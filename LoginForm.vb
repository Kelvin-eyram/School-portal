Imports System.Data
Imports System.Windows.Forms

Public Class LoginForm

    Private Const Caption As String = "Login"

    ' Clears the boxes so the next person can sign in
    Public Sub ResetForm()
        Try
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Creates the database (first run), the first administrator, and focuses the username box
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EnsureDatabase()
            EnsureAdmin()
        Catch ex As Exception
            MessageBox.Show("Cannot connect to the database. Make sure SQL Server Express LocalDB is installed." &
                            Environment.NewLine & Environment.NewLine & ex.Message,
                            "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" Then
                ShowWarn(Caption, "Enter your username and password.")
                Return
            End If

            Dim dt As DataTable = GetTable(
                "SELECT Role FROM Users WHERE Username = @u AND PasswordHash = @p AND IsActive = 1",
                Param("@u", txtUsername.Text.Trim()),
                Param("@p", HashPassword(txtPassword.Text)))

            If dt.Rows.Count = 1 Then
                CurrentUser = txtUsername.Text.Trim()
                CurrentRole = dt.Rows(0)("Role").ToString()
                txtPassword.Clear()
                Me.Hide()
                Program.Dashboard.ApplyRole()
                Program.Dashboard.RefreshCounts()
                Program.Dashboard.Show()
            Else
                MessageBox.Show("Wrong username or password, or the account has been revoked.",
                                "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            Application.Exit()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
