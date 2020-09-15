'================================================================
' Main Menu
'================================================================
Option Explicit On
Imports System.Linq

Public Class MainMenu
    Public myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
    Public types As Type() = myAssembly.GetTypes()

    Public MainMenu_Timer_Enabled As Boolean = False
    Public MainMenu_Update_Counter As Integer

    Dim msg As String = ""
    Dim dialog_result As DialogResult
    Dim result
    Dim caption As String

    '***************************************************************************************
    '* Close all forms when exit button is clicked in order to close all communications
    '***************************************************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer = 0
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
        Me.Close()
    End Sub

    Private Sub ExitApp()
        Dim index As Integer = 0
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
        Me.Close()
    End Sub

    '================================================
    ' Main Menu Load
    '================================================
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '================================================
        'Ethernet settings
        '================================================
        EthernetIPforCLXCom1.IPAddress = My.Settings.PLC_IP_Address
        EthernetIPforCLXCom1.Timeout = My.Settings.PLC_IP_Timeout

        Try
            Me.Location = New Point(0, 0)
            'Me.Location = New Point(0, Me.Parent.Width)

            '================================================
            'Menu selection to open forms from ComboBox
            '================================================
            For Each myForms In types
                If myForms.BaseType.FullName = "System.Windows.Forms.Form" AndAlso
                    myForms.AssemblyQualifiedName <> Me.GetType.AssemblyQualifiedName Then
                    ComboBox1.Items.Add(myForms.Name)
                    ComboBox2.Items.Add(myForms)

                    Dim formname As String = "Form Text"

                    If myForms.Name = "RecipeDisplay_Form" Then
                        formname = RecipeDisplay_Form.Text
                    End If
                    If myForms.Name = "RecipeVerify_Form" Then
                        formname = RecipeVerify_Form.Text
                    End If
                    If myForms.Name = "Markers_Form" Then
                        formname = Markers_Form.Text
                    End If
                    If myForms.Name = "Keyfile_Select_Form" Then
                        formname = Keyfile_Select_Form.Text
                    End If
                    If myForms.Name = "Verify_Recipe_Form" Then
                        formname = Verify_Recipe_Form.Text
                    End If
                    If myForms.Name = "TumblerKit_Form" Then
                        formname = TumblerKit_Form.Text
                    End If
                    If myForms.Name = "BotTumbler_Form" Then
                        formname = BotTumbler_Form.Text
                    End If
                    If myForms.Name = "Charts_Form" Then
                        formname = Charts_Form.Text
                    End If
                    If myForms.Name = "Bushing_Form" Then
                        formname = Bushing_Form.Text
                    End If
                    If myForms.Name = "Barrel_Form" Then
                        formname = Barrel_Form.Text
                    End If
                    If myForms.Name = "DrillPin_Form" Then
                        formname = DrillPin_Form.Text
                    End If
                    If myForms.Name = "Sta2_Form" Then
                        formname = Sta2_Form.Text
                    End If
                    If myForms.Name = "Sta3_Form" Then
                        formname = Sta3_Form.Text
                    End If
                    If myForms.Name = "Sta9_Form" Then
                        formname = Sta9_Form.Text
                    End If
                    If myForms.Name = "Sta13_Form" Then
                        formname = Sta13_Form.Text
                    End If
                    If myForms.Name = "Sta14_Form" Then
                        formname = Sta14_Form.Text
                    End If
                    If myForms.Name = "Sta15_Form" Then
                        formname = Sta15_Form.Text
                    End If
                    If myForms.Name = "Sta16_Form" Then
                        formname = Sta16_Form.Text
                    End If
                    If myForms.Name = "TopSleeve_Form" Then
                        formname = TopSleeve_Form.Text
                    End If
                    If myForms.Name = "MidTumbler_Form" Then
                        formname = MidTumbler_Form.Text
                    End If
                    If myForms.Name = "TopTumbler_Form" Then
                        formname = TopTumbler_Form.Text
                    End If
                    If myForms.Name = "Springs_Form" Then
                        formname = Springs_Form.Text
                    End If
                    If myForms.Name = "KnurlPin_Form" Then
                        formname = KnurlPin_Form.Text
                    End If

                    ComboBox5.Items.Add(formname)

                    If myForms.Name = "RecipeDisplay_Form" Or
                            myForms.Name = "RecipeVerify_Form" Or
                            myForms.Name = "Markers_Form" Or
                            myForms.Name = "Keyfile_Select_Form" Or
                            myForms.Name = "Verify_Recipe_Form" Or
                            myForms.Name = "TumblerKit_Form" Or
                            myForms.Name = "BotTumbler_Form" Or
                            myForms.Name = "Charts_Form" Or
                            myForms.Name = "Bushing_Form" Or
                            myForms.Name = "Barrel_Form" Or
                            myForms.Name = "DrillPin_Form" Or
                            myForms.Name = "Sta2_Form" Or
                            myForms.Name = "Sta3_Form" Or
                            myForms.Name = "Sta9_Form" Or
                            myForms.Name = "Sta13_Form" Or
                            myForms.Name = "Sta14_Form" Or
                            myForms.Name = "Sta15_Form" Or
                            myForms.Name = "Sta16_Form" Or
                            myForms.Name = "TopSleeve_Form" Or
                            myForms.Name = "MidTumbler_Form" Or
                            myForms.Name = "TopTumbler_Form" Or
                            myForms.Name = "Springs_Form" Or
                            myForms.Name = "KnurlPin_Form" Then

                            ComboBox3.Items.Add(myForms.Name)
                            ComboBox4.Items.Add(myForms)
                        End If
                    End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        '***************************************************************************************
        'Open initial form designated by OpenOnStartup property of the button
        '***************************************************************************************
        'Dim index As Integer
        'While index < Me.Controls.Count
        '    If TypeOf Me.Controls(index) Is MainMenuButton Then
        '        If DirectCast(Me.Controls(index), MainMenuButton).OpenOnStartup Then
        '            DirectCast(Me.Controls(index), MainMenuButton).PerformClick()
        '            Exit While
        '        End If
        '    End If
        '    index += 1
        'End While

        'Start with Marker Sequence Timer OFF
        MainMenu_Timer_Enabled = False
        MainMenu_Timer_Button.Text = "Marker OFF"
        MainMenu_Timer_Button.BackColor = SystemColors.Control

        ' Start with User Access only
        Permission_Timer.Stop()
        FullAccess = True
        User_Access_Button.Text = "Full Access"

        'FullAccess = False
        'User_Access_Button.Text = "User Access"

        My.Settings.FullAccess = FullAccess
        User_Access_Button.BackColor = Color.Green
        User_Permission_TextBox.Visible = False

        RecipeOpenForm()

        ' Fix Me
        'Exit Sub

        '================================================
        'Make Markers ready to operate
        '================================================
        Marker_1_Ready = Marker_1_ColdStart()
        Wait_Message_Form.Close()

        Marker_2_Ready = Marker_2_ColdStart()
        Wait_Message_Form.Close()

        My.Settings.Machine_Idle = True

        '================================================
        ' PLC Comms enabled
        '================================================
        PLC_Comms_Enabled = My.Settings.PLC_Comms_Enabled
        If PLC_Comms_Enabled Then
            PLC_Comms_Enabled_Label.BackColor = Color.Green
        Else
            PLC_Comms_Enabled_Label.BackColor = Color.Gray
        End If
    End Sub

    '================================================
    'Open forms from ComboBox
    '================================================
    Private Sub Open_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Open_Button.Click
        Try
            Dim idx As Integer = ComboBox2.SelectedIndex
            Dim myform As Type = DirectCast(ComboBox2.SelectedItem, Type)
            Dim frm As Form = CType(System.Activator.CreateInstance(myform), Form)
            frm.StartPosition = FormStartPosition.Manual
            frm.Left = 200
            frm.Top = 0
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Unable to Open the form." & vbCrLf &
                            ex.Message)
        End Try
    End Sub

    '================================================
    'Close forms from ComboBox
    '================================================
    Private Sub Close_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Button.Click
        Try
            For Each frm In My.Application.OpenForms
                If frm.Name.ToString = ComboBox1.Text Then
                    frm.close()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Unable to Close the form." & vbCrLf &
                            ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.SelectedIndex = ComboBox1.SelectedIndex
    End Sub
    ' ===========================================================
    ' Open form from combo box selctiom
    ' ============================================================
    Private Sub OpenForm_Button_Click(sender As Object, e As EventArgs) Handles OpenForm_Button.Click
        Try
            Dim idx As Integer = ComboBox3.SelectedIndex
            Dim myform As Type = DirectCast(ComboBox4.SelectedItem, Type)
            Dim frm As Form = CType(System.Activator.CreateInstance(myform), Form)
            frm.StartPosition = FormStartPosition.Manual
            frm.Left = 200
            frm.Top = 0
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Unable to Open the form." & vbCrLf &
                            ex.Message)
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ComboBox4.SelectedIndex = ComboBox3.SelectedIndex
    End Sub

    Private Sub MainMenu_Timer_Button_Click(sender As Object, e As EventArgs) Handles MainMenu_Timer_Button.Click
        Toggle_Timer()
    End Sub
    Private Sub Toggle_Timer()
        '=====================================================
        'Enable Marker control sequence
        '=====================================================
        'If Marker_Update_Time < 50 Then
        '    Marker_Update_Time = 50
        'End If
        If MainMenu_Timer_Enabled = True Then
            MainMenu_Timer_Enabled = False

            MainMenu_Timer.Stop()
            MainMenu_Timer_Button.Text = "Marking OFF"
            MainMenu_Timer_Button.BackColor = SystemColors.Control

            System.Windows.Forms.Application.DoEvents()
            Me.Refresh()
        Else
            MainMenu_Timer_Enabled = True
            MainMenu_Timer.Stop()
            MainMenu_Timer.Interval = Marker_Update_Time
            MainMenu_Timer.Start()

            MainMenu_Timer_Button.Text = "Marking ON"
            MainMenu_Timer_Button.BackColor = Color.Green
        End If
    End Sub

    '=====================================================
    'Timer tick service
    '=====================================================
    Private Sub MainMenu_Timer_Tick(sender As Object, e As EventArgs) Handles MainMenu_Timer.Tick

        'stop timer so that tick events do not pile up during debug
        MainMenu_Timer.Stop()
        MainMenu_Timer_Button.BackColor = Color.Green

        '=====================================================
        'Counter Service
        '=====================================================
        MainMenu_Update_Counter += 1
        MainMenu_Update_Counter = MainMenu_Update_Counter Mod 1000
        MainMenu_Timer_Button.Text = "Marking ON"

        '=====================================================
        'Marker Sequence Control
        'If Marking Enabled, call MarkerControl 
        '================================================
        If PLC_15_Recipe_Mark_Top_of_Barrel Then
            If Marker_1_Ready Then
                'Marker_1_Button.Text = "Marker 1 ready"
                Marker_1_Button.BackColor = Color.Green
                Marker_1_Control()
            Else
                Marker_1_Button.Text = "Marker 1 not ready"
                Marker_1_Button.BackColor = Color.Yellow
                'Marker_1_Ready = Marker_1_ColdStart()
                Wait_Message_Form.Close()
            End If
        End If

        If PLC_19_Recipe_Mark_Side_of_Barrel Then
            If Marker_2_Ready Then
                'Marker_2_Button.Text = "Marker 2 ready"
                Marker_2_Button.BackColor = Color.Green
                Marker_2_Control()
            Else
                Marker_2_Button.Text = "Marker 2 not ready"
                Marker_2_Button.BackColor = Color.Yellow
                'Marker_2_Ready = Marker_2_ColdStart()
                Wait_Message_Form.Close()
            End If
        End If

        '=====================================================
        'Timer Service - restart
        '=====================================================
        If MainMenu_Timer_Enabled Then
            MainMenu_Timer.Interval = Marker_Update_Time
            MainMenu_Timer.Start()
        End If
    End Sub

    ' =============================================================
    ' Open Form
    ' =============================================================
    Private Sub Marker_Button_14_Click(sender As Object, e As EventArgs) Handles Marker_1_Button.Click
        Markers_Form.Show()
        Markers_Form.BringToFront()
    End Sub

    ' =============================================================
    ' Open Form
    ' =============================================================
    Private Sub Marker_Button_17_Click(sender As Object, e As EventArgs) Handles Marker_2_Button.Click
        Markers_Form.Show()
        Markers_Form.BringToFront()
    End Sub

    ' =============================================================
    ' Open Keyfile Form
    ' =============================================================
    Private Sub Open_KeyFile_Form_Button_Click(sender As Object, e As EventArgs) Handles KeyFile_Form_Button.Click
        KeyFileOpenForm()
    End Sub

    Private Sub KeyFileOpenForm()
        'If Application.OpenForms().OfType(Of RecipeDisplay_Form).Any Then
        RecipeDisplay_Form.BringToFront()
        'Else
        Keyfile_Select_Form.Text = "KeyFileSelect_Form"
        Keyfile_Select_Form.Show()
        Keyfile_Select_Form.StartPosition = FormStartPosition.Manual
        Keyfile_Select_Form.Location = New Point(200, 0)
        Keyfile_Select_Form.Show()
        Keyfile_Select_Form.BringToFront()
        'End If
    End Sub
    ' =============================================================
    ' Open Settings Form
    ' =============================================================
    Private Sub Setting_Menu_Button_Click(sender As Object, e As EventArgs)
        SettingsOpenForm()
    End Sub

    Private Sub SettingsOpenForm()
        'If Application.OpenForms().OfType(Of RecipeDisplay_Form).Any Then
        SettingsForm.BringToFront()
        'Else
        SettingsForm.Text = "SettingsForm"
        SettingsForm.Show()
        SettingsForm.StartPosition = FormStartPosition.Manual
        SettingsForm.Location = New Point(200, 0)
        SettingsForm.Show()
        SettingsForm.BringToFront()
        'End If
    End Sub
    ' =============================================================
    ' PLC Data Subscriber resonses
    ' =============================================================
    'https://www.advancedhmi.com/forum/index.php?topic=238.0
    'https://advancedhmi.com/documentation/index.php?title=Subscribing_to_PLC_data_via_code
    Public Sub Marker_DataSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles Marker_DataSubscriber.DataChanged
        If e.ErrorId = 0 Then
            If e.PlcAddress = "sta14_Start_Technifor_Print" Then
                PLC_Sta14_Print_Start = e.Values(0)
            ElseIf e.PlcAddress = "sta14_print_data_sent" Then
                PLC_Sta14_Print_Data_Sent = e.Values(0)
            ElseIf e.PlcAddress = "Sta14_Print_Done" Then
                PLC_Sta14_Print_Done = e.Values(0)
            ElseIf e.PlcAddress = "Sta14_Print_Error" Then
                PLC_Sta14_Print_Error = e.Values(0)
            ElseIf e.PlcAddress = "Sta17_Start_Technifor_Print" Then
                PLC_Sta17_Print_Start = e.Values(0)
            ElseIf e.PlcAddress = "Sta17_Print_Data_Sent" Then
                PLC_Sta17_Print_Data_Sent = e.Values(0)
            ElseIf e.PlcAddress = "Sta17_Print_Done" Then
                PLC_Sta17_Print_Done = e.Values(0)
            ElseIf e.PlcAddress = "Sta17_Print_Error" Then
                PLC_Sta17_Print_Error = e.Values(0)
            End If
            PLC_Comms_OK = True
        End If
    End Sub

    ' =============================================================
    ' PLC Data Subscriber responses
    ' =============================================================
    Public Sub Recipe_DataSubscriber_DataChanged(sender As Object, e As Drivers.Common.PlcComEventArgs) Handles Recipe_DataSubscriber.DataChanged
        If e.ErrorId = 0 Then
            If e.Values IsNot Nothing AndAlso e.Values.Count > 0 Then
                If e.PlcAddress = "A_00_Recipe_Manual_Load_Keys" Then
                    PLC_00_Recipe_Manual_Load_Keys = e.Values(0)
                ElseIf e.PlcAddress = "A_01_Recipe_Keyed_Alike" Then
                    PLC_01_Recipe_Keyed_Alike = e.Values(0)
                ElseIf e.PlcAddress = "A_02_Recipe_Auto_Unload_at_Sta17" Then
                    PLC_02_Recipe_Auto_Unload_at_Sta17 = e.Values(0)
                ElseIf e.PlcAddress = "A_03_Recipe_Load_Flex_Ace_at_Sta02" Then
                    PLC_03_Recipe_Load_Flex_Ace_at_Sta02 = e.Values(0)
                ElseIf e.PlcAddress = "A_04_Recipe_Enable_Sta03" Then
                    PLC_04_Recipe_Enable_Sta03 = e.Values(0)
                ElseIf e.PlcAddress = "A_05_Recipe_Enable_Sta04" Then
                    PLC_05_Recipe_Enable_Sta04 = e.Values(0)
                ElseIf e.PlcAddress = "A_06_Recipe_Enable_Sta05" Then
                    PLC_06_Recipe_Enable_Sta05 = e.Values(0)
                ElseIf e.PlcAddress = "A_07_Recipe_Enable_Sta06" Then
                    PLC_07_Recipe_Enable_Sta06 = e.Values(0)
                ElseIf e.PlcAddress = "A_08_Recipe_Enable_Sta07" Then
                    PLC_08_Recipe_Enable_Sta07 = e.Values(0)
                ElseIf e.PlcAddress = "A_09_Recipe_Enable_Sta08" Then
                    PLC_09_Recipe_Enable_Sta08 = e.Values(0)
                ElseIf e.PlcAddress = "A_10_Recipe_Enable_Sta09" Then
                    PLC_10_Recipe_Enable_Sta09 = e.Values(0)
                ElseIf e.PlcAddress = "A_11_Recipe_Enable_Sta10" Then
                    PLC_11_Recipe_Enable_Sta10 = e.Values(0)
                ElseIf e.PlcAddress = "A_12_Recipe_Enable_Sta11" Then
                    PLC_12_Recipe_Enable_Sta11 = e.Values(0)
                ElseIf e.PlcAddress = "A_13_Recipe_Enable_Sta12" Then
                    PLC_13_Recipe_Enable_Sta12 = e.Values(0)
                ElseIf e.PlcAddress = "A_14_Recipe_Enable_Sta13" Then
                    PLC_14_Recipe_Enable_Sta13 = e.Values(0)
                ElseIf e.PlcAddress = "A_15_Recipe_Mark_Top_of_Barrel" Then ''TYLER LOOK HERE
                    PLC_15_Recipe_Mark_Top_of_Barrel = e.Values(0)
                    'Marker_14_Button.Enabled = PLC_15_Recipe_Mark_Top_of_Barrel
                    'Sta14_Start_Print_BasicLabel.Visible = PLC_15_Recipe_Mark_Top_of_Barrel
                ElseIf e.PlcAddress = "A_16_Recipe_Enable_Sta15" Then
                    PLC_16_Recipe_Enable_Sta15 = e.Values(0)
                ElseIf e.PlcAddress = "A_17_Recipe_Leave_key_in_After_Test" Then
                    PLC_17_Recipe_Leave_key_in_After_Test = e.Values(0)
                ElseIf e.PlcAddress = "A_18_Recipe_Enable_Sta16" Then
                    PLC_18_Recipe_Enable_Sta16 = e.Values(0)
                ElseIf e.PlcAddress = "A_19_Recipe_Mark_Side_of_Barrel" Then
                    PLC_19_Recipe_Mark_Side_of_Barrel = e.Values(0)
                    'Marker_17_Button.Enabled = PLC_19_Recipe_Mark_Side_of_Barrel
                    'Sta17_Start_Print_BasicLabel.Visible = PLC_19_Recipe_Mark_Side_of_Barrel
                ElseIf e.PlcAddress = "A_20_Recipe_Use_Master_Key_Scenario" Then
                    PLC_20_Recipe_Use_Master_Key_Scenario = e.Values(0)
                ElseIf e.PlcAddress = "A_21_Recipe_KeyTest_Finish_Angle" Then
                    PLC_21_Recipe_KeyTest_Finish_Angle = e.Values(0)
                ElseIf e.PlcAddress = "A_22_Recipe_KeyTest_Start_Angle" Then
                    PLC_22_Recipe_KeyTest_Start_Angle = e.Values(0)
                ElseIf e.PlcAddress = "A_23_Recipe_KeyTest_Test_Angle" Then
                    PLC_23_Recipe_KeyTest_Test_Angle = e.Values(0)
                ElseIf e.PlcAddress = "A_24_Recipe_Batch_Quantity" Then
                    PLC_24_Recipe_Batch_Quantity = e.Values(0)
                ElseIf e.PlcAddress = "A_25_Recipe_Batch_Key_Que" Then
                    PLC_25_Recipe_Batch_Key_Que = e.Values(0)
                ElseIf e.PlcAddress = "Request_PC_Data" Then
                    PLC_Request_PC_Data = e.Values(0)
                ElseIf e.PlcAddress = "PC_Data_Sent" Then
                    PLC_PC_Data_Sent = (e.Values(0) = "1")
                ElseIf e.PlcAddress = "First_Recipe_Data" Then
                    PLC_First_Recipe_Data = e.Values(0)
                ElseIf e.PlcAddress = "Machine_Mode" Then
                    PLC_Machine_Mode = e.Values(0)
                ElseIf e.PlcAddress = "First_Recipe_Done" Then
                    PLC_First_Recipe_Done = e.Values(0)
                End If
                PLC_Comms_OK = True
            End If
        End If
    End Sub

    ' =====================================================
    ' Marker Control Sequence
    ' =====================================================
    Public Sub Marker_1_Control()
        'Marker_1_ReadStatus()
        EthernetComErrorCount = 0

        Dim MarkerNumber As Integer = 1
        Dim PLC_Mark_Enable As Boolean = PLC_15_Recipe_Mark_Top_of_Barrel

        '===================================================
        'Update User Interface
        '===================================================
        Dim Marker_text As String = ""
        If Marker_1_Ready Then

            Marker_1_Button.BackColor = Color.Green
        Else
            Marker_1_Button.Text = "Marker 1 is not ready"
            Marker_text = Marker_1_Button.Text
            Marker_1_Button.BackColor = Color.Yellow

            Return
        End If

        '===================================================
        'Update Time in State
        '===================================================
        If M_Seq(MarkerNumber).StateChanged Then
            M_Seq(MarkerNumber).start_time = Now
            M_Seq(MarkerNumber).LoopCount = 0
        Else
            M_Seq(MarkerNumber).stop_time = Now
            Try
                '.TotalSeconds
                M_Seq(MarkerNumber).TimeInState = M_Seq(MarkerNumber).stop_time.Subtract(M_Seq(MarkerNumber).start_time).TotalSeconds
            Catch
                M_Seq(MarkerNumber).start_time = Now
                '.TotalSeconds
                M_Seq(MarkerNumber).TimeInState = (Now - M_Seq(MarkerNumber).start_time).TotalSeconds
            End Try
            M_Seq(MarkerNumber).LoopCount += 1 Mod 10000000
        End If

        '===================================================
        ' Reset
        '===================================================
        If M_Seq(MarkerNumber).Reset Then
            M_Seq(MarkerNumber).CurrentState = "Init"
            M_Seq(MarkerNumber).NextState = "Init"
            M_Seq(MarkerNumber).PrintFinished = False

            Marker_1_Cancel()
            System.Threading.Thread.Sleep(100)
            System.Windows.Forms.Application.DoEvents()
            Me.Refresh()

            M_Seq(MarkerNumber).Reset = False
        End If

        ' ===================================================
        ' Wait for PLC Mark Enable
        ' ===================================================
        If PLC_Mark_Enable = False Or
            M_Seq(MarkerNumber).CurrentState = "" Or
            M_Seq(MarkerNumber).CurrentState Is Nothing Then

            M_Seq(MarkerNumber).NextState = "Init"
            M_Seq(MarkerNumber).CurrentState = "Init"
        End If

        '===================================================
        'Step - Init 
        'Initialize
        '===================================================
        If M_Seq(MarkerNumber).CurrentState = "Init" Then

            M_Seq(MarkerNumber).PrintFinished = False
            ' Reset PLC signals
            Try
                'If PLC_Sta14_Print_Error Then
                EthernetIPforCLXCom1.Write("Sta14_Print_Error", 0)
                'End If
                'If PLC_Sta14_Print_Done Then
                EthernetIPforCLXCom1.Write("Sta14_Print_Done", 0)
                'End If
                'If PLC_Sta14_Print_Data_Sent Then
                EthernetIPforCLXCom1.Write("sta14_print_data_sent", 0)
                'End If

                EthernetIPforCLXCom1.Write("Sta14_send_data_fault", 0)

                Marker_1_Button.BackColor = SystemColors.Control
                PLC_Comms_OK = True
            Catch
                EthernetComErrorCount += EthernetComErrorCount
                Markers_Form.Marker_1_Seq_Log_TextBox.AppendText(vbCrLf & "PLC Comm Error ")
                Marker_1_Button.BackColor = Color.Yellow
                Marker_1_Button.Text = "PLC Comm Error"
                PLC_Comms_OK = False
                Return
            End Try

            Marker_1_ReadStatus()

            'Change state
            If PLC_Mark_Enable And
                Marker_1_Status_1 = "1" And
                PLC_Sta14_Print_Data_Sent = False And
                PLC_Sta14_Print_Done = False And
                PLC_Sta14_Print_Data_Sent = False And
                PLC_Sta14_Print_Start = False Then

                M_Seq(MarkerNumber).NextState = "Wait for Print"
                M_Seq(MarkerNumber).CurrentState = "Wait for Print"

                EthernetIPforCLXCom1.Write("sta14_print_data_sent", 1)
            End If
        End If

        '===================================================
        ' Step
        ' Send Print Data
        ' Set Print Data Sent
        ' Wait for PLC Print Command
        '===================================================
        Dim x As Integer = -1
        Dim cmdArmMarker = Chr(27) & Chr(5) & " " & "1" & Chr(13) & Chr(27) & Chr(7) & Chr(13)
        Dim y As String = ""

        If M_Seq(MarkerNumber).CurrentState = "Wait for Print" Then
            Wait_Message_Form.Close()

            EthernetIPforCLXCom1.Write("sta14_print_data_sent", 1)

            ' wait for PLC to repeat back Print command
            If PLC_Sta14_Print_Start Then
                ' Arm Marker
                ' Wait for Marker armed (response = X)
                y = Marker_1_SendData(cmdArmMarker, "X")
                x = y.IndexOf("X")
                M_Seq(MarkerNumber).PrintFinished = y.IndexOf("Y") > -1
            End If

            If x >= 0 Then
                M_Seq(MarkerNumber).NextState = "Printing"
            End If

        End If

        ' ===================================================
        ' Step
        ' Reset Print Data Sent
        ' Wait for Printing Done from Marker
        ' Then Send Print Done to PLC
        ' ===================================================
        If M_Seq(MarkerNumber).CurrentState = "Printing" Then

            EthernetIPforCLXCom1.Write("sta14_Print_Data_Sent", 0)

            'Change state
            ' wait for Marking done (Marker sends Y)
            M_Seq(MarkerNumber).PrintFinished = M_Seq(MarkerNumber).PrintFinished Or Marker_1_ComPort.ReadExisting().IndexOf("Y") > -1

            If M_Seq(MarkerNumber).PrintFinished Then
                Try
                    ' Set StaXX_Print_Done
                    EthernetIPforCLXCom1.Write("sta14_Print_Done", 1)
                    'Marker_1_Button.BackColor = Color.Green
                    PLC_Comms_OK = True
                Catch
                    EthernetComErrorCount += EthernetComErrorCount
                    Markers_Form.Marker_1_Seq_Log_TextBox.AppendText(vbCrLf & "PLC Comm Error")

                    Marker_1_Button.BackColor = Color.Yellow
                    Marker_1_Button.Text = "PLC Comm Error"
                    PLC_Comms_OK = False
                End Try

                M_Seq(MarkerNumber).NextState = "End"
                M_Seq(MarkerNumber).CurrentState = "End"
            End If

        End If

        ' ===================================================
        ' Step End        
        ' ===================================================
        If M_Seq(MarkerNumber).CurrentState = "End" Then
            ' No Action

            'Change state
            If PLC_Mark_Enable Then
                M_Seq(MarkerNumber).NextState = "Wait for Print"
                M_Seq(MarkerNumber).CurrentState = "Wait for Print"

                EthernetIPforCLXCom1.Write("Sta14_Print_Error", 0)
                EthernetIPforCLXCom1.Write("Sta14_Print_Done", 0)
                EthernetIPforCLXCom1.Write("sta14_print_data_sent", 0)
                EthernetIPforCLXCom1.Write("Sta14_send_data_fault", 0)

                PLC_Sta14_Print_Start = 0
            Else
                M_Seq(MarkerNumber).NextState = "Init"
                M_Seq(MarkerNumber).CurrentState = "Init"
            End If

        End If

        Markers_Form.Marker_1_Seq_Log_TextBox.AppendText(vbCrLf & M_Seq(MarkerNumber).CurrentState)
        Marker_1_Button.Text = M_Seq(MarkerNumber).CurrentState
        Markers_Form.Marker_1_State_TextBox.Text = Marker_1_Button.Text

        'Update State Conditions ===================================================
        M_Seq(MarkerNumber).StateChanged = (M_Seq(MarkerNumber).CurrentState <> M_Seq(MarkerNumber).NextState)
        M_Seq(MarkerNumber).CurrentState = M_Seq(MarkerNumber).NextState

        If M_Seq(MarkerNumber).StateChanged Then
            Markers_Form.Marker_1_Seq_Log_TextBox.AppendText(vbCrLf & "State change: " & M_Seq(MarkerNumber).CurrentState)
        End If
        'update status on screen ===================================================
        'If M_Seq(MarkerNumber).LoopCount <= 2 Then
        Markers_Form.Marker_1_State_TextBox.Text = M_Seq(MarkerNumber).CurrentState
        'End If

        'Report Ethernet comm status ===================================================
        If EthernetComErrorCount > 0 Then
            Markers_Form.Marker_1_Seq_Log_TextBox.AppendText(vbCrLf & "PLC Comm errors :" & EthernetComErrorCount & vbCrLf)
        End If

        ' Thus Ends Marker 1 Control Sequence =====================

    End Sub

    ' =====================================================
    ' Marker 2 Control Sequence
    ' =====================================================
    Public Sub Marker_2_Control()
        'Marker_2_ReadStatus()
        EthernetComErrorCount = 0

        Dim MarkerNumber As Integer = 1
        Dim PLC_Mark_Enable As Boolean = PLC_19_Recipe_Mark_Side_of_Barrel

        '===================================================
        'Update User Interface
        '===================================================
        Dim Marker_text As String = ""
        If Marker_2_Ready Then

            Marker_2_Button.BackColor = Color.Green
        Else
            Marker_2_Button.Text = "Marker 2 is not ready"
            Marker_text = Marker_2_Button.Text
            Marker_2_Button.BackColor = Color.Yellow

            Return
        End If

        '===================================================
        'Update Time in State
        '===================================================
        If M_Seq(MarkerNumber).StateChanged Then
            M_Seq(MarkerNumber).start_time = Now
            M_Seq(MarkerNumber).LoopCount = 0
        Else
            M_Seq(MarkerNumber).stop_time = Now
            Try
                '.TotalSeconds
                M_Seq(MarkerNumber).TimeInState = M_Seq(MarkerNumber).stop_time.Subtract(M_Seq(MarkerNumber).start_time).TotalSeconds
            Catch
                M_Seq(MarkerNumber).start_time = Now
                '.TotalSeconds
                M_Seq(MarkerNumber).TimeInState = (Now - M_Seq(MarkerNumber).start_time).TotalSeconds
            End Try
            M_Seq(MarkerNumber).LoopCount += 1 Mod 10000000
        End If

        '===================================================
        ' Reset
        '===================================================
        If M_Seq(MarkerNumber).Reset Then
            M_Seq(MarkerNumber).CurrentState = "Init"
            M_Seq(MarkerNumber).NextState = "Init"

            Marker_2_Cancel()
            System.Threading.Thread.Sleep(100)
            System.Windows.Forms.Application.DoEvents()
            Me.Refresh()

            M_Seq(MarkerNumber).Reset = False
        End If

        ' ===================================================
        ' Wait for PLC Mark Enable
        ' ===================================================
        If PLC_Mark_Enable = False Or
            M_Seq(MarkerNumber).CurrentState = "" Or
            M_Seq(MarkerNumber).CurrentState Is Nothing Then

            M_Seq(MarkerNumber).NextState = "Init"
            M_Seq(MarkerNumber).CurrentState = "Init"
        End If

        '===================================================
        'Step - Init 
        'Initialize
        '===================================================
        If M_Seq(MarkerNumber).CurrentState = "Init" Then

            ' Reset PLC signals
            Try
                EthernetIPforCLXCom1.Write("Sta17_Print_Error", 0)
                EthernetIPforCLXCom1.Write("Sta17_Print_Done", 0)
                EthernetIPforCLXCom1.Write("Sta17_Print_Data_Sent", 0)

                Marker_2_Button.BackColor = SystemColors.Control
                PLC_Comms_OK = True
            Catch
                EthernetComErrorCount += EthernetComErrorCount
                Markers_Form.Marker_2_Seq_Log_TextBox.AppendText(vbCrLf & "PLC Comm Error ")
                Marker_2_Button.BackColor = Color.Yellow
                Marker_2_Button.Text = "PLC Comm Error"
                PLC_Comms_OK = False
                Return
            End Try

            Marker_2_ReadStatus()

            'Change state
            If PLC_Mark_Enable And
                Marker_2_Status_1 = "1" And
                PLC_Sta17_Print_Data_Sent = False And
                PLC_Sta17_Print_Done = False And
                PLC_Sta17_Print_Data_Sent = False And
                PLC_Sta17_Print_Start = False Then

                M_Seq(MarkerNumber).NextState = "Wait for Print"
                M_Seq(MarkerNumber).CurrentState = "Wait for Print"

                EthernetIPforCLXCom1.Write("Sta17_print_data_sent", 1)
            Else
                Wait_Message_Form.Show()
                Wait_Message_Form.Text = "PLC Mark Enable           = " & vbTab & PLC_Mark_Enable & vbCrLf &
                                         "Marker 2 status           = " & vbTab & Marker_2_Status_1 & vbCrLf &
                                         "PLC_Sta17_Print_Data_Sent = " & vbTab & PLC_Sta17_Print_Data_Sent & vbCrLf &
                                         "PLC_Sta17_Print_Done      = " & vbTab & PLC_Sta17_Print_Done & vbCrLf &
                                         "PLC_Sta17_Print_Data_Sent = " & vbTab & PLC_Sta17_Print_Data_Sent & vbCrLf &
                                         "PLC_Sta17_Print_Start     = " & vbTab & PLC_Sta17_Print_Start
            End If
        End If

        '===================================================
        ' Step
        ' Send Print Data
        ' Set Print Data Sent
        ' Wait for PLC Print Command
        '===================================================
        Dim x As Integer = -1
        Dim cmdArmMarker = Chr(27) & Chr(5) & " " & "1" & Chr(13) & Chr(27) & Chr(7) & Chr(13)
        Dim y As String = ""

        If M_Seq(MarkerNumber).CurrentState = "Wait for Print" Then
            Wait_Message_Form.Close()

            EthernetIPforCLXCom1.Write("Sta17_print_data_sent", 1)

            ' wait for PLC to repeat back Print command
            If PLC_Sta17_Print_Start Then
                ' Arm Marker
                ' Wait for Marker armed (response = X)
                y = Marker_2_SendData(cmdArmMarker, "X")
                x = y.IndexOf("X")
            End If

            If x >= 0 Then
                M_Seq(MarkerNumber).NextState = "Printing"
            End If
        End If

        ' ===================================================
        ' Step
        ' Reset Print Data Sent
        ' Wait for Printing Done from Marker
        ' Then Send Print Done to PLC
        ' ===================================================
        If M_Seq(MarkerNumber).CurrentState = "Printing" Then

            EthernetIPforCLXCom1.Write("Sta17_Print_Data_Sent", 0)

            'Change state
            ' wait for Marking done (Marker sends Y)
            x = Marker_2_ComPort.ReadExisting().IndexOf("Y")

            If x >= 0 Then
                Try
                    ' Set StaXX_Print_Done
                    EthernetIPforCLXCom1.Write("Sta17_Print_Done", 1)
                    'Marker_2_Button.BackColor = Color.Green
                    PLC_Comms_OK = True
                Catch
                    EthernetComErrorCount += EthernetComErrorCount
                    Markers_Form.Marker_2_Seq_Log_TextBox.AppendText(vbCrLf & "PLC Comm Error")

                    Marker_2_Button.BackColor = Color.Yellow
                    Marker_2_Button.Text = "PLC Comm Error"
                    PLC_Comms_OK = False
                End Try

                M_Seq(MarkerNumber).NextState = "End"
                M_Seq(MarkerNumber).CurrentState = "End"
            End If
        End If

        ' ===================================================
        ' Step End        
        ' ===================================================
        If M_Seq(MarkerNumber).CurrentState = "End" Then
            ' No Action

            'Change state
            If PLC_Mark_Enable Then
                M_Seq(MarkerNumber).NextState = "Wait for Print"
                M_Seq(MarkerNumber).CurrentState = "Wait for Print"

                EthernetIPforCLXCom1.Write("Sta17_Print_Error", 0)
                EthernetIPforCLXCom1.Write("Sta17_Print_Done", 0)
                EthernetIPforCLXCom1.Write("Sta17_Print_Data_Sent", 0)
                PLC_Sta17_Print_Start = 0
            Else
                M_Seq(MarkerNumber).NextState = "Init"
                M_Seq(MarkerNumber).CurrentState = "Init"
            End If
        End If

        Markers_Form.Marker_2_Seq_Log_TextBox.AppendText(vbCrLf & M_Seq(MarkerNumber).CurrentState)
        Marker_2_Button.Text = M_Seq(MarkerNumber).CurrentState
        Markers_Form.Marker_2_State_TextBox.Text = Marker_2_Button.Text

        'Update State Conditions ===================================================
        M_Seq(MarkerNumber).StateChanged = (M_Seq(MarkerNumber).CurrentState <> M_Seq(MarkerNumber).NextState)
        M_Seq(MarkerNumber).CurrentState = M_Seq(MarkerNumber).NextState

        If M_Seq(MarkerNumber).StateChanged Then
            Markers_Form.Marker_2_Seq_Log_TextBox.AppendText(vbCrLf & "State change: " & M_Seq(MarkerNumber).CurrentState)
        End If
        'update status on screen ===================================================
        'If M_Seq(MarkerNumber).LoopCount <= 2 Then
        Markers_Form.Marker_2_State_TextBox.Text = M_Seq(MarkerNumber).CurrentState
        'End If

        'Report Ethernet comm status ===================================================
        If EthernetComErrorCount > 0 Then
            Markers_Form.Marker_2_Seq_Log_TextBox.AppendText(vbCrLf & "PLC Comm errors :" & EthernetComErrorCount & vbCrLf)
        End If

        ' Thus Ends Marker 2 Control Sequence =====================
    End Sub

    ' ======================================================
    ' Password Button
    ' ======================================================
    Private Sub User_Access_Button_Click(sender As Object, e As EventArgs) Handles User_Access_Button.Click
        ' if access not enabled,  ask for password
        If FullAccess = False Then
            User_Permission_TextBox.Clear()
            User_Permission_TextBox.Visible = True
            User_Access_Button.Text = "Enter password"
            User_Permission_TextBox.Select()

        Else
            Renew_Permissions()
        End If
        Me.Refresh()

    End Sub
    ' ======================================================
    ' Password Renew Permissions
    ' ======================================================
    Public Sub Renew_Permissions()
        'restart timer
        Permission_Timer.Stop()
        Permission_Timer.Interval = 1000 * 60
        Permission_Timer.Start()

        ' enable permissions
        FullAccess = True
        My.Settings.FullAccess = FullAccess
        My.Settings.Save()

        'paint button backcolor
        User_Access_Button.BackColor = Color.Green
        User_Access_Button.Text = "Full Access"

        Me.Refresh()
    End Sub

    ' ======================================================
    ' Password Reset Permissions
    ' ======================================================
    Public Sub Reset_Permissions()
        Permission_Timer.Stop()
        FullAccess = False
        My.Settings.FullAccess = FullAccess
        My.Settings.Save()

        User_Access_Button.BackColor = SystemColors.Control

        User_Access_Button.Text = "User Access"
        User_Permission_TextBox.Visible = False
        Me.Refresh()
    End Sub
    ' ======================================================
    ' Password Timer timeout
    ' ======================================================
    Private Sub Permission_Timer_Tick(sender As Object, e As EventArgs) Handles Permission_Timer.Tick
        Reset_Permissions()
    End Sub

    ' ======================================================
    ' Password Entry Text Box
    ' ======================================================
    Private Sub User_Permission_TextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles User_Permission_TextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ' strip off vbcrlf at end of entry
                If (User_Permission_TextBox.Text.Length >= User_Password.Length) And
                    User_Permission_TextBox.Text.Substring(0, User_Password.Length) = User_Password Then

                    Renew_Permissions()
                    User_Permission_TextBox.Visible = False
                Else
                    User_Access_Button.Text = "Password not correct"
                    User_Permission_TextBox.Visible = False
                    System.Threading.Thread.Sleep(1500)
                    User_Access_Button.Text = "User Access"
                End If
            End If
        Catch
            User_Access_Button.Text = "Password not correct"
            User_Permission_TextBox.Visible = False
            System.Threading.Thread.Sleep(1500)
            User_Access_Button.Text = "User Access"
        End Try
    End Sub

    '==================================================
    'Actual quantity changed
    'Check for end of batch
    '==================================================
    Private Sub A_25_Recipe_Batch_Key_Que_PLC_ValueChanged(sender As Object, e As EventArgs) Handles A_25_Recipe_Batch_Key_Que_PLC.ValueChanged

        'Try
        '    'Actual Quantity changed
        '    'If this is end of current series?
        '    If CInt(A_24_Recipe_Batch_Quantity_PLC.Value) > 0 And
        '    CInt(A_25_Recipe_Batch_Key_Que_PLC.Value) > 0 And
        '    CInt(A_24_Recipe_Batch_Quantity_PLC.Value) >= CInt(A_25_Recipe_Batch_Key_Que_PLC.Value) Then

        '        caption = "PLC Quantity Value Changed"

        '        Wait_Message_Form.Show()
        '        Wait_Message_Form.Text = "Key Series is complete." & vbCrLf &
        '                                 "Quantity produced : " & PLC_24_Recipe_Batch_Quantity & vbCrLf &
        '                                 "Batch quantity    : " & PLC_25_Recipe_Batch_Key_Que & vbCrLf &
        '                                 "Starting Next Series ..."

        '        'Stop Marking sequence
        '        MainMenu_Timer.Stop()

        '        'get next row from keyfile
        '        Keyfile_Select_Form.CloseCurrentWorkFileRow()

        '        ' point to next row in Keyfile
        '        WorkFile_CurrentRow += 1
        '        Keyfile_Select_Form.StartWorkFileRow(WorkFile_CurrentRow)

        '        'Restart Marking sequence
        '        MainMenu_Timer.Start()
        '    End If
        'Catch ex As Exception
        '    msg = "Unable to process Series change" & vbCrLf &
        '            ex.Message
        '    MessageBox.Show(msg,
        '                    caption,
        '                    MessageBoxButtons.OK,
        '                    MessageBoxIcon.Exclamation)
        'End Try
        'Wait_Message_Form.Close()
    End Sub

    ' ===================================================
    ' Machine Mode update
    ' ===================================================
    Private Sub Machine_Mode_PLC_TextChanged(sender As Object, e As EventArgs) Handles Machine_Mode_PLC.TextChanged
        If Machine_Mode_PLC.Text = "0" Then
            Machine_Mode_Display.Text = "Stopped"
            My.Settings.Edit_OK = True
            PLC_Comms_Label.BackColor = Color.Green
            PLC_Comms_Label.Text = "PLC Comms OK"
        ElseIf Machine_Mode_PLC.Text = "1" Then
            Machine_Mode_Display.Text = "Initialized"
            My.Settings.Edit_OK = True
            PLC_Comms_Label.BackColor = Color.Green
            PLC_Comms_Label.Text = "PLC Comms OK"
        ElseIf Machine_Mode_PLC.Text = "2" Then
            Machine_Mode_Display.Text = "Manual Operation"
            'My.Settings.Edit_OK = False
            PLC_Comms_Label.BackColor = Color.Green
            PLC_Comms_Label.Text = "PLC Comms OK"
        ElseIf Machine_Mode_PLC.Text = "3" Then
            Machine_Mode_Display.Text = "Semi-Auto Operation"
            'My.Settings.Edit_OK = False
            PLC_Comms_Label.BackColor = Color.Green
            PLC_Comms_Label.Text = "PLC Comms OK"
        ElseIf Machine_Mode_PLC.Text = "4" Then
            Machine_Mode_Display.Text = "Dry Cycle"
            'My.Settings.Edit_OK = False
            PLC_Comms_Label.BackColor = Color.Green
            PLC_Comms_Label.Text = "PLC Comms OK"
        ElseIf Machine_Mode_PLC.Text = "5" Then
            Machine_Mode_Display.Text = "Full Auto Operation"
            'My.Settings.Edit_OK = False
            PLC_Comms_Label.BackColor = Color.Green
            PLC_Comms_Label.Text = "PLC Comms OK"
        Else
            PLC_Comms_Label.BackColor = Color.Yellow
            PLC_Comms_Label.Text = "PLC Comms Not OK"
        End If

        '' Machine Operating
        'If Machine_Mode_PLC.Text = "2" Or
        '    Machine_Mode_PLC.Text = "3" Or
        '    Machine_Mode_PLC.Text = "4" Or
        '    Machine_Mode_PLC.Text = "5" Then

        '    'Machine_Operating = True
        'Else
        '    'Machine_Operating = False
        'End If
        ''My.Settings.Machine_Idle = Not Machine_Operating
        'My.Settings.Machine_Idle = True
    End Sub

    ' ===================================================
    ' Recipe Button
    ' ===================================================
    Private Sub Recipe_Button_Click(sender As Object, e As EventArgs) Handles Recipe_Button.Click
        RecipeOpenForm()
    End Sub
    Private Sub RecipeOpenForm()
        'If Application.OpenForms().OfType(Of RecipeDisplay_Form).Any Then
        RecipeDisplay_Form.BringToFront()
        'Else
        RecipeDisplay_Form.Text = "RecipeDisplay_Form"
        RecipeDisplay_Form.Show()
        RecipeDisplay_Form.StartPosition = FormStartPosition.Manual
        RecipeDisplay_Form.Location = New Point(200, 0)
        RecipeDisplay_Form.Show()
        RecipeDisplay_Form.BringToFront()
        'End If
    End Sub

    ' ===================================================
    ' Sta 14 Print Command
    ' ===================================================
    Private Sub Sta14_Start_Print_BasicLabel_TextChanged(sender As Object, e As EventArgs) Handles Sta14_Start_Print_BasicLabel.TextChanged
        If Sta14_Start_Print_BasicLabel.Text = "True" Then
            MainMenu_Timer.Stop()
            'PLC_Sta14_Print_Start = True
            Marker_1_Control()
            MainMenu_Timer.Start()
        End If
    End Sub

    ' ===================================================
    ' Sta 17 Print Command
    ' ===================================================
    Private Sub Sta17_Start_Print_BasicLabel_TextChanged(sender As Object, e As EventArgs) Handles Sta17_Start_Print_BasicLabel.TextChanged
        If Sta17_Start_Print_BasicLabel.Text = "True" Then
            MainMenu_Timer.Stop()
            'PLC_Sta17_Print_Start = True
            Marker_2_Control()
            MainMenu_Timer.Start()
        End If
    End Sub

    ' ============================================================
    ' PLC sends Request_PC_Data when the current file is complete
    ' ============================================================
    Private Sub PLC_Requests_Data_BasicLabel_TextChanged(sender As Object, e As EventArgs) Handles PLC_Request_Data_BasicLabel.TextChanged
        If PLC_Request_Data_BasicLabel.Text = "True" Then

            caption = "PLC Request Data"
            msg = "PLC Request Data" & vbCrLf &
                "Proceed to load next KeyFile?"

            dialog_result = MessageBox.Show(msg,
                            caption,
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Asterisk,
                            MessageBoxDefaultButton.Button1)

            If dialog_result = DialogResult.Yes Then
                Keyfile_Select_Form.Send_First_Recipe_Data()
                EthernetIPforCLXCom1.Write("PC_Data_Sent", 1)
            End If
        End If
    End Sub

    ' ============================================================
    ' Machine Mode Display button
    ' ============================================================
    Private Sub Machine_Mode_Display_Click(sender As Object, e As EventArgs) Handles Machine_Mode_Display.Click
        'Machine_Operating = Not Machine_Operating
        'My.Settings.Machine_Idle = Not Machine_Operating
        My.Settings.Machine_Idle = True
    End Sub

    ' ============================================================
    ' PLC Comms Enabled
    ' ============================================================
    Private Sub PLC_Comms_Enabled_Label_Click(sender As Object, e As EventArgs) Handles PLC_Comms_Enabled_Label.Click
        PLC_Comms_Enabled = Not PLC_Comms_Enabled
        If PLC_Comms_Enabled Then
            PLC_Comms_Enabled_Label.BackColor = Color.Green
            PLC_Comms_Enabled_Label.Text = "PLC Comms Enabled"
        Else
            PLC_Comms_Enabled_Label.BackColor = Color.Yellow
            PLC_Comms_Enabled_Label.Text = "PLC Comms Disabled"
        End If
        My.Settings.PLC_Comms_Enabled = PLC_Comms_Enabled
        My.Settings.Save()
    End Sub
End Class

'Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Runtime.InteropServices
'Imports System.Linq
'Imports System.IO
'Imports System          'Access Console.WriteLine()
'Imports System.IO.Ports 'Access the SerialPort Object
'Imports Microsoft.Data.ConnectionUI
'Imports System.Data.Common
'Imports System.Data.SqlClient
'Imports System.Data.OleDb.OleDbConnection
'Imports System.Collections.Generic
'Imports System.Data
'Imports System.Windows.Forms
'Imports System.Configuration
'Imports System.Reflection

'Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Runtime.InteropServices
'Imports System.Linq
'Imports System.IO
'Imports System          'Access Console.WriteLine()
'Imports System.IO.Ports 'Access the SerialPort Object
'Imports Microsoft.Data.ConnectionUI
'Imports System.Data.Common
'Imports System.Data.SqlClient
'Imports System.Data.OleDb.OleDbConnection
'Imports System.Collections.Generic
'Imports System.Data
'Imports System.Windows.Forms
'Imports System.Configuration
'Imports System.Reflection
