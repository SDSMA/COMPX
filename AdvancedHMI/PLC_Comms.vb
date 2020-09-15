Option Explicit On

'Imports System.IO
'Imports System.IO.Ports 'Access SerialPort Object

Public Module PLC_Interface

    Public PLC_Comms_Enabled As Boolean = False

    Public PLC_Machine_Mode As Integer = 0
    Public PLC_Comms_OK As Boolean
    Public PLC_Recipe_Download_OK As Boolean = False
    Public PLC_Tumbler_Download_OK As Boolean = False

    Public PLC_PC_Data_Sent As Boolean
    Public PLC_Request_PC_Data As Boolean
    Public PLC_First_Recipe_Data As Boolean
    Public PLC_First_Recipe_Done As Boolean

    ' updated by PLC subscriber
    Public PLC_Sta14_Print_Start As Boolean
    Public PLC_Sta14_Print_Data_Sent As Boolean
    Public PLC_Sta14_Print_Done As Boolean
    Public PLC_Sta14_Print_Error As Boolean

    ' updated by PLC subscriber
    Public PLC_Sta17_Print_Start As Boolean
    Public PLC_Sta17_Print_Data_Sent As Boolean
    Public PLC_Sta17_Print_Done As Boolean
    Public PLC_Sta17_Print_Error As Boolean

    ' updated by PLC subscriber
    Public PLC_00_Recipe_Manual_Load_Keys As Boolean
    Public PLC_01_Recipe_Keyed_Alike As Boolean
    Public PLC_02_Recipe_Auto_Unload_at_Sta17 As Boolean
    Public PLC_03_Recipe_Load_Flex_Ace_at_Sta02 As Boolean
    Public PLC_04_Recipe_Enable_Sta03 As Boolean
    Public PLC_05_Recipe_Enable_Sta04 As Boolean
    Public PLC_06_Recipe_Enable_Sta05 As Boolean
    Public PLC_07_Recipe_Enable_Sta06 As Boolean
    Public PLC_08_Recipe_Enable_Sta07 As Boolean
    Public PLC_09_Recipe_Enable_Sta08 As Boolean
    Public PLC_10_Recipe_Enable_Sta09 As Boolean
    Public PLC_11_Recipe_Enable_Sta10 As Boolean
    Public PLC_12_Recipe_Enable_Sta11 As Boolean
    Public PLC_13_Recipe_Enable_Sta12 As Boolean
    Public PLC_14_Recipe_Enable_Sta13 As Boolean
    Public PLC_15_Recipe_Mark_Top_of_Barrel As Boolean
    Public PLC_16_Recipe_Enable_Sta15 As Boolean
    Public PLC_17_Recipe_Leave_key_in_After_Test As Boolean
    Public PLC_18_Recipe_Enable_Sta16 As Boolean
    Public PLC_19_Recipe_Mark_Side_of_Barrel As Boolean
    Public PLC_20_Recipe_Use_Master_Key_Scenario As Boolean
    Public PLC_21_Recipe_KeyTest_Finish_Angle As Decimal
    Public PLC_22_Recipe_KeyTest_Start_Angle As Decimal
    Public PLC_23_Recipe_KeyTest_Test_Angle As Decimal
    Public PLC_24_Recipe_Batch_Quantity As Integer
    Public PLC_25_Recipe_Batch_Key_Que As Integer

    Public PLC_KeyCode_Digit_1 As Integer
    Public PLC_KeyCode_Digit_2 As Integer
    Public PLC_KeyCode_Digit_3 As Integer
    Public PLC_KeyCode_Digit_4 As Integer
    Public PLC_KeyCode_Digit_5 As Integer
    Public PLC_KeyCode_Digit_6 As Integer
    Public PLC_KeyCode_Digit_7 As Integer
    Public PLC_KeyCode_Digit_8 As Integer

    Public PLC_Sta06_SpringCode_Digit_1 As Integer
    Public PLC_Sta06_SpringCode_Digit_2 As Integer
    Public PLC_Sta06_SpringCode_Digit_3 As Integer
    Public PLC_Sta06_SpringCode_Digit_4 As Integer
    Public PLC_Sta06_SpringCode_Digit_5 As Integer
    Public PLC_Sta06_SpringCode_Digit_6 As Integer
    Public PLC_Sta06_SpringCode_Digit_7 As Integer

    Public PLC_Sta07_TumberCode_Digit_1 As Integer
    Public PLC_Sta07_TumberCode_Digit_2 As Integer
    Public PLC_Sta07_TumberCode_Digit_3 As Integer
    Public PLC_Sta07_TumberCode_Digit_4 As Integer
    Public PLC_Sta07_TumberCode_Digit_5 As Integer
    Public PLC_Sta07_TumberCode_Digit_6 As Integer
    Public PLC_Sta07_TumberCode_Digit_7 As Integer

    Public PLC_Sta08_TumberCode_Digit_1 As Integer
    Public PLC_Sta08_TumberCode_Digit_2 As Integer
    Public PLC_Sta08_TumberCode_Digit_3 As Integer
    Public PLC_Sta08_TumberCode_Digit_4 As Integer
    Public PLC_Sta08_TumberCode_Digit_5 As Integer
    Public PLC_Sta08_TumberCode_Digit_6 As Integer
    Public PLC_Sta08_TumberCode_Digit_7 As Integer

    Public PLC_Sta10_TumberCode_Digit_1 As Integer
    Public PLC_Sta10_TumberCode_Digit_2 As Integer
    Public PLC_Sta10_TumberCode_Digit_3 As Integer
    Public PLC_Sta10_TumberCode_Digit_4 As Integer
    Public PLC_Sta10_TumberCode_Digit_5 As Integer
    Public PLC_Sta10_TumberCode_Digit_6 As Integer
    Public PLC_Sta10_TumberCode_Digit_7 As Integer

    Public PLC_Sta12_TumberCode_Digit_1 As Integer
    Public PLC_Sta12_TumberCode_Digit_2 As Integer
    Public PLC_Sta12_TumberCode_Digit_3 As Integer
    Public PLC_Sta12_TumberCode_Digit_4 As Integer
    Public PLC_Sta12_TumberCode_Digit_5 As Integer
    Public PLC_Sta12_TumberCode_Digit_6 As Integer
    Public PLC_Sta12_TumberCode_Digit_7 As Integer
    Public PLC_Sta12_TumberCode_Digit_8 As Integer

    Dim PLC_list As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    'PLC DINT to store key Code for PanelView
    Dim Print_Code(3) As Integer

    Dim msg As String
    Dim caption As String
    Dim result
    Dim error_count As Integer = 0
    Dim success As Boolean
    Dim i As Integer = 0

    Dim PLC_addr As String
    Dim PLC_value As String
    Dim var As Object

    Public PLC_Tumbler_Tags As New List(Of String) From {
        "A_KeyCode_Digit_1",
        "A_KeyCode_Digit_2",
        "A_KeyCode_Digit_3",
        "A_KeyCode_Digit_4",
        "A_KeyCode_Digit_5",
        "A_KeyCode_Digit_6",
        "A_KeyCode_Digit_7",
        "A_KeyCode_Digit_8",
        "A_Sta06_SpringCode_Digit_1",
        "A_Sta06_SpringCode_Digit_2",
        "A_Sta06_SpringCode_Digit_3",
        "A_Sta06_SpringCode_Digit_4",
        "A_Sta06_SpringCode_Digit_5",
        "A_Sta06_SpringCode_Digit_6",
        "A_Sta06_SpringCode_Digit_7",
        "A_Sta07_TumberCode_Digit_1",
        "A_Sta07_TumberCode_Digit_2",
        "A_Sta07_TumberCode_Digit_3",
        "A_Sta07_TumberCode_Digit_4",
        "A_Sta07_TumberCode_Digit_5",
        "A_Sta07_TumberCode_Digit_6",
        "A_Sta07_TumberCode_Digit_7",
        "A_Sta08_TumberCode_Digit_1",
        "A_Sta08_TumberCode_Digit_2",
        "A_Sta08_TumberCode_Digit_3",
        "A_Sta08_TumberCode_Digit_4",
        "A_Sta08_TumberCode_Digit_5",
        "A_Sta08_TumberCode_Digit_6",
        "A_Sta08_TumberCode_Digit_7",
        "A_Sta10_TumberCode_Digit_1",
        "A_Sta10_TumberCode_Digit_2",
        "A_Sta10_TumberCode_Digit_3",
        "A_Sta10_TumberCode_Digit_4",
        "A_Sta10_TumberCode_Digit_5",
        "A_Sta10_TumberCode_Digit_6",
        "A_Sta10_TumberCode_Digit_7",
        "A_Sta12_TumberCode_Digit_1",
        "A_Sta12_TumberCode_Digit_2",
        "A_Sta12_TumberCode_Digit_3",
        "A_Sta12_TumberCode_Digit_4",
        "A_Sta12_TumberCode_Digit_5",
        "A_Sta12_TumberCode_Digit_6",
        "A_Sta12_TumberCode_Digit_7",
        "A_Sta12_TumberCode_Digit_8"}

    Public EthernetComErrorCount As Integer

    ' =====================================================================
    ' Send Recipe to PLC 
    ' =====================================================================
    Public Function WriteRecipeToPLC() As Boolean
        Dim count As Integer = 0
        Dim commlog As String = ""

        caption = "Write to PLC"

        ' this is gonna take a few ...
        Wait_Message_Form.Message_TextBox.Text = "Writing to PLC." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Load keys and Master Key
        Dim Manual_Load_Keys As Integer
        If (My.Settings.Sta_1_Load_Keys = "0") Or
            (My.Settings.Sta_1_Load_Keys = "1") Then
            Manual_Load_Keys = My.Settings.Sta_1_Load_Keys
        ElseIf (My.Settings.Sta_1_Load_Keys = "2") Then

        End If

        'build a list of PLC tags and values
        PLC_list.Clear()

        'GoTo Print_Code

        PLC_list.Add(New KeyValuePair(Of String, String)("A_00_Recipe_Manual_Load_Keys", Manual_Load_Keys))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_01_Recipe_Keyed_Alike", My.Settings.Sta_1_Keyed))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_02_Recipe_Auto_Unload_at_Sta17", My.Settings.Sta_1_Unload))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_03_Recipe_Load_Flex_Ace_at_Sta02", My.Settings.Sta_2_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_04_Recipe_Enable_Sta03", My.Settings.Sta_3_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_05_Recipe_Enable_Sta04", My.Settings.Sta_4_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_06_Recipe_Enable_Sta05", My.Settings.Sta_5_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_07_Recipe_Enable_Sta06", My.Settings.Sta_6_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_08_Recipe_Enable_Sta07", My.Settings.Sta_7_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_09_Recipe_Enable_Sta08", My.Settings.Sta_8_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_10_Recipe_Enable_Sta09", My.Settings.Sta_9_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_11_Recipe_Enable_Sta10", My.Settings.Sta_10_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_12_Recipe_Enable_Sta11", My.Settings.Sta_11_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_13_Recipe_Enable_Sta12", My.Settings.Sta_12_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_14_Recipe_Enable_Sta13", My.Settings.Sta_13_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_15_Recipe_Mark_Top_of_Barrel", My.Settings.Sta_14_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_16_Recipe_Enable_Sta15", My.Settings.Sta_15_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_17_Recipe_Leave_key_in_After_Test", My.Settings.Sta_15_Leave_Key))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_18_Recipe_Enable_Sta16", My.Settings.Sta_16_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_19_Recipe_Mark_Side_of_Barrel", My.Settings.Sta_17_Enable))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_20_Recipe_Use_Master_Key_Scenario", My.Settings.Master_Key_Scenario))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_21_Recipe_KeyTest_Finish_Angle", My.Settings.Sta_15_Finish_Angle))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_22_Recipe_KeyTest_Start_Angle", My.Settings.Sta_15_Insert_Angle))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_23_Recipe_KeyTest_Test_Angle", My.Settings.Sta_15_Test_Angle))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_24_Recipe_Batch_Quantity", My.Settings.Key_Qty))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_25_Recipe_Batch_Key_Que", 0))

        error_count = 0

        i = 0
        ' send value to each PLC address in list
        For Each PLC_pair As KeyValuePair(Of String, String) In PLC_list
            success = False
            i += 1
            Wait_Message_Form.Message_TextBox.Text = "Writing item " & i & " to PLC." & vbCrLf & PLC_pair.Key & vbCrLf & "Please wait ..."
            Wait_Message_Form.Update()
            System.Windows.Forms.Application.DoEvents()

            Do Until success
                Try
                    PLC_addr = PLC_pair.Key
                    PLC_value = PLC_pair.Value
                    var = 0

                    'prepare the argument before writing
                    If PLC_pair.Value Is Nothing Then
                        'nothing
                        var = -999
                        error_count += 1
                        commlog = commlog & vbCrLf & "Error : " & vbTab & PLC_pair.Key & vbTab & PLC_pair.Value

                    ElseIf Left(PLC_pair.Key, 2) = "A_" And
                        Left(PLC_pair.Key, 4) <> "A_21" And
                        Left(PLC_pair.Key, 4) <> "A_22" And
                        Left(PLC_pair.Key, 4) <> "A_23" Then

                        'boolean / integer
                        var = CInt(PLC_pair.Value)
                    ElseIf Left(PLC_pair.Key, 5) = "Print" Then
                        ' integer
                        var = CInt(PLC_pair.Value)
                    Else
                        'decimal
                        var = CDec(PLC_pair.Value)
                    End If

                    If var <> -999 Then
                        MainMenu.EthernetIPforCLXCom1.Write(PLC_pair.Key, var)
                        count += 1
                    End If
                    success = True
                Catch ex As Exception
                    PLC_Comms_OK = False
                    error_count += 1
                    commlog = commlog & vbCrLf & "Error : " & vbTab & PLC_pair.Key & vbTab & PLC_pair.Value

                    msg = String.Format("Cannot Write to PLC address: " & PLC_pair.Key & " = " & PLC_pair.Value & vbCrLf, ex.Message)
                    result = MessageBox.Show(String.Format(msg),
                                                caption,
                                                MessageBoxButtons.AbortRetryIgnore,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button2)

                    If result = System.Windows.Forms.DialogResult.Abort Then
                        Wait_Message_Form.Close()
                        PLC_Recipe_Download_OK = False
                        MainMenu.Recipe_Download_Status_Label.BackColor = Color.Yellow
                        MainMenu.Recipe_Download_Status_Label.Text = "Recipe Download failed"

                        Return PLC_Recipe_Download_OK
                    ElseIf result = System.Windows.Forms.DialogResult.Retry Then
                        success = False
                    ElseIf result = System.Windows.Forms.DialogResult.Ignore Then
                        success = True
                    End If
                End Try
            Loop
            Threading.Thread.Sleep(5)
        Next

        'Record if download was good
        PLC_Recipe_Download_OK = (error_count = 0)

        ' Done, Close up
        msg = String.Format("Total of " & i & " items written to PLC")

        If PLC_Recipe_Download_OK Then
            'msg = msg & vbCrLf & "No Transmission Errors"
            MainMenu.Recipe_Button.BackColor = Color.Green
            'MessageBox.Show(msg,
            '            caption,
            '            MessageBoxButtons.OK,
            '            MessageBoxIcon.Information)
            MainMenu.Recipe_Download_Status_Label.BackColor = Color.Green
            MainMenu.Recipe_Download_Status_Label.Text = "Recipe Download OK"
        Else
            MainMenu.Recipe_Button.BackColor = Color.Yellow
            msg = msg & vbCrLf & "Total Transmission Errors: " & error_count & vbCrLf & commlog

            MessageBox.Show(msg,
                        caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation)
            MainMenu.Recipe_Download_Status_Label.BackColor = Color.Yellow
            MainMenu.Recipe_Download_Status_Label.Text = "Recipe Download failed"
        End If

        Wait_Message_Form.Close()
    End Function

    ' =======================================================================
    ' Write Tumblers to PLC
    ' =======================================================================
    Public Sub WriteTumblersToPLC()
        Dim count As Integer = 0
        Dim error_log As String = ""

        PLC_Tumbler_Download_OK = False
        MainMenu.Tumbler_Download_Status_Label.BackColor = Color.Yellow
        MainMenu.Tumbler_Download_Status_Label.Text = "Tumbler Code download failed"

        ' tell user this is gonna take a few ...
        Wait_Message_Form.Message_TextBox.Text = "Writing to PLC." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Load keys and Master Key
        'build a list of PLC tags and values
        PLC_list.Clear()

        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_1", Tumbler_1_Code))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_2", Tumbler_2_Code))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_3", Tumbler_3_Code))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_4", Tumbler_4_Code))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_5", Tumbler_5_Code))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_6", Tumbler_6_Code))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_7", Tumbler_7_Code))
        'PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_8", Tumbler_8_Code))

        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_1", My.Settings.Spring1_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_2", My.Settings.Spring2_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_3", My.Settings.Spring3_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_4", My.Settings.Spring4_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_5", My.Settings.Spring5_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_6", My.Settings.Spring6_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_7", My.Settings.Spring7_Bowl))

        'PLC_list.Add(New KeyValuePair(Of String, String)("A_24_Recipe_Batch_Quantity", My.Settings.Key_Qty))
        'PLC_list.Add(New KeyValuePair(Of String, String)("A_25_Recipe_Batch_Key_Que", 0))

        '===================================================
        'My.Settings.Stepped_x is string with either 0 or 1 as boolean
        'Bowl = Bowl number
        'If = 1 then 
        '   assign the bowl to station 7 (Stepped Tumblers) 
        '   Set station 8 Bowl number = 0
        'Else assign the bowl to station 8 (Bottom Tumblers) 
        '   Set station 7 Bowl number = 0
        '===================================================

        If My.Settings.Stepped_1 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_1", My.Settings.Stepped1_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_1", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_1", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_1", My.Settings.Bot1_Bowl))
        End If

        If My.Settings.Stepped_2 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_2", My.Settings.Stepped2_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_2", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_2", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_2", My.Settings.Bot2_Bowl))
        End If

        If My.Settings.Stepped_3 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_3", My.Settings.Stepped3_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_3", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_3", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_3", My.Settings.Bot3_Bowl))
        End If

        If My.Settings.Stepped_4 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_4", My.Settings.Stepped4_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_4", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_4", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_4", My.Settings.Bot4_Bowl))
        End If

        If My.Settings.Stepped_5 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_5", My.Settings.Stepped5_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_5", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_5", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_5", My.Settings.Bot5_Bowl))
        End If

        If My.Settings.Stepped_6 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_6", My.Settings.Stepped6_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_6", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_6", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_6", My.Settings.Bot6_Bowl))
        End If

        If My.Settings.Stepped_7 = "1" Then
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_7", My.Settings.Stepped7_Bowl))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_7", "0"))
        Else
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_7", "0"))
            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_7", My.Settings.Bot7_Bowl))
        End If

        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_1", My.Settings.Mid1_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_2", My.Settings.Mid2_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_3", My.Settings.Mid3_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_4", My.Settings.Mid4_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_5", My.Settings.Mid5_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_6", My.Settings.Mid6_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_7", My.Settings.Mid7_Bowl))

        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_1", My.Settings.Top1_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_2", My.Settings.Top2_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_3", My.Settings.Top3_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_4", My.Settings.Top4_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_5", My.Settings.Top5_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_6", My.Settings.Top6_Bowl))
        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_7", My.Settings.Top7_Bowl))
        'PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_8", My.Settings.Top8_Bowl))

        Convert_KeySeries()

