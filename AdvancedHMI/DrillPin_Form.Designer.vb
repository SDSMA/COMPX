<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrillPin_Form
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
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DrillPinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drill_PinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Drill_PinTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Drill_PinTableAdapter()
        Me.TableAdapterManager = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.TableAdapterManager()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drill_PinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DrillPinDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Drill_PinBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(360, 143)
        Me.DataGridView1.TabIndex = 380
        '
        'DrillPinDataGridViewTextBoxColumn
        '
        Me.DrillPinDataGridViewTextBoxColumn.DataPropertyName = "Drill Pin"
        Me.DrillPinDataGridViewTextBoxColumn.HeaderText = "Drill Pin"
        Me.DrillPinDataGridViewTextBoxColumn.Name = "DrillPinDataGridViewTextBoxColumn"
        Me.DrillPinDataGridViewTextBoxColumn.ReadOnly = True
        Me.DrillPinDataGridViewTextBoxColumn.Width = 67
        '
        'Drill_PinBindingSource
        '
        Me.Drill_PinBindingSource.DataMember = "Drill Pin"
        Me.Drill_PinBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drill_PinBindingSource, "Drill Pin", True))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(141, 214)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox.TabIndex = 379
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(177, 327)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 378
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(96, 327)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 377
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(15, 326)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 376
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 375
        Me.Label9.Tag = ""
        Me.Label9.Text = "Drill Pin"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Drill_PinTableAdapter
        '
        Me.Drill_PinTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarrelTableAdapter = Nothing
        Me.TableAdapterManager.Bottom_TumblerTableAdapter = Nothing
        Me.TableAdapterManager.BushingTableAdapter = Nothing
        Me.TableAdapterManager.ChartsTableAdapter = Nothing
        Me.TableAdapterManager.Drill_PinTableAdapter = Me.Drill_PinTableAdapter
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
        'DrillPin_Form
        '
        Me.AccessibleDescription = "Drill Pins"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 369)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.Name = "DrillPin_Form"
        Me.Tag = "Components"
        Me.Text = "Drill Pin"
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drill_PinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Drill_PinBindingSource As BindingSource
    Friend WithEvents Drill_PinTableAdapter As NCLRecipeDataSetTableAdapters.Drill_PinTableAdapter
    Friend WithEvents TableAdapterManager As NCLRecipeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DrillPinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
