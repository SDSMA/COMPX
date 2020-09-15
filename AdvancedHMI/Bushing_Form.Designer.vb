<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bushing_Form
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
        Me.BushingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BushingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolingCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BushingTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.BushingTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolingCode_ComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.BushingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BushingBindingSource
        '
        Me.BushingBindingSource.DataMember = "Bushing"
        Me.BushingBindingSource.DataSource = Me.NCLRecipeDataSet
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BushingDataGridViewTextBoxColumn, Me.ToolingCodeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BushingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 47)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(359, 143)
        Me.DataGridView1.TabIndex = 360
        '
        'BushingDataGridViewTextBoxColumn
        '
        Me.BushingDataGridViewTextBoxColumn.DataPropertyName = "Bushing"
        Me.BushingDataGridViewTextBoxColumn.HeaderText = "Bushing"
        Me.BushingDataGridViewTextBoxColumn.Name = "BushingDataGridViewTextBoxColumn"
        Me.BushingDataGridViewTextBoxColumn.ReadOnly = True
        Me.BushingDataGridViewTextBoxColumn.Width = 70
        '
        'ToolingCodeDataGridViewTextBoxColumn
        '
        Me.ToolingCodeDataGridViewTextBoxColumn.DataPropertyName = "Tooling Code"
        Me.ToolingCodeDataGridViewTextBoxColumn.HeaderText = "Tooling Code"
        Me.ToolingCodeDataGridViewTextBoxColumn.Name = "ToolingCodeDataGridViewTextBoxColumn"
        Me.ToolingCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToolingCodeDataGridViewTextBoxColumn.Width = 95
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BushingBindingSource, "Bushing", True))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(140, 232)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox.TabIndex = 359
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(176, 336)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 358
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(95, 336)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 357
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(14, 335)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 356
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(11, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 355
        Me.Label9.Tag = ""
        Me.Label9.Text = "Bushing"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BushingTableAdapter
        '
        Me.BushingTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 362
        Me.Label1.Tag = ""
        Me.Label1.Text = "Tooling Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolingCode_ComboBox
        '
        Me.ToolingCode_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BushingBindingSource, "Bushing", True))
        Me.ToolingCode_ComboBox.DataSource = Me.BushingBindingSource
        Me.ToolingCode_ComboBox.DisplayMember = "Tooling Code"
        Me.ToolingCode_ComboBox.FormattingEnabled = True
        Me.ToolingCode_ComboBox.Location = New System.Drawing.Point(140, 270)
        Me.ToolingCode_ComboBox.Name = "ToolingCode_ComboBox"
        Me.ToolingCode_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ToolingCode_ComboBox.TabIndex = 363
        '
        'Bushing_Form
        '
        Me.AccessibleDescription = "Bushings"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 379)
        Me.Controls.Add(Me.ToolingCode_ComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Bushing_Form"
        Me.Tag = "Component"
        Me.Text = "Bushings"
        CType(Me.BushingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents BushingBindingSource As BindingSource
    Friend WithEvents BushingTableAdapter As NCLRecipeDataSetTableAdapters.BushingTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolingCode_ComboBox As ComboBox
    Friend WithEvents BushingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolingCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