Print_Code:
        PLC_list.Add(New KeyValuePair(Of String, String)("Print_Code_1", CStr(Print_Code(0))))
        PLC_list.Add(New KeyValuePair(Of String, String)("Print_Code_2", CStr(Print_Code(1))))
        PLC_list.Add(New KeyValuePair(Of String, String)("Print_Code_3", CStr(Print_Code(2))))

        error_count = 0

        ' send value to each PLC address in list
        For Each PLC_pair As KeyValuePair(Of String, String) In PLC_list
            success = False
            i += 1
            Wait_Message_Form.Message_TextBox.Text = "Writing item " & i & " to PLC." & vbCrLf & PLC_pair.Key & vbCrLf & "Please wait ..."
            Wait_Message_Form.Update()
            System.Windows.Forms.Application.DoEvents()

            Do Until success
                Try
                    PLC_addr = PLC_pair.Key
                    PLC_value = PLC_pair.Value
                    var = 0

                    'prepare the argument before writing
                    If PLC_pair.Value Is Nothing Then
                        'nothing
                        var = -1
                        error_count += 1
                        error_log = error_log & vbCrLf & PLC_pair.Key & " = " & PLC_pair.Value

                    ElseIf Left(PLC_pair.Key, 2) = "A_" And
                        Left(PLC_pair.Key, 4) <> "A_21" And
                        Left(PLC_pair.Key, 4) <> "A_22" And
                        Left(PLC_pair.Key, 4) <> "A_23" Then

                        'boolean / integer
                        var = CInt(PLC_pair.Value)
                    ElseIf Left(PLC_pair.Key, 5) = "Print" Then
                        ' integer
                        var = CInt(PLC_pair.Value)
                    Else
                        'decimal
                        var = CDec(PLC_pair.Value)
                    End If

                    If var > -1 Then
                        MainMenu.EthernetIPforCLXCom1.Write(PLC_pair.Key, var)
                        count += 1
                    End If
                    success = True
                Catch ex As Exception
                    PLC_Comms_OK = False
                    error_count += 1
                    error_log = error_log & vbCrLf & PLC_pair.Key & " = " & PLC_pair.Value

                    caption = "Write to PLC"
                    msg = String.Format("Cannot Write to PLC address: " & PLC_pair.Key & " = " & PLC_pair.Value & vbCrLf, ex.Message)
                    result = MessageBox.Show(String.Format(msg),
                                                caption,
                                                MessageBoxButtons.AbortRetryIgnore,
                                                MessageBoxIcon.Exclamation,
                                                MessageBoxDefaultButton.Button2)

                    If result = System.Windows.Forms.DialogResult.Abort Then
                        Wait_Message_Form.Close()
                        PLC_Tumbler_Download_OK = False
                        MainMenu.Tumbler_Download_Status_Label.BackColor = Color.Yellow
                        MainMenu.Tumbler_Download_Status_Label.Text = "Tumbler Code download failed"

                        Exit Sub
                    ElseIf result = System.Windows.Forms.DialogResult.Retry Then
                        success = False
                    ElseIf result = System.Windows.Forms.DialogResult.Ignore Then
                        success = True
                    End If
                End Try
            Loop
            Threading.Thread.Sleep(5)
        Next

        'Record if download was good
        PLC_Tumbler_Download_OK = (error_count = 0)

        ' Done, Close up
        caption = "Write to PLC"
        msg = String.Format("Total of " & i & " items written to PLC")
        If error_count = 0 Then
            'msg = msg & vbCrLf & "No Transmission Errors"
            'result = MessageBox.Show(String.Format(msg),
            '                    caption,
            '                    MessageBoxButtons.OK,
            '                    MessageBoxIcon.Information)
            MainMenu.Tumbler_Download_Status_Label.BackColor = Color.Green
            MainMenu.Tumbler_Download_Status_Label.Text = "Tumbler Code OK"
        Else
            msg = msg & vbCrLf & "Total Transmission Errors: " & error_count
            result = MessageBox.Show(msg & vbCrLf & error_log,
                                    caption,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation)
        End If
        Wait_Message_Form.Close()
    End Sub

    '=====================================================================
    ' Convert Key Series to ASCII for PLC
    '=====================================================================
    Public Sub Convert_KeySeries()
        'KeyCode = string = K1 & K2 & K3 & K4 & K5 & K6 & K7 & K8 & K9 & K10
        'PanelView wants a DINT array 
        Dim K_Series(12) As Integer

        'initialize values = 0
        For i = 0 To Key_Series.Length - 1
            K_Series(i) = 0
        Next
        ' pack Key Series digits into DINT as ASCII characters
        For i = 0 To Key_Series.Length - 1
            K_Series(i) = Asc(Key_Series.Substring(i, 1))
            K_Series(i) = K_Series(i) << ((3 - i Mod 4) * 8)
        Next

        Print_Code(0) = K_Series(0) Or K_Series(1) Or K_Series(2) Or K_Series(3)
        Print_Code(1) = K_Series(4) Or K_Series(5) Or K_Series(6) Or K_Series(7)
        Print_Code(2) = K_Series(8) Or K_Series(9) Or K_Series(10) Or K_Series(11)
    End Sub

    ' =======================================================================
    ' Read Tumblers from PLC
    ' =======================================================================
    Public Sub ReadTumblerCodesFromPLC()
        Dim count As Integer = 0
        Dim success As Boolean = False
        Dim response As String = ""
        Dim val_bool As Boolean
        Dim val_dint As Integer
        Dim val_real As Decimal

        Wait_Message_Form.Message_TextBox.Text = "Reading from PLC." & vbCrLf & "Please wait ..." & vbCrLf & count
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        Threading.Thread.Sleep(2)
        'System.Windows.Forms.Application.DoEvents()


        For Each address In PLC_Tumbler_Tags
            success = False
            'Dim var As String

            Do Until success
                Try
                    response = MainMenu.EthernetIPforCLXCom1.Read(address)
                    count += 1

                    Threading.Thread.Sleep(5)
                    'System.Windows.Forms.Application.DoEvents()
                    Wait_Message_Form.Message_TextBox.Text = "Reading from PLC." & vbCrLf & "Please wait ..." & vbCrLf & count
                    Wait_Message_Form.Update()

                    'convert string to data
                    val_bool = CBool(response)
                    val_dint = CInt(response)
                    val_real = CDec(response)

                    If address = "A_00_Recipe_Manual_Load_Keys" Then
                        PLC_00_Recipe_Manual_Load_Keys = val_bool
                    ElseIf address = "A_01_Recipe_Keyed_Alike" Then
                        PLC_01_Recipe_Keyed_Alike = val_bool
                    ElseIf address = "A_02_Recipe_Auto_Unload_at_Sta17" Then
                        PLC_02_Recipe_Auto_Unload_at_Sta17 = val_bool
                    ElseIf address = "A_03_Recipe_Load_Flex_Ace_at_Sta02" Then
                        PLC_03_Recipe_Load_Flex_Ace_at_Sta02 = val_bool
                    ElseIf address = "A_04_Recipe_Enable_Sta03" Then
                        PLC_04_Recipe_Enable_Sta03 = val_bool
                    ElseIf address = "A_05_Recipe_Enable_Sta04" Then
                        PLC_05_Recipe_Enable_Sta04 = val_bool
                    ElseIf address = "A_06_Recipe_Enable_Sta05" Then
                        PLC_06_Recipe_Enable_Sta05 = val_bool
                    ElseIf address = "A_07_Recipe_Enable_Sta06" Then
                        PLC_07_Recipe_Enable_Sta06 = val_bool
                    ElseIf address = "A_08_Recipe_Enable_Sta07" Then
                        PLC_08_Recipe_Enable_Sta07 = val_bool
                    ElseIf address = "A_09_Recipe_Enable_Sta08" Then
                        PLC_09_Recipe_Enable_Sta08 = val_bool
                    ElseIf address = "A_10_Recipe_Enable_Sta09" Then
                        PLC_10_Recipe_Enable_Sta09 = val_bool
                    ElseIf address = "A_11_Recipe_Enable_Sta10" Then
                        PLC_11_Recipe_Enable_Sta10 = val_bool
                    ElseIf address = "A_12_Recipe_Enable_Sta11" Then
                        PLC_12_Recipe_Enable_Sta11 = val_bool
                    ElseIf address = "A_13_Recipe_Enable_Sta12" Then
                        PLC_13_Recipe_Enable_Sta12 = val_bool
                    ElseIf address = "A_14_Recipe_Enable_Sta13" Then
                        PLC_14_Recipe_Enable_Sta13 = val_bool
                    ElseIf address = "A_15_Recipe_Mark_Top_of_Barrel" Then
                        PLC_15_Recipe_Mark_Top_of_Barrel = val_bool
                    ElseIf address = "A_16_Recipe_Enable_Sta15" Then
                        PLC_16_Recipe_Enable_Sta15 = val_bool
                    ElseIf address = "A_17_Recipe_Leave_key_in_After_Test" Then
                        PLC_17_Recipe_Leave_key_in_After_Test = val_bool
                    ElseIf address = "A_18_Recipe_Enable_Sta16" Then
                        PLC_18_Recipe_Enable_Sta16 = val_bool
                    ElseIf address = "A_19_Recipe_Mark_Side_of_Barrel" Then
                        PLC_19_Recipe_Mark_Side_of_Barrel = val_bool
                    ElseIf address = "A_20_Recipe_Use_Master_Key_Scenario" Then
                        PLC_20_Recipe_Use_Master_Key_Scenario = val_bool
                    ElseIf address = "A_21_Recipe_KeyTest_Finish_Angle" Then
                        PLC_21_Recipe_KeyTest_Finish_Angle = val_real
                    ElseIf address = "A_22_Recipe_KeyTest_Start_Angle" Then
                        PLC_22_Recipe_KeyTest_Start_Angle = val_real
                    ElseIf address = "A_23_Recipe_KeyTest_Test_Angle" Then
                        PLC_23_Recipe_KeyTest_Test_Angle = val_real
                    ElseIf address = "A_24_Recipe_Batch_Quantity" Then
                        PLC_24_Recipe_Batch_Quantity = val_dint
                    ElseIf address = "A_25_Recipe_Batch_Key_Que" Then
                        PLC_25_Recipe_Batch_Key_Que = val_dint
                    ElseIf address = "A_KeyCode_Digit_1" Then
                        PLC_KeyCode_Digit_1 = val_dint
                    ElseIf address = "A_KeyCode_Digit_2" Then
                        PLC_KeyCode_Digit_2 = val_dint
                    ElseIf address = "A_KeyCode_Digit_3" Then
                        PLC_KeyCode_Digit_3 = val_dint
                    ElseIf address = "A_KeyCode_Digit_4" Then
                        PLC_KeyCode_Digit_4 = val_dint
                    ElseIf address = "A_KeyCode_Digit_5" Then
                        PLC_KeyCode_Digit_5 = val_dint
                    ElseIf address = "A_KeyCode_Digit_6" Then
                        PLC_KeyCode_Digit_6 = val_dint
                    ElseIf address = "A_KeyCode_Digit_7" Then
                        PLC_KeyCode_Digit_7 = val_dint
                    ElseIf address = "A_KeyCode_Digit_8" Then
                        PLC_KeyCode_Digit_8 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_1" Then
                        PLC_Sta06_SpringCode_Digit_1 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_2" Then
                        PLC_Sta06_SpringCode_Digit_2 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_3" Then
                        PLC_Sta06_SpringCode_Digit_3 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_4" Then
                        PLC_Sta06_SpringCode_Digit_4 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_5" Then
                        PLC_Sta06_SpringCode_Digit_5 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_6" Then
                        PLC_Sta06_SpringCode_Digit_6 = val_dint
                    ElseIf address = "A_Sta06_SpringCode_Digit_7" Then
                        PLC_Sta06_SpringCode_Digit_7 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_1" Then
                        PLC_Sta07_TumberCode_Digit_1 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_2" Then
                        PLC_Sta07_TumberCode_Digit_2 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_3" Then
                        PLC_Sta07_TumberCode_Digit_3 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_4" Then
                        PLC_Sta07_TumberCode_Digit_4 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_5" Then
                        PLC_Sta07_TumberCode_Digit_5 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_6" Then
                        PLC_Sta07_TumberCode_Digit_6 = val_dint
                    ElseIf address = "A_Sta07_TumberCode_Digit_7" Then
                        PLC_Sta07_TumberCode_Digit_7 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_1" Then
                        PLC_Sta08_TumberCode_Digit_1 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_2" Then
                        PLC_Sta08_TumberCode_Digit_2 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_3" Then
                        PLC_Sta08_TumberCode_Digit_3 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_4" Then
                        PLC_Sta08_TumberCode_Digit_4 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_5" Then
                        PLC_Sta08_TumberCode_Digit_5 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_6" Then
                        PLC_Sta08_TumberCode_Digit_6 = val_dint
                    ElseIf address = "A_Sta08_TumberCode_Digit_7" Then
                        PLC_Sta08_TumberCode_Digit_7 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_1" Then
                        PLC_Sta10_TumberCode_Digit_1 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_2" Then
                        PLC_Sta10_TumberCode_Digit_2 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_3" Then
                        PLC_Sta10_TumberCode_Digit_3 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_4" Then
                        PLC_Sta10_TumberCode_Digit_4 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_5" Then
                        PLC_Sta10_TumberCode_Digit_5 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_6" Then
                        PLC_Sta10_TumberCode_Digit_6 = val_dint
                    ElseIf address = "A_Sta10_TumberCode_Digit_7" Then
                        PLC_Sta10_TumberCode_Digit_7 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_1" Then
                        PLC_Sta12_TumberCode_Digit_1 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_2" Then
                        PLC_Sta12_TumberCode_Digit_2 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_3" Then
                        PLC_Sta12_TumberCode_Digit_3 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_4" Then
                        PLC_Sta12_TumberCode_Digit_4 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_5" Then
                        PLC_Sta12_TumberCode_Digit_5 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_6" Then
                        PLC_Sta12_TumberCode_Digit_6 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_7" Then
                        PLC_Sta12_TumberCode_Digit_7 = val_dint
                    ElseIf address = "A_Sta12_TumberCode_Digit_8" Then
                        PLC_Sta12_TumberCode_Digit_8 = val_dint
                    End If

                    'Threading.Thread.Sleep(5)
                    success = True

                Catch ex As Exception
                    Dim msg As String = String.Format("Cannot read from PLC address: " & address & vbCrLf, ex.Message)
                    Dim caption As String = "Read from PLC"
                    Dim result = MessageBox.Show(String.Format(msg),
                                            caption,
                                            MessageBoxButtons.AbortRetryIgnore,
                                            MessageBoxIcon.Exclamation,
                                            MessageBoxDefaultButton.Button2)

                    If result = System.Windows.Forms.DialogResult.Abort Then
                        'punt the entire evolution
                        Wait_Message_Form.Close()
                        Exit Sub
                    ElseIf result = System.Windows.Forms.DialogResult.Retry Then
                        'try again
                    ElseIf result = System.Windows.Forms.DialogResult.Ignore Then
                        'punt this tag
                        Exit Do
                    End If
                End Try
            Loop
        Next
        Wait_Message_Form.Close()

    End Sub

    ' =======================================================================
    ' Verify Tumblers Download
    ' =======================================================================
    Public Function Verify_Tumbler_Download() As Boolean

        Wait_Message_Form.Text = "Verify Tumbler Download"
        Wait_Message_Form.Show()
        Try
            Dim A_KC_1_Verified = (PLC_KeyCode_Digit_1 = CInt(Tumbler_1_Code))
            Dim A_KC_2_Verified = (PLC_KeyCode_Digit_2 = CInt(Tumbler_2_Code))
            Dim A_KC_3_Verified = (PLC_KeyCode_Digit_3 = CInt(Tumbler_3_Code))
            Dim A_KC_4_Verified = (PLC_KeyCode_Digit_4 = CInt(Tumbler_4_Code))
            Dim A_KC_5_Verified = (PLC_KeyCode_Digit_5 = CInt(Tumbler_5_Code))
            Dim A_KC_6_Verified = (PLC_KeyCode_Digit_6 = CInt(Tumbler_6_Code))
            Dim A_KC_7_Verified = (PLC_KeyCode_Digit_7 = CInt(Tumbler_7_Code))

            Dim A_Sta06_1_Verified = (PLC_Sta06_SpringCode_Digit_1 = CInt(My.Settings.Spring1_Bowl))
            Dim A_Sta06_2_Verified = (PLC_Sta06_SpringCode_Digit_2 = CInt(My.Settings.Spring2_Bowl))
            Dim A_Sta06_3_Verified = (PLC_Sta06_SpringCode_Digit_3 = CInt(My.Settings.Spring3_Bowl))
            Dim A_Sta06_4_Verified = (PLC_Sta06_SpringCode_Digit_4 = CInt(My.Settings.Spring4_Bowl))
            Dim A_Sta06_5_Verified = (PLC_Sta06_SpringCode_Digit_5 = CInt(My.Settings.Spring5_Bowl))
            Dim A_Sta06_6_Verified = (PLC_Sta06_SpringCode_Digit_6 = CInt(My.Settings.Spring6_Bowl))
            Dim A_Sta06_7_Verified = (PLC_Sta06_SpringCode_Digit_7 = CInt(My.Settings.Spring7_Bowl))

            Dim A_Sta07_1_Verified = (PLC_Sta07_TumberCode_Digit_1 = CInt(My.Settings.Stepped_1))
            Dim A_Sta07_2_Verified = (PLC_Sta07_TumberCode_Digit_2 = CInt(My.Settings.Stepped_2))
            Dim A_Sta07_3_Verified = (PLC_Sta07_TumberCode_Digit_3 = CInt(My.Settings.Stepped_3))
            Dim A_Sta07_4_Verified = (PLC_Sta07_TumberCode_Digit_4 = CInt(My.Settings.Stepped_4))
            Dim A_Sta07_5_Verified = (PLC_Sta07_TumberCode_Digit_5 = CInt(My.Settings.Stepped_5))
            Dim A_Sta07_6_Verified = (PLC_Sta07_TumberCode_Digit_6 = CInt(My.Settings.Stepped_6))
            Dim A_Sta07_7_Verified = (PLC_Sta07_TumberCode_Digit_7 = CInt(My.Settings.Stepped_7))

            Dim A_Sta08_1_Verified = (PLC_Sta08_TumberCode_Digit_1 = CInt(My.Settings.Bot1_Bowl))
            Dim A_Sta08_2_Verified = (PLC_Sta08_TumberCode_Digit_2 = CInt(My.Settings.Bot2_Bowl))
            Dim A_Sta08_3_Verified = (PLC_Sta08_TumberCode_Digit_3 = CInt(My.Settings.Bot3_Bowl))
            Dim A_Sta08_4_Verified = (PLC_Sta08_TumberCode_Digit_4 = CInt(My.Settings.Bot4_Bowl))
            Dim A_Sta08_5_Verified = (PLC_Sta08_TumberCode_Digit_5 = CInt(My.Settings.Bot5_Bowl))
            Dim A_Sta08_6_Verified = (PLC_Sta08_TumberCode_Digit_6 = CInt(My.Settings.Bot6_Bowl))
            Dim A_Sta08_7_Verified = (PLC_Sta08_TumberCode_Digit_7 = CInt(My.Settings.Bot7_Bowl))

            Dim A_Sta10_1_Verified = (PLC_Sta10_TumberCode_Digit_1 = CInt(My.Settings.Mid1_Bowl))
            Dim A_Sta10_2_Verified = (PLC_Sta10_TumberCode_Digit_2 = CInt(My.Settings.Mid2_Bowl))
            Dim A_Sta10_3_Verified = (PLC_Sta10_TumberCode_Digit_3 = CInt(My.Settings.Mid3_Bowl))
            Dim A_Sta10_4_Verified = (PLC_Sta10_TumberCode_Digit_4 = CInt(My.Settings.Mid4_Bowl))
            Dim A_Sta10_5_Verified = (PLC_Sta10_TumberCode_Digit_5 = CInt(My.Settings.Mid5_Bowl))
            Dim A_Sta10_6_Verified = (PLC_Sta10_TumberCode_Digit_6 = CInt(My.Settings.Mid6_Bowl))
            Dim A_Sta10_7_Verified = (PLC_Sta10_TumberCode_Digit_7 = CInt(My.Settings.Mid7_Bowl))

            Dim A_Sta12_1_Verified = (PLC_Sta12_TumberCode_Digit_1 = CInt(My.Settings.Top1_Bowl))
            Dim A_Sta12_2_Verified = (PLC_Sta12_TumberCode_Digit_2 = CInt(My.Settings.Top2_Bowl))
            Dim A_Sta12_3_Verified = (PLC_Sta12_TumberCode_Digit_3 = CInt(My.Settings.Top3_Bowl))
            Dim A_Sta12_4_Verified = (PLC_Sta12_TumberCode_Digit_4 = CInt(My.Settings.Top4_Bowl))
            Dim A_Sta12_5_Verified = (PLC_Sta12_TumberCode_Digit_5 = CInt(My.Settings.Top5_Bowl))
            Dim A_Sta12_6_Verified = (PLC_Sta12_TumberCode_Digit_6 = CInt(My.Settings.Top6_Bowl))
            Dim A_Sta12_7_Verified = (PLC_Sta12_TumberCode_Digit_7 = CInt(My.Settings.Top7_Bowl))

            Wait_Message_Form.Close()

            Return A_KC_1_Verified And
            A_KC_2_Verified And
            A_KC_3_Verified And
            A_KC_4_Verified And
            A_KC_5_Verified And
            A_KC_6_Verified And
            A_KC_7_Verified And
            A_Sta06_1_Verified And
            A_Sta06_2_Verified And
            A_Sta06_3_Verified And
            A_Sta06_4_Verified And
            A_Sta06_5_Verified And
            A_Sta06_6_Verified And
            A_Sta06_7_Verified And
            A_Sta07_1_Verified And
            A_Sta07_2_Verified And
            A_Sta07_3_Verified And
            A_Sta07_4_Verified And
            A_Sta07_5_Verified And
            A_Sta07_6_Verified And
            A_Sta07_7_Verified And
            A_Sta08_1_Verified And
            A_Sta08_2_Verified And
            A_Sta08_3_Verified And
            A_Sta08_4_Verified And
            A_Sta08_5_Verified And
            A_Sta08_6_Verified And
            A_Sta08_7_Verified And
            A_Sta10_1_Verified And
            A_Sta10_2_Verified And
            A_Sta10_3_Verified And
            A_Sta10_4_Verified And
            A_Sta10_5_Verified And
            A_Sta10_6_Verified And
            A_Sta10_7_Verified And
            A_Sta12_1_Verified And
            A_Sta12_2_Verified And
            A_Sta12_3_Verified And
            A_Sta12_4_Verified And
            A_Sta12_5_Verified And
            A_Sta12_6_Verified And
            A_Sta12_7_Verified And
            A_Sta12_1_Verified
        Catch
            Return False
        End Try
    End Function
