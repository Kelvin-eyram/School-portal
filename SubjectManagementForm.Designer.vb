<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubjectManagementForm
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
        Me.txtSubjectID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubjectName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTeacher = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Text = "   Subject Management"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subject ID"
        '
        ' txtSubjectID
        '
        Me.txtSubjectID.Location = New System.Drawing.Point(130, 72)
        Me.txtSubjectID.Name = "txtSubjectID"
        Me.txtSubjectID.Size = New System.Drawing.Size(200, 23)
        Me.txtSubjectID.TabIndex = 2
        Me.txtSubjectID.ReadOnly = True
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(20, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Subject Name"
        '
        ' txtSubjectName
        '
        Me.txtSubjectName.Location = New System.Drawing.Point(130, 108)
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.Size = New System.Drawing.Size(200, 23)
        Me.txtSubjectName.TabIndex = 4
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Code"
        '
        ' txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(130, 144)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(200, 23)
        Me.txtCode.TabIndex = 6
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Class"
        '
        ' cmbClass
        '
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(130, 180)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(200, 23)
        Me.cmbClass.TabIndex = 8
        '
        ' Label5
        '
        Me.Label5.AutoSize = False
        Me.Label5.Location = New System.Drawing.Point(20, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Teacher"
        '
        ' cmbTeacher
        '
        Me.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeacher.FormattingEnabled = True
        Me.cmbTeacher.Location = New System.Drawing.Point(130, 216)
        Me.cmbTeacher.Name = "cmbTeacher"
        Me.cmbTeacher.Size = New System.Drawing.Size(200, 23)
        Me.cmbTeacher.TabIndex = 10
        '
        ' btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Location = New System.Drawing.Point(20, 280)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 34)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        '
        ' btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Location = New System.Drawing.Point(125, 280)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 34)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        '
        ' btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Location = New System.Drawing.Point(230, 280)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 34)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        '
        ' btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(96, 96, 96)
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Location = New System.Drawing.Point(20, 324)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(310, 34)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        '
        ' dgvSubjects
        '
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AllowUserToDeleteRows = False
        Me.dgvSubjects.AllowUserToResizeRows = False
        Me.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjects.BackgroundColor = System.Drawing.Color.White
        Me.dgvSubjects.MultiSelect = False
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.RowHeadersVisible = False
        Me.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubjects.Location = New System.Drawing.Point(350, 72)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.Size = New System.Drawing.Size(630, 520)
        Me.dgvSubjects.TabIndex = 15
        '
        ' SubjectManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 610)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubjectID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubjectName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbTeacher)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvSubjects)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SubjectManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTeacher As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dgvSubjects As System.Windows.Forms.DataGridView

End Class
