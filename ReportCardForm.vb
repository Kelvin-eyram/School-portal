Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class ReportCardForm

    Private Const Caption As String = "Report card"

    Private pupilID As Integer = 0
    Private classID As Integer = 0

    ' True while the code itself is changing the radio buttons
    Private suppress As Boolean = False

    ' ------------------------------------------------------------------
    ' Helper procedures
    ' ------------------------------------------------------------------

    ' Empties the result boxes
    Private Sub ClearCard()
        suppress = True
        Try
            dgvReportCardSubjects.DataSource = Nothing
            txtTotalScore.Clear()
            txtAverage.Clear()
            txtClassPosition.Clear()
            txtPromotedTo.Clear()
            txtTeacherRemarks.Clear()
            rdoPromoted.Checked = False
            rdoRepeated.Checked = False
        Finally
            suppress = False
        End Try
    End Sub

    ' Finds the name of the class that comes after the pupil's class
    Private Function NextClassName() As String
        If classID = 0 Then Return ""
        Dim nxt As Object = GetValue("SELECT TOP 1 ClassName FROM Classes WHERE ClassID > @c ORDER BY ClassID",
                                     Param("@c", classID))
        Return If(nxt Is Nothing, "Graduated", nxt.ToString())
    End Function

    ' Fills the Promoted to box from the radio button that is ticked
    Private Sub UpdatePromotion()
        If pupilID = 0 Then Return
        If rdoPromoted.Checked Then
            txtPromotedTo.Text = NextClassName()
        ElseIf rdoRepeated.Checked Then
            txtPromotedTo.Text = txtReportClass.Text
        Else
            txtPromotedTo.Clear()
        End If
    End Sub

    ' ------------------------------------------------------------------
    ' Events
    ' ------------------------------------------------------------------

    Private Sub ReportCardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbReportTerm.Items.Clear()
            cmbReportTerm.Items.AddRange(New String() {"Term 1", "Term 2", "Term 3"})
            cmbReportTerm.SelectedIndex = 0
            dgvReportCardSubjects.ReadOnly = True
            dgvReportCardSubjects.AllowUserToAddRows = False
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Typing a pupil ID clears the old card
    Private Sub txtReportPupilID_TextChanged(sender As Object, e As EventArgs) Handles txtReportPupilID.TextChanged
        Try
            pupilID = 0
            classID = 0
            txtReportPupilName.Clear()
            txtReportClass.Clear()
            txtClassPopulation.Clear()
            ClearCard()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Fills the name, class, and the number of pupils in that class (the class population)
    Private Sub btnFindPupil_Click(sender As Object, e As EventArgs) Handles btnFindPupil.Click
        Try
            Dim id As Integer
            If Not Integer.TryParse(txtReportPupilID.Text.Trim(), id) OrElse id <= 0 Then
                ShowWarn(Caption, "Enter a valid pupil ID.")
                Return
            End If

            Dim dt As DataTable = GetTable(
                "SELECT p.FirstName + ' ' + p.LastName AS FullName, p.ClassID, c.ClassName " &
                "FROM Pupils p LEFT JOIN Classes c ON c.ClassID = p.ClassID WHERE p.PupilID = @id",
                Param("@id", id))

            If dt.Rows.Count = 0 Then
                ShowWarn(Caption, "No pupil found with that ID.")
                Return
            End If

            Dim r As DataRow = dt.Rows(0)
            pupilID = id
            classID = ToInt(r("ClassID"))
            txtReportPupilName.Text = r("FullName").ToString()
            txtReportClass.Text = r("ClassName").ToString()
            txtClassPopulation.Text = ToInt(GetValue("SELECT COUNT(*) FROM Pupils WHERE ClassID = @c", Param("@c", classID))).ToString()
            ClearCard()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Lists the pupil's subjects and scores for the term, adds up the total, works out the average,
    ' finds the position in class (equal totals share a position), and decides promotion using PassMark
    Private Sub btnGenerateReportCard_Click(sender As Object, e As EventArgs) Handles btnGenerateReportCard.Click
        Try
            If pupilID = 0 Then
                ShowWarn(Caption, "Find a pupil first.")
                Return
            End If
            If cmbReportTerm.SelectedIndex = -1 Then
                ShowWarn(Caption, "Choose a term.")
                Return
            End If

            Dim dt As DataTable = GetTable(
                "SELECT s.SubjectName AS Subject, r.Score, r.Grade FROM Results r " &
                "INNER JOIN Subjects s ON s.SubjectID = r.SubjectID " &
                "WHERE r.PupilID = @p AND r.Term = @t ORDER BY s.SubjectName",
                Param("@p", pupilID), Param("@t", cmbReportTerm.Text))

            If dt.Rows.Count = 0 Then
                ShowInfo(Caption, "No results are saved for this pupil in " & cmbReportTerm.Text & ".")
                Return
            End If
            dgvReportCardSubjects.DataSource = dt

            ' Total and average
            Dim total As Decimal = 0D
            For Each r As DataRow In dt.Rows
                total += ToDec(r("Score"))
            Next
            Dim average As Decimal = total / dt.Rows.Count
            txtTotalScore.Text = total.ToString("0.#")
            txtAverage.Text = average.ToString("0.0")

            ' Position in class: count the pupils in the class with a higher total
            Dim totals As DataTable = GetTable(
                "SELECT r.PupilID, SUM(r.Score) AS Total FROM Results r " &
                "INNER JOIN Pupils p ON p.PupilID = r.PupilID " &
                "WHERE p.ClassID = @c AND r.Term = @t GROUP BY r.PupilID",
                Param("@c", classID), Param("@t", cmbReportTerm.Text))
            Dim position As Integer = 1
            For Each r As DataRow In totals.Rows
                If ToDec(r("Total")) > total Then position += 1
            Next
            txtClassPosition.Text = Ordinal(position)

            ' Promotion decision (the headteacher can still change it with the radio buttons)
            suppress = True
            Try
                rdoPromoted.Checked = (average >= PassMark)
                rdoRepeated.Checked = (average < PassMark)
            Finally
                suppress = False
            End Try
            UpdatePromotion()
        Catch ex As Exception
            suppress = False
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Because both radio buttons sit in grpPromotion, ticking one unticks the other
    Private Sub rdoPromotion_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPromoted.CheckedChanged, rdoRepeated.CheckedChanged
        If suppress Then Return
        Try
            UpdatePromotion()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnPrintReportCard_Click(sender As Object, e As EventArgs) Handles btnPrintReportCard.Click
        Try
            If dgvReportCardSubjects.Rows.Count = 0 OrElse txtClassPosition.Text = "" Then
                ShowWarn(Caption, "Generate the report card first.")
                Return
            End If
            Using preview As New PrintPreviewDialog()
                preview.Document = PrintDocument1
                preview.WindowState = FormWindowState.Maximized
                preview.ShowDialog(Me)
            End Using
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' What is drawn on the printed report card
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim g As Graphics = e.Graphics
            Using fTitle As New Font("Arial", 18, FontStyle.Bold),
                  fBold As New Font("Arial", 11, FontStyle.Bold),
                  fBody As New Font("Arial", 11)
                Dim x As Single = e.MarginBounds.Left
                Dim y As Single = e.MarginBounds.Top

                g.DrawString("SUNRISE ELEMENTARY SCHOOL", fTitle, Brushes.Black, x, y)
                y += 34
                g.DrawString("STUDENT REPORT CARD - " & cmbReportTerm.Text, fBold, Brushes.Black, x, y)
                y += 36

                g.DrawString("Name: " & txtReportPupilName.Text, fBody, Brushes.Black, x, y)
                y += 22
                g.DrawString("Class: " & txtReportClass.Text & "      Class size: " & txtClassPopulation.Text, fBody, Brushes.Black, x, y)
                y += 34

                g.DrawString("Subject", fBold, Brushes.Black, x, y)
                g.DrawString("Score", fBold, Brushes.Black, x + 260, y)
                g.DrawString("Grade", fBold, Brushes.Black, x + 360, y)
                y += 24

                For Each row As DataGridViewRow In dgvReportCardSubjects.Rows
                    g.DrawString(Convert.ToString(row.Cells("Subject").Value), fBody, Brushes.Black, x, y)
                    g.DrawString(Convert.ToString(row.Cells("Score").Value), fBody, Brushes.Black, x + 260, y)
                    g.DrawString(Convert.ToString(row.Cells("Grade").Value), fBody, Brushes.Black, x + 360, y)
                    y += 22
                Next

                y += 14
                g.DrawString("Total score: " & txtTotalScore.Text & "      Average: " & txtAverage.Text, fBold, Brushes.Black, x, y)
                y += 24
                g.DrawString("Position in class: " & txtClassPosition.Text & " out of " & txtClassPopulation.Text, fBold, Brushes.Black, x, y)
                y += 24

                If rdoPromoted.Checked Then
                    g.DrawString("Promotion: PROMOTED to " & txtPromotedTo.Text, fBold, Brushes.Black, x, y)
                Else
                    g.DrawString("Promotion: REPEATS " & txtReportClass.Text, fBold, Brushes.Black, x, y)
                End If
                y += 34

                g.DrawString("Teacher's remarks:", fBold, Brushes.Black, x, y)
                y += 22
                g.DrawString(txtTeacherRemarks.Text, fBody, Brushes.Black, New RectangleF(x, y, e.MarginBounds.Width, 90))
            End Using
            e.HasMorePages = False
        Catch ex As Exception
            e.HasMorePages = False
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
