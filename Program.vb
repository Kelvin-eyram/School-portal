Imports System.Threading
Imports System.Windows.Forms

''' <summary>
''' Application entry point. Holds the two long-lived forms (login and dashboard).
''' </summary>
Module Program

    Public Login As LoginForm
    Public Dashboard As DashboardForm

    <STAThread()>
    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler Application.ThreadException,
            Sub(sender As Object, e As ThreadExceptionEventArgs)
                ShowError("Unexpected error", e.Exception)
            End Sub

        Login = New LoginForm()
        Dashboard = New DashboardForm()
        Application.Run(Login)
    End Sub

End Module
