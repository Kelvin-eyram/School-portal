Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class ResultsForm

    Private Const Caption As String = "Results"

    ' True while the code itself is filling the drop-down lists
    Private loading As Boolean = False

    ' Fills the table with the pupils of the chosen class and any scores already saved
    Private Sub LoadScores()
        If cmbResultsClass.SelectedIndex = -1 OrElse cmbResultsSubject.SelectedIndex = -1 OrElse cmbTerm.SelectedIndex = -1 Then Return

        dgvScoresGrid.DataSource = GetTable(
            "SELECT p.PupilID AS ID, p.FirstName + ' ' + p.LastName AS [Pupil Name], r.Score, r.Grade " &
            "FROM Pupils p LEFT JOIN Results r ON r.PupilID = p.PupilID AND r.SubjectID = @s AND r.Term = @t " &
            "WHERE p.ClassID = @c ORDER BY p.FirstName",
            Param("@s", ComboValue(cmbResultsSubject)), Param("@t", cmbTerm.Text),
            Param("@c", ComboValue(cmbResultsClass)))

        ' Only the Score column can be typed into
        dgvScoresGrid.ReadOnly = False
        For Each col As DataGridViewColumn In dgvScoresGrid.Columns
            col.ReadOnly = (col.Name <> "Score")
        Next
    End Sub

    Private Sub ResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading = True
        Try
            FillCombo(cmbResultsClass, "SELECT ClassID, ClassName FROM Classes ORDER BY ClassName", "ClassName", "ClassID")
            cmbTerm.Items.Clear()
            cmbTerm.Items.AddRange(New String() {"Term 1", "Term 2", "Term 3"})
            cmbTerm.SelectedIndex = 0
            dgvScoresGrid.AllowUserToAddRows = False
        Catch ex As Exception
            ShowError(Caption, ex)
        Finally
            loading = False
        End Try
    End Sub

    ' Choosing a class lists that class's subjects
    Private Sub cmbResultsClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResultsClass.SelectedIndexChanged
        If loading OrElse cmbResultsClass.SelectedIndex = -1 Then Return
        loading = True
        Try
            FillCombo(cmbResultsSubject,
                      "SELECT SubjectID, SubjectName FROM Subjects WHERE ClassID = @c ORDER BY SubjectName",
                      "SubjectName", "SubjectID", Param("@c", ComboValue(cmbResultsClass)))
            dgvScoresGrid.DataSource = Nothing
        Catch ex As Exception
            ShowError(Caption, ex)
        Finally
            loading = False
        End Try
    End Sub

    ' Choosing a subject or term loads the scores
    Private Sub cmbResultsSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResultsSubject.SelectedIndexChanged
        If loading Then Return
        Try
            LoadScores()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub cmbTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTerm.SelectedIndexChanged
        If loading Then Return
        Try
            LoadScores()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Only scores from 0 to 100 are accepted
    Private Sub dgvScoresGrid_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvScoresGrid.CellValidating
        Try
            If dgvScoresGrid.Columns(e.ColumnIndex).Name <> "Score" Then Return
            Dim text As String = Convert.ToString(e.FormattedValue).Trim()
            If text = "" Then Return
            Dim value As Decimal
            If Not Decimal.TryParse(text, value) OrElse value < 0D OrElse value > 100D Then
                ShowWarn(Caption, "Enter a score between 0 and 100.")
                e.Cancel = True
            End If
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub dgvScoresGrid_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvScoresGrid.DataError
        e.ThrowException = False
        e.Cancel = False
    End Sub

    ' Works out each grade (A to F), saves the scores, and shows the grades in the table
    Private Sub btnCalculateAndSave_Click(sender As Object, e As EventArgs) Handles btnCalculateAndSave.Click
        Try
            dgvScoresGrid.EndEdit()
            If cmbResultsClass.SelectedIndex = -1 OrElse cmbResultsSubject.SelectedIndex = -1 OrElse cmbTerm.SelectedIndex = -1 Then
                ShowWarn(Caption, "Choose a class, subject and term first.")
                Return
            End If

            Dim subjectId As Object = ComboValue(cmbResultsSubject)
            Dim saved As Integer = 0
            For Each row As DataGridViewRow In dgvScoresGrid.Rows
                Dim raw As Object = row.Cells("Score").Value
                If raw Is Nothing OrElse IsDBNull(raw) OrElse raw.ToString().Trim() = "" Then Continue For

                Dim score As Decimal
                If Not Decimal.TryParse(raw.ToString(), score) OrElse score < 0D OrElse score > 100D Then
                    ShowWarn(Caption, "The score for " & Convert.ToString(row.Cells("Pupil Name").Value) & " must be between 0 and 100.")
                    Return
                End If
                Dim pupilId As Integer
                If Not Integer.TryParse(Convert.ToString(row.Cells("ID").Value), pupilId) Then Continue For
                Dim grade As String = GradeFor(score)

                RunCommand("DELETE FROM Results WHERE PupilID = @p AND SubjectID = @s AND Term = @t",
                           Param("@p", pupilId), Param("@s", subjectId), Param("@t", cmbTerm.Text))
                RunCommand("INSERT INTO Results (PupilID, SubjectID, Term, Score, Grade) VALUES (@p, @s, @t, @sc, @g)",
                           Param("@p", pupilId), Param("@s", subjectId),
                           Param("@t", cmbTerm.Text), Param("@sc", score), Param("@g", grade))
                row.Cells("Grade").Value = grade
                saved += 1
            Next
            ShowInfo(Caption, saved.ToString() & " score(s) saved.")
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
