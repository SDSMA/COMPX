Public Class BotTumbler_Form
    Dim DataBindingComplete As Boolean

    Private Function CleanInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[23456789]", "1")
        'Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-.]", "")
        'Return System.Text.RegularExpressions.Regex.Replace(str, "[0-9\b\s-]", "")
    End Function

    ' DataGridViewComboBoxColumn.Items Property
    ' https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridviewcomboboxcolumn.items?view=netframework-4.7.2

    'Private Sub xDataGridView_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles Bottom_TumblerDataGridView.CellValidating
    '    If Bottom_TumblerDataGridView.CurrentRow.Cells("Stepped").IsInEditMode Then
    '        Dim c As Control = Bottom_TumblerDataGridView.EditingControl
    '        Select Case Bottom_TumblerDataGridView.Columns(e.ColumnIndex).Name
    '            Case "Stepped"
    '                c.Text = CleanInputNumber(c.Text)
    '                'Case "yColumn"
    '                '    c.Text = CleanInputAlphabet(c.Text)                
    '        End Select
    '    End If
    'End Sub
    Private Sub Bot_Tumbler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Bottom_Tumbler' table. You can move, or remove it, as needed.
        Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)

        Dim BowlList As New List(Of String)
        BowlList.Add("1")
        BowlList.Add("2")
        BowlList.Add("3")
        BowlList.Add("4")
        BowlList.Add("5")
        BowlList.Add("6")
        BowlList.Add("7")
        Bowl_ComboBox.DataSource = BowlList

        Dim SteppedList As New List(Of String)
        SteppedList.Add("0")
        SteppedList.Add("1")
        Stepped_ComboBox.DataSource = SteppedList

    End Sub

    'Private Sub Stepped_TextBox_Click(sender As Object, e As EventArgs) Handles Stepped_TextBox.TextChanged
    '    Stepped_TextBox.Text = System.Text.RegularExpressions.Regex.Replace(Stepped_TextBox.Text, "[23456789a-zA-Z]", "0")
    'End Sub
    'Private Sub Bowl_TextBox_Click(sender As Object, e As EventArgs) Handles Stepped_TextBox.TextChanged
    '    Bowl_TextBox.Text = System.Text.RegularExpressions.Regex.Replace(Bowl_TextBox.Text, "[23456789a-zA-Z]", "0")
    'End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Dim PrimaryFind As String
        Dim SearchRow As NCLRecipeDataSet.Bottom_TumblerRow

        Try
            PrimaryFind = ComboBox.Text

            SearchRow = NCLRecipeDataSet.Bottom_Tumbler.FindByBottom_Tumbler(PrimaryFind)
            SearchRow("Bowl") = Bowl_ComboBox.Text
            SearchRow("Stepped") = Stepped_ComboBox.Text

            Bottom_TumblerTableAdapter.Update(NCLRecipeDataSet.Bottom_Tumbler)
            Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Bottom_TumblerRow
        NewRow = Me.NCLRecipeDataSet.Bottom_Tumbler.NewRow()

        NewRow.Bottom_Tumbler = ComboBox.Text
        NewRow.Bowl = CInt(Bowl_ComboBox.Text)
        NewRow.Stepped = CInt(Stepped_ComboBox.Text)

        Try
            Bottom_TumblerTableAdapter.Insert(Bottom_Tumbler:=NewRow.Bottom_Tumbler, Bowl:=NewRow.Bowl, Stepped:=NewRow.Stepped)
            Bottom_TumblerTableAdapter.Update(NCLRecipeDataSet.Bottom_Tumbler)
            Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Bottom_TumblerTableAdapter.Delete(Original_Bottom_Tumbler:=ComboBox.Text, Original_Bowl:=Bowl_ComboBox.Text, Original_Stepped:=Stepped_ComboBox.Text)
            Bottom_TumblerTableAdapter.Update(NCLRecipeDataSet.Bottom_Tumbler)
            Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class