End Module

'Public PLC_Recipe_Tags As New List(Of String) From {"A_00_Recipe_Manual_Load_Keys",
'    "A_01_Recipe_Keyed_Alike",
'    "A_02_Recipe_Auto_Unload_at_Sta17",
'    "A_03_Recipe_Load_Flex_Ace_at_Sta02",
'    "A_04_Recipe_Enable_Sta03",
'    "A_05_Recipe_Enable_Sta04",
'    "A_06_Recipe_Enable_Sta05",
'    "A_07_Recipe_Enable_Sta06",
'    "A_08_Recipe_Enable_Sta07",
'    "A_09_Recipe_Enable_Sta08",
'    "A_10_Recipe_Enable_Sta09",
'    "A_11_Recipe_Enable_Sta10",
'    "A_12_Recipe_Enable_Sta11",
'    "A_13_Recipe_Enable_Sta12",
'    "A_14_Recipe_Enable_Sta13",
'    "A_15_Recipe_Mark_Top_of_Barrel",
'    "A_16_Recipe_Enable_Sta15",
'    "A_17_Recipe_Leave_key_in_After_Test",
'    "A_18_Recipe_Enable_Sta16",
'    "A_19_Recipe_Mark_Side_of_Barrel",
'    "A_20_Recipe_Use_Master_Key_Scenario",
'    "A_21_Recipe_KeyTest_Finish_Angle",
'    "A_22_Recipe_KeyTest_Start_Angle",
'    "A_23_Recipe_KeyTest_Test_Angle",
'    "A_24_Recipe_Batch_Quantity",
'    "A_25_Recipe_Batch_Key_Que",
'    "PLC_KeyCode_Digit_1",
'    "PLC_KeyCode_Digit_2",
'    "PLC_KeyCode_Digit_3",
'    "PLC_KeyCode_Digit_4",
'    "PLC_KeyCode_Digit_5",
'    "PLC_KeyCode_Digit_6",
'    "PLC_KeyCode_Digit_7",
'    "PLC_KeyCode_Digit_8",
'    "PLC_Sta06_SpringCode_Digit_1",
'    "PLC_Sta06_SpringCode_Digit_2",
'    "PLC_Sta06_SpringCode_Digit_3",
'    "PLC_Sta06_SpringCode_Digit_4",
'    "PLC_Sta06_SpringCode_Digit_5",
'    "PLC_Sta06_SpringCode_Digit_6",
'    "PLC_Sta06_SpringCode_Digit_7",
'    "PLC_Sta07_TumberCode_Digit_1",
'    "PLC_Sta07_TumberCode_Digit_2",
'    "PLC_Sta07_TumberCode_Digit_3",
'    "PLC_Sta07_TumberCode_Digit_4",
'    "PLC_Sta07_TumberCode_Digit_5",
'    "PLC_Sta07_TumberCode_Digit_6",
'    "PLC_Sta07_TumberCode_Digit_7",
'    "PLC_Sta08_TumberCode_Digit_1",
'    "PLC_Sta08_TumberCode_Digit_2",
'    "PLC_Sta08_TumberCode_Digit_3",
'    "PLC_Sta08_TumberCode_Digit_4",
'    "PLC_Sta08_TumberCode_Digit_5",
'    "PLC_Sta08_TumberCode_Digit_6",
'    "PLC_Sta08_TumberCode_Digit_7",
'    "PLC_Sta10_TumberCode_Digit_1",
'    "PLC_Sta10_TumberCode_Digit_2",
'    "PLC_Sta10_TumberCode_Digit_3",
'    "PLC_Sta10_TumberCode_Digit_4",
'    "PLC_Sta10_TumberCode_Digit_5",
'    "PLC_Sta10_TumberCode_Digit_6",
'    "PLC_Sta10_TumberCode_Digit_7",
'    "PLC_Sta12_TumberCode_Digit_1",
'    "PLC_Sta12_TumberCode_Digit_2",
'    "PLC_Sta12_TumberCode_Digit_3",
'    "PLC_Sta12_TumberCode_Digit_4",
'    "PLC_Sta12_TumberCode_Digit_5",
'    "PLC_Sta12_TumberCode_Digit_6",
'    "PLC_Sta12_TumberCode_Digit_7",
'    "PLC_Sta12_TumberCode_Digit_8"}



