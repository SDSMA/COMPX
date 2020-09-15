<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BotTumbler_Form
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
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.Bottom_TumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.TableAdapterManager()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Bottom_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Bottom_TumblerTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BottomTumblerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BowlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SteppedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bowl_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Stepped_ComboBox = New System.Windows.Forms.ComboBox()
        Me.BarrelTableAdapter1 = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.BarrelTableAdapter()
        Me.BarrelTableAdapter2 = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.BarrelTableAdapter()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom_TumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Bottom_TumblerBindingSource
        '
        Me.Bottom_TumblerBindingSource.DataMember = "Bottom Tumbler"
        Me.Bottom_TumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 156
        Me.Label9.Tag = ""
        Me.Label9.Text = "Bottom Tumbler"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(9, 274)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 16)
        Me.Label32.TabIndex = 181
        Me.Label32.Tag = ""
        Me.Label32.Text = "Stepped"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(9, 248)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 16)
        Me.Label33.TabIndex = 180
        Me.Label33.Tag = ""
        Me.Label33.Text = "Bowl"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(12, 326)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 320
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(93, 327)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 321
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(174, 327)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 322
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bottom_TumblerBindingSource, "Bottom Tumbler", True))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(142, 220)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox.TabIndex = 323
        '
        'Bottom_TumblerTableAdapter
        '
        Me.Bottom_TumblerTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BottomTumblerDataGridViewTextBoxColumn, Me.BowlDataGridViewTextBoxColumn, Me.SteppedDataGridViewTextBoxColumn})
        Me.DataGridView1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Bottom_TumblerBindingSource, "Bottom Tumbler", True))
        Me.DataGridView1.DataSource = Me.Bottom_TumblerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(360, 174)
        Me.DataGridView1.TabIndex = 324
        '
        'BottomTumblerDataGridViewTextBoxColumn
        '
        Me.BottomTumblerDataGridViewTextBoxColumn.DataPropertyName = "Bottom Tumbler"
        Me.BottomTumblerDataGridViewTextBoxColumn.HeaderText = "Bottom Tumbler"
        Me.BottomTumblerDataGridViewTextBoxColumn.Name = "BottomTumblerDataGridViewTextBoxColumn"
        Me.BottomTumblerDataGridViewTextBoxColumn.ReadOnly = True
        Me.BottomTumblerDataGridViewTextBoxColumn.Width = 97
        '
        'BowlDataGridViewTextBoxColumn
        '
        Me.BowlDataGridViewTextBoxColumn.DataPropertyName = "Bowl"
        Me.BowlDataGridViewTextBoxColumn.HeaderText = "Bowl"
        Me.BowlDataGridViewTextBoxColumn.Name = "BowlDataGridViewTextBoxColumn"
        Me.BowlDataGridViewTextBoxColumn.ReadOnly = True
        Me.BowlDataGridViewTextBoxColumn.Width = 55
        '
        'SteppedDataGridViewTextBoxColumn
        '
        Me.SteppedDataGridViewTextBoxColumn.DataPropertyName = "Stepped"
        Me.SteppedDataGridViewTextBoxColumn.HeaderText = "Stepped"
        Me.SteppedDataGridViewTextBoxColumn.Name = "SteppedDataGridViewTextBoxColumn"
        Me.SteppedDataGridViewTextBoxColumn.ReadOnly = True
        Me.SteppedDataGridViewTextBoxColumn.Width = 72
        '
        'Bowl_ComboBox
        '
        Me.Bowl_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bottom_TumblerBindingSource, "Bowl", True))
        Me.Bowl_ComboBox.FormattingEnabled = True
        Me.Bowl_ComboBox.Location = New System.Drawing.Point(142, 248)
        Me.Bowl_ComboBox.Name = "Bowl_ComboBox"
        Me.Bowl_ComboBox.Size = New System.Drawing.Size(50, 21)
        Me.Bowl_ComboBox.TabIndex = 325
        '
        'Stepped_ComboBox
        '
        Me.Stepped_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bottom_TumblerBindingSource, "Stepped", True))
        Me.Stepped_ComboBox.FormattingEnabled = True
        Me.Stepped_ComboBox.Location = New System.Drawing.Point(142, 275)
        Me.Stepped_ComboBox.Name = "Stepped_ComboBox"
        Me.Stepped_ComboBox.Size = New System.Drawing.Size(50, 21)
        Me.Stepped_ComboBox.TabIndex = 326
        '
        'BarrelTableAdapter1
        '
        Me.BarrelTableAdapter1.ClearBeforeFill = True
        '
        'BarrelTableAdapter2
        '
        Me.BarrelTableAdapter2.ClearBeforeFill = True
        '
        'BotTumbler_Form
        '
        Me.AccessibleDescription = "Bottom Tumbler"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(733, 362)
        Me.Controls.Add(Me.Stepped_ComboBox)
        Me.Controls.Add(Me.Bowl_ComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label9)
        Me.Name = "BotTumbler_Form"
        Me.Tag = "Tumblers"
        Me.Text = "Bottom Tumbler"
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom_TumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents Label9 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents TableAdapterManager As NCLRecipeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Update_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Delete_Button As Button
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Bottom_TumblerBindingSource As BindingSource
    Friend WithEvents Bottom_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Bottom_TumblerTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Bowl_ComboBox As ComboBox
    Friend WithEvents Stepped_ComboBox As ComboBox
    Friend WithEvents BarrelTableAdapter1 As NCLRecipeDataSetTableAdapters.BarrelTableAdapter
    Friend WithEvents BarrelTableAdapter2 As NCLRecipeDataSetTableAdapters.BarrelTableAdapter
    Friend WithEvents BottomTumblerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BowlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SteppedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
