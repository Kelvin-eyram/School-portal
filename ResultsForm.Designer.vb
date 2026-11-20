<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsForm
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
        Me.cmbResultsClass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbResultsSubject = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTerm = New System.Windows.Forms.ComboBox()
        Me.btnCalculateAndSave = New System.Windows.Forms.Button()
        Me.dgvScoresGrid = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Text = "   Academic Results"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class"
        '
        ' cmbResultsClass
        '
        Me.cmbResultsClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResultsClass.FormattingEnabled = True
        Me.cmbResultsClass.Location = New System.Drawing.Point(65, 68)
        Me.cmbResultsClass.Name = "cmbResultsClass"
        Me.cmbResultsClass.Size = New System.Drawing.Size(160, 23)
        Me.cmbResultsClass.TabIndex = 2
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(245, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subject"
        '
        ' cmbResultsSubject
        '
        Me.cmbResultsSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResultsSubject.FormattingEnabled = True
        Me.cmbResultsSubject.Location = New System.Drawing.Point(305, 68)
        Me.cmbResultsSubject.Name = "cmbResultsSubject"
        Me.cmbResultsSubject.Size = New System.Drawing.Size(190, 23)
        Me.cmbResultsSubject.TabIndex = 4
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(515, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Term"
        '
        ' cmbTerm
        '
        Me.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerm.FormattingEnabled = True
        Me.cmbTerm.Location = New System.Drawing.Point(560, 68)
        Me.cmbTerm.Name = "cmbTerm"
        Me.cmbTerm.Size = New System.Drawing.Size(110, 23)
        Me.cmbTerm.TabIndex = 6
        '
        ' btnCalculateAndSave
        '
        Me.btnCalculateAndSave.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnCalculateAndSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalculateAndSave.FlatAppearance.BorderSize = 0
        Me.btnCalculateAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculateAndSave.ForeColor = System.Drawing.Color.White
        Me.btnCalculateAndSave.UseVisualStyleBackColor = False
        Me.btnCalculateAndSave.Location = New System.Drawing.Point(700, 63)
        Me.btnCalculateAndSave.Name = "btnCalculateAndSave"
        Me.btnCalculateAndSave.Size = New System.Drawing.Size(180, 32)
        Me.btnCalculateAndSave.TabIndex = 7
        Me.btnCalculateAndSave.Text = "Calculate and Save"
        '
        ' dgvScoresGrid
        '
        Me.dgvScoresGrid.AllowUserToAddRows = False
        Me.dgvScoresGrid.AllowUserToDeleteRows = False
        Me.dgvScoresGrid.AllowUserToResizeRows = False
        Me.dgvScoresGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvScoresGrid.BackgroundColor = System.Drawing.Color.White
        Me.dgvScoresGrid.MultiSelect = False
        Me.dgvScoresGrid.ReadOnly = False
        Me.dgvScoresGrid.RowHeadersVisible = False
        Me.dgvScoresGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvScoresGrid.Location = New System.Drawing.Point(20, 110)
        Me.dgvScoresGrid.Name = "dgvScoresGrid"
        Me.dgvScoresGrid.Size = New System.Drawing.Size(860, 470)
        Me.dgvScoresGrid.TabIndex = 8
        '
        ' ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbResultsClass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbResultsSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTerm)
        Me.Controls.Add(Me.btnCalculateAndSave)
        Me.Controls.Add(Me.dgvScoresGrid)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ResultsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Academic Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbResultsClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbResultsSubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTerm As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculateAndSave As System.Windows.Forms.Button
    Friend WithEvents dgvScoresGrid As System.Windows.Forms.DataGridView

End Class
