Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class ReportsForm

    Private Const Caption As String = "Reports"

    ' Remembers which row to print next
    Private printRow As Integer = 0

    Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbReportType.Items.Clear()
            cmbReportType.Items.AddRange(New String() {"Pupil Roster", "Fees Ledger", "Report Card"})
            cmbReportType.SelectedIndex = 0
            dtpReportStart.Value = Date.Today.AddMonths(-1)
            dtpReportEnd.Value = Date.Today
            dgvReportSummary.ReadOnly = True
            dgvReportSummary.AllowUserToAddRows = False
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Pupil Roster lists all pupils. Fees Ledger lists payments received between the two dates.
    ' Report Card shows each pupil's total and average across all saved results.
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            If cmbReportType.SelectedIndex = -1 Then
                ShowWarn(Caption, "Choose a report type.")
                Return
            End If
            If dtpReportEnd.Value.Date < dtpReportStart.Value.Date Then
                ShowWarn(Caption, "The end date cannot be earlier than the start date.")
                Return
            End If

            Dim startDate As Date = dtpReportStart.Value.Date
            Dim endDate As Date = dtpReportEnd.Value.Date.AddDays(1)
            Dim dt As DataTable = Nothing

            Select Case cmbReportType.Text
                Case "Pupil Roster"
                    dt = GetTable(
                        "SELECT p.PupilID AS ID, p.FirstName + ' ' + p.LastName AS [Pupil Name], " &
                        "c.ClassName AS Class, p.Gender " &
                        "FROM Pupils p LEFT JOIN Classes c ON c.ClassID = p.ClassID ORDER BY c.ClassName, p.FirstName")
                Case "Fees Ledger"
                    dt = GetTable(
                        "SELECT p.PupilID AS ID, p.FirstName + ' ' + p.LastName AS [Pupil Name], " &
                        "p.TotalFees AS [Total Fees], ISNULL(SUM(pay.Amount), 0) AS [Paid In Period] " &
                        "FROM Pupils p LEFT JOIN Payments pay ON pay.PupilID = p.PupilID " &
                        "AND pay.PaymentDate >= @s AND pay.PaymentDate < @e " &
                        "GROUP BY p.PupilID, p.FirstName, p.LastName, p.TotalFees ORDER BY p.FirstName",
                        Param("@s", startDate), Param("@e", endDate))
                Case Else
                    dt = GetTable(
                        "SELECT p.PupilID AS ID, p.FirstName + ' ' + p.LastName AS [Pupil Name], " &
                        "c.ClassName AS Class, SUM(r.Score) AS Total, CAST(AVG(r.Score) AS DECIMAL(5,1)) AS Average " &
                        "FROM Pupils p INNER JOIN Results r ON r.PupilID = p.PupilID " &
                        "LEFT JOIN Classes c ON c.ClassID = p.ClassID " &
                        "GROUP BY p.PupilID, p.FirstName, p.LastName, c.ClassName ORDER BY c.ClassName, SUM(r.Score) DESC")
            End Select

            dgvReportSummary.DataSource = dt
            If dt.Rows.Count = 0 Then
                ShowInfo(Caption, "No records found for this report.")
            End If
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Opens a print preview window, and the Print button inside it sends the report to the printer
    Private Sub btnPrintReport_Click(sender As Object, e As EventArgs) Handles btnPrintReport.Click
        Try
            If dgvReportSummary.Rows.Count = 0 Then
                ShowWarn(Caption, "Generate a report first.")
                Return
            End If
            printRow = 0
            Using preview As New PrintPreviewDialog()
                preview.Document = PrintDocument1
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog(Me)
            End Using
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Prints a title, the column headings, then as many rows as fit on the page, and continues on the next page
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim colCount As Integer = dgvReportSummary.Columns.Count
            If colCount = 0 Then
                e.HasMorePages = False
                Return
            End If

            Using fTitle As New Font("Arial", 16, FontStyle.Bold),
                  fHead As New Font("Arial", 10, FontStyle.Bold),
                  fBody As New Font("Arial", 10)
                Dim x As Single = e.MarginBounds.Left
                Dim y As Single = e.MarginBounds.Top
                Dim colWidth As Single = e.MarginBounds.Width / colCount

                e.Graphics.DrawString("Sunrise Elementary School - " & cmbReportType.Text, fTitle, Brushes.Black, x, y)
                y += 40

                For i As Integer = 0 To colCount - 1
                    e.Graphics.DrawString(dgvReportSummary.Columns(i).HeaderText, fHead, Brushes.Black, x + i * colWidth, y)
                Next
                y += 24

                Do While printRow < dgvReportSummary.Rows.Count
                    If y > e.MarginBounds.Bottom - 20 Then
                        e.HasMorePages = True
                        Return
                    End If
                    For i As Integer = 0 To colCount - 1
                        Dim text As String = Convert.ToString(dgvReportSummary.Rows(printRow).Cells(i).Value)
                        e.Graphics.DrawString(text, fBody, Brushes.Black, x + i * colWidth, y)
                    Next
                    y += 20
                    printRow += 1
                Loop
                e.HasMorePages = False
            End Using
        Catch ex As Exception
            e.HasMorePages = False
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
