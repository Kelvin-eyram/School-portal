<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportCardForm
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
        Me.txtReportPupilID = New System.Windows.Forms.TextBox()
        Me.btnFindPupil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbReportTerm = New System.Windows.Forms.ComboBox()
        Me.btnGenerateReportCard = New System.Windows.Forms.Button()
        Me.btnPrintReportCard = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReportPupilName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReportClass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClassPopulation = New System.Windows.Forms.TextBox()
        Me.dgvReportCardSubjects = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalScore = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtClassPosition = New System.Windows.Forms.TextBox()
        Me.grpPromotion = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPromotedTo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTeacherRemarks = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.rdoPromoted = New System.Windows.Forms.RadioButton()
        Me.rdoRepeated = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        Me.grpPromotion.SuspendLayout()
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
        Me.lblFormTitle.Text = "   Student Report Card"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pupil ID"
        '
        ' txtReportPupilID
        '
        Me.txtReportPupilID.Location = New System.Drawing.Point(85, 68)
        Me.txtReportPupilID.Name = "txtReportPupilID"
        Me.txtReportPupilID.Size = New System.Drawing.Size(90, 23)
        Me.txtReportPupilID.TabIndex = 2
        '
        ' btnFindPupil
        '
        Me.btnFindPupil.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnFindPupil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindPupil.FlatAppearance.BorderSize = 0
        Me.btnFindPupil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindPupil.ForeColor = System.Drawing.Color.White
        Me.btnFindPupil.UseVisualStyleBackColor = False
        Me.btnFindPupil.Location = New System.Drawing.Point(185, 63)
        Me.btnFindPupil.Name = "btnFindPupil"
        Me.btnFindPupil.Size = New System.Drawing.Size(110, 32)
        Me.btnFindPupil.TabIndex = 3
        Me.btnFindPupil.Text = "Find Pupil"
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(315, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Term"
        '
        ' cmbReportTerm
        '
        Me.cmbReportTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportTerm.FormattingEnabled = True
        Me.cmbReportTerm.Location = New System.Drawing.Point(360, 68)
        Me.cmbReportTerm.Name = "cmbReportTerm"
        Me.cmbReportTerm.Size = New System.Drawing.Size(110, 23)
        Me.cmbReportTerm.TabIndex = 5
        '
        ' btnGenerateReportCard
        '
        Me.btnGenerateReportCard.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnGenerateReportCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateReportCard.FlatAppearance.BorderSize = 0
        Me.btnGenerateReportCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateReportCard.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReportCard.UseVisualStyleBackColor = False
        Me.btnGenerateReportCard.Location = New System.Drawing.Point(490, 63)
        Me.btnGenerateReportCard.Name = "btnGenerateReportCard"
        Me.btnGenerateReportCard.Size = New System.Drawing.Size(190, 32)
        Me.btnGenerateReportCard.TabIndex = 6
        Me.btnGenerateReportCard.Text = "Generate Report Card"
        '
        ' btnPrintReportCard
        '
        Me.btnPrintReportCard.BackColor = System.Drawing.Color.FromArgb(96, 96, 96)
        Me.btnPrintReportCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintReportCard.FlatAppearance.BorderSize = 0
        Me.btnPrintReportCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReportCard.ForeColor = System.Drawing.Color.White
        Me.btnPrintReportCard.UseVisualStyleBackColor = False
        Me.btnPrintReportCard.Location = New System.Drawing.Point(695, 63)
        Me.btnPrintReportCard.Name = "btnPrintReportCard"
        Me.btnPrintReportCard.Size = New System.Drawing.Size(120, 32)
        Me.btnPrintReportCard.TabIndex = 7
        Me.btnPrintReportCard.Text = "Print"
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        ' txtReportPupilName
        '
        Me.txtReportPupilName.Location = New System.Drawing.Point(85, 115)
        Me.txtReportPupilName.Name = "txtReportPupilName"
        Me.txtReportPupilName.Size = New System.Drawing.Size(235, 23)
        Me.txtReportPupilName.TabIndex = 9
        Me.txtReportPupilName.ReadOnly = True
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(340, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Class"
        '
        ' txtReportClass
        '
        Me.txtReportClass.Location = New System.Drawing.Point(385, 115)
        Me.txtReportClass.Name = "txtReportClass"
        Me.txtReportClass.Size = New System.Drawing.Size(110, 23)
        Me.txtReportClass.TabIndex = 11
        Me.txtReportClass.ReadOnly = True
        '
        ' Label5
        '
        Me.Label5.AutoSize = False
        Me.Label5.Location = New System.Drawing.Point(515, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Class Size"
        '
        ' txtClassPopulation
        '
        Me.txtClassPopulation.Location = New System.Drawing.Point(590, 115)
        Me.txtClassPopulation.Name = "txtClassPopulation"
        Me.txtClassPopulation.Size = New System.Drawing.Size(70, 23)
        Me.txtClassPopulation.TabIndex = 13
        Me.txtClassPopulation.ReadOnly = True
        '
        ' dgvReportCardSubjects
        '
        Me.dgvReportCardSubjects.AllowUserToAddRows = False
        Me.dgvReportCardSubjects.AllowUserToDeleteRows = False
        Me.dgvReportCardSubjects.AllowUserToResizeRows = False
        Me.dgvReportCardSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReportCardSubjects.BackgroundColor = System.Drawing.Color.White
        Me.dgvReportCardSubjects.MultiSelect = False
        Me.dgvReportCardSubjects.ReadOnly = True
        Me.dgvReportCardSubjects.RowHeadersVisible = False
        Me.dgvReportCardSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportCardSubjects.Location = New System.Drawing.Point(20, 160)
        Me.dgvReportCardSubjects.Name = "dgvReportCardSubjects"
        Me.dgvReportCardSubjects.Size = New System.Drawing.Size(520, 290)
        Me.dgvReportCardSubjects.TabIndex = 14
        '
        ' Label6
        '
        Me.Label6.AutoSize = False
        Me.Label6.Location = New System.Drawing.Point(570, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Score"
        '
        ' txtTotalScore
        '
        Me.txtTotalScore.Location = New System.Drawing.Point(690, 160)
        Me.txtTotalScore.Name = "txtTotalScore"
        Me.txtTotalScore.Size = New System.Drawing.Size(130, 23)
        Me.txtTotalScore.TabIndex = 16
        Me.txtTotalScore.ReadOnly = True
        '
        ' Label7
        '
        Me.Label7.AutoSize = False
        Me.Label7.Location = New System.Drawing.Point(570, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Average"
        '
        ' txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(690, 196)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(130, 23)
        Me.txtAverage.TabIndex = 18
        Me.txtAverage.ReadOnly = True
        '
        ' Label8
        '
        Me.Label8.AutoSize = False
        Me.Label8.Location = New System.Drawing.Point(570, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Position in Class"
        '
        ' txtClassPosition
        '
        Me.txtClassPosition.Location = New System.Drawing.Point(690, 232)
        Me.txtClassPosition.Name = "txtClassPosition"
        Me.txtClassPosition.Size = New System.Drawing.Size(130, 23)
        Me.txtClassPosition.TabIndex = 20
        Me.txtClassPosition.ReadOnly = True
        '
        ' grpPromotion
        '
        Me.grpPromotion.Location = New System.Drawing.Point(570, 275)
        Me.grpPromotion.Name = "grpPromotion"
        Me.grpPromotion.Size = New System.Drawing.Size(250, 95)
        Me.grpPromotion.TabIndex = 21
        Me.grpPromotion.Text = "Promotion"
        Me.grpPromotion.Controls.Add(Me.rdoPromoted)
        Me.grpPromotion.Controls.Add(Me.rdoRepeated)
        '
        ' Label9
        '
        Me.Label9.AutoSize = False
        Me.Label9.Location = New System.Drawing.Point(570, 388)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Promoted To"
        '
        ' txtPromotedTo
        '
        Me.txtPromotedTo.Location = New System.Drawing.Point(690, 385)
        Me.txtPromotedTo.Name = "txtPromotedTo"
        Me.txtPromotedTo.Size = New System.Drawing.Size(130, 23)
        Me.txtPromotedTo.TabIndex = 23
        Me.txtPromotedTo.ReadOnly = True
        '
        ' Label10
        '
        Me.Label10.AutoSize = False
        Me.Label10.Location = New System.Drawing.Point(20, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 20)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Teacher's Remarks"
        '
        ' txtTeacherRemarks
        '
        Me.txtTeacherRemarks.Location = New System.Drawing.Point(20, 490)
        Me.txtTeacherRemarks.Name = "txtTeacherRemarks"
        Me.txtTeacherRemarks.Size = New System.Drawing.Size(800, 100)
        Me.txtTeacherRemarks.TabIndex = 25
        Me.txtTeacherRemarks.Multiline = True
        Me.txtTeacherRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        '
        ' rdoPromoted
        '
        Me.rdoPromoted.AutoSize = True
        Me.rdoPromoted.Location = New System.Drawing.Point(15, 28)
        Me.rdoPromoted.Name = "rdoPromoted"
        Me.rdoPromoted.Size = New System.Drawing.Size(90, 19)
        Me.rdoPromoted.TabIndex = 26
        Me.rdoPromoted.TabStop = True
        Me.rdoPromoted.Text = "Promoted"
        Me.rdoPromoted.UseVisualStyleBackColor = True
        '
        ' rdoRepeated
        '
        Me.rdoRepeated.AutoSize = True
        Me.rdoRepeated.Location = New System.Drawing.Point(15, 60)
        Me.rdoRepeated.Name = "rdoRepeated"
        Me.rdoRepeated.Size = New System.Drawing.Size(90, 19)
        Me.rdoRepeated.TabIndex = 27
        Me.rdoRepeated.TabStop = True
        Me.rdoRepeated.Text = "Repeated"
        Me.rdoRepeated.UseVisualStyleBackColor = True
        '
        ' ReportCardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(900, 640)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReportPupilID)
        Me.Controls.Add(Me.btnFindPupil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbReportTerm)
        Me.Controls.Add(Me.btnGenerateReportCard)
        Me.Controls.Add(Me.btnPrintReportCard)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReportPupilName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtReportClass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtClassPopulation)
        Me.Controls.Add(Me.dgvReportCardSubjects)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtClassPosition)
        Me.Controls.Add(Me.grpPromotion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPromotedTo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTeacherRemarks)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReportCardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Report Card"
        Me.grpPromotion.ResumeLayout(False)
        Me.grpPromotion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReportPupilID As System.Windows.Forms.TextBox
    Friend WithEvents btnFindPupil As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbReportTerm As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerateReportCard As System.Windows.Forms.Button
    Friend WithEvents btnPrintReportCard As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtReportPupilName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReportClass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClassPopulation As System.Windows.Forms.TextBox
    Friend WithEvents dgvReportCardSubjects As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalScore As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtClassPosition As System.Windows.Forms.TextBox
    Friend WithEvents grpPromotion As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPromotedTo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherRemarks As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents rdoPromoted As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRepeated As System.Windows.Forms.RadioButton

End Class
