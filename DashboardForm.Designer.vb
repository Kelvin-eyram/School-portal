<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Me.lblTotalPupils = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalTeachers = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalClasses = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPresentToday = New System.Windows.Forms.Label()
        Me.btnPupils = New System.Windows.Forms.Button()
        Me.btnTeachers = New System.Windows.Forms.Button()
        Me.btnClasses = New System.Windows.Forms.Button()
        Me.btnSubjects = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnFees = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnReportCards = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblSignedIn = New System.Windows.Forms.Label()
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
        Me.lblFormTitle.Text = "   School Dashboard"
        Me.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = False
        Me.Label1.Location = New System.Drawing.Point(30, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Pupils"
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblTotalPupils
        '
        Me.lblTotalPupils.AutoSize = False
        Me.lblTotalPupils.Location = New System.Drawing.Point(30, 101)
        Me.lblTotalPupils.Name = "lblTotalPupils"
        Me.lblTotalPupils.Size = New System.Drawing.Size(185, 64)
        Me.lblTotalPupils.TabIndex = 2
        Me.lblTotalPupils.Text = "0"
        Me.lblTotalPupils.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.lblTotalPupils.ForeColor = System.Drawing.Color.White
        Me.lblTotalPupils.Font = New System.Drawing.Font("Segoe UI", 26.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalPupils.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' Label2
        '
        Me.Label2.AutoSize = False
        Me.Label2.Location = New System.Drawing.Point(235, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Teachers"
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblTotalTeachers
        '
        Me.lblTotalTeachers.AutoSize = False
        Me.lblTotalTeachers.Location = New System.Drawing.Point(235, 101)
        Me.lblTotalTeachers.Name = "lblTotalTeachers"
        Me.lblTotalTeachers.Size = New System.Drawing.Size(185, 64)
        Me.lblTotalTeachers.TabIndex = 4
        Me.lblTotalTeachers.Text = "0"
        Me.lblTotalTeachers.BackColor = System.Drawing.Color.FromArgb(46, 139, 87)
        Me.lblTotalTeachers.ForeColor = System.Drawing.Color.White
        Me.lblTotalTeachers.Font = New System.Drawing.Font("Segoe UI", 26.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalTeachers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' Label3
        '
        Me.Label3.AutoSize = False
        Me.Label3.Location = New System.Drawing.Point(440, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Classes"
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(200, 120, 20)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblTotalClasses
        '
        Me.lblTotalClasses.AutoSize = False
        Me.lblTotalClasses.Location = New System.Drawing.Point(440, 101)
        Me.lblTotalClasses.Name = "lblTotalClasses"
        Me.lblTotalClasses.Size = New System.Drawing.Size(185, 64)
        Me.lblTotalClasses.TabIndex = 6
        Me.lblTotalClasses.Text = "0"
        Me.lblTotalClasses.BackColor = System.Drawing.Color.FromArgb(200, 120, 20)
        Me.lblTotalClasses.ForeColor = System.Drawing.Color.White
        Me.lblTotalClasses.Font = New System.Drawing.Font("Segoe UI", 26.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' Label4
        '
        Me.Label4.AutoSize = False
        Me.Label4.Location = New System.Drawing.Point(645, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Present Today"
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(120, 60, 150)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' lblPresentToday
        '
        Me.lblPresentToday.AutoSize = False
        Me.lblPresentToday.Location = New System.Drawing.Point(645, 101)
        Me.lblPresentToday.Name = "lblPresentToday"
        Me.lblPresentToday.Size = New System.Drawing.Size(185, 64)
        Me.lblPresentToday.TabIndex = 8
        Me.lblPresentToday.Text = "0"
        Me.lblPresentToday.BackColor = System.Drawing.Color.FromArgb(120, 60, 150)
        Me.lblPresentToday.ForeColor = System.Drawing.Color.White
        Me.lblPresentToday.Font = New System.Drawing.Font("Segoe UI", 26.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPresentToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' btnPupils
        '
        Me.btnPupils.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnPupils.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPupils.FlatAppearance.BorderSize = 0
        Me.btnPupils.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPupils.ForeColor = System.Drawing.Color.White
        Me.btnPupils.UseVisualStyleBackColor = False
        Me.btnPupils.Location = New System.Drawing.Point(30, 195)
        Me.btnPupils.Name = "btnPupils"
        Me.btnPupils.Size = New System.Drawing.Size(185, 60)
        Me.btnPupils.TabIndex = 9
        Me.btnPupils.Text = "Pupils"
        '
        ' btnTeachers
        '
        Me.btnTeachers.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeachers.FlatAppearance.BorderSize = 0
        Me.btnTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeachers.ForeColor = System.Drawing.Color.White
        Me.btnTeachers.UseVisualStyleBackColor = False
        Me.btnTeachers.Location = New System.Drawing.Point(235, 195)
        Me.btnTeachers.Name = "btnTeachers"
        Me.btnTeachers.Size = New System.Drawing.Size(185, 60)
        Me.btnTeachers.TabIndex = 10
        Me.btnTeachers.Text = "Teachers"
        '
        ' btnClasses
        '
        Me.btnClasses.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnClasses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClasses.FlatAppearance.BorderSize = 0
        Me.btnClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClasses.ForeColor = System.Drawing.Color.White
        Me.btnClasses.UseVisualStyleBackColor = False
        Me.btnClasses.Location = New System.Drawing.Point(440, 195)
        Me.btnClasses.Name = "btnClasses"
        Me.btnClasses.Size = New System.Drawing.Size(185, 60)
        Me.btnClasses.TabIndex = 11
        Me.btnClasses.Text = "Classes"
        '
        ' btnSubjects
        '
        Me.btnSubjects.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubjects.FlatAppearance.BorderSize = 0
        Me.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjects.ForeColor = System.Drawing.Color.White
        Me.btnSubjects.UseVisualStyleBackColor = False
        Me.btnSubjects.Location = New System.Drawing.Point(645, 195)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(185, 60)
        Me.btnSubjects.TabIndex = 12
        Me.btnSubjects.Text = "Subjects"
        '
        ' btnAttendance
        '
        Me.btnAttendance.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttendance.FlatAppearance.BorderSize = 0
        Me.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.UseVisualStyleBackColor = False
        Me.btnAttendance.Location = New System.Drawing.Point(30, 275)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(185, 60)
        Me.btnAttendance.TabIndex = 13
        Me.btnAttendance.Text = "Attendance"
        '
        ' btnResults
        '
        Me.btnResults.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResults.FlatAppearance.BorderSize = 0
        Me.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResults.ForeColor = System.Drawing.Color.White
        Me.btnResults.UseVisualStyleBackColor = False
        Me.btnResults.Location = New System.Drawing.Point(235, 275)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(185, 60)
        Me.btnResults.TabIndex = 14
        Me.btnResults.Text = "Results"
        '
        ' btnFees
        '
        Me.btnFees.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFees.FlatAppearance.BorderSize = 0
        Me.btnFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFees.ForeColor = System.Drawing.Color.White
        Me.btnFees.UseVisualStyleBackColor = False
        Me.btnFees.Location = New System.Drawing.Point(440, 275)
        Me.btnFees.Name = "btnFees"
        Me.btnFees.Size = New System.Drawing.Size(185, 60)
        Me.btnFees.TabIndex = 15
        Me.btnFees.Text = "Fees"
        '
        ' btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.UseVisualStyleBackColor = False
        Me.btnReports.Location = New System.Drawing.Point(645, 275)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(185, 60)
        Me.btnReports.TabIndex = 16
        Me.btnReports.Text = "Reports"
        '
        ' btnUserManagement
        '
        Me.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserManagement.FlatAppearance.BorderSize = 0
        Me.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserManagement.ForeColor = System.Drawing.Color.White
        Me.btnUserManagement.UseVisualStyleBackColor = False
        Me.btnUserManagement.Location = New System.Drawing.Point(30, 355)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(185, 60)
        Me.btnUserManagement.TabIndex = 17
        Me.btnUserManagement.Text = "User Management"
        '
        ' btnReportCards
        '
        Me.btnReportCards.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.btnReportCards.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportCards.FlatAppearance.BorderSize = 0
        Me.btnReportCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportCards.ForeColor = System.Drawing.Color.White
        Me.btnReportCards.UseVisualStyleBackColor = False
        Me.btnReportCards.Location = New System.Drawing.Point(235, 355)
        Me.btnReportCards.Name = "btnReportCards"
        Me.btnReportCards.Size = New System.Drawing.Size(185, 60)
        Me.btnReportCards.TabIndex = 18
        Me.btnReportCards.Text = "Report Cards"
        '
        ' btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(178, 34, 34)
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.UseVisualStyleBackColor = False
        Me.btnLogout.Location = New System.Drawing.Point(645, 355)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(185, 60)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = "Logout"
        '
        ' lblSignedIn
        '
        Me.lblSignedIn.AutoSize = False
        Me.lblSignedIn.Location = New System.Drawing.Point(30, 455)
        Me.lblSignedIn.Name = "lblSignedIn"
        Me.lblSignedIn.Size = New System.Drawing.Size(500, 24)
        Me.lblSignedIn.TabIndex = 20
        Me.lblSignedIn.Text = "Signed in as:"
        '
        ' DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(244, 246, 250)
        Me.ClientSize = New System.Drawing.Size(860, 520)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalPupils)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalTeachers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalClasses)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPresentToday)
        Me.Controls.Add(Me.btnPupils)
        Me.Controls.Add(Me.btnTeachers)
        Me.Controls.Add(Me.btnClasses)
        Me.Controls.Add(Me.btnSubjects)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.btnFees)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnUserManagement)
        Me.Controls.Add(Me.btnReportCards)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblSignedIn)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPupils As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTeachers As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalClasses As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPresentToday As System.Windows.Forms.Label
    Friend WithEvents btnPupils As System.Windows.Forms.Button
    Friend WithEvents btnTeachers As System.Windows.Forms.Button
    Friend WithEvents btnClasses As System.Windows.Forms.Button
    Friend WithEvents btnSubjects As System.Windows.Forms.Button
    Friend WithEvents btnAttendance As System.Windows.Forms.Button
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents btnFees As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnUserManagement As System.Windows.Forms.Button
    Friend WithEvents btnReportCards As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblSignedIn As System.Windows.Forms.Label

End Class
