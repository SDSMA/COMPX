Public Class MidTumbler_Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Mid_Tumbler' table. You can move, or remove it, as needed.
        Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)

        Dim BowlList As New List(Of String)
        BowlList.Add("0")
        BowlList.Add("1")
        BowlList.Add("2")
        BowlList.Add("3")
        'BowlList.Add("4")
        'BowlList.Add("5")
        'BowlList.Add("6")
        'BowlList.Add("7")
        Bowl_ComboBox.DataSource = BowlList

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Mid_TumblerTableAdapter.Update(NCLRecipeDataSet.Mid_Tumbler)
            Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Mid_TumblerRow
        NewRow = Me.NCLRecipeDataSet.Mid_Tumbler.NewRow()

        NewRow.Mid_Tumbler = ComboBox.Text
        NewRow.Bowl = CInt(Bowl_ComboBox.Text)

        Try
            'Mid_TumblerTableAdapter.Insert(NewRow)
            Mid_TumblerTableAdapter.Insert(Mid_Tumbler:=NewRow.Mid_Tumbler, Bowl:=NewRow.Bowl)
            Mid_TumblerTableAdapter.Update(NCLRecipeDataSet.Mid_Tumbler)
            Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Mid_TumblerTableAdapter.Delete(Original_Mid_Tumbler:=ComboBox.Text, Original_Bowl:=Bowl_ComboBox.Text)
            Mid_TumblerTableAdapter.Update(NCLRecipeDataSet.Mid_Tumbler)
            Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class