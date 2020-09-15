<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sta13_Form
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolingNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GripperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShotpinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReClockPosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReClockRotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Station13ToolingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.Tool_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Station_13_ToolingTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Station_13_ToolingTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gripper_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Orient_ComboBox = New System.Windows.Forms.ComboBox()
        Me.ShotPin_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Place_ComboBox = New System.Windows.Forms.ComboBox()
        Me.ReClockPos_ComboBox = New System.Windows.Forms.ComboBox()
        Me.ReClockRot_ComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Station13ToolingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToolingNameDataGridViewTextBoxColumn, Me.GripperDataGridViewTextBoxColumn, Me.OrientDataGridViewTextBoxColumn, Me.ShotpinDataGridViewTextBoxColumn, Me.PlaceDataGridViewTextBoxColumn, Me.ReClockPosDataGridViewTextBoxColumn, Me.ReClockRotDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Station13ToolingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 35)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(778, 143)
        Me.DataGridView1.TabIndex = 334
        '
        'ToolingNameDataGridViewTextBoxColumn
        '
        Me.ToolingNameDataGridViewTextBoxColumn.DataPropertyName = "Tooling Name"
        Me.ToolingNameDataGridViewTextBoxColumn.HeaderText = "Tooling Name"
        Me.ToolingNameDataGridViewTextBoxColumn.Name = "ToolingNameDataGridViewTextBoxColumn"
        Me.ToolingNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToolingNameDataGridViewTextBoxColumn.Width = 98
        '
        'GripperDataGridViewTextBoxColumn
        '
        Me.GripperDataGridViewTextBoxColumn.DataPropertyName = "Gripper"
        Me.GripperDataGridViewTextBoxColumn.HeaderText = "Gripper"
        Me.GripperDataGridViewTextBoxColumn.Name = "GripperDataGridViewTextBoxColumn"
        Me.GripperDataGridViewTextBoxColumn.ReadOnly = True
        Me.GripperDataGridViewTextBoxColumn.Width = 66
        '
        'OrientDataGridViewTextBoxColumn
        '
        Me.OrientDataGridViewTextBoxColumn.DataPropertyName = "Orient"
        Me.OrientDataGridViewTextBoxColumn.HeaderText = "Orient"
        Me.OrientDataGridViewTextBoxColumn.Name = "OrientDataGridViewTextBoxColumn"
        Me.OrientDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrientDataGridViewTextBoxColumn.Width = 60
        '
        'ShotpinDataGridViewTextBoxColumn
        '
        Me.ShotpinDataGridViewTextBoxColumn.DataPropertyName = "Shotpin"
        Me.ShotpinDataGridViewTextBoxColumn.HeaderText = "Shotpin"
        Me.ShotpinDataGridViewTextBoxColumn.Name = "ShotpinDataGridViewTextBoxColumn"
        Me.ShotpinDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShotpinDataGridViewTextBoxColumn.Width = 68
        '
        'PlaceDataGridViewTextBoxColumn
        '
        Me.PlaceDataGridViewTextBoxColumn.DataPropertyName = "Place"
        Me.PlaceDataGridViewTextBoxColumn.HeaderText = "Place"
        Me.PlaceDataGridViewTextBoxColumn.Name = "PlaceDataGridViewTextBoxColumn"
        Me.PlaceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlaceDataGridViewTextBoxColumn.Width = 59
        '
        'ReClockPosDataGridViewTextBoxColumn
        '
        Me.ReClockPosDataGridViewTextBoxColumn.DataPropertyName = "ReClock Pos"
        Me.ReClockPosDataGridViewTextBoxColumn.HeaderText = "ReClock Pos"
        Me.ReClockPosDataGridViewTextBoxColumn.Name = "ReClockPosDataGridViewTextBoxColumn"
        Me.ReClockPosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReClockPosDataGridViewTextBoxColumn.Width = 94
        '
        'ReClockRotDataGridViewTextBoxColumn
        '
        Me.ReClockRotDataGridViewTextBoxColumn.DataPropertyName = "ReClock Rot"
        Me.ReClockRotDataGridViewTextBoxColumn.HeaderText = "ReClock Rot"
        Me.ReClockRotDataGridViewTextBoxColumn.Name = "ReClockRotDataGridViewTextBoxColumn"
        Me.ReClockRotDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReClockRotDataGridViewTextBoxColumn.Width = 93
        '
        'Station13ToolingBindingSource
        '
        Me.Station13ToolingBindingSource.DataMember = "Station 13 Tooling"
        Me.Station13ToolingBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tool_ComboBox
        '
        Me.Tool_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "Tooling Name", True))
        Me.Tool_ComboBox.FormattingEnabled = True
        Me.Tool_ComboBox.Location = New System.Drawing.Point(142, 208)
        Me.Tool_ComboBox.Name = "Tool_ComboBox"
        Me.Tool_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.Tool_ComboBox.TabIndex = 333
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(228, 416)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 332
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(147, 416)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 331
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(66, 416)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 330
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(13, 262)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(100, 13)
        Me.Label32.TabIndex = 329
        Me.Label32.Tag = ""
        Me.Label32.Text = "Orient"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(13, 236)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(100, 13)
        Me.Label33.TabIndex = 328
        Me.Label33.Tag = ""
        Me.Label33.Text = "Gripper"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(13, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 327
        Me.Label9.Tag = ""
        Me.Label9.Text = "Tooling Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Station_13_ToolingTableAdapter
        '
        Me.Station_13_ToolingTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 364
        Me.Label1.Tag = ""
        Me.Label1.Text = "Shot Pin"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 366
        Me.Label2.Tag = ""
        Me.Label2.Text = "Place"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 368
        Me.Label3.Tag = ""
        Me.Label3.Text = "ReClock Position"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(13, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 370
        Me.Label4.Tag = ""
        Me.Label4.Text = "ReClock Rotation"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gripper_ComboBox
        '
        Me.Gripper_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "Gripper", True))
        Me.Gripper_ComboBox.DataSource = Me.Station13ToolingBindingSource
        Me.Gripper_ComboBox.DisplayMember = "Gripper"
        Me.Gripper_ComboBox.FormattingEnabled = True
        Me.Gripper_ComboBox.Location = New System.Drawing.Point(142, 235)
        Me.Gripper_ComboBox.Name = "Gripper_ComboBox"
        Me.Gripper_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.Gripper_ComboBox.TabIndex = 372
        '
        'Orient_ComboBox
        '
        Me.Orient_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "Orient", True))
        Me.Orient_ComboBox.DataSource = Me.Station13ToolingBindingSource
        Me.Orient_ComboBox.DisplayMember = "Orient"
        Me.Orient_ComboBox.FormattingEnabled = True
        Me.Orient_ComboBox.Location = New System.Drawing.Point(142, 262)
        Me.Orient_ComboBox.Name = "Orient_ComboBox"
        Me.Orient_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.Orient_ComboBox.TabIndex = 373
        '
        'ShotPin_ComboBox
        '
        Me.ShotPin_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "Shotpin", True))
        Me.ShotPin_ComboBox.DataSource = Me.Station13ToolingBindingSource
        Me.ShotPin_ComboBox.DisplayMember = "Shotpin"
        Me.ShotPin_ComboBox.FormattingEnabled = True
        Me.ShotPin_ComboBox.Location = New System.Drawing.Point(142, 289)
        Me.ShotPin_ComboBox.Name = "ShotPin_ComboBox"
        Me.ShotPin_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ShotPin_ComboBox.TabIndex = 374
        '
        'Place_ComboBox
        '
        Me.Place_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "Place", True))
        Me.Place_ComboBox.DataSource = Me.Station13ToolingBindingSource
        Me.Place_ComboBox.DisplayMember = "Place"
        Me.Place_ComboBox.FormattingEnabled = True
        Me.Place_ComboBox.Location = New System.Drawing.Point(142, 314)
        Me.Place_ComboBox.Name = "Place_ComboBox"
        Me.Place_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.Place_ComboBox.TabIndex = 375
        '
        'ReClockPos_ComboBox
        '
        Me.ReClockPos_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "ReClock Pos", True))
        Me.ReClockPos_ComboBox.DataSource = Me.Station13ToolingBindingSource
        Me.ReClockPos_ComboBox.DisplayMember = "ReClock Pos"
        Me.ReClockPos_ComboBox.FormattingEnabled = True
        Me.ReClockPos_ComboBox.Location = New System.Drawing.Point(142, 341)
        Me.ReClockPos_ComboBox.Name = "ReClockPos_ComboBox"
        Me.ReClockPos_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ReClockPos_ComboBox.TabIndex = 376
        '
        'ReClockRot_ComboBox
        '
        Me.ReClockRot_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station13ToolingBindingSource, "ReClock Rot", True))
        Me.ReClockRot_ComboBox.DataSource = Me.Station13ToolingBindingSource
        Me.ReClockRot_ComboBox.DisplayMember = "ReClock Rot"
        Me.ReClockRot_ComboBox.FormattingEnabled = True
        Me.ReClockRot_ComboBox.Location = New System.Drawing.Point(142, 365)
        Me.ReClockRot_ComboBox.Name = "ReClockRot_ComboBox"
        Me.ReClockRot_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ReClockRot_ComboBox.TabIndex = 377
        '
        'Sta13_Form
        '
        Me.AccessibleDescription = "Station 13"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 451)
        Me.Controls.Add(Me.ReClockRot_ComboBox)
        Me.Controls.Add(Me.ReClockPos_ComboBox)
        Me.Controls.Add(Me.Place_ComboBox)
        Me.Controls.Add(Me.ShotPin_ComboBox)
        Me.Controls.Add(Me.Orient_ComboBox)
        Me.Controls.Add(Me.Gripper_ComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Tool_ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Sta13_Form"
        Me.Tag = "Station"
        Me.Text = "Station 13"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Station13ToolingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Tool_ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents Station13ToolingBindingSource As BindingSource
    Friend WithEvents Station_13_ToolingTableAdapter As NCLRecipeDataSetTableAdapters.Station_13_ToolingTableAdapter
    Friend WithEvents ToolingNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GripperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShotpinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReClockPosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReClockRotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Gripper_ComboBox As ComboBox
    Friend WithEvents Orient_ComboBox As ComboBox
    Friend WithEvents ShotPin_ComboBox As ComboBox
    Friend WithEvents Place_ComboBox As ComboBox
    Friend WithEvents ReClockPos_ComboBox As ComboBox
    Friend WithEvents ReClockRot_ComboBox As ComboBox
End Class
