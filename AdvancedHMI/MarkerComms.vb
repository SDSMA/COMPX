﻿Option Explicit On

Imports System.IO
Imports System          'Access Console.WriteLine()
Imports System.IO.Ports 'Access the SerialPort Object
Imports AdvancedHMIDrivers

Public Module MarkerComms
    'Public X As List(Of KeyValuePair(Of String, Object)) = New List(Of KeyValuePair(Of String, Object))
    Public Marker_StateList As New List(Of String) From {"Init",
                                                        "Wait for Print",
                                                        "Printing",
                                                        "End"}
    Public Marker_Update_Time As Integer = 25

    Public Structure MarkerSequence
        Public CurrentState As String
        Public Name As String
        Public NextState As String

        Public start_time As DateTime
        Public stop_time As DateTime
        Public elapsed_time As TimeSpan
        Public TimeInState As Integer

        'https://docs.microsoft.com/en-us/dotnet/api/system.datetime?view=netframework-4.7.2
        Public PrintFinished As Boolean
        Public StateChanged As Boolean
        Public StateList() As String
        Public Description() As String
        Public TransitionOK As Boolean
        Public Timer As Timer
        Function Run()
            Return False
        End Function

        Public Enable As Boolean
        Public LoopCount As Integer
        Function Index()
            Dim response As Integer = -1
            For Each i As Integer In StateList
                If (i = CurrentState) Then
                    response = i
                End If
            Next

            Return response
        End Function

        Public Reset As Boolean

        Function Update()
            If TransitionOK Then

            End If

            If StateChanged Then
                CurrentState = NextState
            End If
            Return True
        End Function
    End Structure

    Public M_Seq(3) As MarkerSequence

    Public Marker_1_Ready As Boolean = False
    Public Marker_1_Status_OK As Boolean = False
    Public Marker_1_ComPort As SerialPort = New SerialPort()
    Public Marker_1_Comport_Error_Count As Integer = 0
    Public Marker_1_Status As String = ""
    Public Marker_1_Status_1 As String = ""
    Public Marker_1_Status_2 As String = ""
    Public Marker_1_Status_Text_1 As String = ""
    Public Marker_1_Status_Text_2 As String = ""
    Public Marker_1_ProgramUpload As String = ""
    Public Marker_1_Program(30) As String
    Public Marker_1_ProgNumber As String = ""
    Public Marker_1_VarNumber As String = ""
    Public Marker_1_Program_Verified As Boolean = False
    Public Marker_1_Variable_Verified As Boolean = False

    Public Marker_2_Ready As Boolean = False
    Public Marker_2_Status_OK As Boolean = False
    Public Marker_2_ComPort As SerialPort = New SerialPort()
    Public Marker_2_Comport_Error_Count As Integer = 0
    Public Marker_2_Status As String = ""
    Public Marker_2_Status_1 As String = ""
    Public Marker_2_Status_2 As String = ""
    Public Marker_2_Status_Text_1 As String = ""
    Public Marker_2_Status_Text_2 As String = ""
    Public Marker_2_ProgramUpload As String = ""
    Public Marker_2_Program(30) As String
    Public Marker_2_ProgNumber As String = ""
    Public Marker_2_VarNumber As String = ""
    Public Marker_2_Program_Verified As Boolean = False
    Public Marker_2_Variable_Verified As Boolean = False

    ' Marker Commands
    Dim Esc As String = Chr(27)
    Dim cr As String = Chr(13)

    ' =====================================================
    ' Marker Program
    ' =====================================================
    Public Sub Marker_1_Get_Program()
        Dim fileReader As String = ""
        Dim LineCounter As Integer = 0

        'fileReader = My.Computer.FileSystem.ReadAllText("C:\compx\Marker_1_program.txt")
        'MsgBox(fileReader)

        Using MyReader As New Microsoft.VisualBasic.FileIO.
            TextFieldParser("C:\compx\Marker_1_program.txt")

            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {vbTab, ","}

            'clear previous program
            Dim i As Integer = 0
            For i = 0 To Marker_2_Program.Length - 1
                Marker_2_Program(i) = Nothing
            Next

            Dim currentRow As String()
            'Loop through all fields in the file. 
            'If any lines are corrupt, report an error and continue parsing. 
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    ' handle the row.
                    Marker_1_Program(LineCounter) = currentRow(0)
                    LineCounter += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & " is invalid.  Skipped.")
                End Try
            End While
        End Using
    End Sub

    Public Sub Marker_2_Get_Program()
        Dim fileReader As String = ""
        Dim LineCounter As Integer = 0

        'fileReader = My.Computer.FileSystem.ReadAllText("C:\compx\Marker_2_program.txt")
        'MsgBox(fileReader)

        Using MyReader As New Microsoft.VisualBasic.FileIO.
            TextFieldParser("C:\compx\Marker_2_program.txt")

            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.Delimiters = New String() {vbTab, ","}

            'clear previous program
            Dim i As Integer = 0
            For i = 0 To Marker_2_Program.Length - 1
                Marker_2_Program(i) = Nothing
            Next

            Dim currentRow As String()
            'Loop through all fields in the file. 
            'If any lines are corrupt, report an error and continue parsing. 
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    ' handle the row.
                    Marker_2_Program(LineCounter) = currentRow(0)
                    LineCounter += 1
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & " is invalid.  Skipped.")
                End Try
            End While
        End Using
    End Sub

    Public Sub Marker_1_Write_Program()
        Marker_1_Get_Program()
        'For i = 0 To Marker_1_Program.Length - 1
        '    Marker_1_Program(i) = ""
        'Next

        'Marker_1_Program(0) = ""

        'Marker_1_Program(0) = "UU1"                     ' Metric
        'Marker_1_Program(1) = "PB 001"                              ' startprogram 1
        'Marker_1_Program(2) = "AJ"                                  ' downstroke
        'Marker_1_Program(3) = "MN"                                  ' normal mode
        'Marker_1_Program(4) = "CC 90"                               ' downstroke
        'Marker_1_Program(5) = "TA 20"                               ' character size
        'Marker_1_Program(6) = "J2"                                  ' forcecode
        'Marker_1_Program(7) = "PO2"                                 ' font
        'Marker_1_Program(8) = "M 280 242"                           ' movement
        'Marker_1_Program(9) = "SC 70"                               ' interchacter spacing
        'Marker_1_Program(10) = "MC260 264 93 860 2 2 1 1 100"        ' Marking angle
        'Marker_1_Program(11) = "CA"                                 ' Marking angle
        'Marker_1_Program(12) = "DF99:(V0)"                          ' format config variable 0
        'Marker_1_Program(13) = "MD 99"                              ' date format
        'Marker_1_Program(14) = "O"                                  ' return to origin
        'Marker_1_Program(15) = "PE 001"                             ' end program 1

    End Sub

    Public Sub Marker_2_Write_Program()
        Marker_2_Get_Program()

        'For i = 0 To Marker_2_Program.Length - 1
        '    Marker_2_Program(i) = ""
        'Next

        'Marker_2_Program(0) = "UU1"                                ' Metric
        'Marker_2_Program(1) = "PB001"                              ' startprogram 1
        'Marker_2_Program(2) = "AJ"                                  ' downstroke
        'Marker_2_Program(3) = "MN"                                  ' normal mode
        'Marker_2_Program(4) = "CC90"                               ' downstroke
        'Marker_2_Program(5) = "TA20"                               ' character size
        'Marker_2_Program(6) = "J2"                                  ' forcecode
        'Marker_2_Program(7) = "M13 0"                              ' movement
        'Marker_2_Program(8) = "PO2"                                 ' font
        'Marker_2_Program(9) = "SC100"                               ' interchacter spacing
        'Marker_2_Program(10) = "MA900"                              ' Marking angle
        'Marker_2_Program(11) = "DF99:(V0)"                          ' format config variable 0
        'Marker_2_Program(12) = "MG99"                              ' date format
        'Marker_2_Program(13) = "O"                                  ' return to origin
        'Marker_2_Program(14) = "PE001"                             ' end program 1
    End Sub

    ' =====================================================
    ' Marker Program Download
    ' =====================================================
    Public Function Marker_1_Download_Program()
        Wait_Message_Form.Text = "Verify Data Update"
        Wait_Message_Form.Message_TextBox.Text = "Comparing PLC to Database" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        Marker_1_Write_Program()

        For i = 0 To Marker_1_Program.Length - 1
            'If Marker_1_Program(i) <> "" Then
            If Not IsNothing(Marker_1_Program(i)) Then
                'download commands from the list
                Marker_1_SendData(Esc & Marker_1_Program(i) & cr, "")

                'Wait_Message_Form.Message_TextBox.Text = "Comparing PLC to Database" & vbCrLf &
                '                                       "Program Step " & i & " : " & Marker_1_Program(i)
                Wait_Message_Form.Refresh()
                Threading.Thread.Sleep(10)
            End If
        Next

        Threading.Thread.Sleep(1000)

        Dim x = Marker_1_VerifyProgram()
        If x Then
            Markers_Form.Marker_1_VerifyProgram_Button.Text = "Marker 1 program loaded"
            Markers_Form.Marker_1_VerifyProgram_Button.BackColor = Color.Green

            Wait_Message_Form.Message_TextBox.Text = "Marker 1 program loaded successfully"
        Else
            Markers_Form.Marker_1_VerifyProgram_Button.Text = "Marker 1 program Failed to Load"
            Markers_Form.Marker_1_VerifyProgram_Button.BackColor = Color.Yellow

            Wait_Message_Form.Message_TextBox.Text = "Marker Program did not Load."
        End If

        Wait_Message_Form.Refresh()
        Threading.Thread.Sleep(100)
        Return x
    End Function

    Public Function Marker_2_Download_Program()
        Marker_2_Write_Program()

        ' fix ending number
        For i = 0 To Marker_2_Program.Length - 1
            'If Marker_2_Program(i) <> "" Then
            If Not IsNothing(Marker_2_Program(i)) Then
                'download commands from the list
                If (i = Marker_2_Program.Length - 1) Then
                    Marker_2_SendData(Esc & Marker_2_Program(i) & cr, "RT0")
                Else
                    Marker_2_SendData(Esc & Marker_2_Program(i) & cr, "")
                End If

                Threading.Thread.Sleep(10)
                End If
        Next

        Threading.Thread.Sleep(1000)

        Dim x = Marker_2_VerifyProgram()
        If x Then
            Markers_Form.Marker_2_VerifyProgram_Button.Text = "Marker 2 program loaded"
            Markers_Form.Marker_2_VerifyProgram_Button.BackColor = Color.Green

            Wait_Message_Form.Message_TextBox.Text = "Marker 2 program loaded successfully"
        Else
            Markers_Form.Marker_2_VerifyProgram_Button.Text = "Marker 2 program failed to load"
            Markers_Form.Marker_2_VerifyProgram_Button.BackColor = Color.Yellow

            Wait_Message_Form.Message_TextBox.Text = "Marker program did not Load."
        End If

        Return x
    End Function

    ' =====================================================
    ' Marker Communication
    ' =====================================================
    ' Get names of available serial ports
    Public Function GetSerialPortNames()
        ' Get a list of serial port names
        Dim msg As String = ""
        Dim ports(10) As String
        Dim port As String

        ports = SerialPort.GetPortNames()

        If ports.Length > 0 Then
            msg = "These serial ports are available:" & vbCrLf
            For Each port In ports
                msg = msg & vbTab & port
            Next
            MsgBox(msg)
        Else
            MsgBox("No serial ports were found.")
        End If
        Return msg
    End Function

    ' =====================================================
    ' Marker Open Com port
    ' =====================================================
    Public Function Marker_1_OpenComPort() As Boolean
        Dim msg As String
        Dim response As Boolean = False
        Try
            If Marker_1_ComPort.IsOpen Then
                msg = Marker_1_ComPort.PortName & " is open"
            Else
                Marker_1_ComPort.PortName = My.Settings.Marker_1_PortName
                Marker_1_ComPort.BaudRate = My.Settings.Marker_1_BaudRate
                Marker_1_ComPort.Parity = My.Settings.Marker_1_Parity
                Marker_1_ComPort.DataBits = My.Settings.Marker_1_Length
                Marker_1_ComPort.StopBits = My.Settings.Marker_1_StopBits

                Marker_1_ComPort.Open()

                msg = Marker_1_ComPort.PortName & " opened"

                Markers_Form.Update()
                MainMenu.Update()
                System.Windows.Forms.Application.DoEvents()
                Threading.Thread.Sleep(500)

            End If

            Marker_1_Update_Buttons()
        Catch ex As Exception
            msg = Marker_1_ComPort.PortName & " exception"
            'MessageBox.Show(String.Format(msg & vbCrLf & "{0}", ex.Message))
            response = False
        End Try

        Markers_Form.Marker_1_CommLog_TextBox.AppendText(msg & vbCrLf)
        Return Marker_1_ComPort.IsOpen
    End Function

    Public Function Marker_2_OpenComPort() As Boolean
        Dim msg As String
        Dim response As Boolean = False
        Try
            If Marker_2_ComPort.IsOpen Then
                msg = Marker_2_ComPort.PortName & " is open"
            Else
                Marker_2_ComPort.PortName = My.Settings.Marker_2_PortName
                Marker_2_ComPort.BaudRate = My.Settings.Marker_2_BaudRate
                Marker_2_ComPort.Parity = My.Settings.Marker_2_Parity
                Marker_2_ComPort.DataBits = My.Settings.Marker_2_Length
                Marker_2_ComPort.StopBits = My.Settings.Marker_2_StopBits

                Marker_2_ComPort.Open()

                Markers_Form.Update()
                MainMenu.Update()
                System.Windows.Forms.Application.DoEvents()
                Threading.Thread.Sleep(500)

                msg = Marker_2_ComPort.PortName & " opened"
            End If

            Marker_2_Update_Buttons()
        Catch ex As Exception
            msg = Marker_2_ComPort.PortName & " exception"
            'MessageBox.Show(String.Format(msg & vbCrLf & "{0}", ex.Message))
            response = False
        End Try

        Markers_Form.Marker_2_CommLog_TextBox.AppendText(msg & vbCrLf)
        Return Marker_2_ComPort.IsOpen
    End Function

    ' =====================================================
    ' Marker Close Com port
    ' =====================================================
    Public Function Marker_1_CloseComPort()
        Dim msg As String
        Dim caption As String

        Try
            Marker_1_ComPort.Close()
        Catch ex As Exception
            caption = "Marker 1"
            msg = "Cannot close : " & Marker_1_ComPort.PortName
            MessageBox.Show(String.Format(msg & vbCrLf & "{0}", ex.Message, caption))
        End Try
        msg = "Com port closed" & Marker_1_ComPort.PortName
        Markers_Form.Marker_1_CommLog_TextBox.AppendText(msg & vbCrLf)

        Marker_1_Update_Buttons()
        Return Marker_1_ComPort.IsOpen
    End Function

    Public Function Marker_2_CloseComPort()
        Dim msg As String
        Dim caption As String
        Try
            Marker_2_ComPort.Close()
        Catch ex As Exception
            caption = "Marker 2"
            msg = "Cannot close : " & Marker_2_ComPort.PortName
            MessageBox.Show(String.Format(msg & vbCrLf & "{0}", ex.Message, caption))
        End Try
        msg = "Com port closed" & Marker_2_ComPort.PortName
        Markers_Form.Marker_2_CommLog_TextBox.AppendText(msg & vbCrLf)

        Marker_2_Update_Buttons()
        Return Marker_2_ComPort.IsOpen
    End Function

    ' =====================================================
    ' Marker Update
    ' =====================================================
    Private Sub Marker_1_Update_Buttons()
        If Marker_1_ComPort.IsOpen Then
            Markers_Form.Marker_1_Open_ComPort_Button.Visible = False
            Markers_Form.Marker_1_Close_ComPort_Button.Visible = True

            Markers_Form.Marker_1_Close_ComPort_Button.Text = "Marker 1 ComPort Open"
        Else
            Markers_Form.Marker_1_Open_ComPort_Button.Visible = True
            Markers_Form.Marker_1_Close_ComPort_Button.Visible = False

            Markers_Form.Marker_1_Close_ComPort_Button.Text = "Marker 1 ComPort Not Open"
        End If
    End Sub

    Private Sub Marker_2_Update_Buttons()
        If Marker_2_ComPort.IsOpen Then
            Markers_Form.Marker_2_Open_ComPort_Button.Visible = False
            Markers_Form.Marker_2_Close_ComPort_Button.Visible = True

            Markers_Form.Marker_2_Close_ComPort_Button.Text = "Marker 2 ComPort Open"
        Else
            Markers_Form.Marker_2_Open_ComPort_Button.Visible = True
            Markers_Form.Marker_2_Close_ComPort_Button.Visible = False

            Markers_Form.Marker_2_Close_ComPort_Button.Text = "Marker 2 ComPort Not Open"
        End If
    End Sub

    ' =====================================================
    ' Marker Cold Start
    ' =====================================================
    Public Function Marker_1_ColdStart()
        ' return true if com port is open with my.settings 

        Dim msg As String
        Dim response As Boolean = False
        Dim dialog_result As DialogResult
        Dim caption As String
        Dim count As Integer = 0

        Wait_Message_Form.Text = "Marker 1 Setup"

        Wait_Message_Form.Message_TextBox.Text = "Opening Marker com port" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        '================================================
        'Check if com port Open
        '================================================
        Do While Marker_1_ComPort.IsOpen = False

            Marker_1_OpenComPort()

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(1000)

            If Marker_1_ComPort.IsOpen Then
                ' if com port is open, we'll leave the loop next time
                Markers_Form.Marker_1_CommLog_TextBox.AppendText("Com Port is open" & vbCrLf)
            Else
                caption = "Marker 1"
                msg = "Cannot open " & Marker_1_ComPort.PortName
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(5)
        Loop

        Wait_Message_Form.Message_TextBox.Text = "Reading Marker Status" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' query Marker status
        '================================================
        count = 0
        Do Until Marker_1_status_OK
            Marker_1_ReadStatus()
            Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker status: " & Marker_1_Status & vbCrLf)

            If Marker_1_status_OK Then

            Else
                caption = "Marker 1"
                msg = "Marker does not respond to communication ... " & vbCrLf &
                    vbTab & "Check Marker power is ON." & vbCrLf &
                    vbTab & "Check Serial Port Connections at the computer" & vbCrLf &
                    vbTab & "and at the Marker." & vbCrLf &
                    vbTab & "Then click 'Retry' to try again." & vbCrLf &
                    vbCrLf &
                    "If this does not work:" & vbCrLf &
                    vbTab & "Turn Marker power switch OFF." & vbCrLf &
                    vbTab & "Wait at least 20 seconds." & vbCrLf &
                    "Turn Marker power switch ON." & vbCrLf &
                    vbTab & "Then click 'Abort' to bypass Marker verification," & vbCrLf &
                    vbTab & "Or click 'Retry' to reset the Marker," & vbCrLf &
                    vbTab & "Or click 'Ignore' to continue Marker Verification."

                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.AbortRetryIgnore,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Abort Then
                    Wait_Message_Form.Close()
                    Return False
                ElseIf dialog_result = System.Windows.Forms.DialogResult.No Then
                    ' stay in the loop
                    count = 0
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Exit Do
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        '================================================
        ' if we can read marker status, then bypass the resetting to defaults
        '================================================
        If Marker_1_status_OK Then
            GoTo Marker_1_ReadStatus

            Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker status: " & Marker_1_Status & vbCrLf)

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)
        End If

        Wait_Message_Form.Message_TextBox.Text = "Cannot read Marker status." & vbCrLf & "Setting Marker to default settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Set Marker comms to default settings
        '================================================
        response = False
        Do Until response
            msg = "Setting Comport to 1200, 7,1,E"

            Try
                Marker_1_ComPort.Close()
                Marker_1_ComPort.PortName = My.Settings.Marker_1_PortName
                Marker_1_ComPort.BaudRate = 1200
                Marker_1_ComPort.Parity = 2
                Marker_1_ComPort.DataBits = 7
                Marker_1_ComPort.StopBits = 1
                Marker_1_ComPort.Open()

                response = True

                Markers_Form.Marker_1_CommLog_TextBox.AppendText(Marker_1_ComPort.PortName & " set To defaults" & vbCrLf)

            Catch ex As Exception
                caption = "Marker 1"
                msg = "Cannot set " & Marker_1_ComPort.PortName & " to Marker default settings"
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End Try

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)
        Loop

        Wait_Message_Form.Message_TextBox.Text = "Attempting to communicate with Marker at default settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' query Marker com port at default settings
        '================================================
        count = 0
        Do Until Marker_1_status_OK
            Marker_1_ReadStatus()

            If Marker_1_status_OK Then

            Else
                caption = "Marker 1"
                msg = "Marker does not respond to query at default settings... "
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End If

            Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker status: " & Marker_1_Status & vbCrLf)

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1
        Loop

        Wait_Message_Form.Message_TextBox.Text = "Connected to Marker." & vbCrLf & "Setting Marker to normal settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Restore Marker coms to my.settings
        '================================================
        Marker_1_SendData(Esc & "SV 2400 8 1 0" & cr, "")

        Markers_Form.Marker_1_CommLog_TextBox.AppendText("Restore " & Marker_1_ComPort.PortName & " to Settings: " & vbCrLf)
        Markers_Form.Update()
        MainMenu.Update()
        System.Windows.Forms.Application.DoEvents()
        Threading.Thread.Sleep(5)

        ' Marker no longer responds to comms at current settings

        '================================================
        ' Restore PC coms to my.settings
        '================================================
        Try
            Marker_1_ComPort.Close()
            Marker_1_ComPort.PortName = My.Settings.Marker_1_PortName
            Marker_1_ComPort.BaudRate = My.Settings.Marker_1_BaudRate
            Marker_1_ComPort.Parity = My.Settings.Marker_1_Parity
            Marker_1_ComPort.DataBits = My.Settings.Marker_1_Length
            Marker_1_ComPort.StopBits = My.Settings.Marker_1_StopBits
            Marker_1_ComPort.Open()

            Markers_Form.Marker_1_CommLog_TextBox.AppendText("Change " & Marker_1_ComPort.PortName & " to My.Settings" & vbCrLf)
            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(5)

        Catch ex As Exception
            caption = "Marker 1"
            msg = "Cannot change " & Marker_1_ComPort.PortName & " settings"
            'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function
            dialog_result = MessageBox.Show(msg, caption,
                            MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                ' stay in the loop
            ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                Wait_Message_Form.Close()
                Return False
            End If
        End Try

Marker_1_ReadStatus:

        Wait_Message_Form.Message_TextBox.Text = "Reading Marker status at normal settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        'Read Marker Status at normal settings
        '================================================
        count = 0
        Do Until Marker_1_status_OK
            Marker_1_ReadStatus()

            ' Check that all is well in comms world
            If Marker_1_status_OK And
                Marker_1_ComPort.PortName = My.Settings.Marker_1_PortName And
                Marker_1_ComPort.BaudRate = My.Settings.Marker_1_BaudRate And
                Marker_1_ComPort.Parity = My.Settings.Marker_1_Parity And
                Marker_1_ComPort.DataBits = My.Settings.Marker_1_Length And
                Marker_1_ComPort.StopBits = My.Settings.Marker_1_StopBits And
                Marker_1_ComPort.IsOpen() Then

                Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker status: " & Marker_1_Status & vbCrLf)

            Else
                msg = "Cannot read Marker status." &
                    vbCrLf & "It make take up to a minute for the printer to restart after power ON."
                caption = "Marker 1"
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                    count = 0
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        'we're communicating with the Marker
        'Continue on to check progam

Marker_1_DownloadProgram:

        Wait_Message_Form.Message_TextBox.Text = "Marker status is OK" & vbCrLf & "Verifying Marker program." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Check for valid program
        '================================================
        count = 0
        Do Until Marker_1_Program_Verified
            Marker_1_Program_Verified = Marker_1_VerifyProgram()

            If Marker_1_Program_Verified Then
                Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker Program is OK" & vbCrLf)
            Else
                Markers_Form.Marker_1_CommLog_TextBox.AppendText("Downloading Marker Program" & vbCrLf)

                'downloadprogram returns true if program is verified afer download
                Marker_1_Program_Verified = Marker_1_Download_Program()

                If Marker_1_Program_Verified Then
                    Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker Program is OK" & vbCrLf)
                Else
                    caption = "Marker 1"
                    msg = "Cannot download program ... " & vbCrLf &
                            vbCrLf &
                            "<Retry> to download program" & vbCrLf &
                            "<Cancel> to quit"
                    dialog_result = MessageBox.Show(msg, caption,
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                    If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                        ' stay in the loop
                    ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                        Wait_Message_Form.Close()
                        Return False
                    End If

                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        Wait_Message_Form.Message_TextBox.Text = "Marker program is OK" & vbCrLf & "Verifying Marker variable." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Check for valid variable
        '================================================
        count = 0
        Do Until Marker_1_Variable_Verified
            Marker_1_Variable_Verified = Marker_1_VerifyVariable()

            If Marker_1_Variable_Verified Then
                Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker Variable is OK" & vbCrLf)

                Markers_Form.Update()
                MainMenu.Update()
                System.Windows.Forms.Application.DoEvents()
                Threading.Thread.Sleep(500)
            Else
                'Write variable returns true if varible is verified after download
                Marker_1_Variable_Verified = Marker_1_Write_Variable(Marker_1_VarNumber, My.Settings.Key_Code)

                If Marker_1_Variable_Verified Then
                    Markers_Form.Marker_1_CommLog_TextBox.AppendText("Marker Variable is OK" & vbCrLf)

                Else
                    caption = "Marker 1"
                    msg = "Cannot verify variable... "
                    dialog_result = MessageBox.Show(msg, caption,
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                    If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                        ' stay in the loop
                    ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                        Wait_Message_Form.Close()
                        Return False
                    End If
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        Wait_Message_Form.Message_TextBox.Text = "Marker communication, status, program and variable are OK" & vbCrLf & "marker is Ready!"
        Wait_Message_Form.Refresh()

        '================================================
        'One last check
        '================================================
        If Marker_1_ComPort.IsOpen And
            Marker_1_status_OK And
            Marker_1_Program_Verified And
            Marker_1_Variable_Verified Then

            Markers_Form.Marker_1_Cold_Start_Button.BackColor = Color.Green
            Markers_Form.Marker_1_Cold_Start_Button.Text = "Marker 1 Ready"
            Wait_Message_Form.Close()
            Return True
        Else
            Markers_Form.Marker_1_Cold_Start_Button.BackColor = SystemColors.Control
            Markers_Form.Marker_1_Cold_Start_Button.Text = "Marker 1 ColdStart"
            Wait_Message_Form.Close()
            Return False
        End If
    End Function

    ' =====================================================
    ' Marker Cold Start
    ' =====================================================
    Public Function Marker_2_ColdStart()
        ' return true if com port is open with my.settings 

        Dim msg As String
        Dim response As Boolean = False
        Dim dialog_result As DialogResult
        Dim caption As String
        Dim count As Integer = 0

        Wait_Message_Form.Text = "Marker 2 Setup"

        Wait_Message_Form.Message_TextBox.Text = "Opening marker com port" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        '================================================
        'Check if com port Open
        '================================================
        Do While Marker_2_ComPort.IsOpen = False

            Marker_2_OpenComPort()

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(1000)

            If Marker_2_ComPort.IsOpen Then
                ' if com port is open, we'll leave the loop next time
                Markers_Form.Marker_2_CommLog_TextBox.AppendText("Com Port is open" & vbCrLf)
            Else
                caption = "Marker 2"
                msg = "cannot open " & Marker_2_ComPort.PortName
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(5)
        Loop

        Wait_Message_Form.Message_TextBox.Text = "Reading Marker Status" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' query Marker status
        '================================================
        count = 0
        Do Until Marker_2_status_OK
            Marker_2_ReadStatus()
            Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker status: " & Marker_2_Status & vbCrLf)

            If Marker_2_status_OK Then

            Else
                caption = "Marker 2"
                msg = "Marker does not respond to communication ... " & vbCrLf &
                    vbTab & "Check Marker power is ON." & vbCrLf &
                    vbTab & "Check Serial Port Connections at the computer" & vbCrLf &
                    vbTab & "and at the Marker." & vbCrLf &
                    vbTab & "Then click 'Retry' to try again." & vbCrLf &
                    vbCrLf &
                    "If this does not work:" & vbCrLf &
                    vbTab & "Turn Marker power switch OFF." & vbCrLf &
                    vbTab & "Wait at least 20 seconds." & vbCrLf &
                    "Turn Marker power switch ON." & vbCrLf &
                    vbTab & "Then click 'Abort' to bypass Marker verification," & vbCrLf &
                    vbTab & "Or click 'Retry' to reset the Marker," & vbCrLf &
                    vbTab & "Or click 'Ignore' to continue Marker Verification."

                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.AbortRetryIgnore,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Abort Then
                    Wait_Message_Form.Close()
                    Return False
                ElseIf dialog_result = System.Windows.Forms.DialogResult.No Then
                    ' stay in the loop
                    count = 0
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Exit Do
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        '================================================
        ' if we can read marker status, then bypass the resetting to defaults
        '================================================
        If Marker_2_status_OK Then
            GoTo Marker_2_ReadStatus

            Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker status: " & Marker_2_Status & vbCrLf)

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)
        End If

        Wait_Message_Form.Message_TextBox.Text = "Cannot read Marker status." & vbCrLf & "Setting Marker to default settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Set Marker comms to default settings
        '================================================
        response = False
        Do Until response
            msg = "Setting Comport to 1200, 7,1,E"

            Try
                Marker_2_ComPort.Close()
                Marker_2_ComPort.PortName = My.Settings.Marker_2_PortName
                Marker_2_ComPort.BaudRate = 1200
                Marker_2_ComPort.Parity = 2
                Marker_2_ComPort.DataBits = 7
                Marker_2_ComPort.StopBits = 1
                Marker_2_ComPort.Open()

                response = True

                Markers_Form.Marker_2_CommLog_TextBox.AppendText(Marker_2_ComPort.PortName & " set To defaults" & vbCrLf)

            Catch ex As Exception
                caption = "Marker 2"
                msg = "Cannot set " & Marker_2_ComPort.PortName & " to Marker default settings"
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End Try

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)
        Loop

        Wait_Message_Form.Message_TextBox.Text = "Attempting to communicate with Marker at default settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' query Marker com port at default settings
        '================================================
        count = 0
        Do Until Marker_2_status_OK
            Marker_2_ReadStatus()

            If Marker_2_status_OK Then

            Else
                caption = "Marker 2"
                msg = "Marker does not respond to query at default settings... "
                'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End If

            Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker status: " & Marker_2_Status & vbCrLf)

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1
        Loop

        Wait_Message_Form.Message_TextBox.Text = "Connected to Marker." & vbCrLf & "Setting Marker to normal settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Restore Marker coms to my.settings
        '================================================
        Marker_2_SendData(Esc & "SV 2400 8 1 0" & cr, "")

        Markers_Form.Marker_2_CommLog_TextBox.AppendText("Restore " & Marker_2_ComPort.PortName & " to Settings: " & vbCrLf)
        Markers_Form.Update()
        MainMenu.Update()
        System.Windows.Forms.Application.DoEvents()
        Threading.Thread.Sleep(5)

        ' Marker no longer responds to comms at current settings

        '================================================
        ' Restore PC coms to my.settings
        '================================================
        Try
            Marker_2_ComPort.Close()
            Marker_2_ComPort.PortName = My.Settings.Marker_2_PortName
            Marker_2_ComPort.BaudRate = My.Settings.Marker_2_BaudRate
            Marker_2_ComPort.Parity = My.Settings.Marker_2_Parity
            Marker_2_ComPort.DataBits = My.Settings.Marker_2_Length
            Marker_2_ComPort.StopBits = My.Settings.Marker_2_StopBits
            Marker_2_ComPort.Open()

            Markers_Form.Marker_2_CommLog_TextBox.AppendText("Change " & Marker_2_ComPort.PortName & " to My.Settings" & vbCrLf)
            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(5)

        Catch ex As Exception
            caption = "Marker 2"
            msg = "Cannot change " & Marker_2_ComPort.PortName & " settings"
            'https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function
            dialog_result = MessageBox.Show(msg, caption,
                            MessageBoxButtons.RetryCancel,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1)
            If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                ' stay in the loop
            ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                Wait_Message_Form.Close()
                Return False
            End If
        End Try

Marker_2_ReadStatus:

        Wait_Message_Form.Message_TextBox.Text = "Reading Marker status at normal settings" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        'Read Marker Status at normal settings
        '================================================
        count = 0
        Do Until Marker_2_status_OK
            Marker_2_ReadStatus()

            ' Check that all is well in comms world
            If Marker_2_status_OK And
                Marker_2_ComPort.PortName = My.Settings.Marker_2_PortName And
                Marker_2_ComPort.BaudRate = My.Settings.Marker_2_BaudRate And
                Marker_2_ComPort.Parity = My.Settings.Marker_2_Parity And
                Marker_2_ComPort.DataBits = My.Settings.Marker_2_Length And
                Marker_2_ComPort.StopBits = My.Settings.Marker_2_StopBits And
                Marker_2_ComPort.IsOpen() Then

                Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker status: " & Marker_2_Status & vbCrLf)

            Else
                caption = "Marker 2"
                msg = "Cannot read Marker status." &
                    vbCrLf & "It make take up to a minute for the printer to restart after power ON."
                dialog_result = MessageBox.Show(msg, caption,
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1)
                If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                    ' stay in the loop
                    count = 0
                ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                    Wait_Message_Form.Close()
                    Return False
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        'we're communicating with the Marker
        'Continue on to check progam

Marker_2_DownloadProgram:

        Wait_Message_Form.Message_TextBox.Text = "Marker status is OK" & vbCrLf & "Verifying Marker program." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Check for valid program
        '================================================
        count = 0
        Do Until Marker_2_Program_Verified
            Marker_2_Program_Verified = Marker_2_VerifyProgram()

            If Marker_2_Program_Verified Then
                Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker Program is OK" & vbCrLf)
            Else
                Markers_Form.Marker_2_CommLog_TextBox.AppendText("Downloading Marker Program" & vbCrLf)

                'downloadprogram returns true if program is verified afer download
                Marker_2_Program_Verified = Marker_2_Download_Program()

                If Marker_2_Program_Verified Then
                    Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker Program is OK" & vbCrLf)
                Else
                    caption = "Marker 2"
                    msg = "Cannot download program ... " & vbCrLf &
                            "<Retry> to download program" & vbCrLf &
                            "<Cancel> to quit"
                    dialog_result = MessageBox.Show(msg, caption,
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                    If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                        ' stay in the loop
                    ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                        Wait_Message_Form.Close()
                        Return False
                    End If

                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        Wait_Message_Form.Message_TextBox.Text = "Marker program is OK" & vbCrLf & "Verifying Marker variable." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Refresh()

        '================================================
        ' Check for valid variable
        '================================================
        count = 0
        Do Until Marker_2_Variable_Verified
            Marker_2_Variable_Verified = Marker_2_VerifyVariable()

            If Marker_2_Variable_Verified Then
                Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker Variable is OK" & vbCrLf)

                Markers_Form.Update()
                MainMenu.Update()
                System.Windows.Forms.Application.DoEvents()
                Threading.Thread.Sleep(500)
            Else
                'Write variable returns true if varible is verified after download
                Marker_2_Variable_Verified = Marker_2_Write_Variable(Marker_2_VarNumber, My.Settings.Key_Code)

                If Marker_2_Variable_Verified Then
                    Markers_Form.Marker_2_CommLog_TextBox.AppendText("Marker Variable is OK" & vbCrLf)

                Else
                    caption = "Marker 2"
                    msg = "Cannot verify variable... "
                    dialog_result = MessageBox.Show(msg, caption,
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Exclamation,
                                    MessageBoxDefaultButton.Button1)
                    If dialog_result = System.Windows.Forms.DialogResult.Retry Then
                        ' stay in the loop
                    ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
                        Wait_Message_Form.Close()
                        Return False
                    End If
                End If
            End If

            Markers_Form.Update()
            MainMenu.Update()
            System.Windows.Forms.Application.DoEvents()
            Threading.Thread.Sleep(500)

            count += 1

        Loop

        Wait_Message_Form.Message_TextBox.Text = "Marker communication, status, program and variable are OK" & vbCrLf & "marker is Ready!"
        Wait_Message_Form.Refresh()

        '================================================
        'One last check
        '================================================
        If Marker_2_ComPort.IsOpen And
            Marker_2_status_OK And
            Marker_2_Program_Verified And
            Marker_2_Variable_Verified Then

            Markers_Form.Marker_2_Cold_Start_Button.BackColor = Color.Green
            Markers_Form.Marker_2_Cold_Start_Button.Text = "Marker 2 Ready"
            Wait_Message_Form.Close()
            Return True
        Else
            Markers_Form.Marker_2_Cold_Start_Button.BackColor = SystemColors.Control
            Markers_Form.Marker_2_Cold_Start_Button.Text = "Marker 2 ColdStart"
            Wait_Message_Form.Close()
            Return False
        End If
    End Function

    ' =====================================================
    ' Marker Write Serial Port 
    ' =====================================================
    Function Marker_1_SendData(ByVal data As String, Optional ByVal expectedresponse As String = Nothing, Optional force As Boolean = False) As String
        ' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-send-strings-to-serial-ports
        ' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-receive-strings-from-serial-ports
        ' https://www.xanthium.in/serial-port-programming-visual-basic-dotnet-for-embedded-developers

        Dim returnStr As String = ""
        Dim Incoming As String = ""
        Dim count As Integer = 0
        Dim IncomingBytesToRead As Integer
        Dim msg As String = ""

        Try
            If Not Marker_1_ComPort.IsOpen Then
                Marker_1_OpenComPort()
            End If
        Catch ex As Exception
            Return "-1"
        End Try

        If Not Marker_1_ComPort.IsOpen Then
            Return "-1"
        End If

        If Marker_1_ComPort.BytesToRead > 0 Or
            Marker_1_ComPort.BytesToWrite > 0 Then

            Marker_1_Comport_Error_Count += 1
            Markers_Form.Marker_1_CommLog_TextBox.AppendText("Com error(s): " & Marker_1_Comport_Error_Count & vbCrLf)

            Incoming = Marker_1_ComPort.ReadExisting()
            If Incoming <> "" Then
                Markers_Form.Marker_1_CommLog_TextBox.AppendText("Read: " & Incoming & vbCrLf)
                Incoming = ""
            End If

        End If
        'flush old commm data
        'Marker_1_ComPort.DiscardInBuffer()
        'Marker_1_ComPort.DiscardOutBuffer()

        Try
            'Marker_1_ComPort.WriteLine(data)
            Marker_1_ComPort.DiscardInBuffer() ''TYLER
            Marker_1_ComPort.Write(data)
            msg = "Send: " & data.Replace(Chr(27), "")
        Catch ex As Exception
            msg = "Send Exception: " & "-1"
            Return "-1"
        End Try

        Markers_Form.Marker_1_CommLog_TextBox.AppendText(msg & vbCrLf)

        'wait for response?
        If expectedresponse Is "" Then
            'no
            Return "Sent"
        Else
            'yes... wait for the response
            Dim x As Integer = 0
            Try
                Do
                    ' give the port time to read
                    System.Windows.Forms.Application.DoEvents()
                    Threading.Thread.Sleep(100)

                    ' incoming byte count
                    IncomingBytesToRead = Marker_1_ComPort.BytesToRead()

                    ' incoming data
                    Incoming = Marker_1_ComPort.ReadExisting()

                    ' add to all received thus far
                    returnStr = returnStr & Incoming

                    ' if got return string, exit
                    If (returnStr = expectedresponse Or returnStr = expectedresponse & vbCr) Then
                        Exit Do
                    End If

                    ' if we received something earlier, and now we get nothing, we must have gotten all there was
                    If Incoming = "" And returnStr <> "" And ((x > 7 And Not force) Or x > 100) Then
                        Exit Do
                    End If

                    ' if, after several tries, we still don't have anything, ... punt
                    If returnStr = Nothing And (x > 10) Then
                        returnStr = "-1"
                        Exit Do
                    End If
                    x += 1

                    msg = returnStr
                Loop
                'returnStr = returnStr.Replace(vbCr, "").Replace(vbCrLf, "").Replace(vbLf, "")

            Catch ex As Exception
                msg = "Com port exception"
                returnStr = "-1"
            End Try
        End If

        Markers_Form.Marker_1_CommLog_TextBox.AppendText("Read: " & msg & vbCrLf)
        Marker_1_ComPort.DiscardInBuffer() ''TYLER
        Return returnStr
    End Function

    ' =====================================================
    ' Marker Write Serial Port 
    ' =====================================================
    Function Marker_2_SendData(ByVal data As String, Optional ByVal expectedresponse As String = Nothing, Optional force As Boolean = False) As String

        ' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-send-strings-to-serial-ports
        ' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-receive-strings-from-serial-ports
        ' https://www.xanthium.in/serial-port-programming-visual-basic-dotnet-for-embedded-developers

        Dim returnStr As String = ""
        Dim Incoming As String = ""
        Dim count As Integer = 0
        Dim IncomingBytesToRead As Integer
        Dim msg As String = ""

        Try
            If Not Marker_2_ComPort.IsOpen Then
                Marker_2_OpenComPort()
            End If
        Catch ex As Exception
            Return "-1"
        End Try

        If Not Marker_2_ComPort.IsOpen Then
            Return "-1"
        End If

        If Marker_2_ComPort.BytesToRead > 0 Or
            Marker_2_ComPort.BytesToWrite > 0 Then

            Marker_2_Comport_Error_Count += 1
            Markers_Form.Marker_2_CommLog_TextBox.AppendText("Com error" & Marker_2_Comport_Error_Count & vbCrLf)

            Incoming = Marker_2_ComPort.ReadExisting()
            If Incoming <> "" Then
                Markers_Form.Marker_2_CommLog_TextBox.AppendText("Read: " & Incoming & vbCrLf)
                Incoming = ""
            End If

        End If
        'flush old commm data
        'Marker_2_ComPort.DiscardInBuffer()
        'Marker_2_ComPort.DiscardOutBuffer()

        Try
            'marker_2_ComPort.WriteLine(data)
            Marker_2_ComPort.DiscardInBuffer() ''TYLER
            Marker_2_ComPort.Write(data)
            msg = "Send: " & data.Replace(Chr(27), "")
        Catch ex As Exception
            msg = "Send Exception: " & "-1"
            Return "-1"
        End Try

        Markers_Form.Marker_2_CommLog_TextBox.AppendText(msg & vbCrLf)

        'wait for response?
        If expectedresponse Is "" Then
            'no
            Return "Sent"
        Else
            'yes... wait for the response
            Dim x As Integer = 0
            Try
                Do
                    ' give the port time to read
                    System.Windows.Forms.Application.DoEvents()
                    Threading.Thread.Sleep(100)

                    ' incoming byte count
                    IncomingBytesToRead = Marker_2_ComPort.BytesToRead()

                    ' incoming data
                    Incoming = Marker_2_ComPort.ReadExisting()

                    ' add to all received thus far
                    returnStr = returnStr & Incoming

                    ' if got return string, exit
                    If (returnStr = expectedresponse Or returnStr = expectedresponse & vbCr) Then
                        Exit Do
                    End If

                    ' if we received something earlier, and now we get nothing, we must have gotten all there was
                    If Incoming = "" And returnStr <> "" And ((x > 7 And Not force) Or x > 100) Then
                        Exit Do
                    End If

                    ' if, after several tries, we still don't have anything, ... punt
                    If returnStr = Nothing And (x > 10) Then
                        returnStr = "-1"
                        Exit Do
                    End If
                    x += 1

                    msg = returnStr
                Loop
                'returnStr = returnStr.Replace(vbCr, "").Replace(vbCrLf, "").Replace(vbLf, "")

            Catch ex As Exception
                msg = "Com port exception"
                returnStr = "-1"
            End Try
        End If

        Markers_Form.Marker_2_CommLog_TextBox.AppendText(msg & vbCrLf)
        Marker_2_ComPort.DiscardInBuffer() ''TYLER
        Return returnStr
    End Function

    ' =====================================================
    ' Marker Initialize
    ' =====================================================
    Dim cmdInit As String = Esc & "*" & cr
    Public Function Marker_1_Initialize()
        Try
            'Initialize Marker
            Return Marker_1_SendData(cmdInit, ".")
        Catch ex As Exception
            Return "-1"
        End Try

        ' reset Control sequence
        M_Seq(1).CurrentState = "Init"
    End Function

    Public Function Marker_2_Initialize()
        Try
            'Initialize Marker
            Return Marker_2_SendData(cmdInit, ".")

            ' reset Control sequence
            M_Seq(2).CurrentState = "Init"
        Catch
            Return "-1"
        End Try
    End Function

    ' =====================================================
    ' Marker Status
    ' =====================================================
    Dim StatusQuery = Esc & "ST" & cr
    Public Function Marker_1_ReadStatus()
        Marker_1_status_OK = False
        Try
            Marker_1_Status = Marker_1_SendData(StatusQuery, "11")

            ' 1st Character
            Marker_1_Status_1 = (Mid(Marker_1_Status, 1, 1))
            ' 2nd Character
            Marker_1_Status_2 = (Mid(Marker_1_Status, 2, 1))
        Catch
            Return "-1"
        End Try

        ' Status Response
        ' 1st character : Status
        If Marker_1_Status_1 = "1" Then
            'Status = 1 : Waiting for Command
            Marker_1_Status_Text_1 = "Waiting"
            Marker_1_status_OK = True
            Markers_Form.Marker_1_Arm_Button.BackColor = SystemColors.Control

        ElseIf Marker_1_Status_1 = "2" Then
            'Status = 2 : Ready To mark, waiting the "start marking" signal
            Marker_1_Status_Text_1 = "Ready"
            Marker_1_status_OK = True
            Markers_Form.Marker_1_Arm_Button.BackColor = Color.Green

        ElseIf Marker_1_Status_1 = "3" Then
            'Status = 3 : Marking under way
            Marker_1_Status_Text_1 = "Marking"
        Else
            Marker_1_Status_Text_1 = "-1"
            Markers_Form.Marker_1_Arm_Button.BackColor = Color.Yellow
        End If

        '2nd character : Stylus position
        '0 : Not at origin
        '1 : At origin On X & Y axis (0, 0)

        If Marker_1_Status_2 = "0" Then
            Marker_1_Status_Text_2 = "Not at origin"
        ElseIf Marker_1_Status_2 = "1" Then
            Marker_1_Status_Text_2 = "At origin"
        Else
            Marker_1_Status_Text_2 = "-1"
        End If

        Markers_Form.Marker_1_Status_TextBox.Text = Marker_1_Status

        Return Marker_1_Status
    End Function

    ' =====================================================
    ' Marker Status
    ' =====================================================
    Public Function Marker_2_ReadStatus()
        Marker_2_status_OK = False
        Try
            Marker_2_Status = Marker_2_SendData(StatusQuery, "11")

            ' 1st Character
            Marker_2_Status_1 = (Mid(Marker_2_Status, 1, 1))
            ' 2nd Character
            Marker_2_Status_2 = (Mid(Marker_2_Status, 2, 1))
        Catch
            Return "-1"
        End Try

        ' Status Response
        ' 1st character : Status
        If Marker_2_Status_1 = "1" Then
            'Status = 1 : Waiting for Command
            Marker_2_Status_Text_1 = "Waiting"
            Marker_2_status_OK = True

        ElseIf Marker_2_Status_1 = "2" Then
            'Status = 2 : Ready To mark, waiting the "start marking" signal
            Marker_2_Status_Text_1 = "Ready"
            Marker_2_status_OK = True
        ElseIf Marker_2_Status_1 = "3" Then
            'Status = 3 : Marking under way
            Marker_2_Status_Text_1 = "Marking"
        Else
            Marker_2_Status_Text_1 = "-1"
        End If

        '2nd character : Stylus position
        '0 : Not at origin
        '1 : At origin On X & Y axis (0, 0)

        If Marker_2_Status_2 = "0" Then
            Marker_2_Status_Text_2 = "Not at origin"
        ElseIf Marker_2_Status_2 = "1" Then
            Marker_2_Status_Text_2 = "At origin"
        Else
            Marker_2_Status_Text_2 = "-1"
        End If

        Markers_Form.Marker_2_Status_TextBox.Text = Marker_2_Status

        Dim PrintDone As Boolean = False
        Dim x As Integer = -1
        Try
            x = Marker_2_Status.IndexOf("Y")
            PrintDone = (x > 0)
        Catch
            PrintDone = False
        End Try

        Return Marker_2_Status
    End Function

    '=====================================================
    'Marker Cancel
    'AM response = "Z"
    '=====================================================
    Dim cmdCancel = Esc & "AM" & cr
    Public Function Marker_1_Cancel()
        Try
            Dim x = Marker_1_SendData(cmdCancel, "Z")
            x = x.Replace(vbCr, "")

            If (x.IndexOf("Z") >= 0) Then
                'Markers_Form.Marker_1_Cancel_Button.BackColor = Color.Green
                Return "Z"
            Else
                'Markers_Form.Marker_1_Cancel_Button.BackColor = SystemColors.Control
                Return "-1"
            End If
        Catch
            Return "-1"
        End Try
    End Function

    Public Function Marker_2_Cancel()
        Try
            Dim x = Marker_2_SendData(cmdCancel, "Z")
            x = x.Replace(vbCr, "")

            If (x.IndexOf("Z") >= 0) Then
                'Markers_Form.Marker_2_Cancel_Button.BackColor = Color.Green
                Return "Z"
            Else
                'Markers_Form.Marker_2_Cancel_Button.BackColor = SystemColors.Control
                Return "-1"
            End If
        Catch
            Return "-1"
        End Try
    End Function

    ' =====================================================
    ' Marker Mark Once
    ' =====================================================
    'Waiting for start cycle to begin, response = X<CR>
    'Cannot find program number Or program cannot be read, response = L<CR>
    ' =====================================================
    Dim cmdArmMarker = Esc & Chr(5) & " " & "1" & cr
    Public Function Marker_1_Arm()
        Try
            Dim x = Marker_1_SendData(cmdArmMarker, ".")
            x = x.Replace(Chr(5), "<ctlG>")
            Return x
        Catch
            Return "-1"
        End Try
    End Function

    Public Function Marker_2_Arm()
        Try
            Dim x = Marker_2_SendData(cmdArmMarker, ".")
            x = x.Replace(Chr(5), "<ctlG>")
            Return x
        Catch
            Return "-1"
        End Try
    End Function


    '=====================================================
    'Marker Start marking
    'Marker status changes from 1x to 2x when successful
    '=====================================================
    Dim cmdStartMarking = Esc & Chr(7) & cr

    Public Function Marker_1_Start_Marking()
        Try
            Return Marker_1_SendData(cmdStartMarking, ".")
        Catch
            Return "-1"
        End Try
    End Function

    Public Function Marker_2_Start_Marking()
        Try
            Return Marker_2_SendData(cmdStartMarking, ".")
        Catch
            Return "-1"
        End Try
    End Function

    ' =====================================================
    ' Marker Mark Now
    ' =====================================================
    'Public Function Marker_1_MarkNow()
    '    Try
    '        Dim cmdMarkNow = Esc & Chr(7) & cr
    '        Return Marker_1_SendData(cmdMarkNow, ".")
    '    Catch
    '        Return "-1"
    '    End Try
    'End Function

    'Public Function Marker_2_MarkNow()
    '    Try
    '        Dim cmdMarkNow = Esc & Chr(7) & " " & cr
    '        Return Marker_2_SendData(cmdMarkNow, ".")
    '    Catch
    '        Return "-1"
    '    End Try
    'End Function

    ' =====================================================
    ' Marker Exit Error
    ' =====================================================
    Dim cmdReset = Esc & "AD" & cr
    Public Function Marker_1_Exit_Error()
        Try
            Return Marker_1_SendData(cmdReset, ".")
        Catch
            Return "-1"
        End Try
    End Function

    Public Function Marker_2_Exit_Error()
        Try
            Return Marker_2_SendData(cmdReset, ".")
        Catch
            Return "-1"
        End Try
    End Function

    ' =====================================================
    ' Marker Read Program
    ' =====================================================
    Dim cmdReadProgram As String = Esc & "IM 001" & cr
    Public Function Marker_1_Read_Program()
        Try
            Marker_1_ProgramUpload = Marker_1_SendData(cmdReadProgram, ".")
            Return Marker_1_ProgramUpload

            'If Marker_1_ProgramUpload <> "-1" Then
            '    My.Settings.Marker_1_ProgramUpload = Marker_1_ProgramUpload
            'End If
        Catch
            Return "-1"
        End Try
    End Function

    Public Function Marker_2_Read_Program()
        Try
            Marker_2_ProgramUpload = Marker_2_SendData(cmdReadProgram, ".")
            Return Marker_2_ProgramUpload

            'If Marker_2_ProgramUpload <> "-1" Then
            '    My.Settings.Marker_2_ProgramUpload = Marker_2_ProgramUpload
            'End If
        Catch
            Return "-1"
        End Try
    End Function

    ' =====================================================
    ' Marker Read a Variable
    ' =====================================================
    Public Function Marker_1_Read_Variable(ByVal var)
        Try
            Dim VarQuery As String = Esc & "V? " & var & cr
            Return Marker_1_SendData(VarQuery, ".")
        Catch
            Return "-1"
        End Try
    End Function

    Public Function Marker_2_Read_Variable(ByVal var)
        Try
            Dim VarQuery As String = Esc & "V? " & var & cr
            Return Marker_2_SendData(VarQuery, ".")
        Catch
            Return "-1"
        End Try
    End Function

    '' =====================================================
    '' Marker Arm
    '' =====================================================
    'Public Function Marker_1_Arm(reps As String, programnumber As String)
    '    Dim ProgLoad As String = Esc & "NB " & reps & " " & programnumber & cr
    '    Return Marker_1_SendData(ProgLoad, ".")

    '    Markers_Form.Update()
    '    MainMenu.Update()
    '    System.Windows.Forms.Application.DoEvents()
    '    Threading.Thread.Sleep(100)

    '    Return True
    'End Function

    'Public Function Marker_2_Arm(reps As String, programnumber As String)
    '    Dim ProgLoad As String = Esc & "NB " & reps & " " & programnumber & cr
    '    Return Marker_2_SendData(ProgLoad, ".")

    '    Markers_Form.Update()
    '    MainMenu.Update()
    '    System.Windows.Forms.Application.DoEvents()
    '    Threading.Thread.Sleep(100)

    '    Return True
    'End Function

    ' =====================================================
    ' Marker Verify Program
    ' =====================================================
    Public Function Marker_1_VerifyProgram()
        'return true if upload matches the stored value 
        Dim response As Boolean = False
        Dim upload As String = ""

        'Check for valid program
        'upload the program
        upload = Marker_1_Read_Program()

        'compare to program saved earlier
        upload = upload.Replace("{Text = ", "").Replace(vbCr, ", ")
        Dim y = My.Settings.Marker_1_ProgramUpload.Replace(vbCr, ", ")
        response = (upload = y)

        If response Then
            Markers_Form.Marker_1_VerifyProgram_Button.BackColor = Color.Green
            Markers_Form.Marker_1_VerifyProgram_Button.Text = "Marker 1 Program Verified"
        Else
            Markers_Form.Marker_1_VerifyProgram_Button.BackColor = SystemColors.Control
            Markers_Form.Marker_1_VerifyProgram_Button.Text = "Marker 1 Program Not Verified"
        End If

        Return response
    End Function

    Public Function Marker_2_VerifyProgram()
        'return true if upload matches the stored value 
        Dim response As Boolean = False
        Dim upload As String = ""

        'Check for valid program
        'upload the program
        upload = Marker_2_Read_Program()

        'compare to program saved earlier
        upload = upload.Replace("{Text = ", "").Replace(vbCr, ", ")
        Dim y = My.Settings.Marker_2_ProgramUpload.Replace(vbCr, ", ")
        response = (upload = y)

        If response Then
            Markers_Form.Marker_2_VerifyProgram_Button.BackColor = Color.Green
            Markers_Form.Marker_2_VerifyProgram_Button.Text = "Marker 2 Program Verified"
        Else
            Markers_Form.Marker_2_VerifyProgram_Button.BackColor = SystemColors.Control
            Markers_Form.Marker_2_VerifyProgram_Button.Text = "Marker 2 Program Not Verified"
        End If

        Markers_Form.Update()
        MainMenu.Update()
        System.Windows.Forms.Application.DoEvents()
        Threading.Thread.Sleep(5)

        Return response
    End Function

    ' =====================================================
    ' Marker Write a Variable
    ' =====================================================
    Public Function Marker_1_Write_Variable(var As String, value As String)
        Try
            Dim VarWrite As String = Esc & "VR " & var & " " & value & cr
            Return Marker_1_SendData(VarWrite, ".")
        Catch
            Return "-1"
        End Try

        Return Marker_1_VerifyVariable()
    End Function

    Public Function Marker_2_Write_Variable(var As String, value As String)
        Try
            Dim VarWrite As String = Esc & "VR " & var & " " & value & cr
            Return Marker_2_SendData(VarWrite, ".")
        Catch
            Return "-1"
        End Try

        Return Marker_2_VerifyVariable()
    End Function

    ' =====================================================
    ' Marker Verify Variable
    ' =====================================================
    Public Function Marker_1_VerifyVariable()
        'return true if var number 0 has value Key_Code
        Dim upload As String = ""
        Dim response As Boolean = False

        Dim index As Integer
        Dim varnum As String = ""
        Dim varvalue As String = ""

        Marker_1_VarNumber = My.Settings.Marker_1_VarNum

        If Marker_1_VarNumber Is Nothing Or
                Marker_1_VarNumber = "" Then
            Marker_1_VarNumber = "0"
        End If
        GlobalVariables.Key_Code = My.Settings.Key_Code

        ' Read Variable from Marker
        upload = Marker_1_Read_Variable(Marker_1_VarNumber)
        upload = upload.Replace(vbCr, "").Replace(vbCrLf, "").Replace(vbLf, "")
        'response = (upload = Marker_1_VarNumber & " " & Key_Code)

        'parse variable number and variable value
        index = upload.IndexOf(" ")

        ' Get variable number and variable value from string response
        If index > 0 Then
            varnum = Mid(upload, 1, index)
            varvalue = Mid(upload, index + 1, upload.Length - index + 1)
            response = True
        Else
            response = False
        End If
        Return response
    End Function

    Public Function Marker_2_VerifyVariable()
        'return true if var number 0 has value Key_Code
        Dim upload As String = ""
        Dim response As Boolean = False

        Dim index As Integer
        Dim varnum As String = ""
        Dim varvalue As String = ""

        Marker_2_VarNumber = My.Settings.Marker_2_VarNum
        GlobalVariables.Key_Code = My.Settings.Key_Code

        ' Read Variable from Marker
        upload = Marker_2_Read_Variable(Marker_2_VarNumber)
        upload = upload.Replace(vbCr, "").Replace(vbCrLf, "").Replace(vbLf, "")
        'response = (upload = Marker_2_VarNumber & " " & Key_Code)

        'parse variable number and variable value
        index = upload.IndexOf(" ")

        ' Get variable number and variable value from string response
        If index > 0 Then
            varnum = Mid(upload, 1, index)
            varvalue = Mid(upload, index + 1, upload.Length - index + 1)
            response = True
        Else
            response = False
        End If
        Return response
    End Function
End Module

'' =====================================================
'' Marker Send Break
'' =====================================================
'Public Function Marker_1_Send_Break()
'    'serial break Is sent by breaking the TX line.
'    'When a serial port Is idle And no data Is being sent the TX line Is in a logical 1 state. 
'    'While Data Is being send the TX line rapidly transitions between logical 0 And logical 1. 
'    'Each frame of data takes a certain period of time to send, depending on the bit rate of the connection. This Is "frame time" Or "word time".
'    'a break occurs when the TX line Is held to a logical 0 for longer than one frame time.
'    'There are Short breaks And Long breaks. In general a Short break Is one that lasts longer than one frame time, but less than two frame times. 
'    'A long break can last two Or more frame times. Most serial devices that support breaks use a short break.

'    Dim breakduration As Integer = 1000
'    Dim breaktime As Integer = 200
'    Dim count As Integer = 3
'    'Dim response

'    Try
'        For count = 1 To 3
'            Marker_1_ComPort.BreakState = True

'            Threading.Thread.Sleep(breaktime)
'            Marker_1_ComPort.BreakState = False
'            Threading.Thread.Sleep(breakduration)
'        Next
'        Return True
'    Catch ex As Exception
'        Dim msg = "Cannot break Marker 1 Com port: "
'        MessageBox.Show(String.Format(msg & vbCrLf & "{0}", ex.Message))
'        Return False
'    End Try
'    Marker_1_ComPort.BreakState = False

'End Function

'Public Function Marker_2_Send_Break()

'    Dim breaktime As Integer = 1000 / (2400 / 9)
'    Dim count As Integer

'    Try
'        For count = 1 To 3
'            Marker_2_ComPort.BreakState = True
'            Threading.Thread.Sleep(breaktime)
'            Marker_2_ComPort.BreakState = False
'            Threading.Thread.Sleep(breaktime)
'        Next
'        Return True
'    Catch ex As Exception
'        Dim msg = "Cannot break Marker 2 Com port: "
'        MessageBox.Show(String.Format(msg & vbCrLf & "{0}", ex.Message))
'        Return False
'    End Try
'    Marker_2_ComPort.BreakState = False

'    Threading.Thread.Sleep(5000)
'End Function

'' ==============================================================================
''  Receive Data Responses
''  H<cr>         Syntax error
''  H123<cr>     Syntax error, for PB command, 123 = line number
''  L123<cr>     Syntax error, for PE command, 123 = line number
''  dT<cr>       Power ON
''  OK<cr> RS232 parameters modified

'Public Sub Marker_1_DataReceivedHandler(sender, SerialDataReceivedEventArgs)
'    ' Get string from serial port Read buffer
'    ' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-receive-strings-from-serial-ports

'    Dim returnStr As String = ""
'    Dim Incoming As String
'    Dim msg As String
'    ' incoming message counter

'    Try
'        Do
'            Incoming = Marker_1_ComPort.ReadLine()
'            'MarkerData = Marker_1_ComPort.ReadExisting()

'            If Incoming Is Nothing Then
'                Exit Do
'            Else
'                returnStr &= Incoming
'            End If
'        Loop
'        msg = "Received: " & returnStr
'    Catch ex As TimeoutException
'        ' MessageBox.Show(String.Format("Cannot Open Marker 1 Com port: " & vbCrLf & "{0}", ex.Message))
'        msg = "Timeout"
'    End Try

'    Markers_Form.Marker_1_CommLog_TextBox.AppendText(msg & vbCrLf)

'End Sub

'Public Sub Marker_2_DataReceivedHandler(sender, SerialDataReceivedEventArgs)
'    ' Get string from serial port Read buffer
'    ' https://docs.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/computer-resources/how-to-receive-strings-from-serial-ports

'    Dim returnStr As String = ""
'    Dim Incoming As String
'    Dim msg As String
'    ' incoming message counter
'    Marker_2_Messages_Received = Marker_2_Messages_Received + 1

'    Try
'        Do
'            Incoming = Marker_2_ComPort.ReadLine()
'            'MarkerData = Marker_2_ComPort.ReadExisting()

'            If Incoming Is Nothing Then
'                Exit Do
'            Else
'                returnStr &= Incoming
'            End If
'        Loop
'        msg = "Received: " & returnStr
'    Catch ex As TimeoutException
'        ' MessageBox.Show(String.Format("Cannot Open Marker 1 Com port: " & vbCrLf & "{0}", ex.Message))
'        msg = "Timeout"
'    End Try

'    Markers_Form.Marker_2_CommLog_TextBox.AppendText(msg & vbCrLf)

'End Sub
