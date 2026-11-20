Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class PupilManagementForm

    Private Const Caption As String = "Pupils"

    ' ------------------------------------------------------------------
    ' Helper procedures
    ' ------------------------------------------------------------------

    ' Shows pupils in the table (optionally filtered by a name or ID)
    Private Sub LoadPupils(Optional filter As String = "")
        Dim sql As String =
            "SELECT p.PupilID AS ID, p.FirstName AS [First Name], p.LastName AS [Last Name], " &
            "p.Gender, c.ClassName AS Class, p.DOB " &
            "FROM Pupils p LEFT JOIN Classes c ON c.ClassID = p.ClassID"
        If filter = "" Then
            dgvPupils.DataSource = GetTable(sql & " ORDER BY p.PupilID")
        Else
            dgvPupils.DataSource = GetTable(
                sql & " WHERE p.FirstName LIKE @f OR p.LastName LIKE @f " &
                "OR CAST(p.PupilID AS NVARCHAR(10)) = @id ORDER BY p.PupilID",
                Param("@f", "%" & filter & "%"), Param("@id", filter))
        End If
        If dgvPupils.Columns.Contains("DOB") Then dgvPupils.Columns("DOB").DefaultCellStyle.Format = "yyyy-MM-dd"
    End Sub

    ' Empties every input box ready for a new pupil
    Private Sub ClearForm()
        txtPupilID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        cmbGender.SelectedIndex = -1
        cmbClass.SelectedIndex = -1
        dtpDOB.Value = Date.Today
        txtParentName.Clear()
        txtParentPhone.Clear()
        txtAddress.Clear()
        txtFirstName.Focus()
    End Sub

    ' Checks the required boxes before saving
    Private Function ValidateInput() As Boolean
        If txtFirstName.Text.Trim() = "" OrElse txtLastName.Text.Trim() = "" Then
            ShowWarn(Caption, "First name and last name are required.")
            Return False
        End If
        If cmbClass.SelectedIndex = -1 Then
            ShowWarn(Caption, "Choose the pupil's class.")
            Return False
        End If
        If dtpDOB.Value.Date > Date.Today Then
            ShowWarn(Caption, "The date of birth cannot be in the future.")
            Return False
        End If
        Return True
    End Function

    ' Reads the selected pupil ID from the read-only box
    Private Function TryGetSelectedId(ByRef id As Integer) As Boolean
        If Not Integer.TryParse(txtPupilID.Text, id) OrElse id <= 0 Then
            ShowWarn(Caption, "Click a pupil in the table first.")
            Return False
        End If
        Return True
    End Function

    ' ------------------------------------------------------------------
    ' Events
    ' ------------------------------------------------------------------

    Private Sub PupilManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbGender.Items.Clear()
            cmbGender.Items.AddRange(New String() {"Male", "Female"})
            dtpDOB.MaxDate = Date.Today
            FillCombo(cmbClass, "SELECT ClassID, ClassName FROM Classes ORDER BY ClassName", "ClassName", "ClassID")
            LoadPupils()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not ValidateInput() Then Return
            RunCommand(
                "INSERT INTO Pupils (FirstName, LastName, Gender, ClassID, DOB, ParentName, ParentPhone, Address) " &
                "VALUES (@fn, @ln, @g, @c, @dob, @pn, @pp, @a)",
                Param("@fn", txtFirstName.Text.Trim()), Param("@ln", txtLastName.Text.Trim()),
                Param("@g", If(cmbGender.SelectedIndex = -1, Nothing, cmbGender.Text)),
                Param("@c", ComboValue(cmbClass)), Param("@dob", dtpDOB.Value.Date),
                Param("@pn", txtParentName.Text.Trim()), Param("@pp", txtParentPhone.Text.Trim()),
                Param("@a", txtAddress.Text.Trim()))
            ShowInfo(Caption, "Pupil added.")
            ClearForm()
            LoadPupils()
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
                "UPDATE Pupils SET FirstName=@fn, LastName=@ln, Gender=@g, ClassID=@c, DOB=@dob, " &
                "ParentName=@pn, ParentPhone=@pp, Address=@a WHERE PupilID=@id",
                Param("@fn", txtFirstName.Text.Trim()), Param("@ln", txtLastName.Text.Trim()),
                Param("@g", If(cmbGender.SelectedIndex = -1, Nothing, cmbGender.Text)),
                Param("@c", ComboValue(cmbClass)), Param("@dob", dtpDOB.Value.Date),
                Param("@pn", txtParentName.Text.Trim()), Param("@pp", txtParentPhone.Text.Trim()),
                Param("@a", txtAddress.Text.Trim()), Param("@id", id))
            ShowInfo(Caption, "Pupil updated.")
            ClearForm()
            LoadPupils()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Asks for confirmation and also removes the pupil's attendance, results and payments
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim id As Integer
            If Not TryGetSelectedId(id) Then Return
            If Not Confirm("Confirm delete", "Delete this pupil and all of their records?") Then Return
            RunCommand("DELETE FROM Attendance WHERE PupilID = @id", Param("@id", id))
            RunCommand("DELETE FROM Results WHERE PupilID = @id", Param("@id", id))
            RunCommand("DELETE FROM Payments WHERE PupilID = @id", Param("@id", id))
            RunCommand("DELETE FROM Pupils WHERE PupilID = @id", Param("@id", id))
            ClearForm()
            LoadPupils()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim text As String = txtFirstName.Text.Trim()
            If text = "" Then text = txtLastName.Text.Trim()
            LoadPupils(text)
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ClearForm()
            LoadPupils()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Copies the clicked pupil into the input boxes so they can be edited
    Private Sub dgvPupils_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPupils.CellClick
        Try
            If e.RowIndex < 0 Then Return
            Dim id As Integer
            If Not Integer.TryParse(Convert.ToString(dgvPupils.Rows(e.RowIndex).Cells("ID").Value), id) Then Return
            Dim dt As DataTable = GetTable("SELECT * FROM Pupils WHERE PupilID = @id", Param("@id", id))
            If dt.Rows.Count = 0 Then Return
            Dim r As DataRow = dt.Rows(0)
            txtPupilID.Text = r("PupilID").ToString()
            txtFirstName.Text = r("FirstName").ToString()
            txtLastName.Text = r("LastName").ToString()
            SelectCombo(cmbGender, r("Gender"))
            SelectCombo(cmbClass, r("ClassID"))
            Dim dob As DateTime
            If Not IsDBNull(r("DOB")) AndAlso DateTime.TryParse(Convert.ToString(r("DOB")), dob) Then
                If dob > dtpDOB.MaxDate Then dob = dtpDOB.MaxDate
                If dob < dtpDOB.MinDate Then dob = dtpDOB.MinDate
                dtpDOB.Value = dob
            Else
                dtpDOB.Value = Date.Today
            End If
            txtParentName.Text = r("ParentName").ToString()
            txtParentPhone.Text = r("ParentPhone").ToString()
            txtAddress.Text = r("Address").ToString()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Phone number accepts digits only
    Private Sub txtParentPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParentPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
    End Sub

End Class
