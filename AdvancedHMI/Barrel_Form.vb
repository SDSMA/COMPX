Public Class Barrel_Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BarrelTableAdapter.Fill(Me.NCLRecipeDataSet.Barrel)
        Dim BowlList As New List(Of String)
        BowlList.Add("Manual")
        BowlList.Add("Primary")
        BowlList.Add("Alternate")
        Bowl_ComboBox.DataSource = BowlList

        Dim OrientList As New List(Of String)
        OrientList.Add("1")
        OrientList.Add("2")
        OrientList.Add("3")
        Orient_ComboBox.DataSource = OrientList
    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            BarrelTableAdapter.Update(NCLRecipeDataSet.Barrel)
            Me.BarrelTableAdapter.Fill(Me.NCLRecipeDataSet.Barrel)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.BarrelRow
        NewRow = Me.NCLRecipeDataSet.Barrel.NewRow()

        NewRow.Barrel = ComboBox.Text
        NewRow.Bowl = Bowl_ComboBox.Text
        NewRow.Mark_Orient = CInt(Orient_ComboBox.Text)

        Try
            BarrelTableAdapter.Insert(Barrel:=NewRow.Barrel, Bowl:=NewRow.Bowl, Mark_Orient:=NewRow.Mark_Orient)
            BarrelTableAdapter.Update(NCLRecipeDataSet.Barrel)
            Me.BarrelTableAdapter.Fill(Me.NCLRecipeDataSet.Barrel)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            BarrelTableAdapter.Delete(Original_Barrel:=ComboBox.Text, Original_Bowl:=Bowl_ComboBox.Text, Original_Mark_Orient:=Orient_ComboBox.Text)
            BarrelTableAdapter.Update(NCLRecipeDataSet.Barrel)
            Me.BarrelTableAdapter.Fill(Me.NCLRecipeDataSet.Barrel)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class