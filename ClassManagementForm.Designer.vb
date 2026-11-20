<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClassManagementForm
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
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbClassTeacher = New System.Windows.Forms.ComboBox()
        Me.btnAddClass = New System.Windows.Forms.Button()
        Me.btnUpdateClass = New System.Windows.Forms.Button()
        Me.btnDeleteClass = New System.Windows.Forms.Button()
        Me.btnRefreshClasses = New System.Windows.Forms.Button()
        Me.dgvClasses = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Size = New System.Drawing.Size(1000, 55)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "   Class Management"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class ID"
        '
        ' txtClassID
        '
        Me.txtClassID.Location = New System.Drawing.Point(130, 72)
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.Size = New System.Drawing.Size(200, 23)
        Me.txtClassID.TabIndex = 2
        Me.txtClassID.ReadOnly = True
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(20, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Class Name"
        '
        ' txtClassName
        '
        Me.txtClassName.Location = New System.Drawing.Point(130, 108)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(200, 23)
        Me.txtClassName.TabIndex = 4
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Capacity"
        '
        ' txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(130, 144)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(200, 23)
        Me.txtCapacity.TabIndex = 6
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Class Teacher"
        '
        ' cmbClassTeacher
        '
        Me.cmbClassTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClassTeacher.FormattingEnabled = True
        Me.cmbClassTeacher.Location = New System.Drawing.Point(130, 180)
        Me.cmbClassTeacher.Name = "cmbClassTeacher"
        Me.cmbClassTeacher.Size = New System.Drawing.Size(200, 23)
        Me.cmbClassTeacher.TabIndex = 8
        '
        ' btnAddClass
        '
        Me.btnAddClass.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnAddClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddClass.FlatAppearance.BorderSize = 0
        Me.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddClass.ForeColor = System.Drawing.Color.White
        Me.btnAddClass.UseVisualStyleBackColor = False
        Me.btnAddClass.Location = New System.Drawing.Point(20, 240)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(150, 34)
        Me.btnAddClass.TabIndex = 9
        Me.btnAddClass.Text = "Add Class"
        '
        ' btnUpdateClass
        '
        Me.btnUpdateClass.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnUpdateClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateClass.FlatAppearance.BorderSize = 0
        Me.btnUpdateClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateClass.ForeColor = System.Drawing.Color.White
        Me.btnUpdateClass.UseVisualStyleBackColor = False
        Me.btnUpdateClass.Location = New System.Drawing.Point(180, 240)
        Me.btnUpdateClass.Name = "btnUpdateClass"
        Me.btnUpdateClass.Size = New System.Drawing.Size(150, 34)
        Me.btnUpdateClass.TabIndex = 10
        Me.btnUpdateClass.Text = "Update Class"
        '
        ' btnDeleteClass
        '
        Me.btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnDeleteClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteClass.FlatAppearance.BorderSize = 0
        Me.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteClass.ForeColor = System.Drawing.Color.White
        Me.btnDeleteClass.UseVisualStyleBackColor = False
        Me.btnDeleteClass.Location = New System.Drawing.Point(20, 284)
        Me.btnDeleteClass.Name = "btnDeleteClass"
        Me.btnDeleteClass.Size = New System.Drawing.Size(150, 34)
        Me.btnDeleteClass.TabIndex = 11
        Me.btnDeleteClass.Text = "Delete Class"
        '
        ' btnRefreshClasses
        '
        Me.btnRefreshClasses.BackColor = System.Drawing.Color.FromArgb(96, 96, 96)
        Me.btnRefreshClasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshClasses.FlatAppearance.BorderSize = 0
        Me.btnRefreshClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshClasses.ForeColor = System.Drawing.Color.White
        Me.btnRefreshClasses.UseVisualStyleBackColor = False
        Me.btnRefreshClasses.Location = New System.Drawing.Point(180, 284)
        Me.btnRefreshClasses.Name = "btnRefreshClasses"
        Me.btnRefreshClasses.Size = New System.Drawing.Size(150, 34)
        Me.btnRefreshClasses.TabIndex = 12
        Me.btnRefreshClasses.Text = "Refresh"
        '
        ' dgvClasses
        '
        Me.dgvClasses.AllowUserToAddRows = False
        Me.dgvClasses.AllowUserToDeleteRows = False
        Me.dgvClasses.AllowUserToResizeRows = False
        Me.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClasses.BackgroundColor = System.Drawing.Color.White
        Me.dgvClasses.MultiSelect = False
        Me.dgvClasses.ReadOnly = True
        Me.dgvClasses.RowHeadersVisible = False
        Me.dgvClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClasses.Location = New System.Drawing.Point(350, 72)
        Me.dgvClasses.Name = "dgvClasses"
        Me.dgvClasses.Size = New System.Drawing.Size(630, 520)
        Me.dgvClasses.TabIndex = 13
        '
        ' ClassManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 610)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClassID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClassName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbClassTeacher)
        Me.Controls.Add(Me.btnAddClass)
        Me.Controls.Add(Me.btnUpdateClass)
        Me.Controls.Add(Me.btnDeleteClass)
        Me.Controls.Add(Me.btnRefreshClasses)
        Me.Controls.Add(Me.dgvClasses)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ClassManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClassID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbClassTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddClass As System.Windows.Forms.Button
    Friend WithEvents btnUpdateClass As System.Windows.Forms.Button
    Friend WithEvents btnDeleteClass As System.Windows.Forms.Button
    Friend WithEvents btnRefreshClasses As System.Windows.Forms.Button
    Friend WithEvents dgvClasses As System.Windows.Forms.DataGridView

End Class
