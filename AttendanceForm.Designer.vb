<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AttendanceForm
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
        Me.dtpAttendanceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAttendanceClass = New System.Windows.Forms.ComboBox()
        Me.btnLoadClass = New System.Windows.Forms.Button()
        Me.btnSaveAttendance = New System.Windows.Forms.Button()
        Me.dgvAttendance = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Text = "   Daily Attendance"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date"
        '
        ' dtpAttendanceDate
        '
        Me.dtpAttendanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpAttendanceDate.Location = New System.Drawing.Point(65, 68)
        Me.dtpAttendanceDate.Name = "dtpAttendanceDate"
        Me.dtpAttendanceDate.Size = New System.Drawing.Size(130, 23)
        Me.dtpAttendanceDate.TabIndex = 2
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(215, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Class"
        '
        ' cmbAttendanceClass
        '
        Me.cmbAttendanceClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttendanceClass.FormattingEnabled = True
        Me.cmbAttendanceClass.Location = New System.Drawing.Point(260, 68)
        Me.cmbAttendanceClass.Name = "cmbAttendanceClass"
        Me.cmbAttendanceClass.Size = New System.Drawing.Size(170, 23)
        Me.cmbAttendanceClass.TabIndex = 4
        '
        ' btnLoadClass
        '
        Me.btnLoadClass.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnLoadClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadClass.FlatAppearance.BorderSize = 0
        Me.btnLoadClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadClass.ForeColor = System.Drawing.Color.White
        Me.btnLoadClass.UseVisualStyleBackColor = False
        Me.btnLoadClass.Location = New System.Drawing.Point(450, 63)
        Me.btnLoadClass.Name = "btnLoadClass"
        Me.btnLoadClass.Size = New System.Drawing.Size(140, 32)
        Me.btnLoadClass.TabIndex = 5
        Me.btnLoadClass.Text = "Load Class"
        '
        ' btnSaveAttendance
        '
        Me.btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnSaveAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveAttendance.FlatAppearance.BorderSize = 0
        Me.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAttendance.ForeColor = System.Drawing.Color.White
        Me.btnSaveAttendance.UseVisualStyleBackColor = False
        Me.btnSaveAttendance.Location = New System.Drawing.Point(600, 63)
        Me.btnSaveAttendance.Name = "btnSaveAttendance"
        Me.btnSaveAttendance.Size = New System.Drawing.Size(160, 32)
        Me.btnSaveAttendance.TabIndex = 6
        Me.btnSaveAttendance.Text = "Save Attendance"
        '
        ' dgvAttendance
        '
        Me.dgvAttendance.AllowUserToAddRows = False
        Me.dgvAttendance.AllowUserToDeleteRows = False
        Me.dgvAttendance.AllowUserToResizeRows = False
        Me.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAttendance.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttendance.MultiSelect = False
        Me.dgvAttendance.ReadOnly = False
        Me.dgvAttendance.RowHeadersVisible = False
        Me.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAttendance.Location = New System.Drawing.Point(20, 110)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.Size = New System.Drawing.Size(860, 470)
        Me.dgvAttendance.TabIndex = 7
        '
        ' AttendanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAttendanceDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAttendanceClass)
        Me.Controls.Add(Me.btnLoadClass)
        Me.Controls.Add(Me.btnSaveAttendance)
        Me.Controls.Add(Me.dgvAttendance)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AttendanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Attendance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAttendanceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAttendanceClass As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadClass As System.Windows.Forms.Button
    Friend WithEvents btnSaveAttendance As System.Windows.Forms.Button
    Friend WithEvents dgvAttendance As System.Windows.Forms.DataGridView

End Class
