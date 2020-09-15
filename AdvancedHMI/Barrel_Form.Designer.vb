<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barrel_Form
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
        Me.BarrelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BarrelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BowlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkOrientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BarrelTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.BarrelTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bowl_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Orient_ComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.BarrelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarrelBindingSource
        '
        Me.BarrelBindingSource.DataMember = "Barrel"
        Me.BarrelBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 371
        Me.Label1.Tag = ""
        Me.Label1.Text = "Bowl"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BarrelDataGridViewTextBoxColumn, Me.BowlDataGridViewTextBoxColumn, Me.MarkOrientDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BarrelBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(7, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(359, 150)
        Me.DataGridView1.TabIndex = 369
        '
        'BarrelDataGridViewTextBoxColumn
        '
        Me.BarrelDataGridViewTextBoxColumn.DataPropertyName = "Barrel"
        Me.BarrelDataGridViewTextBoxColumn.HeaderText = "Barrel"
        Me.BarrelDataGridViewTextBoxColumn.Name = "BarrelDataGridViewTextBoxColumn"
        Me.BarrelDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarrelDataGridViewTextBoxColumn.Width = 69
        '
        'BowlDataGridViewTextBoxColumn
        '
        Me.BowlDataGridViewTextBoxColumn.DataPropertyName = "Bowl"
        Me.BowlDataGridViewTextBoxColumn.HeaderText = "Bowl"
        Me.BowlDataGridViewTextBoxColumn.Name = "BowlDataGridViewTextBoxColumn"
        Me.BowlDataGridViewTextBoxColumn.ReadOnly = True
        Me.BowlDataGridViewTextBoxColumn.Width = 62
        '
        'MarkOrientDataGridViewTextBoxColumn
        '
        Me.MarkOrientDataGridViewTextBoxColumn.DataPropertyName = "Mark Orient"
        Me.MarkOrientDataGridViewTextBoxColumn.HeaderText = "Mark Orient"
        Me.MarkOrientDataGridViewTextBoxColumn.Name = "MarkOrientDataGridViewTextBoxColumn"
        Me.MarkOrientDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarkOrientDataGridViewTextBoxColumn.Width = 101
        '
        'ComboBox
        '
        Me.ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarrelBindingSource, "Barrel", True))
        Me.ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(136, 204)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(230, 24)
        Me.ComboBox.TabIndex = 368
        '
        'Delete_Button
        '
        Me.Delete_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Button.Location = New System.Drawing.Point(172, 327)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 367
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert_Button.Location = New System.Drawing.Point(91, 327)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 366
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Button.Location = New System.Drawing.Point(10, 326)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 365
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 364
        Me.Label9.Tag = ""
        Me.Label9.Text = "Barrel"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BarrelTableAdapter
        '
        Me.BarrelTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 373
        Me.Label2.Tag = ""
        Me.Label2.Text = "Mark Orient"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bowl_ComboBox
        '
        Me.Bowl_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarrelBindingSource, "Bowl", True))
        Me.Bowl_ComboBox.DataSource = Me.BarrelBindingSource
        Me.Bowl_ComboBox.DisplayMember = "Bowl"
        Me.Bowl_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bowl_ComboBox.FormattingEnabled = True
        Me.Bowl_ComboBox.Location = New System.Drawing.Point(136, 236)
        Me.Bowl_ComboBox.Name = "Bowl_ComboBox"
        Me.Bowl_ComboBox.Size = New System.Drawing.Size(50, 24)
        Me.Bowl_ComboBox.TabIndex = 375
        '
        'Orient_ComboBox
        '
        Me.Orient_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarrelBindingSource, "Mark Orient", True))
        Me.Orient_ComboBox.DataSource = Me.BarrelBindingSource
        Me.Orient_ComboBox.DisplayMember = "Mark Orient"
        Me.Orient_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orient_ComboBox.FormattingEnabled = True
        Me.Orient_ComboBox.Location = New System.Drawing.Point(136, 268)
        Me.Orient_ComboBox.Name = "Orient_ComboBox"
        Me.Orient_ComboBox.Size = New System.Drawing.Size(50, 24)
        Me.Orient_ComboBox.TabIndex = 376
        '
        'Barrel_Form
        '
        Me.AccessibleDescription = "Barrel"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.Orient_ComboBox)
        Me.Controls.Add(Me.Bowl_ComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Barrel_Form"
        Me.Tag = "Component"
        Me.Text = "Barrel"
        CType(Me.BarrelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents BarrelTableAdapter As NCLRecipeDataSetTableAdapters.BarrelTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents BarrelBindingSource As BindingSource
    Friend WithEvents BarrelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BowlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarkOrientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Bowl_ComboBox As ComboBox
    Friend WithEvents Orient_ComboBox As ComboBox
End Class