' =====================================================================
' Read Recipe Data from PLC 
' =====================================================================
'Public Sub ReadFromPLC(EthernetIPforCLXCom1)
'    Dim count As Integer = 0
'    Dim success As Boolean = False
'    Dim response As String = ""
'    Dim val_bool As Boolean
'    Dim val_dint As Integer
'    Dim val_real As Decimal

'    Wait_Message_Form.Message_TextBox.Text = "Reading from PLC." & vbCrLf & "Please wait ..."
'    Wait_Message_Form.Show()
'    Wait_Message_Form.Refresh()

'    Threading.Thread.Sleep(25)
'    System.Windows.Forms.Application.DoEvents()


'    For Each address In PLC_Recipe_Tags
'        success = False
'        Dim var As String

'        Do Until success
'            Try
'                response = EthernetIPforCLXCom1.Read(address)
'                count += 1

'                Threading.Thread.Sleep(25)
'                System.Windows.Forms.Application.DoEvents()

'                'convert string to data
'                val_bool = CBool(response)
'                val_dint = CInt(response)
'                val_real = CDec(response)

'                If address = "A_00_Recipe_Manual_Load_Keys" Then
'                    PLC_00_Recipe_Manual_Load_Keys = val_bool
'                ElseIf address = "A_01_Recipe_Keyed_Alike" Then
'                    PLC_01_Recipe_Keyed_Alike = val_bool
'                ElseIf address = "A_02_Recipe_Auto_Unload_at_Sta17" Then
'                    PLC_02_Recipe_Auto_Unload_at_Sta17 = val_bool
'                ElseIf address = "A_03_Recipe_Load_Flex_Ace_at_Sta02" Then
'                    PLC_03_Recipe_Load_Flex_Ace_at_Sta02 = val_bool
'                ElseIf address = "A_04_Recipe_Enable_Sta03" Then
'                    PLC_04_Recipe_Enable_Sta03 = val_bool
'                ElseIf address = "A_05_Recipe_Enable_Sta04" Then
'                    PLC_05_Recipe_Enable_Sta04 = val_bool
'                ElseIf address = "A_06_Recipe_Enable_Sta05" Then
'                    PLC_06_Recipe_Enable_Sta05 = val_bool
'                ElseIf address = "A_07_Recipe_Enable_Sta06" Then
'                    PLC_07_Recipe_Enable_Sta06 = val_bool
'                ElseIf address = "A_08_Recipe_Enable_Sta07" Then
'                    PLC_08_Recipe_Enable_Sta07 = val_bool
'                ElseIf address = "A_09_Recipe_Enable_Sta08" Then
'                    PLC_09_Recipe_Enable_Sta08 = val_bool
'                ElseIf address = "A_10_Recipe_Enable_Sta09" Then
'                    PLC_10_Recipe_Enable_Sta09 = val_bool
'                ElseIf address = "A_11_Recipe_Enable_Sta10" Then
'                    PLC_11_Recipe_Enable_Sta10 = val_bool
'                ElseIf address = "A_12_Recipe_Enable_Sta11" Then
'                    PLC_12_Recipe_Enable_Sta11 = val_bool
'                ElseIf address = "A_13_Recipe_Enable_Sta12" Then
'                    PLC_13_Recipe_Enable_Sta12 = val_bool
'                ElseIf address = "A_14_Recipe_Enable_Sta13" Then
'                    PLC_14_Recipe_Enable_Sta13 = val_bool
'                ElseIf address = "A_15_Recipe_Mark_Top_of_Barrel" Then
'                    PLC_15_Recipe_Mark_Top_of_Barrel = val_bool
'                ElseIf address = "A_16_Recipe_Enable_Sta15" Then
'                    PLC_16_Recipe_Enable_Sta15 = val_bool
'                ElseIf address = "A_17_Recipe_Leave_key_in_After_Test" Then
'                    PLC_17_Recipe_Leave_key_in_After_Test = val_bool
'                ElseIf address = "A_18_Recipe_Enable_Sta16" Then
'                    PLC_18_Recipe_Enable_Sta16 = val_bool
'                ElseIf address = "A_19_Recipe_Mark_Side_of_Barrel" Then
'                    PLC_19_Recipe_Mark_Side_of_Barrel = val_bool
'                ElseIf address = "A_20_Recipe_Use_Master_Key_Scenario" Then
'                    PLC_20_Recipe_Use_Master_Key_Scenario = val_bool
'                ElseIf address = "A_21_Recipe_KeyTest_Finish_Angle" Then
'                    PLC_21_Recipe_KeyTest_Finish_Angle = val_real
'                ElseIf address = "A_22_Recipe_KeyTest_Start_Angle" Then
'                    PLC_22_Recipe_KeyTest_Start_Angle = val_real
'                ElseIf address = "A_23_Recipe_KeyTest_Test_Angle" Then
'                    PLC_23_Recipe_KeyTest_Test_Angle = val_real
'                ElseIf address = "A_24_Recipe_Batch_Quantity" Then
'                    PLC_24_Recipe_Batch_Quantity = val_dint
'                ElseIf address = "A_25_Recipe_Batch_Key_Que" Then
'                    PLC_25_Recipe_Batch_Key_Que = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_1" Then
'                    PLC_KeyCode_Digit_1 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_2" Then
'                    PLC_KeyCode_Digit_2 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_3" Then
'                    PLC_KeyCode_Digit_3 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_4" Then
'                    PLC_KeyCode_Digit_4 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_5" Then
'                    PLC_KeyCode_Digit_5 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_6" Then
'                    PLC_KeyCode_Digit_6 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_7" Then
'                    PLC_KeyCode_Digit_7 = val_dint
'                ElseIf address = "PLC_KeyCode_Digit_8" Then
'                    PLC_KeyCode_Digit_8 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_1" Then
'                    PLC_Sta06_SpringCode_Digit_1 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_2" Then
'                    PLC_Sta06_SpringCode_Digit_2 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_3" Then
'                    PLC_Sta06_SpringCode_Digit_3 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_4" Then
'                    PLC_Sta06_SpringCode_Digit_4 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_5" Then
'                    PLC_Sta06_SpringCode_Digit_5 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_6" Then
'                    PLC_Sta06_SpringCode_Digit_6 = val_dint
'                ElseIf address = "PLC_Sta06_SpringCode_Digit_7" Then
'                    PLC_Sta06_SpringCode_Digit_7 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_1" Then
'                    PLC_Sta07_TumberCode_Digit_1 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_2" Then
'                    PLC_Sta07_TumberCode_Digit_2 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_3" Then
'                    PLC_Sta07_TumberCode_Digit_3 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_4" Then
'                    PLC_Sta07_TumberCode_Digit_4 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_5" Then
'                    PLC_Sta07_TumberCode_Digit_5 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_6" Then
'                    PLC_Sta07_TumberCode_Digit_6 = val_dint
'                ElseIf address = "PLC_Sta07_TumberCode_Digit_7" Then
'                    PLC_Sta07_TumberCode_Digit_7 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_1" Then
'                    PLC_Sta08_TumberCode_Digit_1 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_2" Then
'                    PLC_Sta08_TumberCode_Digit_2 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_3" Then
'                    PLC_Sta08_TumberCode_Digit_3 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_4" Then
'                    PLC_Sta08_TumberCode_Digit_4 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_5" Then
'                    PLC_Sta08_TumberCode_Digit_5 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_6" Then
'                    PLC_Sta08_TumberCode_Digit_6 = val_dint
'                ElseIf address = "PLC_Sta08_TumberCode_Digit_7" Then
'                    PLC_Sta08_TumberCode_Digit_7 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_1" Then
'                    PLC_Sta10_TumberCode_Digit_1 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_2" Then
'                    PLC_Sta10_TumberCode_Digit_2 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_3" Then
'                    PLC_Sta10_TumberCode_Digit_3 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_4" Then
'                    PLC_Sta10_TumberCode_Digit_4 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_5" Then
'                    PLC_Sta10_TumberCode_Digit_5 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_6" Then
'                    PLC_Sta10_TumberCode_Digit_6 = val_dint
'                ElseIf address = "PLC_Sta10_TumberCode_Digit_7" Then
'                    PLC_Sta10_TumberCode_Digit_7 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_1" Then
'                    PLC_Sta12_TumberCode_Digit_1 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_2" Then
'                    PLC_Sta12_TumberCode_Digit_2 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_3" Then
'                    PLC_Sta12_TumberCode_Digit_3 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_4" Then
'                    PLC_Sta12_TumberCode_Digit_4 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_5" Then
'                    PLC_Sta12_TumberCode_Digit_5 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_6" Then
'                    PLC_Sta12_TumberCode_Digit_6 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_7" Then
'                    PLC_Sta12_TumberCode_Digit_7 = val_dint
'                ElseIf address = "PLC_Sta12_TumberCode_Digit_8" Then
'                    PLC_Sta12_TumberCode_Digit_8 = val_dint
'                End If
'                Threading.Thread.Sleep(5)
'                success = True
'            Catch ex As Exception
'                Dim msg As String = String.Format("Cannot read from PLC address: " & address & vbCrLf, ex.Message)
'                Dim caption As String = "Read from PLC"
'                Dim result = MessageBox.Show(String.Format(msg),
'                                        caption,
'                                        MessageBoxButtons.AbortRetryIgnore,
'                                        MessageBoxIcon.Asterisk,
'                                        MessageBoxDefaultButton.Button2)

