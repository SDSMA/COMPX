'=================================================
' Recipe Module
'=================================================

Option Explicit On

'Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Runtime.InteropServices

Imports System.Text.RegularExpressions

Module Recipe_Module

    Public First_Recipe_Data_Sent As Boolean = False
    Public First_Recipe_Done_Sent As Boolean = False

    'Public First_Recipe_Data_PLC_Response As Boolean = False

    Public Recipe_Download_OK As Boolean = False
    Public Recipe_Selected As Boolean = False

    Dim openfiledialog1 As OpenFileDialog = New OpenFileDialog

    '=================================================
    'Find database
    '=================================================
    Public Function Start_DB()
        Dim DBFileExists As Boolean
        'this is what we are looking for: 
        'Provider = Microsoft.Jet.OLEDB.4.0;Data Source=<fully qualified file And path name>
        'Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\CompX\Recipe\NCLRecipe.mdb

        Dim strStart As Integer = My.Settings.NCLRecipeConnectionString.IndexOf(";Data Source")
        Dim strDBpath As String
        Dim response As Boolean = False ' true if DB found and opened

        If strStart > 0 Then
            'find the = mark. remaining text is filepath.
            strStart = My.Settings.NCLRecipeConnectionString.IndexOf("=", strStart)
            strDBpath = Mid(My.Settings.NCLRecipeConnectionString, strStart + 2)

            If System.IO.File.Exists(strDBpath) Then
                'file exists
                'nothing to do here
                response = True
            Else
                'file doesn't exist
                MsgBox("Cannot find the path in Database connection string: " & My.Settings.NCLRecipeConnectionString & "." & vbCrLf & "Please locate the correct Recipe Database ...", MessageBoxButtons.OK)
                FindDB()
            End If
        Else
            MsgBox("Database connection string is not valid: " & My.Settings.NCLRecipeConnectionString & "." & vbCrLf & "Please locate the correct Recipe Database ...", MessageBoxButtons.OK)
            FindDB()
        End If

        If Not DBFileExists Then
            MsgBox("There is no Database connection to : " & My.Settings.NCLRecipeConnectionString & "." & vbCrLf & "The application cannot perform correctly.", MessageBoxButtons.OK)
            response = False
        End If
        Return response
    End Function

    '=================================================
    'Find database
    '=================================================
    Public Function FindDB()
        'Find the Recipe Database
        'Declare provider and security
        Dim provider As String = "Microsoft.Jet.OLEDB.4.0"
        Dim security As String = "False"
        Dim response As Boolean = False
        'Filter only allows selection of access database file

        openfiledialog1.Filter = "Access Documents|*.mdb"
        openfiledialog1.FileName = ""
        openfiledialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)

        'OpenFileDialog returns path selected by user
        If openfiledialog1.ShowDialog = DialogResult.OK Then

            'Get filename from OpenFileDialog
            My.Settings.DatabaseFileName = openfiledialog1.FileName

            'Re-declare strDatabase
            strDatabase = My.Settings.DatabaseFileName

            'Connection string to the database
            My.Settings.Item("NCLRecipeConnectionString") = "Provider=" & provider & ";Data Source =" & strDatabase

            'Re-declare strDatabaseCon
            strDatabaseCon = My.Settings.NCLRecipeConnectionString

            'Save application settings
            My.Settings.Save()
            response = True
        Else
            MessageBox.Show("No Database Path selected.", "Fatal Error", MessageBoxButtons.OK)
            response = False
        End If
        Return response
    End Function

    Public Function GetDatabaseConnectionString()
        ' https://www.mztools.com/articles/2007/MZ2007011.aspx

        Dim ops As New Operations
        Dim dataSource = ""

        If ops.GetConnection(dataSource) Then

            My.Settings.Item("NCLRecipeConnectionString") = ops.NewConnectionString
            My.Settings.Save()
            GetDatabaseConnectionString = True
        Else
            ' failed to get connection
            GetDatabaseConnectionString = False
        End If
    End Function
End Module


