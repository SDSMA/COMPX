<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KnurlPin_Form
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.KnurlPinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Knurl_PinTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Knurl_PinTableAdapter()
        Me.TableAdapterManager = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolingCode_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Bowl_ComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KnurlPinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 384
        Me.Label2.Tag = ""
        Me.Label2.Text = "Bowl"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KnurlPinBindingSource
        '
        Me.KnurlPinBindingSource.DataMember = "Knurl Pin"
        Me.KnurlPinBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KnurlPinBindingSource, "Knurl Pin", True))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(141, 215)
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
        Me.Label9.Location = New System.Drawing.Point(12, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 375
        Me.Label9.Tag = ""
        Me.Label9.Text = "Knurl Pin"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 382
        Me.Label1.Tag = ""
        Me.Label1.Text = "Tooling Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Knurl_PinTableAdapter
        '
        Me.Knurl_PinTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarrelTableAdapter = Nothing
        Me.TableAdapterManager.Bottom_TumblerTableAdapter = Nothing
        Me.TableAdapterManager.BushingTableAdapter = Nothing
        Me.TableAdapterManager.ChartsTableAdapter = Nothing
        Me.TableAdapterManager.Drill_PinTableAdapter = Nothing
        Me.TableAdapterManager.Knurl_PinTableAdapter = Me.Knurl_PinTableAdapter
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView1.DataSource = Me.KnurlPinBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(345, 164)
        Me.DataGridView1.TabIndex = 385
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Knurl Pin"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Knurl Pin"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tooling Code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tooling Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bowl"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bowl"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 55
        '
        'ToolingCode_ComboBox
        '
        Me.ToolingCode_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KnurlPinBindingSource, "Tooling Code", True))
        Me.ToolingCode_ComboBox.DataSource = Me.KnurlPinBindingSource
        Me.ToolingCode_ComboBox.DisplayMember = "Tooling Code"
        Me.ToolingCode_ComboBox.FormattingEnabled = True
        Me.ToolingCode_ComboBox.Location = New System.Drawing.Point(141, 248)
        Me.ToolingCode_ComboBox.Name = "ToolingCode_ComboBox"
        Me.ToolingCode_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ToolingCode_ComboBox.TabIndex = 386
        '
        'Bowl_ComboBox
        '
        Me.Bowl_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KnurlPinBindingSource, "Bowl", True))
        Me.Bowl_ComboBox.DataSource = Me.KnurlPinBindingSource
        Me.Bowl_ComboBox.DisplayMember = "Bowl"
        Me.Bowl_ComboBox.FormattingEnabled = True
        Me.Bowl_ComboBox.Location = New System.Drawing.Point(141, 278)
        Me.Bowl_ComboBox.Name = "Bowl_ComboBox"
        Me.Bowl_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.Bowl_ComboBox.TabIndex = 387
        '
        'KnurlPin_Form
        '
        Me.AccessibleDescription = "Knurl Pins"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 374)
        Me.Controls.Add(Me.Bowl_ComboBox)
        Me.Controls.Add(Me.ToolingCode_ComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KnurlPin_Form"
        Me.Tag = "Component"
        Me.Text = "Knurl Pins"
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KnurlPinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KnurlPinBindingSource As BindingSource
    Friend WithEvents Knurl_PinTableAdapter As NCLRecipeDataSetTableAdapters.Knurl_PinTableAdapter
    Friend WithEvents TableAdapterManager As NCLRecipeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolingCode_ComboBox As ComboBox
    Friend WithEvents Bowl_ComboBox As ComboBox
End Class
