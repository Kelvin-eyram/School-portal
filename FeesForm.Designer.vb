<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeesForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFeeSearchPupilID = New System.Windows.Forms.TextBox()
        Me.btnFindPupilFees = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPupilName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalOwed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOutstandingBalance = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
        Me.btnPostPayment = New System.Windows.Forms.Button()
        Me.dgvPaymentHistory = New System.Windows.Forms.DataGridView()
        Me.SuspendLayout()
        '
        ' lblFormTitle
        '
        Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(860, 55)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "   Fees and Payments"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pupil ID"
        '
        ' txtFeeSearchPupilID
        '
        Me.txtFeeSearchPupilID.Location = New System.Drawing.Point(85, 72)
        Me.txtFeeSearchPupilID.Name = "txtFeeSearchPupilID"
        Me.txtFeeSearchPupilID.Size = New System.Drawing.Size(110, 23)
        Me.txtFeeSearchPupilID.TabIndex = 2
        '
        ' btnFindPupilFees
        '
        Me.btnFindPupilFees.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnFindPupilFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindPupilFees.FlatAppearance.BorderSize = 0
        Me.btnFindPupilFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindPupilFees.ForeColor = System.Drawing.Color.White
        Me.btnFindPupilFees.UseVisualStyleBackColor = False
        Me.btnFindPupilFees.Location = New System.Drawing.Point(210, 67)
        Me.btnFindPupilFees.Name = "btnFindPupilFees"
        Me.btnFindPupilFees.Size = New System.Drawing.Size(120, 32)
        Me.btnFindPupilFees.TabIndex = 3
        Me.btnFindPupilFees.Text = "Find Fees"
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(355, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pupil Name"
        '
        ' txtPupilName
        '
        Me.txtPupilName.Location = New System.Drawing.Point(440, 72)
        Me.txtPupilName.Name = "txtPupilName"
        Me.txtPupilName.Size = New System.Drawing.Size(270, 23)
        Me.txtPupilName.TabIndex = 5
        Me.txtPupilName.ReadOnly = True
        Me.txtPupilName.TabStop = False
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Fees"
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        '
        ' lblTotalOwed
        '
        Me.lblTotalOwed.AutoSize = False
        Me.lblTotalOwed.Location = New System.Drawing.Point(20, 142)
        Me.lblTotalOwed.Name = "lblTotalOwed"
        Me.lblTotalOwed.Size = New System.Drawing.Size(250, 46)
        Me.lblTotalOwed.TabIndex = 7
        Me.lblTotalOwed.Text = "0.00"
        Me.lblTotalOwed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalOwed.BackColor = System.Drawing.Color.White
        Me.lblTotalOwed.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalOwed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(300, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount Paid"
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        '
        ' lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = False
        Me.lblAmountPaid.Location = New System.Drawing.Point(300, 142)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(250, 46)
        Me.lblAmountPaid.TabIndex = 9
        Me.lblAmountPaid.Text = "0.00"
        Me.lblAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountPaid.BackColor = System.Drawing.Color.White
        Me.lblAmountPaid.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' Label5
        '
        Me.Label5.AutoSize = False
        Me.Label5.Location = New System.Drawing.Point(580, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Outstanding Balance"
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        '
        ' lblOutstandingBalance
        '
        Me.lblOutstandingBalance.AutoSize = False
        Me.lblOutstandingBalance.Location = New System.Drawing.Point(580, 142)
        Me.lblOutstandingBalance.Name = "lblOutstandingBalance"
        Me.lblOutstandingBalance.Size = New System.Drawing.Size(250, 46)
        Me.lblOutstandingBalance.TabIndex = 11
        Me.lblOutstandingBalance.Text = "0.00"
        Me.lblOutstandingBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutstandingBalance.BackColor = System.Drawing.Color.White
        Me.lblOutstandingBalance.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOutstandingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        ' Label6
        '
        Me.Label6.AutoSize = False
        Me.Label6.Location = New System.Drawing.Point(20, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Payment Amount"
        '
        ' txtPaymentAmount
        '
        Me.txtPaymentAmount.Location = New System.Drawing.Point(135, 215)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(150, 23)
        Me.txtPaymentAmount.TabIndex = 13
        '
        ' btnPostPayment
        '
        Me.btnPostPayment.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnPostPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPostPayment.FlatAppearance.BorderSize = 0
        Me.btnPostPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPostPayment.ForeColor = System.Drawing.Color.White
        Me.btnPostPayment.UseVisualStyleBackColor = False
        Me.btnPostPayment.Location = New System.Drawing.Point(300, 210)
        Me.btnPostPayment.Name = "btnPostPayment"
        Me.btnPostPayment.Size = New System.Drawing.Size(140, 32)
        Me.btnPostPayment.TabIndex = 14
        Me.btnPostPayment.Text = "Post Payment"
        '
        ' dgvPaymentHistory
        '
        Me.dgvPaymentHistory.AllowUserToAddRows = False
        Me.dgvPaymentHistory.AllowUserToDeleteRows = False
        Me.dgvPaymentHistory.AllowUserToResizeRows = False
        Me.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaymentHistory.MultiSelect = False
        Me.dgvPaymentHistory.ReadOnly = True
        Me.dgvPaymentHistory.RowHeadersVisible = False
        Me.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(20, 260)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(820, 260)
        Me.dgvPaymentHistory.TabIndex = 15
        '
        ' FeesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(860, 540)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFeeSearchPupilID)
        Me.Controls.Add(Me.btnFindPupilFees)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPupilName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalOwed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblOutstandingBalance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPaymentAmount)
        Me.Controls.Add(Me.btnPostPayment)
        Me.Controls.Add(Me.dgvPaymentHistory)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FeesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees and Payments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFeeSearchPupilID As System.Windows.Forms.TextBox
    Friend WithEvents btnFindPupilFees As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPupilName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalOwed As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOutstandingBalance As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnPostPayment As System.Windows.Forms.Button
    Friend WithEvents dgvPaymentHistory As System.Windows.Forms.DataGridView

End Class
