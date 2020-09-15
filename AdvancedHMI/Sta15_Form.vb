Public Class Sta15_Form
    Private Sub Sta15_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Station_15_Tooling' table. You can move, or remove it, as needed.
        Me.Station_15_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_15_Tooling)

        'Dim ToolingNameList As New List(Of String)
        'ToolingNameList.Add("A - Tooling Setup")
        'ToolingNameList.Add("B - Alternate Setup (K-4119 CDC Family Only)")
        'ToolingName_ComboBox.DataSource = ToolingNameList

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Station_15_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_15_Tooling)
            Me.Station_15_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_15_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Station_15_ToolingRow
        NewRow = Me.NCLRecipeDataSet.Station_15_Tooling.NewRow()

        NewRow.Tooling_Name = ToolingName_ComboBox.Text

        Try
            Station_15_ToolingTableAdapter.Insert(Tooling_Name:=NewRow.Tooling_Name)
            Station_15_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_15_Tooling)
            Me.Station_15_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_15_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Station_15_ToolingTableAdapter.Delete(Original_Tooling_Name:=ToolingName_ComboBox.Text)
            Station_15_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_15_Tooling)
            Me.Station_15_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_15_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class