'                If result = System.Windows.Forms.DialogResult.Abort Then
'                    'punt the entire evolution
'                    Wait_Message_Form.Close()
'                    Exit Sub
'                ElseIf result = System.Windows.Forms.DialogResult.Retry Then
'                    'try again
'                ElseIf result = System.Windows.Forms.DialogResult.Ignore Then
'                    'punt this tag
'                    Exit Do
'                End If
'            End Try
'        Loop
'    Next

'End Sub

'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_1", Tumbler_1_Code))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_2", Tumbler_2_Code))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_3", Tumbler_3_Code))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_4", Tumbler_4_Code))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_5", Tumbler_5_Code))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_6", Tumbler_6_Code))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_7", Tumbler_7_Code))
'        'PLC_list.Add(New KeyValuePair(Of String, String)("A_KeyCode_Digit_8", Tumbler_8_Code))

'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_1", My.Settings.Spring1_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_2", My.Settings.Spring2_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_3", My.Settings.Spring3_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_4", My.Settings.Spring4_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_5", My.Settings.Spring5_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_6", My.Settings.Spring6_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta06_SpringCode_Digit_7", My.Settings.Spring7_Bowl))

'        '===================================================
'        'My.Settings.Stepped_x is string with either 0 or 1 as boolean
'        'Bowl = Bowl number
'        'If = 1 then 
'        '   assign the bowl to station 7 (Stepped Tumblers) 
'        '   Set station 8 Bowl number = 0
'        'Else assign the bowl to station 8 (Bottom Tumblers) 
'        '   Set station 7 Bowl number = 0
'        '===================================================

