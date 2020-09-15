<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charts_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PartType_TextBox = New System.Windows.Forms.TextBox()
        Me.ChartsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.Part_8_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_8_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_7_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_7_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_6_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_6_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_5_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_5_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_4_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_4_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_3_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_3_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_2_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_2_TextBox = New System.Windows.Forms.TextBox()
        Me.Part_1_TextBox = New System.Windows.Forms.TextBox()
        Me.KeyCode_1_TextBox = New System.Windows.Forms.TextBox()
        Me.ChartName_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_1_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_1_TextBox = New System.Windows.Forms.TextBox()
        Me.Charts_DataGridView = New System.Windows.Forms.DataGridView()
        Me.ChartNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyCode8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bottom_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChartsTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.ChartsTableAdapter()
        Me.Bottom_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Bottom_TumblerTableAdapter()
        Me.TableAdapterManager = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.TableAdapterManager()
        Me.Mid_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mid_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Mid_TumblerTableAdapter()
        Me.Top_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Top_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Top_TumblerTableAdapter()
        Me.SpringsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpringsTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.SpringsTableAdapter()
        Me.Stepped_2_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_2_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_3_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_3_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_4_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_4_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_5_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_5_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_6_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_6_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_7_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_7_TextBox = New System.Windows.Forms.TextBox()
        Me.Stepped_8_TextBox = New System.Windows.Forms.TextBox()
        Me.Bowl_8_TextBox = New System.Windows.Forms.TextBox()
        Me.ReadOnly_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ChartsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charts_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mid_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpringsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PartType_TextBox
        '
        Me.PartType_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part Type", True))
        Me.PartType_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartType_TextBox.Location = New System.Drawing.Point(159, 692)
        Me.PartType_TextBox.Name = "PartType_TextBox"
        Me.PartType_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.PartType_TextBox.TabIndex = 36
        '
        'ChartsBindingSource
        '
        Me.ChartsBindingSource.DataMember = "Charts"
        Me.ChartsBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Part_8_TextBox
        '
        Me.Part_8_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #7", True))
        Me.Part_8_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_8_TextBox.Location = New System.Drawing.Point(68, 934)
        Me.Part_8_TextBox.Name = "Part_8_TextBox"
        Me.Part_8_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_8_TextBox.TabIndex = 35
        '
        'KeyCode_8_TextBox
        '
        Me.KeyCode_8_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 8", True))
        Me.KeyCode_8_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_8_TextBox.Location = New System.Drawing.Point(3, 934)
        Me.KeyCode_8_TextBox.Name = "KeyCode_8_TextBox"
        Me.KeyCode_8_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_8_TextBox.TabIndex = 34
        Me.KeyCode_8_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_7_TextBox
        '
        Me.Part_7_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #7", True))
        Me.Part_7_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_7_TextBox.Location = New System.Drawing.Point(68, 908)
        Me.Part_7_TextBox.Name = "Part_7_TextBox"
        Me.Part_7_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_7_TextBox.TabIndex = 33
        '
        'KeyCode_7_TextBox
        '
        Me.KeyCode_7_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 7", True))
        Me.KeyCode_7_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_7_TextBox.Location = New System.Drawing.Point(3, 908)
        Me.KeyCode_7_TextBox.Name = "KeyCode_7_TextBox"
        Me.KeyCode_7_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_7_TextBox.TabIndex = 32
        Me.KeyCode_7_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_6_TextBox
        '
        Me.Part_6_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #6", True))
        Me.Part_6_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_6_TextBox.Location = New System.Drawing.Point(68, 882)
        Me.Part_6_TextBox.Name = "Part_6_TextBox"
        Me.Part_6_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_6_TextBox.TabIndex = 31
        '
        'KeyCode_6_TextBox
        '
        Me.KeyCode_6_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 6", True))
        Me.KeyCode_6_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_6_TextBox.Location = New System.Drawing.Point(3, 882)
        Me.KeyCode_6_TextBox.Name = "KeyCode_6_TextBox"
        Me.KeyCode_6_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_6_TextBox.TabIndex = 30
        Me.KeyCode_6_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_5_TextBox
        '
        Me.Part_5_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #5", True))
        Me.Part_5_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_5_TextBox.Location = New System.Drawing.Point(68, 856)
        Me.Part_5_TextBox.Name = "Part_5_TextBox"
        Me.Part_5_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_5_TextBox.TabIndex = 29
        '
        'KeyCode_5_TextBox
        '
        Me.KeyCode_5_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 5", True))
        Me.KeyCode_5_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_5_TextBox.Location = New System.Drawing.Point(3, 856)
        Me.KeyCode_5_TextBox.Name = "KeyCode_5_TextBox"
        Me.KeyCode_5_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_5_TextBox.TabIndex = 28
        Me.KeyCode_5_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_4_TextBox
        '
        Me.Part_4_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #4", True))
        Me.Part_4_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_4_TextBox.Location = New System.Drawing.Point(68, 830)
        Me.Part_4_TextBox.Name = "Part_4_TextBox"
        Me.Part_4_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_4_TextBox.TabIndex = 27
        '
        'KeyCode_4_TextBox
        '
        Me.KeyCode_4_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 4", True))
        Me.KeyCode_4_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_4_TextBox.Location = New System.Drawing.Point(3, 830)
        Me.KeyCode_4_TextBox.Name = "KeyCode_4_TextBox"
        Me.KeyCode_4_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_4_TextBox.TabIndex = 26
        Me.KeyCode_4_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_3_TextBox
        '
        Me.Part_3_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #3", True))
        Me.Part_3_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_3_TextBox.Location = New System.Drawing.Point(68, 804)
        Me.Part_3_TextBox.Name = "Part_3_TextBox"
        Me.Part_3_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_3_TextBox.TabIndex = 25
        '
        'KeyCode_3_TextBox
        '
        Me.KeyCode_3_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 3", True))
        Me.KeyCode_3_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_3_TextBox.Location = New System.Drawing.Point(3, 804)
        Me.KeyCode_3_TextBox.Name = "KeyCode_3_TextBox"
        Me.KeyCode_3_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_3_TextBox.TabIndex = 24
        Me.KeyCode_3_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_2_TextBox
        '
        Me.Part_2_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #2", True))
        Me.Part_2_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_2_TextBox.Location = New System.Drawing.Point(68, 778)
        Me.Part_2_TextBox.Name = "Part_2_TextBox"
        Me.Part_2_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_2_TextBox.TabIndex = 23
        '
        'KeyCode_2_TextBox
        '
        Me.KeyCode_2_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 2", True))
        Me.KeyCode_2_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_2_TextBox.Location = New System.Drawing.Point(3, 778)
        Me.KeyCode_2_TextBox.Name = "KeyCode_2_TextBox"
        Me.KeyCode_2_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_2_TextBox.TabIndex = 22
        Me.KeyCode_2_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Part_1_TextBox
        '
        Me.Part_1_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Part #1", True))
        Me.Part_1_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Part_1_TextBox.Location = New System.Drawing.Point(68, 752)
        Me.Part_1_TextBox.Name = "Part_1_TextBox"
        Me.Part_1_TextBox.Size = New System.Drawing.Size(215, 22)
        Me.Part_1_TextBox.TabIndex = 21
        '
        'KeyCode_1_TextBox
        '
        Me.KeyCode_1_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "KeyCode 1", True))
        Me.KeyCode_1_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyCode_1_TextBox.Location = New System.Drawing.Point(3, 752)
        Me.KeyCode_1_TextBox.Name = "KeyCode_1_TextBox"
        Me.KeyCode_1_TextBox.Size = New System.Drawing.Size(46, 22)
        Me.KeyCode_1_TextBox.TabIndex = 20
        Me.KeyCode_1_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChartName_TextBox
        '
        Me.ChartName_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartsBindingSource, "Chart Name", True))
        Me.ChartName_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChartName_TextBox.Location = New System.Drawing.Point(3, 692)
        Me.ChartName_TextBox.Name = "ChartName_TextBox"
        Me.ChartName_TextBox.Size = New System.Drawing.Size(150, 22)
        Me.ChartName_TextBox.TabIndex = 19
        '
        'Bowl_1_TextBox
        '
        Me.Bowl_1_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_1_TextBox.Location = New System.Drawing.Point(288, 752)
        Me.Bowl_1_TextBox.Name = "Bowl_1_TextBox"
        Me.Bowl_1_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_1_TextBox.TabIndex = 37
        '
        'Stepped_1_TextBox
        '
        Me.Stepped_1_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_1_TextBox.Location = New System.Drawing.Point(364, 752)
        Me.Stepped_1_TextBox.Name = "Stepped_1_TextBox"
        Me.Stepped_1_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_1_TextBox.TabIndex = 38
        '
        'Charts_DataGridView
        '
        Me.Charts_DataGridView.AllowUserToAddRows = False
        Me.Charts_DataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Charts_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Charts_DataGridView.AutoGenerateColumns = False
        Me.Charts_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Charts_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Charts_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Charts_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Charts_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChartNameDataGridViewTextBoxColumn, Me.PartTypeDataGridViewTextBoxColumn, Me.KeyCode1DataGridViewTextBoxColumn, Me.Part1DataGridViewTextBoxColumn, Me.KeyCode2DataGridViewTextBoxColumn, Me.Part2DataGridViewTextBoxColumn, Me.KeyCode3DataGridViewTextBoxColumn, Me.Part3DataGridViewTextBoxColumn, Me.KeyCode4DataGridViewTextBoxColumn, Me.Part4DataGridViewTextBoxColumn, Me.KeyCode5DataGridViewTextBoxColumn, Me.Part5DataGridViewTextBoxColumn, Me.KeyCode6DataGridViewTextBoxColumn, Me.Part6DataGridViewTextBoxColumn, Me.KeyCode7DataGridViewTextBoxColumn, Me.Part7DataGridViewTextBoxColumn, Me.KeyCode8DataGridViewTextBoxColumn, Me.Part8DataGridViewTextBoxColumn})
        Me.Charts_DataGridView.DataSource = Me.ChartsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Charts_DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.Charts_DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Charts_DataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Charts_DataGridView.MultiSelect = False
        Me.Charts_DataGridView.Name = "Charts_DataGridView"
        Me.Charts_DataGridView.ReadOnly = True
        Me.Charts_DataGridView.Size = New System.Drawing.Size(1581, 621)
        Me.Charts_DataGridView.TabIndex = 40
        '
        'ChartNameDataGridViewTextBoxColumn
        '
        Me.ChartNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ChartNameDataGridViewTextBoxColumn.DataPropertyName = "Chart Name"
        Me.ChartNameDataGridViewTextBoxColumn.HeaderText = "Chart Name"
        Me.ChartNameDataGridViewTextBoxColumn.Name = "ChartNameDataGridViewTextBoxColumn"
        Me.ChartNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChartNameDataGridViewTextBoxColumn.Width = 104
        '
        'PartTypeDataGridViewTextBoxColumn
        '
        Me.PartTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PartTypeDataGridViewTextBoxColumn.DataPropertyName = "Part Type"
        Me.PartTypeDataGridViewTextBoxColumn.HeaderText = "Part Type"
        Me.PartTypeDataGridViewTextBoxColumn.Name = "PartTypeDataGridViewTextBoxColumn"
        Me.PartTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.PartTypeDataGridViewTextBoxColumn.Width = 92
        '
        'KeyCode1DataGridViewTextBoxColumn
        '
        Me.KeyCode1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KeyCode1DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 1"
        Me.KeyCode1DataGridViewTextBoxColumn.HeaderText = "KeyCode 1"
        Me.KeyCode1DataGridViewTextBoxColumn.Name = "KeyCode1DataGridViewTextBoxColumn"
        Me.KeyCode1DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode1DataGridViewTextBoxColumn.Width = 99
        '
        'Part1DataGridViewTextBoxColumn
        '
        Me.Part1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Part1DataGridViewTextBoxColumn.DataPropertyName = "Part #1"
        Me.Part1DataGridViewTextBoxColumn.HeaderText = "Part #1"
        Me.Part1DataGridViewTextBoxColumn.Name = "Part1DataGridViewTextBoxColumn"
        Me.Part1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part1DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode2DataGridViewTextBoxColumn
        '
        Me.KeyCode2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KeyCode2DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 2"
        Me.KeyCode2DataGridViewTextBoxColumn.HeaderText = "KeyCode 2"
        Me.KeyCode2DataGridViewTextBoxColumn.Name = "KeyCode2DataGridViewTextBoxColumn"
        Me.KeyCode2DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode2DataGridViewTextBoxColumn.Width = 99
        '
        'Part2DataGridViewTextBoxColumn
        '
        Me.Part2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Part2DataGridViewTextBoxColumn.DataPropertyName = "Part #2"
        Me.Part2DataGridViewTextBoxColumn.HeaderText = "Part #2"
        Me.Part2DataGridViewTextBoxColumn.Name = "Part2DataGridViewTextBoxColumn"
        Me.Part2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part2DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode3DataGridViewTextBoxColumn
        '
        Me.KeyCode3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KeyCode3DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 3"
        Me.KeyCode3DataGridViewTextBoxColumn.HeaderText = "KeyCode 3"
        Me.KeyCode3DataGridViewTextBoxColumn.Name = "KeyCode3DataGridViewTextBoxColumn"
        Me.KeyCode3DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode3DataGridViewTextBoxColumn.Width = 99
        '
        'Part3DataGridViewTextBoxColumn
        '
        Me.Part3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Part3DataGridViewTextBoxColumn.DataPropertyName = "Part #3"
        Me.Part3DataGridViewTextBoxColumn.HeaderText = "Part #3"
        Me.Part3DataGridViewTextBoxColumn.Name = "Part3DataGridViewTextBoxColumn"
        Me.Part3DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part3DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode4DataGridViewTextBoxColumn
        '
        Me.KeyCode4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KeyCode4DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 4"
        Me.KeyCode4DataGridViewTextBoxColumn.HeaderText = "KeyCode 4"
        Me.KeyCode4DataGridViewTextBoxColumn.Name = "KeyCode4DataGridViewTextBoxColumn"
        Me.KeyCode4DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode4DataGridViewTextBoxColumn.Width = 99
        '
        'Part4DataGridViewTextBoxColumn
        '
        Me.Part4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Part4DataGridViewTextBoxColumn.DataPropertyName = "Part #4"
        Me.Part4DataGridViewTextBoxColumn.HeaderText = "Part #4"
        Me.Part4DataGridViewTextBoxColumn.Name = "Part4DataGridViewTextBoxColumn"
        Me.Part4DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part4DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode5DataGridViewTextBoxColumn
        '
        Me.KeyCode5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KeyCode5DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 5"
        Me.KeyCode5DataGridViewTextBoxColumn.HeaderText = "KeyCode 5"
        Me.KeyCode5DataGridViewTextBoxColumn.Name = "KeyCode5DataGridViewTextBoxColumn"
        Me.KeyCode5DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode5DataGridViewTextBoxColumn.Width = 99
        '
        'Part5DataGridViewTextBoxColumn
        '
        Me.Part5DataGridViewTextBoxColumn.DataPropertyName = "Part #5"
        Me.Part5DataGridViewTextBoxColumn.HeaderText = "Part #5"
        Me.Part5DataGridViewTextBoxColumn.Name = "Part5DataGridViewTextBoxColumn"
        Me.Part5DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part5DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode6DataGridViewTextBoxColumn
        '
        Me.KeyCode6DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 6"
        Me.KeyCode6DataGridViewTextBoxColumn.HeaderText = "KeyCode 6"
        Me.KeyCode6DataGridViewTextBoxColumn.Name = "KeyCode6DataGridViewTextBoxColumn"
        Me.KeyCode6DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode6DataGridViewTextBoxColumn.Width = 99
        '
        'Part6DataGridViewTextBoxColumn
        '
        Me.Part6DataGridViewTextBoxColumn.DataPropertyName = "Part #6"
        Me.Part6DataGridViewTextBoxColumn.HeaderText = "Part #6"
        Me.Part6DataGridViewTextBoxColumn.Name = "Part6DataGridViewTextBoxColumn"
        Me.Part6DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part6DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode7DataGridViewTextBoxColumn
        '
        Me.KeyCode7DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 7"
        Me.KeyCode7DataGridViewTextBoxColumn.HeaderText = "KeyCode 7"
        Me.KeyCode7DataGridViewTextBoxColumn.Name = "KeyCode7DataGridViewTextBoxColumn"
        Me.KeyCode7DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode7DataGridViewTextBoxColumn.Width = 99
        '
        'Part7DataGridViewTextBoxColumn
        '
        Me.Part7DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Part7DataGridViewTextBoxColumn.DataPropertyName = "Part #7"
        Me.Part7DataGridViewTextBoxColumn.HeaderText = "Part #7"
        Me.Part7DataGridViewTextBoxColumn.Name = "Part7DataGridViewTextBoxColumn"
        Me.Part7DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part7DataGridViewTextBoxColumn.Width = 74
        '
        'KeyCode8DataGridViewTextBoxColumn
        '
        Me.KeyCode8DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.KeyCode8DataGridViewTextBoxColumn.DataPropertyName = "KeyCode 8"
        Me.KeyCode8DataGridViewTextBoxColumn.HeaderText = "KeyCode 8"
        Me.KeyCode8DataGridViewTextBoxColumn.Name = "KeyCode8DataGridViewTextBoxColumn"
        Me.KeyCode8DataGridViewTextBoxColumn.ReadOnly = True
        Me.KeyCode8DataGridViewTextBoxColumn.Width = 99
        '
        'Part8DataGridViewTextBoxColumn
        '
        Me.Part8DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Part8DataGridViewTextBoxColumn.DataPropertyName = "Part #8"
        Me.Part8DataGridViewTextBoxColumn.HeaderText = "Part #8"
        Me.Part8DataGridViewTextBoxColumn.Name = "Part8DataGridViewTextBoxColumn"
        Me.Part8DataGridViewTextBoxColumn.ReadOnly = True
        Me.Part8DataGridViewTextBoxColumn.Width = 74
        '
        'Bottom_TumblerBindingSource
        '
        Me.Bottom_TumblerBindingSource.DataMember = "Bottom Tumbler"
        Me.Bottom_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'ChartsTableAdapter
        '
        Me.ChartsTableAdapter.ClearBeforeFill = True
        '
        'Bottom_TumblerTableAdapter
        '
        Me.Bottom_TumblerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarrelTableAdapter = Nothing
        Me.TableAdapterManager.Bottom_TumblerTableAdapter = Me.Bottom_TumblerTableAdapter
        Me.TableAdapterManager.BushingTableAdapter = Nothing
        Me.TableAdapterManager.ChartsTableAdapter = Me.ChartsTableAdapter
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
        'Mid_TumblerBindingSource
        '
        Me.Mid_TumblerBindingSource.DataMember = "Mid Tumbler"
        Me.Mid_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Mid_TumblerTableAdapter
        '
        Me.Mid_TumblerTableAdapter.ClearBeforeFill = True
        '
        'Top_TumblerBindingSource
        '
        Me.Top_TumblerBindingSource.DataMember = "Top Tumbler"
        Me.Top_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Top_TumblerTableAdapter
        '
        Me.Top_TumblerTableAdapter.ClearBeforeFill = True
        '
        'SpringsBindingSource
        '
        Me.SpringsBindingSource.DataMember = "Springs"
        Me.SpringsBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'SpringsTableAdapter
        '
        Me.SpringsTableAdapter.ClearBeforeFill = True
        '
        'Stepped_2_TextBox
        '
        Me.Stepped_2_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_2_TextBox.Location = New System.Drawing.Point(363, 778)
        Me.Stepped_2_TextBox.Name = "Stepped_2_TextBox"
        Me.Stepped_2_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_2_TextBox.TabIndex = 42
        '
        'Bowl_2_TextBox
        '
        Me.Bowl_2_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_2_TextBox.Location = New System.Drawing.Point(287, 778)
        Me.Bowl_2_TextBox.Name = "Bowl_2_TextBox"
        Me.Bowl_2_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_2_TextBox.TabIndex = 41
        '
        'Stepped_3_TextBox
        '
        Me.Stepped_3_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_3_TextBox.Location = New System.Drawing.Point(364, 804)
        Me.Stepped_3_TextBox.Name = "Stepped_3_TextBox"
        Me.Stepped_3_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_3_TextBox.TabIndex = 44
        '
        'Bowl_3_TextBox
        '
        Me.Bowl_3_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_3_TextBox.Location = New System.Drawing.Point(288, 804)
        Me.Bowl_3_TextBox.Name = "Bowl_3_TextBox"
        Me.Bowl_3_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_3_TextBox.TabIndex = 43
        '
        'Stepped_4_TextBox
        '
        Me.Stepped_4_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_4_TextBox.Location = New System.Drawing.Point(364, 830)
        Me.Stepped_4_TextBox.Name = "Stepped_4_TextBox"
        Me.Stepped_4_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_4_TextBox.TabIndex = 46
        '
        'Bowl_4_TextBox
        '
        Me.Bowl_4_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_4_TextBox.Location = New System.Drawing.Point(288, 830)
        Me.Bowl_4_TextBox.Name = "Bowl_4_TextBox"
        Me.Bowl_4_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_4_TextBox.TabIndex = 45
        '
        'Stepped_5_TextBox
        '
        Me.Stepped_5_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_5_TextBox.Location = New System.Drawing.Point(363, 856)
        Me.Stepped_5_TextBox.Name = "Stepped_5_TextBox"
        Me.Stepped_5_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_5_TextBox.TabIndex = 48
        '
        'Bowl_5_TextBox
        '
        Me.Bowl_5_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_5_TextBox.Location = New System.Drawing.Point(287, 856)
        Me.Bowl_5_TextBox.Name = "Bowl_5_TextBox"
        Me.Bowl_5_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_5_TextBox.TabIndex = 47
        '
        'Stepped_6_TextBox
        '
        Me.Stepped_6_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_6_TextBox.Location = New System.Drawing.Point(363, 882)
        Me.Stepped_6_TextBox.Name = "Stepped_6_TextBox"
        Me.Stepped_6_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_6_TextBox.TabIndex = 50
        '
        'Bowl_6_TextBox
        '
        Me.Bowl_6_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_6_TextBox.Location = New System.Drawing.Point(287, 882)
        Me.Bowl_6_TextBox.Name = "Bowl_6_TextBox"
        Me.Bowl_6_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_6_TextBox.TabIndex = 49
        '
        'Stepped_7_TextBox
        '
        Me.Stepped_7_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_7_TextBox.Location = New System.Drawing.Point(364, 908)
        Me.Stepped_7_TextBox.Name = "Stepped_7_TextBox"
        Me.Stepped_7_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_7_TextBox.TabIndex = 52
        '
        'Bowl_7_TextBox
        '
        Me.Bowl_7_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_7_TextBox.Location = New System.Drawing.Point(288, 908)
        Me.Bowl_7_TextBox.Name = "Bowl_7_TextBox"
        Me.Bowl_7_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_7_TextBox.TabIndex = 51
        '
        'Stepped_8_TextBox
        '
        Me.Stepped_8_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stepped_8_TextBox.Location = New System.Drawing.Point(364, 934)
        Me.Stepped_8_TextBox.Name = "Stepped_8_TextBox"
        Me.Stepped_8_TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Stepped_8_TextBox.TabIndex = 54
        '
        'Bowl_8_TextBox
        '
        Me.Bowl_8_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_8_TextBox.Location = New System.Drawing.Point(288, 934)
        Me.Bowl_8_TextBox.Name = "Bowl_8_TextBox"
        Me.Bowl_8_TextBox.Size = New System.Drawing.Size(71, 22)
        Me.Bowl_8_TextBox.TabIndex = 53
        '
        'ReadOnly_CheckBox
        '
        Me.ReadOnly_CheckBox.AutoSize = True
        Me.ReadOnly_CheckBox.Checked = Global.MfgControl.AdvancedHMI.My.MySettings.Default.ChartDataGridReadOnly
        Me.ReadOnly_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ReadOnly_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MfgControl.AdvancedHMI.My.MySettings.Default, "ChartDataGridReadOnly", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ReadOnly_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadOnly_CheckBox.Location = New System.Drawing.Point(1295, 670)
        Me.ReadOnly_CheckBox.Name = "ReadOnly_CheckBox"
        Me.ReadOnly_CheckBox.Size = New System.Drawing.Size(164, 20)
        Me.ReadOnly_CheckBox.TabIndex = 39
        Me.ReadOnly_CheckBox.Text = "Charts Data Read Only"
        Me.ReadOnly_CheckBox.UseVisualStyleBackColor = True
        Me.ReadOnly_CheckBox.Visible = False
        '
        'Delete_Button
        '
        Me.Delete_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Button.Location = New System.Drawing.Point(1214, 669)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 370
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        '
        'Insert_Button
        '
        Me.Insert_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert_Button.Location = New System.Drawing.Point(1133, 669)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 369
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        '
        'Update_Button
        '
        Me.Update_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Button.Location = New System.Drawing.Point(1052, 669)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 368
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 731)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Keycode"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 731)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Part"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 731)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 373
        Me.Label3.Text = "Bowl"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 731)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 374
        Me.Label4.Text = "Stepped"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Charts_Form
        '
        Me.AccessibleDescription = "Charts"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 961)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Stepped_8_TextBox)
        Me.Controls.Add(Me.Bowl_8_TextBox)
        Me.Controls.Add(Me.Stepped_7_TextBox)
        Me.Controls.Add(Me.Bowl_7_TextBox)
        Me.Controls.Add(Me.Stepped_6_TextBox)
        Me.Controls.Add(Me.Bowl_6_TextBox)
        Me.Controls.Add(Me.Stepped_5_TextBox)
        Me.Controls.Add(Me.Bowl_5_TextBox)
        Me.Controls.Add(Me.Stepped_4_TextBox)
        Me.Controls.Add(Me.Bowl_4_TextBox)
        Me.Controls.Add(Me.Stepped_3_TextBox)
        Me.Controls.Add(Me.Bowl_3_TextBox)
        Me.Controls.Add(Me.Stepped_2_TextBox)
        Me.Controls.Add(Me.Bowl_2_TextBox)
        Me.Controls.Add(Me.Charts_DataGridView)
        Me.Controls.Add(Me.ReadOnly_CheckBox)
        Me.Controls.Add(Me.Stepped_1_TextBox)
        Me.Controls.Add(Me.Bowl_1_TextBox)
        Me.Controls.Add(Me.PartType_TextBox)
        Me.Controls.Add(Me.Part_8_TextBox)
        Me.Controls.Add(Me.KeyCode_8_TextBox)
        Me.Controls.Add(Me.Part_7_TextBox)
        Me.Controls.Add(Me.KeyCode_7_TextBox)
        Me.Controls.Add(Me.Part_6_TextBox)
        Me.Controls.Add(Me.KeyCode_6_TextBox)
        Me.Controls.Add(Me.Part_5_TextBox)
        Me.Controls.Add(Me.KeyCode_5_TextBox)
        Me.Controls.Add(Me.Part_4_TextBox)
        Me.Controls.Add(Me.KeyCode_4_TextBox)
        Me.Controls.Add(Me.Part_3_TextBox)
        Me.Controls.Add(Me.KeyCode_3_TextBox)
        Me.Controls.Add(Me.Part_2_TextBox)
        Me.Controls.Add(Me.KeyCode_2_TextBox)
        Me.Controls.Add(Me.Part_1_TextBox)
        Me.Controls.Add(Me.KeyCode_1_TextBox)
        Me.Controls.Add(Me.ChartName_TextBox)
        Me.Name = "Charts_Form"
        Me.Tag = "Tumblers"
        Me.Text = "Charts"
        CType(Me.ChartsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charts_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mid_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpringsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents ChartsBindingSource As BindingSource
    Friend WithEvents ChartsTableAdapter As NCLRecipeDataSetTableAdapters.ChartsTableAdapter
    Friend WithEvents PartType_TextBox As TextBox
    Friend WithEvents Part_8_TextBox As TextBox
    Friend WithEvents KeyCode_8_TextBox As TextBox
    Friend WithEvents Part_7_TextBox As TextBox
    Friend WithEvents KeyCode_7_TextBox As TextBox
    Friend WithEvents Part_6_TextBox As TextBox
    Friend WithEvents KeyCode_6_TextBox As TextBox
    Friend WithEvents Part_5_TextBox As TextBox
    Friend WithEvents KeyCode_5_TextBox As TextBox
    Friend WithEvents Part_4_TextBox As TextBox
    Friend WithEvents KeyCode_4_TextBox As TextBox
    Friend WithEvents Part_3_TextBox As TextBox
    Friend WithEvents KeyCode_3_TextBox As TextBox
    Friend WithEvents Part_2_TextBox As TextBox
    Friend WithEvents KeyCode_2_TextBox As TextBox
    Friend WithEvents Part_1_TextBox As TextBox
    Friend WithEvents KeyCode_1_TextBox As TextBox
    Friend WithEvents ChartName_TextBox As TextBox
    Friend WithEvents Bottom_TumblerBindingSource As BindingSource
    Friend WithEvents Bottom_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Bottom_TumblerTableAdapter
    Friend WithEvents TableAdapterManager As NCLRecipeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Mid_TumblerBindingSource As BindingSource
    Friend WithEvents Mid_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Mid_TumblerTableAdapter
    Friend WithEvents Top_TumblerBindingSource As BindingSource
    Friend WithEvents Top_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Top_TumblerTableAdapter
    Friend WithEvents Bowl_1_TextBox As TextBox
    Friend WithEvents Stepped_1_TextBox As TextBox
    Friend WithEvents Charts_DataGridView As DataGridView
    Friend WithEvents SpringsBindingSource As BindingSource
    Friend WithEvents SpringsTableAdapter As NCLRecipeDataSetTableAdapters.SpringsTableAdapter
    Friend WithEvents Stepped_2_TextBox As TextBox
    Friend WithEvents Bowl_2_TextBox As TextBox
    Friend WithEvents Stepped_3_TextBox As TextBox
    Friend WithEvents Bowl_3_TextBox As TextBox
    Friend WithEvents Stepped_4_TextBox As TextBox
    Friend WithEvents Bowl_4_TextBox As TextBox
    Friend WithEvents Stepped_5_TextBox As TextBox
    Friend WithEvents Bowl_5_TextBox As TextBox
    Friend WithEvents Stepped_6_TextBox As TextBox
    Friend WithEvents Bowl_6_TextBox As TextBox
    Friend WithEvents Stepped_7_TextBox As TextBox
    Friend WithEvents Bowl_7_TextBox As TextBox
    Friend WithEvents Stepped_8_TextBox As TextBox
    Friend WithEvents Bowl_8_TextBox As TextBox
    Friend WithEvents ReadOnly_CheckBox As CheckBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ChartNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PartTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeyCode8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
