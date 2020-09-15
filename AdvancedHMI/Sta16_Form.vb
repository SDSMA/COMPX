Public Class Sta16_Form
    Private Sub Sta16_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Station_16_Tooling' table. You can move, or remove it, as needed.
        Me.Station_16_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_16_Tooling)

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Station_16_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_16_Tooling)
            Me.Station_16_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_16_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Station_16_ToolingRow
        NewRow = Me.NCLRecipeDataSet.Station_16_Tooling.NewRow()

        NewRow.Tooling_Name = ComboBox.Text

        Try
            Station_16_ToolingTableAdapter.Insert(Tooling_Name:=NewRow.Tooling_Name)
            Station_16_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_16_Tooling)
            Me.Station_16_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_16_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Station_16_ToolingTableAdapter.Delete(Original_Tooling_Name:=ComboBox.Text)
            Station_16_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_16_Tooling)
            Me.Station_16_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_16_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub
End Class