'' Marker Sequence
''================================================================
'Option Explicit On

'Module Marker_Sequence
'    Public Sub Marker_1_Control(EthernetIPforCLXCom1)
'        Dim Marker_1_Status As String
'        Dim status_OK As Boolean = False
'        Dim dialog_result As DialogResult
'        Dim caption As String
'        Dim msg As String

'        'Marker 1 signals ========================================================
'        'Sta_14_Print_Data_Sent             : to PLC
'        'Sta_14_Print_Done                  : to PLC
'        'Sta_14_Print_Error                 : to PLC
'        'Sta_14_Start_Technifor_Print       : from PLC
'        '"A_15_Recipe_Mark_Top_of_Barrel"   : from PLC

'        'Marker 2 PLC signals =====================================================
'        'Sta_17_Print_Data_Sent             : to PLC
'        'Sta_17_Print_Done                  : to PLC
'        'Sta_17_Print_Error                 : to PLC
'        'Sta_17_Start_Technifor_Print       : from PLC
'        '"A_19_Recipe_Mark_Side_of_Barrel"  : from PLC


'        'get a current status ===================================================
'        Marker_1_Status = Marker_1_ReadStatus()
'        status_OK = Left(Marker_1_Status, 1) = "1" Or
'                    Left(Marker_1_Status, 1) = "2" Or
'                    Left(Marker_1_Status, 1) = "3"

'        If status_OK = False Then
'            caption = "Marker 1"
'            msg = "Marker 1 is not ready." & vbCrLf & "<Retry> to download program" & vbCrLf & "<Cancel> to quit"
'            dialog_result = MessageBox.Show(msg,
'                        caption,
'                        MessageBoxButtons.RetryCancel,
'                        MessageBoxIcon.Asterisk,
'                        MessageBoxDefaultButton.Button1)
'            If dialog_result = System.Windows.Forms.DialogResult.Retry Then
'                ' stay in the loop
'            ElseIf dialog_result = System.Windows.Forms.DialogResult.Cancel Then
'                Return
'            End If
'        End If

'        System.Windows.Forms.Application.DoEvents()
'        Threading.Thread.Sleep(50)

'        'clear status message
'        Markers_Form.Marker_1_Status_TextBox.Text = ""
'        Marker_1_Seq_Log = ""

'        'Update Time in State ===================================================
'        If M_Seq(1).StateChanged Then
'            M_Seq(1).start_time = Now
'            M_Seq(1).LoopCount = 0
'        Else
'            M_Seq(1).stop_time = Now
'            Try
'                '.TotalSeconds
'                M_Seq(1).TimeInState = M_Seq(1).stop_time.Subtract(M_Seq(1).start_time).TotalSeconds
'            Catch
'                M_Seq(1).start_time = Now
'                '.TotalSeconds
'                M_Seq(1).TimeInState = (Now - M_Seq(1).start_time).TotalSeconds
'            End Try
'            M_Seq(1).LoopCount += 1 Mod 10000
'        End If

'        'check if stuck in a loop ===================================================
'        If M_Seq(1).TimeInState > 10000 And
'            M_Seq(1).CurrentState <> "Init" Then
'            Try
'                EthernetIPforCLXCom1.Write("Sta14_Print_Error", 1)
'                EthernetIPforCLXCom1.Write("Sta14_Print_Data_Sent", 0)
'                EthernetIPforCLXCom1.Write("Sta14_Print_Done", 0)
'            Catch
'                EthernetComErrorCount += EthernetComErrorCount
'                Marker_1_Seq_Log &= "Ethernet Error (Stuck in Loop)" & vbCrLf
'            End Try

'            caption = "Marker 1"
'            msg = "Stuck in state " & M_Seq(1).CurrentState
'            dialog_result = MessageBox.Show(msg,
'                            caption,
'                            MessageBoxButtons.AbortRetryIgnore,
'                            MessageBoxIcon.Asterisk,
'                            MessageBoxDefaultButton.Button2)
'            If dialog_result = System.Windows.Forms.DialogResult.Abort Then
'                Exit Sub
'            ElseIf dialog_result = System.Windows.Forms.DialogResult.Retry Then
'                M_Seq(1).LoopCount = 0
'            ElseIf dialog_result = System.Windows.Forms.DialogResult.Ignore Then
'                Return
'            End If
'        End If

'        'check enable ===================================================
'        'Wait for Enable (A_15 or A19)
'        Dim gf_mode As Boolean = True
'        If PLC_15_Recipe_Mark_Top_of_Barrel = False And
'            gf_mode = False Then

