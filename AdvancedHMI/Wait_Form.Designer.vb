<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wait_Message_Form
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
        Me.Message_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Message_TextBox
        '
        Me.Message_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Message_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Message_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message_TextBox.Location = New System.Drawing.Point(12, 12)
        Me.Message_TextBox.Multiline = True
        Me.Message_TextBox.Name = "Message_TextBox"
        Me.Message_TextBox.Size = New System.Drawing.Size(381, 113)
        Me.Message_TextBox.TabIndex = 1
        Me.Message_TextBox.Text = "Updating from the Database ... "
        Me.Message_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Wait_Message_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 137)
        Me.Controls.Add(Me.Message_TextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(1000, 800)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Wait_Message_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recipe Updating"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Message_TextBox As TextBox
End Class
