Public Class Bushing_Form
    Private Sub Bushing_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Bushing' table. You can move, or remove it, as needed.
        Me.BushingTableAdapter.Fill(Me.NCLRecipeDataSet.Bushing)

        Dim ToolingCode As New List(Of String)
        ToolingCode.Add("A - Standard Setup (.640)")
        ToolingCode.Add("B - Long Setup (.840)")
        ToolingCode.Add("C - Short Setup (.625)")
        ToolingCode_ComboBox.DataSource = ToolingCode
    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            BushingTableAdapter.Update(NCLRecipeDataSet.Bushing)
            Me.BushingTableAdapter.Fill(Me.NCLRecipeDataSet.Bushing)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.BushingRow
        NewRow = Me.NCLRecipeDataSet.Bushing.NewRow()

        NewRow.Bushing = ComboBox.Text
        NewRow.Tooling_Code = ToolingCode_ComboBox.Text

        Try
            BushingTableAdapter.Insert(Bushing:=NewRow.Bushing, Tooling_Code:=NewRow.Tooling_Code)
            BushingTableAdapter.Update(NCLRecipeDataSet.Bushing)
            Me.BushingTableAdapter.Fill(Me.NCLRecipeDataSet.Bushing)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            BushingTableAdapter.Delete(Original_Bushing:=ComboBox.Text, Original_Tooling_Code:=ToolingCode_ComboBox.Text)
            BushingTableAdapter.Update(NCLRecipeDataSet.Bushing)
            Me.BushingTableAdapter.Fill(Me.NCLRecipeDataSet.Bushing)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class