Option Explicit On

Public Class RecipeVerify_Form
    'Dim msg As String = ""
    'Dim caption As String = ""

    Private Sub RecipeVerify_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Heading_Label.Text = "Verify each item is correct." & vbCrLf &
                            "Then click <Check All>." & vbCrLf &
                            "Then click <Send Recipe> to send Recipe values to the PLC."
        Update_Verify()
        Update_CheckBoxes(False)
    End Sub

    ' ===================================================
    ' Update verify items
    ' ===================================================
    Private Sub Update_Verify()
        ' ===================================================
        ' Station 1
        If R_Sta_1_Load_Keys = "0" Then
            Sta_1_Master_CheckBox.Text = "0"
        ElseIf R_Sta_1_Load_Keys = "1" Then
            Sta_1_Master_CheckBox.Text = "1"
        ElseIf R_Sta_1_Load_Keys = "2" Then
            Sta_1_Master_CheckBox.Text = "2"
        End If

        If R_Sta_1_Keyed = "1" Then
            Sta_1_Master_CheckBox.Text = "Station 1 : Master Key must be loaded with First Lock"
        Else
            Sta_1_Master_CheckBox.Text = "??"
        End If

        If R_Sta_1_Unload = "1" Then
            Sta_1_Unload_CheckBox.Text = "Station 1 : Parts will be automatically unloaded at Station 17"
        Else
            Sta_1_Unload_CheckBox.Text = "??"
        End If

        ' ===================================================
        ' Station 2
        If R_Sta_2_Enable = "1" Then
            Sta_2_FlexAce_CheckBox.Text = "Station 2 : No Flex ACE parts need to be loaded." & vbCrLf &
                                            "Station 3 should be enabled."
        Else
            Sta_2_FlexAce_CheckBox.Text = "??? Station 2 : Load Flex ACE parts." & vbCrLf &
                                            "Station 3 should be disabled."
        End If

        ' ===================================================
        ' Station 3
        Sta_3_Part_CheckBox.Text = "Station 3 part number : " & R_Sta_3_Part_Number

        If R_Sta_3_Enable = "1" Then
            Sta_3_Enabled_CheckBox.Text = "Station 3 is Enabled"
        Else
            Sta_3_Enabled_CheckBox.Text = "Station 3 is Disabled"
        End If

        Sta_3_Part_CheckBox.Text = "Station 3 part number : " & R_Sta_3_Part_Number
        'R_Bushing_ToolingCode

        ' ===================================================
        ' Station 4
        If R_Sta_4_Enable = "1" Then
            Sta_4_Enabled_CheckBox.Text = "Station 4 is Enabled"
        Else
            Sta_4_Enabled_CheckBox.Text = "Station 4 is Disabled"
        End If

        ' ===================================================
        ' Station 5
        Sta_5_Part_CheckBox.Text = "Station 5 part number : " & R_Sta_5_Part_Number


        If R_Sta_5_Enable = "1" Then
            Sta_5_Enabled_CheckBox.Text = "Station 5 is Enabled"
        Else
            Sta_5_Enabled_CheckBox.Text = "Station 5 is Disabled"
        End If

        Sta_5_Pin_Ht_CheckBox.Text = "Station 5 Vertical Height : " & R_Sta_5_Vert_Height & ""

        ' ===================================================
        ' Station 6
        If R_Sta_6_Enable = "1" Then
            Sta_6_Enabled_CheckBox.Text = "Station 6 is Enabled"
        Else
            Sta_6_Enabled_CheckBox.Text = "Station 6 is Disabled"
        End If

        ' ===================================================
        ' Station 7
        Sta_7_Enabled_CheckBox.Text = "Station 7 part number : " & R_Sta_7_Part_Number

        If R_Sta_7_Enable = "1" Then
            Sta_7_Enabled_CheckBox.Text = "Station 7 is Enabled"
        Else
            Sta_7_Enabled_CheckBox.Text = "Station 7 is Disabled"
        End If

        ' ===================================================
        ' Station 8
        Sta_8_Part_CheckBox.Text = "Station 8 part number : " & R_Sta_8_Part_Number

        If R_Sta_8_Enable = "1" Then
            Sta_8_Enabled_CheckBox.Text = "Station 8 is Enabled"
        Else
            Sta_8_Enabled_CheckBox.Text = "Station 8 is Disabled"
        End If

        ' ===================================================
        ' Station 9
        If R_Sta_9_Enable = "1" Then
            Sta_9_Enabled_CheckBox.Text = "Station 9 is Enabled"
        Else
            Sta_9_Enabled_CheckBox.Text = "Station 9 is dISabled"
        End If

        Sta_9_Tooling_CheckBox.Text = "Station 9 Tooling Name : " & R_Sta_9_Tool

        ' ===================================================
        ' Station 10
        Sta_10_Part_CheckBox.Text = "Station 10 part number : " & R_Sta_10_Part_Number

        ' ===================================================
        ' Station 11
        Sta_11_Part_CheckBox.Text = "Station 11 part number : " & R_Sta_11_Part_Number

        If R_Sta_11_Enable = "1" Then
            Sta_11_Enabled_CheckBox.Text = "Station 11 is Enabled"
        Else
            Sta_11_Enabled_CheckBox.Text = "Station 11 is Disabled"
        End If

        ' ===================================================
        ' Station 12
        Sta_12_Part_CheckBox.Text = "Station 12 part number : " & R_Sta_12_Part_Number


        If R_Sta_12_Enable = "1" Then
            Sta_12_Enabled_CheckBox.Text = "Station 12 is Enabled"
        Else
            Sta_12_Enabled_CheckBox.Text = "Station 12 is Disabled"
        End If


        ' ===================================================
        ' Station 13
        If R_Sta_13_Enable = "1" Then
            Sta_13_Enabled_CheckBox.Text = "Station 13 is Enabled"
        Else
            Sta_13_Enabled_CheckBox.Text = "Station 13 is Disabled"
        End If

        Sta_13_Part_CheckBox.Text = "Station 13 part number : " & R_Sta_13_Part_Number
        Sta_13_Bowl_CheckBox.Text = "Station 13 Bowl : " & R_Barrel_Bowl
        Sta_13_Tooling_CheckBox.Text = "Station 13 Tooling Name : " & R_Sta_13_Tool
        Sta_13_Grippers_CheckBox.Text = "Station 13 Gripper Jaws : " & R_Sta_13_Gripper
        Sta_13_Orient_CheckBox.Text = "Station 13 Orient Fiber Position : " & R_Sta_13_Orient
        'Sta_13_Orient_CheckBox.Text = "Station 13 Orient Fiber Position : " & R_Barrel_Orient
        Sta_13_ShotPin_CheckBox.Text = "Station 13 ShotPin Position : " & R_Sta_13_Shotpin
        Sta_13_Barrel_CheckBox.Text = "Station 13 Barrel Place Position : " & R_Sta_13_Place
        Sta_13_Bushing_Pos_CheckBox.Text = "Station 13 Bushing Re-Clock Position : " & R_Sta_13_ReClockPos
        Sta_13_Bushing_Rot_CheckBox.Text = "Station 13 Bushing Re-Clock Rotation : " & R_Sta_13_ReClockRot

        ' ===================================================
        ' Station 14
        If R_Sta_14_Enable = "1" Then
            Sta_14_Enabled_CheckBox.Text = "Station 14 is Enabled"
        Else
            Sta_14_Enabled_CheckBox.Text = "Station 14 is Disabled"
        End If

        Sta_14_Tooling_CheckBox.Text = "Station 14 Tooling Name : " & R_Sta_14_Tool
        ' ===================================================
        ' Station 15
        If R_Sta_15_Enable = "1" Then
            Sta_15_Enabled_CheckBox.Text = "Station 15 is Enabled"
        Else
            Sta_15_Enabled_CheckBox.Text = "Station 15 is Disabled"
        End If

        Sta_15_Tooling_CheckBox.Text = "Station 15 Tooling Name : " & R_Sta_15_Tool
        R_Sta_15_Insert_Angle = R_Sta_15_Insert_Angle
        R_Sta_15_Test_Angle = R_Sta_15_Test_Angle
        R_Sta_15_Finish_Angle = R_Sta_15_Finish_Angle
        R_Sta_15_Insert_Angle = R_Sta_15_Insert_Angle

        If R_Sta_15_Leave_Key_In_After_Test = "1" Then

        Else

        End If

        ' ===================================================
        ' Station 16
        Sta_16_Part_CheckBox.Text = "Station 16 Part Number : " & R_Sta_16_Part_Number

        If R_Sta_16_Enable = "1" Then
            Sta_16_Enabled_CheckBox.Text = "Station 16 is Enabled"
        Else
            Sta_16_Enabled_CheckBox.Text = "Station 16 is Disabled"
        End If

        R_Sta_16_Back_Support = R_Sta_16_Back_Support
        R_KnurlPin_ToolingCode = R_KnurlPin_ToolingCode
        R_KnurlPin_Bowl = R_KnurlPin_Bowl

        ' ===================================================
        ' Station 17
        If R_Sta_17_Enable = "1" Then
            Sta_17_Enabled_CheckBox.Text = "Station 17 is Enabled"
        Else
            Sta_17_Enabled_CheckBox.Text = "Station 17 is Disabled"
        End If

    End Sub

    '=====================================================================
    ' Check all checkboxes button
    '=====================================================================
    Private Sub Check_All_Button_Click(sender As Object, e As EventArgs) Handles Check_All_Button.Click
        Update_CheckBoxes(True)
    End Sub

    '=====================================================================
    ' Un Check all checkboxes button
    '=====================================================================
    Private Sub UnCheck_All_Button_Click(sender As Object, e As EventArgs) Handles Uncheck_All_Button.Click
        Update_CheckBoxes(False)
    End Sub

    '=====================================================================
    ' Update all checkboxes button
    '=====================================================================
    Private Sub Update_CheckBoxes(state)
        Dim c As Control = Me
        CheckAll(c, state)
        Send_Recipe_Button.Enabled = state
    End Sub

    '=====================================================================
    ' Check all
    '=====================================================================
    Private Sub CheckAll(ByVal container As Control, state As Boolean)
        ' set all checkboxes ON
        For Each ctl In container.Controls
            If TypeOf ctl Is CheckBox Then

                ctl.checked = state
            End If
            If ctl.HasChildren Then
                CheckAll(ctl, state)
            End If
        Next
    End Sub

    '=====================================================================
    ' Send Recipe to PLC
    '=====================================================================
    Private Sub Send_Recipe_Button_Click(sender As Object, e As EventArgs) Handles Send_Recipe_Button.Click
        If PLC_Comms_Enabled Then
            WriteRecipeToPLC()
            Send_Recipe_Button.Enabled = False
            Recipe_Downloaded(True)

        Else
            MessageBox.Show("PLC communication is not enabled.",
            "PLC_Communication",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1)
        End If
    End Sub

    '=====================================================================
    ' Recipe OK Update
    '=====================================================================
    Public Sub Recipe_Downloaded(status)
        ' reset to default
        If VarType(status) <> vbBoolean Then
            MainMenu.Recipe_Button.BackColor = SystemColors.Control

            First_Recipe_Data_Sent = False

            Return
        End If

        ' Recipe OK
        If status Then
            MainMenu.Recipe_Button.BackColor = Color.Green
        Else
            ' Recipe Fault
            MainMenu.Recipe_Button.BackColor = Color.Yellow

            First_Recipe_Data_Sent = False
            'First_Recipe_Data_PLC_Response = False

        End If
    End Sub
End Class
