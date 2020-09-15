<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Keyfile_Select_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Key_File_Dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Keyfile_Select_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KeyFile_Status_Label = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Convert_Workfile_Button = New System.Windows.Forms.Button()
        Me.ExcelToDGV_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.KeyCode_TextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Quantity_TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Key_Series_TextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Save_Workfile_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WorkFilePath_Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KeyFile_Path_Label = New System.Windows.Forms.Label()
        Me.WorkFile_Current_Row_TextBox = New System.Windows.Forms.TextBox()
        Me.EthernetIPforCLXCom2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.Tumbler_KitTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Tumbler_KitTableAdapter()
        Me.Tumbler_KitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Top_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Top_TumblerTableAdapter()
        Me.Top_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpringsTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.SpringsTableAdapter()
        Me.SpringsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mid_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Mid_TumblerTableAdapter()
        Me.Mid_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knurl_PinTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Knurl_PinTableAdapter()
        Me.Drill_PinTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Drill_PinTableAdapter()
        Me.Drill_PinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChartsTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.ChartsTableAdapter()
        Me.BushingTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.BushingTableAdapter()
        Me.BushingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bottom_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Bottom_TumblerTableAdapter()
        Me.Bottom_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarrelTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.BarrelTableAdapter()
        Me.BarrelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Station_13_ToolingTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Station_13_ToolingTableAdapter()
        Me.Station_13_ToolingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.TableAdapterManager()
        Me.ChartsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Knurl_PinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Tumbler_Code_OK_Label = New System.Windows.Forms.Label()
        Me.Send_First_Recipe_Button = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tumbler_KitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpringsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mid_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drill_PinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BushingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarrelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Station_13_ToolingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Knurl_PinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Key_File_Dialog
        '
        Me.Key_File_Dialog.Filter = "Excel worksheets|*.xls*"
        Me.Key_File_Dialog.InitialDirectory = "C:\CompX"
        Me.Key_File_Dialog.RestoreDirectory = True
        Me.Key_File_Dialog.ShowHelp = True
        Me.Key_File_Dialog.Title = "Key File Selection"
        '
        'Keyfile_Select_btn
        '
        Me.Keyfile_Select_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keyfile_Select_btn.Location = New System.Drawing.Point(12, 39)
        Me.Keyfile_Select_btn.Name = "Keyfile_Select_btn"
        Me.Keyfile_Select_btn.Size = New System.Drawing.Size(120, 100)
        Me.Keyfile_Select_btn.TabIndex = 1
        Me.Keyfile_Select_btn.Text = "Select Keyfile"
        Me.Keyfile_Select_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Keyfile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(682, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Workfile"
        '
        'KeyFile_Status_Label
        '
        Me.KeyFile_Status_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KeyFile_Status_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyFile_Status_Label.Location = New System.Drawing.Point(528, 71)
        Me.KeyFile_Status_Label.Name = "KeyFile_Status_Label"
        Me.KeyFile_Status_Label.Size = New System.Drawing.Size(1052, 63)
        Me.KeyFile_Status_Label.TabIndex = 10
        Me.KeyFile_Status_Label.Text = "KeyFile Status"
        Me.KeyFile_Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(520, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1052, 51)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "WorkFile"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(476, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 20)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "of"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(603, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 20)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "Total Rows in Workfile"
        '
        'Convert_Workfile_Button
        '
        Me.Convert_Workfile_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Convert_Workfile_Button.Location = New System.Drawing.Point(1313, 976)
        Me.Convert_Workfile_Button.Name = "Convert_Workfile_Button"
        Me.Convert_Workfile_Button.Size = New System.Drawing.Size(116, 78)
        Me.Convert_Workfile_Button.TabIndex = 158
        Me.Convert_Workfile_Button.Text = "Convert KeyCode to DINT"
        Me.Convert_Workfile_Button.UseVisualStyleBackColor = True
        '
        'ExcelToDGV_Button
        '
        Me.ExcelToDGV_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcelToDGV_Button.Location = New System.Drawing.Point(12, 145)
        Me.ExcelToDGV_Button.Name = "ExcelToDGV_Button"
        Me.ExcelToDGV_Button.Size = New System.Drawing.Size(120, 100)
        Me.ExcelToDGV_Button.TabIndex = 160
        Me.ExcelToDGV_Button.Text = "Load current Workfile from  Workbook"
        Me.ExcelToDGV_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 341
        Me.Label1.Text = "Quantity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 180)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 16)
        Me.Label20.TabIndex = 531
        Me.Label20.Text = "Key Code"
        '
        'KeyCode_TextBox
        '
        Me.KeyCode_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.KeyCode_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_Code", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.KeyCode_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_TextBox.Location = New System.Drawing.Point(94, 175)
        Me.KeyCode_TextBox.Name = "KeyCode_TextBox"
        Me.KeyCode_TextBox.Size = New System.Drawing.Size(110, 26)
        Me.KeyCode_TextBox.TabIndex = 506
        Me.KeyCode_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_Code
        Me.KeyCode_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 16)
        Me.Label19.TabIndex = 530
        Me.Label19.Text = "Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 16)
        Me.Label18.TabIndex = 529
        Me.Label18.Text = "Assigned To"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 16)
        Me.Label17.TabIndex = 528
        Me.Label17.Text = "MK code"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 16)
        Me.Label16.TabIndex = 527
        Me.Label16.Text = "Key No"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 16)
        Me.Label15.TabIndex = 526
        Me.Label15.Text = "Series"
        '
        'Quantity_TextBox
        '
        Me.Quantity_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_Qty", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Quantity_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity_TextBox.Location = New System.Drawing.Point(94, 207)
        Me.Quantity_TextBox.Name = "Quantity_TextBox"
        Me.Quantity_TextBox.Size = New System.Drawing.Size(110, 26)
        Me.Quantity_TextBox.TabIndex = 151
        Me.Quantity_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_Qty
        Me.Quantity_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_Date", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(94, 143)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(110, 26)
        Me.TextBox5.TabIndex = 150
        Me.TextBox5.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_Date
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_Assigned_To", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(94, 111)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(110, 26)
        Me.TextBox4.TabIndex = 149
        Me.TextBox4.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_Assigned_To
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_MK_Code", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(94, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 26)
        Me.TextBox2.TabIndex = 148
        Me.TextBox2.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_MK_Code
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Key_Series_TextBox
        '
        Me.Key_Series_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_Series", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Key_Series_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Key_Series_TextBox.Location = New System.Drawing.Point(94, 15)
        Me.Key_Series_TextBox.Name = "Key_Series_TextBox"
        Me.Key_Series_TextBox.Size = New System.Drawing.Size(110, 26)
        Me.Key_Series_TextBox.TabIndex = 145
        Me.Key_Series_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_Series
        Me.Key_Series_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_No", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(94, 47)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(110, 26)
        Me.TextBox3.TabIndex = 147
        Me.TextBox3.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_No
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save_Workfile_Button
        '
        Me.Save_Workfile_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Workfile_Button.Location = New System.Drawing.Point(138, 142)
        Me.Save_Workfile_Button.Name = "Save_Workfile_Button"
        Me.Save_Workfile_Button.Size = New System.Drawing.Size(120, 100)
        Me.Save_Workfile_Button.TabIndex = 512
        Me.Save_Workfile_Button.Text = "Save Workfile"
        Me.Save_Workfile_Button.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(534, 205)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DividerHeight = 4
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1052, 450)
        Me.DataGridView1.TabIndex = 513
        Me.DataGridView1.Tag = ""
        Me.ToolTip1.SetToolTip(Me.DataGridView1, "To Select a Series for production: DoubleClick on the row.DoubleClcik")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.WorkFilePath_Label)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.KeyFile_Path_Label)
        Me.GroupBox3.Controls.Add(Me.WorkFile_Current_Row_TextBox)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "FullAccess", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GroupBox3.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.FullAccess
        Me.GroupBox3.Location = New System.Drawing.Point(528, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1052, 66)
        Me.GroupBox3.TabIndex = 515
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = "FullAccess_K"
        Me.GroupBox3.Text = "Event log filepath"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "WorkFile_RowCount", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(529, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 525
        Me.Label6.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.WorkFile_RowCount
        '
        'WorkFilePath_Label
        '
        Me.WorkFilePath_Label.AutoSize = True
        Me.WorkFilePath_Label.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Work_File_Path", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WorkFilePath_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkFilePath_Label.Location = New System.Drawing.Point(754, 42)
        Me.WorkFilePath_Label.Name = "WorkFilePath_Label"
        Me.WorkFilePath_Label.Size = New System.Drawing.Size(112, 20)
        Me.WorkFilePath_Label.TabIndex = 524
        Me.WorkFilePath_Label.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Work_File_Path
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(348, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Current Row"
        '
        'KeyFile_Path_Label
        '
        Me.KeyFile_Path_Label.AutoSize = True
        Me.KeyFile_Path_Label.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Key_File_Path", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.KeyFile_Path_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyFile_Path_Label.Location = New System.Drawing.Point(67, 42)
        Me.KeyFile_Path_Label.Name = "KeyFile_Path_Label"
        Me.KeyFile_Path_Label.Size = New System.Drawing.Size(101, 20)
        Me.KeyFile_Path_Label.TabIndex = 523
        Me.KeyFile_Path_Label.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Key_File_Path
        '
        'WorkFile_Current_Row_TextBox
        '
        Me.WorkFile_Current_Row_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "WorkFile_CurrentRow", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WorkFile_Current_Row_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkFile_Current_Row_TextBox.Location = New System.Drawing.Point(208, 13)
        Me.WorkFile_Current_Row_TextBox.Name = "WorkFile_Current_Row_TextBox"
        Me.WorkFile_Current_Row_TextBox.Size = New System.Drawing.Size(110, 26)
        Me.WorkFile_Current_Row_TextBox.TabIndex = 154
        Me.WorkFile_Current_Row_TextBox.Text = Global.MfgControl.AdvancedHMI.My.MySettings.Default.WorkFile_CurrentRow
        Me.WorkFile_Current_Row_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EthernetIPforCLXCom2
        '
        Me.EthernetIPforCLXCom2.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom2.DataBindings.Add(New System.Windows.Forms.Binding("IPAddress", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "PLC_IP_Address", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EthernetIPforCLXCom2.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom2.DisableSubscriptions = False
        Me.EthernetIPforCLXCom2.IniFileName = ""
        Me.EthernetIPforCLXCom2.IniFileSection = Nothing
        Me.EthernetIPforCLXCom2.IPAddress = Global.MfgControl.AdvancedHMI.My.MySettings.Default.PLC_IP_Address
        Me.EthernetIPforCLXCom2.PollRateOverride = 2000
        Me.EthernetIPforCLXCom2.Port = 44818
        Me.EthernetIPforCLXCom2.ProcessorSlot = 0
        Me.EthernetIPforCLXCom2.RoutePath = Nothing
        Me.EthernetIPforCLXCom2.Timeout = 4000
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tumbler_KitTableAdapter
        '
        Me.Tumbler_KitTableAdapter.ClearBeforeFill = True
        '
        'Tumbler_KitBindingSource
        '
        Me.Tumbler_KitBindingSource.DataMember = "Tumbler Kit"
        Me.Tumbler_KitBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Top_TumblerTableAdapter
        '
        Me.Top_TumblerTableAdapter.ClearBeforeFill = True
        '
        'Top_TumblerBindingSource
        '
        Me.Top_TumblerBindingSource.DataMember = "Top Tumbler"
        Me.Top_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'SpringsTableAdapter
        '
        Me.SpringsTableAdapter.ClearBeforeFill = True
        '
        'SpringsBindingSource
        '
        Me.SpringsBindingSource.DataMember = "Springs"
        Me.SpringsBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Mid_TumblerTableAdapter
        '
        Me.Mid_TumblerTableAdapter.ClearBeforeFill = True
        '
        'Mid_TumblerBindingSource
        '
        Me.Mid_TumblerBindingSource.DataMember = "Mid Tumbler"
        Me.Mid_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Knurl_PinTableAdapter
        '
        Me.Knurl_PinTableAdapter.ClearBeforeFill = True
        '
        'Drill_PinTableAdapter
        '
        Me.Drill_PinTableAdapter.ClearBeforeFill = True
        '
        'Drill_PinBindingSource
        '
        Me.Drill_PinBindingSource.DataMember = "Drill Pin"
        Me.Drill_PinBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'ChartsTableAdapter
        '
        Me.ChartsTableAdapter.ClearBeforeFill = True
        '
        'BushingTableAdapter
        '
        Me.BushingTableAdapter.ClearBeforeFill = True
        '
        'BushingBindingSource
        '
        Me.BushingBindingSource.DataMember = "Bushing"
        Me.BushingBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Bottom_TumblerTableAdapter
        '
        Me.Bottom_TumblerTableAdapter.ClearBeforeFill = True
        '
        'Bottom_TumblerBindingSource
        '
        Me.Bottom_TumblerBindingSource.DataMember = "Bottom Tumbler"
        Me.Bottom_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'BarrelTableAdapter
        '
        Me.BarrelTableAdapter.ClearBeforeFill = True
        '
        'BarrelBindingSource
        '
        Me.BarrelBindingSource.DataMember = "Barrel"
        Me.BarrelBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Station_13_ToolingTableAdapter
        '
        Me.Station_13_ToolingTableAdapter.ClearBeforeFill = True
        '
        'Station_13_ToolingBindingSource
        '
        Me.Station_13_ToolingBindingSource.DataMember = "Station 13 Tooling"
        Me.Station_13_ToolingBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarrelTableAdapter = Nothing
        Me.TableAdapterManager.Bottom_TumblerTableAdapter = Nothing
        Me.TableAdapterManager.BushingTableAdapter = Nothing
        Me.TableAdapterManager.ChartsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Drill_PinTableAdapter = Nothing
        Me.TableAdapterManager.Knurl_PinTableAdapter = Nothing
        Me.TableAdapterManager.Mid_TumblerTableAdapter = Nothing
        Me.TableAdapterManager.RecipeTableAdapter = Nothing
        Me.TableAdapterManager.SpringsTableAdapter = Nothing
        Me.TableAdapterManager.Station_13_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Station_14_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Station_15_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Station_16_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Station_2_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Station_3_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Station_9_ToolingTableAdapter = Nothing
        Me.TableAdapterManager.Top_SleeveTableAdapter = Nothing
        Me.TableAdapterManager.Top_TumblerTableAdapter = Nothing
        Me.TableAdapterManager.Tumbler_KitTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ChartsBindingSource
        '
        Me.ChartsBindingSource.DataMember = "Charts"
        Me.ChartsBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Knurl_PinBindingSource
        '
        Me.Knurl_PinBindingSource.DataMember = "Knurl Pin"
        Me.Knurl_PinBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.KeyCode_TextBox)
        Me.GroupBox1.Controls.Add(Me.Key_Series_TextBox)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Quantity_TextBox)
        Me.GroupBox1.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "FullAccess", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GroupBox1.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.FullAccess
        Me.GroupBox1.Location = New System.Drawing.Point(303, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 250)
        Me.GroupBox1.TabIndex = 529
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "FullAccess_K"
        Me.GroupBox1.Text = "Current Key Series"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(300, 248)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(218, 23)
        Me.Label25.TabIndex = 530
        Me.Label25.Text = "Tumbler Code Not Updated"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tumbler_Code_OK_Label
        '
        Me.Tumbler_Code_OK_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tumbler_Code_OK_Label.Location = New System.Drawing.Point(300, 248)
        Me.Tumbler_Code_OK_Label.Name = "Tumbler_Code_OK_Label"
        Me.Tumbler_Code_OK_Label.Size = New System.Drawing.Size(218, 23)
        Me.Tumbler_Code_OK_Label.TabIndex = 531
        Me.Tumbler_Code_OK_Label.Text = "Tumbler Code OK"
        Me.Tumbler_Code_OK_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Send_First_Recipe_Button
        '
        Me.Send_First_Recipe_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_First_Recipe_Button.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Send_First_Recipe_Button.Location = New System.Drawing.Point(12, 248)
        Me.Send_First_Recipe_Button.Name = "Send_First_Recipe_Button"
        Me.Send_First_Recipe_Button.Size = New System.Drawing.Size(120, 100)
        Me.Send_First_Recipe_Button.TabIndex = 532
        Me.Send_First_Recipe_Button.Text = "Send Selected Row"
        Me.Send_First_Recipe_Button.UseVisualStyleBackColor = True
        '
        'Keyfile_Select_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1593, 961)
        Me.Controls.Add(Me.Send_First_Recipe_Button)
        Me.Controls.Add(Me.Tumbler_Code_OK_Label)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Convert_Workfile_Button)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ExcelToDGV_Button)
        Me.Controls.Add(Me.KeyFile_Status_Label)
        Me.Controls.Add(Me.Keyfile_Select_btn)
        Me.Controls.Add(Me.Save_Workfile_Button)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "Edit_OK", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Enabled = Global.MfgControl.AdvancedHMI.My.MySettings.Default.Edit_OK
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(200, 0)
        Me.Name = "Keyfile_Select_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Key File Select"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tumbler_KitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpringsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mid_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drill_PinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BushingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarrelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Station_13_ToolingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Knurl_PinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Key_File_Dialog As OpenFileDialog
    Friend WithEvents Keyfile_Select_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents KeyFile_Status_Label As Label
    Friend WithEvents Key_Series_TextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Quantity_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents WorkFile_Current_Row_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Convert_Workfile_Button As Button
    Friend WithEvents ExcelToDGV_Button As Button
    Friend WithEvents KeyCode_TextBox As TextBox
    Friend WithEvents Save_Workfile_Button As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents WorkFilePath_Label As Label
    Friend WithEvents KeyFile_Path_Label As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents Tumbler_KitTableAdapter As NCLRecipeDataSetTableAdapters.Tumbler_KitTableAdapter
    Friend WithEvents Tumbler_KitBindingSource As BindingSource
    Friend WithEvents Top_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Top_TumblerTableAdapter
    Friend WithEvents Top_TumblerBindingSource As BindingSource
    Friend WithEvents SpringsTableAdapter As NCLRecipeDataSetTableAdapters.SpringsTableAdapter
    Friend WithEvents SpringsBindingSource As BindingSource
    Friend WithEvents Mid_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Mid_TumblerTableAdapter
    Friend WithEvents Mid_TumblerBindingSource As BindingSource
    Friend WithEvents Knurl_PinTableAdapter As NCLRecipeDataSetTableAdapters.Knurl_PinTableAdapter
    Friend WithEvents Drill_PinTableAdapter As NCLRecipeDataSetTableAdapters.Drill_PinTableAdapter
    Friend WithEvents Drill_PinBindingSource As BindingSource
    Friend WithEvents EthernetIPforCLXCom2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents ChartsTableAdapter As NCLRecipeDataSetTableAdapters.ChartsTableAdapter
    Friend WithEvents BushingTableAdapter As NCLRecipeDataSetTableAdapters.BushingTableAdapter
    Friend WithEvents BushingBindingSource As BindingSource
    Friend WithEvents Bottom_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Bottom_TumblerTableAdapter
    Friend WithEvents Bottom_TumblerBindingSource As BindingSource
    Friend WithEvents BarrelTableAdapter As NCLRecipeDataSetTableAdapters.BarrelTableAdapter
    Friend WithEvents BarrelBindingSource As BindingSource
    Friend WithEvents Station_13_ToolingTableAdapter As NCLRecipeDataSetTableAdapters.Station_13_ToolingTableAdapter
    Friend WithEvents Station_13_ToolingBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As NCLRecipeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChartsBindingSource As BindingSource
    Friend WithEvents Knurl_PinBindingSource As BindingSource
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Tumbler_Code_OK_Label As Label
    Friend WithEvents Send_First_Recipe_Button As Button
End Class
