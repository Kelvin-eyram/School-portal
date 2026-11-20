Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class AttendanceForm

    Private Const Caption As String = "Attendance"

    ' True while the code itself is filling or changing the grid
    Private busy As Boolean = False

    ' Returns True when a check-box cell is ticked
    Private Function IsTicked(cell As DataGridViewCell) As Boolean
        Dim b As Boolean
        If cell.Value Is Nothing Then Return False
        Return Boolean.TryParse(Convert.ToString(cell.Value), b) AndAlso b
    End Function

    ' Sets the button colours, fills the class list, and builds the table columns
    Private Sub AttendanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            btnLoadClass.BackColor = Color.SeaGreen
            btnLoadClass.ForeColor = Color.White
            btnSaveAttendance.BackColor = Color.Firebrick
            btnSaveAttendance.ForeColor = Color.White
            btnSaveAttendance.Enabled = False

            FillCombo(cmbAttendanceClass, "SELECT ClassID, ClassName FROM Classes ORDER BY ClassName", "ClassName", "ClassID")

            dgvAttendance.AllowUserToAddRows = False
            dgvAttendance.Columns.Clear()
            dgvAttendance.Columns.Add("colID", "Student ID")
            dgvAttendance.Columns.Add("colName", "Student Name")

            Dim present As New DataGridViewCheckBoxColumn()
            present.Name = "colPresent"
            present.HeaderText = "Present"
            dgvAttendance.Columns.Add(present)

            Dim absent As New DataGridViewCheckBoxColumn()
            absent.Name = "colAbsent"
            absent.HeaderText = "Absent"
            dgvAttendance.Columns.Add(absent)

            dgvAttendance.Columns.Add("colNotes", "Notes")
            dgvAttendance.Columns("colID").ReadOnly = True
            dgvAttendance.Columns("colName").ReadOnly = True
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Lists every pupil in the class and shows any attendance already saved for the chosen date
    Private Sub btnLoadClass_Click(sender As Object, e As EventArgs) Handles btnLoadClass.Click
        Try
            If cmbAttendanceClass.SelectedIndex = -1 Then
                ShowWarn(Caption, "Choose a class first.")
                Return
            End If

            Dim dt As DataTable = GetTable(
                "SELECT p.PupilID, p.FirstName + ' ' + p.LastName AS FullName, a.Status, a.Notes " &
                "FROM Pupils p LEFT JOIN Attendance a ON a.PupilID = p.PupilID AND a.AttendanceDate = @d " &
                "WHERE p.ClassID = @c ORDER BY p.FirstName",
                Param("@d", dtpAttendanceDate.Value.Date), Param("@c", ComboValue(cmbAttendanceClass)))

            busy = True
            Try
                dgvAttendance.Rows.Clear()
                For Each r As DataRow In dt.Rows
                    Dim status As String = If(IsDBNull(r("Status")), "Present", r("Status").ToString())
                    dgvAttendance.Rows.Add(r("PupilID"), r("FullName"), status = "Present", status = "Absent", r("Notes").ToString())
                Next
            Finally
                busy = False
            End Try

            btnSaveAttendance.Enabled = (dgvAttendance.Rows.Count > 0)
            If dgvAttendance.Rows.Count = 0 Then
                ShowInfo(Caption, "There are no pupils in this class yet.")
            End If
        Catch ex As Exception
            busy = False
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Makes a ticked box register straight away
    Private Sub dgvAttendance_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvAttendance.CurrentCellDirtyStateChanged
        Try
            If dgvAttendance.IsCurrentCellDirty Then
                dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Only one of Present or Absent can be ticked: unticks the other box in the same row
    Private Sub dgvAttendance_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellValueChanged
        If busy OrElse e.RowIndex < 0 Then Return
        Try
            Dim row As DataGridViewRow = dgvAttendance.Rows(e.RowIndex)
            busy = True
            Try
                If e.ColumnIndex = row.Cells("colPresent").ColumnIndex AndAlso IsTicked(row.Cells("colPresent")) Then
                    row.Cells("colAbsent").Value = False
                ElseIf e.ColumnIndex = row.Cells("colAbsent").ColumnIndex AndAlso IsTicked(row.Cells("colAbsent")) Then
                    row.Cells("colPresent").Value = False
                End If
            Finally
                busy = False
            End Try
        Catch ex As Exception
            busy = False
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub dgvAttendance_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvAttendance.DataError
        e.ThrowException = False
    End Sub

    ' Replaces any earlier marks for the same pupils and date, so saving twice never creates duplicates
    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        Try
            dgvAttendance.EndEdit()
            Dim saved As Integer = 0
            For Each row As DataGridViewRow In dgvAttendance.Rows
                Dim pupilId As Integer
                If Not Integer.TryParse(Convert.ToString(row.Cells("colID").Value), pupilId) Then Continue For
                Dim status As String = If(IsTicked(row.Cells("colPresent")), "Present", "Absent")
                Dim notes As String = If(row.Cells("colNotes").Value Is Nothing, "", row.Cells("colNotes").Value.ToString())

                RunCommand("DELETE FROM Attendance WHERE PupilID = @p AND AttendanceDate = @d",
                           Param("@p", pupilId), Param("@d", dtpAttendanceDate.Value.Date))
                RunCommand("INSERT INTO Attendance (PupilID, AttendanceDate, Status, Notes) VALUES (@p, @d, @s, @n)",
                           Param("@p", pupilId), Param("@d", dtpAttendanceDate.Value.Date),
                           Param("@s", status), Param("@n", notes))
                saved += 1
            Next
            ShowInfo(Caption, "Attendance saved for " & saved.ToString() & " pupil(s).")
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
