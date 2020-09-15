Public Class Charts_Form
    Private Sub Charts_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load  'NCLRecipeDataSet.Springs' table.
        Me.SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)
        'Load 'NCLRecipeDataSet.Top_Tumbler' table.
        Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)
        'Load 'NCLRecipeDataSet.Mid_Tumbler' table.
        Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)
        'Load 'NCLRecipeDataSet.Bottom_Tumbler' table.
        Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)
        'Loads 'NCLRecipeDataSet.Charts' table.
        Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
    End Sub

    Private Sub PartNumber_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_1_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_1_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_1_TextBox.Text)
            Stepped_1_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_1_TextBox.Text)
            Stepped_1_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_1_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_1_TextBox.Text)
            Stepped_1_TextBox.Text = ""
            Stepped_1_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_1_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_1_TextBox.Text)
            Stepped_1_TextBox.Text = ""
            Stepped_1_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_1_TextBox.Text = SpringsTableAdapter.GetBowl(Part_1_TextBox.Text)
            Stepped_1_TextBox.Text = ""
            Stepped_1_TextBox.Visible = False

        End If

    End Sub

    Private Sub Part_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_2_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_2_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_2_TextBox.Text)
            Stepped_2_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_2_TextBox.Text)
            Stepped_2_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_2_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_2_TextBox.Text)
            Stepped_2_TextBox.Text = ""
            Stepped_2_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_2_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_2_TextBox.Text)
            Stepped_2_TextBox.Text = ""
            Stepped_2_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_2_TextBox.Text = SpringsTableAdapter.GetBowl(Part_2_TextBox.Text)
            Stepped_2_TextBox.Text = ""
            Stepped_2_TextBox.Visible = False

        End If
    End Sub

    Private Sub Part_3_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_3_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_3_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_3_TextBox.Text)
            Stepped_3_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_3_TextBox.Text)
            Stepped_3_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_3_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_3_TextBox.Text)
            Stepped_3_TextBox.Text = ""
            Stepped_3_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_3_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_3_TextBox.Text)
            Stepped_3_TextBox.Text = ""
            Stepped_3_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_3_TextBox.Text = SpringsTableAdapter.GetBowl(Part_3_TextBox.Text)
            Stepped_3_TextBox.Text = ""
            Stepped_3_TextBox.Visible = False

        End If
    End Sub

    Private Sub Part_4_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_4_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_4_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_4_TextBox.Text)
            Stepped_4_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_4_TextBox.Text)
            Stepped_4_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_4_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_4_TextBox.Text)
            Stepped_4_TextBox.Text = ""
            Stepped_4_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_4_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_4_TextBox.Text)
            Stepped_4_TextBox.Text = ""
            Stepped_4_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_4_TextBox.Text = SpringsTableAdapter.GetBowl(Part_4_TextBox.Text)
            Stepped_4_TextBox.Text = ""
            Stepped_4_TextBox.Visible = False

        End If
    End Sub

    Private Sub PartNumber_5_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_5_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_5_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_5_TextBox.Text)
            Stepped_5_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_5_TextBox.Text)
            Stepped_5_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_5_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_5_TextBox.Text)
            Stepped_5_TextBox.Text = ""
            Stepped_5_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_5_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_5_TextBox.Text)
            Stepped_5_TextBox.Text = ""
            Stepped_5_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_5_TextBox.Text = SpringsTableAdapter.GetBowl(Part_5_TextBox.Text)
            Stepped_5_TextBox.Text = ""
            Stepped_5_TextBox.Visible = False

        End If
    End Sub

    Private Sub PartNumber_6_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_6_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_6_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_6_TextBox.Text)
            Stepped_6_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_6_TextBox.Text)
            Stepped_6_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_6_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_6_TextBox.Text)
            Stepped_6_TextBox.Text = ""
            Stepped_6_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_6_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_6_TextBox.Text)
            Stepped_6_TextBox.Text = ""
            Stepped_6_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_6_TextBox.Text = SpringsTableAdapter.GetBowl(Part_6_TextBox.Text)
            Stepped_6_TextBox.Text = ""
            Stepped_6_TextBox.Visible = False

        End If
    End Sub

    Private Sub Part_Number_7_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_7_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_7_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_7_TextBox.Text)
            Stepped_7_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_7_TextBox.Text)
            Stepped_7_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_7_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_7_TextBox.Text)
            Stepped_7_TextBox.Text = ""
            Stepped_7_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_7_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_7_TextBox.Text)
            Stepped_7_TextBox.Text = ""
            Stepped_7_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_7_TextBox.Text = SpringsTableAdapter.GetBowl(Part_7_TextBox.Text)
            Stepped_7_TextBox.Text = ""
            Stepped_7_TextBox.Visible = False

        End If
    End Sub

    Private Sub Part_8_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Part_8_TextBox.TextChanged
        If PartType_TextBox.Text.ToUpper() = "BOTTUM" Then

            Bowl_8_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Part_8_TextBox.Text)
            Stepped_8_TextBox.Text = Bottom_TumblerTableAdapter.GetStepped(Part_8_TextBox.Text)
            Stepped_8_TextBox.Visible = True

        ElseIf PartType_TextBox.Text.ToUpper() = "MIDTUM" Then

            Bowl_8_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Part_8_TextBox.Text)
            Stepped_8_TextBox.Text = ""
            Stepped_8_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "TOPTUM" Then

            Bowl_8_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Part_8_TextBox.Text)
            Stepped_8_TextBox.Text = ""
            Stepped_8_TextBox.Visible = False

        ElseIf PartType_TextBox.Text.ToUpper() = "SPRINGS" Then

            Bowl_8_TextBox.Text = SpringsTableAdapter.GetBowl(Part_8_TextBox.Text)
            Stepped_8_TextBox.Text = ""
            Stepped_8_TextBox.Visible = False

        End If
    End Sub

    Private Sub ReadOnly_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReadOnly_CheckBox.CheckedChanged
        Charts_DataGridView.ReadOnly = ReadOnly_CheckBox.Checked
        Update_Button.Enabled = (ReadOnly_CheckBox.Checked = False)
        Insert_Button.Enabled = (ReadOnly_CheckBox.Checked = False)
        Delete_Button.Enabled = (ReadOnly_CheckBox.Checked = False)
    End Sub

    Private Sub ChartNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ChartName_TextBox.TextChanged
        'GlobalVariables.C_ChartName = ChartName_TextBox.Text
        'GlobalVariables.C_PartType = PartType_TextBox.Text
        'GlobalVariables.C_KeyCode_1 = KeyCode_1_TextBox.Text
        'GlobalVariables.C_KeyCode_2 = KeyCode_2_TextBox.Text
        'GlobalVariables.C_KeyCode_3 = KeyCode_3_TextBox.Text
        'GlobalVariables.C_KeyCode_4 = KeyCode_4_TextBox.Text
        'GlobalVariables.C_KeyCode_5 = KeyCode_5_TextBox.Text
        'GlobalVariables.C_KeyCode_6 = KeyCode_6_TextBox.Text
        'GlobalVariables.C_KeyCode_7 = KeyCode_7_TextBox.Text
        'GlobalVariables.C_KeyCode_8 = KeyCode_8_TextBox.Text

        'GlobalVariables.C_Part_1 = Part_1_TextBox.Text
        'GlobalVariables.C_Part_2 = Part_2_TextBox.Text
        'GlobalVariables.C_Part_3 = Part_3_TextBox.Text
        'GlobalVariables.C_Part_4 = Part_4_TextBox.Text
        'GlobalVariables.C_Part_5 = Part_5_TextBox.Text
        'GlobalVariables.C_Part_6 = Part_6_TextBox.Text
        'GlobalVariables.C_Part_7 = Part_7_TextBox.Text
        'GlobalVariables.C_Part_8 = Part_8_TextBox.Text

        'GlobalVariables.C_Bowl_1 = Bowl_1_TextBox.Text
        'GlobalVariables.C_Bowl_2 = Bowl_2_TextBox.Text
        'GlobalVariables.C_Bowl_3 = Bowl_3_TextBox.Text
        'GlobalVariables.C_Bowl_4 = Bowl_4_TextBox.Text
        'GlobalVariables.C_Bowl_5 = Bowl_5_TextBox.Text
        'GlobalVariables.C_Bowl_6 = Bowl_6_TextBox.Text
        'GlobalVariables.C_Bowl_7 = Bowl_7_TextBox.Text
        'GlobalVariables.C_Bowl_8 = Bowl_8_TextBox.Text

        'GlobalVariables.C_Stepped_1 = Stepped_1_TextBox.Text
        'GlobalVariables.C_Stepped_2 = Stepped_2_TextBox.Text
        'GlobalVariables.C_Stepped_3 = Stepped_3_TextBox.Text
        'GlobalVariables.C_Stepped_4 = Stepped_4_TextBox.Text
        'GlobalVariables.C_Stepped_5 = Stepped_5_TextBox.Text
        'GlobalVariables.C_Stepped_6 = Stepped_6_TextBox.Text
        'GlobalVariables.C_Stepped_7 = Stepped_7_TextBox.Text
        'GlobalVariables.C_Stepped_8 = Stepped_8_TextBox.Text

    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            ChartsTableAdapter.Update(NCLRecipeDataSet.Charts)
            Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.ChartsRow
        NewRow = Me.NCLRecipeDataSet.Charts.NewRow()

        NewRow.Chart_Name = ChartName_TextBox.Text
        NewRow.Part_Type = PartType_TextBox.Text
        NewRow.KeyCode_1 = KeyCode_1_TextBox.Text
        NewRow._Part__1 = Part_1_TextBox.Text
        NewRow.KeyCode_2 = KeyCode_2_TextBox.Text
        NewRow._Part__2 = Part_2_TextBox.Text
        NewRow.KeyCode_3 = KeyCode_3_TextBox.Text
        NewRow._Part__3 = Part_3_TextBox.Text
        NewRow.KeyCode_4 = KeyCode_4_TextBox.Text
        NewRow._Part__4 = Part_4_TextBox.Text
        NewRow.KeyCode_5 = KeyCode_5_TextBox.Text
        NewRow._Part__5 = Part_5_TextBox.Text
        NewRow.KeyCode_6 = KeyCode_6_TextBox.Text
        NewRow._Part__6 = Part_6_TextBox.Text
        NewRow.KeyCode_7 = KeyCode_7_TextBox.Text
        NewRow._Part__7 = Part_7_TextBox.Text
        NewRow.KeyCode_8 = KeyCode_8_TextBox.Text
        NewRow._Part__8 = Part_8_TextBox.Text

        Try
            ChartsTableAdapter.Insert(Chart_Name:=NewRow.Chart_Name,
                                      Part_Type:=NewRow.Part_Type,
                                      KeyCode_1:=NewRow.KeyCode_1,
                                      _Part__1:=NewRow._Part__1,
                                      KeyCode_2:=NewRow.KeyCode_2,
                                      _Part__2:=NewRow._Part__2,
                                      KeyCode_3:=NewRow.KeyCode_3,
                                      _Part__3:=NewRow._Part__3,
                                      KeyCode_4:=NewRow.KeyCode_4,
                                      _Part__4:=NewRow._Part__4,
                                      KeyCode_5:=NewRow.KeyCode_5,
                                      _Part__5:=NewRow._Part__5,
                                      KeyCode_6:=NewRow.KeyCode_6,
                                      _Part__6:=NewRow._Part__6,
                                      KeyCode_7:=NewRow.KeyCode_7,
                                      _Part__7:=NewRow._Part__7,
                                      KeyCode_8:=NewRow.KeyCode_8,
                                      _Part__8:=NewRow._Part__8)

            ChartsTableAdapter.Update(NCLRecipeDataSet.Charts)
            Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Try
            ChartsTableAdapter.Delete(Original_Chart_Name:=ChartName_TextBox.Text,
                                      Original_Part_Type:=PartType_TextBox.Text,
                                      Original_KeyCode_1:=KeyCode_1_TextBox.Text,
                                      _Original_Part__1:=Part_1_TextBox.Text,
                                      Original_KeyCode_2:=KeyCode_2_TextBox.Text,
                                      _Original_Part__2:=Part_2_TextBox.Text,
                                      Original_KeyCode_3:=KeyCode_3_TextBox.Text,
                                      _Original_Part__3:=Part_3_TextBox.Text,
                                      Original_KeyCode_4:=KeyCode_4_TextBox.Text,
                                      _Original_Part__4:=Part_4_TextBox.Text,
                                      Original_KeyCode_5:=KeyCode_5_TextBox.Text,
                                      _Original_Part__5:=Part_5_TextBox.Text,
                                      Original_KeyCode_6:=KeyCode_6_TextBox.Text,
                                      _Original_Part__6:=Part_6_TextBox.Text,
                                      Original_KeyCode_7:=KeyCode_7_TextBox.Text,
                                      _Original_Part__7:=Part_7_TextBox.Text,
                                      Original_KeyCode_8:=KeyCode_8_TextBox.Text,
                                      _Original_Part__8:=Part_8_TextBox.Text)

            ChartsTableAdapter.Update(NCLRecipeDataSet.Charts)
            Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

End Class