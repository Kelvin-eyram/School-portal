<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportsForm
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
        Me.cmbReportType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpReportStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpReportEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.btnPrintReport = New System.Windows.Forms.Button()
        Me.dgvReportSummary = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
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
        Me.lblFormTitle.Size = New System.Drawing.Size(900, 55)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "   Reports"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Report"
        '
        ' cmbReportType
        '
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Location = New System.Drawing.Point(75, 68)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(150, 23)
        Me.cmbReportType.TabIndex = 2
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(240, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        ' dtpReportStart
        '
        Me.dtpReportStart.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpReportStart.Location = New System.Drawing.Point(280, 68)
        Me.dtpReportStart.Name = "dtpReportStart"
        Me.dtpReportStart.Size = New System.Drawing.Size(120, 23)
        Me.dtpReportStart.TabIndex = 4
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(415, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To"
        '
        ' dtpReportEnd
        '
        Me.dtpReportEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpReportEnd.Location = New System.Drawing.Point(445, 68)
        Me.dtpReportEnd.Name = "dtpReportEnd"
        Me.dtpReportEnd.Size = New System.Drawing.Size(120, 23)
        Me.dtpReportEnd.TabIndex = 6
        '
        ' btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateReport.FlatAppearance.BorderSize = 0
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        Me.btnGenerateReport.Location = New System.Drawing.Point(590, 63)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(135, 32)
        Me.btnGenerateReport.TabIndex = 7
        Me.btnGenerateReport.Text = "Generate"
        '
        ' btnPrintReport
        '
        Me.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintReport.FlatAppearance.BorderSize = 0
        Me.btnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReport.ForeColor = System.Drawing.Color.White
        Me.btnPrintReport.UseVisualStyleBackColor = False
        Me.btnPrintReport.Location = New System.Drawing.Point(740, 63)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(135, 32)
        Me.btnPrintReport.TabIndex = 8
        Me.btnPrintReport.Text = "Print"
        '
        ' dgvReportSummary
        '
        Me.dgvReportSummary.AllowUserToAddRows = False
        Me.dgvReportSummary.AllowUserToDeleteRows = False
        Me.dgvReportSummary.AllowUserToResizeRows = False
        Me.dgvReportSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReportSummary.BackgroundColor = System.Drawing.Color.White
        Me.dgvReportSummary.MultiSelect = False
        Me.dgvReportSummary.ReadOnly = True
        Me.dgvReportSummary.RowHeadersVisible = False
        Me.dgvReportSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportSummary.Location = New System.Drawing.Point(20, 110)
        Me.dgvReportSummary.Name = "dgvReportSummary"
        Me.dgvReportSummary.Size = New System.Drawing.Size(860, 470)
        Me.dgvReportSummary.TabIndex = 9
        '
        ' ReportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbReportType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpReportStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpReportEnd)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.dgvReportSummary)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReportsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpReportStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpReportEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
    Friend WithEvents btnPrintReport As System.Windows.Forms.Button
    Friend WithEvents dgvReportSummary As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument

End Class
