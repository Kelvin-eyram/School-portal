Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class FeesForm

    Private Const Caption As String = "Fees"

    ' Form-level variables (keep the pupil and balances in memory)
    Private currentPupilID As Integer = 0
    Private totalOwed As Decimal = 0D
    Private amountPaid As Decimal = 0D

    ' Loads the pupil's balances and receipts
    Private Sub ShowFees(id As Integer)
        Dim fees As Object = GetValue("SELECT TotalFees FROM Pupils WHERE PupilID = @id", Param("@id", id))
        If fees Is Nothing OrElse IsDBNull(fees) Then
            ShowWarn(Caption, "No pupil found with that ID.")
            ClearDisplay()
            Return
        End If

        totalOwed = ToDec(fees)
        Dim paid As Object = GetValue("SELECT SUM(Amount) FROM Payments WHERE PupilID = @id", Param("@id", id))
        amountPaid = ToDec(paid)
        currentPupilID = id

        Dim outstanding As Decimal = totalOwed - amountPaid
        lblTotalOwed.Text = totalOwed.ToString("N2")
        lblAmountPaid.Text = amountPaid.ToString("N2")
        lblOutstandingBalance.Text = outstanding.ToString("N2")
        lblOutstandingBalance.ForeColor = If(outstanding > 0D, Color.Firebrick, Color.SeaGreen)

        dgvPaymentHistory.DataSource = GetTable(
            "SELECT 'RC-' + RIGHT('0000' + CAST(PaymentID AS NVARCHAR(10)), 4) AS Receipt, " &
            "PaymentDate AS [Date], Amount FROM Payments WHERE PupilID = @id ORDER BY PaymentID DESC",
            Param("@id", id))
    End Sub

    ' Empties the balances and receipts
    Private Sub ClearDisplay()
        currentPupilID = 0
        totalOwed = 0D
        amountPaid = 0D
        lblTotalOwed.Text = "0.00"
        lblAmountPaid.Text = "0.00"
        lblOutstandingBalance.Text = "0.00"
        lblOutstandingBalance.ForeColor = Color.Black
        dgvPaymentHistory.DataSource = Nothing
    End Sub

    ' Makes the name box read-only and starts the labels at zero
    Private Sub FeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtPupilName.ReadOnly = True
            txtPupilName.TabStop = False
            txtPaymentAmount.TextAlign = HorizontalAlignment.Right
            ClearDisplay()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' The name box fills in as soon as a valid ID is typed, and empties if no pupil has that ID
    Private Sub txtFeeSearchPupilID_TextChanged(sender As Object, e As EventArgs) Handles txtFeeSearchPupilID.TextChanged
        Try
            Dim id As Integer
            If Integer.TryParse(txtFeeSearchPupilID.Text.Trim(), id) Then
                Dim name As Object = GetValue(
                    "SELECT FirstName + ' ' + LastName FROM Pupils WHERE PupilID = @id", Param("@id", id))
                txtPupilName.Text = If(name Is Nothing, "", name.ToString())
            Else
                txtPupilName.Text = ""
            End If
            ClearDisplay()
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    Private Sub btnFindPupilFees_Click(sender As Object, e As EventArgs) Handles btnFindPupilFees.Click
        Try
            Dim id As Integer
            If Not Integer.TryParse(txtFeeSearchPupilID.Text.Trim(), id) OrElse id <= 0 Then
                ShowWarn(Caption, "Enter a valid pupil ID.")
                txtFeeSearchPupilID.Focus()
                Return
            End If
            ShowFees(id)
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

    ' Payment amount accepts digits and one decimal point
    Private Sub txtPaymentAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaymentAmount.KeyPress
        If Char.IsControl(e.KeyChar) Then Return
        If Char.IsDigit(e.KeyChar) Then Return
        If e.KeyChar = "."c AndAlso Not txtPaymentAmount.Text.Contains(".") Then Return
        e.Handled = True
    End Sub

    ' Checks the amount, asks for confirmation, saves the payment, shows the receipt number
    Private Sub btnPostPayment_Click(sender As Object, e As EventArgs) Handles btnPostPayment.Click
        Try
            If currentPupilID = 0 Then
                ShowWarn(Caption, "Click Find Fees for a pupil first.")
                Return
            End If

            Dim amount As Decimal
            If Not Decimal.TryParse(txtPaymentAmount.Text.Trim(), amount) OrElse amount <= 0D Then
                ShowWarn(Caption, "Enter a payment amount greater than zero.")
                txtPaymentAmount.Focus()
                Return
            End If

            If amount > totalOwed - amountPaid Then
                ShowWarn(Caption, "The payment is more than the outstanding balance.")
                Return
            End If

            If Not Confirm("Confirm payment", "Post a payment of " & amount.ToString("N2") & " for " & txtPupilName.Text & "?") Then Return

            Dim newId As Object = GetValue(
                "INSERT INTO Payments (PupilID, Amount) OUTPUT INSERTED.PaymentID VALUES (@p, @a)",
                Param("@p", currentPupilID), Param("@a", amount))
            ShowFees(currentPupilID)
            txtPaymentAmount.Clear()
            ShowInfo(Caption, "Payment posted. Receipt number: RC-" & ToInt(newId).ToString("0000"))
        Catch ex As Exception
            ShowError(Caption, ex)
        End Try
    End Sub

End Class
