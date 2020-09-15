Public Class TopTumbler_Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Top_Tumbler' table. You can move, or remove it, as needed.
        Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)

        Dim BowlList As New List(Of String)
        BowlList.Add("0")
        BowlList.Add("1")
        BowlList.Add("2")
        BowlList.Add("3")
        BowlList.Add("4")
        BowlList.Add("5")
        BowlList.Add("6")
        BowlList.Add("7")
        Bowl_ComboBox.DataSource = BowlList

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Top_TumblerTableAdapter.Update(NCLRecipeDataSet.Top_Tumbler)
            Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Top_TumblerRow
        NewRow = Me.NCLRecipeDataSet.Top_Tumbler.NewRow()

        NewRow.Top_Tumbler = ComboBox.Text
        NewRow.Bowl = CInt(Bowl_ComboBox.Text)

        Try
            Top_TumblerTableAdapter.Insert(Top_Tumbler:=NewRow.Top_Tumbler, Bowl:=NewRow.Bowl)
            Top_TumblerTableAdapter.Update(NCLRecipeDataSet.Top_Tumbler)
            Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Top_TumblerTableAdapter.Delete(Original_Top_Tumbler:=ComboBox.Text, Original_Bowl:=Bowl_ComboBox.Text)
            Top_TumblerTableAdapter.Update(NCLRecipeDataSet.Top_Tumbler)
            Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class