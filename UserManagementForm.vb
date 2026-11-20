Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class UserManagementForm

    Private Const Caption As String = "Users"

    ' Remembers the user clicked in the table
    Private selectedUserID As Integer = 0

    Private Sub LoadUsers()
        dgvSystemUsers.DataSource = GetTable(
            "SELECT UserID AS ID, Username, Role, " &
            "CASE WHEN IsActive = 1 THEN 'Active' ELSE 'Revoked' END AS Status " &
            "FROM Users ORDER BY UserID")
    End Sub

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        Try
            cmbSystemRole.Items.Clear()
            cmbSystemRole.Items.AddRange(New String() {"Administrator", "Teacher", "Headteacher", "Accountant"})
            txtSystemPassword.UseSystemPasswordChar = True
            LoadUsers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Checks the username is at least 3 characters, the password at least 6, a role is chosen,
    ' and the username is not already taken. The password is stored as a hash.
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Try
            Dim name As String = txtSystemUsername.Text.Trim()
            If name.Length < 3 Then
                ShowWarn(Caption, "The username must have at least 3 characters.")
                Return
            End If
            If txtSystemPassword.Text.Length < 6 Then
                ShowWarn(Caption, "The password must have at least 6 characters.")
                Return
            End If
            If cmbSystemRole.SelectedIndex = -1 Then
                ShowWarn(Caption, "Choose a role.")
                Return
            End If
            If ToInt(GetValue("SELECT COUNT(*) FROM Users WHERE Username = @u", Param("@u", name))) > 0 Then
                ShowWarn(Caption, "That username is already taken.")
                Return
            End If

            RunCommand("INSERT INTO Users (Username, PasswordHash, Role, IsActive) VALUES (@u, @p, @r, 1)",
                       Param("@u", name), Param("@p", HashPassword(txtSystemPassword.Text)),
                       Param("@r", cmbSystemRole.Text))
            txtSystemUsername.Clear()
            txtSystemPassword.Clear()
            cmbSystemRole.SelectedIndex = -1
            selectedUserID = 0
            LoadUsers()
            ShowInfo(Caption, "User created.")
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnModifyRole_Click(sender As Object, e As EventArgs) Handles btnModifyRole.Click
        Try
            If selectedUserID = 0 Then
                ShowWarn(Caption, "Click a user in the table first.")
                Return
            End If
            If cmbSystemRole.SelectedIndex = -1 Then
                ShowWarn(Caption, "Choose the new role.")
                Return
            End If
            If txtSystemUsername.Text = CurrentUser AndAlso cmbSystemRole.Text <> "Administrator" Then
                ShowWarn(Caption, "You cannot remove the Administrator role from the account you are signed in with.")
                Return
            End If
            RunCommand("UPDATE Users SET Role = @r WHERE UserID = @id",
                       Param("@r", cmbSystemRole.Text), Param("@id", selectedUserID))
            LoadUsers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnRevokeUser_Click(sender As Object, e As EventArgs) Handles btnRevokeUser.Click
        Try
            If selectedUserID = 0 Then
                ShowWarn(Caption, "Click a user in the table first.")
                Return
            End If
            If txtSystemUsername.Text = CurrentUser Then
                ShowWarn(Caption, "You cannot revoke the account you are signed in with.")
                Return
            End If
            If Not Confirm("Confirm", "Revoke access for " & txtSystemUsername.Text & "?") Then Return
            RunCommand("UPDATE Users SET IsActive = 0 WHERE UserID = @id", Param("@id", selectedUserID))
            LoadUsers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnReactivateUser_Click(sender As Object, e As EventArgs) Handles btnReactivateUser.Click
        Try
            If selectedUserID = 0 Then
                ShowWarn(Caption, "Click a user in the table first.")
                Return
            End If
            RunCommand("UPDATE Users SET IsActive = 1 WHERE UserID = @id", Param("@id", selectedUserID))
            LoadUsers()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Copies the clicked user into the boxes. The password box is always left empty for safety.
    Private Sub dgvSystemUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSystemUsers.CellClick
        Try
            If e.RowIndex < 0 Then Return
            Dim row As DataGridViewRow = dgvSystemUsers.Rows(e.RowIndex)
            Dim id As Integer
            If Not Integer.TryParse(Convert.ToString(row.Cells("ID").Value), id) Then Return
            selectedUserID = id
            txtSystemUsername.Text = Convert.ToString(row.Cells("Username").Value)
            SelectCombo(cmbSystemRole, row.Cells("Role").Value)
            txtSystemPassword.Clear()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
