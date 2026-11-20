<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PupilManagementForm
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
        Me.txtPupilID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtParentName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtParentPhone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.dgvPupils = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Text = "   Pupil Management"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pupil ID"
        '
        ' txtPupilID
        '
        Me.txtPupilID.Location = New System.Drawing.Point(130, 72)
        Me.txtPupilID.Name = "txtPupilID"
        Me.txtPupilID.Size = New System.Drawing.Size(200, 23)
        Me.txtPupilID.TabIndex = 2
        Me.txtPupilID.ReadOnly = True
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
        ' txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 23)
        Me.txtFirstName.TabIndex = 4
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
        ' txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(130, 144)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 23)
        Me.txtLastName.TabIndex = 6
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(20, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        '
        ' cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(130, 180)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(200, 23)
        Me.cmbGender.TabIndex = 8
        '
        ' Label5
        '
        Me.Label5.AutoSize = False
        Me.Label5.Location = New System.Drawing.Point(20, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Class"
        '
        ' cmbClass
        '
        Me.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(130, 216)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(200, 23)
        Me.cmbClass.TabIndex = 10
        '
        ' Label6
        '
        Me.Label6.AutoSize = False
        Me.Label6.Location = New System.Drawing.Point(20, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date of Birth"
        '
        ' dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDOB.Location = New System.Drawing.Point(130, 252)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 23)
        Me.dtpDOB.TabIndex = 12
        '
        ' Label7
        '
        Me.Label7.AutoSize = False
        Me.Label7.Location = New System.Drawing.Point(20, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Parent Name"
        '
        ' txtParentName
        '
        Me.txtParentName.Location = New System.Drawing.Point(130, 288)
        Me.txtParentName.Name = "txtParentName"
        Me.txtParentName.Size = New System.Drawing.Size(200, 23)
        Me.txtParentName.TabIndex = 14
        '
        ' Label8
        '
        Me.Label8.AutoSize = False
        Me.Label8.Location = New System.Drawing.Point(20, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Parent Phone"
        '
        ' txtParentPhone
        '
        Me.txtParentPhone.Location = New System.Drawing.Point(130, 324)
        Me.txtParentPhone.Name = "txtParentPhone"
        Me.txtParentPhone.Size = New System.Drawing.Size(200, 23)
        Me.txtParentPhone.TabIndex = 16
        '
        ' Label9
        '
        Me.Label9.AutoSize = False
        Me.Label9.Location = New System.Drawing.Point(20, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Address"
        '
        ' txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(130, 360)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 60)
        Me.txtAddress.TabIndex = 18
        Me.txtAddress.Multiline = True
        '
        ' btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Location = New System.Drawing.Point(20, 440)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 34)
        Me.btnAdd.TabIndex = 19
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
        Me.btnUpdate.Location = New System.Drawing.Point(125, 440)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 34)
        Me.btnUpdate.TabIndex = 20
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
        Me.btnDelete.Location = New System.Drawing.Point(230, 440)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 34)
        Me.btnDelete.TabIndex = 21
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
        Me.btnSearch.Location = New System.Drawing.Point(20, 484)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(155, 34)
        Me.btnSearch.TabIndex = 22
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
        Me.btnClear.Location = New System.Drawing.Point(175, 484)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 34)
        Me.btnClear.TabIndex = 23
        Me.btnClear.Text = "Clear"
        '
        ' lblHint
        '
        Me.lblHint.AutoSize = False
        Me.lblHint.Location = New System.Drawing.Point(20, 530)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(310, 60)
        Me.lblHint.TabIndex = 24
        Me.lblHint.Text = "To search, type part of a first or last name (or a whole pupil ID in the First Name box), then click Search."
        Me.lblHint.ForeColor = System.Drawing.Color.DimGray
        '
        ' dgvPupils
        '
        Me.dgvPupils.AllowUserToAddRows = False
        Me.dgvPupils.AllowUserToDeleteRows = False
        Me.dgvPupils.AllowUserToResizeRows = False
        Me.dgvPupils.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPupils.BackgroundColor = System.Drawing.Color.White
        Me.dgvPupils.MultiSelect = False
        Me.dgvPupils.ReadOnly = True
        Me.dgvPupils.RowHeadersVisible = False
        Me.dgvPupils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPupils.Location = New System.Drawing.Point(350, 72)
        Me.dgvPupils.Name = "dgvPupils"
        Me.dgvPupils.Size = New System.Drawing.Size(630, 520)
        Me.dgvPupils.TabIndex = 25
        '
        ' PupilManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(1000, 610)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPupilID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtParentName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtParentPhone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.dgvPupils)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PupilManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pupil Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPupilID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtParentName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtParentPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents dgvPupils As System.Windows.Forms.DataGridView

End Class
