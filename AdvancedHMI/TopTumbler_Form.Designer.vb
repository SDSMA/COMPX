<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopTumbler_Form
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
        Me.TopTumblerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BowlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopTumblerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Top_TumblerTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Top_TumblerTableAdapter()
        Me.Bowl_ComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopTumblerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TopTumblerDataGridViewTextBoxColumn, Me.BowlDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TopTumblerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 39)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(359, 143)
        Me.DataGridView1.TabIndex = 380
        '
        'TopTumblerDataGridViewTextBoxColumn
        '
        Me.TopTumblerDataGridViewTextBoxColumn.DataPropertyName = "Top Tumbler"
        Me.TopTumblerDataGridViewTextBoxColumn.HeaderText = "Top Tumbler"
        Me.TopTumblerDataGridViewTextBoxColumn.Name = "TopTumblerDataGridViewTextBoxColumn"
        Me.TopTumblerDataGridViewTextBoxColumn.ReadOnly = True
        Me.TopTumblerDataGridViewTextBoxColumn.Width = 92
        '
        'BowlDataGridViewTextBoxColumn
        '
        Me.BowlDataGridViewTextBoxColumn.DataPropertyName = "Bowl"
        Me.BowlDataGridViewTextBoxColumn.HeaderText = "Bowl"
        Me.BowlDataGridViewTextBoxColumn.Name = "BowlDataGridViewTextBoxColumn"
        Me.BowlDataGridViewTextBoxColumn.ReadOnly = True
        Me.BowlDataGridViewTextBoxColumn.Width = 55
        '
        'TopTumblerBindingSource
        '
        Me.TopTumblerBindingSource.DataMember = "Top Tumbler"
        Me.TopTumblerBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopTumblerBindingSource, "Top Tumbler", True))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(138, 213)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox.TabIndex = 379
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(174, 326)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 378
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(93, 326)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 377
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(12, 326)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 376
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 21)
        Me.Label9.TabIndex = 375
        Me.Label9.Tag = ""
        Me.Label9.Text = "Tumbler"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 382
        Me.Label1.Tag = ""
        Me.Label1.Text = "Bowl"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Top_TumblerTableAdapter
        '
        Me.Top_TumblerTableAdapter.ClearBeforeFill = True
        '
        'Bowl_ComboBox
        '
        Me.Bowl_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TopTumblerBindingSource, "Bowl", True))
        Me.Bowl_ComboBox.DataSource = Me.TopTumblerBindingSource
        Me.Bowl_ComboBox.DisplayMember = "Bowl"
        Me.Bowl_ComboBox.FormattingEnabled = True
        Me.Bowl_ComboBox.Location = New System.Drawing.Point(138, 250)
        Me.Bowl_ComboBox.Name = "Bowl_ComboBox"
        Me.Bowl_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.Bowl_ComboBox.TabIndex = 383
        '
        'TopTumbler_Form
        '
        Me.AccessibleDescription = "Top Tumblers"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 354)
        Me.Controls.Add(Me.Bowl_ComboBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TopTumbler_Form"
        Me.Tag = "Tumblers"
        Me.Text = "Top Tumbler"
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopTumblerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TopTumblerBindingSource As BindingSource
    Friend WithEvents Top_TumblerTableAdapter As NCLRecipeDataSetTableAdapters.Top_TumblerTableAdapter
    Friend WithEvents TopTumblerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BowlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bowl_ComboBox As ComboBox
End Class
