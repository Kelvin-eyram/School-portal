<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TeacherManagementForm
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
        Me.txtTeacherID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTeacherFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTeacherLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTeacherPhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTeacherEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTeacherGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSubjectTaught = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbClassAssigned = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.dgvTeachers = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Text = "   Teacher Management"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Teacher ID"
        '
        ' txtTeacherID
        '
        Me.txtTeacherID.Location = New System.Drawing.Point(130, 72)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Size = New System.Drawing.Size(200, 23)
        Me.txtTeacherID.TabIndex = 2
        Me.txtTeacherID.ReadOnly = True
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(20, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        '
        ' txtTeacherFirstName
        '
        Me.txtTeacherFirstName.Location = New System.Drawing.Point(130, 108)
        Me.txtTeacherFirstName.Name = "txtTeacherFirstName"
        Me.txtTeacherFirstName.Size = New System.Drawing.Size(200, 23)
        Me.txtTeacherFirstName.TabIndex = 4
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        ' txtTeacherLastName
        '
        Me.txtTeacherLastName.Location = New System.Drawing.Point(130, 144)
        Me.txtTeacherLastName.Name = "txtTeacherLastName"
        Me.txtTeacherLastName.Size = New System.Drawing.Size(200, 23)
        Me.txtTeacherLastName.TabIndex = 6
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone"
        '
        ' txtTeacherPhone
        '
        Me.txtTeacherPhone.Location = New System.Drawing.Point(130, 180)
        Me.txtTeacherPhone.Name = "txtTeacherPhone"
        Me.txtTeacherPhone.Size = New System.Drawing.Size(200, 23)
        Me.txtTeacherPhone.TabIndex = 8
        '
        ' Label5
        '
        Me.Label5.AutoSize = False
        Me.Label5.Location = New System.Drawing.Point(20, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        ' txtTeacherEmail
        '
        Me.txtTeacherEmail.Location = New System.Drawing.Point(130, 216)
        Me.txtTeacherEmail.Name = "txtTeacherEmail"
        Me.txtTeacherEmail.Size = New System.Drawing.Size(200, 23)
        Me.txtTeacherEmail.TabIndex = 10
        '
        ' Label6
        '
        Me.Label6.AutoSize = False
        Me.Label6.Location = New System.Drawing.Point(20, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gender"
        '
        ' cmbTeacherGender
        '
        Me.cmbTeacherGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeacherGender.FormattingEnabled = True
        Me.cmbTeacherGender.Location = New System.Drawing.Point(130, 252)
        Me.cmbTeacherGender.Name = "cmbTeacherGender"
        Me.cmbTeacherGender.Size = New System.Drawing.Size(200, 23)
        Me.cmbTeacherGender.TabIndex = 12
        '
        ' Label7
        '
        Me.Label7.AutoSize = False
        Me.Label7.Location = New System.Drawing.Point(20, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Subject Taught"
        '
        ' cmbSubjectTaught
        '
        Me.cmbSubjectTaught.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectTaught.FormattingEnabled = True
        Me.cmbSubjectTaught.Location = New System.Drawing.Point(130, 288)
        Me.cmbSubjectTaught.Name = "cmbSubjectTaught"
        Me.cmbSubjectTaught.Size = New System.Drawing.Size(200, 23)
        Me.cmbSubjectTaught.TabIndex = 14
        '
        ' Label8
        '
        Me.Label8.AutoSize = False
        Me.Label8.Location = New System.Drawing.Point(20, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Class Assigned"
        '
        ' cmbClassAssigned
        '
        Me.cmbClassAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClassAssigned.FormattingEnabled = True
        Me.cmbClassAssigned.Location = New System.Drawing.Point(130, 324)
        Me.cmbClassAssigned.Name = "cmbClassAssigned"
        Me.cmbClassAssigned.Size = New System.Drawing.Size(200, 23)
        Me.cmbClassAssigned.TabIndex = 16
        '
        ' btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Location = New System.Drawing.Point(20, 385)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 34)
        Me.btnAdd.TabIndex = 17
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
        Me.btnUpdate.Location = New System.Drawing.Point(125, 385)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 34)
        Me.btnUpdate.TabIndex = 18
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
        Me.btnDelete.Location = New System.Drawing.Point(230, 385)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 34)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        '
        ' btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Location = New System.Drawing.Point(20, 429)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(155, 34)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Search"
        '
        ' btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(96, 96, 96)
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Location = New System.Drawing.Point(175, 429)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 34)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        '
        ' lblHint
        '
        Me.lblHint.AutoSize = False
        Me.lblHint.Location = New System.Drawing.Point(20, 475)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(310, 60)
        Me.lblHint.TabIndex = 22
        Me.lblHint.Text = "To search, type part of a first name, last name or phone number in the matching box, then click Search."
        Me.lblHint.ForeColor = System.Drawing.Color.DimGray
        '
        ' dgvTeachers
        '
        Me.dgvTeachers.AllowUserToAddRows = False
        Me.dgvTeachers.AllowUserToDeleteRows = False
        Me.dgvTeachers.AllowUserToResizeRows = False
        Me.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeachers.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeachers.MultiSelect = False
        Me.dgvTeachers.ReadOnly = True
        Me.dgvTeachers.RowHeadersVisible = False
        Me.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeachers.Location = New System.Drawing.Point(350, 72)
        Me.dgvTeachers.Name = "dgvTeachers"
        Me.dgvTeachers.Size = New System.Drawing.Size(630, 520)
        Me.dgvTeachers.TabIndex = 23
        '
        ' TeacherManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 610)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTeacherID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTeacherFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTeacherLastName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTeacherPhone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTeacherEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTeacherGender)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbSubjectTaught)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbClassAssigned)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.dgvTeachers)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TeacherManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTeacherGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbSubjectTaught As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbClassAssigned As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents dgvTeachers As System.Windows.Forms.DataGridView

End Class
