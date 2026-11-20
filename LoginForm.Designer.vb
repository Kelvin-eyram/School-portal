<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
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
        Me.lblFormTitle.Size = New System.Drawing.Size(420, 55)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "   Elementary School Portal - Login"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(50, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        ' txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(50, 118)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(320, 23)
        Me.txtUsername.TabIndex = 2
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(50, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        ' txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(50, 178)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(320, 23)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        ' btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.Location = New System.Drawing.Point(50, 235)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(150, 38)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        '
        ' btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(96, 96, 96)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Location = New System.Drawing.Point(220, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        '
        ' LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(420, 330)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elementary School Portal - Login"
        Me.AcceptButton = Me.btnLogin
        Me.CancelButton = Me.btnExit
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
