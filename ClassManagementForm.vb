Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class ClassManagementForm

    Private Const Caption As String = "Classes"

    ' ------------------------------------------------------------------
    ' Helper procedures
    ' ------------------------------------------------------------------

    Private Sub LoadClasses()
        dgvClasses.DataSource = GetTable(
            "SELECT c.ClassID AS [Class ID], c.ClassName AS [Class Name], " &
            "t.FirstName + ' ' + ISNULL(t.LastName, '') AS Teacher, c.Capacity, " &
            "(SELECT COUNT(*) FROM Pupils p WHERE p.ClassID = c.ClassID) AS [Current Count] " &
            "FROM Classes c LEFT JOIN Teachers t ON t.TeacherID = c.TeacherID ORDER BY c.ClassID")
    End Sub

    Private Sub ClearForm()
        txtClassID.Clear()
        txtClassName.Clear()
        txtCapacity.Clear()
        cmbClassTeacher.SelectedIndex = -1
        txtClassName.Focus()
    End Sub

    Private Function ValidateInput(ByRef capacity As Integer) As Boolean
        If txtClassName.Text.Trim() = "" Then
            ShowWarn(Caption, "Enter the class name.")
            Return False
        End If
        If Not Integer.TryParse(txtCapacity.Text.Trim(), capacity) OrElse capacity <= 0 Then
            ShowWarn(Caption, "Capacity must be a whole number greater than zero.")
            Return False
        End If
        Return True
    End Function

    Private Function TryGetSelectedId(ByRef id As Integer) As Boolean
        If Not Integer.TryParse(txtClassID.Text, id) OrElse id <= 0 Then
            ShowWarn(Caption, "Click a class in the table first.")
            Return False
        End If
        Return True
    End Function

    ' ------------------------------------------------------------------
    ' Events
    ' ------------------------------------------------------------------

    Private Sub ClassManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillCombo(cmbClassTeacher,
                      "SELECT TeacherID, FirstName + ' ' + ISNULL(LastName, '') AS FullName FROM Teachers ORDER BY FirstName",
                      "FullName", "TeacherID")
            LoadClasses()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnAddClass_Click(sender As Object, e As EventArgs) Handles btnAddClass.Click
        Try
            Dim capacity As Integer
            If Not ValidateInput(capacity) Then Return
            RunCommand("INSERT INTO Classes (ClassName, Capacity, TeacherID) VALUES (@n, @cap, @t)",
                       Param("@n", txtClassName.Text.Trim()), Param("@cap", capacity),
                       Param("@t", ComboValue(cmbClassTeacher)))
            ClearForm()
            LoadClasses()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnUpdateClass_Click(sender As Object, e As EventArgs) Handles btnUpdateClass.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            Dim capacity As Integer
            If Not ValidateInput(capacity) Then Return
            RunCommand("UPDATE Classes SET ClassName=@n, Capacity=@cap, TeacherID=@t WHERE ClassID=@id",
                       Param("@n", txtClassName.Text.Trim()), Param("@cap", capacity),
                       Param("@t", ComboValue(cmbClassTeacher)), Param("@id", id))
            ClearForm()
            LoadClasses()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Delete refuses to remove a class that still has pupils
    Private Sub btnDeleteClass_Click(sender As Object, e As EventArgs) Handles btnDeleteClass.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            If ToInt(GetValue("SELECT COUNT(*) FROM Pupils WHERE ClassID = @id", Param("@id", id))) > 0 Then
                ShowWarn(Caption, "This class still has pupils. Move them to another class first.")
                Return
            End If
            If Not Confirm("Confirm delete", "Delete this class?") Then Return
            RunCommand("DELETE FROM Classes WHERE ClassID = @id", Param("@id", id))
            ClearForm()
            LoadClasses()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnRefreshClasses_Click(sender As Object, e As EventArgs) Handles btnRefreshClasses.Click
        Try
            ClearForm()
            LoadClasses()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Copies the clicked class into the input boxes so it can be edited
    Private Sub dgvClasses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClasses.CellClick
        Try
            If e.RowIndex < 0 Then Return
            Dim id As Integer
            If Not Integer.TryParse(Convert.ToString(dgvClasses.Rows(e.RowIndex).Cells("Class ID").Value), id) Then Return
            Dim dt As DataTable = GetTable("SELECT * FROM Classes WHERE ClassID = @id", Param("@id", id))
            If dt.Rows.Count = 0 Then Return
            Dim r As DataRow = dt.Rows(0)
            txtClassID.Text = r("ClassID").ToString()
            txtClassName.Text = r("ClassName").ToString()
            txtCapacity.Text = r("Capacity").ToString()
            SelectCombo(cmbClassTeacher, r("TeacherID"))
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Capacity accepts digits only
    Private Sub txtCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

End Class
