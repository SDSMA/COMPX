Public Class Wait_Message_Form
    Private Sub Wait_Message_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Message_TextBox.Text = "Updating from the Database." & vbCrLf & "Please wait ..."
        Message_TextBox.TabStop = False
    End Sub

End Class