Public Class Sta14_Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Station_14_Tooling' table. You can move, or remove it, as needed.
        Me.Station_14_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_14_Tooling)

        'Dim ToolingNameList As New List(Of String)
        'ToolingNameList.Add("A - Tooling Setup")
        'ToolingNameList.Add("B - Tooling Setup (5502 Family)")
        'ToolingNameList.Add("C - Tooling Setup (K-4119 CDC Family)")
        'ToolingNameList.Add("D - Tooling Setup (5555 Family)")
        'ToolingName_ComboBox.DataSource = ToolingNameList

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Station_14_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_14_Tooling)
            Me.Station_14_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_14_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Station_14_ToolingRow
        NewRow = Me.NCLRecipeDataSet.Station_14_Tooling.NewRow()

        NewRow.Tooling_Name = ToolingName_ComboBox.Text

        Try
            Station_14_ToolingTableAdapter.Insert(Tooling_Name:=NewRow.Tooling_Name)
            Station_14_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_14_Tooling)
            Me.Station_14_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_14_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Station_14_ToolingTableAdapter.Delete(Original_Tooling_Name:=ToolingName_ComboBox.Text)
            Station_14_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_14_Tooling)
            Me.Station_14_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_14_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class