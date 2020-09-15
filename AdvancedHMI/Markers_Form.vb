Option Explicit On

Imports System          'Access Console.WriteLine()
Imports System.IO
Imports System.IO.Ports 'Access the SerialPort Object

Public Class Markers_Form
    Public WithEvents Timer1 As New Timer

    Public X As List(Of KeyValuePair(Of String, Object)) = New List(Of KeyValuePair(Of String, Object))
    Public Marker_StateList As New List(Of String) From {"Init",
                                                        "Send Cancel",
                                                        "Send Reset",
                                                        "Send ProgNum",
                                                        "Set Var",
                                                        "Set DataSent",
                                                        "Wait for PLC Ready",
                                                        "Wait for Print Command",
                                                        "Send Print Command",
                                                        "Wait for Marker Done",
                                                        "Set Print Done",
                                                        "End"}

    Private Sub Markers_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '=====================================================================
        'Marker update timer
        '=====================================================================
        Timer1.Interval = 1000
        Timer1.Start()

        '=====================================================================
        'Marker 1 Com port ComboBox settings
        '=====================================================================
        Marker_1_PortName_ComboBox.DataSource = SerialPort.GetPortNames()
        Marker_1_PortName_ComboBox.Text = My.Settings.Marker_1_PortName
        Marker_1_BaudRate_ComboBox.Text = My.Settings.Marker_1_BaudRate

        Dim Marker1_Length = New Integer() {7, 8}
        Marker_1_Length_ComboBox.DataSource = Marker1_Length
        Marker_1_Length_ComboBox.Text = My.Settings.Marker_1_Length

        Dim Marker1_StopBits = New Integer() {0, 1, 2}
        Marker_1_StopBits_ComboBox.DataSource = Marker1_StopBits
        Marker_1_StopBits_ComboBox.Text = My.Settings.Marker_1_StopBits

        Dim Marker1_BaudRate = New Integer() {110, 300, 600, 1200, 2400, 9600, 19200, 38400}
        Marker_1_BaudRate_ComboBox.DataSource = Marker1_BaudRate

        ' Parity
        ' https://docs.microsoft.com/en-us/dotnet/api/system.io.ports.parity?view=netframework-4.7.2
        'Even   2, Mark   3, None   0, Odd    1, Space  4
        Marker_1_Parity_ComboBox.DataSource = System.Enum.GetValues(GetType(Parity))
        Marker_1_Parity_ComboBox.Text = DirectCast([Enum].Parse(GetType(Parity), Marker_1_Parity_ComboBox.Text), Parity)
        My.Settings.Marker_1_Parity = DirectCast([Enum].Parse(GetType(Parity), Marker_1_Parity_ComboBox.Text), Parity)

        Marker_1_PortName_ComboBox.Text = My.Settings.Marker_1_PortName
        Marker_1_BaudRate_ComboBox.Text = My.Settings.Marker_1_BaudRate
        Marker_1_Parity_ComboBox.Text = My.Settings.Marker_1_Parity
        Marker_1_StopBits_ComboBox.Text = My.Settings.Marker_1_StopBits
        Marker_1_Length_ComboBox.Text = My.Settings.Marker_1_Length

        '=====================================================================
        'Marker 2 Com port ComboBox settings
        '=====================================================================
        Marker_2_PortName_ComboBox.DataSource = SerialPort.GetPortNames()
        Marker_2_PortName_ComboBox.Text = My.Settings.Marker_2_PortName

        Dim Marker2_BaudRate = New Integer() {110, 300, 600, 1200, 2400, 9600, 19200, 38400}
        Marker_2_BaudRate_ComboBox.DataSource = Marker2_BaudRate
        Marker_2_BaudRate_ComboBox.Text = My.Settings.Marker_2_BaudRate

        Dim Marker2_Length = New Integer() {7, 8}
        Marker_2_Length_ComboBox.DataSource = Marker2_Length
        Marker_2_Length_ComboBox.Text = My.Settings.Marker_2_Length

        Dim Marker2_StopBits = New Integer() {0, 1, 2}
        Marker_2_StopBits_ComboBox.DataSource = Marker2_StopBits
        Marker_2_StopBits_ComboBox.Text = My.Settings.Marker_2_StopBits

        Marker_2_Parity_ComboBox.DataSource = System.Enum.GetValues(GetType(Parity))
        Marker_2_PortName_ComboBox.Text = My.Settings.Marker_2_PortName
        Marker_2_BaudRate_ComboBox.Text = My.Settings.Marker_2_BaudRate
        Marker_2_Parity_ComboBox.Text = My.Settings.Marker_2_Parity
        Marker_2_StopBits_ComboBox.Text = My.Settings.Marker_2_StopBits
        Marker_2_Length_ComboBox.Text = My.Settings.Marker_2_Length

        'Marker_1_Manual_State_ComboBox.Items.AddRange(PLC_Recipe_Tags.ToArray)
        'Marker_2_Manual_State_ComboBox.Items.AddRange(PLC_Recipe_Tags.ToArray)

        Marker_1_State_TextBox.Text = M_Seq(1).CurrentState
        Marker_2_State_TextBox.Text = M_Seq(1).CurrentState


        Marker_Program_Update_Help_Label.Text = "If Marker Program is changed, you must save the updated program." & vbCrLf &
            vbTab & "Load the correct program to the Marker." & vbCrLf &
            vbTab & "<Read> the Program." & vbCrLf &
            vbTab & "<Save> the Program." & vbCrLf &
            vbTab & "<Verify> the Program to ensure the Saved Program matches the Marker Program." & vbCrLf &
            vbCrLf &
        vbTab & "This allows the Marker Program to verify upload against the newly saved program."

    End Sub


    '=====================================================================
    'Marker Com port Open
    '=====================================================================
    Public Sub Open_Marker_1_ComPort_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Open_ComPort_Button.Click
        Try
            Marker_1_OpenComPort()
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot find " & Marker_1_ComPort.PortName & vbCrLf & "{0}", ex.Message))
        End Try
    End Sub

    Public Sub Open_Marker_2_ComPort_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Open_ComPort_Button.Click
        Try
            Marker_2_OpenComPort()
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot find " & Marker_2_ComPort.PortName & vbCrLf & "{0}", ex.Message))
        End Try
    End Sub

    '=====================================================================
    'Marker Com port Close
    '=====================================================================
    Private Sub Close_Marker_1_ComPort_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Close_ComPort_Button.Click
        Marker_1_CloseComPort()
    End Sub

    Private Sub Close_Marker_2_ComPort_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Close_ComPort_Button.Click
        Marker_2_CloseComPort()
    End Sub

    '=====================================================================
    'Marker 1 Com port Settings
    '=====================================================================
    Private Sub Marker_1_PortName_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_1_PortName_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_1_PortName = Marker_1_PortName_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_1_BaudRate_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_1_BaudRate_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_1_BaudRate = Marker_1_BaudRate_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_1_Length_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_1_Length_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_1_Length = Marker_1_Length_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_1_StopBits_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_1_StopBits_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_1_StopBits = Marker_1_StopBits_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_1_Parity_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_1_Parity_ComboBox.SelectionChangeCommitted
        ' My.Settings.Marker_1_Parity = (Parity) Enum.Parse(TypeOf (Parity), Marker_1_Parity_ComboBox.Items[SelectedIndex])
        My.Settings.Marker_1_Parity = DirectCast([Enum].Parse(GetType(Parity), Marker_1_Parity_ComboBox.SelectedIndex), Parity)
        My.Settings.Save()
    End Sub

    '=====================================================================
    'Marker 2 Com port Settings
    '=====================================================================
    Private Sub Marker_2_PortName_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_2_PortName_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_2_PortName = Marker_2_PortName_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_2_BaudRate_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_2_BaudRate_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_2_BaudRate = Marker_2_BaudRate_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_2_Length_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_2_Length_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_2_Length = Marker_2_Length_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_2_StopBits_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_2_StopBits_ComboBox.SelectionChangeCommitted
        My.Settings.Marker_2_StopBits = Marker_2_StopBits_ComboBox.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Marker_2_Parity_ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Marker_2_Parity_ComboBox.SelectionChangeCommitted
        ' My.Settings.Marker_2_Parity = (Parity) Enum.Parse(TypeOf (Parity), Marker_2_Parity_ComboBox.Items[SelectedIndex])
        My.Settings.Marker_2_Parity = DirectCast([Enum].Parse(GetType(Parity), Marker_2_Parity_ComboBox.SelectedIndex), Parity)
        My.Settings.Save()
    End Sub

    '=====================================================================
    ' Marker Push button navigation
    '=====================================================================

    'Private Sub Marker_BreakTime_TextBox_Click(sender As Object, e As MaskInputRejectedEventArgs) Handles Marker_BreakTime_TextBox.Click
    '    My.Settings.SerialPort_BreakTime = Marker_BreakTime_TextBox.Text
    '    My.Settings.Save()
    'End Sub

    'Private Sub Marker_BreakCounts_TextBox_Click(sender As Object, e As MaskInputRejectedEventArgs) Handles Marker_BreakCounts_TextBox.Click
    '    My.Settings.SerialPort_BreakCounts = Marker_BreakCounts_TextBox.Text
    '    My.Settings.Save()
    'End Sub

    '=====================================================================
    ' Marker Status
    '=====================================================================
    Private Sub Read_Marker_1_Status_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Status_Button.Click
        Marker_1_ReadStatus()
        Marker_1_Status_TextBox.Text = Marker_1_Status
    End Sub

    Private Sub Read_Marker_2_Status_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Status_Button.Click
        Marker_2_ReadStatus()
        Marker_2_Status_TextBox.Text = Marker_2_Status
    End Sub

    '=====================================================================
    ' Marker Reset
    '=====================================================================
    Private Sub Marker_1_ExitError_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_ExitError_Button.Click
        Marker_1_Exit_Error()
    End Sub

    Private Sub Marker_2_ExitError_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_ExitError_Button.Click
        Marker_2_Exit_Error()
    End Sub

    '=====================================================================
    ' Marker Write Program
    '=====================================================================
    Private Sub Marker_1_Write_Program_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Write_Program_Button.Click
        Marker_1_Download_Program()
    End Sub

    Private Sub Marker_2_Write_Program_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Write_Program_Button.Click
        Marker_2_Download_Program()
    End Sub

    '=====================================================================
    ' Marker Read Program
    '=====================================================================
    Private Sub Marker_1_ReadProgram_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_ReadProgram_Button.Click
        Marker_1_Program_TextBox.Text = Marker_1_Read_Program()
    End Sub

    Private Sub Marker_2_ReadProgram_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_ReadProgram_Button.Click
        Marker_2_Program_TextBox.Text = Marker_2_Read_Program()
    End Sub

    '=====================================================
    ' Marker Verify Program
    '=====================================================
    Private Sub Marker_1_VerifyProgram_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_VerifyProgram_Button.Click
        Marker_1_VerifyProgram()
    End Sub

    Private Sub Marker_2_VerifyProgram_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_VerifyProgram_Button.Click
        Marker_2_VerifyProgram()
    End Sub

    '=====================================================================
    ' Marker Mark Once
    '=====================================================================
    Private Sub Marker_1_Arm_ButtonButton_Click(sender As Object, e As EventArgs) Handles Marker_1_Arm_Button.Click
        Marker_1_Arm()
    End Sub

    Private Sub Marker_2_Arm_Button_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Arm_Button.Click
        Marker_2_Arm()
    End Sub

    '=====================================================================
    ' Marker Mark Now
    '=====================================================================
    Private Sub Marker_1_Mark_Now_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Mark_Now_Button.Click
        Marker_1_Start_Marking()
    End Sub

    Private Sub Marker_2_Mark_Now_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Mark_Now_Button.Click
        Marker_2_Start_Marking()
    End Sub

    '=====================================================================
    ' Marker Write Variable
    '=====================================================================
    Private Sub Marker_1_Write_Var_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Write_Var_Button.Click
        Dim var = Marker_1_VarNum_TextBox.Text
        Dim value = Marker_1_VarValue_TextBox.Text
        Marker_1_Write_Variable(var, value)
    End Sub

    Private Sub Marker_2_Write_Var_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Write_Var_Button.Click
        Dim var = Marker_2_VarNum_TextBox.Text
        Dim value = Marker_2_VarValue_TextBox.Text
        Marker_2_Write_Variable(var, value)
    End Sub

    '=====================================================================
    ' Marker Read Variable
    '=====================================================================
    Private Sub Marker_1__Read_Var_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Read_Var_Button.Click
        Marker_1_VarValue_TextBox.Text = Marker_1_Read_Variable(Marker_1_VarNum_TextBox.Text)
    End Sub

    Private Sub Marker_2__Read_Var_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Read_Var_Button.Click
        Marker_2_VarValue_TextBox.Text = Marker_2_Read_Variable(Marker_2_VarNum_TextBox.Text)
    End Sub

    '=====================================================================
    ' Marker Save Uploaded Program
    '=====================================================================
    Private Sub Marker_1_Save_Prog_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Save_Prog_Button.Click
        My.Settings.Marker_1_ProgramUpload = Marker_1_ProgramUpload
        My.Settings.Save()
        Marker_1_Save_Prog_Button.Text = "Marker 1 Program Saved"
        Marker_1_Save_Prog_Button.BackColor = Color.Green
    End Sub

    Private Sub Marker_2_Save_Prog_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Save_Prog_Button.Click
        My.Settings.Marker_2_ProgramUpload = Marker_2_ProgramUpload
        My.Settings.Save()
        Marker_2_Save_Prog_Button.Text = "Marker 2 Program Saved"
        Marker_2_Save_Prog_Button.BackColor = Color.Green
    End Sub

    '=====================================================================
    ' Marker Init
    '=====================================================================
    Private Sub Marker_1_Init_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Init_Button.Click
        Marker_1_Initialize()
    End Sub

    Private Sub Marker_2_Init_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Init_Button.Click
        Marker_2_Initialize()
    End Sub

    '=====================================================================
    ' Marker Cancel`
    '=====================================================================
    Private Sub Marker_1_Cancel_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Cancel_Button.Click
        Marker_1_Cancel()
    End Sub

    Private Sub Marker_2_Cancel_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Cancel_Button.Click
        Marker_2_Cancel()
    End Sub



    '=====================================================================
    ' Marker Sequence
    '=====================================================================
    Private Sub Marker_1_Sequence_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Sequence_Button.Click
        MainMenu.Marker_1_Control()
    End Sub

    Private Sub Marker_2_Sequence_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Sequence_Button.Click
        MainMenu.Marker_2_Control()
    End Sub

    '=====================================================================
    ' Marker Cold Start
    '=====================================================================
    Private Sub Marker_1_Cold_Start_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Cold_Start_Button.Click
        Marker_1_Ready = Marker_1_ColdStart()
    End Sub

    Private Sub Marker_2_Cold_Start_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Cold_Start_Button.Click
        Marker_2_Ready = Marker_2_ColdStart()
    End Sub

    '=====================================================================
    ' Marker Reset
    '=====================================================================
    Public Sub Marker_1_Reset_Button_Click(sender As Object, e As EventArgs) Handles Marker_1_Reset_Button.Click
        M_Seq(1).Reset = True
        'Marker_1_Reset_Button.BackColor = Color.Yellow

        ' update sequence if sequence timer is not running
        If MainMenu.MainMenu_Timer_Enabled = False Then
            MainMenu.Marker_2_Control()
        End If
    End Sub
    Public Sub Marker_2_Reset_Button_Click(sender As Object, e As EventArgs) Handles Marker_2_Reset_Button.Click
        M_Seq(2).Reset = True
        'Marker_2_Reset_Button.BackColor = Color.Yellow

        ' update sequence if sequence timer is not running
        If MainMenu.MainMenu_Timer_Enabled = False Then
            MainMenu.Marker_2_Control()
        End If
    End Sub

    '=====================================================================
    ' Reset all controls to user default 
    ' not used, example of for .. each in a form
    '=====================================================================
    Private Sub ResetAllControlsBackColor(Control)
        Control.BackColor = SystemColors.Control
        Control.ForeColor = SystemColors.ControlText
        If (Control.HasChildren) Then
            'Recursively call this method for each child control.
            For Each childControl In Control.Controls
                ResetAllControlsBackColor(childControl)
            Next
        End If
    End Sub

End Class