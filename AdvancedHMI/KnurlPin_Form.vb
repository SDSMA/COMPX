Public Class KnurlPin_Form
    Private Sub KnurlPin_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Knurl_Pin' table. You can move, or remove it, as needed.
        Me.Knurl_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Knurl_Pin)

        Dim BowlList As New List(Of String)
        BowlList.Add("0")
        BowlList.Add("1")
        BowlList.Add("2")
        'BowlList.Add("3")
        Bowl_ComboBox.DataSource = BowlList

        Dim ToolingCodeList As New List(Of String)
        ToolingCodeList.Add("A - Brass Knurl Pin")
        ToolingCodeList.Add("C - Steel Pin")
        ToolingCode_ComboBox.DataSource = ToolingCodeList

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Knurl_PinTableAdapter.Update(NCLRecipeDataSet.Knurl_Pin)
            Me.Knurl_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Knurl_Pin)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Knurl_PinRow
        NewRow = Me.NCLRecipeDataSet.Knurl_Pin.NewRow()

        NewRow.Knurl_Pin = ComboBox.Text
        NewRow.Tooling_Code = ToolingCode_ComboBox.Text
        NewRow.Bowl = CInt(Bowl_ComboBox.Text)

        Try
            Knurl_PinTableAdapter.Insert(Knurl_Pin:=NewRow.Knurl_Pin, Bowl:=NewRow.Bowl, Tooling_Code:=NewRow.Tooling_Code)
            Knurl_PinTableAdapter.Update(NCLRecipeDataSet.Knurl_Pin)
            Me.Knurl_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Knurl_Pin)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}", ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Knurl_PinTableAdapter.Delete(Original_Knurl_Pin:=ComboBox.Text, Original_Bowl:=Bowl_ComboBox.Text, Original_Tooling_Code:=ToolingCode_ComboBox.Text)
            Knurl_PinTableAdapter.Update(NCLRecipeDataSet.Knurl_Pin)
            Me.Knurl_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Knurl_Pin)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}", ex.Message))
        End Try
    End Sub

End Class