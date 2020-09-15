'=====================================================================
' Verify Recipe Form
'=====================================================================
Option Explicit On

'Imports System.Configuration
'Imports System.Configuration.ConfigurationManager
'Imports System.Threading
'Imports Microsoft.Data.ConnectionUI

Public Class Verify_Recipe_Form

    Public A_00_Verified As Boolean
    Public A_01_Verified As Boolean
    Public A_02_Verified As Boolean
    Public A_03_Verified As Boolean
    Public A_04_Verified As Boolean
    Public A_05_Verified As Boolean
    Public A_06_Verified As Boolean
    Public A_07_Verified As Boolean
    Public A_08_Verified As Boolean
    Public A_09_Verified As Boolean
    Public A_10_Verified As Boolean
    Public A_11_Verified As Boolean
    Public A_12_Verified As Boolean
    Public A_13_Verified As Boolean
    Public A_14_Verified As Boolean
    Public A_15_Verified As Boolean
    Public A_16_Verified As Boolean
    Public A_17_Verified As Boolean
    Public A_18_Verified As Boolean
    Public A_19_Verified As Boolean
    Public A_20_Verified As Boolean
    Public A_21_Verified As Boolean
    Public A_22_Verified As Boolean
    Public A_23_Verified As Boolean
    Public A_24_Verified As Boolean
    Public A_25_Verified As Boolean

    Public PLC_Matches_Recipe As Boolean

    '=====================================================================
    'Load Form
    '=====================================================================
    Private Sub Verify_Recipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '====================================================
        'Ethernet address
        '====================================================
        EthernetIPforCLXCom1.IPAddress = My.Settings.PLC_IP_Address
        EthernetIPforCLXCom1.Timeout = My.Settings.PLC_IP_Timeout
    End Sub

    Private Sub Verify_Recipe_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Initialize_PLC_Values()
        UpdateData()
    End Sub

    '=====================================================================
    'Change Enable Status
    '=====================================================================
    ' General purpose recursion to change property of any group of controls
    ' How to call:
    ' Dim c As Control = Me
    ' EnableRecipeDataItems(c, ReadOnly_CheckBox.Checked)
    Private Sub EnableRecipeDataItems(ByVal container As Control, state As Boolean)
        For Each ctl In container.Controls
            If TypeOf ctl Is CheckBox And
                ctl.text <> "Read Only" Then
                ctl.Enabled = Not state
            End If
            If ctl.HasChildren Then
                EnableRecipeDataItems(ctl, state)
            End If
        Next
    End Sub

    '=====================================================================
    'Update data
    '=====================================================================
    Private Sub UpdateData()

        Wait_Message_Form.Text = "Verify Data Update"
        Wait_Message_Form.Message_TextBox.Text = "Updating from Database" & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        'Set screen item' recipe values
        Sta1_LoadKeys_Yes_RadioButton.Checked = (R_Sta_1_Load_Keys = "1")
        Sta1_LoadKeys_No_RadioButton.Checked = (R_Sta_1_Load_Keys = "0")
        Sta1_LoadKeys_Single_RadioButton.Checked = (R_Sta_1_Load_Keys = "2")

        Sta1_Keyed_CheckBox.Checked = (R_Sta_1_Keyed = "1")

        AutoLoad_CheckBox.Checked = (R_Sta_1_Unload = "1")

        'Sta2_Enable_checkbox.Checked = (R_Sta_2_Enable = "1")

        Sta3_Enable_CheckBox.Checked = (R_Sta_3_Enable = "1")
        Sta4_Enable_CheckBox.Checked = (R_Sta_4_Enable = "1")
        Sta5_Enable_CheckBox.Checked = (R_Sta_5_Enable = "1")
        Sta6_Enable_CheckBox.Checked = (R_Sta_6_Enable = "1")
        Sta7_Enable_CheckBox.Checked = (R_Sta_7_Enable = "1")
        Sta8_Enable_CheckBox.Checked = (R_Sta_8_Enable = "1")
        Sta9_Enable_CheckBox.Checked = (R_Sta_9_Enable = "1")
        Sta10_Enable_CheckBox.Checked = (R_Sta_10_Enable = "1")
        Sta11_Enable_CheckBox.Checked = (R_Sta_11_Enable = "1")
        Sta12_Enable_CheckBox.Checked = (R_Sta_12_Enable = "1")
        Sta13_Enable_CheckBox.Checked = (R_Sta_13_Enable = "1")
        Sta14_Enable_CheckBox.Checked = (R_Sta_14_Enable = "1")
        'Sta14_Enable_CheckBox.Checked = (R_Sta_14_Enable = "1")
        Sta15_Enable_CheckBox.Checked = (R_Sta_15_Enable = "1")
        Sta16_Enable_CheckBox.Checked = (R_Sta_16_Enable = "1")
        Sta17_Enabled_CheckBox.Checked = (R_Sta_17_Enable = "1")

        Sta15_Finish_Label.Text = String.Format("{0:n2}", CDec(My.Settings.Sta_15_Finish_Angle))
        Sta15_Insert_Label.Text = String.Format("{0:n2}", CDec(My.Settings.Sta_15_Insert_Angle))
        Sta15_Test_Label.Text = String.Format("{0:n2}", CDec(My.Settings.Sta_15_Test_Angle))

        Sta15_LeaveKey_CheckBox.Checked = (R_Sta_15_Leave_Key_In_After_Test = "1")

        '=======================================================
        'Step_x_Label displays bowl assignment to stations 7 & 8
        '=======================================================

        'Bottom Tumbler 1 ======================================
        Step_1_Label.Text = My.Settings.Stepped1_Bowl
        Bot_1_Label.Text = My.Settings.Bot1_Bowl

        'Bottom Tumbler 2 ======================================
        Step_2_Label.Text = My.Settings.Stepped2_Bowl
        Bot_2_Label.Text = My.Settings.Bot2_Bowl

        'Bottom Tumbler 3 ======================================
        Step_3_Label.Text = My.Settings.Stepped3_Bowl
        Bot_3_Label.Text = My.Settings.Bot3_Bowl

        'Bottom Tumbler 4 ======================================
        Step_4_Label.Text = My.Settings.Stepped4_Bowl
        Bot_4_Label.Text = My.Settings.Bot4_Bowl

        'Bottom Tumbler 5 ======================================
        Step_5_Label.Text = My.Settings.Stepped5_Bowl
        Bot_5_Label.Text = My.Settings.Bot5_Bowl

        'Bottom Tumbler 6 ======================================
        Step_6_Label.Text = My.Settings.Stepped6_Bowl
        Bot_6_Label.Text = My.Settings.Bot6_Bowl

        'Bottom Tumbler 7 ======================================
        Step_7_Label.Text = My.Settings.Stepped7_Bowl
        Bot_7_Label.Text = My.Settings.Bot7_Bowl

        Wait_Message_Form.Close()
    End Sub

    Public Sub Initialize_PLC_Values()

        Wait_Message_Form.Text = "Verify Data Update"
        Wait_Message_Form.Message_TextBox.Text = "Reading from the PLC." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        Try
            ' initialize to prevent changed value events
            PLC_00_Recipe_Manual_Load_Keys = EthernetIPforCLXCom1.Read("A_00_Recipe_Manual_Load_Keys")
            PLC_01_Recipe_Keyed_Alike = EthernetIPforCLXCom1.Read("A_01_Recipe_Keyed_Alike")
            PLC_02_Recipe_Auto_Unload_at_Sta17 = EthernetIPforCLXCom1.Read("A_02_Recipe_Auto_Unload_at_Sta17")
            PLC_03_Recipe_Load_Flex_Ace_at_Sta02 = EthernetIPforCLXCom1.Read("A_03_Recipe_Load_Flex_Ace_at_Sta02")
            PLC_04_Recipe_Enable_Sta03 = EthernetIPforCLXCom1.Read("A_04_Recipe_Enable_Sta03")
            PLC_05_Recipe_Enable_Sta04 = EthernetIPforCLXCom1.Read("A_05_Recipe_Enable_Sta04")
            PLC_06_Recipe_Enable_Sta05 = EthernetIPforCLXCom1.Read("A_06_Recipe_Enable_Sta05")
            PLC_07_Recipe_Enable_Sta06 = EthernetIPforCLXCom1.Read("A_07_Recipe_Enable_Sta06")
            PLC_08_Recipe_Enable_Sta07 = EthernetIPforCLXCom1.Read("A_08_Recipe_Enable_Sta07")
            PLC_09_Recipe_Enable_Sta08 = EthernetIPforCLXCom1.Read("A_09_Recipe_Enable_Sta08")
            PLC_10_Recipe_Enable_Sta09 = EthernetIPforCLXCom1.Read("A_10_Recipe_Enable_Sta09")
            PLC_11_Recipe_Enable_Sta10 = EthernetIPforCLXCom1.Read("A_11_Recipe_Enable_Sta10")
            PLC_12_Recipe_Enable_Sta11 = EthernetIPforCLXCom1.Read("A_12_Recipe_Enable_Sta11")
            PLC_13_Recipe_Enable_Sta12 = EthernetIPforCLXCom1.Read("A_13_Recipe_Enable_Sta12")
            PLC_14_Recipe_Enable_Sta13 = EthernetIPforCLXCom1.Read("A_14_Recipe_Enable_Sta13")
            PLC_15_Recipe_Mark_Top_of_Barrel = EthernetIPforCLXCom1.Read("A_15_Recipe_Mark_Top_of_Barrel")
            PLC_16_Recipe_Enable_Sta15 = EthernetIPforCLXCom1.Read("A_16_Recipe_Enable_Sta15")
            PLC_21_Recipe_KeyTest_Finish_Angle = EthernetIPforCLXCom1.Read("A_21_Recipe_KeyTest_Finish_Angle")
            PLC_22_Recipe_KeyTest_Start_Angle = EthernetIPforCLXCom1.Read("A_22_Recipe_KeyTest_Start_Angle")
            PLC_23_Recipe_KeyTest_Test_Angle = EthernetIPforCLXCom1.Read("A_23_Recipe_KeyTest_Test_Angle")
            PLC_17_Recipe_Leave_key_in_After_Test = EthernetIPforCLXCom1.Read("A_17_Recipe_Leave_key_in_After_Test")
            PLC_18_Recipe_Enable_Sta16 = EthernetIPforCLXCom1.Read("A_18_Recipe_Enable_Sta16")
            PLC_19_Recipe_Mark_Side_of_Barrel = EthernetIPforCLXCom1.Read("A_19_Recipe_Mark_Side_of_Barrel")
            PLC_20_Recipe_Use_Master_Key_Scenario = EthernetIPforCLXCom1.Read("A_20_Recipe_Use_Master_Key_Scenario")
            PLC_24_Recipe_Batch_Quantity = EthernetIPforCLXCom1.Read("A_24_Recipe_Batch_Quantity")
            PLC_25_Recipe_Batch_Key_Que = EthernetIPforCLXCom1.Read("A_25_Recipe_Batch_Key_Que")

        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot read from PLC." & vbCrLf, ex.Message))
        End Try

        Wait_Message_Form.Close()

    End Sub

    Private Sub Verify_Recipe()

        Wait_Message_Form.Text = "Verify Data Update"
        Wait_Message_Form.Message_TextBox.Text = "Comparing PLC to Database." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Load keys =================================================
        A_00_Verified = ((My.Settings.Sta_1_Load_Keys = "1") = PLC_00_Recipe_Manual_Load_Keys)

        ' Compare (Recipe = 1) to PLC Tag
        A_01_Verified = ((My.Settings.Sta_1_Keyed = "1") = PLC_01_Recipe_Keyed_Alike)

        A_02_Verified = ((My.Settings.Sta_1_Unload = "1") = PLC_02_Recipe_Auto_Unload_at_Sta17)

        A_03_Verified = ((My.Settings.Sta_2_Enable = "1") = PLC_03_Recipe_Load_Flex_Ace_at_Sta02)

        'Sta 3 Part Number (string) =================================================
        A_04_Verified = ((My.Settings.Sta_3_Enable = "1") = PLC_04_Recipe_Enable_Sta03)

        'Sta 4 enabled (boolean) =================================================
        A_05_Verified = ((My.Settings.Sta_4_Enable = "1") = PLC_04_Recipe_Enable_Sta03)

        'Sta 5 enabled (boolean) =================================================
        A_06_Verified = ((My.Settings.Sta_5_Enable = "1") = PLC_06_Recipe_Enable_Sta05)

        'Sta 5 Part Number (string) =================================================

        'Sta 5 Height (real) =================================================

        'Sta 6 Part Number (string) =================================================
        A_07_Verified = ((My.Settings.Sta_6_Enable = "1") = PLC_07_Recipe_Enable_Sta06)

        'Sta 7 Part Number (string) =================================================
        A_08_Verified = ((My.Settings.Sta_7_Enable = "1") = PLC_08_Recipe_Enable_Sta07)

        'Sta 8 enabled (boolean) =================================================
        A_09_Verified = ((My.Settings.Sta_8_Enable = "1") = PLC_09_Recipe_Enable_Sta08)

        'Sta 9 enabled (boolean) =================================================
        A_10_Verified = ((My.Settings.Sta_9_Enable = "1") = PLC_10_Recipe_Enable_Sta09)

        'Sta 9 Tool Number (string) =================================================

        'Sta 10 Enable (string) =================================================
        A_11_Verified = ((My.Settings.Sta_10_Enable = "1") = PLC_11_Recipe_Enable_Sta10)

        'Sta 10 Part Number (string) =================================================

        'Sta 11 Enabled (string) =================================================
        A_12_Verified = ((My.Settings.Sta_11_Enable = "1") = PLC_12_Recipe_Enable_Sta11)

        'Sta 11 Part Number (string) =================================================

        'Sta 12 Enabled (string) =================================================
        A_13_Verified = ((My.Settings.Sta_12_Enable = "1") = PLC_13_Recipe_Enable_Sta12)

        'Sta 12 Part Number (string) =================================================

        'Sta 13 Part Number (string) =================================================
        A_14_Verified = ((My.Settings.Sta_13_Enable = "1") = PLC_14_Recipe_Enable_Sta13)

        'Sta 13 Tool Number (string) =================================================

        'Sta 14 enabled (boolean) =================================================
        A_15_Verified = ((My.Settings.Sta_14_Enable = "1") = PLC_15_Recipe_Mark_Top_of_Barrel)

        'Sta 14 Part Number (string) =================================================

        'Sta 15 enabled (boolean) =================================================
        A_16_Verified = ((My.Settings.Sta_15_Enable = "1") = PLC_16_Recipe_Enable_Sta15)

        'Sta 15 Insert Angle (real) =================================================
        A_22_Verified = (CDec(Sta15_Insert_Label.Text) = PLC_22_Recipe_KeyTest_Start_Angle)

        'Sta 15 Test Angle (real) =================================================
        A_23_Verified = (CDec(Sta15_Test_Label.Text) = PLC_23_Recipe_KeyTest_Test_Angle)

        'Sta 15 Finish Angle (real) =================================================
        A_21_Verified = (CDec(Sta15_Finish_Label.Text) = PLC_21_Recipe_KeyTest_Finish_Angle)

        'Sta 15 Leave key (boolean) =================================================
        A_17_Verified = ((Sta15_LeaveKey_CheckBox.Checked) = PLC_17_Recipe_Leave_key_in_After_Test)

        'Sta 15 Part Number (string) =================================================

        'Sta 16 Enable (string) =================================================
        A_18_Verified = ((My.Settings.Sta_16_Enable) = PLC_18_Recipe_Enable_Sta16)

        'Sta 16 Part Number (string) =================================================

        'Sta 17 enabled (boolean) =================================================

        'Sta 17 Mark Side (boolean) =================================================
        'A_19_Verified = ((My.Settings.Sta_17_Mark_Side = "1") = PLC_19_Recipe_Mark_Side_of_Barrel)
        A_19_Verified = ((My.Settings.Sta_17_Enable = "1") = PLC_19_Recipe_Mark_Side_of_Barrel)

        'Sta 17 Master Key (boolean) =================================================
        A_20_Verified = ((My.Settings.Master_Key_Scenario = "1") = PLC_20_Recipe_Use_Master_Key_Scenario)


        Dim msg As String
        Dim caption As String
        Dim result

        If A_00_Verified And
            A_01_Verified And
            A_02_Verified And
            A_03_Verified And
            A_04_Verified And
            A_05_Verified And
            A_06_Verified And
            A_07_Verified And
            A_08_Verified And
            A_09_Verified And
            A_10_Verified And
            A_11_Verified And
            A_12_Verified And
            A_13_Verified And
            A_14_Verified And
            A_15_Verified And
            A_16_Verified And
            A_17_Verified And
            A_18_Verified And
            A_19_Verified And
            A_20_Verified And
            A_21_Verified And
            A_22_Verified And
            A_23_Verified Then

            PLC_Matches_Recipe = True
            Verify_PLC_Button.BackColor = Color.Green
            msg = String.Format("All Recipe parameters in PLC match the Recipe")
        Else
            PLC_Matches_Recipe = False
            Verify_PLC_Button.BackColor = Color.Yellow
            msg = String.Format("Recipe parameters do not match PLC")
        End If

        Wait_Message_Form.Close()

        caption = "Verify PLC Download to PLC"
        result = MessageBox.Show(msg,
                                caption,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)


    End Sub

    '=====================================================================
    'Check all Verify checkboxes button
    '=====================================================================
    Private Sub Check_All_Button_Click(sender As Object, e As EventArgs) Handles Check_All_Button.Click
        Dim c As Control = Me
        CheckAll(c, True)
    End Sub

    '=====================================================================
    'Check all Verify checkboxes
    '=====================================================================
    Private Sub CheckAll(ByVal container As Control, state As Boolean)
        ' set all checkboxes ON
        For Each ctl In container.Controls
            If TypeOf ctl Is CheckBox And
                ctl.tag = "OperatorCheck" Then

                ctl.checked = state
            End If
            If ctl.HasChildren Then
                CheckAll(ctl, state)
            End If
        Next
    End Sub

    '=====================================================================
    'Uncheck all Verify checkboxes button
    '=====================================================================
    Private Sub UnCheck_All_Button_Click(sender As Object, e As EventArgs) Handles Uncheck_All_Button.Click
        Dim c As Control = Me
        UnCheckAll(c, False)
    End Sub

    '=====================================================================
    'Check all Verify checkboxes
    '=====================================================================
    Private Sub UnCheckAll(ByVal container As Control, state As Boolean)
        ' set all checkboxes OFF
        For Each ctl In container.Controls
            If TypeOf ctl Is CheckBox And
                ctl.tag = "OperatorCheck" Then

                ctl.checked = state
            End If
            If ctl.HasChildren Then
                UnCheckAll(ctl, state)
            End If
        Next
    End Sub

    '=====================================================================
    'Verify Update button
    '=====================================================================
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Me.Update()
        UpdateData()
    End Sub

    '=====================================================================
    'Verify PLC data button
    '=====================================================================
    Private Sub Verify_PLC_Button_Click(sender As Object, e As EventArgs) Handles Verify_PLC_Button.Click
        Verify_Recipe()
    End Sub

    '=====================================================================
    'Toggle Read-Only button
    '=====================================================================
    Private Sub ReadOnly_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReadOnly_CheckBox.CheckedChanged
        Dim c As Control = Me
        EnableRecipeDataItems(c, ReadOnly_CheckBox.Checked)
    End Sub

    '=====================================================================
    'Send data to PLC Button click
    '=====================================================================
    'Private Sub SendToPLC_Button_Click(sender As Object, e As EventArgs) Handles SendTumblersToPLC_Button.Click
    '    WriteTumblersToPLC(EthernetIPforCLXCom1)

    '    Verify_Recipe()

    '    If PLC_Matches_Recipe Then
    '        SendFirstRecipe()
    '    Else

    '    End If
    'End Sub

    '=====================================================================
    'Capture screenshot of active window
    '=====================================================================
    Private Sub Screenshot_Button_Click(sender As System.Object, e As System.EventArgs) Handles Screenshot_Button.Click
        'working area excludes all docked toolbars like taskbar, etc.

        Dim currentScreen = Screen.FromHandle(Me.Handle).WorkingArea
        Dim bounds = Me.DesktopBounds

        'create a bitmap of the working area
        Using bmp As New Bitmap(currentScreen.Width, currentScreen.Height)
            'Using Bmp As New Bitmap(800, 1000, Imaging.PixelFormat.Format32bppPArgb)
            'Using bmp As New Bitmap(bounds.Width, bounds.Height)
            'Set the resolution to 300 DPI
            'bmp.SetResolution(300, 300)

            'copy the screen to the image
            Using g = Graphics.FromImage(bmp)

                g.CopyFromScreen(New Point(0, 0), New Point(0, 0), currentScreen.Size)
            End Using

            Try
                ' Create screenshots folder if it does not exist
                If Not (System.IO.Directory.Exists("C:\CompX\Screenshots")) Then
                    System.IO.Directory.CreateDirectory("C:\CompX\Screenshots")
                End If

                'save the image
                'bmp.Save("C:\CompX\Screenshots\Verify Form_" & System.DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss"), System.Drawing.Imaging.ImageFormat.Bmp)
                bmp.Save("C:\CompX\Screenshots\Verify Form_" & System.DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss"), System.Drawing.Imaging.ImageFormat.Bmp)

            Catch ex As Exception
                MessageBox.Show("Unable to capture screenshot." & vbCrLf &
                                ex.Message,
                                "Capture Screen Shot",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk,
                                MessageBoxDefaultButton.Button1)
            End Try
            'Using sfd As New SaveFileDialog() With {.Filter = "PNG Image|*.png",
            '                                        .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop}

            '    If sfd.ShowDialog() = DialogResult.OK Then
            '        bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png)
            '    End If
            'End Using
        End Using
    End Sub

    '=====================================================================
    'Capture screenshot (not used)
    '=====================================================================
    Private Sub ScreenGrab_BMP()
        'https://stackoverflow.com/questions/10930569/high-quality-full-screenshots-vb-net

        Dim screenSize As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim screenGrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(screenGrab)

        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenSize)
        screenGrab.Save("c:\compX\Screenshots\picture.bmp")
    End Sub
End Class