'            'If not enabled, Wait in Init step
'            M_Seq(1).CurrentState = "Init"
'            M_Seq(1).NextState = "Init"
'            Try
'                EthernetIPforCLXCom1.Write("Sta14_Print_Error", 0)
'                EthernetIPforCLXCom1.Write("Sta14_Print_Data_Sent", 0)
'                EthernetIPforCLXCom1.Write("Sta14_Print_Done", 0)
'            Catch
'                EthernetComErrorCount += EthernetComErrorCount
'                Marker_1_Seq_Log = "Ethernet Error" & vbCrLf
'            End Try
'        End If

'        '===================================================
'        'Step - Init 
'        'Initialize
'        '===================================================
'        If M_Seq(1).CurrentState = "Init" Then
'            ' Reset PLC signals
'            If PLC_15_Recipe_Mark_Top_of_Barrel Then
'                Try
'                    EthernetIPforCLXCom1.Write("Sta14_Print_Error", 0)
'                    EthernetIPforCLXCom1.Write("Sta14_Print_Done", 0)
'                Catch
'                    EthernetComErrorCount += EthernetComErrorCount
'                    Marker_1_Seq_Log = "Ethernet Error" & vbCrLf
'                End Try
'            End If

'            'Change state
'            'Marker Ready, PLC Enables, PLC signals OFF
'            If status_OK And
'                PLC_15_Recipe_Mark_Top_of_Barrel And
'                Marker_1_VerifyProgram() And
'                Marker_1_VerifyVariable() And
'                PLC_Sta14_Print_Error = False And
'                PLC_Sta14_Print_Done = False Then

'                M_Seq(1).NextState = "Cancel Marking"
'            End If
'        End If

'        'Step - Send Marker Cancel ===================================================
'        'Wait for Marker response to Cancel
'        If M_Seq(1).CurrentState = "Cancel Marking" Then
'            Dim response = Marker_1_Cancel()

'            'Change state
'            ' Response to 'Cancel'
'            If response.IndexOf("Z") >= 0 Then
'                M_Seq(1).NextState = "Reset Marker"
'            End If
'        End If

'        'Step - Send Marker Reset ===================================================
'        If M_Seq(1).CurrentState = "Reset Marker" Then
'            ' Download Program and data
'            Marker_1_Exit_Error()

'            'Change state
'            M_Seq(1).NextState = "Arm Marker"
'        End If

'        '' Step ===================================================
'        '' Send Variable to Marker
'        'If M_Seq(1).CurrentState = "Set Variable" Then
'        '    Dim response As String = ""
'        '    Dim index As Integer
'        '    Dim varnum As String = ""
'        '    Dim varvalue As String = ""

'        '    ' Write Variable to Marker
'        '    Try
'        '        response = Marker_1_Write_Variable(0, My.Settings.KeyCode)
'        '    Catch
'        '        ' decide what to do here if message fails
'        '        Marker_1_Seq_Log = "Marker Error"
'        '    End Try

'        '    ' Read Variable from Marker
'        '    'If response <> "-1" Then
'        '    response = Marker_1_Read_Variable(0)
'        '    index = response.IndexOf(" ")

'        '    ' Get variable number and variable value from string response
'        '    If index > 0 Then
'        '        varnum = Mid(response, 1, index)
'        '        varvalue = Mid(response, index + 2, response.Length - index + 1)
'        '        varvalue = varvalue.Replace(vbCr, "").Replace(vbCrLf, "").Replace(" ", "")
'        '    End If

'        '    'Change state
'        '    'Match variable number and value 
'        '    If (varnum = "0") And
'        '        varvalue = My.Settings.KeyCode Then

'        '        M_Seq(1).NextState = "Arm Marker"
'        '    End If
'        '    'End If
'        'End If

'        ' Step ===================================================
'        ' Send Program Number to Marker
'        If M_Seq(1).CurrentState = "Arm Marker" Then
'            ' Download # reps & Program Number

'            '!!!! fix me
'            Marker_1_ProgNumber = "1"
'            Marker_1_Load_Prog(1, Marker_1_ProgNumber)

'            'Change state
'            If True Then
'                M_Seq(1).NextState = "Data Sent to PLC"
'            End If
'        End If

'        ' Step ===================================================
'        ' Send Data_Sent to PLC
'        If M_Seq(1).CurrentState = "Data Sent to PLC" Then

'            If (PLC_Sta14_Print_Data_Sent = False) Then
'                Try
'                    ' Set Data Sent
'                    EthernetIPforCLXCom1.Write("Sta14_Print_Data_Sent", 1)
'                Catch
'                    EthernetComErrorCount += EthernetComErrorCount
'                    Marker_1_Seq_Log = "Ethernet Error"
'                End Try
'            End If

