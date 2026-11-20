Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class SubjectManagementForm

    Private Const Caption As String = "Subjects"

    ' ------------------------------------------------------------------
    ' Helper procedures
    ' ------------------------------------------------------------------

    Private Sub LoadSubjects()
        dgvSubjects.DataSource = GetTable(
            "SELECT s.SubjectID AS ID, s.SubjectName AS Subject, s.Code, c.ClassName AS Class, " &
            "t.FirstName + ' ' + ISNULL(t.LastName, '') AS Teacher " &
            "FROM Subjects s LEFT JOIN Classes c ON c.ClassID = s.ClassID " &
            "LEFT JOIN Teachers t ON t.TeacherID = s.TeacherID ORDER BY c.ClassName, s.SubjectName")
    End Sub

    Private Sub ClearForm()
        txtSubjectID.Clear()
        txtSubjectName.Clear()
        txtCode.Clear()
        cmbClass.SelectedIndex = -1
        cmbTeacher.SelectedIndex = -1
        txtSubjectName.Focus()
    End Sub

    Private Function ValidateInput() As Boolean
        If txtSubjectName.Text.Trim() = "" Then
            ShowWarn(Caption, "Enter the subject name.")
            Return False
        End If
        If cmbClass.SelectedIndex = -1 Then
            ShowWarn(Caption, "Choose the class for this subject.")
            Return False
        End If
        Return True
    End Function

    Private Function TryGetSelectedId(ByRef id As Integer) As Boolean
        If Not Integer.TryParse(txtSubjectID.Text, id) OrElse id <= 0 Then
            ShowWarn(Caption, "Click a subject in the table first.")
            Return False
        End If
        Return True
    End Function

    ' ------------------------------------------------------------------
    ' Events
    ' ------------------------------------------------------------------

    Private Sub SubjectManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbClass, "SELECT ClassID, ClassName FROM Classes ORDER BY ClassName", "ClassName", "ClassID")
            FillCombo(cmbTeacher,
                      "SELECT TeacherID, FirstName + ' ' + ISNULL(LastName, '') AS FullName FROM Teachers ORDER BY FirstName",
                      "FullName", "TeacherID")
            LoadSubjects()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not ValidateInput() Then Return
            RunCommand("INSERT INTO Subjects (SubjectName, Code, ClassID, TeacherID) VALUES (@n, @code, @c, @t)",
                       Param("@n", txtSubjectName.Text.Trim()), Param("@code", txtCode.Text.Trim()),
                       Param("@c", ComboValue(cmbClass)), Param("@t", ComboValue(cmbTeacher)))
            ClearForm()
            LoadSubjects()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            If Not ValidateInput() Then Return
            RunCommand("UPDATE Subjects SET SubjectName=@n, Code=@code, ClassID=@c, TeacherID=@t WHERE SubjectID=@id",
                       Param("@n", txtSubjectName.Text.Trim()), Param("@code", txtCode.Text.Trim()),
                       Param("@c", ComboValue(cmbClass)), Param("@t", ComboValue(cmbTeacher)),
                       Param("@id", id))
            ClearForm()
            LoadSubjects()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            If Not Confirm("Confirm delete", "Delete this subject and its saved scores?") Then Return
            RunCommand("DELETE FROM Results WHERE SubjectID = @id", Param("@id", id))
            RunCommand("DELETE FROM Subjects WHERE SubjectID = @id", Param("@id", id))
            ClearForm()
            LoadSubjects()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ClearForm()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Copies the clicked subject into the input boxes so it can be edited
    Private Sub dgvSubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        Try
            If e.RowIndex < 0 Then Return
            Dim id As Integer
            If Not Integer.TryParse(Convert.ToString(dgvSubjects.Rows(e.RowIndex).Cells("ID").Value), id) Then Return
            Dim dt As DataTable = GetTable("SELECT * FROM Subjects WHERE SubjectID = @id", Param("@id", id))
            If dt.Rows.Count = 0 Then Return
            Dim r As DataRow = dt.Rows(0)
            txtSubjectID.Text = r("SubjectID").ToString()
            txtSubjectName.Text = r("SubjectName").ToString()
            txtCode.Text = r("Code").ToString()
            SelectCombo(cmbClass, r("ClassID"))
            SelectCombo(cmbTeacher, r("TeacherID"))
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
