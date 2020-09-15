Public Class Springs_Form
    Private Sub Springs_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Springs' table. You can move, or remove it, as needed.
        Me.SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)

        Dim BowlList As New List(Of String)
        BowlList.Add("0")
        BowlList.Add("1")
        BowlList.Add("2")
        BowlList.Add("3")
        BowlList.Add("4")
        Bowl_ComboBox.DataSource = BowlList
    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            SpringsTableAdapter.Update(NCLRecipeDataSet.Springs)
            SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub
    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.SpringsRow
        NewRow = Me.NCLRecipeDataSet.Springs.NewRow()

        NewRow.Spring = ComboBox.Text
        NewRow.Bowl = CInt(Bowl_ComboBox.Text)

        Try
            SpringsTableAdapter.Insert(Spring:=NewRow.Spring, Bowl:=NewRow.Bowl)
            SpringsTableAdapter.Update(NCLRecipeDataSet.Springs)
            SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            SpringsTableAdapter.Delete(Original_Spring:=ComboBox.Text, Original_Bowl:=Bowl_ComboBox.Text)
            SpringsTableAdapter.Update(NCLRecipeDataSet.Springs)
            SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub ReadOnly_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReadOnly_CheckBox.CheckedChanged
        DataGridView1.ReadOnly = ReadOnly_CheckBox.Checked
        Update_Button.Enabled = (ReadOnly_CheckBox.Checked = False)
        Insert_Button.Enabled = (ReadOnly_CheckBox.Checked = False)
        Delete_Button.Enabled = (ReadOnly_CheckBox.Checked = False)

    End Sub

End Class