'            'Change state
'            If PLC_Sta14_Print_Data_Sent Then
'                M_Seq(1).NextState = "Wait for PLC Ready"
'            End If
'        End If

'        ' Step ===================================================
'        If M_Seq(1).CurrentState = "Wait for PLC Ready" Then
'            ' No Action

'            'Change state
'            ' Wait for PLC signals = OFF before beginning print cycle
'            If PLC_Sta14_Print_Data_Sent = True And
'                PLC_Sta14_Print_Done = False And
'                PLC_Sta14_Print_Error = False Then

'                M_Seq(1).NextState = "Wait for Print Command"
'            End If
'        End If

'        ' Step ===================================================
'        ' Wait for PLC Print Command
'        ' Sta_14_Start_Technifor_Print
'        'PLC sends Start Print when Step >= 1 and Sta14_Print_Data_Sent
'        If M_Seq(1).CurrentState = "Wait for Print Command" Then

'            'Change state
'            If PLC_Sta14_Print_Start Then
'                Marker_1_Start_Marking()
'                M_Seq(1).NextState = "Wait for Marker Done"
'            End If
'        End If

'        '' Step ===================================================
'        '' Send Print command to Marker
'        'If M_Seq(1).CurrentState = "Send Print Command" Then
'        '    Marker_1_Start_Marking()

'        '    ' try to catch status = 3
'        '    Dim c = Marker_1_ReadStatus()

'        '    'Change state
'        '    M_Seq(1).NextState = "Wait for Marker Done"
'        'End If

'        ' ===================================================
'        'Step
'        'Wait for Marker Response Printing Done
'        'Then Set Print Done
'        ' ===================================================
'        If M_Seq(1).CurrentState = "Wait for Marker Done" Then

'            'Change state
'            If Marker_1_Status_1 = "1" Then
'                Try
'                    ' Set StaXX_Print_Done
'                    EthernetIPforCLXCom1.Write("Sta14_Print_Done", 1)
'                Catch
'                    EthernetComErrorCount += EthernetComErrorCount
'                    Marker_1_Seq_Log = "Ethernet Error"
'                End Try

'                M_Seq(1).NextState = "End"
'            End If
'        End If

'        '' Step ===================================================
'        '' Send Print_Done to PLC
'        'If M_Seq(1).CurrentState = "Set Print Done" Then

'        '    Try
'        '        ' Set StaXX_Print_Done
'        '        EthernetIPforCLXCom1.Write("Sta14_Print_Done", 1)
'        '    Catch
'        '        EthernetComErrorCount += EthernetComErrorCount
'        '        Marker_1_Seq_Log = "Ethernet Error"
'        '    End Try

'        '    'Change state
'        '    If PLC_Sta14_Print_Done Then
'        '        M_Seq(1).NextState = "End"
'        '    End If
'        'End If

'        ' Step ===================================================
'        If M_Seq(1).CurrentState = "End" Then
'            ' No Action

'            'Change state
'            M_Seq(1).NextState = "Init"
'        End If


'        'Check invalid state name ===================================================
'        'If M_Seq(1).CurrentState Is Nothing Or M_Seq(1).CurrentState = "" Then
'        '    M_Seq(1).NextState = "Init"
'        'End If

'        ' search list of state names to verify state is valid
'        Dim success As Boolean
'        For Each i As String In Marker_StateList

'            If i = M_Seq(1).CurrentState Then
'                success = True
'            End If
'        Next
'        If success = False Then
'            M_Seq(1).NextState = "Init"
'            Marker_1_Seq_Log = "Invalid State: " & M_Seq(1).CurrentState
'        End If

'        'Update State Conditions ===================================================
'        M_Seq(1).StateChanged = (M_Seq(1).CurrentState <> M_Seq(1).NextState)
'        M_Seq(1).CurrentState = M_Seq(1).NextState

'        'update status on screen
'        Markers_Form.Marker_1_State_TextBox.Text = M_Seq(1).CurrentState
'        Markers_Form.Marker_1_Seq_Log_TextBox.AppendText(M_Seq(1).NextState & ": " & Marker_1_Seq_Log & vbCrLf)

'        If EthernetComErrorCount > 0 Then
'            Markers_Form.Marker_1_Seq_Log_TextBox.AppendText("PLC Comm errors :" & EthernetComErrorCount & vbCrLf)
'        End If

'        ' Thus Ends Marker_1 Control Sequence =====================
'    End Sub

'End Module
