<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserManagementForm
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
        Me.txtSystemUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSystemPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSystemRole = New System.Windows.Forms.ComboBox()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnModifyRole = New System.Windows.Forms.Button()
        Me.btnRevokeUser = New System.Windows.Forms.Button()
        Me.btnReactivateUser = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.dgvSystemUsers = New System.Windows.Forms.DataGridView()
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
        Me.lblFormTitle.Text = "   User Management"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        ' txtSystemUsername
        '
        Me.txtSystemUsername.Location = New System.Drawing.Point(110, 72)
        Me.txtSystemUsername.Name = "txtSystemUsername"
        Me.txtSystemUsername.Size = New System.Drawing.Size(210, 23)
        Me.txtSystemUsername.TabIndex = 2
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(20, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        ' txtSystemPassword
        '
        Me.txtSystemPassword.Location = New System.Drawing.Point(110, 108)
        Me.txtSystemPassword.Name = "txtSystemPassword"
        Me.txtSystemPassword.Size = New System.Drawing.Size(210, 23)
        Me.txtSystemPassword.TabIndex = 4
        Me.txtSystemPassword.UseSystemPasswordChar = True
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Role"
        '
        ' cmbSystemRole
        '
        Me.cmbSystemRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSystemRole.FormattingEnabled = True
        Me.cmbSystemRole.Location = New System.Drawing.Point(110, 144)
        Me.cmbSystemRole.Name = "cmbSystemRole"
        Me.cmbSystemRole.Size = New System.Drawing.Size(210, 23)
        Me.cmbSystemRole.TabIndex = 6
        '
        ' btnCreateUser
        '
        Me.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateUser.FlatAppearance.BorderSize = 0
        Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateUser.ForeColor = System.Drawing.Color.White
        Me.btnCreateUser.UseVisualStyleBackColor = False
        Me.btnCreateUser.Location = New System.Drawing.Point(20, 200)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(145, 34)
        Me.btnCreateUser.TabIndex = 7
        Me.btnCreateUser.Text = "Create User"
        '
        ' btnModifyRole
        '
        Me.btnModifyRole.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnModifyRole.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyRole.FlatAppearance.BorderSize = 0
        Me.btnModifyRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyRole.ForeColor = System.Drawing.Color.White
        Me.btnModifyRole.UseVisualStyleBackColor = False
        Me.btnModifyRole.Location = New System.Drawing.Point(175, 200)
        Me.btnModifyRole.Name = "btnModifyRole"
        Me.btnModifyRole.Size = New System.Drawing.Size(145, 34)
        Me.btnModifyRole.TabIndex = 8
        Me.btnModifyRole.Text = "Modify Role"
        '
        ' btnRevokeUser
        '
        Me.btnRevokeUser.BackColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnRevokeUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRevokeUser.FlatAppearance.BorderSize = 0
        Me.btnRevokeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevokeUser.ForeColor = System.Drawing.Color.White
        Me.btnRevokeUser.UseVisualStyleBackColor = False
        Me.btnRevokeUser.Location = New System.Drawing.Point(20, 244)
        Me.btnRevokeUser.Name = "btnRevokeUser"
        Me.btnRevokeUser.Size = New System.Drawing.Size(145, 34)
        Me.btnRevokeUser.TabIndex = 9
        Me.btnRevokeUser.Text = "Revoke User"
        '
        ' btnReactivateUser
        '
        Me.btnReactivateUser.BackColor = System.Drawing.Color.FromArgb(96, 96, 96)
        Me.btnReactivateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReactivateUser.FlatAppearance.BorderSize = 0
        Me.btnReactivateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReactivateUser.ForeColor = System.Drawing.Color.White
        Me.btnReactivateUser.UseVisualStyleBackColor = False
        Me.btnReactivateUser.Location = New System.Drawing.Point(175, 244)
        Me.btnReactivateUser.Name = "btnReactivateUser"
        Me.btnReactivateUser.Size = New System.Drawing.Size(145, 34)
        Me.btnReactivateUser.TabIndex = 10
        Me.btnReactivateUser.Text = "Reactivate"
        '
        ' lblHint
        '
        Me.lblHint.AutoSize = False
        Me.lblHint.Location = New System.Drawing.Point(20, 300)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(300, 80)
        Me.lblHint.TabIndex = 11
        Me.lblHint.Text = "Click a user in the table to edit. Leave the password blank when changing a role. Passwords need at least 6 characters."
        Me.lblHint.ForeColor = System.Drawing.Color.DimGray
        '
        ' dgvSystemUsers
        '
        Me.dgvSystemUsers.AllowUserToAddRows = False
        Me.dgvSystemUsers.AllowUserToDeleteRows = False
        Me.dgvSystemUsers.AllowUserToResizeRows = False
        Me.dgvSystemUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSystemUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgvSystemUsers.MultiSelect = False
        Me.dgvSystemUsers.ReadOnly = True
        Me.dgvSystemUsers.RowHeadersVisible = False
        Me.dgvSystemUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSystemUsers.Location = New System.Drawing.Point(340, 72)
        Me.dgvSystemUsers.Name = "dgvSystemUsers"
        Me.dgvSystemUsers.Size = New System.Drawing.Size(500, 420)
        Me.dgvSystemUsers.TabIndex = 12
        '
        ' UserManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(860, 520)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSystemUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSystemPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSystemRole)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.btnModifyRole)
        Me.Controls.Add(Me.btnRevokeUser)
        Me.Controls.Add(Me.btnReactivateUser)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.dgvSystemUsers)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "UserManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSystemUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSystemPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSystemRole As System.Windows.Forms.ComboBox
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents btnModifyRole As System.Windows.Forms.Button
    Friend WithEvents btnRevokeUser As System.Windows.Forms.Button
    Friend WithEvents btnReactivateUser As System.Windows.Forms.Button
    Friend WithEvents lblHint As System.Windows.Forms.Label
    Friend WithEvents dgvSystemUsers As System.Windows.Forms.DataGridView

End Class