'        If My.Settings.Stepped_1 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_1", My.Settings.Stepped1_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_1", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_1", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_1", My.Settings.Bot1_Bowl))
'        End If

'        If My.Settings.Stepped_2 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_2", My.Settings.Stepped2_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_2", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_2", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_2", My.Settings.Bot2_Bowl))
'        End If

'        If My.Settings.Stepped_3 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_3", My.Settings.Stepped3_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_3", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_3", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_3", My.Settings.Bot3_Bowl))
'        End If

'        If My.Settings.Stepped_4 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_4", My.Settings.Stepped4_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_4", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_4", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_4", My.Settings.Bot4_Bowl))
'        End If

'        If My.Settings.Stepped_5 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_5", My.Settings.Stepped5_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_5", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_5", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_5", My.Settings.Bot5_Bowl))
'        End If

'        If My.Settings.Stepped_6 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_6", My.Settings.Stepped6_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_6", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_6", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_6", My.Settings.Bot6_Bowl))
'        End If

'        If My.Settings.Stepped_7 = "1" Then
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_7", My.Settings.Stepped7_Bowl))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_7", "0"))
'        Else
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta07_TumberCode_Digit_7", "0"))
'            PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta08_TumberCode_Digit_7", My.Settings.Bot7_Bowl))
'        End If

'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_1", My.Settings.Mid1_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_2", My.Settings.Mid2_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_3", My.Settings.Mid3_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_4", My.Settings.Mid4_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_5", My.Settings.Mid5_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_6", My.Settings.Mid6_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta10_TumberCode_Digit_7", My.Settings.Mid7_Bowl))

'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_1", My.Settings.Top1_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_2", My.Settings.Top2_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_3", My.Settings.Top3_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_4", My.Settings.Top4_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_5", My.Settings.Top5_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_6", My.Settings.Top6_Bowl))
'        PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_7", My.Settings.Top7_Bowl))
'        'PLC_list.Add(New KeyValuePair(Of String, String)("A_Sta12_TumberCode_Digit_8", My.Settings.Top8_Bowl))

'        Convert_KeySeries()

'Print_Code:
'        PLC_list.Add(New KeyValuePair(Of String, String)("Print_Code_1", CStr(Print_Code(0))))
'        PLC_list.Add(New KeyValuePair(Of String, String)("Print_Code_2", CStr(Print_Code(1))))
'        PLC_list.Add(New KeyValuePair(Of String, String)("Print_Code_3", CStr(Print_Code(2))))