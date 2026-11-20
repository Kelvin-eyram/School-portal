Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class TeacherManagementForm

    Private Const Caption As String = "Teachers"

    ' ------------------------------------------------------------------
    ' Helper procedures
    ' ------------------------------------------------------------------

    Private Sub LoadTeachers(Optional filter As String = "")
        Dim sql As String =
            "SELECT t.TeacherID AS ID, t.FirstName AS [First Name], t.LastName AS [Last Name], " &
            "t.Phone, t.Email, t.Gender, t.SubjectTaught AS Subject, c.ClassName AS Class " &
            "FROM Teachers t LEFT JOIN Classes c ON c.ClassID = t.ClassID"
        If filter = "" Then
            dgvTeachers.DataSource = GetTable(sql & " ORDER BY t.TeacherID")
        Else
            dgvTeachers.DataSource = GetTable(
                sql & " WHERE t.FirstName LIKE @f OR t.LastName LIKE @f OR t.Phone LIKE @f ORDER BY t.TeacherID",
                Param("@f", "%" & filter & "%"))
        End If
    End Sub

    Private Sub ClearForm()
        txtTeacherID.Clear()
        txtTeacherFirstName.Clear()
        txtTeacherLastName.Clear()
        txtTeacherPhone.Clear()
        txtTeacherEmail.Clear()
        cmbTeacherGender.SelectedIndex = -1
        cmbSubjectTaught.SelectedIndex = -1
        cmbClassAssigned.SelectedIndex = -1
        txtTeacherFirstName.Focus()
    End Sub

    Private Function ValidateInput() As Boolean
        If txtTeacherFirstName.Text.Trim() = "" Then
            ShowWarn(Caption, "The teacher's first name is required.")
            Return False
        End If
        Dim email As String = txtTeacherEmail.Text.Trim()
        If email <> "" Then
            Dim at As Integer = email.IndexOf("@"c)
            If at < 1 OrElse email.IndexOf("."c, at) < at + 2 OrElse email.EndsWith(".") Then
                ShowWarn(Caption, "Enter a valid email address.")
                Return False
            End If
        End If
        Return True
    End Function

    Private Function TryGetSelectedId(ByRef id As Integer) As Boolean
        If Not Integer.TryParse(txtTeacherID.Text, id) OrElse id <= 0 Then
            ShowWarn(Caption, "Click a teacher in the table first.")
            Return False
        End If
        Return True
    End Function

    ' ------------------------------------------------------------------
    ' Events
    ' ------------------------------------------------------------------

    Private Sub TeacherManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbTeacherGender.Items.Clear()
            cmbTeacherGender.Items.AddRange(New String() {"Male", "Female"})
            FillCombo(cmbSubjectTaught, "SELECT DISTINCT SubjectName FROM Subjects ORDER BY SubjectName", "SubjectName", "SubjectName")
            FillCombo(cmbClassAssigned, "SELECT ClassID, ClassName FROM Classes ORDER BY ClassName", "ClassName", "ClassID")
            LoadTeachers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not ValidateInput() Then Return
            RunCommand(
                "INSERT INTO Teachers (FirstName, LastName, Gender, Phone, Email, SubjectTaught, ClassID) " &
                "VALUES (@fn, @ln, @g, @ph, @em, @s, @c)",
                Param("@fn", txtTeacherFirstName.Text.Trim()), Param("@ln", txtTeacherLastName.Text.Trim()),
                Param("@g", If(cmbTeacherGender.SelectedIndex = -1, Nothing, cmbTeacherGender.Text)),
                Param("@ph", txtTeacherPhone.Text.Trim()), Param("@em", txtTeacherEmail.Text.Trim()),
                Param("@s", ComboValue(cmbSubjectTaught)), Param("@c", ComboValue(cmbClassAssigned)))
            ShowInfo(Caption, "Teacher added.")
            ClearForm()
            LoadTeachers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            If Not ValidateInput() Then Return
            RunCommand(
                "UPDATE Teachers SET FirstName=@fn, LastName=@ln, Gender=@g, Phone=@ph, Email=@em, " &
                "SubjectTaught=@s, ClassID=@c WHERE TeacherID=@id",
                Param("@fn", txtTeacherFirstName.Text.Trim()), Param("@ln", txtTeacherLastName.Text.Trim()),
                Param("@g", If(cmbTeacherGender.SelectedIndex = -1, Nothing, cmbTeacherGender.Text)),
                Param("@ph", txtTeacherPhone.Text.Trim()), Param("@em", txtTeacherEmail.Text.Trim()),
                Param("@s", ComboValue(cmbSubjectTaught)), Param("@c", ComboValue(cmbClassAssigned)),
                Param("@id", id))
            ShowInfo(Caption, "Teacher updated.")
            ClearForm()
            LoadTeachers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            If Not Confirm("Confirm delete", "Delete this teacher?") Then Return
            RunCommand("UPDATE Classes SET TeacherID = NULL WHERE TeacherID = @id", Param("@id", id))
            RunCommand("UPDATE Subjects SET TeacherID = NULL WHERE TeacherID = @id", Param("@id", id))
            RunCommand("DELETE FROM Teachers WHERE TeacherID = @id", Param("@id", id))
            ClearForm()
            LoadTeachers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim text As String = txtTeacherFirstName.Text.Trim()
            If text = "" Then text = txtTeacherLastName.Text.Trim()
            If text = "" Then text = txtTeacherPhone.Text.Trim()
            LoadTeachers(text)
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ClearForm()
            LoadTeachers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Copies the clicked teacher into the input boxes so they can be edited
    Private Sub dgvTeachers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeachers.CellClick
        Try
            If e.RowIndex < 0 Then Return
            Dim id As Integer
            If Not Integer.TryParse(Convert.ToString(dgvTeachers.Rows(e.RowIndex).Cells("ID").Value), id) Then Return
            Dim dt As DataTable = GetTable("SELECT * FROM Teachers WHERE TeacherID = @id", Param("@id", id))
            If dt.Rows.Count = 0 Then Return
            Dim r As DataRow = dt.Rows(0)
            txtTeacherID.Text = r("TeacherID").ToString()
            txtTeacherFirstName.Text = r("FirstName").ToString()
            txtTeacherLastName.Text = r("LastName").ToString()
            txtTeacherPhone.Text = r("Phone").ToString()
            txtTeacherEmail.Text = r("Email").ToString()
            SelectCombo(cmbTeacherGender, r("Gender"))
            SelectCombo(cmbSubjectTaught, r("SubjectTaught"))
            SelectCombo(cmbClassAssigned, r("ClassID"))
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Phone number accepts digits only
    Private Sub txtTeacherPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTeacherPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

End Class
