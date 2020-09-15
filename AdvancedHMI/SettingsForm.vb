Option Explicit On

Imports System          'Access Console.WriteLine()
Imports System.IO
Imports System.IO.Ports 'Access the SerialPort Object

Public Class SettingsForm
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '=====================================================================
        'File path Settings
        '=====================================================================

        RecipePath_TextBox.Text = strDatabase
        PLC_IP_Address_TextBox.Text = My.Settings.PLC_IP_Address
        PLC_IP_Address_Timeout_TextBox.Text = My.Settings.PLC_IP_Timeout

        Ini_Filepath_TextBox.Text = My.Settings.Ini_FilePath
        Event_Log_Filepath_TextBox.Text = My.Settings.Event_Log_Filepath

        PLC_IP_Address_Timeout_TextBox.DataBindings.Add("Text", My.Settings, "PLC_IP_Timeout")

        PLC_IP_Address_TextBox.Mask = ""
        'PLC_IP_Address_TextBox.ValidatingType = TypeOf (System.Net.IPAddress)

        '=====================================================================
        'Network Settings
        '=====================================================================
        EthernetIPforCLXCom1.IPAddress = My.Settings.PLC_IP_Address
        EthernetIPforCLXCom1.Timeout = My.Settings.PLC_IP_Timeout

    End Sub

    'Public Sub Settings_Form_Timer_Tick()
    '    Marker_1_Sequence_TextBox.Text = Marker_1_Control_State
    '    Marker_2_Sequence_TextBox.Text = Marker_2_Control_State
    'End Sub
    '=====================================================================
    ' PLC IP Address
    '=====================================================================
    Private Sub PLC_IP_Address_TextBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles PLC_IP_Address_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsIPValid(PLC_IP_Address_TextBox.Text) Then
                ' IP address is valid. update variables.
                My.Settings.PLC_IP_Address = PLC_IP_Address_TextBox.Text
                My.Settings.Save()

                MainMenu.EthernetIPforCLXCom1.IPAddress = My.Settings.PLC_IP_Address
                Verify_Recipe_Form.EthernetIPforCLXCom1.IPAddress = My.Settings.PLC_IP_Address

                System.Windows.Forms.Application.DoEvents()
            Else
                MessageBox.Show(String.Format(PLC_IP_Address_TextBox.Text & " is not a valid IP address."))
                ' Display original IP address
                PLC_IP_Address_TextBox.Text = My.Settings.PLC_IP_Address
                Exit Sub
            End If

            Ping_PLC()
        End If
    End Sub

    Private Sub Ping_PLC_Button_Click(sender As Object, e As EventArgs) Handles Ping_PLC_Button.Click
        Ping_PLC()
    End Sub

    Public Sub Ping_PLC()
        Try
            ' check if IP address responds to ping
            If My.Computer.Network.Ping(My.Settings.PLC_IP_Address) Then
                MsgBox(My.Settings.PLC_IP_Address & " responded to ping .")
            Else
                MsgBox(My.Settings.PLC_IP_Address & " did not respond to ping.")
            End If

        Catch ex As Exception
            MessageBox.Show("Cannnot ping IP address ...")
        End Try
    End Sub

    Private Sub PLC_IP_Address_Timeout_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            My.Settings.PLC_IP_Timeout = PLC_IP_Address_Timeout_TextBox.Text
            My.Settings.Save()
        End If
    End Sub


    'Private Sub PLC_IP_Address_TextBox_TextChanged(sender As Object, ByVal e As EventArgs) Handles PLC_IP_Address_TextBox.TextChanged

    '    '.KeyEventArgs
    '    'Private Sub PLC_IP_Address_TextBox_TextChanged(sender As Object, ByVal e As EventArgs) Handles PLC_IP_Address_TextBox.TextChanged
    '    ' Wait for <Enter> key
    '    'Dim f As System.Windows.Forms.KeyEventArgs = System.Windows.Forms.

    '    ' Dim g As Object = system.Windows.Forms.


    '    ' My.Forms.SettingsForm.KeyPreview

    '    'If My.Forms.SettingsForm.KeyPreview <> Keys.Enter Then
    '    '        If My.Forms.SettingsForm.
    '    '    Exit Sub
    '    '       End If

    '    ' Check if string is valid IP address

    '    If IsIPValid(PLC_IP_Address_TextBox.Text) Then
    '        My.Settings.PLC_IP_Address = PLC_IP_Address_TextBox.Text
    '        My.Settings.Save()
    '    Else
    '        MessageBox.Show(String.Format(PLC_IP_Address_TextBox.Text & " is not a valid IP address."))
    '        Exit Sub
    '    End If

    'End Sub
    Private Sub GetIPAddress()
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim strIPAddress As String = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

        '        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)
    End Sub

    Public Function IsIPValid(ByVal IPString As String) As Boolean
        'Dim varAddress(10) As String
        'Dim ipsegement(10) As Byte
        'Dim n As Long
        'Dim lCount As Long
        Dim address As System.Net.IPAddress = Nothing
        'Dim ipvalid As Boolean = False

        '' parse the string at the dots.
        'varAddress = Split(IPString, ".", , vbTextCompare)

        'Dim example As String = "123.456.789"
        ''Dim is_valid As Boolean = 
        ''IPAddress.TryParse(example, ip)

        '' count the dots
        'Dim var_ubound As Int32 = UBound(varAddress)

        'If IsArray(varAddress) And UBound(varAddress) = 3 Then
        '    For n = LBound(varAddress) To UBound(varAddress)
        '        lCount = lCount + 1
        '        ipsegement(n) = CByte(varAddress(n))
        '    Next
        'End If

        '' if there are 4 segement, each within the range
        'If (lCount = 4) Then
        '    If ipsegement(0) > 0 And ipsegement(0) < 255 And
        '        ipsegement(1) > 0 And ipsegement(1) < 255 And
        '        ipsegement(2) > 0 And ipsegement(2) < 255 And
        '        ipsegement(3) > 0 And ipsegement(3) < 255 Then

        '        ipvalid = True

        '    End If
        'End If

        ''If ipvalid Then
        ''    MessageBox.Show(String.Format(IPString & " is not a valid IP address."))
        ''    Exit Function
        ''End If

        '' check if IP address responds to ping
        'If My.Computer.Network.Ping(IPString) Then
        '    MsgBox(IPString & "responded to ping request.")
        'Else
        '    MsgBox(IPString & " did not respond to Ping request.")
        'End If
        'Return ipvalid

        Return System.Net.IPAddress.TryParse(IPString, address)

    End Function

    '=====================================================================
    'File path Settings
    '=====================================================================

    Private Sub WorkFile_Path_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WorkFilepath_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.Work_File_Path = WorkFilepath_TextBox.Text
            My.Settings.Save()
            Work_File_Path = My.Settings.Work_File_Path
            System.Windows.Forms.Application.DoEvents()

            MessageBox.Show("WorkFile path is changed to: " & Work_File_Path,
                            "WorkFile path setting")
        Else
            'MsgBox("File path does not exist: " & KeyFilepath_TextBox.Text)
        End If
    End Sub

    Private Sub Ini_File_Path_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Ini_Filepath_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Directory.Exists(Ini_Filepath_TextBox.Text) Then
                My.Settings.Ini_FilePath = Ini_Filepath_TextBox.Text
                My.Settings.Save()
            Else
                MsgBox("File path does not exist: " & Ini_Filepath_TextBox.Text)
            End If
        End If
    End Sub

    Private Sub Event_Log_FilePath_TextBox_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Event_Log_Filepath_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Directory.Exists(Event_Log_Filepath_TextBox.Text) Then
                My.Settings.Event_Log_Filepath = Event_Log_Filepath_TextBox.Text
                My.Settings.Save()
            Else
                MsgBox("File path does not exist: " & Event_Log_Filepath_TextBox.Text)
            End If
        End If
    End Sub

    Private Function IsIPAddress(ByVal IP As String, ByRef sQuad() As String, Optional ByVal AllowError As Boolean = True) As Boolean
        'IP is the IP address
        'sQuad is an array of the 4 parts of the IP
        'AllowError is a flag to let the function know
        '   if allowed to throw an error if IP is invalid.

        Dim IsValid As Boolean = True 'Assumes that the IP is valid until proven otherwise
        Try
            Dim counter As Integer
            Dim tmpQuad(3) As String
            Dim WhichQuad As Integer = 0

            tmpQuad(0) = ""
            For counter = 1 To IP.Length
                If Mid(IP, counter, 1) = "." Then
                    'need to move to the next quad
                    WhichQuad += 1
                    tmpQuad(WhichQuad) = ""
                Else
                    'add the char
                    tmpQuad(WhichQuad) &= Mid(IP, counter, 1)
                End If
            Next
            For counter = 0 To 3
                If Not tmpQuad(counter) = Val(tmpQuad(counter)).ToString Then IsValid = False
                'verify between 0 and 255
                If (Val(tmpQuad(counter)) < 0) Or (Val(tmpQuad(counter)) > 255) Then
                    IsValid = False
                Else
                    'Is valid, so move the portion of the temp IP
                    sQuad(counter) = tmpQuad(counter)
                End If
            Next
        Catch
            IsValid = False
        End Try

        'If AllowError And Not IsValid Then
        '    'Since the IP was incorrectly assumed to be valid, an error will be thrown 
        '    RaiseEvent InvalidIP(IP)
        '    Dim ex As New Exception()
        '    ex.Source = "IP Address"
        '    Throw ex
        'End If
        'Return IsValid
    End Function

End Class