<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopSleeve_Form
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
        Me.TopSleeveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopSleeveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Top_SleeveTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Top_SleeveTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopSleeveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TopSleeveDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TopSleeveBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(360, 143)
        Me.DataGridView1.TabIndex = 389
        '
        'TopSleeveDataGridViewTextBoxColumn
        '
        Me.TopSleeveDataGridViewTextBoxColumn.DataPropertyName = "Top Sleeve"
        Me.TopSleeveDataGridViewTextBoxColumn.HeaderText = "Top Sleeve"
        Me.TopSleeveDataGridViewTextBoxColumn.Name = "TopSleeveDataGridViewTextBoxColumn"
        Me.TopSleeveDataGridViewTextBoxColumn.ReadOnly = True
        Me.TopSleeveDataGridViewTextBoxColumn.Width = 87
        '
        'TopSleeveBindingSource
        '
        Me.TopSleeveBindingSource.DataMember = "Top Sleeve"
        Me.TopSleeveBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopSleeveBindingSource, "Top Sleeve", True))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(182, 234)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(190, 21)
        Me.ComboBox.TabIndex = 388
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(177, 327)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 387
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(96, 327)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 386
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(15, 326)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 385
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 384
        Me.Label9.Tag = ""
        Me.Label9.Text = "Top Sleeve"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Top_SleeveTableAdapter
        '
        Me.Top_SleeveTableAdapter.ClearBeforeFill = True
        '
        'TopSleeve_Form
        '
        Me.AccessibleDescription = "Top Sleeve"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 373)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopSleeveBindingSource, "Top Sleeve", True))
        Me.Name = "TopSleeve_Form"
        Me.Tag = "Component"
        Me.Text = "Top Sleeve"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopSleeveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents TopSleeveBindingSource As BindingSource
    Friend WithEvents Top_SleeveTableAdapter As NCLRecipeDataSetTableAdapters.Top_SleeveTableAdapter
    Friend WithEvents TopSleeveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
