Option Explicit On

Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Runtime.InteropServices
'Imports System.Data.OleDb
'Imports System.Data.SqlClient
'Imports Microsoft.Office.Interop
'Imports System.Text.RegularExpressions
'Imports System.Data.Common
'Imports System
'Imports System.IO.Ports 'Access SerialPort Object

Imports System.IO

'===================================================
'Load Key Files to WorkFile DataGridView
'Setup Key series for Markers
'Convert Key Series into PrintCode for HMI
'Setup Tumbler Code for PLC
'Parse Tumbler Code into digits
'===================================================
Public Class Keyfile_Select_Form

    'Public xlapp As Excel.Application
    'Public xlworkbook As Microsoft.Office.Interop.Excel.Workbook
    'Public xlworksheet As Excel.Worksheet

    Dim caption As String = "Select a KeyFile"
    Dim msg As String = ""
    Dim dialog_result As DialogResult
    Dim result

    '===================================================
    ' Load KeyFile Form
    '===================================================
    Private Sub Keyfile_Select_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tumbler_KitTableAdapter.Fill(Me.NCLRecipeDataSet.Tumbler_Kit)
        Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)
        Me.SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)
        Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)
        Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
        Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)

        'Initialize Key Data
        Key_Series = My.Settings.Key_Series
        Convert_KeySeries()
        Key_Code = My.Settings.Key_Code

        ' Reset Tumblers OK
        TumblerCode_OK = False
        'MainMenu.Tumblers_Button.BackColor = Color.Yellow
        MainMenu.Tumblers_Button.Text = "Tumbler Codes are not valid."
    End Sub

    '===================================================
    ' KeyFile Form Shown
    '===================================================
    Private Sub Keyfile_Select_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Work_File_Path = My.Settings.Work_File_Path
        KeyFile_Status_Label.Text = "Key File Status"

        'Adjust DGV row position
        If IsNumeric(My.Settings.WorkFile_CurrentRow) Then
            WorkFile_CurrentRow = My.Settings.WorkFile_CurrentRow
        Else
            WorkFile_CurrentRow = 0
        End If
        DGVVisibleRow(DataGridView1, WorkFile_CurrentRow)

        Load_WorkFile_To_DGV()
    End Sub

    '===================================================
    'Select KeyFile
    '===================================================
    Private Sub Keyfile_Select_btn_Click(sender As Object, e As EventArgs) Handles Keyfile_Select_btn.Click
        ' Open File Dialog
        Dim Result_dialog As DialogResult

        Dim xlRow As Integer = 1
        Dim keyfilename As String

        caption = "Select Key File"
        Try
            ' restore last used folder path
            If My.Settings.Key_File_Path IsNot Nothing Then
                Key_File_Dialog.InitialDirectory = My.Settings.Key_File_Path
            Else
                Key_File_Dialog.InitialDirectory = "C:\CompX\"
            End If

            ' get keyfile selection
            Result_dialog = Key_File_Dialog.ShowDialog()

            If Result_dialog = DialogResult.Cancel Then
                Return
            End If
            keyfilename = Key_File_Dialog.FileName

        Catch ex As Exception
            MessageBox.Show("Cannot open Key File folder " & vbCrLf &
                            ex.Message,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet

        Try
            ' Open KeyFile workbook
            xlapp = New Excel.Application
            xlapp.Visible = False
            xlworkbook = xlapp.Workbooks.Open(keyfilename)
            xlworksheet = xlworkbook.Worksheets(1)
            xlworksheet.Activate()

        Catch ex As Exception
            GoTo CleanUp
            MessageBox.Show("Cannot open Key File: " & keyfilename & vbCrLf &
                            ex.Message,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

        Try
            ' Evaluate Dialog result
            If Result_dialog = DialogResult.OK Then

                KeyFile = Key_File_Dialog.FileName

                ' Save file path
                My.Settings.Key_File_Path = System.IO.Path.GetDirectoryName(KeyFile)

                ' Save Filename
                My.Settings.Keyfile = KeyFile
                My.Settings.Save()

                WorkFileMessage(caption, "File : " & vbTab & KeyFile)

                'let everyone catch up
                CatchUp()

                ' Verify worksheet headings are correct, and there is at last one row of data...
                ' Get column headings
                Dim col(12) As Object

                Dim colSeriesOK As Boolean = False
                Dim colKeyNoOK As Boolean = False
                Dim colKeyCodeOK As Boolean = False
                Dim colMKCodeOK As Boolean = False
                Dim colQtyOK As Boolean = False
                Dim colDescOK As Boolean = False
                Dim colAssignedToOK As Boolean = False
                Dim colDateOK As Boolean = False

                Dim colnum_Series As Integer = -1
                Dim colnum_KeyNo As Integer = -1
                Dim colnum_KeyCode As Integer = -1
                Dim colnum_Qty As Integer = -1
                Dim colnum_Desc As Integer = -1
                Dim colnum_AssignedTo As Integer = -1
                Dim colnum_Date As Integer = -1
                Dim colnum_MKCode As Integer = -1

                col(0) = xlworksheet.Range("A1").Value
                col(1) = xlworksheet.Range("B1").Value
                col(2) = xlworksheet.Range("C1").Value
                col(3) = xlworksheet.Range("D1").Value
                col(4) = xlworksheet.Range("E1").Value
                col(5) = xlworksheet.Range("F1").Value
                col(6) = xlworksheet.Range("G1").Value
                col(7) = xlworksheet.Range("H1").Value
                col(8) = xlworksheet.Range("I1").Value
                col(9) = xlworksheet.Range("J1").Value
                col(10) = xlworksheet.Range("K1").Value
                col(11) = xlworksheet.Range("K1").Value

                ' check for valid headings and data
                For i = 0 To 7
                    If Not IsNothing(col(i)) Then
                        Try
                            If (col(i).toupper) = "Series".ToUpper Then
                                colSeriesOK = True
                                colnum_Series = i
                            End If
                        Catch ex As Exception
                            msg = "Cannot import KeyFile ..." & vbCrLf &
                                    "Error reading : " & col(i)
                            WorkFileMessage(caption, msg)
                            MessageBox.Show(msg & vbCrLf &
                                            ex.Message,
                                            caption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)
                            GoTo CleanUp
                        End Try

                        Try
                            If col(i).toupper = "KeyNo".ToUpper Then
                                colKeyNoOK = True
                                colnum_KeyNo = i
                            End If
                        Catch ex As Exception
                            'msg = "Cannot import KeyFile ..." & vbCrLf &
                            '            "Error reading : " & col(i)
                            '    WorkFileMessage(caption, msg)
                            '    MessageBox.Show(msg & vbCrLf &
                            '                    ex.Message,
                            '                    caption,
                            '                    MessageBoxButtons.OK,
                            '                    MessageBoxIcon.Asterisk,
                            '                    MessageBoxDefaultButton.Button1)
                            'GoTo CleanUp
                        End Try

                        Try
                            If col(i).toupper = "KeyCode".ToUpper Then
                                colKeyCodeOK = True
                                colnum_KeyCode = i
                            End If
                        Catch ex As Exception
                            msg = "Cannot import KeyFile ..." & vbCrLf &
                                    "Error reading : " & col(i)
                            WorkFileMessage(caption, msg)
                            MessageBox.Show(msg & vbCrLf &
                                            ex.Message,
                                            caption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)
                            GoTo CleanUp
                        End Try

                        Try
                            If (col(i).toupper.SUBSTRING(0, Math.Min(col(i).length, 2)) = "MK".ToUpper) Then
                                colMKCodeOK = True
                                colnum_MKCode = i
                            End If
                        Catch ex As Exception
                            'msg = "Cannot import KeyFile ..." & vbCrLf &
                            '        "Error reading : " & col(i)
                            'WorkFileMessage(caption, msg)
                            'MessageBox.Show(msg & vbCrLf &
                            '                ex.Message,
                            '                caption,
                            '                MessageBoxButtons.OK,
                            '                MessageBoxIcon.Asterisk,
                            '                MessageBoxDefaultButton.Button1)
                            'GoTo CleanUp
                        End Try

                        Try
                            If (col(i).toupper.SUBSTRING(0, 1) = "Q".ToUpper) Then
                                colQtyOK = True
                                colnum_Qty = i
                            End If
                        Catch ex As Exception
                            msg = "Cannot import KeyFile ..." & vbCrLf &
                                    "Error reading : " & col(i)
                            WorkFileMessage(caption, msg)
                            MessageBox.Show(msg & vbCrLf &
                                            ex.Message,
                                            caption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)
                            'GoTo CleanUp
                        End Try

                        Try
                            If (col(i).toupper.SUBSTRING(0, Math.Min(col(i).length, 4)) = "Desc".ToUpper) Then
                                colDescOK = True
                                colnum_Desc = i
                            End If
                        Catch ex As Exception
                            'msg = "Cannot import KeyFile ..." & vbCrLf &
                            '        "Error reading : " & col(i)
                            'WorkFileMessage(caption, msg)
                            'MessageBox.Show(msg & vbCrLf &
                            '                ex.Message,
                            '                caption,
                            '                MessageBoxButtons.OK,
                            '                MessageBoxIcon.Asterisk,
                            '                MessageBoxDefaultButton.Button1)
                            'GoTo CleanUp
                        End Try

                        Try
                            If (col(i).toupper.SUBSTRING(0, Math.Min(col(i).length, 6)) = "Assign".ToUpper) Then
                                colAssignedToOK = True
                                colnum_AssignedTo = i
                            End If
                        Catch ex As Exception
                            'msg = "Cannot import KeyFile ..." & vbCrLf &
                            '        "Error reading : " & col(i)
                            'WorkFileMessage(caption, msg)
                            'MessageBox.Show(msg & vbCrLf &
                            '                ex.Message,
                            '                caption,
                            '                MessageBoxButtons.OK,
                            '                MessageBoxIcon.Asterisk,
                            '                MessageBoxDefaultButton.Button1)
                            'GoTo CleanUp
                        End Try

                        Try
                            If (col(i).toupper.SUBSTRING(0, Math.Min(col(i).length, 4)) = "Date".ToUpper) Then
                                colDateOK = True
                                colnum_Date = i
                            End If
                        Catch ex As Exception
                            '    msg = "Cannot import KeyFile ..." & vbCrLf &
                            '            "Error reading : " & col(i)
                            '    WorkFileMessage(caption, msg)
                            '    MessageBox.Show(msg & vbCrLf &
                            '                    ex.Message,
                            '                    caption,
                            '                    MessageBoxButtons.OK,
                            '                    MessageBoxIcon.Asterisk,
                            '                    MessageBoxDefaultButton.Button1)
                            'GoTo CleanUp
                        End Try
                    End If
                Next

                ' test for valid Series, Code, Quantity
                If colSeriesOK And
                    colKeyCodeOK And
                    colQtyOK Then

                    ' Count number of valid data rows
                    xlRow = 2
                    Do Until (IsNothing(xlworksheet.Cells(xlRow, 1).Value) Or xlRow > 10000)
                        xlRow += 1
                    Loop

                    ' Update Row Count
                    WorkFile_RowCount = xlRow - 2

                    If WorkFile_RowCount <= 0 Then
                        msg = "Workfile row count = " & WorkFile_RowCount & vbCrLf &
                                "Data in file " & keyfilename & " at row " & xlRow & " is not valid."

                        MessageBox.Show(msg,
                                        caption,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1)
                        GoTo CleanUp
                    End If

                    My.Settings.WorkFile_RowCount = WorkFile_RowCount

                    If WorkFile_RowCount >= 1 Then
                        WorkFile_Complete = False
                        KeyFile_OK = False

                        ' Archive existing WorkFile
                        WorkFileMessage(caption, "Archiving old WorkFile...")
                        ArchiveWorkFile()

                        ' copy New KeyFile to DGV
                        WorkFileMessage(caption, "Copying KeyFile to Data View...")

                        PLC_Tumbler_Download_OK = False

                        Try
                            'Clear DGV data. start with clean view
                            Clear_DGV1()

                            ' Get any existing data from all rows, first 7 columns
                            DataGridView1.Rows.Add(WorkFile_RowCount)
                            For i As Integer = 0 To WorkFile_RowCount - 1

                                If colnum_Series >= 0 Then
                                    DataGridView1.Rows(i).Cells("Series").Value = xlworksheet.Cells(i + 2, colnum_Series + 1).value
                                End If

                                If colnum_KeyNo >= 0 Then
                                    DataGridView1.Rows(i).Cells("KeyNo").Value = xlworksheet.Cells(i + 2, colnum_KeyNo + 1).value
                                End If

                                If colnum_KeyCode >= 0 Then
                                    DataGridView1.Rows(i).Cells("KeyCode").Value = xlworksheet.Cells(i + 2, colnum_KeyCode + 1).value
                                End If

                                If colnum_MKCode >= 0 Then
                                    DataGridView1.Rows(i).Cells("MKCode").Value = xlworksheet.Cells(i + 2, colnum_KeyCode + 1).value
                                End If

                                If colnum_Qty >= 0 Then
                                    DataGridView1.Rows(i).Cells("Qty").Value = xlworksheet.Cells(i + 2, colnum_Qty + 1).value
                                End If

                                If colnum_Date >= 0 Then
                                    DataGridView1.Rows(i).Cells("Date").Value = xlworksheet.Cells(i + 2, colnum_Date + 1).value
                                End If

                                If colnum_AssignedTo >= 0 Then
                                    DataGridView1.Rows(i).Cells("AssignedTo").Value = xlworksheet.Cells(i + 2, colnum_Date + 1).value
                                End If

                                WorkFileMessage(caption, "Row :" & vbTab & i)
                            Next

                            WorkFileMessage(caption, "Row :" & vbTab & (WorkFile_RowCount - 1))

                            DataGridView1.Refresh()
                            DataGridView1.Update()

                            WorkFileMessage(caption, "KeyFile is copied to Data View." & vbCrLf &
                                            "Closing Keyfile workbook.")

                            ' Done with Key File. Close it.
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                            If Not xlworksheet Is Nothing Then
                                ReleaseObject(xlworksheet)
                                xlworksheet = Nothing
                            End If

                            If Not xlworkbook Is Nothing Then
                                xlworkbook.Close(False)
                                ReleaseObject(xlworkbook)
                                xlworkbook = Nothing
                            End If

                            If Not xlapp Is Nothing Then
                                xlapp.Quit()
                                ReleaseObject(xlapp)
                                xlapp = Nothing
                            End If
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

                            GC.Collect()
                            GC.WaitForPendingFinalizers()

                            KillExcelProcess()

                            ' Save Data View to WorkFile
                            Save_DGV_To_WorkFile()

                        Catch ex As Exception
                            msg = "Cannot copy KeyFile to Data View ..."
                            WorkFileMessage(caption, msg)
                            MessageBox.Show(msg & vbCrLf &
                                            ex.Message,
                                            caption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button1)
                            GoTo CleanUp
                        End Try
                    Else
                        WorkFileMessage(caption, "No row found in KeyFile: " & vbCrLf & Work_File_Path)
                        GoTo CleanUp
                    End If
                End If

                'let everyone catch up
                CatchUp()

                ' Initialize current row
                WorkFile_CurrentRow = 0

                My.Settings.WorkFile_CurrentRow = WorkFile_CurrentRow
                My.Settings.WorkFile_RowCount = WorkFile_RowCount
                My.Settings.Save()

                ' Set DGV to current row
                Try
                    DataGridView1.Rows(WorkFile_CurrentRow).Selected = True
                Catch ex As Exception
                    msg = "Cannot set Data View to current Key Series"
                    WorkFileMessage(caption, msg)
                    msg = msg & vbCrLf & ex.ToString

                    MessageBox.Show(msg,
                                    caption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                End Try

                ' save settings
                Save_KeyFile_Settings()

                WorkFile_Complete = False
                KeyFile_OK = False
                MainMenu.KeyFile_Form_Button.BackColor = SystemColors.Control

                ' Point to Start button
                Send_First_Recipe_Button.Select()

                WorkFileMessage(caption, "WorkFile copied from : " & My.Settings.Key_File_Path)
                Wait_Message_Form.Close()
            End If
        Catch ex As Exception
            msg = "Cannot parse Key File"
            WorkFileMessage(caption, msg)
            msg = msg & vbCrLf & ex.ToString

            MessageBox.Show(msg,
                                    caption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
            GoTo CleanUp

        End Try

CleanUp:
        KeyFile_OK = False
        MainMenu.KeyFile_Form_Button.BackColor = Color.Yellow
        Try
            Wait_Message_Form.Close()

#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            If Not xlworksheet Is Nothing Then
                ReleaseObject(xlworksheet)
                xlworksheet = Nothing
            End If

            If Not xlworkbook Is Nothing Then
                xlworkbook.Close()
                ReleaseObject(xlworkbook)
                xlworkbook = Nothing
            End If

            If Not xlapp Is Nothing Then
                xlapp.Quit()
                ReleaseObject(xlapp)
                xlapp = Nothing
            End If
#Enable Warning BC42104 ' Variable is used before it has been assigned a value


            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch ex As Exception
            MessageBox.Show("Cannot close KeyFile Excel workbook." & vbCrLf &
                                ex.Message.ToString,
                                caption)
        End Try
    End Sub

    ' ======================================================
    ' Archive Work File with date time stamp
    ' ======================================================
    Private Function ArchiveWorkFile() As Boolean
        Dim response As Boolean = False
        ' archive work file only if file exists
        If System.IO.File.Exists(Work_File_Path) Then
            Try
                ' save current WorkFile to new filename
                Dim xFileName = Work_File_Path.Replace(".xls", "_" & Key_Series & "_" & DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") & ".xls")
                My.Computer.FileSystem.CopyFile(Work_File_Path, xFileName, overwrite:=True)
                File.SetLastWriteTime(xFileName, DateTime.Now)

                'let everyone catch up
                CatchUp()
                response = True
            Catch ex As Exception
                response = False
                WorkFileMessage(caption, "Cannot copy WorkFile to archive ...")
                MessageBox.Show("Cannot copy WorkFile to archive ..." & vbCrLf &
                                ex.Message.ToString,
                                caption)
            End Try
        Else
            response = False
        End If
    End Function
    '============================================================
    'Save settings for selected KeyFile 
    '============================================================
    Private Sub Save_KeyFile_Settings()
        Try
            Key_Series = CStr(DataGridView1("Series", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_Series = ""
        End Try
        Try
            Key_No = CStr(DataGridView1("KeyNo", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_No = ""
        End Try
        Try
            Key_Code = CStr(DataGridView1("KeyCode", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_Code = ""
        End Try
        Try
            Key_Qty = CStr(DataGridView1("Qty", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_Qty = ""
        End Try
        Try
            Key_MK_Code = CStr(DataGridView1("MKCode", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_MK_Code = ""
        End Try
        Try
            Key_Desc = CStr(DataGridView1("Desc", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_Desc = ""
        End Try
        Try
            Key_Assigned_To = CStr(DataGridView1("AssignedTo", WorkFile_CurrentRow).Value)
        Catch ex As Exception
            Key_Assigned_To = ""
        End Try
        Try
            Key_Date = CStr(DataGridView1("Date", WorkFile_CurrentRow).Value)

            If Key_Date.Year < 2019 Then
                Key_Date = Nothing
            End If
        Catch ex As Exception
            Key_Date = Nothing
        End Try
        Try
            My.Settings.Key_Series = Key_Series
            My.Settings.Key_Code = Key_Code
            My.Settings.Key_No = Key_No
            My.Settings.Key_MK_Code = Key_MK_Code
            My.Settings.Key_Qty = Key_Qty
            My.Settings.Key_Desc = Key_Desc
            My.Settings.Key_Assigned_To = Key_Assigned_To
            My.Settings.Key_Date = CStr(Key_Date)

            My.Settings.Save()

        Catch ex As Exception
            MessageBox.Show("Cannot save settings." & vbCrLf & ex.Message.ToString,
                            caption)
        End Try
    End Sub

    '============================================================
    'Close WorkFile row button
    '============================================================
    Private Sub CloseSeries_Button_Click(sender As Object, e As EventArgs)
        CloseCurrentWorkFileRow()
    End Sub

    '============================================================
    'Start next WorkFile row
    '============================================================
    'Private Sub StartRow_Button_Click(sender As Object, e As EventArgs) Handles StartRow_Button.Click
    '    KeyFile_OK = StartWorkFileRow(WorkFile_CurrentRow)

    '    If KeyFile_OK Then
    '        MainMenu.KeyFile_Form_Button.BackColor = SystemColors.Control

    '        If R_Sta_14_Enable Then
    '            'Write variable returns true if variable is verified after download
    '            Marker_1_Variable_Verified = Marker_1_Write_Variable(Marker_1_VarNumber, My.Settings.Key_Code)
    '            If Marker_1_Variable_Verified = False Then
    '                MainMenu.Marker_14_Button.BackColor = Color.Yellow
    '                MainMenu.Marker_14_Button.Text = "Program Variable not verified"
    '            End If
    '        End If

    '        If R_Sta_17_Enable Then
    '            'Write variable returns true if variable is verified after download
    '            Marker_2_Variable_Verified = Marker_2_Write_Variable(Marker_2_VarNumber, My.Settings.Key_Code)
    '            If Marker_2_Variable_Verified = False Then
    '                MainMenu.Marker_17_Button.BackColor = Color.Yellow
    '                MainMenu.Marker_17_Button.Text = "Program Variable not verified"
    '            End If
    '        End If
    '    Else
    '        MainMenu.KeyFile_Form_Button.BackColor = Color.Yellow
    '    End If
    'End Sub

    '============================================================
    ' Open Workfile button
    '============================================================
    Private Sub Open_WorkFile_Button_Click(sender As Object, e As EventArgs)
        Try
            ' Open WorkFile workbook
            Dim xlapp = New Excel.Application
            xlapp.Visible = True
            Dim xlworkbook = xlapp.Workbooks.Open(Work_File_Path, [ReadOnly]:=False)
            Dim xlworksheet = xlworkbook.Worksheets(1)
            xlworksheet.Activate()

        Catch ex As Exception
            MessageBox.Show("Cannot open Work File." & vbCrLf &
                            ex.Message,
                            caption)
        End Try
    End Sub

    '============================================================
    ' Open Workfile
    '============================================================
    'Public Sub Open_WorkFile()
    '    Try
    '        ' Open WorkFile workbook
    '        xlapp = New Excel.Application
    '        xlapp.Visible = False
    '        xlworkbook = xlapp.Workbooks.Open(Work_File_Path, [ReadOnly]:=False)
    '        xlworksheet = xlworkbook.Worksheets(1)
    '        xlworksheet.Activate()

    '    Catch ex As Exception
    '        MessageBox.Show("Cannot open Work File." & vbCrLf &
    '                        ex.Message,
    '                        caption)
    '        xlworkbook.Close(False)
    '        xlapp.Quit()
    '    End Try
    'End Sub

    '============================================================
    'New Key Series row of WorkFile is entered by Operator 
    '============================================================
    Private Sub WorkFile_Current_Row_TextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles WorkFile_Current_Row_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim caption As String = "Select WorkFile Row"
            If CInt(WorkFile_Current_Row_TextBox.Text) > 0 Then

                GlobalVariables.WorkFile_CurrentRow = WorkFile_Current_Row_TextBox.Text
                My.Settings.WorkFile_CurrentRow = WorkFile_Current_Row_TextBox.Text
                My.Settings.Save()

                DataGridView1.Rows(GlobalVariables.WorkFile_CurrentRow).Selected = True
                DataGridView1.FirstDisplayedScrollingRowIndex = GlobalVariables.WorkFile_CurrentRow

                DataGridView1.Refresh()
                DataGridView1.Update()
            Else
                MessageBox.Show(WorkFile_Current_Row_TextBox.Text & " is not a valid row in the WorkFile.",
                                caption)
                WorkFile_Current_Row_TextBox.Text = My.Settings.WorkFile_CurrentRow
            End If
        End If
    End Sub

    '============================================================
    ' Adjust DGV to display selected row
    '============================================================
    Private Sub DGVVisibleRow(view, rowToShow)
        'view = DataGridView
        'rowtoshow = integer

        Dim countVisible As Integer
        Dim firstVisible As Integer
        If (rowToShow >= 0 And rowToShow < view.RowCount) Then
            countVisible = view.DisplayedRowCount(False)
            firstVisible = Math.Max(rowToShow - (countVisible / 2), 0)
            view.FirstDisplayedScrollingRowIndex = firstVisible
        End If
    End Sub

    '============================================================
    'Convert Key Series to PrintCodes for HMI
    '============================================================
    Private Sub Convert_Workfile_Button_Click(sender As Object, e As EventArgs) Handles Convert_Workfile_Button.Click
        Convert_KeySeries()
    End Sub

    '============================================================
    'Import WorkFile to DGV
    '============================================================
    Private Sub ExcelToDGV_Button_Click(sender As Object, e As EventArgs) Handles ExcelToDGV_Button.Click
        If Load_WorkFile_To_DGV() Then
            KeyFile_Status_Label.Text = "KeyFile Loaded"
        Else
            KeyFile_Status_Label.Text = "KeyFile did not load"
        End If
    End Sub

    '============================================================
    'Save WorkFile to Excel button
    '============================================================
    Private Sub Save_Workfile_Button_Click(sender As Object, e As EventArgs) Handles Save_Workfile_Button.Click
        Save_DGV_To_WorkFile()
    End Sub

    '============================================================
    'Clear Data Grid View
    '============================================================
    Private Sub Clear_DGV1()
        'Clear DGV data. start with clean view
        DataGridView1.DataSource = Nothing

        For i = DataGridView1.Columns.Count - 1 To 0 Step -1
            DataGridView1.Columns.RemoveAt(i)
        Next

        For i = DataGridView1.Rows.Count - 1 To 0 Step -1
            DataGridView1.Rows.RemoveAt(i)
        Next

        ' Set DGV Columns
        DataGridView1.Columns.Add("Series", "Series")
        DataGridView1.Columns.Add("KeyNo", "Key No")
        DataGridView1.Columns.Add("KeyCode", "Key Code")
        DataGridView1.Columns.Add("MKCode", "MK Code")
        DataGridView1.Columns.Add("Qty", "Qty")
        DataGridView1.Columns.Add("Desc", "Desc")
        DataGridView1.Columns.Add("AssignedTo", "Assigned To")
        DataGridView1.Columns.Add("Date", "Date")
        DataGridView1.Columns.Add("Blank", "--")
        DataGridView1.Columns.Add("QtyMadeGood", "Qty Good")
        DataGridView1.Columns.Add("QtyMadeBad", "Qty Bad")
        DataGridView1.Columns.Add("TimeStarted", "Time Started")
        DataGridView1.Columns.Add("TimeCompleted", "Time Completed")

        DataGridView1.Refresh()
        DataGridView1.Update()
    End Sub

    '============================================================
    ' Load Work File to Data Grid View
    '============================================================
    Private Function Load_WorkFile_To_DGV() As Boolean
        ' true = keyfile loaded
        ' false = keyfile did not load
        Dim success As Boolean = False

        caption = "Load WorkFile to DataView"
        WorkFileMessage(caption, "Load Data View from WorkFile")

        WorkFile_Complete = False
        KeyFile_OK = False
        MainMenu.KeyFile_Form_Button.BackColor = SystemColors.Control

        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet

        Try

            Try
                ' Open WorkFile workbook
                xlapp = New Excel.Application
                xlapp.Visible = False
                xlworkbook = xlapp.Workbooks.Open(Work_File_Path, [ReadOnly]:=False)
                xlworksheet = xlworkbook.Worksheets(1)
                xlworksheet.Activate()

            Catch ex As Exception
                MessageBox.Show("Cannot open Work File." & vbCrLf &
                            ex.Message,
                            caption)
                GoTo CleanUp
            End Try

            Clear_DGV1()

            ' Copy from Work File to DGV
            Dim i As Integer = 0

            Do Until IsNothing(xlworksheet.Cells(i + 2, 1).value) Or
                    CStr(xlworksheet.Cells(i + 2, 1).value) = ""

                ' if there is data in the first column of the row, then add a row
                DataGridView1.Rows.Add()

                For j As Integer = 0 To DataGridView1.ColumnCount - 1
                    ' if there is data in the cell, then copy it
                    If Not IsNothing(xlworksheet.Cells(i + 2, j + 1).Value) Then
                        DataGridView1(j, i).Value = xlworksheet.Cells(i + 2, j + 1).value
                    End If

                    If (i Mod 5 = 0) Then
                        Wait_Message_Form.Message_TextBox.Text = "Row    :" & vbTab & i & vbCrLf ' &
                        '"Column :" & vbTab & j & vbCrLf &
                        '"Value  :" & vbTab & DataGridView1(j, i).Value

                        Wait_Message_Form.Refresh()
                    End If

                    CatchUp()
                Next
                i += 1
            Loop
            WorkFile_RowCount = i
            DataGridView1.Update()
            DataGridView1.Refresh()

            My.Settings.WorkFile_RowCount = WorkFile_RowCount

            ' set current row
            If WorkFile_CurrentRow > DataGridView1.Rows.Count - 1 Or
                        WorkFile_CurrentRow < 0 Then
                WorkFile_CurrentRow = 0
            End If

            My.Settings.Key_Qty = DataGridView1.Rows(WorkFile_CurrentRow).Cells("Qty").Value
            My.Settings.WorkFile_CurrentRow = WorkFile_CurrentRow
            My.Settings.Save()

            success = True
        Catch ex As Exception
            success = False
            GoTo CleanUp
        End Try

CleanUp:
        Try
            WorkFileMessage(caption, "WorkFile loaded")
            Wait_Message_Form.Close()

#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            If Not xlworksheet Is Nothing Then
                ReleaseObject(xlworksheet)
                xlworksheet = Nothing
            End If

            If Not xlworkbook Is Nothing Then
                xlworkbook.Close()
                ReleaseObject(xlworkbook)
                xlworkbook = Nothing
            End If

            If Not xlapp Is Nothing Then
                xlapp.Quit()
                ReleaseObject(xlapp)
                xlapp = Nothing
            End If
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch ex As Exception
            MessageBox.Show("Cannot close KeyFile Excel workbook." & vbCrLf &
                            ex.Message,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1)
            success = False
        End Try

        ' Point to Start button
        Send_First_Recipe_Button.Select()

        Return success
    End Function

    '============================================================
    'Save Data View to New Work File
    '============================================================
    Private Sub Save_DGV_To_WorkFile()
        'Dim misValue As Object = System.Reflection.Missing.Value

        ' Create new workbook
        Dim xlapp = New Excel.Application
        Dim xlworkbook = xlapp.Workbooks.Add()
        Dim xlworksheet = xlworkbook.Worksheets(1)

        Try
            Wait_Message_Form.Text = "Saving Data View to WorkFile ..."
            Wait_Message_Form.Message_TextBox.Text = "Deleting Old WorkFile ..."
            Wait_Message_Form.Show()
            Wait_Message_Form.Refresh()

            ' Delete old WorkFile
            System.IO.File.Delete(Work_File_Path)

            Wait_Message_Form.Message_TextBox.Text = "Creating New WorkFile ..."
            Wait_Message_Form.Refresh()

            Try
                xlworksheet.Activate()

                ' change sheet name to WorkSheet
                CType(xlworksheet, Microsoft.Office.Interop.Excel.Worksheet).Name = "WorkSheet"

                xlapp.Visible = False
                xlapp.DisplayAlerts = False

                ' Strip off the file extension. let Excel decide
                Dim zFileName = Work_File_Path.Replace(".xl*", "")
                xlworkbook.DoNotPromptForConvert = True
                xlworkbook.SaveAs(zFileName)

                'xlworkbook.SaveAs(Work_File_Path, Excel.XlFileFormat.xlworkbookNormal)

            Catch ex As Exception
                MessageBox.Show("Cannot create Work File." & vbCrLf &
                                ex.Message,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                GoTo cleanup
            End Try

            ' Header row
            For k As Integer = 1 To DataGridView1.Columns.Count
                xlworksheet.Cells(1, k).value = DataGridView1.Columns(k - 1).HeaderText
            Next

            ' Data Rows
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For j As Integer = 0 To DataGridView1.ColumnCount - 1
                    If Not IsNothing(DataGridView1(j, i).Value) Then
                        xlworksheet.Cells(i + 2, j + 1).value = DataGridView1(j, i).Value
                    End If

                    Wait_Message_Form.Message_TextBox.Text = "Copying Data View to WorkFile ..." & vbCrLf &
                                                            "Row    :" & vbTab & i & vbCrLf &
                                                            "Column :" & vbTab & j & vbCrLf &
                                                            "Value  :" & vbTab & DataGridView1(j, i).Value
                    Try
                        Wait_Message_Form.Refresh()
                        'let everyone catch up
                        CatchUp()
                    Catch
                    End Try
                Next
            Next

            DataGridView1.Refresh()
            DataGridView1.Update()
            CatchUp()

            xlapp.DisplayAlerts = False
            xlworkbook.Save()
            'xlworkbook.Save(Excel.XlFileFormat.xlworkbookNormal, misValue, misValue, misValue, misValue,
            '    Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)

        Catch ex As Exception
            MessageBox.Show("Cannot save Data View to Work File." & vbCrLf &
                            ex.Message,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            GoTo cleanup
        End Try
cleanup:
        Wait_Message_Form.Close()
        CatchUp()
        Try
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            If Not xlworksheet Is Nothing Then
                ReleaseObject(xlworksheet)
                xlworksheet = Nothing
            End If

            If Not xlworkbook Is Nothing Then
                xlworkbook.Close()
                ReleaseObject(xlworkbook)
                xlworkbook = Nothing
            End If

            If Not xlapp Is Nothing Then
                xlapp.Quit()
                ReleaseObject(xlapp)
                xlapp = Nothing
            End If
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch ex As Exception

        End Try
    End Sub

    '============================================================
    'Update Key Series from Operator Entry
    '============================================================
    Private Sub Key_Series_TextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Key_Series_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            caption = "Update key Series"

            ' Check Key series for corect length
            If Key_Series_TextBox.TextLength > 0 And
                Key_Series_TextBox.TextLength <= 9 Then

                Key_Series = My.Settings.Key_Series
                My.Settings.Save()

                'Translate Key Series into Print Code for HMI
                Convert_KeySeries()

                MessageBox.Show("Key Series changed: " & Key_Series,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1)

                Key_Series_TextBox.SelectNextControl(ActiveControl, True, True, True, True)
            Else
                My.Settings.Key_Series = Key_Series
                MessageBox.Show("Key Series is not valid: " & Key_Series,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)

                'lose focus
                Key_Series_TextBox.SelectNextControl(ActiveControl, True, True, True, True)
            End If
        End If
    End Sub

    '============================================================
    'When clicked, Select All Key Series textbox
    '============================================================
    Private Sub Key_Series_TextBox_Click(sender As Object, e As EventArgs) Handles Key_Series_TextBox.Click
        Key_Series_TextBox.SelectionStart = 0
        Key_Series_TextBox.SelectionLength = Key_Series_TextBox.TextLength
    End Sub

    '============================================================
    'When double-clicked, restore old Key Series
    '============================================================
    Private Sub Key_Series_TextBox_DoubleClick(sender As Object, e As EventArgs) Handles Key_Series_TextBox.DoubleClick
        ' double click to retrieve saved setting.
        Key_Series_TextBox.Text = My.Settings.Key_Series
    End Sub

    '==================================================
    'Operator change Key Code
    '==================================================
    Private Sub KeyCode_TextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles KeyCode_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If UpdateTumblerCode(KeyCode_TextBox.Text) = True Then
                KeyCode_TextBox.Text = Key_Code

                System.Windows.Forms.Application.DoEvents()
                MessageBox.Show("Key Code changed: " & Key_Code,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1)

                'update recipe screen
                RecipeDisplay_Form.UpdateScreen()

            Else
                Key_Code = My.Settings.Key_Code

                KeyCode_TextBox.Text = My.Settings.Key_Code
                KeyCode_TextBox.SelectNextControl(ActiveControl, True, True, True, True)
                Exit Sub
            End If
            KeyCode_TextBox.SelectNextControl(ActiveControl, True, True, True, True)
        End If
    End Sub

    '============================================================
    'When clicked, Select All Key Code textbox
    '============================================================
    Private Sub Key_Code_TextBox_Click(sender As Object, e As EventArgs)
        KeyCode_TextBox.SelectionStart = 0
        KeyCode_TextBox.SelectionLength = KeyCode_TextBox.TextLength
    End Sub

    '============================================================
    'When double-clicked, restore old Key Code
    '============================================================
    Private Sub Key_Code_TextBox_DoubleClick(sender As Object, e As EventArgs)
        KeyCode_TextBox.Text = My.Settings.Key_Code
    End Sub

    '=================================================
    'Close current series in WorkFile
    '=================================================
    Public Function CloseCurrentWorkFileRow() As Boolean
        caption = "Close Current Row"
        Wait_Message_Form.Text = caption
        Try
            'Check if WorkFile is loaded
            If WorkFile_RowCount < 1 Then
                Dim msg = "WorkFile is empty." & vbCrLf &
                            "No Action."
                Dim result = MessageBox.Show(msg,
                                            caption,
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk,
                                            MessageBoxDefaultButton.Button1)
                Return False
            End If

            '=================================================
            'Record data from completed row
            '=================================================
            'Actual Quantity Made Good for completed row
            DataGridView1.Rows(WorkFile_CurrentRow).Cells("QtyMadeGood").Value = PLC_25_Recipe_Batch_Key_Que

            'Actual Quantity Made Bad for completed row
            DataGridView1.Rows(WorkFile_CurrentRow).Cells("QtyMadeBad").Value = -1

            'Time Completed for completed row
            DataGridView1.Rows(WorkFile_CurrentRow).Cells("TimeCompleted").Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

            'Check if at end of WorkFile
            If IsNothing(DataGridView1.Rows(WorkFile_CurrentRow + 1).Cells("Series").Value) Or
                IsDBNull(DataGridView1.Rows(WorkFile_CurrentRow + 1).Cells("Series").Value) Then

                WorkFileMessage(caption, "Completed last row of WorkFile.")

                'Set Complete Flag and exit
                WorkFile_Complete = True
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot update Data View. " & vbCrLf &
                            ex.Message,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            Wait_Message_Form.Close()
            Return False
        End Try

        Wait_Message_Form.Close()
        Return True
    End Function

    '=================================================
    'Start row in WorkFile
    '=================================================
    Public Function StartWorkFileRow(rownumber) As Boolean
        ' true = started
        ' false = fault

        caption = "Begin Selected Series in KeyFile"
        Dim errorexit As Boolean = False

        Try
            If rownumber > WorkFile_RowCount Then
                msg = "End of WorkFile." & vbCrLf & "All Done." & vbCrLf &
                "Current Row         :" & rownumber & vbCrLf &
                "Work File Row Count :" & WorkFile_RowCount

                errorexit = True
            End If

            If rownumber < 0 Then
                msg = "WorkFile Row selection is not valid." & vbCrLf &
                    "Current Row         :" & rownumber & vbCrLf &
                    "Work File Row Count :" & WorkFile_RowCount

                errorexit = True
            End If

            If errorexit Then
                MessageBox.Show(msg,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            End If

            ' Update for next workfile row
            WorkFile_CurrentRow = rownumber
            My.Settings.WorkFile_CurrentRow = rownumber
            My.Settings.Save()

            ' record Time Started new row
            DataGridView1.Rows(WorkFile_CurrentRow).Cells("TimeStarted").Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            DataGridView1.Rows(WorkFile_CurrentRow).Selected = True

            CatchUp()

            Key_Series = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("Series").Value)
            Key_No = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("KeyNo").Value)
            Key_Code = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("KeyCode").Value)

            Try
                Key_MK_Code = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("MKCode").Value)
            Catch
                Key_MK_Code = ""
            End Try

            Key_Qty = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("Qty").Value)

            Try
                Key_Desc = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("Desc").Value)
            Catch
                Key_Desc = ""
            End Try

            Try
                Key_Assigned_To = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("AssignedTo").Value)
            Catch
                Key_Assigned_To = ""
            End Try

            Try
                Key_Date = CStr(DataGridView1.Rows(WorkFile_CurrentRow).Cells("Date").Value)
            Catch
                Key_Date = Nothing
            End Try

        Catch ex As Exception
            MessageBox.Show("Error reading from Work File." & vbCrLf &
                            "Key Series:     " & vbTab & Key_Series & vbCrLf &
                            "Key No:         " & vbTab & Key_No & vbCrLf &
                            "Key Code:       " & vbTab & Key_Code & vbCrLf &
                            "Key MK_Code:    " & vbTab & Key_MK_Code & vbCrLf &
                            "Key Qty:        " & vbTab & Key_Qty & vbCrLf &
                            "Key Desc:       " & vbTab & Key_Desc & vbCrLf &
                            "Key AssignedTo: " & vbTab & Key_Assigned_To & vbCrLf &
                            "Key Date:       " & vbTab & Key_Date & vbCrLf &
                            "Current Line:   " & vbTab & WorkFile_CurrentRow & vbCrLf &
                            vbCrLf &
                            ex.Message,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            Return False
        End Try

        Try
            'Validate Key Series data
            If Key_Series.Length > 0 And Key_Series.Length <= 12 And
                    IsNumeric(Key_Code) And Key_Code.Length = 7 And
                    IsNumeric(Key_Qty) And CInt(Key_Qty) > 0 Then

                My.Settings.Key_Series = Key_Series
                My.Settings.Key_No = Key_No
                My.Settings.Key_Code = Key_Code
                My.Settings.Key_MK_Code = Key_MK_Code
                My.Settings.Key_Qty = Key_Qty
                My.Settings.Key_Desc = Key_Desc
                My.Settings.Key_Assigned_To = Key_Assigned_To
                My.Settings.Key_Date = Key_Date
                My.Settings.WorkFile_CurrentRow = WorkFile_CurrentRow

                My.Settings.Save()

                'Select current row
                DataGridView1.Rows(My.Settings.WorkFile_CurrentRow).Selected = True
                DGVVisibleRow(DataGridView1, My.Settings.WorkFile_CurrentRow)

                ' Update Tumbler Codes
                TumblerCode_OK = UpdateTumblerCode(Key_Code)

                If TumblerCode_OK Then
                    MainMenu.Tumblers_Button.BackColor = Color.Green
                    MainMenu.Tumblers_Button.Text = "Tumbler Codes are valid."
                    MainMenu.Tumblers_Button.BackColor = Color.Green
                Else
                    MainMenu.Tumblers_Button.BackColor = Color.Yellow
                    MainMenu.Tumblers_Button.Text = "Tumbler Codes are not valid."
                End If
                Return TumblerCode_OK

            ElseIf CInt(Key_Qty) < 0 Or
                    CInt(Key_Qty) > 7777777 Then

                MessageBox.Show("Key Series quantity is not valid: " & vbCrLf &
                            "Key Qty:        " & vbTab & Key_Qty,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                Return False

            ElseIf Key_Series.Length <= 0 Then
                MessageBox.Show("Key Series name is not valid: " & vbCrLf &
                            "Key Series:     " & vbTab & Key_Series,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                Return False

            ElseIf Key_Code.Length <> 7 Then
                MessageBox.Show("Key Code is not valid: " & vbCrLf &
                            "Key Code:     " & vbTab & Key_Code,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
                Return False
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Key Series has incorrect values: " & vbCrLf &
                                "Key Series:     " & vbTab & Key_Series & vbCrLf &
                                "Key No:         " & vbTab & Key_No & vbCrLf &
                                "Key Code:       " & vbTab & Key_Code & vbCrLf &
                                "Key MK_Code:    " & vbTab & Key_MK_Code & vbCrLf &
                                "Key Qty:        " & vbTab & Key_Qty & vbCrLf &
                                "Key Desc:       " & vbTab & Key_Desc & vbCrLf &
                                "Key AssignedTo: " & vbTab & Key_Assigned_To & vbCrLf &
                                "Key Date:       " & vbTab & Key_Date & vbCrLf &
                                "Current Line:   " & vbTab & WorkFile_CurrentRow & vbCrLf &
                                vbCrLf &
                                ex.Message,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
        End Try
cleanup:
        Wait_Message_Form.Close()
    End Function

    '=====================================================
    'Get new Work File row from DataGridView mouse doubleclick
    '=====================================================
    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        caption = "Data Grid View"

        If e.RowIndex >= 0 Then
            If Not IsDBNull(DataGridView1.Rows(e.RowIndex).Cells("Series").Value) Then
                WorkFile_CurrentRow = e.RowIndex
                My.Settings.WorkFile_CurrentRow = WorkFile_CurrentRow
                My.Settings.Save()

                'set values for new line of workfile
                Save_KeyFile_Settings()
            Else
                msg = "Selected row is not valid." & vbCrLf &
                         "Select a different row."

                MessageBox.Show(msg,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    '=========================================
    ' Release Object
    '=========================================
    Private Sub ReleaseObject(ByVal obj As Object)
        ' https://stackoverflow.com/questions/10309365/the-proper-way-to-dispose-excel-com-object-using-vb-net

        'System.Runtime.InteropServices.Marshal.ReleaseComObject()

        Try
            Dim xyz = System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    '============================================================
    'Close Excel
    '============================================================
    Private Sub KillExcelProcess()
        Try
            Dim Xcel() As Process = Process.GetProcessesByName("EXCEL")
            For Each Process As Process In Xcel
                Process.Kill()
            Next
        Catch ex As Exception
        End Try
    End Sub

    '============================================================
    ' Archive WorkFile Button
    '============================================================
    Private Sub Archive_WorkFile_Button_Click(sender As Object, e As EventArgs)
        ArchiveWorkFile()
    End Sub
    '===================================================
    ' Work File Message
    '===================================================
    Private Function WorkFileMessage(caption, message_text)
        Wait_Message_Form.Text = caption
        Wait_Message_Form.Message_TextBox.Text = message_text

        If Wait_Message_Form.Visible = False Then
            Wait_Message_Form.Show()
        End If
        Wait_Message_Form.Refresh()

        KeyFile_Status_Label.Text = message_text
        Me.Refresh()

    End Function

    '===================================================
    ' Catch up
    '===================================================
    Private Sub CatchUp()
        'let everyone catch up
        System.Windows.Forms.Application.DoEvents()
        Threading.Thread.Sleep(1)
        Me.Update()
    End Sub

    '===================================================
    ' Update Tumbler Code
    '===================================================
    Public Function UpdateTumblerCode(tumblerinput)
        ' true = Update OK
        ' false = Update fault
        caption = "Update Tumbler Code"

        Wait_Message_Form.Message_TextBox.Text = "Updating ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.TopMost = True
        Wait_Message_Form.Refresh()

        Try
            'check for valid Tumbler Code
            If IsNumeric(tumblerinput) = True And
                        CInt(tumblerinput) > 0 And
                        (tumblerinput Is Nothing) = False And
                        tumblerinput.Length = 7 Then


            Else
                msg = "Tumbler Code is not valid: " & tumblerinput
                MessageBox.Show(msg,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk)

                My.Settings.Key_Code = Key_Code
                Return False
            End If

        Catch ex As Exception
            msg = "Tumbler Code is not valid: " & tumblerinput
            MessageBox.Show(msg,
                        caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk)
            Return False
        End Try

        Key_Code = tumblerinput
        My.Settings.Key_Code = Key_Code
        My.Settings.Save()

        'Set Tumbler Code
        Tumbler_1_Code = Mid(Key_Code, 1, 1)
        Tumbler_2_Code = Mid(Key_Code, 2, 1)
        Tumbler_3_Code = Mid(Key_Code, 3, 1)
        Tumbler_4_Code = Mid(Key_Code, 4, 1)
        Tumbler_5_Code = Mid(Key_Code, 5, 1)
        Tumbler_6_Code = Mid(Key_Code, 6, 1)
        Tumbler_7_Code = Mid(Key_Code, 7, 1)
        Tumbler_8_Code = Mid(Key_Code, 8, 1)

        Update_Tumbler_Locations()
        SaveTumblerSettings()

        Return TumblerCode_OK
    End Function

    '====================================================
    'Update Tumbler Locations
    '====================================================
    Public Sub Update_Tumbler_Locations()

        caption = "Update Tumblers"
        msg = ""

        ' false until validated
        TumblerCode_OK = False

        'Dim dialog_result As DialogResult

        Dim random1
        Dim keycode
        Dim number
        Dim part As String = ""

        Wait_Message_Form.Text = "Tumbler Code Location Update"
        Wait_Message_Form.Message_TextBox.Text = "Updating Tumbler Locations" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        '==========================================================
        ' Check for Tumbler Code initialized 
        '==========================================================
        If Key_Code Is Nothing Or
                 Key_Code = "" Then

            caption = "Recipe Update"
            msg = "Tumbler Code is not set"
            MessageBox.Show(msg, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Try
            '==========================================================
            ' Check for valid Tumbler Code
            '==========================================================
            If CInt(Tumbler_1_Code) < 0 Or CInt(Tumbler_1_Code) > 9 Or
                    CInt(Tumbler_2_Code) < 0 Or CInt(Tumbler_2_Code) > 9 Or
                    CInt(Tumbler_3_Code) < 0 Or CInt(Tumbler_3_Code) > 9 Or
                    CInt(Tumbler_4_Code) < 0 Or CInt(Tumbler_4_Code) > 9 Or
                    CInt(Tumbler_5_Code) < 0 Or CInt(Tumbler_5_Code) > 9 Or
                    CInt(Tumbler_6_Code) < 0 Or CInt(Tumbler_6_Code) > 9 Or
                    CInt(Tumbler_7_Code) < 0 Or CInt(Tumbler_7_Code) > 9 Then

                caption = "Updating Tumbler Locations"
                msg = "Key Code is not valid"
                MessageBox.Show(msg,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk)
                Exit Sub
            End If
        Catch ex As Exception
            caption = "Recipe Update"
            msg = "Key Code is not valid" & vbCrLf & ex.Message
            MessageBox.Show(msg,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk)
            Exit Sub
        End Try

        Wait_Message_Form.Message_TextBox.Text = "Updating Tumbler Locations." & vbCrLf & "Updating Springs ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Tumbler Kits ========================================================================
        ' Spring Tumbler Kit ==================================================================
        R_Spring_Tumbler_Kit = R_Sta_6_Part_Number

        ' Spring 1 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring1_Type = "NONE"
            Else
                ' Spring 1 Type
                R_Spring1_Type = Tumbler_KitTableAdapter.GetSpring1Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table. " & ex.Message)
            Exit Sub
        End Try

        Try
            If R_Spring1_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring1Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring1_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table. " & ex.Message)
            Exit Sub
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring1_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring1Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring1Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring1_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
            Exit Sub
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring1_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring1_Chart = Tumbler_KitTableAdapter.GetSpring1Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_1_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring1_Chart)
                ElseIf Tumbler_1_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring1_Chart)
                ElseIf Tumbler_1_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring1_Chart)
                ElseIf Tumbler_1_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring1_Chart)
                ElseIf Tumbler_1_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring1_Chart)
                ElseIf Tumbler_1_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring1_Chart)
                ElseIf Tumbler_1_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Spring1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring1_Chart)
                End If

                ' get bowl location from Springs table
                GlobalVariables.R_Spring1_Bowl = SpringsTableAdapter.GetBowl(part)
            End If

        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Chart type. " & ex.Message)
            Exit Sub
        End Try

        If R_Spring1_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring1_Bowl = ""
        End If

        ' Spring 1 =============================================================================
        ' Spring 2 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring2_Type = "NONE"
            Else
                ' Spring 2 Type
                R_Spring2_Type = Tumbler_KitTableAdapter.GetSpring2Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table. " & ex.Message)
            Exit Sub
        End Try

        Try
            If R_Spring2_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring2Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring2_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Fixed type. " & ex.Message)

            Exit Sub
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring2_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring2Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring2Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring2_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring2_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring2_Chart = Tumbler_KitTableAdapter.GetSpring2Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_2_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring2_Chart)
                ElseIf Tumbler_2_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring2_Chart)
                ElseIf Tumbler_2_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring2_Chart)
                ElseIf Tumbler_2_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring2_Chart)
                ElseIf Tumbler_2_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring2_Chart)
                ElseIf Tumbler_2_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring2_Chart)
                ElseIf Tumbler_2_Code = "7" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring2_Chart)
                End If

                ' get bowl location from Springs table
                GlobalVariables.R_Spring2_Bowl = SpringsTableAdapter.GetBowl(part)
            End If

        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Spring2_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring2_Bowl = ""
        End If

        ' Spring 2 =============================================================================
        ' Spring 3 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring3_Type = "NONE"
            Else
                ' Spring 3 Type
                R_Spring3_Type = Tumbler_KitTableAdapter.GetSpring3Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Spring3_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring3Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring3_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring3_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring3Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring3Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring3_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring3_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring3_Chart = Tumbler_KitTableAdapter.GetSpring3Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_3_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring3_Chart)
                ElseIf Tumbler_3_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring3_Chart)
                ElseIf Tumbler_3_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring3_Chart)
                ElseIf Tumbler_3_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring3_Chart)
                ElseIf Tumbler_3_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring3_Chart)
                ElseIf Tumbler_3_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring3_Chart)
                ElseIf Tumbler_3_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Spring3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring3_Chart)
                End If
                ' get bowl location from Springs table
                GlobalVariables.R_Spring3_Bowl = SpringsTableAdapter.GetBowl(part)
            End If

        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Spring3_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring3_Bowl = ""
        End If

        ' Spring 3 =============================================================================
        ' Spring 4 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring4_Type = "NONE"
            Else
                ' Spring 4 Type
                R_Spring4_Type = Tumbler_KitTableAdapter.GetSpring4Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Spring4_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring4Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring4_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring4_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring4Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring4Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring4_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring4_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring4_Chart = Tumbler_KitTableAdapter.GetSpring4Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_4_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring4_Chart)
                ElseIf Tumbler_4_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring4_Chart)
                ElseIf Tumbler_4_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring4_Chart)
                ElseIf Tumbler_4_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring4_Chart)
                ElseIf Tumbler_4_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring4_Chart)
                ElseIf Tumbler_4_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring4_Chart)
                ElseIf Tumbler_4_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Spring4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring4_Chart)
                End If
                ' get bowl location from Springs table
                GlobalVariables.R_Spring4_Bowl = SpringsTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Spring4_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring4_Bowl = ""
        End If

        ' Spring 4 =============================================================================
        ' Spring 5 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring5_Type = "NONE"
            Else
                ' Spring 5 Type
                R_Spring5_Type = Tumbler_KitTableAdapter.GetSpring5Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Spring5_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring5Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring5_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring5_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring5Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring5Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring5_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring5_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring5_Chart = Tumbler_KitTableAdapter.GetSpring5Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_5_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring5_Chart)
                ElseIf Tumbler_5_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring5_Chart)
                ElseIf Tumbler_5_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring5_Chart)
                ElseIf Tumbler_5_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring5_Chart)
                ElseIf Tumbler_5_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring5_Chart)
                ElseIf Tumbler_5_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring5_Chart)
                ElseIf Tumbler_5_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Spring5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring5_Chart)
                End If

                ' get bowl location from Springs table
                GlobalVariables.R_Spring5_Bowl = SpringsTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Spring5_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring5_Bowl = ""
        End If

        ' Spring 5 =============================================================================
        ' Spring 6 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring6_Type = "NONE"
            Else
                ' Spring 6 Type
                R_Spring6_Type = Tumbler_KitTableAdapter.GetSpring6Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Spring6_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring6Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring6_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring6_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring6Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring6Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring6_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring6_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring6_Chart = Tumbler_KitTableAdapter.GetSpring6Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_6_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring6_Chart)
                ElseIf Tumbler_6_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring6_Chart)
                ElseIf Tumbler_6_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring6_Chart)
                ElseIf Tumbler_6_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring6_Chart)
                ElseIf Tumbler_6_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring6_Chart)
                ElseIf Tumbler_6_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring6_Chart)
                ElseIf Tumbler_6_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Spring6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring6_Chart)
                End If

                ' get bowl location from Springs table
                GlobalVariables.R_Spring6_Bowl = SpringsTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Spring6_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring6_Bowl = ""
        End If

        ' Spring 6 =============================================================================
        ' Spring 7 =============================================================================
        Try
            If R_Spring_Tumbler_Kit.ToUpper = "NONE" Then
                R_Spring7_Type = "NONE"
            Else
                ' Spring 7 Type
                R_Spring7_Type = Tumbler_KitTableAdapter.GetSpring7Type(R_Spring_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Spring7_Type.ToUpper = "FIXED" Then
                ' Get Spring spec from Number
                number = Tumbler_KitTableAdapter.GetSpring7Number(R_Spring_Tumbler_Kit)

                ' get bowl location from Springs table
                GlobalVariables.R_Spring7_Bowl = SpringsTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Random1, Random2
            If R_Spring7_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetSpring7Random1(R_Spring_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetSpring7Random2(R_Spring_Tumbler_Kit)
                End If

                ' get bowl locations from Springs table
                GlobalVariables.R_Spring7_Bowl = SpringsTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Springs Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Spring spec from Chart
            If R_Spring7_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Spring7_Chart = Tumbler_KitTableAdapter.GetSpring7Chart(R_Spring_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_7_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Spring7_Chart)
                ElseIf Tumbler_7_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Spring7_Chart)
                ElseIf Tumbler_7_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Spring7_Chart)
                ElseIf Tumbler_7_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Spring7_Chart)
                ElseIf Tumbler_7_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Spring7_Chart)
                ElseIf Tumbler_7_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Spring7_Chart)
                ElseIf Tumbler_7_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Spring7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Spring7_Chart)
                End If

                ' get bowl location from Springs table
                GlobalVariables.R_Spring7_Bowl = SpringsTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Spring7_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Spring7_Bowl = ""
        End If

        ' Spring 7 =========================================================================

        Wait_Message_Form.Message_TextBox.Text = "Updating Tumbler Codes." & vbCrLf & "Updating Top Tumblers ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Top Tumbler Kit ==================================================================
        R_Top_Tumbler_Kit = R_Sta_12_Part_Number
        ' Top 1 ============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top1_Type = "NONE"
            Else
                ' Top 1 Type
                R_Top1_Type = Tumbler_KitTableAdapter.GetTop1Type(R_Top_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top1_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop1Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top1_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top1_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop1Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop1Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top1_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top1_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top1_Chart = Tumbler_KitTableAdapter.GetTop1Chart(R_Top_Tumbler_Kit)


                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_1_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top1_Chart)
                ElseIf Tumbler_1_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top1_Chart)
                ElseIf Tumbler_1_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top1_Chart)
                ElseIf Tumbler_1_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top1_Chart)
                ElseIf Tumbler_1_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top1_Chart)
                ElseIf Tumbler_1_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top1_Chart)
                ElseIf Tumbler_1_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top1_Chart)
                End If


                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top1_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top1_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top1_Bowl = ""
        End If

        ' Top 1 =============================================================================
        ' Top 2 =============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top2_Type = "NONE"
            Else
                ' Top 2 Type
                R_Top2_Type = Tumbler_KitTableAdapter.GetTop2Type(R_Top_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top2_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop2Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top2_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Top Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top2_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop2Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop2Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top2_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top2_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top2_Chart = Tumbler_KitTableAdapter.GetTop2Chart(R_Top_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_2_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top2_Chart)
                ElseIf Tumbler_2_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top2_Chart)
                ElseIf Tumbler_2_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top2_Chart)
                ElseIf Tumbler_2_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top2_Chart)
                ElseIf Tumbler_2_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top2_Chart)
                ElseIf Tumbler_2_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top2_Chart)
                ElseIf Tumbler_2_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top2_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top2_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top2_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top2_Bowl = ""
        End If

        ' Top 2 =============================================================================
        ' Top 3 =============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top3_Type = "NONE"
            Else
                ' Top 3 Type
                R_Top3_Type = Tumbler_KitTableAdapter.GetTop3Type(R_Top_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top3_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop3Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top3_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top3_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop3Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop3Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top3_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top3_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top3_Chart = Tumbler_KitTableAdapter.GetTop3Chart(R_Top_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_3_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top3_Chart)
                ElseIf Tumbler_3_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top3_Chart)
                ElseIf Tumbler_3_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top3_Chart)
                ElseIf Tumbler_3_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top3_Chart)
                ElseIf Tumbler_3_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top3_Chart)
                ElseIf Tumbler_3_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top3_Chart)
                ElseIf Tumbler_3_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top3_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top3_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top3_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top3_Bowl = ""
        End If

        ' Top 3 =============================================================================
        ' Top 4 =============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top4_Type = "NONE"

            Else
                ' Top 4 Type
                R_Top4_Type = Tumbler_KitTableAdapter.GetTop4Type(R_Top_Tumbler_Kit)

            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top4_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop4Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top4_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top4_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop4Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop4Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top4_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top4_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top4_Chart = Tumbler_KitTableAdapter.GetTop4Chart(R_Top_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_4_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top4_Chart)
                ElseIf Tumbler_4_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top4_Chart)
                ElseIf Tumbler_4_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top4_Chart)
                ElseIf Tumbler_4_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top4_Chart)
                ElseIf Tumbler_4_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top4_Chart)
                ElseIf Tumbler_4_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top4_Chart)
                ElseIf Tumbler_4_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top4_Chart)
                End If
                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top4_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top4_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top4_Bowl = ""
        End If

        ' Top 4 =============================================================================
        ' Top 5 =============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top5_Type = "NONE"
            Else
                ' Top 5 Type
                R_Top5_Type = Tumbler_KitTableAdapter.GetTop5Type(R_Top_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top5_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop5Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top5_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top5_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop5Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop5Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top5_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top5_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top5_Chart = Tumbler_KitTableAdapter.GetTop5Chart(R_Top_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_5_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top5_Chart)
                ElseIf Tumbler_5_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top5_Chart)
                ElseIf Tumbler_5_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top5_Chart)
                ElseIf Tumbler_5_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top5_Chart)
                ElseIf Tumbler_5_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top5_Chart)
                ElseIf Tumbler_5_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top5_Chart)
                ElseIf Tumbler_5_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top5_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top5_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top5_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top5_Bowl = ""
        End If

        ' Top 5 =============================================================================
        ' Top 6 =============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top6_Type = "NONE"
            Else
                ' Top 6 Type
                R_Top6_Type = Tumbler_KitTableAdapter.GetTop6Type(R_Top_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top6_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop6Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top6_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top6_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop6Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop6Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top6_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top6_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top6_Chart = Tumbler_KitTableAdapter.GetTop6Chart(R_Top_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_6_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top6_Chart)
                ElseIf Tumbler_6_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top6_Chart)
                ElseIf Tumbler_6_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top6_Chart)
                ElseIf Tumbler_6_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top6_Chart)
                ElseIf Tumbler_6_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top6_Chart)
                ElseIf Tumbler_6_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top6_Chart)
                ElseIf Tumbler_6_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top6_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top6_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top6_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top6_Bowl = ""
        End If

        ' Top 6 =============================================================================
        ' Top 7 =============================================================================
        Try
            If R_Top_Tumbler_Kit.ToUpper = "NONE" Then
                R_Top7_Type = "NONE"
            Else
                ' Top 7 Type
                R_Top7_Type = Tumbler_KitTableAdapter.GetTop7Type(R_Top_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Top7_Type.ToUpper = "FIXED" Then
                ' Get Top spec from Number
                number = Tumbler_KitTableAdapter.GetTop7Number(R_Top_Tumbler_Kit)

                ' get bowl location from Tops table
                GlobalVariables.R_Top7_Bowl = Top_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Random1, Random2
            If R_Top7_Type.ToUpper = "RANDOM" Then
                'select based on top half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetTop7Random1(R_Top_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetTop7Random2(R_Top_Tumbler_Kit)
                End If

                ' get bowl locations from Top Tumbler table
                GlobalVariables.R_Top7_Bowl = Top_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Tops Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Top spec from Chart
            If R_Top7_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Top7_Chart = Tumbler_KitTableAdapter.GetTop7Chart(R_Top_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_7_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Top7_Chart)
                ElseIf Tumbler_7_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Top7_Chart)
                ElseIf Tumbler_7_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Top7_Chart)
                ElseIf Tumbler_7_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Top7_Chart)
                ElseIf Tumbler_7_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Top7_Chart)
                ElseIf Tumbler_7_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Top7_Chart)
                ElseIf Tumbler_7_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Top7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Top7_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Top7_Bowl = Top_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try
        If R_Top7_Type.ToUpper = "NONE" Then
            GlobalVariables.R_Top7_Bowl = ""
        End If

        ' Top 7 =============================================================================

        Wait_Message_Form.Message_TextBox.Text = "Updating Tumbler Codes." & vbCrLf & "Updating Intermediate Tumblers ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()
        Wait_Message_Form.TopMost = True

        ' Mid Tumbler Kit ==================================================================
        R_Mid_Tumbler_Kit = R_Sta_10_Part_Number

        'Not all recipes use intermediate tumblers. Everybody gets a default value.
        If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
            GlobalVariables.R_Mid1_Bowl = "0"
        End If

        ' Mid 1 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid1_Type = "NONE"
                GlobalVariables.R_Mid1_Bowl = "0"
            Else
                ' Mid 1 Type
                R_Mid1_Type = Tumbler_KitTableAdapter.GetMid1Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid1_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid1Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid1_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid1_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid1Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid1Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid1_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid1_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid1_Chart = Tumbler_KitTableAdapter.GetMid1Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_1_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid1_Chart)
                ElseIf Tumbler_1_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid1_Chart)
                ElseIf Tumbler_1_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid1_Chart)
                ElseIf Tumbler_1_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid1_Chart)
                ElseIf Tumbler_1_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid1_Chart)
                ElseIf Tumbler_1_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid1_Chart)
                ElseIf Tumbler_1_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid1_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid1_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid1_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 1 =============================================================================
        ' Mid 2 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid2_Type = "NONE"
                GlobalVariables.R_Mid2_Bowl = "0"
            Else
                ' Mid 2 Type
                R_Mid2_Type = Tumbler_KitTableAdapter.GetMid2Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid2_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid2Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid2_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid2_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid2Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid2Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid2_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid2_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid2_Chart = Tumbler_KitTableAdapter.GetMid2Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_2_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid2_Chart)
                ElseIf Tumbler_2_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid2_Chart)
                ElseIf Tumbler_2_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid2_Chart)
                ElseIf Tumbler_2_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid2_Chart)
                ElseIf Tumbler_2_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid2_Chart)
                ElseIf Tumbler_2_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid2_Chart)
                ElseIf Tumbler_2_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid2_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid2_Chart)
                End If


                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid2_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 2 =============================================================================
        ' Mid 3 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid3_Type = "NONE"
                GlobalVariables.R_Mid3_Bowl = "0"
            Else
                ' Mid 3 Type
                R_Mid3_Type = Tumbler_KitTableAdapter.GetMid3Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid3_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid3Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid3_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid3_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid3Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid3Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid3_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid3_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid3_Chart = Tumbler_KitTableAdapter.GetMid3Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_3_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid3_Chart)
                ElseIf Tumbler_3_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid3_Chart)
                ElseIf Tumbler_3_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid3_Chart)
                ElseIf Tumbler_3_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid3_Chart)
                ElseIf Tumbler_3_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid3_Chart)
                ElseIf Tumbler_3_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid3_Chart)
                ElseIf Tumbler_3_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid3_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid3_Chart)
                End If


                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid3_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 3 =============================================================================
        ' Mid 4 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid4_Type = "NONE"
                GlobalVariables.R_Mid4_Bowl = "0"
            Else
                ' Mid 4 Type
                R_Mid4_Type = Tumbler_KitTableAdapter.GetMid4Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid4_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid4Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid4_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid4_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid4Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid4Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid4_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid4_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid4_Chart = Tumbler_KitTableAdapter.GetMid4Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_4_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid4_Chart)
                ElseIf Tumbler_4_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid4_Chart)
                ElseIf Tumbler_4_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid4_Chart)
                ElseIf Tumbler_4_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid4_Chart)
                ElseIf Tumbler_4_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid4_Chart)
                ElseIf Tumbler_4_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid4_Chart)
                ElseIf Tumbler_4_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid4_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid4_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid4_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 4 =============================================================================
        ' Mid 5 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid5_Type = "NONE"
                GlobalVariables.R_Mid5_Bowl = "0"
            Else
                ' Mid 5 Type
                R_Mid5_Type = Tumbler_KitTableAdapter.GetMid5Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid5_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid5Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid5_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid5_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid5Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid5Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid5_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid5_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid5_Chart = Tumbler_KitTableAdapter.GetMid5Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_5_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid5_Chart)
                ElseIf Tumbler_5_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid5_Chart)
                ElseIf Tumbler_5_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid5_Chart)
                ElseIf Tumbler_5_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid5_Chart)
                ElseIf Tumbler_5_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid5_Chart)
                ElseIf Tumbler_5_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid5_Chart)
                ElseIf Tumbler_5_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid5_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid5_Chart)
                End If


                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid5_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 5 =============================================================================
        ' Mid 6 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid6_Type = "NONE"
                GlobalVariables.R_Mid6_Bowl = "0"
            Else
                ' Mid 6 Type
                R_Mid6_Type = Tumbler_KitTableAdapter.GetMid6Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid6_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid6Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid6_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid6_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid6Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid6Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid6_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid6_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid6_Chart = Tumbler_KitTableAdapter.GetMid6Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_6_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid6_Chart)
                ElseIf Tumbler_6_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid6_Chart)
                ElseIf Tumbler_6_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid6_Chart)
                ElseIf Tumbler_6_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid6_Chart)
                ElseIf Tumbler_6_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid6_Chart)
                ElseIf Tumbler_6_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid6_Chart)
                ElseIf Tumbler_6_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid6_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid6_Chart)
                End If


                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid6_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 6 =============================================================================
        ' Mid 7 =============================================================================
        Try
            If R_Mid_Tumbler_Kit.ToUpper = "NONE" Then
                R_Mid7_Type = "NONE"
                GlobalVariables.R_Mid7_Bowl = "0"
            Else
                ' Mid 7 Type
                R_Mid7_Type = Tumbler_KitTableAdapter.GetMid7Type(R_Mid_Tumbler_Kit)
            End If
        Catch ex As Exception
            MsgBox("Cannot read Type from Tumbler Kit. " & ex.Message)
        End Try

        Try
            If R_Mid7_Type.ToUpper = "FIXED" Then
                ' Get Mid spec from Number
                number = Tumbler_KitTableAdapter.GetMid7Number(R_Mid_Tumbler_Kit)

                ' get bowl location from Mids table
                GlobalVariables.R_Mid7_Bowl = Mid_TumblerTableAdapter.GetBowl(number)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Fixed type. " & ex.Message)
        End Try

        Try
            ' Get mid spec from Random1, Random2
            If R_Mid7_Type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    random1 = Tumbler_KitTableAdapter.GetMid7Random1(R_Mid_Tumbler_Kit)
                Else
                    random1 = Tumbler_KitTableAdapter.GetMid7Random2(R_Mid_Tumbler_Kit)
                End If

                ' get bowl locations from mid Tumbler table
                GlobalVariables.R_Mid7_Bowl = Mid_TumblerTableAdapter.GetBowl(random1)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Mids Table for Random type. " & ex.Message)
        End Try

        Try
            ' Get Mid spec from Chart
            If R_Mid7_Type.ToUpper = "KEYCODE" Then
                ' Get Chart name
                R_Mid7_Chart = Tumbler_KitTableAdapter.GetMid7Chart(R_Mid_Tumbler_Kit)

                ' Get keycode for the Chart Name from the column according to Tumbler Code
                If Tumbler_7_Code = "1" Then
                    part = ChartsTableAdapter.GetPart1(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode1(R_Mid7_Chart)
                ElseIf Tumbler_7_Code = "2" Then
                    part = ChartsTableAdapter.GetPart2(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode2(R_Mid7_Chart)
                ElseIf Tumbler_7_Code = "3" Then
                    part = ChartsTableAdapter.GetPart3(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode3(R_Mid7_Chart)
                ElseIf Tumbler_7_Code = "4" Then
                    part = ChartsTableAdapter.GetPart4(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode4(R_Mid7_Chart)
                ElseIf Tumbler_7_Code = "5" Then
                    part = ChartsTableAdapter.GetPart5(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode5(R_Mid7_Chart)
                ElseIf Tumbler_7_Code = "6" Then
                    part = ChartsTableAdapter.GetPart6(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode6(R_Mid7_Chart)
                ElseIf Tumbler_7_Code = "7" Then
                    part = ChartsTableAdapter.GetPart7(R_Mid7_Chart)
                    keycode = ChartsTableAdapter.GetKeycode7(R_Mid7_Chart)
                End If

                ' get bowl location from Top Tumbler table
                GlobalVariables.R_Mid7_Bowl = Mid_TumblerTableAdapter.GetBowl(part)
            End If
        Catch ex As Exception
            MsgBox("Cannot read from Charts Table for type Keycode. " & ex.Message)
        End Try

        ' Mid 7 =============================================================================

        Wait_Message_Form.Message_TextBox.Text = "Updating Tumbler Codes." & vbCrLf & "Updating Bottom Tumblers ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Bottom Tumbler Kit ==================================================================
        Dim tumblerkit_bottom As String = ""
        Dim tumblerkit_stepped As String = ""
        Dim bottom_tumbler As String = ""
        Dim bottom_stepped As String = ""
        Dim bottom_type As String = ""
        Dim bottom_tumblerkit As String = ""
        Dim bottom_chart As String = ""
        Dim bowl_lookup As String = ""
        Dim bowl_lookup_Sta7 As String = ""
        Dim stepped_lookup As String = ""

        ' Bottom 1 Begin =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot1Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot1Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 1 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot1Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot1Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot1Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot1Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_1_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_1_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_1_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_1_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_1_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_1_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_1_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot1_Stepped = stepped_lookup

        Catch ex As Exception
            MsgBox("Cannot find Bottom 1 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped1_Bowl = bowl_lookup
            R_Bot1_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot1_Bowl = bowl_lookup
            R_Stepped1_Bowl = "0"
        End If
        ' Bottom 1 End =============================================================================

        ' Bottom 2 =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot2Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot2Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 2 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot2Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot2Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot2Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot2Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_2_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_2_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_2_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_2_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_2_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_2_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_2_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot2_Stepped = stepped_lookup

        Catch ex As Exception
            MsgBox("Cannot find Bottom 2 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped2_Bowl = bowl_lookup
            R_Bot2_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot2_Bowl = bowl_lookup
            R_Stepped2_Bowl = "0"
        End If
        ' Bottom 2 =============================================================================

        ' Bottom 3 =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot3Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot3Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 3 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot3Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot3Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot3Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot3Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_3_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_3_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_3_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_3_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_3_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_3_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_3_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot3_Stepped = stepped_lookup
            
        Catch ex As Exception
            MsgBox("Cannot find Bottom 3 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped3_Bowl = bowl_lookup
            R_Bot3_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot3_Bowl = bowl_lookup
            R_Stepped3_Bowl = "0"
        End If
        ' Bottom 3 =============================================================================

        ' Bottom 4 =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot4Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot4Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 4 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot4Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot4Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot4Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot4Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_4_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_4_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_4_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_4_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_4_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_4_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_4_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot4_Stepped = stepped_lookup


        Catch ex As Exception
            MsgBox("Cannot find Bottom 4 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped4_Bowl = bowl_lookup
            R_Bot4_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot4_Bowl = bowl_lookup
            R_Stepped4_Bowl = "0"
        End If
        ' Bottom 4 =============================================================================

        ' Bottom 5 =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot5Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot5Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 5 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot5Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot5Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot5Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot5Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_5_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_5_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_5_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_5_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_5_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_5_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_5_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot5_Stepped = stepped_lookup


        Catch ex As Exception
            MsgBox("Cannot find Bottom 5 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped5_Bowl = bowl_lookup
            R_Bot5_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot5_Bowl = bowl_lookup
            R_Stepped5_Bowl = "0"
        End If
        ' Bottom 5 =============================================================================

        ' Bottom 6 =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot6Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot6Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 6 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot6Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot6Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot6Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot6Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_6_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_6_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_6_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_6_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_6_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_6_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_6_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot6_Stepped = stepped_lookup


        Catch ex As Exception
            MsgBox("Cannot find Bottom 6 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped6_Bowl = bowl_lookup
            R_Bot6_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot6_Bowl = bowl_lookup
            R_Stepped6_Bowl = "0"
        End If
        ' Bottom 6 =============================================================================

        ' Bottom 7 =============================================================================
        Try
            'If stepped == 1 Then use station #7
            'Station #7 takes priority over station #8
            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                'get type from Tumbler Kit
                bottom_tumblerkit = R_Sta_8_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot7Type(R_Sta_8_Part_Number)
            Else
                bottom_tumblerkit = R_Sta_7_Part_Number
                bottom_type = Tumbler_KitTableAdapter.GetBot7Type(R_Sta_7_Part_Number)
            End If
        Catch ex As Exception
            MsgBox("Cannot find Bottom 7 Type in Tumbler Kit. " & vbCrLf & ex.Message)
        End Try

        Try
            If bottom_type.ToUpper = "FIXED" Then
                ' get bowl specs from Tumbler Kit
                bottom_tumbler = Tumbler_KitTableAdapter.GetBot7Number(bottom_tumblerkit)
            ElseIf bottom_type.ToUpper = "RANDOM" Then
                'select based on mid half or bottom half of the second
                If Now.Millisecond Mod 4 > 1 Then
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot7Random1(bottom_tumblerkit)
                Else
                    bottom_tumbler = Tumbler_KitTableAdapter.GetBot7Random2(bottom_tumblerkit)
                End If

            ElseIf bottom_type.ToUpper = "KEYCODE" Then
                ' Get Chart name from Tumbler Kit table
                bottom_chart = Tumbler_KitTableAdapter.GetBot7Chart(bottom_tumblerkit)

                ' Get Chart lookup value for Bottom Tumbler according to Tumbler Code
                If Tumbler_7_Code = "1" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart1(bottom_chart)
                ElseIf Tumbler_7_Code = "2" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart2(bottom_chart)
                ElseIf Tumbler_7_Code = "3" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart3(bottom_chart)
                ElseIf Tumbler_7_Code = "4" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart4(bottom_chart)
                ElseIf Tumbler_7_Code = "5" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart5(bottom_chart)
                ElseIf Tumbler_7_Code = "6" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart6(bottom_chart)
                ElseIf Tumbler_7_Code = "7" Then
                    bottom_tumbler = ChartsTableAdapter.GetPart7(bottom_chart)
                End If
            End If

            ' get bowl specs from Bottom table
            bowl_lookup = Bottom_TumblerTableAdapter.GetBowl(bottom_tumbler)
            stepped_lookup = Bottom_TumblerTableAdapter.GetStepped(bottom_tumbler)
            R_Bot7_Stepped = stepped_lookup

        Catch ex As Exception
            MsgBox("Cannot find Bottom 7 Tumbler in Bottom Tumbler Table" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        'if stepped
        If stepped_lookup = "1" Then
            'stepped bowl
            R_Stepped7_Bowl = bowl_lookup
            R_Bot7_Bowl = "0"
        Else
            'if the bowl is not stepped, then it must be on Station 8
            R_Bot7_Bowl = bowl_lookup
            R_Stepped7_Bowl = "0"
        End If
        ' Bottom 7 =============================================================================

        Wait_Message_Form.Close()

        ' Update Tumbler Codes
        TumblerCode_OK = True
        MainMenu.Tumblers_Button.BackColor = Color.Green
        MainMenu.Tumblers_Button.Text = "Tumbler Codes are OK."
    End Sub

    ' =============================================================================
    ' Save Tumbler and Bowl Settings
    ' =============================================================================
    Public Sub SaveTumblerSettings()
        ' Update Spring Bowl
        My.Settings.Spring1_Bowl = GlobalVariables.R_Spring1_Bowl
        My.Settings.Spring2_Bowl = GlobalVariables.R_Spring2_Bowl
        My.Settings.Spring3_Bowl = GlobalVariables.R_Spring3_Bowl
        My.Settings.Spring4_Bowl = GlobalVariables.R_Spring4_Bowl
        My.Settings.Spring5_Bowl = GlobalVariables.R_Spring5_Bowl
        My.Settings.Spring6_Bowl = GlobalVariables.R_Spring6_Bowl
        My.Settings.Spring7_Bowl = GlobalVariables.R_Spring7_Bowl
        My.Settings.Spring8_Bowl = GlobalVariables.R_Spring8_Bowl

        ' Update Top Tumbler Bowl
        My.Settings.Top1_Bowl = GlobalVariables.R_Top1_Bowl
        My.Settings.Top2_Bowl = GlobalVariables.R_Top2_Bowl
        My.Settings.Top3_Bowl = GlobalVariables.R_Top3_Bowl
        My.Settings.Top4_Bowl = GlobalVariables.R_Top4_Bowl
        My.Settings.Top5_Bowl = GlobalVariables.R_Top5_Bowl
        My.Settings.Top6_Bowl = GlobalVariables.R_Top6_Bowl
        My.Settings.Top7_Bowl = GlobalVariables.R_Top7_Bowl
        My.Settings.Top8_Bowl = GlobalVariables.R_Top8_Bowl

        ' Update Mid Tumbler Bowl
        My.Settings.Mid1_Bowl = GlobalVariables.R_Mid1_Bowl
        My.Settings.Mid2_Bowl = GlobalVariables.R_Mid2_Bowl
        My.Settings.Mid3_Bowl = GlobalVariables.R_Mid3_Bowl
        My.Settings.Mid4_Bowl = GlobalVariables.R_Mid4_Bowl
        My.Settings.Mid5_Bowl = GlobalVariables.R_Mid5_Bowl
        My.Settings.Mid6_Bowl = GlobalVariables.R_Mid6_Bowl
        My.Settings.Mid7_Bowl = GlobalVariables.R_Mid7_Bowl
        My.Settings.Mid8_Bowl = GlobalVariables.R_Mid8_Bowl

        '===================================================
        'Stepped = Boolean
        '   On = Stepped
        '   OFF = Bottom
        'Bowl = Bowl number for Stepped or Bottom
        '   Set other Bowl number = 0
        '===================================================

        ' Update Bottom Tumbler Bowl
        My.Settings.Bot1_Bowl = GlobalVariables.R_Bot1_Bowl
        My.Settings.Bot2_Bowl = GlobalVariables.R_Bot2_Bowl
        My.Settings.Bot3_Bowl = GlobalVariables.R_Bot3_Bowl
        My.Settings.Bot4_Bowl = GlobalVariables.R_Bot4_Bowl
        My.Settings.Bot5_Bowl = GlobalVariables.R_Bot5_Bowl
        My.Settings.Bot6_Bowl = GlobalVariables.R_Bot6_Bowl
        My.Settings.Bot7_Bowl = GlobalVariables.R_Bot7_Bowl
        My.Settings.Bot8_Bowl = GlobalVariables.R_Bot8_Bowl

        ' Update Bottom Tumbler Stepped Enabled
        My.Settings.Stepped_1 = GlobalVariables.R_Bot1_Stepped
        My.Settings.Stepped_2 = GlobalVariables.R_Bot2_Stepped
        My.Settings.Stepped_3 = GlobalVariables.R_Bot3_Stepped
        My.Settings.Stepped_4 = GlobalVariables.R_Bot4_Stepped
        My.Settings.Stepped_5 = GlobalVariables.R_Bot5_Stepped
        My.Settings.Stepped_6 = GlobalVariables.R_Bot6_Stepped
        My.Settings.Stepped_7 = GlobalVariables.R_Bot7_Stepped
        My.Settings.Stepped_8 = GlobalVariables.R_Bot8_Stepped

        ' Update Bottom Tumbler Stepped Bowl
        My.Settings.Stepped1_Bowl = GlobalVariables.R_Stepped1_Bowl
        My.Settings.Stepped2_Bowl = GlobalVariables.R_Stepped2_Bowl
        My.Settings.Stepped3_Bowl = GlobalVariables.R_Stepped3_Bowl
        My.Settings.Stepped4_Bowl = GlobalVariables.R_Stepped4_Bowl
        My.Settings.Stepped5_Bowl = GlobalVariables.R_Stepped5_Bowl
        My.Settings.Stepped6_Bowl = GlobalVariables.R_Stepped6_Bowl
        My.Settings.Stepped7_Bowl = GlobalVariables.R_Stepped7_Bowl

        My.Settings.Save()
    End Sub

    '============================================================
    ' Form visibility changed
    '============================================================
    'Private Sub Keyfile_Select_Form_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
    '    If Me.Visible Then
    '        Dim c As Control = Me
    '        KeyFile_FullAccess(c, FullAccess)
    '    End If
    'End Sub

    '============================================================
    ' Form visibility changed
    '============================================================
    Private Sub KeyFile_FullAccess(ByVal container As Control, state As Boolean)
        For Each ctl In container.Controls
            If Not IsNothing(ctl.tag) Then
                Try
                    If ctl.tag.Substring(0, 4).upper = "FULL" Then
                        ctl.Enabled = Not state
                    End If
                    If ctl.HasChildren Then
                        KeyFile_FullAccess(ctl, state)
                    End If
                Catch

                End Try
            End If
        Next
    End Sub

    '============================================================
    ' Read Tumbler Codes from PLC
    '============================================================
    Private Sub ReadTumblerCodesFromPLC_Button_Click(sender As Object, e As EventArgs)
        ReadTumblerCodesFromPLC()
    End Sub

    '============================================================
    ' Verify Tumblers
    '============================================================
    Private Sub Verify_Tumblers_Button_Click(sender As Object, e As EventArgs)
        Verify_Tumbler_Download()
    End Sub

    '============================================================
    ' Send First Recipe Data
    '============================================================
    Private Sub Send_First_Recipe_Button_Click(sender As Object, e As EventArgs) Handles Send_First_Recipe_Button.Click
        CloseCurrentWorkFileRow()
        Send_First_Recipe_Data()
    End Sub

    Public Sub Send_First_Recipe_Data()
        MainMenu.MainMenu_Timer().Stop()

        If WorkFile_CurrentRow >= 0 Then
            KeyFile_OK = StartWorkFileRow(WorkFile_CurrentRow)

            If KeyFile_OK Then
                MainMenu.KeyFile_Form_Button.BackColor = SystemColors.Control

                'My.Settings.Marker_1_VarNum = 0
                'My.Settings.Marker_2_VarNum = 0
                'My.Settings.Save()

                If R_Sta_14_Enable = "1" Then
                    'Write variable returns true if variable is verified after download
                    Marker_1_Variable_Verified = Marker_1_Write_Variable(My.Settings.Marker_1_VarNum, My.Settings.Key_Series)
                    If Marker_1_Variable_Verified = False Then
                        MainMenu.Marker_1_Button.BackColor = Color.Yellow
                        MainMenu.Marker_1_Button.Text = "Program Variable not verified"
                    End If
                    M_Seq(1).Reset = True
                End If

                If R_Sta_17_Enable = "1" Then
                    'Write variable returns true if variable is verified after download
                    Marker_2_Variable_Verified = Marker_2_Write_Variable(My.Settings.Marker_2_VarNum, My.Settings.Key_Series)
                    If Marker_2_Variable_Verified = False Then
                        MainMenu.Marker_2_Button.BackColor = Color.Yellow
                        MainMenu.Marker_2_Button.Text = "Program Variable not verified"
                    End If
                    M_Seq(2).Reset = True
                End If
            Else
                MessageBox.Show("Keyfile is not valid",
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)

                MainMenu.KeyFile_Form_Button.BackColor = Color.Yellow
                Exit Sub
            End If

            If TumblerCode_OK = True Then

                If PLC_Comms_Enabled Then
                    ' write new tumbler codes to PLC
                    WriteTumblersToPLC()
                    Verify_Tumbler_Download()
                Else
                    MessageBox.Show("PLC communication is not enabled.",
                                    caption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("Tumbler Code is not valid" & vbCrLf &
                                    Key_Code,
                                    caption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)

                MainMenu.KeyFile_Form_Button.BackColor = Color.Yellow
                Exit Sub
            End If

            Send_First_Recipe_Button.BackColor = SystemColors.Control
            Try
                MainMenu.EthernetIPforCLXCom1.Write("First_Recipe_Data", 1)
                Send_First_Recipe_Button.BackColor = Color.Green
            Catch
                Send_First_Recipe_Button.BackColor = Color.Yellow
            End Try

            MainMenu.KeyFile_Form_Button.BackColor = Color.Green
            MainMenu.KeyFile_Form_Button.Text = "Key Code: " & Key_Code

            If MainMenu.MainMenu_Timer_Enabled Then
                MainMenu.MainMenu_Timer().Start()
            End If
        Else
            MainMenu.KeyFile_Form_Button.BackColor = Color.Yellow
            MessageBox.Show("Key file row is not valid " & vbCrLf &
                            "Select a valid key File row in the Data View",
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class


''============================================================
''Copy Work File to Data Grid View
''============================================================
'Private Sub Load_WorkFile_To_DGV()

'    'Clear DGV data. start with clean view
'    DataGridView1.DataSource = Nothing

'    For i = DataGridView1.Columns.Count - 1 To 0 Step -1
'        DataGridView1.Columns.RemoveAt(i)
'    Next

'    For i = DataGridView1.Rows.Count - 1 To 0 Step -1
'        DataGridView1.Rows.RemoveAt(i)
'    Next

'    DataGridView1.Refresh()

'    Try
'        MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\CompX\WorkFile\WorkFile.xls';Extended Properties=Excel 8.0;")
'        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [TEMPLATE$]", MyConnection)
'        'MyCommand = New System.Data.OleDb.OleDbDataAdapter("select Series, KeyNo, KeyCode, MKCode, Quantity, Desc, AssignedTo, Date  from [TEMPLATE$]", MyConnection)

'        DtSet = New System.Data.DataSet
'        MyCommand.Fill(DtSet, "[TEMPLATE$]")
'        'MyCommand.Update(DtSet)
'        DataGridView1.DataSource = DtSet
'        DataGridView1.DataMember = "[TEMPLATE$]"

'        If DataGridView1.Columns.Count < 5 Then
'            'error
'        End If

'    Catch ex As Exception
'        MessageBox.Show(String.Format("Cannot open Work File." & vbCrLf & "{0}", ex.Message))

'    End Try

'    ' rename quantity column
'    DataGridView1.Columns(4).HeaderCell.Value = "Quantity"

'    ' add column
'    If DataGridView1.Columns.Count = 5 Then
'        DataGridView1.Columns.Add("Desc", "Desc")
'    End If

'    ' add column
'    If DataGridView1.Columns.Count = 6 Then
'        DataGridView1.Columns.Add("AssignedTo", "Assigned To")
'    End If

'    ' add column
'    If DataGridView1.Columns.Count = 7 Then
'        DataGridView1.Columns.Add("Date", "Date")
'    End If

'    ' add columns
'    If DataGridView1.Columns.Count = 8 Then
'        DataGridView1.Columns.Add("Blank", "--")
'        DataGridView1.Columns.Add("QtyMadeGood", "Qty Good")
'        DataGridView1.Columns.Add("QtyMadeBad", "Qty Bad")
'        DataGridView1.Columns.Add("TimeStarted", "Time Started")
'        DataGridView1.Columns.Add("TimeCompleted", "Time Completed")
'    End If

'    MyConnection.Close()

'    DataGridView1.Update()
'    DataGridView1.Refresh()

'    'Copy DGV back to WorkFile to save new columns
'    Save_DGV_To_WorkFile()

'End Sub 

'Public Sub Cleanup()
'    Do
'        GC.Collect()
'        GC.WaitForPendingFinalizers()

'    Loop While Marshal.AreComObjectsAvailableForCleanup()
'End Sub

'=========================================
'MessageBox Template
'=========================================
'caption = "  "
'msg = "   "
'dialog_result = MessageBox.Show(msg, caption,
'                MessageBoxButtons.OK,
'                MessageBoxIcon.Asterisk,
'                MessageBoxDefaultButton.Button1)
