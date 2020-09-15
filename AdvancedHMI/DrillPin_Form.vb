Public Class DrillPin_Form
    Private Sub DrillPin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Drill_Pin' table. You can move, or remove it, as needed.
        Me.Drill_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Drill_Pin)
    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Drill_PinTableAdapter.Update(NCLRecipeDataSet.Drill_Pin)
            Me.Drill_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Drill_Pin)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}", ex.Message))
        End Try
    End Sub
    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Drill_PinRow
        NewRow = Me.NCLRecipeDataSet.Drill_Pin.NewRow()

        NewRow.Drill_Pin = ComboBox.Text

        Try
            Drill_PinTableAdapter.Insert(Drill_Pin:=NewRow.Drill_Pin)
            Drill_PinTableAdapter.Update(NCLRecipeDataSet.Drill_Pin)
            Me.Drill_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Drill_Pin)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            Drill_PinTableAdapter.Delete(Original_Drill_Pin:=ComboBox.Text)
            Drill_PinTableAdapter.Update(NCLRecipeDataSet.Drill_Pin)
            Me.Drill_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Drill_Pin)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}", ex.Message))
        End Try
    End Sub

End Class