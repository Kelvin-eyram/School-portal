Imports System.Data
Imports System.Windows.Forms

Public Class DashboardForm

    Private Const Caption As String = "Dashboard"

    ' Shows the totals on the four summary cards`
    Public Sub RefreshCounts()
        Try
            lblTotalPupils.Text = ToInt(GetValue("SELECT COUNT(*) FROM Pupils")).ToString()
            lblTotalTeachers.Text = ToInt(GetValue("SELECT COUNT(*) FROM Teachers")).ToString()
            lblTotalClasses.Text = ToInt(GetValue("SELECT COUNT(*) FROM Classes")).ToString()
            lblPresentToday.Text = ToInt(GetValue(
                "SELECT COUNT(*) FROM Attendance WHERE AttendanceDate = @d AND Status = 'Present'",
                Param("@d", Date.Today))).ToString()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Hides buttons the signed-in role should not use
    Public Sub ApplyRole()
        Try
            btnUserManagement.Visible = (CurrentRole = "Administrator")
            btnFees.Visible = (CurrentRole = "Administrator" OrElse CurrentRole = "Accountant" OrElse CurrentRole = "Headteacher")
            lblSignedIn.Text = "Signed in as: " & CurrentUser & "  (" & CurrentRole & ")"
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Opens a form on top of the dashboard, then refreshes the totals
    Private Sub OpenForm(f As Form)
        Try
            f.ShowDialog(Me)
        Catch ex As Exception
            ShowError(Caption, ex)
        Finally
            f.Dispose()
        End Try
        RefreshCounts()
    End Sub

    Private Sub btnPupils_Click(sender As Object, e As EventArgs) Handles btnPupils.Click
        Try
            OpenForm(New PupilManagementForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        Try
            OpenForm(New TeacherManagementForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnClasses_Click(sender As Object, e As EventArgs) Handles btnClasses.Click
        Try
            OpenForm(New ClassManagementForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnSubjects_Click(sender As Object, e As EventArgs) Handles btnSubjects.Click
        Try
            OpenForm(New SubjectManagementForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Try
            OpenForm(New AttendanceForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Try
            OpenForm(New ResultsForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnFees_Click(sender As Object, e As EventArgs) Handles btnFees.Click
        Try
            OpenForm(New FeesForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Try
            OpenForm(New ReportsForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnReportCards_Click(sender As Object, e As EventArgs) Handles btnReportCards.Click
        Try
            OpenForm(New ReportCardForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        Try
            OpenForm(New UserManagementForm())
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            CurrentUser = ""
            CurrentRole = ""
            Me.Hide()
            Program.Login.ResetForm()
            Program.Login.Show()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub DashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
