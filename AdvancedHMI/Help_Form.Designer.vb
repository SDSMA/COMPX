<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Help_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Work_File_Path_TextBox = New System.Windows.Forms.TextBox()
        Me.Key_Series_TextBox = New System.Windows.Forms.TextBox()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(411, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Key series"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Work File Path"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 60)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Click to Load a new KeyFile. File is copied to WorkFile.."
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 60)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tumbler Kit"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 60)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Rows"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 60)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(300, 60)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Buttons"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(15, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(300, 60)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Buttons"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(15, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 60)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Run / Stop, ReadNext"
        '
        'BasicLabel1
        '
        Me.BasicLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.EthernetIPforCLXCom1
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.InterpretValueAsBCD = False
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(15, 71)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(201, 60)
        Me.BasicLabel1.TabIndex = 11
        Me.BasicLabel1.Text = "BasicLabel"
        Me.BasicLabel1.Value = "BasicLabel"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        Me.BasicLabel1.ValueToSubtractFrom = 0!
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(15, 642)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(300, 60)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Buttons"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(411, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Database Filename"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "DatabaseFileName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(511, 162)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(500, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.DatabaseFileName
        '
        'Work_File_Path_TextBox
        '
        Me.Work_File_Path_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Work_File_Path", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Work_File_Path_TextBox.Location = New System.Drawing.Point(511, 97)
        Me.Work_File_Path_TextBox.Name = "Work_File_Path_TextBox"
        Me.Work_File_Path_TextBox.Size = New System.Drawing.Size(500, 20)
        Me.Work_File_Path_TextBox.TabIndex = 2
        Me.Work_File_Path_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Work_File_Path
        '
        'Key_Series_TextBox
        '
        Me.Key_Series_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_Series", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Key_Series_TextBox.Location = New System.Drawing.Point(511, 71)
        Me.Key_Series_TextBox.Name = "Key_Series_TextBox"
        Me.Key_Series_TextBox.Size = New System.Drawing.Size(500, 20)
        Me.Key_Series_TextBox.TabIndex = 0
        Me.Key_Series_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_Series
        '
        'Help_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 711)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Work_File_Path_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Key_Series_TextBox)
        Me.Name = "Help_Form"
        Me.Text = "Help"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Key_Series_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Work_File_Path_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
