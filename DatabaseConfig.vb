Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

''' <summary>
''' Shared database helpers, session values and small utility functions used by every form.
''' </summary>
Module DatabaseConfig

    Private Const ServerPart As String = "Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30"

    Public ReadOnly MasterConnectionString As String = ServerPart & ";Initial Catalog=master"
    Public ReadOnly ConnectionString As String = ServerPart & ";Initial Catalog=SchoolDB"

    Public CurrentUser As String = ""
    Public CurrentRole As String = ""
    Public PassMark As Decimal = 50D

    ' ------------------------------------------------------------------
    ' Database helpers
    ' ------------------------------------------------------------------

    ' Creates a query parameter and turns Nothing into a database NULL
    Public Function Param(name As String, value As Object) As SqlParameter
        If value Is Nothing Then value = DBNull.Value
        Return New SqlParameter(name, value)
    End Function

    ' Runs a SELECT and returns the rows
    Public Function GetTable(sql As String, ParamArray args() As SqlParameter) As DataTable
        Dim dt As New DataTable()
        Using con As New SqlConnection(ConnectionString)
            Using da As New SqlDataAdapter(sql, con)
                If args IsNot Nothing AndAlso args.Length > 0 Then da.SelectCommand.Parameters.AddRange(args)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    ' Runs INSERT, UPDATE or DELETE and returns the number of rows changed
    Public Function RunCommand(sql As String, ParamArray args() As SqlParameter) As Integer
        Using con As New SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(sql, con)
                If args IsNot Nothing AndAlso args.Length > 0 Then cmd.Parameters.AddRange(args)
                con.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    ' Runs a query and returns the first value (or Nothing if no rows)
    Public Function GetValue(sql As String, ParamArray args() As SqlParameter) As Object
        Using con As New SqlConnection(ConnectionString)
            Using cmd As New SqlCommand(sql, con)
                If args IsNot Nothing AndAlso args.Length > 0 Then cmd.Parameters.AddRange(args)
                con.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    ' Creates the SchoolDB database and all tables the first time the program runs
    Public Sub EnsureDatabase()
        Using con As New SqlConnection(MasterConnectionString)
            con.Open()
            Using cmd As New SqlCommand("IF DB_ID('SchoolDB') IS NULL CREATE DATABASE SchoolDB", con)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Dim scripts() As String = {
            "IF OBJECT_ID('dbo.Classes','U') IS NULL CREATE TABLE dbo.Classes (ClassID INT IDENTITY(1,1) PRIMARY KEY, ClassName NVARCHAR(50) NOT NULL, Capacity INT NOT NULL, TeacherID INT NULL)",
            "IF OBJECT_ID('dbo.Teachers','U') IS NULL CREATE TABLE dbo.Teachers (TeacherID INT IDENTITY(1,1) PRIMARY KEY, FirstName NVARCHAR(50) NOT NULL, LastName NVARCHAR(50) NULL, Gender NVARCHAR(10) NULL, Phone NVARCHAR(20) NULL, Email NVARCHAR(100) NULL, SubjectTaught NVARCHAR(50) NULL, ClassID INT NULL)",
            "IF OBJECT_ID('dbo.Pupils','U') IS NULL CREATE TABLE dbo.Pupils (PupilID INT IDENTITY(1,1) PRIMARY KEY, FirstName NVARCHAR(50) NOT NULL, LastName NVARCHAR(50) NOT NULL, Gender NVARCHAR(10) NULL, ClassID INT NULL, DOB DATE NULL, ParentName NVARCHAR(100) NULL, ParentPhone NVARCHAR(20) NULL, Address NVARCHAR(200) NULL, TotalFees DECIMAL(10,2) NOT NULL DEFAULT 1200)",
            "IF OBJECT_ID('dbo.Subjects','U') IS NULL CREATE TABLE dbo.Subjects (SubjectID INT IDENTITY(1,1) PRIMARY KEY, SubjectName NVARCHAR(50) NOT NULL, Code NVARCHAR(10) NULL, ClassID INT NULL, TeacherID INT NULL)",
            "IF OBJECT_ID('dbo.Attendance','U') IS NULL CREATE TABLE dbo.Attendance (AttendanceID INT IDENTITY(1,1) PRIMARY KEY, PupilID INT NOT NULL, AttendanceDate DATE NOT NULL, Status NVARCHAR(10) NOT NULL, Notes NVARCHAR(200) NULL)",
            "IF OBJECT_ID('dbo.Results','U') IS NULL CREATE TABLE dbo.Results (ResultID INT IDENTITY(1,1) PRIMARY KEY, PupilID INT NOT NULL, SubjectID INT NOT NULL, Term NVARCHAR(10) NOT NULL, Score DECIMAL(5,1) NOT NULL, Grade NVARCHAR(2) NULL)",
            "IF OBJECT_ID('dbo.Payments','U') IS NULL CREATE TABLE dbo.Payments (PaymentID INT IDENTITY(1,1) PRIMARY KEY, PupilID INT NOT NULL, PaymentDate DATETIME NOT NULL DEFAULT GETDATE(), Amount DECIMAL(10,2) NOT NULL)",
            "IF OBJECT_ID('dbo.Users','U') IS NULL CREATE TABLE dbo.Users (UserID INT IDENTITY(1,1) PRIMARY KEY, Username NVARCHAR(50) NOT NULL UNIQUE, PasswordHash NVARCHAR(100) NOT NULL, Role NVARCHAR(20) NOT NULL, IsActive BIT NOT NULL DEFAULT 1)"
        }
        For Each script As String In scripts
            RunCommand(script)
        Next
    End Sub

    ' Creates the first administrator account (admin / admin123) if no users exist
    Public Sub EnsureAdmin()
        If ToInt(GetValue("SELECT COUNT(*) FROM Users")) = 0 Then
            RunCommand("INSERT INTO Users (Username, PasswordHash, Role, IsActive) VALUES (@u, @p, 'Administrator', 1)",
                       Param("@u", "admin"), Param("@p", HashPassword("admin123")))
        End If
    End Sub

    ' ------------------------------------------------------------------
    ' Safe conversions (TryParse based)
    ' ------------------------------------------------------------------

    ' Converts any value (including DBNull / Nothing) to an Integer, 0 when it cannot be parsed
    Public Function ToInt(o As Object) As Integer
        Dim n As Integer
        If o Is Nothing OrElse IsDBNull(o) Then Return 0
        If Integer.TryParse(Convert.ToString(o, CultureInfo.InvariantCulture), NumberStyles.Integer, CultureInfo.InvariantCulture, n) Then Return n
        Return 0
    End Function

    ' Converts any value (including DBNull / Nothing) to a Decimal, 0 when it cannot be parsed
    Public Function ToDec(o As Object) As Decimal
        Dim d As Decimal
        If o Is Nothing OrElse IsDBNull(o) Then Return 0D
        If Decimal.TryParse(Convert.ToString(o, CultureInfo.InvariantCulture), NumberStyles.Number, CultureInfo.InvariantCulture, d) Then Return d
        Return 0D
    End Function

    ' ------------------------------------------------------------------
    ' ComboBox helpers
    ' ------------------------------------------------------------------

    ' Fills a ComboBox from a query
    Public Sub FillCombo(cmb As ComboBox, sql As String, display As String, value As String, ParamArray args() As SqlParameter)
        Dim dt As DataTable = GetTable(sql, args)
        cmb.DataSource = Nothing
        cmb.DisplayMember = display
        cmb.ValueMember = value
        cmb.DataSource = dt
        cmb.SelectedIndex = -1
    End Sub

    ' Returns the ValueMember of the selected item, or Nothing when nothing is selected
    Public Function ComboValue(cmb As ComboBox) As Object
        If cmb.SelectedIndex = -1 Then Return Nothing
        Dim drv As DataRowView = TryCast(cmb.SelectedItem, DataRowView)
        If drv IsNot Nothing AndAlso cmb.ValueMember <> "" Then Return drv(cmb.ValueMember)
        Return cmb.SelectedItem
    End Function

    ' Returns the selected value as an Integer (0 when nothing is selected)
    Public Function ComboInt(cmb As ComboBox) As Integer
        Return ToInt(ComboValue(cmb))
    End Function

    ' Selects the item whose value matches (or clears the selection)
    Public Sub SelectCombo(cmb As ComboBox, value As Object)
        cmb.SelectedIndex = -1
        If value Is Nothing OrElse IsDBNull(value) Then Return
        Dim target As String = Convert.ToString(value, CultureInfo.InvariantCulture)
        If target = "" Then Return
        For i As Integer = 0 To cmb.Items.Count - 1
            Dim drv As DataRowView = TryCast(cmb.Items(i), DataRowView)
            Dim item As Object
            If drv IsNot Nothing AndAlso cmb.ValueMember <> "" Then
                item = drv(cmb.ValueMember)
            Else
                item = cmb.Items(i)
            End If
            If String.Equals(Convert.ToString(item, CultureInfo.InvariantCulture), target, StringComparison.OrdinalIgnoreCase) Then
                cmb.SelectedIndex = i
                Return
            End If
        Next
    End Sub

    ' ------------------------------------------------------------------
    ' Message helpers
    ' ------------------------------------------------------------------

    Public Sub ShowWarn(title As String, message As String)
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub ShowInfo(title As String, message As String)
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub ShowError(title As String, ex As Exception)
        MessageBox.Show("Something went wrong: " & ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function Confirm(title As String, message As String) As Boolean
        Return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    ' ------------------------------------------------------------------
    ' Security and grading
    ' ------------------------------------------------------------------

    Public Function HashPassword(password As String) As String
        Using sha As SHA256 = SHA256.Create()
            Dim bytes() As Byte = sha.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return Convert.ToBase64String(bytes)
        End Using
    End Function

    Public Function GradeFor(score As Decimal) As String
        If score >= 80D Then Return "A"
        If score >= 70D Then Return "B"
        If score >= 60D Then Return "C"
        If score >= 50D Then Return "D"
        If score >= 40D Then Return "E"
        Return "F"
    End Function

    Public Function Ordinal(n As Integer) As String
        If n Mod 100 >= 11 AndAlso n Mod 100 <= 13 Then Return n.ToString() & "th"
        Select Case n Mod 10
            Case 1 : Return n.ToString() & "st"
            Case 2 : Return n.ToString() & "nd"
            Case 3 : Return n.ToString() & "rd"
            Case Else : Return n.ToString() & "th"
        End Select
    End Function

End Module
