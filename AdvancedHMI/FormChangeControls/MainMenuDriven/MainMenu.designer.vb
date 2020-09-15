<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MainMenu_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Open_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Quantity_GroupBox = New System.Windows.Forms.GroupBox()
        Me.A_25_Recipe_Batch_Key_Que_PLC = New AdvancedHMIControls.AnalogValueDisplay()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.PLC_Request_Data_BasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.A_24_Recipe_Batch_Quantity_PLC = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Marker_1_Button = New System.Windows.Forms.Button()
        Me.KeyFile_Form_Button = New System.Windows.Forms.Button()
        Me.MainMenu_Timer_Button = New System.Windows.Forms.Button()
        Me.User_Access_Button = New System.Windows.Forms.Button()
        Me.Permission_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Modify_Access_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Marker_2_Button = New System.Windows.Forms.Button()
        Me.User_Permission_TextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Machine_Mode_Display = New System.Windows.Forms.Label()
        Me.Recipe_Button = New System.Windows.Forms.Button()
        Me.Tumblers_Button = New System.Windows.Forms.Button()
        Me.PLC_Comms_Label = New System.Windows.Forms.Label()
        Me.OpenForm_Button = New System.Windows.Forms.Button()
        Me.Sta17_Start_Print_BasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.Sta14_Start_Print_BasicLabel = New AdvancedHMIControls.BasicLabel()
        Me.Machine_Mode_PLC = New AdvancedHMIControls.AnalogValueDisplay()
        Me.Marker_DataSubscriber = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.Recipe_DataSubscriber = New AdvancedHMIControls.DataSubscriber2(Me.components)
        Me.NclRecipeDataSet1 = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MainMenuButton8 = New MfgControl.AdvancedHMI.MainMenuButton()
        Me.StartupForm_btn = New MfgControl.AdvancedHMI.MainMenuButton()
        Me.Settings_MainMenuButton = New MfgControl.AdvancedHMI.MainMenuButton()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Tumbler_Download_Status_Label = New System.Windows.Forms.Label()
        Me.Recipe_Download_Status_Label = New System.Windows.Forms.Label()
        Me.PLC_Comms_Enabled_Label = New System.Windows.Forms.Label()
        Me.Quantity_GroupBox.SuspendLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Marker_DataSubscriber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Recipe_DataSubscriber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NclRecipeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'MainMenu_Timer
        '
        '
        'ComboBox1
        '
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Name = "ComboBox1"
        '
        'ComboBox2
        '
        resources.ApplyResources(Me.ComboBox2, "ComboBox2")
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Name = "ComboBox2"
        '
        'Open_Button
        '
        resources.ApplyResources(Me.Open_Button, "Open_Button")
        Me.Open_Button.Name = "Open_Button"
        Me.Open_Button.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        resources.ApplyResources(Me.Close_Button, "Close_Button")
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Quantity_GroupBox
        '
        Me.Quantity_GroupBox.Controls.Add(Me.A_25_Recipe_Batch_Key_Que_PLC)
        Me.Quantity_GroupBox.Controls.Add(Me.PLC_Request_Data_BasicLabel)
        Me.Quantity_GroupBox.Controls.Add(Me.A_24_Recipe_Batch_Quantity_PLC)
        Me.Quantity_GroupBox.Controls.Add(Me.Label8)
        Me.Quantity_GroupBox.Controls.Add(Me.Label3)
        Me.Quantity_GroupBox.Controls.Add(Me.Label2)
        Me.Quantity_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        resources.ApplyResources(Me.Quantity_GroupBox, "Quantity_GroupBox")
        Me.Quantity_GroupBox.Name = "Quantity_GroupBox"
        Me.Quantity_GroupBox.TabStop = False
        '
        'A_25_Recipe_Batch_Key_Que_PLC
        '
        Me.A_25_Recipe_Batch_Key_Que_PLC.BackColor = System.Drawing.SystemColors.ControlDark
        Me.A_25_Recipe_Batch_Key_Que_PLC.ComComponent = Me.EthernetIPforCLXCom1
        Me.A_25_Recipe_Batch_Key_Que_PLC.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "FullAccess", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.A_25_Recipe_Batch_Key_Que_PLC.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.FullAccess
        Me.A_25_Recipe_Batch_Key_Que_PLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.A_25_Recipe_Batch_Key_Que_PLC, "A_25_Recipe_Batch_Key_Que_PLC")
        Me.A_25_Recipe_Batch_Key_Que_PLC.ForeColor = System.Drawing.Color.Black
        Me.A_25_Recipe_Batch_Key_Que_PLC.ForeColorInLimits = System.Drawing.Color.Black
        Me.A_25_Recipe_Batch_Key_Que_PLC.ForeColorOverLimit = System.Drawing.Color.Black
        Me.A_25_Recipe_Batch_Key_Que_PLC.ForeColorUnderLimit = System.Drawing.Color.Black
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadFontColor = System.Drawing.Color.Black
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadMaxValue = 9999.0R
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadMinValue = 0R
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadPasscode = Nothing
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadScaleFactor = 1.0R
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadText = "Enter New Batch Quantity"
        Me.A_25_Recipe_Batch_Key_Que_PLC.KeypadWidth = 300
        Me.A_25_Recipe_Batch_Key_Que_PLC.Name = "A_25_Recipe_Batch_Key_Que_PLC"
        Me.A_25_Recipe_Batch_Key_Que_PLC.NumericFormat = "0000"
        Me.A_25_Recipe_Batch_Key_Que_PLC.PLCAddressKeypad = "A_25_Recipe_Batch_Key_Que"
        Me.A_25_Recipe_Batch_Key_Que_PLC.PLCAddressValue = CType(resources.GetObject("A_25_Recipe_Batch_Key_Que_PLC.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.A_25_Recipe_Batch_Key_Que_PLC.PLCAddressValueLimitLower = Nothing
        Me.A_25_Recipe_Batch_Key_Que_PLC.PLCAddressValueLimitUpper = Nothing
        Me.A_25_Recipe_Batch_Key_Que_PLC.PLCAddressVisible = Nothing
        Me.A_25_Recipe_Batch_Key_Que_PLC.ShowValue = True
        Me.A_25_Recipe_Batch_Key_Que_PLC.Tag = "PLC"
        Me.A_25_Recipe_Batch_Key_Que_PLC.Value = "0000"
        Me.A_25_Recipe_Batch_Key_Que_PLC.ValueLimitLower = -999999.0R
        Me.A_25_Recipe_Batch_Key_Que_PLC.ValueLimitUpper = 999999.0R
        Me.A_25_Recipe_Batch_Key_Que_PLC.ValuePrefix = Nothing
        Me.A_25_Recipe_Batch_Key_Que_PLC.ValueSuffix = Nothing
        Me.A_25_Recipe_Batch_Key_Que_PLC.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DataBindings.Add(New System.Windows.Forms.Binding("IPAddress", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "PLC_IP_Address", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = Global.MfgControl.AdvancedHMI.My.MySettings.Default.PLC_IP_Address
        Me.EthernetIPforCLXCom1.PollRateOverride = 20
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 2000
        '
        'PLC_Request_Data_BasicLabel
        '
        resources.ApplyResources(Me.PLC_Request_Data_BasicLabel, "PLC_Request_Data_BasicLabel")
        Me.PLC_Request_Data_BasicLabel.BackColor = System.Drawing.SystemColors.Control
        Me.PLC_Request_Data_BasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.PLC_Request_Data_BasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.PLC_Request_Data_BasicLabel.DisplayAsTime = False
        Me.PLC_Request_Data_BasicLabel.ForeColor = System.Drawing.Color.Black
        Me.PLC_Request_Data_BasicLabel.Highlight = False
        Me.PLC_Request_Data_BasicLabel.HighlightColor = System.Drawing.Color.Green
        Me.PLC_Request_Data_BasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.PLC_Request_Data_BasicLabel.HighlightKeyCharacter = "!"
        Me.PLC_Request_Data_BasicLabel.InterpretValueAsBCD = False
        Me.PLC_Request_Data_BasicLabel.KeypadAlphaNumeric = False
        Me.PLC_Request_Data_BasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.PLC_Request_Data_BasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PLC_Request_Data_BasicLabel.KeypadMaxValue = 0R
        Me.PLC_Request_Data_BasicLabel.KeypadMinValue = 0R
        Me.PLC_Request_Data_BasicLabel.KeypadScaleFactor = 1.0R
        Me.PLC_Request_Data_BasicLabel.KeypadShowCurrentValue = False
        Me.PLC_Request_Data_BasicLabel.KeypadText = Nothing
        Me.PLC_Request_Data_BasicLabel.KeypadWidth = 300
        Me.PLC_Request_Data_BasicLabel.Name = "PLC_Request_Data_BasicLabel"
        Me.PLC_Request_Data_BasicLabel.NumericFormat = Nothing
        Me.PLC_Request_Data_BasicLabel.PLCAddressHighlight = "Request_PC_Data"
        Me.PLC_Request_Data_BasicLabel.PLCAddressKeypad = ""
        Me.PLC_Request_Data_BasicLabel.PLCAddressValue = "Request_PC_Data"
        Me.PLC_Request_Data_BasicLabel.PollRate = 0
        Me.PLC_Request_Data_BasicLabel.Value = "PLC Req Data"
        Me.PLC_Request_Data_BasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.PLC_Request_Data_BasicLabel.ValueLeftPadLength = 0
        Me.PLC_Request_Data_BasicLabel.ValuePrefix = Nothing
        Me.PLC_Request_Data_BasicLabel.ValueScaleFactor = 1.0R
        Me.PLC_Request_Data_BasicLabel.ValueSuffix = Nothing
        Me.PLC_Request_Data_BasicLabel.ValueToSubtractFrom = 0!
        '
        'A_24_Recipe_Batch_Quantity_PLC
        '
        Me.A_24_Recipe_Batch_Quantity_PLC.BackColor = System.Drawing.SystemColors.ControlDark
        Me.A_24_Recipe_Batch_Quantity_PLC.ComComponent = Me.EthernetIPforCLXCom1
        Me.A_24_Recipe_Batch_Quantity_PLC.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "FullAccess", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.A_24_Recipe_Batch_Quantity_PLC.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.FullAccess
        Me.A_24_Recipe_Batch_Quantity_PLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.A_24_Recipe_Batch_Quantity_PLC, "A_24_Recipe_Batch_Quantity_PLC")
        Me.A_24_Recipe_Batch_Quantity_PLC.ForeColor = System.Drawing.Color.Black
        Me.A_24_Recipe_Batch_Quantity_PLC.ForeColorInLimits = System.Drawing.Color.Black
        Me.A_24_Recipe_Batch_Quantity_PLC.ForeColorOverLimit = System.Drawing.Color.Black
        Me.A_24_Recipe_Batch_Quantity_PLC.ForeColorUnderLimit = System.Drawing.Color.Black
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadFontColor = System.Drawing.Color.Black
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadMaxValue = 0R
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadMinValue = 0R
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadPasscode = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadScaleFactor = 1.0R
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadText = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.KeypadWidth = 300
        Me.A_24_Recipe_Batch_Quantity_PLC.Name = "A_24_Recipe_Batch_Quantity_PLC"
        Me.A_24_Recipe_Batch_Quantity_PLC.NumericFormat = "0000"
        Me.A_24_Recipe_Batch_Quantity_PLC.PLCAddressKeypad = ""
        Me.A_24_Recipe_Batch_Quantity_PLC.PLCAddressValue = CType(resources.GetObject("A_24_Recipe_Batch_Quantity_PLC.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.A_24_Recipe_Batch_Quantity_PLC.PLCAddressValueLimitLower = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.PLCAddressValueLimitUpper = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.PLCAddressVisible = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.ShowValue = True
        Me.A_24_Recipe_Batch_Quantity_PLC.Tag = "PLC"
        Me.A_24_Recipe_Batch_Quantity_PLC.Value = "0000"
        Me.A_24_Recipe_Batch_Quantity_PLC.ValueLimitLower = -999999.0R
        Me.A_24_Recipe_Batch_Quantity_PLC.ValueLimitUpper = 999999.0R
        Me.A_24_Recipe_Batch_Quantity_PLC.ValuePrefix = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.ValueSuffix = Nothing
        Me.A_24_Recipe_Batch_Quantity_PLC.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Marker_1_Button
        '
        resources.ApplyResources(Me.Marker_1_Button, "Marker_1_Button")
        Me.Marker_1_Button.Name = "Marker_1_Button"
        Me.Marker_1_Button.UseVisualStyleBackColor = True
        '
        'KeyFile_Form_Button
        '
        resources.ApplyResources(Me.KeyFile_Form_Button, "KeyFile_Form_Button")
        Me.KeyFile_Form_Button.Name = "KeyFile_Form_Button"
        Me.KeyFile_Form_Button.UseVisualStyleBackColor = True
        '
        'MainMenu_Timer_Button
        '
        resources.ApplyResources(Me.MainMenu_Timer_Button, "MainMenu_Timer_Button")
        Me.MainMenu_Timer_Button.Name = "MainMenu_Timer_Button"
        Me.MainMenu_Timer_Button.UseVisualStyleBackColor = True
        '
        'User_Access_Button
        '
        resources.ApplyResources(Me.User_Access_Button, "User_Access_Button")
        Me.User_Access_Button.Name = "User_Access_Button"
        Me.User_Access_Button.UseVisualStyleBackColor = True
        '
        'Permission_Timer
        '
        '
        'Marker_2_Button
        '
        resources.ApplyResources(Me.Marker_2_Button, "Marker_2_Button")
        Me.Marker_2_Button.Name = "Marker_2_Button"
        Me.Marker_2_Button.UseVisualStyleBackColor = True
        '
        'User_Permission_TextBox
        '
        resources.ApplyResources(Me.User_Permission_TextBox, "User_Permission_TextBox")
        Me.User_Permission_TextBox.Name = "User_Permission_TextBox"
        '
        'ComboBox3
        '
        resources.ApplyResources(Me.ComboBox3, "ComboBox3")
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Name = "ComboBox3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "WorkFile_RowCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.WorkFile_RowCount
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "WorkFile_CurrentRow", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.WorkFile_CurrentRow
        '
        'Machine_Mode_Display
        '
        resources.ApplyResources(Me.Machine_Mode_Display, "Machine_Mode_Display")
        Me.Machine_Mode_Display.Name = "Machine_Mode_Display"
        '
        'Recipe_Button
        '
        resources.ApplyResources(Me.Recipe_Button, "Recipe_Button")
        Me.Recipe_Button.Name = "Recipe_Button"
        Me.Recipe_Button.UseVisualStyleBackColor = True
        '
        'Tumblers_Button
        '
        resources.ApplyResources(Me.Tumblers_Button, "Tumblers_Button")
        Me.Tumblers_Button.Name = "Tumblers_Button"
        Me.Tumblers_Button.UseVisualStyleBackColor = True
        '
        'PLC_Comms_Label
        '
        resources.ApplyResources(Me.PLC_Comms_Label, "PLC_Comms_Label")
        Me.PLC_Comms_Label.Name = "PLC_Comms_Label"
        '
        'OpenForm_Button
        '
        resources.ApplyResources(Me.OpenForm_Button, "OpenForm_Button")
        Me.OpenForm_Button.Name = "OpenForm_Button"
        Me.OpenForm_Button.UseVisualStyleBackColor = True
        '
        'Sta17_Start_Print_BasicLabel
        '
        resources.ApplyResources(Me.Sta17_Start_Print_BasicLabel, "Sta17_Start_Print_BasicLabel")
        Me.Sta17_Start_Print_BasicLabel.BackColor = System.Drawing.SystemColors.Control
        Me.Sta17_Start_Print_BasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Sta17_Start_Print_BasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.Sta17_Start_Print_BasicLabel.DisplayAsTime = False
        Me.Sta17_Start_Print_BasicLabel.ForeColor = System.Drawing.Color.Black
        Me.Sta17_Start_Print_BasicLabel.Highlight = False
        Me.Sta17_Start_Print_BasicLabel.HighlightColor = System.Drawing.Color.Green
        Me.Sta17_Start_Print_BasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.Sta17_Start_Print_BasicLabel.HighlightKeyCharacter = "!"
        Me.Sta17_Start_Print_BasicLabel.InterpretValueAsBCD = False
        Me.Sta17_Start_Print_BasicLabel.KeypadAlphaNumeric = False
        Me.Sta17_Start_Print_BasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Sta17_Start_Print_BasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Sta17_Start_Print_BasicLabel.KeypadMaxValue = 0R
        Me.Sta17_Start_Print_BasicLabel.KeypadMinValue = 0R
        Me.Sta17_Start_Print_BasicLabel.KeypadScaleFactor = 1.0R
        Me.Sta17_Start_Print_BasicLabel.KeypadShowCurrentValue = False
        Me.Sta17_Start_Print_BasicLabel.KeypadText = Nothing
        Me.Sta17_Start_Print_BasicLabel.KeypadWidth = 300
        Me.Sta17_Start_Print_BasicLabel.Name = "Sta17_Start_Print_BasicLabel"
        Me.Sta17_Start_Print_BasicLabel.NumericFormat = Nothing
        Me.Sta17_Start_Print_BasicLabel.PLCAddressHighlight = "Sta17_Start_Technifor_Print"
        Me.Sta17_Start_Print_BasicLabel.PLCAddressKeypad = ""
        Me.Sta17_Start_Print_BasicLabel.PLCAddressValue = "Sta17_Start_Technifor_Print"
        Me.Sta17_Start_Print_BasicLabel.PollRate = 0
        Me.Sta17_Start_Print_BasicLabel.Value = "Sta17 Print"
        Me.Sta17_Start_Print_BasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Sta17_Start_Print_BasicLabel.ValueLeftPadLength = 0
        Me.Sta17_Start_Print_BasicLabel.ValuePrefix = Nothing
        Me.Sta17_Start_Print_BasicLabel.ValueScaleFactor = 1.0R
        Me.Sta17_Start_Print_BasicLabel.ValueSuffix = Nothing
        Me.Sta17_Start_Print_BasicLabel.ValueToSubtractFrom = 0!
        '
        'Sta14_Start_Print_BasicLabel
        '
        resources.ApplyResources(Me.Sta14_Start_Print_BasicLabel, "Sta14_Start_Print_BasicLabel")
        Me.Sta14_Start_Print_BasicLabel.BackColor = System.Drawing.SystemColors.Control
        Me.Sta14_Start_Print_BasicLabel.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Sta14_Start_Print_BasicLabel.ComComponent = Me.EthernetIPforCLXCom1
        Me.Sta14_Start_Print_BasicLabel.DisplayAsTime = False
        Me.Sta14_Start_Print_BasicLabel.ForeColor = System.Drawing.Color.Black
        Me.Sta14_Start_Print_BasicLabel.Highlight = False
        Me.Sta14_Start_Print_BasicLabel.HighlightColor = System.Drawing.Color.Green
        Me.Sta14_Start_Print_BasicLabel.HighlightForeColor = System.Drawing.Color.White
        Me.Sta14_Start_Print_BasicLabel.HighlightKeyCharacter = "!"
        Me.Sta14_Start_Print_BasicLabel.InterpretValueAsBCD = False
        Me.Sta14_Start_Print_BasicLabel.KeypadAlphaNumeric = False
        Me.Sta14_Start_Print_BasicLabel.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Sta14_Start_Print_BasicLabel.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Sta14_Start_Print_BasicLabel.KeypadMaxValue = 0R
        Me.Sta14_Start_Print_BasicLabel.KeypadMinValue = 0R
        Me.Sta14_Start_Print_BasicLabel.KeypadScaleFactor = 1.0R
        Me.Sta14_Start_Print_BasicLabel.KeypadShowCurrentValue = False
        Me.Sta14_Start_Print_BasicLabel.KeypadText = Nothing
        Me.Sta14_Start_Print_BasicLabel.KeypadWidth = 300
        Me.Sta14_Start_Print_BasicLabel.Name = "Sta14_Start_Print_BasicLabel"
        Me.Sta14_Start_Print_BasicLabel.NumericFormat = Nothing
        Me.Sta14_Start_Print_BasicLabel.PLCAddressHighlight = "Sta14_Start_Technifor_Print"
        Me.Sta14_Start_Print_BasicLabel.PLCAddressKeypad = ""
        Me.Sta14_Start_Print_BasicLabel.PLCAddressValue = "Sta14_Start_Technifor_Print"
        Me.Sta14_Start_Print_BasicLabel.PollRate = 0
        Me.Sta14_Start_Print_BasicLabel.Value = "Sta14 Print"
        Me.Sta14_Start_Print_BasicLabel.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Sta14_Start_Print_BasicLabel.ValueLeftPadLength = 0
        Me.Sta14_Start_Print_BasicLabel.ValuePrefix = Nothing
        Me.Sta14_Start_Print_BasicLabel.ValueScaleFactor = 1.0R
        Me.Sta14_Start_Print_BasicLabel.ValueSuffix = Nothing
        Me.Sta14_Start_Print_BasicLabel.ValueToSubtractFrom = 0!
        '
        'Machine_Mode_PLC
        '
        Me.Machine_Mode_PLC.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Machine_Mode_PLC.ComComponent = Me.EthernetIPforCLXCom1
        Me.Machine_Mode_PLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.Machine_Mode_PLC, "Machine_Mode_PLC")
        Me.Machine_Mode_PLC.ForeColor = System.Drawing.Color.Black
        Me.Machine_Mode_PLC.ForeColorInLimits = System.Drawing.Color.Black
        Me.Machine_Mode_PLC.ForeColorOverLimit = System.Drawing.Color.Black
        Me.Machine_Mode_PLC.ForeColorUnderLimit = System.Drawing.Color.Black
        Me.Machine_Mode_PLC.KeypadFontColor = System.Drawing.Color.Black
        Me.Machine_Mode_PLC.KeypadMaxValue = 9999.0R
        Me.Machine_Mode_PLC.KeypadMinValue = 0R
        Me.Machine_Mode_PLC.KeypadPasscode = Nothing
        Me.Machine_Mode_PLC.KeypadScaleFactor = 1.0R
        Me.Machine_Mode_PLC.KeypadText = ""
        Me.Machine_Mode_PLC.KeypadWidth = 300
        Me.Machine_Mode_PLC.Name = "Machine_Mode_PLC"
        Me.Machine_Mode_PLC.NumericFormat = "0"
        Me.Machine_Mode_PLC.PLCAddressKeypad = ""
        Me.Machine_Mode_PLC.PLCAddressValue = CType(resources.GetObject("Machine_Mode_PLC.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.Machine_Mode_PLC.PLCAddressValueLimitLower = Nothing
        Me.Machine_Mode_PLC.PLCAddressValueLimitUpper = Nothing
        Me.Machine_Mode_PLC.PLCAddressVisible = Nothing
        Me.Machine_Mode_PLC.ShowValue = True
        Me.Machine_Mode_PLC.Tag = "PLC"
        Me.Machine_Mode_PLC.Value = "0"
        Me.Machine_Mode_PLC.ValueLimitLower = -999999.0R
        Me.Machine_Mode_PLC.ValueLimitUpper = 999999.0R
        Me.Machine_Mode_PLC.ValuePrefix = Nothing
        Me.Machine_Mode_PLC.ValueSuffix = Nothing
        Me.Machine_Mode_PLC.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'Marker_DataSubscriber
        '
        Me.Marker_DataSubscriber.ComComponent = Me.EthernetIPforCLXCom1
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems1"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems2"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems3"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems4"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems5"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems6"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Marker_DataSubscriber.PLCAddressValueItems7"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Marker_DataSubscriber.PollRate = 0
        Me.Marker_DataSubscriber.SynchronizingObject = Me.Label14
        Me.Marker_DataSubscriber.Value = Nothing
        '
        'Recipe_DataSubscriber
        '
        Me.Recipe_DataSubscriber.ComComponent = Me.EthernetIPforCLXCom1
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems1"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems2"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems3"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems4"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems5"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems6"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems7"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems8"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems9"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems10"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems11"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems12"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems13"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems14"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems15"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems16"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems17"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems18"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems19"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems20"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems21"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems22"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems23"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems24"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems25"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems26"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems27"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems28"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems29"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PLCAddressValueItems.Add(CType(resources.GetObject("Recipe_DataSubscriber.PLCAddressValueItems30"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem))
        Me.Recipe_DataSubscriber.PollRate = 100
        Me.Recipe_DataSubscriber.SynchronizingObject = Me
        Me.Recipe_DataSubscriber.Value = Nothing
        '
        'NclRecipeDataSet1
        '
        Me.NclRecipeDataSet1.DataSetName = "NCLRecipeDataSet"
        Me.NclRecipeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox4
        '
        resources.ApplyResources(Me.ComboBox4, "ComboBox4")
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Name = "ComboBox4"
        '
        'MainMenuButton8
        '
        Me.MainMenuButton8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MainMenuButton8.ComComponent = Nothing
        resources.ApplyResources(Me.MainMenuButton8, "MainMenuButton8")
        Me.MainMenuButton8.ForeColor = System.Drawing.Color.Black
        Me.MainMenuButton8.FormToOpen = GetType(MfgControl.AdvancedHMI.Help_Form)
        Me.MainMenuButton8.KeypadWidth = 300
        Me.MainMenuButton8.Name = "MainMenuButton8"
        Me.MainMenuButton8.OpenOnStartup = False
        Me.MainMenuButton8.Passcode = Nothing
        Me.MainMenuButton8.PasswordChar = False
        Me.MainMenuButton8.PLCAddressVisible = ""
        Me.MainMenuButton8.UseVisualStyleBackColor = False
        '
        'StartupForm_btn
        '
        Me.StartupForm_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StartupForm_btn.ComComponent = Nothing
        resources.ApplyResources(Me.StartupForm_btn, "StartupForm_btn")
        Me.StartupForm_btn.ForeColor = System.Drawing.Color.Black
        Me.StartupForm_btn.FormToOpen = Nothing
        Me.StartupForm_btn.KeypadWidth = 300
        Me.StartupForm_btn.Name = "StartupForm_btn"
        Me.StartupForm_btn.OpenOnStartup = False
        Me.StartupForm_btn.Passcode = Nothing
        Me.StartupForm_btn.PasswordChar = False
        Me.StartupForm_btn.PLCAddressVisible = ""
        Me.StartupForm_btn.UseVisualStyleBackColor = False
        '
        'Settings_MainMenuButton
        '
        Me.Settings_MainMenuButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Settings_MainMenuButton.ComComponent = Nothing
        Me.Settings_MainMenuButton.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "FullAccess", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Settings_MainMenuButton.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.FullAccess
        resources.ApplyResources(Me.Settings_MainMenuButton, "Settings_MainMenuButton")
        Me.Settings_MainMenuButton.ForeColor = System.Drawing.Color.Black
        Me.Settings_MainMenuButton.FormToOpen = GetType(MfgControl.AdvancedHMI.SettingsForm)
        Me.Settings_MainMenuButton.KeypadWidth = 300
        Me.Settings_MainMenuButton.Name = "Settings_MainMenuButton"
        Me.Settings_MainMenuButton.OpenOnStartup = False
        Me.Settings_MainMenuButton.Passcode = Nothing
        Me.Settings_MainMenuButton.PasswordChar = False
        Me.Settings_MainMenuButton.PLCAddressVisible = ""
        Me.Settings_MainMenuButton.UseVisualStyleBackColor = False
        '
        'ComboBox5
        '
        resources.ApplyResources(Me.ComboBox5, "ComboBox5")
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Name = "ComboBox5"
        '
        'Tumbler_Download_Status_Label
        '
        resources.ApplyResources(Me.Tumbler_Download_Status_Label, "Tumbler_Download_Status_Label")
        Me.Tumbler_Download_Status_Label.Name = "Tumbler_Download_Status_Label"
        '
        'Recipe_Download_Status_Label
        '
        resources.ApplyResources(Me.Recipe_Download_Status_Label, "Recipe_Download_Status_Label")
        Me.Recipe_Download_Status_Label.Name = "Recipe_Download_Status_Label"
        '
        'PLC_Comms_Enabled_Label
        '
        resources.ApplyResources(Me.PLC_Comms_Enabled_Label, "PLC_Comms_Enabled_Label")
        Me.PLC_Comms_Enabled_Label.Name = "PLC_Comms_Enabled_Label"
        '
        'MainMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.PLC_Comms_Enabled_Label)
        Me.Controls.Add(Me.Recipe_Download_Status_Label)
        Me.Controls.Add(Me.Tumbler_Download_Status_Label)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.OpenForm_Button)
        Me.Controls.Add(Me.PLC_Comms_Label)
        Me.Controls.Add(Me.Tumblers_Button)
        Me.Controls.Add(Me.Machine_Mode_Display)
        Me.Controls.Add(Me.Sta17_Start_Print_BasicLabel)
        Me.Controls.Add(Me.Sta14_Start_Print_BasicLabel)
        Me.Controls.Add(Me.Recipe_Button)
        Me.Controls.Add(Me.Machine_Mode_PLC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.User_Permission_TextBox)
        Me.Controls.Add(Me.Marker_2_Button)
        Me.Controls.Add(Me.User_Access_Button)
        Me.Controls.Add(Me.MainMenu_Timer_Button)
        Me.Controls.Add(Me.KeyFile_Form_Button)
        Me.Controls.Add(Me.Marker_1_Button)
        Me.Controls.Add(Me.Quantity_GroupBox)
        Me.Controls.Add(Me.Close_Button)
        Me.Controls.Add(Me.Open_Button)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MainMenuButton8)
        Me.Controls.Add(Me.Settings_MainMenuButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StartupForm_btn)
        Me.Controls.Add(Me.ComboBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.TopMost = True
        Me.Quantity_GroupBox.ResumeLayout(False)
        Me.Quantity_GroupBox.PerformLayout()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Marker_DataSubscriber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Recipe_DataSubscriber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NclRecipeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenuButton10 As MainMenuButton
    Friend WithEvents MainMenuButton9 As MainMenuButton
    Friend WithEvents MainMenuButton7 As MainMenuButton
    Friend WithEvents MainMenuButton6 As MainMenuButton
    Friend WithEvents MainMenuButton5 As MainMenuButton
    Friend WithEvents MainMenuButton4 As MainMenuButton
    Friend WithEvents MainMenuButton3 As MainMenuButton
    Friend WithEvents MainMenuButton2 As MainMenuButton
    Friend WithEvents MainMenuButton1 As MainMenuButton
    Friend WithEvents Button1 As Button
    Friend WithEvents StartupForm_btn As MainMenuButton
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Settings_MainMenuButton As MainMenuButton
    Friend WithEvents MainMenuButton8 As MainMenuButton
    Friend WithEvents MainMenu_Timer As Timer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Open_Button As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents Marker_DataSubscriber As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents Quantity_GroupBox As GroupBox
    Friend WithEvents NclRecipeDataSet1 As NCLRecipeDataSet
    Friend WithEvents Marker_1_Button As Button
    Friend WithEvents KeyFile_Form_Button As Button
    Friend WithEvents Recipe_DataSubscriber As AdvancedHMIControls.DataSubscriber2
    Friend WithEvents MainMenu_Timer_Button As Button
    Friend WithEvents User_Access_Button As Button
    Friend WithEvents Permission_Timer As Timer
    Friend WithEvents Modify_Access_Timer As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents A_25_Recipe_Batch_Key_Que_PLC As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents A_24_Recipe_Batch_Quantity_PLC As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Marker_2_Button As Button
    Friend WithEvents User_Permission_TextBox As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Machine_Mode_PLC As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents Machine_Mode_Display As Label
    Friend WithEvents Recipe_Button As Button
    Friend WithEvents Sta14_Start_Print_BasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents Sta17_Start_Print_BasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents PLC_Request_Data_BasicLabel As AdvancedHMIControls.BasicLabel
    Friend WithEvents Tumblers_Button As Button
    Friend WithEvents PLC_Comms_Label As Label
    Friend WithEvents OpenForm_Button As Button
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Tumbler_Download_Status_Label As Label
    Friend WithEvents Recipe_Download_Status_Label As Label
    Friend WithEvents PLC_Comms_Enabled_Label As Label
End Class
