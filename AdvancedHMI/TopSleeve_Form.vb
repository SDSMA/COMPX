Public Class TopSleeve_Form
    Private Sub TopSleeve_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Top_Sleeve' table. You can move, or remove it, as needed.
        Me.Top_SleeveTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Sleeve)

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Top_SleeveTableAdapter.Update(NCLRecipeDataSet.Top_Sleeve)
            Me.Top_SleeveTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Sleeve)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Top_SleeveRow
        NewRow = Me.NCLRecipeDataSet.Top_Sleeve.NewRow()

        NewRow.Top_Sleeve = ComboBox.Text

        Try
            Top_SleeveTableAdapter.Insert(Top_Sleeve:=NewRow.Top_Sleeve)
            Top_SleeveTableAdapter.Update(NCLRecipeDataSet.Top_Sleeve)
            Me.Top_SleeveTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Sleeve)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Top_SleeveTableAdapter.Delete(Original_Top_Sleeve:=ComboBox.Text)
            Top_SleeveTableAdapter.Update(NCLRecipeDataSet.Top_Sleeve)
            Me.Top_SleeveTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Sleeve)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub


End Class