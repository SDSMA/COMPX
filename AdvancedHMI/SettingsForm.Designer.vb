<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Me.RecipePath_TextBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.PLC_IP_Address_TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PLC_IP_Address_Timeout_TextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Ping_PLC_Button = New System.Windows.Forms.Button()
        Me.Event_Log_Filepath_TextBox = New System.Windows.Forms.TextBox()
        Me.Ini_Filepath_TextBox = New System.Windows.Forms.TextBox()
        Me.WorkFilepath_TextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecipePath_TextBox
        '
        Me.RecipePath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "NCLRecipeConnectionString", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RecipePath_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipePath_TextBox.Location = New System.Drawing.Point(388, 36)
        Me.RecipePath_TextBox.Name = "RecipePath_TextBox"
        Me.RecipePath_TextBox.Size = New System.Drawing.Size(192, 22)
        Me.RecipePath_TextBox.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 99)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 194
        Me.Label21.Text = "10.1.100.102"
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "10.1.100.102"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 2000
        '
        'PLC_IP_Address_TextBox
        '
        Me.PLC_IP_Address_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "PLC_IP_Address", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.PLC_IP_Address_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLC_IP_Address_TextBox.Location = New System.Drawing.Point(129, 42)
        Me.PLC_IP_Address_TextBox.Name = "PLC_IP_Address_TextBox"
        Me.PLC_IP_Address_TextBox.Size = New System.Drawing.Size(113, 22)
        Me.PLC_IP_Address_TextBox.TabIndex = 199
        Me.PLC_IP_Address_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.PLC_IP_Address
        '
        'PLC_IP_Address_Timeout_TextBox
        '
        Me.PLC_IP_Address_Timeout_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLC_IP_Address_Timeout_TextBox.Location = New System.Drawing.Point(129, 70)
        Me.PLC_IP_Address_Timeout_TextBox.Name = "PLC_IP_Address_Timeout_TextBox"
        Me.PLC_IP_Address_Timeout_TextBox.Size = New System.Drawing.Size(113, 22)
        Me.PLC_IP_Address_Timeout_TextBox.TabIndex = 200
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(21, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 16)
        Me.Label22.TabIndex = 201
        Me.Label22.Text = "PLC IP Address"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(21, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 16)
        Me.Label23.TabIndex = 202
        Me.Label23.Text = "PLC IP Timeout"
        '
        'Ping_PLC_Button
        '
        Me.Ping_PLC_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ping_PLC_Button.Location = New System.Drawing.Point(260, 42)
        Me.Ping_PLC_Button.Name = "Ping_PLC_Button"
        Me.Ping_PLC_Button.Size = New System.Drawing.Size(60, 47)
        Me.Ping_PLC_Button.TabIndex = 203
        Me.Ping_PLC_Button.Text = "Ping PLC"
        Me.Ping_PLC_Button.UseVisualStyleBackColor = True
        '
        'Event_Log_Filepath_TextBox
        '
        Me.Event_Log_Filepath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Event_Log_Filepath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Event_Log_Filepath_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Event_Log_Filepath_TextBox.Location = New System.Drawing.Point(388, 114)
        Me.Event_Log_Filepath_TextBox.Name = "Event_Log_Filepath_TextBox"
        Me.Event_Log_Filepath_TextBox.Size = New System.Drawing.Size(192, 22)
        Me.Event_Log_Filepath_TextBox.TabIndex = 109
        Me.Event_Log_Filepath_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Event_Log_Filepath
        '
        'Ini_Filepath_TextBox
        '
        Me.Ini_Filepath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Ini_FilePath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Ini_Filepath_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ini_Filepath_TextBox.Location = New System.Drawing.Point(388, 88)
        Me.Ini_Filepath_TextBox.Name = "Ini_Filepath_TextBox"
        Me.Ini_Filepath_TextBox.Size = New System.Drawing.Size(192, 22)
        Me.Ini_Filepath_TextBox.TabIndex = 108
        Me.Ini_Filepath_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Ini_FilePath
        '
        'WorkFilepath_TextBox
        '
        Me.WorkFilepath_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Work_File_Path", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WorkFilepath_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkFilepath_TextBox.Location = New System.Drawing.Point(388, 62)
        Me.WorkFilepath_TextBox.Name = "WorkFilepath_TextBox"
        Me.WorkFilepath_TextBox.Size = New System.Drawing.Size(192, 22)
        Me.WorkFilepath_TextBox.TabIndex = 5
        Me.WorkFilepath_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Work_File_Path
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.CompX_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(1076, 537)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.ErrorImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox2.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox2.InitialImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox2.Location = New System.Drawing.Point(1076, 617)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 100
        Me.PictureBox2.TabStop = False
        '
        'SettingsForm
        '
        Me.AccessibleDescription = "Settings"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.Ping_PLC_Button)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.PLC_IP_Address_Timeout_TextBox)
        Me.Controls.Add(Me.PLC_IP_Address_TextBox)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Event_Log_Filepath_TextBox)
        Me.Controls.Add(Me.Ini_Filepath_TextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.WorkFilepath_TextBox)
        Me.Controls.Add(Me.RecipePath_TextBox)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Edit_OK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Edit_OK
        Me.Name = "SettingsForm"
        Me.Text = "Settings"
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents RecipePath_TextBox As TextBox
    Friend WithEvents WorkFilepath_TextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Ini_Filepath_TextBox As TextBox
    Friend WithEvents Event_Log_Filepath_TextBox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PLC_IP_Address_TextBox As MaskedTextBox
    Friend WithEvents PLC_IP_Address_Timeout_TextBox As MaskedTextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Ping_PLC_Button As Button
End Class
