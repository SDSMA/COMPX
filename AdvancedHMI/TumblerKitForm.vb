Public Class TumblerKit_Form

    Private Sub TumblerKit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mid_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Mid_Tumbler)
        Me.Bottom_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Bottom_Tumbler)
        Me.Top_TumblerTableAdapter.Fill(Me.NCLRecipeDataSet.Top_Tumbler)
        Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
        Me.SpringsTableAdapter.Fill(Me.NCLRecipeDataSet.Springs)
        Me.Tumbler_KitTableAdapter.Fill(Me.NCLRecipeDataSet.Tumbler_Kit)
    End Sub

    Private Sub Tumbler_Kit_TextBox_TextChanged() Handles Tumbler_Kit_TextBox.TextChanged
        Timer1.Interval = 500
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick() Handles Timer1.Tick
        Timer1.Stop()

        'GlobalVariables.Spring_1_Type = Spring_1_Type_TextBox.Text
        'GlobalVariables.Spring_1_Random_1 = Spring_1_Random_1_TextBox.Text
        'GlobalVariables.Spring_1_Random_2 = Spring_1_Random_2_TextBox.Text
        'GlobalVariables.Spring_1_Number = Spring_1_Number_TextBox.Text
        'GlobalVariables.Spring_1_Chart = Spring_1_Chart_TextBox.Text

        'GlobalVariables.Spring_1_Random_1_Bowl = Spring_1_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_1_Random_2_Bowl = Spring_1_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_1_Number_Bowl = Spring_1_Number_Bowl_TextBox.Text

        'GlobalVariables.Spring_2_Type = Spring_2_Type_TextBox.Text
        'GlobalVariables.Spring_2_Random_1 = Spring_2_Random_1_TextBox.Text
        'GlobalVariables.Spring_2_Random_2 = Spring_2_Random_2_TextBox.Text
        'GlobalVariables.Spring_2_Number = Spring_2_Number_TextBox.Text
        'GlobalVariables.Spring_2_Chart = Spring_2_Chart_TextBox.Text

        'GlobalVariables.Spring_2_Random_1_Bowl = Spring_2_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_2_Random_2_Bowl = Spring_2_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_2_Number_Bowl = Spring_2_Number_Bowl_TextBox.Text

        'GlobalVariables.Spring_3_Type = Spring_3_Type_TextBox.Text
        'GlobalVariables.Spring_3_Random_1 = Spring_3_Random_1_TextBox.Text
        'GlobalVariables.Spring_3_Random_2 = Spring_3_Random_2_TextBox.Text
        'GlobalVariables.Spring_3_Number = Spring_3_Number_TextBox.Text
        'GlobalVariables.Spring_3_Chart = Spring_3_Chart_TextBox.Text

        'GlobalVariables.Spring_3_Random_1_Bowl = Spring_3_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_3_Random_2_Bowl = Spring_3_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_3_Number_Bowl = Spring_3_Number_Bowl_TextBox.Text

        'GlobalVariables.Spring_4_Type = Spring_4_Type_TextBox.Text
        'GlobalVariables.Spring_4_Random_1 = Spring_4_Random_1_TextBox.Text
        'GlobalVariables.Spring_4_Random_2 = Spring_4_Random_2_TextBox.Text
        'GlobalVariables.Spring_4_Number = Spring_4_Number_TextBox.Text
        'GlobalVariables.Spring_4_Chart = Spring_4_Chart_TextBox.Text

        'GlobalVariables.Spring_4_Random_1_Bowl = Spring_4_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_4_Random_2_Bowl = Spring_4_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_4_Number_Bowl = Spring_4_Number_Bowl_TextBox.Text

        'GlobalVariables.Spring_5_Type = Spring_5_Type_TextBox.Text
        'GlobalVariables.Spring_5_Random_1 = Spring_5_Random_1_TextBox.Text
        'GlobalVariables.Spring_5_Random_2 = Spring_5_Random_2_TextBox.Text
        'GlobalVariables.Spring_5_Number = Spring_5_Number_TextBox.Text
        'GlobalVariables.Spring_5_Chart = Spring_5_Chart_TextBox.Text

        'GlobalVariables.Spring_5_Random_1_Bowl = Spring_5_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_5_Random_2_Bowl = Spring_5_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_5_Number_Bowl = Spring_5_Number_Bowl_TextBox.Text

        'GlobalVariables.Spring_6_Type = Spring_6_Type_TextBox.Text
        'GlobalVariables.Spring_6_Random_1 = Spring_6_Random_1_TextBox.Text
        'GlobalVariables.Spring_6_Random_2 = Spring_6_Random_2_TextBox.Text
        'GlobalVariables.Spring_6_Number = Spring_6_Number_TextBox.Text
        'GlobalVariables.Spring_6_Chart = Spring_6_Chart_TextBox.Text

        'GlobalVariables.Spring_6_Random_1_Bowl = Spring_6_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_6_Random_2_Bowl = Spring_6_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_6_Number_Bowl = Spring_6_Number_Bowl_TextBox.Text

        'GlobalVariables.Spring_7_Type = Spring_7_Type_TextBox.Text
        'GlobalVariables.Spring_7_Random_1 = Spring_7_Random_1_TextBox.Text
        'GlobalVariables.Spring_7_Random_2 = Spring_7_Random_2_TextBox.Text
        'GlobalVariables.Spring_7_Number = Spring_7_Number_TextBox.Text
        'GlobalVariables.Spring_7_Chart = Spring_7_Chart_TextBox.Text

        'GlobalVariables.Spring_7_Random_1_Bowl = Spring_7_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Spring_7_Random_2_Bowl = Spring_7_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Spring_7_Number_Bowl = Spring_7_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_1_Type = Top_1_Type_TextBox.Text
        'GlobalVariables.Top_1_Random_1 = Top_1_Random_1_TextBox.Text
        'GlobalVariables.Top_1_Random_2 = Top_1_Random_2_TextBox.Text
        'GlobalVariables.Top_1_Number = Top_1_Number_TextBox.Text
        'GlobalVariables.Top_1_Chart = Top_1_Chart_TextBox.Text

        'GlobalVariables.Top_1_Random_1_Bowl = Top_1_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_1_Random_2_Bowl = Top_1_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_1_Number_Bowl = Top_1_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_2_Type = Top_2_Type_TextBox.Text
        'GlobalVariables.Top_2_Random_1 = Top_2_Random_1_TextBox.Text
        'GlobalVariables.Top_2_Random_2 = Top_2_Random_2_TextBox.Text
        'GlobalVariables.Top_2_Number = Top_2_Number_TextBox.Text
        'GlobalVariables.Top_2_Chart = Top_2_Chart_TextBox.Text

        'GlobalVariables.Top_2_Random_1_Bowl = Top_2_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_2_Random_2_Bowl = Top_2_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_2_Number_Bowl = Top_2_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_3_Type = Top_3_Type_TextBox.Text
        'GlobalVariables.Top_3_Random_1 = Top_3_Random_1_TextBox.Text
        'GlobalVariables.Top_3_Random_2 = Top_3_Random_2_TextBox.Text
        'GlobalVariables.Top_3_Number = Top_3_Number_TextBox.Text
        'GlobalVariables.Top_3_Chart = Top_3_Chart_TextBox.Text

        'GlobalVariables.Top_4_Random_1_Bowl = Top_4_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_4_Random_2_Bowl = Top_4_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_4_Number_Bowl = Top_4_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_4_Type = Top_4_Type_TextBox.Text
        'GlobalVariables.Top_4_Random_1 = Top_4_Random_1_TextBox.Text
        'GlobalVariables.Top_4_Random_2 = Top_4_Random_2_TextBox.Text
        'GlobalVariables.Top_4_Number = Top_4_Number_TextBox.Text
        'GlobalVariables.Top_4_Chart = Top_4_Chart_TextBox.Text

        'GlobalVariables.Top_5_Random_1_Bowl = Top_5_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_5_Random_2_Bowl = Top_5_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_5_Number_Bowl = Top_5_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_5_Type = Top_5_Type_TextBox.Text
        'GlobalVariables.Top_5_Random_1 = Top_5_Random_1_TextBox.Text
        'GlobalVariables.Top_5_Random_2 = Top_5_Random_2_TextBox.Text
        'GlobalVariables.Top_5_Number = Top_5_Number_TextBox.Text
        'GlobalVariables.Top_5_Chart = Top_5_Chart_TextBox.Text

        'GlobalVariables.Top_5_Random_1_Bowl = Top_5_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_5_Random_2_Bowl = Top_5_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_5_Number_Bowl = Top_5_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_6_Type = Top_6_Type_TextBox.Text
        'GlobalVariables.Top_6_Random_1 = Top_6_Random_1_TextBox.Text
        'GlobalVariables.Top_6_Random_2 = Top_6_Random_2_TextBox.Text
        'GlobalVariables.Top_6_Number = Top_6_Number_TextBox.Text
        'GlobalVariables.Top_6_Chart = Top_6_Chart_TextBox.Text

        'GlobalVariables.Top_6_Random_1_Bowl = Top_6_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_6_Random_2_Bowl = Top_6_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_6_Number_Bowl = Top_6_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_7_Type = Top_7_Type_TextBox.Text
        'GlobalVariables.Top_7_Random_1 = Top_7_Random_1_TextBox.Text
        'GlobalVariables.Top_7_Random_2 = Top_7_Random_2_TextBox.Text
        'GlobalVariables.Top_7_Number = Top_7_Number_TextBox.Text
        'GlobalVariables.Top_7_Chart = Top_7_Chart_TextBox.Text

        'GlobalVariables.Top_7_Random_1_Bowl = Top_7_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_7_Random_2_Bowl = Top_7_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_7_Number_Bowl = Top_7_Number_Bowl_TextBox.Text

        'GlobalVariables.Top_8_Type = Top_8_Type_TextBox.Text
        'GlobalVariables.Top_8_Random_1 = Top_8_Random_1_TextBox.Text
        'GlobalVariables.Top_8_Random_2 = Top_8_Random_2_TextBox.Text
        'GlobalVariables.Top_8_Number = Top_8_Number_TextBox.Text
        'GlobalVariables.Top_8_Chart = Top_8_Chart_TextBox.Text

        'GlobalVariables.Top_8_Random_1_Bowl = Top_8_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Top_8_Random_2_Bowl = Top_8_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Top_8_Number_Bowl = Top_8_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_1_Type = Mid_1_Type_TextBox.Text
        'GlobalVariables.Mid_1_Random_1 = Mid_1_Random_1_TextBox.Text
        'GlobalVariables.Mid_1_Random_2 = Mid_1_Random_2_TextBox.Text
        'GlobalVariables.Mid_1_Number = Mid_1_Number_TextBox.Text
        'GlobalVariables.Mid_1_Chart = Mid_1_Chart_TextBox.Text

        'GlobalVariables.Mid_1_Random_1_Bowl = Mid_1_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_1_Random_2_Bowl = Mid_1_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_1_Number_Bowl = Mid_1_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_2_Type = Mid_2_Type_TextBox.Text
        'GlobalVariables.Mid_2_Random_1 = Mid_2_Random_1_TextBox.Text
        'GlobalVariables.Mid_2_Random_2 = Mid_2_Random_2_TextBox.Text
        'GlobalVariables.Mid_2_Number = Mid_2_Number_TextBox.Text
        'GlobalVariables.Mid_2_Chart = Mid_2_Chart_TextBox.Text

        'GlobalVariables.Mid_2_Random_1_Bowl = Mid_2_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_2_Random_2_Bowl = Mid_2_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_2_Number_Bowl = Mid_2_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_3_Type = Mid_3_Type_TextBox.Text
        'GlobalVariables.Mid_3_Random_1 = Mid_3_Random_1_TextBox.Text
        'GlobalVariables.Mid_3_Random_2 = Mid_3_Random_2_TextBox.Text
        'GlobalVariables.Mid_3_Number = Mid_3_Number_TextBox.Text
        'GlobalVariables.Mid_3_Chart = Mid_3_Chart_TextBox.Text

        'GlobalVariables.Mid_3_Random_1_Bowl = Mid_3_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_3_Random_2_Bowl = Mid_3_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_3_Number_Bowl = Mid_3_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_4_Random_1_Bowl = Mid_4_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_4_Random_2_Bowl = Mid_4_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_4_Number_Bowl = Mid_4_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_4_Type = Mid_4_Type_TextBox.Text
        'GlobalVariables.Mid_4_Random_1 = Mid_4_Random_1_TextBox.Text
        'GlobalVariables.Mid_4_Random_2 = Mid_4_Random_2_TextBox.Text
        'GlobalVariables.Mid_4_Number = Mid_4_Number_TextBox.Text
        'GlobalVariables.Mid_4_Chart = Mid_4_Chart_TextBox.Text

        'GlobalVariables.Mid_4_Random_1_Bowl = Mid_4_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_4_Random_2_Bowl = Mid_4_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_4_Number_Bowl = Mid_4_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_5_Type = Mid_5_Type_TextBox.Text
        'GlobalVariables.Mid_5_Random_1 = Mid_5_Random_1_TextBox.Text
        'GlobalVariables.Mid_5_Random_2 = Mid_5_Random_2_TextBox.Text
        'GlobalVariables.Mid_5_Number = Mid_5_Number_TextBox.Text
        'GlobalVariables.Mid_5_Chart = Mid_5_Chart_TextBox.Text

        'GlobalVariables.Mid_5_Random_1_Bowl = Mid_5_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_5_Random_2_Bowl = Mid_5_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_5_Number_Bowl = Mid_5_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_6_Type = Mid_6_Type_TextBox.Text
        'GlobalVariables.Mid_6_Random_1 = Mid_6_Random_1_TextBox.Text
        'GlobalVariables.Mid_6_Random_2 = Mid_6_Random_2_TextBox.Text
        'GlobalVariables.Mid_6_Number = Mid_6_Number_TextBox.Text
        'GlobalVariables.Mid_6_Chart = Mid_6_Chart_TextBox.Text

        'GlobalVariables.Mid_6_Random_1_Bowl = Mid_6_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_6_Random_2_Bowl = Mid_6_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_6_Number_Bowl = Mid_6_Number_Bowl_TextBox.Text

        'GlobalVariables.Mid_7_Type = Mid_7_Type_TextBox.Text
        'GlobalVariables.Mid_7_Random_1 = Mid_7_Random_1_TextBox.Text
        'GlobalVariables.Mid_7_Random_2 = Mid_7_Random_2_TextBox.Text
        'GlobalVariables.Mid_7_Number = Mid_7_Number_TextBox.Text
        'GlobalVariables.Mid_7_Chart = Mid_7_Chart_TextBox.Text

        'GlobalVariables.Mid_7_Random_1_Bowl = Mid_7_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Mid_7_Random_2_Bowl = Mid_7_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Mid_7_Number_Bowl = Mid_7_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_1_Type = Bot_1_Type_TextBox.Text
        'GlobalVariables.Bot_1_Random_1 = Bot_1_Random_1_TextBox.Text
        'GlobalVariables.Bot_1_Random_2 = Bot_1_Random_2_TextBox.Text
        'GlobalVariables.Bot_1_Number = Bot_1_Number_TextBox.Text
        'GlobalVariables.Bot_1_Chart = Bot_1_Chart_TextBox.Text

        'GlobalVariables.Bot_1_Random_1_Bowl = Bot_1_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_1_Random_2_Bowl = Bot_1_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_1_Number_Bowl = Bot_1_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_2_Type = Bot_2_Type_TextBox.Text
        'GlobalVariables.Bot_2_Random_1 = Bot_2_Random_1_TextBox.Text
        'GlobalVariables.Bot_2_Random_2 = Bot_2_Random_2_TextBox.Text
        'GlobalVariables.Bot_2_Number = Bot_2_Number_TextBox.Text
        'GlobalVariables.Bot_2_Chart = Bot_2_Chart_TextBox.Text

        'GlobalVariables.Bot_2_Random_1_Bowl = Bot_2_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_2_Random_2_Bowl = Bot_2_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_2_Number_Bowl = Bot_2_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_3_Type = Bot_3_Type_TextBox.Text
        'GlobalVariables.Bot_3_Random_1 = Bot_3_Random_1_TextBox.Text
        'GlobalVariables.Bot_3_Random_2 = Bot_3_Random_2_TextBox.Text
        'GlobalVariables.Bot_3_Number = Bot_3_Number_TextBox.Text
        'GlobalVariables.Bot_3_Chart = Bot_3_Chart_TextBox.Text

        'GlobalVariables.Bot_3_Random_1_Bowl = Bot_3_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_3_Random_2_Bowl = Bot_3_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_3_Number_Bowl = Bot_3_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_4_Type = Bot_4_Type_TextBox.Text
        'GlobalVariables.Bot_4_Random_1 = Bot_4_Random_1_TextBox.Text
        'GlobalVariables.Bot_4_Random_2 = Bot_4_Random_2_TextBox.Text
        'GlobalVariables.Bot_4_Number = Bot_4_Number_TextBox.Text
        'GlobalVariables.Bot_4_Chart = Bot_4_Chart_TextBox.Text

        'GlobalVariables.Bot_4_Random_1_Bowl = Bot_4_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_4_Random_2_Bowl = Bot_4_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_4_Number_Bowl = Bot_4_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_5_Type = Bot_5_Type_TextBox.Text
        'GlobalVariables.Bot_5_Random_1 = Bot_5_Random_1_TextBox.Text
        'GlobalVariables.Bot_5_Random_2 = Bot_5_Random_2_TextBox.Text
        'GlobalVariables.Bot_5_Number = Bot_5_Number_TextBox.Text
        'GlobalVariables.Bot_5_Chart = Bot_5_Chart_TextBox.Text

        'GlobalVariables.Bot_5_Random_1_Bowl = Bot_5_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_5_Random_2_Bowl = Bot_5_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_5_Number_Bowl = Bot_5_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_6_Type = Bot_6_Type_TextBox.Text
        'GlobalVariables.Bot_6_Random_1 = Bot_6_Random_1_TextBox.Text
        'GlobalVariables.Bot_6_Random_2 = Bot_6_Random_2_TextBox.Text
        'GlobalVariables.Bot_6_Number = Bot_6_Number_TextBox.Text
        'GlobalVariables.Bot_6_Chart = Bot_6_Chart_TextBox.Text

        'GlobalVariables.Bot_6_Random_1_Bowl = Bot_6_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_6_Random_2_Bowl = Bot_6_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_6_Number_Bowl = Bot_6_Number_Bowl_TextBox.Text

        'GlobalVariables.Bot_7_Type = Bot_7_Type_TextBox.Text
        'GlobalVariables.Bot_7_Random_1 = Bot_7_Random_1_TextBox.Text
        'GlobalVariables.Bot_7_Random_2 = Bot_7_Random_2_TextBox.Text
        'GlobalVariables.Bot_7_Number = Bot_7_Number_TextBox.Text
        'GlobalVariables.Bot_7_Chart = Bot_7_Chart_TextBox.Text

        'GlobalVariables.Bot_7_Random_1_Bowl = Bot_7_Random_1_Bowl_TextBox.Text
        'GlobalVariables.Bot_7_Random_2_Bowl = Bot_7_Random_2_Bowl_TextBox.Text
        'GlobalVariables.Bot_7_Number_Bowl = Bot_7_Number_Bowl_TextBox.Text

        '' Spring 1
        'If Spring_1_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_1_1_Selection = Spring_1_Number_TextBox.Text
        '    GlobalVariables.Spring_1_2_Selection = "--"
        '    GlobalVariables.Spring_1_1_Bowl_Selection = Spring_1_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_1_2_Bowl_Selection = "--"

        '    Spring_1_Number_TextBox.Visible = True
        '    Spring_1_Random_1_TextBox.Visible = False
        '    Spring_1_Random_2_TextBox.Visible = False
        '    Spring_1_Chart_TextBox.Visible = False

        '    Spring_1_Number_Bowl_TextBox.Visible = True
        '    Spring_1_Random_1_Bowl_TextBox.Visible = False
        '    Spring_1_Random_2_Bowl_TextBox.Visible = False
        '    Spring_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_1_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_1_1_Selection = Spring_1_Random_1_TextBox.Text
        '    GlobalVariables.Spring_1_2_Selection = Spring_1_Random_2_TextBox.Text
        '    GlobalVariables.Spring_1_1_Bowl_Selection = Spring_1_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_1_2_Bowl_Selection = Spring_1_Random_2_Bowl_TextBox.Text

        '    Spring_1_Number_TextBox.Visible = False
        '    Spring_1_Random_1_TextBox.Visible = True
        '    Spring_1_Random_2_TextBox.Visible = True
        '    Spring_1_Chart_TextBox.Visible = False

        '    Spring_1_Number_Bowl_TextBox.Visible = False
        '    Spring_1_Random_1_Bowl_TextBox.Visible = True
        '    Spring_1_Random_2_Bowl_TextBox.Visible = True
        '    Spring_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_1_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_1_1_Selection = Spring_1_Chart_TextBox.Text
        '    GlobalVariables.Spring_1_2_Selection = "--"
        '    GlobalVariables.Spring_1_1_Bowl_Selection = Spring_1_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_1_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_1_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart1(Spring_1_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Spring_1_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Spring_1_Number_TextBox.Visible = False
        '    Spring_1_Random_1_TextBox.Visible = False
        '    Spring_1_Random_2_TextBox.Visible = False
        '    Spring_1_Chart_TextBox.Visible = True

        '    Spring_1_Number_Bowl_TextBox.Visible = False
        '    Spring_1_Random_1_Bowl_TextBox.Visible = False
        '    Spring_1_Random_2_Bowl_TextBox.Visible = False
        '    Spring_1_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_1_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_1_1_Selection = "--"
        '    GlobalVariables.Spring_1_2_Selection = "--"
        '    GlobalVariables.Spring_1_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_1_2_Bowl_Selection = "--"

        '    Spring_1_Number_TextBox.Visible = False
        '    Spring_1_Random_1_TextBox.Visible = False
        '    Spring_1_Random_2_TextBox.Visible = False
        '    Spring_1_Chart_TextBox.Visible = False

        '    Spring_1_Number_Bowl_TextBox.Visible = False
        '    Spring_1_Random_1_Bowl_TextBox.Visible = False
        '    Spring_1_Random_2_Bowl_TextBox.Visible = False
        '    Spring_1_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Spring 2
        'If Spring_2_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_2_1_Selection = Spring_2_Number_TextBox.Text
        '    GlobalVariables.Spring_2_2_Selection = "--"
        '    GlobalVariables.Spring_2_1_Bowl_Selection = Spring_2_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_2_2_Bowl_Selection = "--"

        '    Spring_2_Number_TextBox.Visible = True
        '    Spring_2_Random_1_TextBox.Visible = False
        '    Spring_2_Random_2_TextBox.Visible = False
        '    Spring_2_Chart_TextBox.Visible = False

        '    Spring_2_Number_Bowl_TextBox.Visible = True
        '    Spring_2_Random_1_Bowl_TextBox.Visible = False
        '    Spring_2_Random_2_Bowl_TextBox.Visible = False
        '    Spring_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_2_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_2_1_Selection = Spring_2_Random_1_TextBox.Text
        '    GlobalVariables.Spring_2_2_Selection = Spring_2_Random_2_TextBox.Text
        '    GlobalVariables.Spring_2_1_Bowl_Selection = Spring_2_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_2_2_Bowl_Selection = Spring_2_Random_2_Bowl_TextBox.Text

        '    Spring_2_Number_TextBox.Visible = False
        '    Spring_2_Random_1_TextBox.Visible = True
        '    Spring_2_Random_2_TextBox.Visible = True
        '    Spring_2_Chart_TextBox.Visible = False

        '    Spring_2_Number_Bowl_TextBox.Visible = False
        '    Spring_2_Random_1_Bowl_TextBox.Visible = True
        '    Spring_2_Random_2_Bowl_TextBox.Visible = True
        '    Spring_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_2_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_2_1_Selection = Spring_2_Chart_TextBox.Text
        '    GlobalVariables.Spring_2_2_Selection = "--"
        '    GlobalVariables.Spring_2_1_Bowl_Selection = Spring_2_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_2_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_2_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart2(Spring_2_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Spring_2_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Spring_2_Number_TextBox.Visible = False
        '    Spring_2_Random_1_TextBox.Visible = False
        '    Spring_2_Random_2_TextBox.Visible = False
        '    Spring_2_Chart_TextBox.Visible = True

        '    Spring_2_Number_Bowl_TextBox.Visible = False
        '    Spring_2_Random_1_Bowl_TextBox.Visible = False
        '    Spring_2_Random_2_Bowl_TextBox.Visible = False
        '    Spring_2_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_2_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_2_1_Selection = "--"
        '    GlobalVariables.Spring_2_2_Selection = "--"
        '    GlobalVariables.Spring_2_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_2_2_Bowl_Selection = "--"

        '    Spring_2_Number_TextBox.Visible = False
        '    Spring_2_Random_1_TextBox.Visible = False
        '    Spring_2_Random_2_TextBox.Visible = False
        '    Spring_2_Chart_TextBox.Visible = False

        '    Spring_2_Number_Bowl_TextBox.Visible = False
        '    Spring_2_Random_1_Bowl_TextBox.Visible = False
        '    Spring_2_Random_2_Bowl_TextBox.Visible = False
        '    Spring_2_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Spring 3
        'If Spring_3_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_3_1_Selection = Spring_3_Number_TextBox.Text
        '    GlobalVariables.Spring_3_2_Selection = "--"
        '    GlobalVariables.Spring_3_1_Bowl_Selection = Spring_3_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_3_2_Bowl_Selection = "--"

        '    Spring_3_Number_TextBox.Visible = True
        '    Spring_3_Random_1_TextBox.Visible = False
        '    Spring_3_Random_2_TextBox.Visible = False
        '    Spring_3_Chart_TextBox.Visible = False

        '    Spring_3_Number_Bowl_TextBox.Visible = True
        '    Spring_3_Random_1_Bowl_TextBox.Visible = False
        '    Spring_3_Random_2_Bowl_TextBox.Visible = False
        '    Spring_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_3_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_3_1_Selection = Spring_3_Random_1_TextBox.Text
        '    GlobalVariables.Spring_3_2_Selection = Spring_3_Random_2_TextBox.Text
        '    GlobalVariables.Spring_3_1_Bowl_Selection = Spring_3_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_3_2_Bowl_Selection = Spring_3_Random_2_Bowl_TextBox.Text

        '    Spring_3_Number_TextBox.Visible = False
        '    Spring_3_Random_1_TextBox.Visible = True
        '    Spring_3_Random_2_TextBox.Visible = True
        '    Spring_3_Chart_TextBox.Visible = False

        '    Spring_3_Number_Bowl_TextBox.Visible = False
        '    Spring_3_Random_1_Bowl_TextBox.Visible = True
        '    Spring_3_Random_2_Bowl_TextBox.Visible = True
        '    Spring_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_3_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_3_1_Selection = Spring_3_Chart_TextBox.Text
        '    GlobalVariables.Spring_3_2_Selection = "--"
        '    GlobalVariables.Spring_3_1_Bowl_Selection = Spring_3_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_3_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_3_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart3(Spring_3_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Spring_3_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Spring_3_Number_TextBox.Visible = False
        '    Spring_3_Random_1_TextBox.Visible = False
        '    Spring_3_Random_2_TextBox.Visible = False
        '    Spring_3_Chart_TextBox.Visible = True

        '    Spring_3_Number_Bowl_TextBox.Visible = False
        '    Spring_3_Random_1_Bowl_TextBox.Visible = False
        '    Spring_3_Random_2_Bowl_TextBox.Visible = False
        '    Spring_3_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_3_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_3_1_Selection = "--"
        '    GlobalVariables.Spring_3_2_Selection = "--"
        '    GlobalVariables.Spring_3_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_3_2_Bowl_Selection = "--"

        '    Spring_3_Number_TextBox.Visible = False
        '    Spring_3_Random_1_TextBox.Visible = False
        '    Spring_3_Random_2_TextBox.Visible = False
        '    Spring_3_Chart_TextBox.Visible = False

        '    Spring_3_Number_Bowl_TextBox.Visible = False
        '    Spring_3_Random_1_Bowl_TextBox.Visible = False
        '    Spring_3_Random_2_Bowl_TextBox.Visible = False
        '    Spring_3_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Spring 4
        'If Spring_4_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_4_1_Selection = Spring_4_Number_TextBox.Text
        '    GlobalVariables.Spring_4_2_Selection = "--"
        '    GlobalVariables.Spring_4_1_Bowl_Selection = Spring_4_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_4_2_Bowl_Selection = "--"

        '    Spring_4_Number_TextBox.Visible = True
        '    Spring_4_Random_1_TextBox.Visible = False
        '    Spring_4_Random_2_TextBox.Visible = False
        '    Spring_4_Chart_TextBox.Visible = False

        '    Spring_4_Number_Bowl_TextBox.Visible = True
        '    Spring_4_Random_1_Bowl_TextBox.Visible = False
        '    Spring_4_Random_2_Bowl_TextBox.Visible = False
        '    Spring_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_4_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_4_1_Selection = Spring_4_Random_1_TextBox.Text
        '    GlobalVariables.Spring_4_2_Selection = Spring_4_Random_2_TextBox.Text
        '    GlobalVariables.Spring_4_1_Bowl_Selection = Spring_4_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_4_2_Bowl_Selection = Spring_4_Random_2_Bowl_TextBox.Text

        '    Spring_4_Number_TextBox.Visible = False
        '    Spring_4_Random_1_TextBox.Visible = True
        '    Spring_4_Random_2_TextBox.Visible = True
        '    Spring_4_Chart_TextBox.Visible = False

        '    Spring_4_Number_Bowl_TextBox.Visible = False
        '    Spring_4_Random_1_Bowl_TextBox.Visible = True
        '    Spring_4_Random_2_Bowl_TextBox.Visible = True
        '    Spring_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_4_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_4_1_Selection = Spring_4_Chart_TextBox.Text
        '    GlobalVariables.Spring_4_2_Selection = "--"
        '    GlobalVariables.Spring_4_1_Bowl_Selection = Spring_4_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_4_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_4_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart4(Spring_4_Chart_TextBox.Text)
        '        Spring_4_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '    End If

        '    Spring_4_Number_TextBox.Visible = False
        '    Spring_4_Random_1_TextBox.Visible = False
        '    Spring_4_Random_2_TextBox.Visible = False
        '    Spring_4_Chart_TextBox.Visible = True

        '    Spring_4_Number_Bowl_TextBox.Visible = False
        '    Spring_4_Random_1_Bowl_TextBox.Visible = False
        '    Spring_4_Random_2_Bowl_TextBox.Visible = False
        '    Spring_4_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_4_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_4_1_Selection = "--"
        '    GlobalVariables.Spring_4_2_Selection = "--"
        '    GlobalVariables.Spring_4_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_4_2_Bowl_Selection = "--"

        '    Spring_4_Number_TextBox.Visible = False
        '    Spring_4_Random_1_TextBox.Visible = False
        '    Spring_4_Random_2_TextBox.Visible = False
        '    Spring_4_Chart_TextBox.Visible = False

        '    Spring_4_Number_Bowl_TextBox.Visible = False
        '    Spring_4_Random_1_Bowl_TextBox.Visible = False
        '    Spring_4_Random_2_Bowl_TextBox.Visible = False
        '    Spring_4_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Spring 5
        'If Spring_5_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_5_1_Selection = Spring_5_Number_TextBox.Text
        '    GlobalVariables.Spring_5_2_Selection = "--"
        '    GlobalVariables.Spring_5_1_Bowl_Selection = Spring_5_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_5_2_Bowl_Selection = "--"

        '    Spring_5_Number_TextBox.Visible = True
        '    Spring_5_Random_1_TextBox.Visible = False
        '    Spring_5_Random_2_TextBox.Visible = False
        '    Spring_5_Chart_TextBox.Visible = False

        '    Spring_5_Number_Bowl_TextBox.Visible = True
        '    Spring_5_Random_1_Bowl_TextBox.Visible = False
        '    Spring_5_Random_2_Bowl_TextBox.Visible = False
        '    Spring_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_5_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_5_1_Selection = Spring_5_Random_1_TextBox.Text
        '    GlobalVariables.Spring_5_2_Selection = Spring_5_Random_2_TextBox.Text
        '    GlobalVariables.Spring_5_1_Bowl_Selection = Spring_5_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_5_2_Bowl_Selection = Spring_5_Random_2_Bowl_TextBox.Text

        '    Spring_5_Number_TextBox.Visible = False
        '    Spring_5_Random_1_TextBox.Visible = True
        '    Spring_5_Random_2_TextBox.Visible = True
        '    Spring_5_Chart_TextBox.Visible = False

        '    Spring_5_Number_Bowl_TextBox.Visible = False
        '    Spring_5_Random_1_Bowl_TextBox.Visible = True
        '    Spring_5_Random_2_Bowl_TextBox.Visible = True
        '    Spring_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_5_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_5_1_Selection = Spring_5_Chart_TextBox.Text
        '    GlobalVariables.Spring_5_2_Selection = "--"
        '    GlobalVariables.Spring_5_1_Bowl_Selection = Spring_5_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_5_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_5_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart5(Spring_5_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Spring_5_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Spring_5_Number_TextBox.Visible = False
        '    Spring_5_Random_1_TextBox.Visible = False
        '    Spring_5_Random_2_TextBox.Visible = False
        '    Spring_5_Chart_TextBox.Visible = True

        '    Spring_5_Number_Bowl_TextBox.Visible = False
        '    Spring_5_Random_1_Bowl_TextBox.Visible = False
        '    Spring_5_Random_2_Bowl_TextBox.Visible = False
        '    Spring_5_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_5_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_5_1_Selection = "--"
        '    GlobalVariables.Spring_5_2_Selection = "--"
        '    GlobalVariables.Spring_5_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_5_2_Bowl_Selection = "--"

        '    Spring_5_Number_TextBox.Visible = False
        '    Spring_5_Random_1_TextBox.Visible = False
        '    Spring_5_Random_2_TextBox.Visible = False
        '    Spring_5_Chart_TextBox.Visible = False

        '    Spring_5_Number_Bowl_TextBox.Visible = False
        '    Spring_5_Random_1_Bowl_TextBox.Visible = False
        '    Spring_5_Random_2_Bowl_TextBox.Visible = False
        '    Spring_5_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Spring 6
        'If Spring_6_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_6_1_Selection = Spring_6_Number_TextBox.Text
        '    GlobalVariables.Spring_6_2_Selection = "--"
        '    GlobalVariables.Spring_6_1_Bowl_Selection = Spring_6_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_6_2_Bowl_Selection = "--"

        '    Spring_6_Number_TextBox.Visible = True
        '    Spring_6_Random_1_TextBox.Visible = False
        '    Spring_6_Random_2_TextBox.Visible = False
        '    Spring_6_Chart_TextBox.Visible = False

        '    Spring_6_Number_Bowl_TextBox.Visible = True
        '    Spring_6_Random_1_Bowl_TextBox.Visible = False
        '    Spring_6_Random_2_Bowl_TextBox.Visible = False
        '    Spring_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_6_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_6_1_Selection = Spring_6_Random_1_TextBox.Text
        '    GlobalVariables.Spring_6_2_Selection = Spring_6_Random_2_TextBox.Text
        '    GlobalVariables.Spring_6_1_Bowl_Selection = Spring_6_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_6_2_Bowl_Selection = Spring_6_Random_2_Bowl_TextBox.Text

        '    Spring_6_Number_TextBox.Visible = False
        '    Spring_6_Random_1_TextBox.Visible = True
        '    Spring_6_Random_2_TextBox.Visible = True
        '    Spring_6_Chart_TextBox.Visible = False

        '    Spring_6_Number_Bowl_TextBox.Visible = False
        '    Spring_6_Random_1_Bowl_TextBox.Visible = True
        '    Spring_6_Random_2_Bowl_TextBox.Visible = True
        '    Spring_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_6_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_6_1_Selection = Spring_6_Chart_TextBox.Text
        '    GlobalVariables.Spring_6_2_Selection = "--"
        '    GlobalVariables.Spring_6_1_Bowl_Selection = Spring_6_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_6_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_6_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart6(Spring_6_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Spring_6_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Spring_6_Number_TextBox.Visible = False
        '    Spring_6_Random_1_TextBox.Visible = False
        '    Spring_6_Random_2_TextBox.Visible = False
        '    Spring_6_Chart_TextBox.Visible = True

        '    Spring_6_Number_Bowl_TextBox.Visible = False
        '    Spring_6_Random_1_Bowl_TextBox.Visible = False
        '    Spring_6_Random_2_Bowl_TextBox.Visible = False
        '    Spring_6_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_6_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_6_1_Selection = "--"
        '    GlobalVariables.Spring_6_2_Selection = "--"
        '    GlobalVariables.Spring_6_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_6_2_Bowl_Selection = "--"

        '    Spring_6_Number_TextBox.Visible = False
        '    Spring_6_Random_1_TextBox.Visible = False
        '    Spring_6_Random_2_TextBox.Visible = False
        '    Spring_6_Chart_TextBox.Visible = False

        '    Spring_6_Number_Bowl_TextBox.Visible = False
        '    Spring_6_Random_1_Bowl_TextBox.Visible = False
        '    Spring_6_Random_2_Bowl_TextBox.Visible = False
        '    Spring_6_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Spring 7
        'If Spring_7_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Spring_7_1_Selection = Spring_7_Number_TextBox.Text
        '    GlobalVariables.Spring_7_2_Selection = "--"
        '    GlobalVariables.Spring_7_1_Bowl_Selection = Spring_7_Number_Bowl_TextBox.Text
        '    GlobalVariables.Spring_7_2_Bowl_Selection = "--"

        '    Spring_7_Number_TextBox.Visible = True
        '    Spring_7_Random_1_TextBox.Visible = False
        '    Spring_7_Random_2_TextBox.Visible = False
        '    Spring_7_Chart_TextBox.Visible = False

        '    Spring_7_Number_Bowl_TextBox.Visible = True
        '    Spring_7_Random_1_Bowl_TextBox.Visible = False
        '    Spring_7_Random_2_Bowl_TextBox.Visible = False
        '    Spring_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_7_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Spring_7_1_Selection = Spring_7_Random_1_TextBox.Text
        '    GlobalVariables.Spring_7_2_Selection = Spring_7_Random_2_TextBox.Text
        '    GlobalVariables.Spring_7_1_Bowl_Selection = Spring_7_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Spring_7_2_Bowl_Selection = Spring_7_Random_2_Bowl_TextBox.Text

        '    Spring_7_Number_TextBox.Visible = False
        '    Spring_7_Random_1_TextBox.Visible = True
        '    Spring_7_Random_2_TextBox.Visible = True
        '    Spring_7_Chart_TextBox.Visible = False

        '    Spring_7_Number_Bowl_TextBox.Visible = False
        '    Spring_7_Random_1_Bowl_TextBox.Visible = True
        '    Spring_7_Random_2_Bowl_TextBox.Visible = True
        '    Spring_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Spring_7_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Spring_7_1_Selection = Spring_7_Chart_TextBox.Text
        '    GlobalVariables.Spring_7_2_Selection = "--"
        '    GlobalVariables.Spring_7_1_Bowl_Selection = Spring_7_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Spring_7_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Spring_7_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart7(Spring_7_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Spring_7_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Spring_7_Number_TextBox.Visible = False
        '    Spring_7_Random_1_TextBox.Visible = False
        '    Spring_7_Random_2_TextBox.Visible = False
        '    Spring_7_Chart_TextBox.Visible = True

        '    Spring_7_Number_Bowl_TextBox.Visible = False
        '    Spring_7_Random_1_Bowl_TextBox.Visible = False
        '    Spring_7_Random_2_Bowl_TextBox.Visible = False
        '    Spring_7_Chart_Bowl_TextBox.Visible = True

        'ElseIf Spring_7_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Spring_7_1_Selection = "--"
        '    GlobalVariables.Spring_7_2_Selection = "--"
        '    GlobalVariables.Spring_7_1_Bowl_Selection = "--"
        '    GlobalVariables.Spring_7_2_Bowl_Selection = "--"

        '    Spring_7_Number_TextBox.Visible = False
        '    Spring_7_Random_1_TextBox.Visible = False
        '    Spring_7_Random_2_TextBox.Visible = False
        '    Spring_7_Chart_TextBox.Visible = False

        '    Spring_7_Number_Bowl_TextBox.Visible = False
        '    Spring_7_Random_1_Bowl_TextBox.Visible = False
        '    Spring_7_Random_2_Bowl_TextBox.Visible = False
        '    Spring_7_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 1
        'If Top_1_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_1_1_Selection = Top_1_Number_TextBox.Text
        '    GlobalVariables.Top_1_2_Selection = "--"
        '    GlobalVariables.Top_1_1_Bowl_Selection = Top_1_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_1_2_Bowl_Selection = "--"

        '    Top_1_Number_TextBox.Visible = True
        '    Top_1_Random_1_TextBox.Visible = False
        '    Top_1_Random_2_TextBox.Visible = False
        '    Top_1_Chart_TextBox.Visible = False

        '    Top_1_Number_Bowl_TextBox.Visible = True
        '    Top_1_Random_1_Bowl_TextBox.Visible = False
        '    Top_1_Random_2_Bowl_TextBox.Visible = False
        '    Top_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_1_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_1_1_Selection = Top_1_Random_1_TextBox.Text
        '    GlobalVariables.Top_1_2_Selection = Top_1_Random_2_TextBox.Text
        '    GlobalVariables.Top_1_1_Bowl_Selection = Top_1_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_1_2_Bowl_Selection = Top_1_Random_2_Bowl_TextBox.Text

        '    Top_1_Number_TextBox.Visible = False
        '    Top_1_Random_1_TextBox.Visible = True
        '    Top_1_Random_2_TextBox.Visible = True
        '    Top_1_Chart_TextBox.Visible = False

        '    Top_1_Number_Bowl_TextBox.Visible = False
        '    Top_1_Random_1_Bowl_TextBox.Visible = True
        '    Top_1_Random_2_Bowl_TextBox.Visible = True
        '    Top_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_1_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_1_1_Selection = Top_1_Chart_TextBox.Text
        '    GlobalVariables.Top_1_2_Selection = "--"
        '    GlobalVariables.Top_1_1_Bowl_Selection = Top_1_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_1_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_1_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart1(Top_1_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_1_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_1_Number_TextBox.Visible = False
        '    Top_1_Random_1_TextBox.Visible = False
        '    Top_1_Random_2_TextBox.Visible = False
        '    Top_1_Chart_TextBox.Visible = True

        '    Top_1_Number_Bowl_TextBox.Visible = False
        '    Top_1_Random_1_Bowl_TextBox.Visible = False
        '    Top_1_Random_2_Bowl_TextBox.Visible = False
        '    Top_1_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_1_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_1_1_Selection = "--"
        '    GlobalVariables.Top_1_2_Selection = "--"
        '    GlobalVariables.Top_1_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_1_2_Bowl_Selection = "--"

        '    Top_1_Number_TextBox.Visible = False
        '    Top_1_Random_1_TextBox.Visible = False
        '    Top_1_Random_2_TextBox.Visible = False
        '    Top_1_Chart_TextBox.Visible = False

        '    Top_1_Number_Bowl_TextBox.Visible = False
        '    Top_1_Random_1_Bowl_TextBox.Visible = False
        '    Top_1_Random_2_Bowl_TextBox.Visible = False
        '    Top_1_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 2
        'If Top_2_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_2_1_Selection = Top_2_Number_TextBox.Text
        '    GlobalVariables.Top_2_2_Selection = "--"
        '    GlobalVariables.Top_2_1_Bowl_Selection = Top_2_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_2_2_Bowl_Selection = "--"

        '    Top_2_Number_TextBox.Visible = True
        '    Top_2_Random_1_TextBox.Visible = False
        '    Top_2_Random_2_TextBox.Visible = False
        '    Top_2_Chart_TextBox.Visible = False

        '    Top_2_Number_Bowl_TextBox.Visible = True
        '    Top_2_Random_1_Bowl_TextBox.Visible = False
        '    Top_2_Random_2_Bowl_TextBox.Visible = False
        '    Top_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_2_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_2_1_Selection = Top_2_Random_1_TextBox.Text
        '    GlobalVariables.Top_2_2_Selection = Top_2_Random_2_TextBox.Text
        '    GlobalVariables.Top_2_1_Bowl_Selection = Top_2_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_2_2_Bowl_Selection = Top_2_Random_2_Bowl_TextBox.Text

        '    Top_2_Number_TextBox.Visible = False
        '    Top_2_Random_1_TextBox.Visible = True
        '    Top_2_Random_2_TextBox.Visible = True
        '    Top_2_Chart_TextBox.Visible = False

        '    Top_2_Number_Bowl_TextBox.Visible = False
        '    Top_2_Random_1_Bowl_TextBox.Visible = True
        '    Top_2_Random_2_Bowl_TextBox.Visible = True
        '    Top_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_2_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_2_1_Selection = Top_2_Chart_TextBox.Text
        '    GlobalVariables.Top_2_2_Selection = "--"
        '    GlobalVariables.Top_2_1_Bowl_Selection = Top_2_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_2_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_2_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart2(Top_2_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_2_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_2_Number_TextBox.Visible = False
        '    Top_2_Random_1_TextBox.Visible = False
        '    Top_2_Random_2_TextBox.Visible = False
        '    Top_2_Chart_TextBox.Visible = True

        '    Top_2_Number_Bowl_TextBox.Visible = False
        '    Top_2_Random_1_Bowl_TextBox.Visible = False
        '    Top_2_Random_2_Bowl_TextBox.Visible = False
        '    Top_2_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_2_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_2_1_Selection = "--"
        '    GlobalVariables.Top_2_2_Selection = "--"
        '    GlobalVariables.Top_2_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_2_2_Bowl_Selection = "--"

        '    Top_2_Number_TextBox.Visible = False
        '    Top_2_Random_1_TextBox.Visible = False
        '    Top_2_Random_2_TextBox.Visible = False
        '    Top_2_Chart_TextBox.Visible = False

        '    Top_2_Number_Bowl_TextBox.Visible = False
        '    Top_2_Random_1_Bowl_TextBox.Visible = False
        '    Top_2_Random_2_Bowl_TextBox.Visible = False
        '    Top_2_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 3
        'If Top_3_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_3_1_Selection = Top_3_Number_TextBox.Text
        '    GlobalVariables.Top_3_2_Selection = "--"
        '    GlobalVariables.Top_3_1_Bowl_Selection = Top_3_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_3_2_Bowl_Selection = "--"

        '    Top_3_Number_TextBox.Visible = True
        '    Top_3_Random_1_TextBox.Visible = False
        '    Top_3_Random_2_TextBox.Visible = False
        '    Top_3_Chart_TextBox.Visible = False

        '    Top_3_Number_Bowl_TextBox.Visible = True
        '    Top_3_Random_1_Bowl_TextBox.Visible = False
        '    Top_3_Random_2_Bowl_TextBox.Visible = False
        '    Top_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_3_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_3_1_Selection = Top_3_Random_1_TextBox.Text
        '    GlobalVariables.Top_3_2_Selection = Top_3_Random_2_TextBox.Text
        '    GlobalVariables.Top_3_1_Bowl_Selection = Top_3_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_3_2_Bowl_Selection = Top_3_Random_2_Bowl_TextBox.Text

        '    Top_3_Number_TextBox.Visible = False
        '    Top_3_Random_1_TextBox.Visible = True
        '    Top_3_Random_2_TextBox.Visible = True
        '    Top_3_Chart_TextBox.Visible = False

        '    Top_3_Number_Bowl_TextBox.Visible = False
        '    Top_3_Random_1_Bowl_TextBox.Visible = True
        '    Top_3_Random_2_Bowl_TextBox.Visible = True
        '    Top_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_3_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_3_1_Selection = Top_3_Chart_TextBox.Text
        '    GlobalVariables.Top_3_2_Selection = "--"
        '    GlobalVariables.Top_3_1_Bowl_Selection = Top_3_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_3_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_3_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart3(Top_3_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_3_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_3_Number_TextBox.Visible = False
        '    Top_3_Random_1_TextBox.Visible = False
        '    Top_3_Random_2_TextBox.Visible = False
        '    Top_3_Chart_TextBox.Visible = True

        '    Top_3_Number_Bowl_TextBox.Visible = False
        '    Top_3_Random_1_Bowl_TextBox.Visible = False
        '    Top_3_Random_2_Bowl_TextBox.Visible = False
        '    Top_3_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_3_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_3_1_Selection = "--"
        '    GlobalVariables.Top_3_2_Selection = "--"
        '    GlobalVariables.Top_3_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_3_2_Bowl_Selection = "--"

        '    Top_3_Number_TextBox.Visible = False
        '    Top_3_Random_1_TextBox.Visible = False
        '    Top_3_Random_2_TextBox.Visible = False
        '    Top_3_Chart_TextBox.Visible = False

        '    Top_3_Number_Bowl_TextBox.Visible = False
        '    Top_3_Random_1_Bowl_TextBox.Visible = False
        '    Top_3_Random_2_Bowl_TextBox.Visible = False
        '    Top_3_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 4
        'If Top_4_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_4_1_Selection = Top_4_Number_TextBox.Text
        '    GlobalVariables.Top_4_2_Selection = "--"
        '    GlobalVariables.Top_4_1_Bowl_Selection = Top_4_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_4_2_Bowl_Selection = "--"

        '    Top_4_Number_TextBox.Visible = True
        '    Top_4_Random_1_TextBox.Visible = False
        '    Top_4_Random_2_TextBox.Visible = False
        '    Top_4_Chart_TextBox.Visible = False

        '    Top_4_Number_Bowl_TextBox.Visible = True
        '    Top_4_Random_1_Bowl_TextBox.Visible = False
        '    Top_4_Random_2_Bowl_TextBox.Visible = False
        '    Top_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_4_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_4_1_Selection = Top_4_Random_1_TextBox.Text
        '    GlobalVariables.Top_4_2_Selection = Top_4_Random_2_TextBox.Text
        '    GlobalVariables.Top_4_1_Bowl_Selection = Top_4_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_4_2_Bowl_Selection = Top_4_Random_2_Bowl_TextBox.Text

        '    Top_4_Number_TextBox.Visible = False
        '    Top_4_Random_1_TextBox.Visible = True
        '    Top_4_Random_2_TextBox.Visible = True
        '    Top_4_Chart_TextBox.Visible = False

        '    Top_4_Number_Bowl_TextBox.Visible = False
        '    Top_4_Random_1_Bowl_TextBox.Visible = True
        '    Top_4_Random_2_Bowl_TextBox.Visible = True
        '    Top_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_4_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_4_1_Selection = Top_4_Chart_TextBox.Text
        '    GlobalVariables.Top_4_2_Selection = "--"
        '    GlobalVariables.Top_4_1_Bowl_Selection = Top_4_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_4_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_4_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart4(Top_4_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_4_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_4_Number_TextBox.Visible = False
        '    Top_4_Random_1_TextBox.Visible = False
        '    Top_4_Random_2_TextBox.Visible = False
        '    Top_4_Chart_TextBox.Visible = True

        '    Top_4_Number_Bowl_TextBox.Visible = False
        '    Top_4_Random_1_Bowl_TextBox.Visible = False
        '    Top_4_Random_2_Bowl_TextBox.Visible = False
        '    Top_4_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_4_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_4_1_Selection = "--"
        '    GlobalVariables.Top_4_2_Selection = "--"
        '    GlobalVariables.Top_4_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_4_2_Bowl_Selection = "--"

        '    Top_4_Number_TextBox.Visible = False
        '    Top_4_Random_1_TextBox.Visible = False
        '    Top_4_Random_2_TextBox.Visible = False
        '    Top_4_Chart_TextBox.Visible = False

        '    Top_4_Number_Bowl_TextBox.Visible = False
        '    Top_4_Random_1_Bowl_TextBox.Visible = False
        '    Top_4_Random_2_Bowl_TextBox.Visible = False
        '    Top_4_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 5
        'If Top_5_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_5_1_Selection = Top_5_Number_TextBox.Text
        '    GlobalVariables.Top_5_2_Selection = "--"
        '    GlobalVariables.Top_5_1_Bowl_Selection = Top_5_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_5_2_Bowl_Selection = "--"

        '    Top_5_Number_TextBox.Visible = True
        '    Top_5_Random_1_TextBox.Visible = False
        '    Top_5_Random_2_TextBox.Visible = False
        '    Top_5_Chart_TextBox.Visible = False

        '    Top_5_Number_Bowl_TextBox.Visible = True
        '    Top_5_Random_1_Bowl_TextBox.Visible = False
        '    Top_5_Random_2_Bowl_TextBox.Visible = False
        '    Top_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_5_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_5_1_Selection = Top_5_Random_1_TextBox.Text
        '    GlobalVariables.Top_5_2_Selection = Top_5_Random_2_TextBox.Text
        '    GlobalVariables.Top_5_1_Bowl_Selection = Top_5_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_5_2_Bowl_Selection = Top_5_Random_2_Bowl_TextBox.Text

        '    Top_5_Number_TextBox.Visible = False
        '    Top_5_Random_1_TextBox.Visible = True
        '    Top_5_Random_2_TextBox.Visible = True
        '    Top_5_Chart_TextBox.Visible = False

        '    Top_5_Number_Bowl_TextBox.Visible = False
        '    Top_5_Random_1_Bowl_TextBox.Visible = True
        '    Top_5_Random_2_Bowl_TextBox.Visible = True
        '    Top_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_5_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_5_1_Selection = Top_5_Chart_TextBox.Text
        '    GlobalVariables.Top_5_2_Selection = "--"
        '    GlobalVariables.Top_5_1_Bowl_Selection = Top_5_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_5_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_5_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart5(Top_5_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_5_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_5_Number_TextBox.Visible = False
        '    Top_5_Random_1_TextBox.Visible = False
        '    Top_5_Random_2_TextBox.Visible = False
        '    Top_5_Chart_TextBox.Visible = True

        '    Top_5_Number_Bowl_TextBox.Visible = False
        '    Top_5_Random_1_Bowl_TextBox.Visible = False
        '    Top_5_Random_2_Bowl_TextBox.Visible = False
        '    Top_5_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_5_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_5_1_Selection = "--"
        '    GlobalVariables.Top_5_2_Selection = "--"
        '    GlobalVariables.Top_5_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_5_2_Bowl_Selection = "--"

        '    Top_5_Number_TextBox.Visible = False
        '    Top_5_Random_1_TextBox.Visible = False
        '    Top_5_Random_2_TextBox.Visible = False
        '    Top_5_Chart_TextBox.Visible = False

        '    Top_5_Number_Bowl_TextBox.Visible = False
        '    Top_5_Random_1_Bowl_TextBox.Visible = False
        '    Top_5_Random_2_Bowl_TextBox.Visible = False
        '    Top_5_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 6
        'If Top_6_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_6_1_Selection = Top_6_Number_TextBox.Text
        '    GlobalVariables.Top_6_2_Selection = "--"
        '    GlobalVariables.Top_6_1_Bowl_Selection = Top_6_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_6_2_Bowl_Selection = "--"

        '    Top_6_Number_TextBox.Visible = True
        '    Top_6_Random_1_TextBox.Visible = False
        '    Top_6_Random_2_TextBox.Visible = False
        '    Top_6_Chart_TextBox.Visible = False

        '    Top_6_Number_Bowl_TextBox.Visible = True
        '    Top_6_Random_1_Bowl_TextBox.Visible = False
        '    Top_6_Random_2_Bowl_TextBox.Visible = False
        '    Top_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_6_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_6_1_Selection = Top_6_Random_1_TextBox.Text
        '    GlobalVariables.Top_6_2_Selection = Top_6_Random_2_TextBox.Text
        '    GlobalVariables.Top_6_1_Bowl_Selection = Top_6_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_6_2_Bowl_Selection = Top_6_Random_2_Bowl_TextBox.Text

        '    Top_6_Number_TextBox.Visible = False
        '    Top_6_Random_1_TextBox.Visible = True
        '    Top_6_Random_2_TextBox.Visible = True
        '    Top_6_Chart_TextBox.Visible = False

        '    Top_6_Number_Bowl_TextBox.Visible = False
        '    Top_6_Random_1_Bowl_TextBox.Visible = True
        '    Top_6_Random_2_Bowl_TextBox.Visible = True
        '    Top_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_6_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_6_1_Selection = Top_6_Chart_TextBox.Text
        '    GlobalVariables.Top_6_2_Selection = "--"
        '    GlobalVariables.Top_6_1_Bowl_Selection = Top_6_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_6_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_6_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart6(Top_6_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_6_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_6_Number_TextBox.Visible = False
        '    Top_6_Random_1_TextBox.Visible = False
        '    Top_6_Random_2_TextBox.Visible = False
        '    Top_6_Chart_TextBox.Visible = True

        '    Top_6_Number_Bowl_TextBox.Visible = False
        '    Top_6_Random_1_Bowl_TextBox.Visible = False
        '    Top_6_Random_2_Bowl_TextBox.Visible = False
        '    Top_6_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_6_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_6_1_Selection = "--"
        '    GlobalVariables.Top_6_2_Selection = "--"
        '    GlobalVariables.Top_6_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_6_2_Bowl_Selection = "--"

        '    Top_6_Number_TextBox.Visible = False
        '    Top_6_Random_1_TextBox.Visible = False
        '    Top_6_Random_2_TextBox.Visible = False
        '    Top_6_Chart_TextBox.Visible = False

        '    Top_6_Number_Bowl_TextBox.Visible = False
        '    Top_6_Random_1_Bowl_TextBox.Visible = False
        '    Top_6_Random_2_Bowl_TextBox.Visible = False
        '    Top_6_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 7
        'If Top_7_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_7_1_Selection = Top_7_Number_TextBox.Text
        '    GlobalVariables.Top_7_2_Selection = "--"
        '    GlobalVariables.Top_7_1_Bowl_Selection = Top_7_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_7_2_Bowl_Selection = "--"

        '    Top_7_Number_TextBox.Visible = True
        '    Top_7_Random_1_TextBox.Visible = False
        '    Top_7_Random_2_TextBox.Visible = False
        '    Top_7_Chart_TextBox.Visible = False

        '    Top_7_Number_Bowl_TextBox.Visible = True
        '    Top_7_Random_1_Bowl_TextBox.Visible = False
        '    Top_7_Random_2_Bowl_TextBox.Visible = False
        '    Top_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_7_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_7_1_Selection = Top_7_Random_1_TextBox.Text
        '    GlobalVariables.Top_7_2_Selection = Top_7_Random_2_TextBox.Text
        '    GlobalVariables.Top_7_1_Bowl_Selection = Top_7_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_7_2_Bowl_Selection = Top_7_Random_2_Bowl_TextBox.Text

        '    Top_7_Number_TextBox.Visible = False
        '    Top_7_Random_1_TextBox.Visible = True
        '    Top_7_Random_2_TextBox.Visible = True
        '    Top_7_Chart_TextBox.Visible = False

        '    Top_7_Number_Bowl_TextBox.Visible = False
        '    Top_7_Random_1_Bowl_TextBox.Visible = True
        '    Top_7_Random_2_Bowl_TextBox.Visible = True
        '    Top_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_7_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_7_1_Selection = Top_7_Chart_TextBox.Text
        '    GlobalVariables.Top_7_2_Selection = "--"
        '    GlobalVariables.Top_7_1_Bowl_Selection = Top_7_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_7_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Top_7_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart7(Top_7_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_7_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_7_Number_TextBox.Visible = False
        '    Top_7_Random_1_TextBox.Visible = False
        '    Top_7_Random_2_TextBox.Visible = False
        '    Top_7_Chart_TextBox.Visible = True

        '    Top_7_Number_Bowl_TextBox.Visible = False
        '    Top_7_Random_1_Bowl_TextBox.Visible = False
        '    Top_7_Random_2_Bowl_TextBox.Visible = False
        '    Top_7_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_7_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_7_1_Selection = "--"
        '    GlobalVariables.Top_7_2_Selection = "--"
        '    GlobalVariables.Top_7_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_7_2_Bowl_Selection = "--"

        '    Top_7_Number_TextBox.Visible = False
        '    Top_7_Random_1_TextBox.Visible = False
        '    Top_7_Random_2_TextBox.Visible = False
        '    Top_7_Chart_TextBox.Visible = False

        '    Top_7_Number_Bowl_TextBox.Visible = False
        '    Top_7_Random_1_Bowl_TextBox.Visible = False
        '    Top_7_Random_2_Bowl_TextBox.Visible = False
        '    Top_7_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Top 7
        'If Top_8_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Top_8_1_Selection = Top_8_Number_TextBox.Text
        '    GlobalVariables.Top_8_2_Selection = "--"
        '    GlobalVariables.Top_8_1_Bowl_Selection = Top_8_Number_Bowl_TextBox.Text
        '    GlobalVariables.Top_8_2_Bowl_Selection = "--"

        '    Top_8_Number_TextBox.Visible = True
        '    Top_8_Random_1_TextBox.Visible = False
        '    Top_8_Random_2_TextBox.Visible = False
        '    Top_8_Chart_TextBox.Visible = False

        '    Top_8_Number_Bowl_TextBox.Visible = True
        '    Top_8_Random_1_Bowl_TextBox.Visible = False
        '    Top_8_Random_2_Bowl_TextBox.Visible = False
        '    Top_8_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_8_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Top_8_1_Selection = Top_8_Random_1_TextBox.Text
        '    GlobalVariables.Top_8_2_Selection = Top_8_Random_2_TextBox.Text
        '    GlobalVariables.Top_8_1_Bowl_Selection = Top_8_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Top_8_2_Bowl_Selection = Top_8_Random_2_Bowl_TextBox.Text

        '    Top_8_Number_TextBox.Visible = False
        '    Top_8_Random_1_TextBox.Visible = True
        '    Top_8_Random_2_TextBox.Visible = True
        '    Top_8_Chart_TextBox.Visible = False

        '    Top_8_Number_Bowl_TextBox.Visible = False
        '    Top_8_Random_1_Bowl_TextBox.Visible = True
        '    Top_8_Random_2_Bowl_TextBox.Visible = True
        '    Top_8_Chart_Bowl_TextBox.Visible = False

        'ElseIf Top_8_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Top_8_1_Selection = Top_8_Chart_TextBox.Text
        '    GlobalVariables.Top_8_2_Selection = "--"
        '    GlobalVariables.Top_8_1_Bowl_Selection = Top_8_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Top_8_2_Bowl_Selection = "--"

        '    Top_8_Number_TextBox.Visible = False
        '    Top_8_Random_1_TextBox.Visible = False
        '    Top_8_Random_2_TextBox.Visible = False
        '    Top_8_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Top_8_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart8(Top_8_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Top_8_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Top_8_Number_Bowl_TextBox.Visible = False
        '    Top_8_Random_1_Bowl_TextBox.Visible = False
        '    Top_8_Random_2_Bowl_TextBox.Visible = False
        '    Top_8_Chart_Bowl_TextBox.Visible = True

        'ElseIf Top_8_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Top_8_1_Selection = "--"
        '    GlobalVariables.Top_8_2_Selection = "--"
        '    GlobalVariables.Top_8_1_Bowl_Selection = "--"
        '    GlobalVariables.Top_8_2_Bowl_Selection = "--"

        '    Top_8_Number_TextBox.Visible = False
        '    Top_8_Random_1_TextBox.Visible = False
        '    Top_8_Random_2_TextBox.Visible = False
        '    Top_8_Chart_TextBox.Visible = False

        '    Top_8_Number_Bowl_TextBox.Visible = False
        '    Top_8_Random_1_Bowl_TextBox.Visible = False
        '    Top_8_Random_2_Bowl_TextBox.Visible = False
        '    Top_8_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 1
        'If Mid_1_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_1_1_Selection = Mid_1_Number_TextBox.Text
        '    GlobalVariables.Mid_1_2_Selection = "--"
        '    GlobalVariables.Mid_1_1_Bowl_Selection = Mid_1_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_1_2_Bowl_Selection = "--"

        '    Mid_1_Number_TextBox.Visible = True
        '    Mid_1_Random_1_TextBox.Visible = False
        '    Mid_1_Random_2_TextBox.Visible = False
        '    Mid_1_Chart_TextBox.Visible = False

        '    Mid_1_Number_Bowl_TextBox.Visible = True
        '    Mid_1_Random_1_Bowl_TextBox.Visible = False
        '    Mid_1_Random_2_Bowl_TextBox.Visible = False
        '    Mid_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_1_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_1_1_Selection = Mid_1_Random_1_TextBox.Text
        '    GlobalVariables.Mid_1_2_Selection = Mid_1_Random_2_TextBox.Text
        '    GlobalVariables.Mid_1_1_Bowl_Selection = Mid_1_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_1_2_Bowl_Selection = Mid_1_Random_2_Bowl_TextBox.Text

        '    Mid_1_Number_TextBox.Visible = False
        '    Mid_1_Random_1_TextBox.Visible = True
        '    Mid_1_Random_2_TextBox.Visible = True
        '    Mid_1_Chart_TextBox.Visible = False

        '    Mid_1_Number_Bowl_TextBox.Visible = False
        '    Mid_1_Random_1_Bowl_TextBox.Visible = True
        '    Mid_1_Random_2_Bowl_TextBox.Visible = True
        '    Mid_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_1_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_1_1_Selection = Mid_1_Chart_TextBox.Text
        '    GlobalVariables.Mid_1_2_Selection = "--"
        '    GlobalVariables.Mid_1_1_Bowl_Selection = Mid_1_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_1_2_Bowl_Selection = "--"

        '    Mid_1_Number_TextBox.Visible = False
        '    Mid_1_Random_1_TextBox.Visible = False
        '    Mid_1_Random_2_TextBox.Visible = False
        '    Mid_1_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Mid_1_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart1(Mid_1_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_1_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_1_Number_Bowl_TextBox.Visible = False
        '    Mid_1_Random_1_Bowl_TextBox.Visible = False
        '    Mid_1_Random_2_Bowl_TextBox.Visible = False
        '    Mid_1_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_1_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_1_1_Selection = "--"
        '    GlobalVariables.Mid_1_2_Selection = "--"
        '    GlobalVariables.Mid_1_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_1_2_Bowl_Selection = "--"

        '    Mid_1_Number_TextBox.Visible = False
        '    Mid_1_Random_1_TextBox.Visible = False
        '    Mid_1_Random_2_TextBox.Visible = False
        '    Mid_1_Chart_TextBox.Visible = False

        '    Mid_1_Number_Bowl_TextBox.Visible = False
        '    Mid_1_Random_1_Bowl_TextBox.Visible = False
        '    Mid_1_Random_2_Bowl_TextBox.Visible = False
        '    Mid_1_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 2
        'If Mid_2_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_2_1_Selection = Mid_2_Number_TextBox.Text
        '    GlobalVariables.Mid_2_2_Selection = "--"
        '    GlobalVariables.Mid_2_1_Bowl_Selection = Mid_2_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_2_2_Bowl_Selection = "--"

        '    Mid_2_Number_TextBox.Visible = True
        '    Mid_2_Random_1_TextBox.Visible = False
        '    Mid_2_Random_2_TextBox.Visible = False
        '    Mid_2_Chart_TextBox.Visible = False

        '    Mid_2_Number_Bowl_TextBox.Visible = True
        '    Mid_2_Random_1_Bowl_TextBox.Visible = False
        '    Mid_2_Random_2_Bowl_TextBox.Visible = False
        '    Mid_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_2_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_2_1_Selection = Mid_2_Random_1_TextBox.Text
        '    GlobalVariables.Mid_2_2_Selection = Mid_2_Random_2_TextBox.Text
        '    GlobalVariables.Mid_2_1_Bowl_Selection = Mid_2_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_2_2_Bowl_Selection = Mid_2_Random_2_Bowl_TextBox.Text

        '    Mid_2_Number_TextBox.Visible = False
        '    Mid_2_Random_1_TextBox.Visible = True
        '    Mid_2_Random_2_TextBox.Visible = True
        '    Mid_2_Chart_TextBox.Visible = False

        '    Mid_2_Number_Bowl_TextBox.Visible = False
        '    Mid_2_Random_1_Bowl_TextBox.Visible = True
        '    Mid_2_Random_2_Bowl_TextBox.Visible = True
        '    Mid_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_2_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_2_1_Selection = Mid_2_Chart_TextBox.Text
        '    GlobalVariables.Mid_2_2_Selection = "--"
        '    GlobalVariables.Mid_2_1_Bowl_Selection = Mid_2_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_2_2_Bowl_Selection = "--"

        '    Mid_2_Number_TextBox.Visible = False
        '    Mid_2_Random_1_TextBox.Visible = False
        '    Mid_2_Random_2_TextBox.Visible = False
        '    Mid_2_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Mid_2_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart2(Mid_2_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_2_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_2_Number_Bowl_TextBox.Visible = False
        '    Mid_2_Random_1_Bowl_TextBox.Visible = False
        '    Mid_2_Random_2_Bowl_TextBox.Visible = False
        '    Mid_2_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_2_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_2_1_Selection = "--"
        '    GlobalVariables.Mid_2_2_Selection = "--"
        '    GlobalVariables.Mid_2_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_2_2_Bowl_Selection = "--"

        '    Mid_2_Number_TextBox.Visible = False
        '    Mid_2_Random_1_TextBox.Visible = False
        '    Mid_2_Random_2_TextBox.Visible = False
        '    Mid_2_Chart_TextBox.Visible = False

        '    Mid_2_Number_Bowl_TextBox.Visible = False
        '    Mid_2_Random_1_Bowl_TextBox.Visible = False
        '    Mid_2_Random_2_Bowl_TextBox.Visible = False
        '    Mid_2_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 3
        'If Mid_3_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_3_1_Selection = Mid_3_Number_TextBox.Text
        '    GlobalVariables.Mid_3_2_Selection = "--"
        '    GlobalVariables.Mid_3_1_Bowl_Selection = Mid_3_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_3_2_Bowl_Selection = "--"

        '    Mid_3_Number_TextBox.Visible = True
        '    Mid_3_Random_1_TextBox.Visible = False
        '    Mid_3_Random_2_TextBox.Visible = False
        '    Mid_3_Chart_TextBox.Visible = False

        '    Mid_3_Number_Bowl_TextBox.Visible = True
        '    Mid_3_Random_1_Bowl_TextBox.Visible = False
        '    Mid_3_Random_2_Bowl_TextBox.Visible = False
        '    Mid_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_3_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_3_1_Selection = Mid_3_Random_1_TextBox.Text
        '    GlobalVariables.Mid_3_2_Selection = Mid_3_Random_2_TextBox.Text
        '    GlobalVariables.Mid_3_1_Bowl_Selection = Mid_3_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_3_2_Bowl_Selection = Mid_3_Random_2_Bowl_TextBox.Text

        '    Mid_3_Number_TextBox.Visible = False
        '    Mid_3_Random_1_TextBox.Visible = True
        '    Mid_3_Random_2_TextBox.Visible = True
        '    Mid_3_Chart_TextBox.Visible = False

        '    Mid_3_Number_Bowl_TextBox.Visible = False
        '    Mid_3_Random_1_Bowl_TextBox.Visible = True
        '    Mid_3_Random_2_Bowl_TextBox.Visible = True
        '    Mid_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_3_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_3_1_Selection = Mid_3_Chart_TextBox.Text
        '    GlobalVariables.Mid_3_2_Selection = "--"
        '    GlobalVariables.Mid_3_1_Bowl_Selection = Mid_3_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_3_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Mid_3_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart3(Mid_3_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_3_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_3_Number_TextBox.Visible = False
        '    Mid_3_Random_1_TextBox.Visible = False
        '    Mid_3_Random_2_TextBox.Visible = False
        '    Mid_3_Chart_TextBox.Visible = True

        '    Mid_3_Number_Bowl_TextBox.Visible = False
        '    Mid_3_Random_1_Bowl_TextBox.Visible = False
        '    Mid_3_Random_2_Bowl_TextBox.Visible = False
        '    Mid_3_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_3_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_3_1_Selection = "--"
        '    GlobalVariables.Mid_3_2_Selection = "--"
        '    GlobalVariables.Mid_3_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_3_2_Bowl_Selection = "--"

        '    Mid_3_Number_TextBox.Visible = False
        '    Mid_3_Random_1_TextBox.Visible = False
        '    Mid_3_Random_2_TextBox.Visible = False
        '    Mid_3_Chart_TextBox.Visible = False

        '    Mid_3_Number_Bowl_TextBox.Visible = False
        '    Mid_3_Random_1_Bowl_TextBox.Visible = False
        '    Mid_3_Random_2_Bowl_TextBox.Visible = False
        '    Mid_3_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 4
        'If Mid_4_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_4_1_Selection = Mid_4_Number_TextBox.Text
        '    GlobalVariables.Mid_4_2_Selection = "--"
        '    GlobalVariables.Mid_4_1_Bowl_Selection = Mid_4_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_4_2_Bowl_Selection = "--"

        '    Mid_4_Number_TextBox.Visible = True
        '    Mid_4_Random_1_TextBox.Visible = False
        '    Mid_4_Random_2_TextBox.Visible = False
        '    Mid_4_Chart_TextBox.Visible = False

        '    Mid_4_Number_Bowl_TextBox.Visible = True
        '    Mid_4_Random_1_Bowl_TextBox.Visible = False
        '    Mid_4_Random_2_Bowl_TextBox.Visible = False
        '    Mid_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_4_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_4_1_Selection = Mid_4_Random_1_TextBox.Text
        '    GlobalVariables.Mid_4_2_Selection = Mid_4_Random_2_TextBox.Text
        '    GlobalVariables.Mid_4_1_Bowl_Selection = Mid_4_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_4_2_Bowl_Selection = Mid_4_Random_2_Bowl_TextBox.Text

        '    Mid_4_Number_TextBox.Visible = False
        '    Mid_4_Random_1_TextBox.Visible = True
        '    Mid_4_Random_2_TextBox.Visible = True
        '    Mid_4_Chart_TextBox.Visible = False

        '    Mid_4_Number_Bowl_TextBox.Visible = False
        '    Mid_4_Random_1_Bowl_TextBox.Visible = True
        '    Mid_4_Random_2_Bowl_TextBox.Visible = True
        '    Mid_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_4_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_4_1_Selection = Mid_4_Chart_TextBox.Text
        '    GlobalVariables.Mid_4_2_Selection = "--"
        '    GlobalVariables.Mid_4_1_Bowl_Selection = Mid_4_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_4_2_Bowl_Selection = "--"

        '    Mid_4_Number_TextBox.Visible = False
        '    Mid_4_Random_1_TextBox.Visible = False
        '    Mid_4_Random_2_TextBox.Visible = False
        '    Mid_4_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Mid_4_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart4(Mid_4_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_4_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_4_Number_Bowl_TextBox.Visible = False
        '    Mid_4_Random_1_Bowl_TextBox.Visible = False
        '    Mid_4_Random_2_Bowl_TextBox.Visible = False
        '    Mid_4_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_4_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_4_1_Selection = "--"
        '    GlobalVariables.Mid_4_2_Selection = "--"
        '    GlobalVariables.Mid_4_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_4_2_Bowl_Selection = "--"

        '    Mid_4_Number_TextBox.Visible = False
        '    Mid_4_Random_1_TextBox.Visible = False
        '    Mid_4_Random_2_TextBox.Visible = False
        '    Mid_4_Chart_TextBox.Visible = False

        '    Mid_4_Number_Bowl_TextBox.Visible = False
        '    Mid_4_Random_1_Bowl_TextBox.Visible = False
        '    Mid_4_Random_2_Bowl_TextBox.Visible = False
        '    Mid_4_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 5
        'If Mid_5_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_5_1_Selection = Mid_5_Number_TextBox.Text
        '    GlobalVariables.Mid_5_2_Selection = "--"
        '    GlobalVariables.Mid_5_1_Bowl_Selection = Mid_5_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_5_2_Bowl_Selection = "--"

        '    Mid_5_Number_TextBox.Visible = True
        '    Mid_5_Random_1_TextBox.Visible = False
        '    Mid_5_Random_2_TextBox.Visible = False
        '    Mid_5_Chart_TextBox.Visible = False

        '    Mid_5_Number_Bowl_TextBox.Visible = True
        '    Mid_5_Random_1_Bowl_TextBox.Visible = False
        '    Mid_5_Random_2_Bowl_TextBox.Visible = False
        '    Mid_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_5_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_5_1_Selection = Mid_5_Random_1_TextBox.Text
        '    GlobalVariables.Mid_5_2_Selection = Mid_5_Random_2_TextBox.Text
        '    GlobalVariables.Mid_5_1_Bowl_Selection = Mid_5_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_5_2_Bowl_Selection = Mid_5_Random_2_Bowl_TextBox.Text

        '    Mid_5_Number_TextBox.Visible = False
        '    Mid_5_Random_1_TextBox.Visible = True
        '    Mid_5_Random_2_TextBox.Visible = True
        '    Mid_5_Chart_TextBox.Visible = False

        '    Mid_5_Number_Bowl_TextBox.Visible = False
        '    Mid_5_Random_1_Bowl_TextBox.Visible = True
        '    Mid_5_Random_2_Bowl_TextBox.Visible = True
        '    Mid_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_5_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_5_1_Selection = Mid_5_Chart_TextBox.Text
        '    GlobalVariables.Mid_5_2_Selection = "--"
        '    GlobalVariables.Mid_5_1_Bowl_Selection = Mid_5_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_5_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Mid_5_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart5(Mid_5_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_5_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_5_Number_TextBox.Visible = False
        '    Mid_5_Random_1_TextBox.Visible = False
        '    Mid_5_Random_2_TextBox.Visible = False
        '    Mid_5_Chart_TextBox.Visible = True

        '    Mid_5_Number_Bowl_TextBox.Visible = False
        '    Mid_5_Random_1_Bowl_TextBox.Visible = False
        '    Mid_5_Random_2_Bowl_TextBox.Visible = False
        '    Mid_5_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_5_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_5_1_Selection = "--"
        '    GlobalVariables.Mid_5_2_Selection = "--"
        '    GlobalVariables.Mid_5_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_5_2_Bowl_Selection = "--"

        '    Mid_5_Number_TextBox.Visible = False
        '    Mid_5_Random_1_TextBox.Visible = False
        '    Mid_5_Random_2_TextBox.Visible = False
        '    Mid_5_Chart_TextBox.Visible = False

        '    Mid_5_Number_Bowl_TextBox.Visible = False
        '    Mid_5_Random_1_Bowl_TextBox.Visible = False
        '    Mid_5_Random_2_Bowl_TextBox.Visible = False
        '    Mid_5_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 6
        'If Mid_6_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_6_1_Selection = Mid_6_Number_TextBox.Text
        '    GlobalVariables.Mid_6_2_Selection = "--"
        '    GlobalVariables.Mid_6_1_Bowl_Selection = Mid_6_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_6_2_Bowl_Selection = "--"

        '    Mid_6_Number_TextBox.Visible = True
        '    Mid_6_Random_1_TextBox.Visible = False
        '    Mid_6_Random_2_TextBox.Visible = False
        '    Mid_6_Chart_TextBox.Visible = False

        '    Mid_6_Number_Bowl_TextBox.Visible = True
        '    Mid_6_Random_1_Bowl_TextBox.Visible = False
        '    Mid_6_Random_2_Bowl_TextBox.Visible = False
        '    Mid_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_6_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_6_1_Selection = Mid_6_Random_1_TextBox.Text
        '    GlobalVariables.Mid_6_2_Selection = Mid_6_Random_2_TextBox.Text
        '    GlobalVariables.Mid_6_1_Bowl_Selection = Mid_6_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_6_2_Bowl_Selection = Mid_6_Random_2_Bowl_TextBox.Text

        '    Mid_6_Number_TextBox.Visible = False
        '    Mid_6_Random_1_TextBox.Visible = True
        '    Mid_6_Random_2_TextBox.Visible = True
        '    Mid_6_Chart_TextBox.Visible = False

        '    Mid_6_Number_Bowl_TextBox.Visible = False
        '    Mid_6_Random_1_Bowl_TextBox.Visible = True
        '    Mid_6_Random_2_Bowl_TextBox.Visible = True
        '    Mid_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_6_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_6_1_Selection = Mid_6_Chart_TextBox.Text
        '    GlobalVariables.Mid_6_2_Selection = "--"
        '    GlobalVariables.Mid_6_1_Bowl_Selection = Mid_6_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_6_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Mid_6_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart6(Mid_6_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_6_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_6_Number_TextBox.Visible = False
        '    Mid_6_Random_1_TextBox.Visible = False
        '    Mid_6_Random_2_TextBox.Visible = False
        '    Mid_6_Chart_TextBox.Visible = True

        '    Mid_6_Number_Bowl_TextBox.Visible = False
        '    Mid_6_Random_1_Bowl_TextBox.Visible = False
        '    Mid_6_Random_2_Bowl_TextBox.Visible = False
        '    Mid_6_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_6_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_6_1_Selection = "--"
        '    GlobalVariables.Mid_6_2_Selection = "--"
        '    GlobalVariables.Mid_6_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_6_2_Bowl_Selection = "--"

        '    Mid_6_Number_TextBox.Visible = False
        '    Mid_6_Random_1_TextBox.Visible = False
        '    Mid_6_Random_2_TextBox.Visible = False
        '    Mid_6_Chart_TextBox.Visible = False

        '    Mid_6_Number_Bowl_TextBox.Visible = False
        '    Mid_6_Random_1_Bowl_TextBox.Visible = False
        '    Mid_6_Random_2_Bowl_TextBox.Visible = False
        '    Mid_6_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Mid 7
        'If Mid_7_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Mid_7_1_Selection = Mid_7_Number_TextBox.Text
        '    GlobalVariables.Mid_7_2_Selection = "--"
        '    GlobalVariables.Mid_7_1_Bowl_Selection = Mid_7_Number_Bowl_TextBox.Text
        '    GlobalVariables.Mid_7_2_Bowl_Selection = "--"

        '    Mid_7_Number_TextBox.Visible = True
        '    Mid_7_Random_1_TextBox.Visible = False
        '    Mid_7_Random_2_TextBox.Visible = False
        '    Mid_7_Chart_TextBox.Visible = False

        '    Mid_7_Number_Bowl_TextBox.Visible = True
        '    Mid_7_Random_1_Bowl_TextBox.Visible = False
        '    Mid_7_Random_2_Bowl_TextBox.Visible = False
        '    Mid_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_7_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Mid_7_1_Selection = Mid_7_Random_1_TextBox.Text
        '    GlobalVariables.Mid_7_2_Selection = Mid_7_Random_2_TextBox.Text
        '    GlobalVariables.Mid_7_1_Bowl_Selection = Mid_7_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Mid_7_2_Bowl_Selection = Mid_7_Random_2_Bowl_TextBox.Text

        '    Mid_7_Number_TextBox.Visible = False
        '    Mid_7_Random_1_TextBox.Visible = True
        '    Mid_7_Random_2_TextBox.Visible = True
        '    Mid_7_Chart_TextBox.Visible = False

        '    Mid_7_Number_Bowl_TextBox.Visible = False
        '    Mid_7_Random_1_Bowl_TextBox.Visible = True
        '    Mid_7_Random_2_Bowl_TextBox.Visible = True
        '    Mid_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Mid_7_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Mid_7_1_Selection = Mid_7_Chart_TextBox.Text
        '    GlobalVariables.Mid_7_2_Selection = "--"
        '    GlobalVariables.Mid_7_1_Bowl_Selection = Mid_7_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Mid_7_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Mid_7_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart7(Mid_7_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Mid_7_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Mid_7_Number_TextBox.Visible = False
        '    Mid_7_Random_1_TextBox.Visible = False
        '    Mid_7_Random_2_TextBox.Visible = False
        '    Mid_7_Chart_TextBox.Visible = True

        '    Mid_7_Number_Bowl_TextBox.Visible = False
        '    Mid_7_Random_1_Bowl_TextBox.Visible = False
        '    Mid_7_Random_2_Bowl_TextBox.Visible = False
        '    Mid_7_Chart_Bowl_TextBox.Visible = True

        'ElseIf Mid_7_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Mid_7_1_Selection = "--"
        '    GlobalVariables.Mid_7_2_Selection = "--"
        '    GlobalVariables.Mid_7_1_Bowl_Selection = "--"
        '    GlobalVariables.Mid_7_2_Bowl_Selection = "--"

        '    Mid_7_Number_TextBox.Visible = False
        '    Mid_7_Random_1_TextBox.Visible = False
        '    Mid_7_Random_2_TextBox.Visible = False
        '    Mid_7_Chart_TextBox.Visible = False

        '    Mid_7_Number_Bowl_TextBox.Visible = False
        '    Mid_7_Random_1_Bowl_TextBox.Visible = False
        '    Mid_7_Random_2_Bowl_TextBox.Visible = False
        '    Mid_7_Chart_Bowl_TextBox.Visible = False

        'End If


        '' Bot 1
        'If Bot_1_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_1_1_Selection = Bot_1_Number_TextBox.Text
        '    GlobalVariables.Bot_1_2_Selection = "--"
        '    GlobalVariables.Bot_1_1_Bowl_Selection = Bot_1_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_1_2_Bowl_Selection = "--"

        '    Bot_1_Number_TextBox.Visible = True
        '    Bot_1_Random_1_TextBox.Visible = False
        '    Bot_1_Random_2_TextBox.Visible = False
        '    Bot_1_Chart_TextBox.Visible = False

        '    Bot_1_Number_Bowl_TextBox.Visible = True
        '    Bot_1_Random_1_Bowl_TextBox.Visible = False
        '    Bot_1_Random_2_Bowl_TextBox.Visible = False
        '    Bot_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_1_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_1_1_Selection = Bot_1_Random_1_TextBox.Text
        '    GlobalVariables.Bot_1_2_Selection = Bot_1_Random_2_TextBox.Text
        '    GlobalVariables.Bot_1_1_Bowl_Selection = Bot_1_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_1_2_Bowl_Selection = Bot_1_Random_2_Bowl_TextBox.Text

        '    Bot_1_Number_TextBox.Visible = False
        '    Bot_1_Random_1_TextBox.Visible = True
        '    Bot_1_Random_2_TextBox.Visible = True
        '    Bot_1_Chart_TextBox.Visible = False

        '    Bot_1_Number_Bowl_TextBox.Visible = False
        '    Bot_1_Random_1_Bowl_TextBox.Visible = True
        '    Bot_1_Random_2_Bowl_TextBox.Visible = True
        '    Bot_1_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_1_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_1_1_Selection = Bot_1_Chart_TextBox.Text
        '    GlobalVariables.Bot_1_2_Selection = "--"
        '    GlobalVariables.Bot_1_1_Bowl_Selection = Bot_1_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_1_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Bot_1_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart1(Bot_1_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_1_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_1_Number_TextBox.Visible = False
        '    Bot_1_Random_1_TextBox.Visible = False
        '    Bot_1_Random_2_TextBox.Visible = False
        '    Bot_1_Chart_TextBox.Visible = True

        '    Bot_1_Number_Bowl_TextBox.Visible = False
        '    Bot_1_Random_1_Bowl_TextBox.Visible = False
        '    Bot_1_Random_2_Bowl_TextBox.Visible = False
        '    Bot_1_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_1_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_1_1_Selection = "--"
        '    GlobalVariables.Bot_1_2_Selection = "--"
        '    GlobalVariables.Bot_1_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_1_2_Bowl_Selection = "--"

        '    Bot_1_Number_TextBox.Visible = False
        '    Bot_1_Random_1_TextBox.Visible = False
        '    Bot_1_Random_2_TextBox.Visible = False
        '    Bot_1_Chart_TextBox.Visible = False

        '    Bot_1_Number_Bowl_TextBox.Visible = False
        '    Bot_1_Random_1_Bowl_TextBox.Visible = False
        '    Bot_1_Random_2_Bowl_TextBox.Visible = False
        '    Bot_1_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Bot 2
        'If Bot_2_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_2_1_Selection = Bot_2_Number_TextBox.Text
        '    GlobalVariables.Bot_2_2_Selection = "--"
        '    GlobalVariables.Bot_2_1_Bowl_Selection = Bot_2_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_2_2_Bowl_Selection = "--"

        '    Bot_2_Number_TextBox.Visible = True
        '    Bot_2_Random_1_TextBox.Visible = False
        '    Bot_2_Random_2_TextBox.Visible = False
        '    Bot_2_Chart_TextBox.Visible = False

        '    Bot_2_Number_Bowl_TextBox.Visible = True
        '    Bot_2_Random_1_Bowl_TextBox.Visible = False
        '    Bot_2_Random_2_Bowl_TextBox.Visible = False
        '    Bot_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_2_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_2_1_Selection = Bot_2_Random_1_TextBox.Text
        '    GlobalVariables.Bot_2_2_Selection = Bot_2_Random_2_TextBox.Text
        '    GlobalVariables.Bot_2_1_Bowl_Selection = Bot_2_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_2_2_Bowl_Selection = Bot_2_Random_2_Bowl_TextBox.Text

        '    Bot_2_Number_TextBox.Visible = False
        '    Bot_2_Random_1_TextBox.Visible = True
        '    Bot_2_Random_2_TextBox.Visible = True
        '    Bot_2_Chart_TextBox.Visible = False

        '    Bot_2_Number_Bowl_TextBox.Visible = False
        '    Bot_2_Random_1_Bowl_TextBox.Visible = True
        '    Bot_2_Random_2_Bowl_TextBox.Visible = True
        '    Bot_2_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_2_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_2_1_Selection = Bot_2_Chart_TextBox.Text
        '    GlobalVariables.Bot_2_2_Selection = "--"
        '    GlobalVariables.Bot_2_1_Bowl_Selection = Bot_2_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_2_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Bot_2_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart2(Bot_2_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_2_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_2_Number_TextBox.Visible = False
        '    Bot_2_Random_1_TextBox.Visible = False
        '    Bot_2_Random_2_TextBox.Visible = False
        '    Bot_2_Chart_TextBox.Visible = True

        '    Bot_2_Number_Bowl_TextBox.Visible = False
        '    Bot_2_Random_1_Bowl_TextBox.Visible = False
        '    Bot_2_Random_2_Bowl_TextBox.Visible = False
        '    Bot_2_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_2_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_2_1_Selection = "--"
        '    GlobalVariables.Bot_2_2_Selection = "--"
        '    GlobalVariables.Bot_2_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_2_2_Bowl_Selection = "--"

        '    Bot_2_Number_TextBox.Visible = False
        '    Bot_2_Random_1_TextBox.Visible = False
        '    Bot_2_Random_2_TextBox.Visible = False
        '    Bot_2_Chart_TextBox.Visible = False

        '    Bot_2_Number_Bowl_TextBox.Visible = False
        '    Bot_2_Random_1_Bowl_TextBox.Visible = False
        '    Bot_2_Random_2_Bowl_TextBox.Visible = False
        '    Bot_2_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Bot 3
        'If Bot_3_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_3_1_Selection = Bot_3_Number_TextBox.Text
        '    GlobalVariables.Bot_3_2_Selection = "--"
        '    GlobalVariables.Bot_3_1_Bowl_Selection = Bot_3_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_3_2_Bowl_Selection = "--"

        '    Bot_3_Number_TextBox.Visible = True
        '    Bot_3_Random_1_TextBox.Visible = False
        '    Bot_3_Random_2_TextBox.Visible = False
        '    Bot_3_Chart_TextBox.Visible = False

        '    Bot_3_Number_Bowl_TextBox.Visible = True
        '    Bot_3_Random_1_Bowl_TextBox.Visible = False
        '    Bot_3_Random_2_Bowl_TextBox.Visible = False
        '    Bot_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_3_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_3_1_Selection = Bot_3_Random_1_TextBox.Text
        '    GlobalVariables.Bot_3_2_Selection = Bot_3_Random_2_TextBox.Text
        '    GlobalVariables.Bot_3_1_Bowl_Selection = Bot_3_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_3_2_Bowl_Selection = Bot_3_Random_2_Bowl_TextBox.Text

        '    Bot_3_Number_TextBox.Visible = False
        '    Bot_3_Random_1_TextBox.Visible = True
        '    Bot_3_Random_2_TextBox.Visible = True
        '    Bot_3_Chart_TextBox.Visible = False

        '    Bot_3_Number_Bowl_TextBox.Visible = False
        '    Bot_3_Random_1_Bowl_TextBox.Visible = True
        '    Bot_3_Random_2_Bowl_TextBox.Visible = True
        '    Bot_3_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_3_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_3_1_Selection = Bot_3_Chart_TextBox.Text
        '    GlobalVariables.Bot_3_2_Selection = "--"
        '    GlobalVariables.Bot_3_1_Bowl_Selection = Bot_3_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_3_2_Bowl_Selection = "--"

        '    ' Look up Bowl location
        '    If Bot_3_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart3(Bot_3_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_3_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_3_Number_TextBox.Visible = False
        '    Bot_3_Random_1_TextBox.Visible = False
        '    Bot_3_Random_2_TextBox.Visible = False
        '    Bot_3_Chart_TextBox.Visible = True

        '    Bot_3_Number_Bowl_TextBox.Visible = False
        '    Bot_3_Random_1_Bowl_TextBox.Visible = False
        '    Bot_3_Random_2_Bowl_TextBox.Visible = False
        '    Bot_3_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_3_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_3_1_Selection = "--"
        '    GlobalVariables.Bot_3_2_Selection = "--"
        '    GlobalVariables.Bot_3_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_3_2_Bowl_Selection = "--"

        '    Bot_3_Number_TextBox.Visible = False
        '    Bot_3_Random_1_TextBox.Visible = False
        '    Bot_3_Random_2_TextBox.Visible = False
        '    Bot_3_Chart_TextBox.Visible = False

        '    Bot_3_Number_Bowl_TextBox.Visible = False
        '    Bot_3_Random_1_Bowl_TextBox.Visible = False
        '    Bot_3_Random_2_Bowl_TextBox.Visible = False
        '    Bot_3_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Bot 4
        'If Bot_4_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_4_1_Selection = Bot_4_Number_TextBox.Text
        '    GlobalVariables.Bot_4_2_Selection = "--"
        '    GlobalVariables.Bot_4_1_Bowl_Selection = Bot_4_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_4_2_Bowl_Selection = "--"

        '    Bot_4_Number_TextBox.Visible = True
        '    Bot_4_Random_1_TextBox.Visible = False
        '    Bot_4_Random_2_TextBox.Visible = False
        '    Bot_4_Chart_TextBox.Visible = False

        '    Bot_4_Number_Bowl_TextBox.Visible = True
        '    Bot_4_Random_1_Bowl_TextBox.Visible = False
        '    Bot_4_Random_2_Bowl_TextBox.Visible = False
        '    Bot_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_4_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_4_1_Selection = Bot_4_Random_1_TextBox.Text
        '    GlobalVariables.Bot_4_2_Selection = Bot_4_Random_2_TextBox.Text
        '    GlobalVariables.Bot_4_1_Bowl_Selection = Bot_4_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_4_2_Bowl_Selection = Bot_4_Random_2_Bowl_TextBox.Text

        '    Bot_4_Number_TextBox.Visible = False
        '    Bot_4_Random_1_TextBox.Visible = True
        '    Bot_4_Random_2_TextBox.Visible = True
        '    Bot_4_Chart_TextBox.Visible = False

        '    Bot_4_Number_Bowl_TextBox.Visible = False
        '    Bot_4_Random_1_Bowl_TextBox.Visible = True
        '    Bot_4_Random_2_Bowl_TextBox.Visible = True
        '    Bot_4_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_4_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_4_1_Selection = Bot_4_Chart_TextBox.Text
        '    GlobalVariables.Bot_4_2_Selection = "--"
        '    GlobalVariables.Bot_4_1_Bowl_Selection = Bot_4_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_4_2_Bowl_Selection = "--"

        '    Bot_4_Number_TextBox.Visible = False
        '    Bot_4_Random_1_TextBox.Visible = False
        '    Bot_4_Random_2_TextBox.Visible = False
        '    Bot_4_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Bot_4_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart4(Bot_4_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_4_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_4_Number_Bowl_TextBox.Visible = False
        '    Bot_4_Random_1_Bowl_TextBox.Visible = False
        '    Bot_4_Random_2_Bowl_TextBox.Visible = False
        '    Bot_4_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_4_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_4_1_Selection = "--"
        '    GlobalVariables.Bot_4_2_Selection = "--"
        '    GlobalVariables.Bot_4_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_4_2_Bowl_Selection = "--"

        '    Bot_4_Number_TextBox.Visible = False
        '    Bot_4_Random_1_TextBox.Visible = False
        '    Bot_4_Random_2_TextBox.Visible = False
        '    Bot_4_Chart_TextBox.Visible = False

        '    Bot_4_Number_Bowl_TextBox.Visible = False
        '    Bot_4_Random_1_Bowl_TextBox.Visible = False
        '    Bot_4_Random_2_Bowl_TextBox.Visible = False
        '    Bot_4_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Bot 5
        'If Bot_5_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_5_1_Selection = Bot_5_Number_TextBox.Text
        '    GlobalVariables.Bot_5_2_Selection = "--"
        '    GlobalVariables.Bot_5_1_Bowl_Selection = Bot_5_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_5_2_Bowl_Selection = "--"

        '    Bot_5_Number_TextBox.Visible = True
        '    Bot_5_Random_1_TextBox.Visible = False
        '    Bot_5_Random_2_TextBox.Visible = False
        '    Bot_5_Chart_TextBox.Visible = False

        '    Bot_5_Number_Bowl_TextBox.Visible = True
        '    Bot_5_Random_1_Bowl_TextBox.Visible = False
        '    Bot_5_Random_2_Bowl_TextBox.Visible = False
        '    Bot_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_5_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_5_1_Selection = Bot_5_Random_1_TextBox.Text
        '    GlobalVariables.Bot_5_2_Selection = Bot_5_Random_2_TextBox.Text
        '    GlobalVariables.Bot_5_1_Bowl_Selection = Bot_5_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_5_2_Bowl_Selection = Bot_5_Random_2_Bowl_TextBox.Text

        '    Bot_5_Number_TextBox.Visible = False
        '    Bot_5_Random_1_TextBox.Visible = True
        '    Bot_5_Random_2_TextBox.Visible = True
        '    Bot_5_Chart_TextBox.Visible = False

        '    Bot_5_Number_Bowl_TextBox.Visible = False
        '    Bot_5_Random_1_Bowl_TextBox.Visible = True
        '    Bot_5_Random_2_Bowl_TextBox.Visible = True
        '    Bot_5_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_5_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_5_1_Selection = Bot_5_Chart_TextBox.Text
        '    GlobalVariables.Bot_5_2_Selection = "--"
        '    GlobalVariables.Bot_5_1_Bowl_Selection = Bot_5_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_5_2_Bowl_Selection = "--"

        '    Bot_5_Number_TextBox.Visible = False
        '    Bot_5_Random_1_TextBox.Visible = False
        '    Bot_5_Random_2_TextBox.Visible = False
        '    Bot_5_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Bot_5_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart5(Bot_5_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_5_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_5_Number_Bowl_TextBox.Visible = False
        '    Bot_5_Random_1_Bowl_TextBox.Visible = False
        '    Bot_5_Random_2_Bowl_TextBox.Visible = False
        '    Bot_5_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_5_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_5_1_Selection = "--"
        '    GlobalVariables.Bot_5_2_Selection = "--"
        '    GlobalVariables.Bot_5_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_5_2_Bowl_Selection = "--"

        '    Bot_5_Number_TextBox.Visible = False
        '    Bot_5_Random_1_TextBox.Visible = False
        '    Bot_5_Random_2_TextBox.Visible = False
        '    Bot_5_Chart_TextBox.Visible = False

        '    Bot_5_Number_Bowl_TextBox.Visible = False
        '    Bot_5_Random_1_Bowl_TextBox.Visible = False
        '    Bot_5_Random_2_Bowl_TextBox.Visible = False
        '    Bot_5_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Bot 6
        'If Bot_6_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_6_1_Selection = Bot_6_Number_TextBox.Text
        '    GlobalVariables.Bot_6_2_Selection = "--"
        '    GlobalVariables.Bot_6_1_Bowl_Selection = Bot_6_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_6_2_Bowl_Selection = "--"

        '    Bot_6_Number_TextBox.Visible = True
        '    Bot_6_Random_1_TextBox.Visible = False
        '    Bot_6_Random_2_TextBox.Visible = False
        '    Bot_6_Chart_TextBox.Visible = False

        '    Bot_6_Number_Bowl_TextBox.Visible = True
        '    Bot_6_Random_1_Bowl_TextBox.Visible = False
        '    Bot_6_Random_2_Bowl_TextBox.Visible = False
        '    Bot_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_6_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_6_1_Selection = Bot_6_Random_1_TextBox.Text
        '    GlobalVariables.Bot_6_2_Selection = Bot_6_Random_2_TextBox.Text
        '    GlobalVariables.Bot_6_1_Bowl_Selection = Bot_6_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_6_2_Bowl_Selection = Bot_6_Random_2_Bowl_TextBox.Text

        '    Bot_6_Number_TextBox.Visible = False
        '    Bot_6_Random_1_TextBox.Visible = True
        '    Bot_6_Random_2_TextBox.Visible = True
        '    Bot_6_Chart_TextBox.Visible = False

        '    Bot_6_Number_Bowl_TextBox.Visible = False
        '    Bot_6_Random_1_Bowl_TextBox.Visible = True
        '    Bot_6_Random_2_Bowl_TextBox.Visible = True
        '    Bot_6_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_6_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_6_1_Selection = Bot_6_Chart_TextBox.Text
        '    GlobalVariables.Bot_6_2_Selection = "--"
        '    GlobalVariables.Bot_6_1_Bowl_Selection = Bot_6_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_6_2_Bowl_Selection = "--"

        '    Bot_6_Number_TextBox.Visible = False
        '    Bot_6_Random_1_TextBox.Visible = False
        '    Bot_6_Random_2_TextBox.Visible = False
        '    Bot_6_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Bot_6_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart6(Bot_6_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_6_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_6_Number_Bowl_TextBox.Visible = False
        '    Bot_6_Random_1_Bowl_TextBox.Visible = False
        '    Bot_6_Random_2_Bowl_TextBox.Visible = False
        '    Bot_6_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_6_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_6_1_Selection = "--"
        '    GlobalVariables.Bot_6_2_Selection = "--"
        '    GlobalVariables.Bot_6_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_6_2_Bowl_Selection = "--"

        '    Bot_6_Number_TextBox.Visible = False
        '    Bot_6_Random_1_TextBox.Visible = False
        '    Bot_6_Random_2_TextBox.Visible = False
        '    Bot_6_Chart_TextBox.Visible = False

        '    Bot_6_Number_Bowl_TextBox.Visible = False
        '    Bot_6_Random_1_Bowl_TextBox.Visible = False
        '    Bot_6_Random_2_Bowl_TextBox.Visible = False
        '    Bot_6_Chart_Bowl_TextBox.Visible = False

        'End If

        '' Bot 7
        'If Bot_7_Type.ToUpper = "FIXED" Then
        '    GlobalVariables.Bot_7_1_Selection = Bot_7_Number_TextBox.Text
        '    GlobalVariables.Bot_7_2_Selection = "--"
        '    GlobalVariables.Bot_7_1_Bowl_Selection = Bot_7_Number_Bowl_TextBox.Text
        '    GlobalVariables.Bot_7_2_Bowl_Selection = "--"

        '    Bot_7_Number_TextBox.Visible = True
        '    Bot_7_Random_1_TextBox.Visible = False
        '    Bot_7_Random_2_TextBox.Visible = False
        '    Bot_7_Chart_TextBox.Visible = False

        '    Bot_7_Number_Bowl_TextBox.Visible = True
        '    Bot_7_Random_1_Bowl_TextBox.Visible = False
        '    Bot_7_Random_2_Bowl_TextBox.Visible = False
        '    Bot_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_7_Type.ToUpper = "RANDOM" Then
        '    GlobalVariables.Bot_7_1_Selection = Bot_7_Random_1_TextBox.Text
        '    GlobalVariables.Bot_7_2_Selection = Bot_7_Random_2_TextBox.Text
        '    GlobalVariables.Bot_7_1_Bowl_Selection = Bot_7_Random_1_Bowl_TextBox.Text
        '    GlobalVariables.Bot_7_2_Bowl_Selection = Bot_7_Random_2_Bowl_TextBox.Text

        '    Bot_7_Number_TextBox.Visible = False
        '    Bot_7_Random_1_TextBox.Visible = True
        '    Bot_7_Random_2_TextBox.Visible = True
        '    Bot_7_Chart_TextBox.Visible = False

        '    Bot_7_Number_Bowl_TextBox.Visible = False
        '    Bot_7_Random_1_Bowl_TextBox.Visible = True
        '    Bot_7_Random_2_Bowl_TextBox.Visible = True
        '    Bot_7_Chart_Bowl_TextBox.Visible = False

        'ElseIf Bot_7_Type.ToUpper = "KEYCODE" Then
        '    GlobalVariables.Bot_7_1_Selection = Bot_7_Chart_TextBox.Text
        '    GlobalVariables.Bot_7_2_Selection = "--"
        '    GlobalVariables.Bot_7_1_Bowl_Selection = Bot_7_Chart_Bowl_TextBox.Text
        '    GlobalVariables.Bot_7_2_Bowl_Selection = "--"

        '    Bot_7_Number_TextBox.Visible = False
        '    Bot_7_Random_1_TextBox.Visible = False
        '    Bot_7_Random_2_TextBox.Visible = False
        '    Bot_7_Chart_TextBox.Visible = True

        '    ' Look up Bowl location
        '    If Bot_7_Type_TextBox.Text.ToUpper <> "NONE" Then
        '        Dim temp = ChartsTableAdapter.GetPart7(Bot_7_Chart_TextBox.Text)
        '        If Not IsNothing(temp) Then
        '            Bot_7_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
        '        End If
        '    End If

        '    Bot_7_Number_Bowl_TextBox.Visible = False
        '    Bot_7_Random_1_Bowl_TextBox.Visible = False
        '    Bot_7_Random_2_Bowl_TextBox.Visible = False
        '    Bot_7_Chart_Bowl_TextBox.Visible = True

        'ElseIf Bot_7_Type.ToUpper = "NONE" Then
        '    GlobalVariables.Bot_7_1_Selection = "--"
        '    GlobalVariables.Bot_7_2_Selection = "--"
        '    GlobalVariables.Bot_7_1_Bowl_Selection = "--"
        '    GlobalVariables.Bot_7_2_Bowl_Selection = "--"

        '    Bot_7_Number_TextBox.Visible = False
        '    Bot_7_Random_1_TextBox.Visible = False
        '    Bot_7_Random_2_TextBox.Visible = False
        '    Bot_7_Chart_TextBox.Visible = False

        '    Bot_7_Number_Bowl_TextBox.Visible = False
        '    Bot_7_Random_1_Bowl_TextBox.Visible = False
        '    Bot_7_Random_2_Bowl_TextBox.Visible = False
        '    Bot_7_Chart_Bowl_TextBox.Visible = False
        'End If
    End Sub
    Private Sub AllOff()
        KeyCode_Off()
        Fixed_Off()
        Random_Off()
    End Sub
    Private Sub AllOn()
        KeyCode_On()
        Fixed_On()
        Random_On()
    End Sub
    Private Sub KeyCode_On()
        Spring_1_Chart_TextBox.Visible = True
        Spring_2_Chart_TextBox.Visible = True
        Spring_3_Chart_TextBox.Visible = True
        Spring_4_Chart_TextBox.Visible = True
        Spring_5_Chart_TextBox.Visible = True
        Spring_6_Chart_TextBox.Visible = True
        Spring_7_Chart_TextBox.Visible = True

        Top_1_Chart_TextBox.Visible = True
        Top_2_Chart_TextBox.Visible = True
        Top_3_Chart_TextBox.Visible = True
        Top_4_Chart_TextBox.Visible = True
        Top_5_Chart_TextBox.Visible = True
        Top_6_Chart_TextBox.Visible = True
        Top_7_Chart_TextBox.Visible = True

        Mid_1_Chart_TextBox.Visible = True
        Mid_2_Chart_TextBox.Visible = True
        Mid_3_Chart_TextBox.Visible = True
        Mid_4_Chart_TextBox.Visible = True
        Mid_5_Chart_TextBox.Visible = True
        Mid_6_Chart_TextBox.Visible = True
        Mid_7_Chart_TextBox.Visible = True

        Bot_1_Chart_TextBox.Visible = True
        Bot_2_Chart_TextBox.Visible = True
        Bot_3_Chart_TextBox.Visible = True
        Bot_4_Chart_TextBox.Visible = True
        Bot_5_Chart_TextBox.Visible = True
        Bot_6_Chart_TextBox.Visible = True
        Bot_7_Chart_TextBox.Visible = True

    End Sub
    Private Sub KeyCode_Off()
        Spring_1_Chart_TextBox.Visible = False
        Spring_2_Chart_TextBox.Visible = False
        Spring_3_Chart_TextBox.Visible = False
        Spring_4_Chart_TextBox.Visible = False
        Spring_5_Chart_TextBox.Visible = False
        Spring_6_Chart_TextBox.Visible = False
        Spring_7_Chart_TextBox.Visible = False

        Top_1_Chart_TextBox.Visible = False
        Top_2_Chart_TextBox.Visible = False
        Top_3_Chart_TextBox.Visible = False
        Top_4_Chart_TextBox.Visible = False
        Top_5_Chart_TextBox.Visible = False
        Top_6_Chart_TextBox.Visible = False
        Top_7_Chart_TextBox.Visible = False

        Mid_1_Chart_TextBox.Visible = False
        Mid_2_Chart_TextBox.Visible = False
        Mid_3_Chart_TextBox.Visible = False
        Mid_4_Chart_TextBox.Visible = False
        Mid_5_Chart_TextBox.Visible = False
        Mid_6_Chart_TextBox.Visible = False
        Mid_7_Chart_TextBox.Visible = False

        Bot_1_Chart_TextBox.Visible = False
        Bot_2_Chart_TextBox.Visible = False
        Bot_3_Chart_TextBox.Visible = False
        Bot_4_Chart_TextBox.Visible = False
        Bot_5_Chart_TextBox.Visible = False
        Bot_6_Chart_TextBox.Visible = False
        Bot_7_Chart_TextBox.Visible = False

    End Sub
    Private Sub Random_On()
        Spring_1_Random_1_TextBox.Visible = True
        Spring_2_Random_1_TextBox.Visible = True
        Spring_3_Random_1_TextBox.Visible = True
        Spring_4_Random_1_TextBox.Visible = True
        Spring_5_Random_1_TextBox.Visible = True
        Spring_6_Random_1_TextBox.Visible = True
        Spring_7_Random_1_TextBox.Visible = True

        Spring_1_Random_2_TextBox.Visible = True
        Spring_2_Random_2_TextBox.Visible = True
        Spring_3_Random_2_TextBox.Visible = True
        Spring_4_Random_2_TextBox.Visible = True
        Spring_5_Random_2_TextBox.Visible = True
        Spring_6_Random_2_TextBox.Visible = True
        Spring_7_Random_2_TextBox.Visible = True

    End Sub
    Private Sub Random_Off()
        Spring_1_Random_1_TextBox.Visible = False
        Spring_2_Random_1_TextBox.Visible = False
        Spring_3_Random_1_TextBox.Visible = False
        Spring_4_Random_1_TextBox.Visible = False
        Spring_5_Random_1_TextBox.Visible = False
        Spring_6_Random_1_TextBox.Visible = False
        Spring_7_Random_1_TextBox.Visible = False

        Spring_1_Random_2_TextBox.Visible = False
        Spring_2_Random_2_TextBox.Visible = False
        Spring_3_Random_2_TextBox.Visible = False
        Spring_4_Random_2_TextBox.Visible = False
        Spring_5_Random_2_TextBox.Visible = False
        Spring_6_Random_2_TextBox.Visible = False
        Spring_7_Random_2_TextBox.Visible = False

    End Sub
    Private Sub Fixed_On()
        Spring_1_Number_TextBox.Visible = True
        Spring_2_Number_TextBox.Visible = True
        Spring_3_Number_TextBox.Visible = True
        Spring_4_Number_TextBox.Visible = True
        Spring_5_Number_TextBox.Visible = True
        Spring_6_Number_TextBox.Visible = True
        Spring_7_Number_TextBox.Visible = True

        Top_1_Number_TextBox.Visible = True
        Top_2_Number_TextBox.Visible = True
        Top_3_Number_TextBox.Visible = True
        Top_4_Number_TextBox.Visible = True
        Top_5_Number_TextBox.Visible = True
        Top_6_Number_TextBox.Visible = True
        Top_7_Number_TextBox.Visible = True

        Mid_1_Number_TextBox.Visible = True
        Mid_2_Number_TextBox.Visible = True
        Mid_3_Number_TextBox.Visible = True
        Mid_4_Number_TextBox.Visible = True
        Mid_5_Number_TextBox.Visible = True
        Mid_6_Number_TextBox.Visible = True
        Mid_7_Number_TextBox.Visible = True

        Bot_1_Number_TextBox.Visible = True
        Bot_2_Number_TextBox.Visible = True
        Bot_3_Number_TextBox.Visible = True
        Bot_4_Number_TextBox.Visible = True
        Bot_5_Number_TextBox.Visible = True
        Bot_6_Number_TextBox.Visible = True
        Bot_7_Number_TextBox.Visible = True

    End Sub
    Private Sub Fixed_Off()
        Spring_1_Number_TextBox.Visible = False
        Spring_2_Number_TextBox.Visible = False
        Spring_3_Number_TextBox.Visible = False
        Spring_4_Number_TextBox.Visible = False
        Spring_5_Number_TextBox.Visible = False
        Spring_6_Number_TextBox.Visible = False
        Spring_7_Number_TextBox.Visible = False

        Top_1_Number_TextBox.Visible = False
        Top_2_Number_TextBox.Visible = False
        Top_3_Number_TextBox.Visible = False
        Top_4_Number_TextBox.Visible = False
        Top_5_Number_TextBox.Visible = False
        Top_6_Number_TextBox.Visible = False
        Top_7_Number_TextBox.Visible = False

        Mid_1_Number_TextBox.Visible = False
        Mid_2_Number_TextBox.Visible = False
        Mid_3_Number_TextBox.Visible = False
        Mid_4_Number_TextBox.Visible = False
        Mid_5_Number_TextBox.Visible = False
        Mid_6_Number_TextBox.Visible = False
        Mid_7_Number_TextBox.Visible = False

        Bot_1_Number_TextBox.Visible = False
        Bot_2_Number_TextBox.Visible = False
        Bot_3_Number_TextBox.Visible = False
        Bot_4_Number_TextBox.Visible = False
        Bot_5_Number_TextBox.Visible = False
        Bot_6_Number_TextBox.Visible = False
        Bot_7_Number_TextBox.Visible = False

    End Sub

    Private Sub Spring_1_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_1_Random_1_TextBox.TextChanged
        Spring_1_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_1_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_1_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_1_Random_2_TextBox.TextChanged
        Spring_1_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_1_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_1_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_1_Number_TextBox.TextChanged
        Spring_1_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_1_Number_TextBox.Text)
    End Sub

    Private Sub Spring_2_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_2_Random_1_TextBox.TextChanged
        Spring_2_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_2_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_2_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_2_Random_2_TextBox.TextChanged
        Spring_2_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_2_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_2_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_2_Number_TextBox.TextChanged
        Spring_2_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_2_Number_TextBox.Text)
    End Sub

    Private Sub Spring_3_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_3_Random_1_TextBox.TextChanged
        Spring_3_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_3_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_3_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_3_Random_2_TextBox.TextChanged
        Spring_3_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_3_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_3_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_3_Number_TextBox.TextChanged
        Spring_3_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_3_Number_TextBox.Text)
    End Sub

    Private Sub Spring_4_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_4_Random_1_TextBox.TextChanged
        Spring_4_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_4_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_4_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_4_Random_2_TextBox.TextChanged
        Spring_4_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_4_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_4_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_4_Number_TextBox.TextChanged
        Spring_4_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_4_Number_TextBox.Text)
    End Sub
    Private Sub Spring_5_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_5_Random_1_TextBox.TextChanged
        Spring_5_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_5_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_5_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_5_Random_2_TextBox.TextChanged
        Spring_5_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_5_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_5_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_5_Number_TextBox.TextChanged
        Spring_5_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_5_Number_TextBox.Text)
    End Sub

    Private Sub Spring_6_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_6_Random_1_TextBox.TextChanged
        Spring_6_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_6_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_6_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_6_Random_2_TextBox.TextChanged
        Spring_6_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_6_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_6_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_6_Number_TextBox.TextChanged
        Spring_6_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_6_Number_TextBox.Text)
    End Sub

    Private Sub Spring_7_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_7_Random_1_TextBox.TextChanged
        Spring_7_Random_1_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_7_Random_1_TextBox.Text)
    End Sub

    Private Sub Spring_7_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_7_Random_2_TextBox.TextChanged
        Spring_7_Random_2_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_7_Random_2_TextBox.Text)
    End Sub

    Private Sub Spring_7_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_7_Number_TextBox.TextChanged
        Spring_7_Number_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(Spring_7_Number_TextBox.Text)
    End Sub
    Private Sub Top_1_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_1_Random_1_TextBox.TextChanged
        Top_1_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_1_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_1_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_1_Random_2_TextBox.TextChanged
        Top_1_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_1_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_1_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_1_Number_TextBox.TextChanged
        Top_1_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_1_Number_TextBox.Text)
    End Sub

    Private Sub Top_2_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_2_Random_1_TextBox.TextChanged
        Top_2_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_2_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_2_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_2_Random_2_TextBox.TextChanged
        Top_2_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_2_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_2_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_2_Number_TextBox.TextChanged
        Top_2_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_2_Number_TextBox.Text)
    End Sub

    Private Sub Top_3_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_3_Random_1_TextBox.TextChanged
        Top_3_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_3_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_3_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_3_Random_2_TextBox.TextChanged
        Top_3_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_3_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_3_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_3_Number_TextBox.TextChanged
        Top_3_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_3_Number_TextBox.Text)
    End Sub

    Private Sub Top_4_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_4_Random_1_TextBox.TextChanged
        Top_4_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_4_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_4_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_4_Random_2_TextBox.TextChanged
        Top_4_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_4_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_4_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_4_Number_TextBox.TextChanged
        Top_4_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_4_Number_TextBox.Text)
    End Sub

    Private Sub Top_5_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_5_Random_1_TextBox.TextChanged
        Top_5_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_5_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_5_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_5_Random_2_TextBox.TextChanged
        Top_5_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_5_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_5_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_5_Number_TextBox.TextChanged
        Top_5_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_5_Number_TextBox.Text)
    End Sub

    Private Sub Top_6_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_6_Random_1_TextBox.TextChanged
        Top_6_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_6_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_6_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_6_Random_2_TextBox.TextChanged
        Top_6_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_6_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_6_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_6_Number_TextBox.TextChanged
        Top_6_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_6_Number_TextBox.Text)
    End Sub

    Private Sub Top_7_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_7_Random_1_TextBox.TextChanged
        Top_7_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_7_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_7_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_7_Random_2_TextBox.TextChanged
        Top_7_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_7_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_7_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_7_Number_TextBox.TextChanged
        Top_7_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_7_Number_TextBox.Text)
    End Sub

    Private Sub Top_8_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_8_Random_1_TextBox.TextChanged
        Top_8_Random_1_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_8_Random_1_TextBox.Text)
    End Sub

    Private Sub Top_8_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_8_Random_2_TextBox.TextChanged
        Top_8_Random_2_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_8_Random_2_TextBox.Text)
    End Sub

    Private Sub Top_8_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_8_Number_TextBox.TextChanged
        Top_8_Number_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_8_Number_TextBox.Text)
    End Sub

    Private Sub Mid_1_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_1_Random_1_TextBox.TextChanged
        Mid_1_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_1_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_1_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_1_Random_2_TextBox.TextChanged
        Mid_1_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_1_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_1_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_1_Number_TextBox.TextChanged
        Mid_1_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_1_Number_TextBox.Text)
    End Sub

    Private Sub Mid_2_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_2_Random_1_TextBox.TextChanged
        Mid_2_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_2_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_2_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_2_Random_2_TextBox.TextChanged
        Mid_2_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_2_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_2_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_2_Number_TextBox.TextChanged
        Mid_2_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_2_Number_TextBox.Text)
    End Sub

    Private Sub Mid_3_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_3_Random_1_TextBox.TextChanged
        Mid_3_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_3_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_3_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_3_Random_2_TextBox.TextChanged
        Mid_3_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_3_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_3_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_3_Number_TextBox.TextChanged
        Mid_3_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_3_Number_TextBox.Text)
    End Sub

    Private Sub Mid_4_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_4_Random_1_TextBox.TextChanged
        Mid_4_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_4_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_4_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_4_Random_2_TextBox.TextChanged
        Mid_4_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_4_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_4_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_4_Number_TextBox.TextChanged
        Mid_4_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_4_Number_TextBox.Text)
    End Sub

    Private Sub Mid_5_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_5_Random_1_TextBox.TextChanged
        Mid_5_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_5_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_5_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_5_Random_2_TextBox.TextChanged
        Mid_5_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_5_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_5_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_5_Number_TextBox.TextChanged
        Mid_5_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_5_Number_TextBox.Text)
    End Sub

    Private Sub Mid_6_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_6_Random_1_TextBox.TextChanged
        Mid_6_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_6_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_6_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_6_Random_2_TextBox.TextChanged
        Mid_6_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_6_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_6_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_6_Number_TextBox.TextChanged
        Mid_6_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_6_Number_TextBox.Text)
    End Sub

    Private Sub Mid_7_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_7_Random_1_TextBox.TextChanged
        Mid_7_Random_1_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_7_Random_1_TextBox.Text)
    End Sub

    Private Sub Mid_7_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_7_Random_2_TextBox.TextChanged
        Mid_7_Random_2_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_7_Random_2_TextBox.Text)
    End Sub

    Private Sub Mid_7_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_7_Number_TextBox.TextChanged
        Mid_7_Number_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_7_Number_TextBox.Text)
    End Sub

    Private Sub Bot_1_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_1_Random_1_TextBox.TextChanged
        Bot_1_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_1_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_1_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_1_Random_2_TextBox.TextChanged
        Bot_1_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_1_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_1_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_1_Number_TextBox.TextChanged
        Bot_1_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_1_Number_TextBox.Text)
    End Sub

    Private Sub Bot_2_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_2_Random_1_TextBox.TextChanged
        Bot_2_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_2_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_2_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_2_Random_2_TextBox.TextChanged
        Bot_2_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_2_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_2_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_2_Number_TextBox.TextChanged
        Bot_2_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_2_Number_TextBox.Text)
    End Sub

    Private Sub Bot_3_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_3_Random_1_TextBox.TextChanged
        Bot_3_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_3_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_3_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_3_Random_2_TextBox.TextChanged
        Bot_3_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_3_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_3_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_3_Number_TextBox.TextChanged
        Bot_3_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_3_Number_TextBox.Text)
    End Sub
    Private Sub Bot_4_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_4_Random_1_TextBox.TextChanged
        Bot_4_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_4_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_4_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_4_Random_2_TextBox.TextChanged
        Bot_4_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_4_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_4_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_4_Number_TextBox.TextChanged
        Bot_4_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_4_Number_TextBox.Text)
    End Sub

    Private Sub Bot_5_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_5_Random_1_TextBox.TextChanged
        Bot_5_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_5_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_5_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_5_Random_2_TextBox.TextChanged
        Bot_5_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_5_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_5_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_5_Number_TextBox.TextChanged
        Bot_5_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_5_Number_TextBox.Text)
    End Sub
    Private Sub Bot_6_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_6_Random_1_TextBox.TextChanged
        Bot_6_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_6_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_6_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_6_Random_2_TextBox.TextChanged
        Bot_6_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_6_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_6_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_6_Number_TextBox.TextChanged
        Bot_6_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_6_Number_TextBox.Text)
    End Sub
    Private Sub Bot_7_Random_1_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_7_Random_1_TextBox.TextChanged
        Bot_7_Random_1_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_7_Random_1_TextBox.Text)
    End Sub

    Private Sub Bot_7_Random_2_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_7_Random_2_TextBox.TextChanged
        Bot_7_Random_2_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_7_Random_2_TextBox.Text)
    End Sub

    Private Sub Bot_7_Number_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_7_Number_TextBox.TextChanged
        Bot_7_Number_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(Bot_7_Number_TextBox.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tumbler_Kit_TextBox_TextChanged()
    End Sub

    'Private Sub Spring_1_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_1_Chart_TextBox.TextChanged
    '    If Spring_1_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart1(Spring_1_Chart_TextBox.Text)
    '        Spring_1_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Spring_2_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_2_Chart_TextBox.TextChanged
    '    If Spring_2_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart2(Spring_2_Chart_TextBox.Text)
    '        Spring_2_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Spring_3_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_3_Chart_TextBox.TextChanged
    '    If Spring_3_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart3(Spring_3_Chart_TextBox.Text)
    '        Spring_3_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Spring_4_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_4_Chart_TextBox.TextChanged
    '    If Spring_4_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart4(Spring_4_Chart_TextBox.Text)
    '        Spring_4_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Spring_5_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_5_Chart_TextBox.TextChanged
    '    If Spring_5_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart5(Spring_5_Chart_TextBox.Text)
    '        Spring_5_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Spring_6_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_6_Chart_TextBox.TextChanged
    '    If Spring_6_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart6(Spring_6_Chart_TextBox.Text)
    '        Spring_6_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Spring_7_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Spring_7_Chart_TextBox.TextChanged
    '    If Spring_7_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart7(Spring_7_Chart_TextBox.Text)
    '        Spring_7_Chart_Bowl_TextBox.Text = SpringsTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Top_1_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_1_Chart_TextBox.TextChanged
    '    If Top_1_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart1(Top_1_Chart_TextBox.Text)
    '        Top_1_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(Top_1_Chart_TextBox.Text)
    '    End If
    'End Sub

    'Private Sub Top_2_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_2_Chart_TextBox.TextChanged
    '    If Top_2_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart2(Top_2_Chart_TextBox.Text)
    '        Top_2_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Top_3_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_3_Chart_TextBox.TextChanged
    '    If Top_2_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart3(Top_3_Chart_TextBox.Text)
    '        Top_3_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Top_4_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_4_Chart_TextBox.TextChanged
    '    If Top_3_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart4(Top_4_Chart_TextBox.Text)
    '        Top_4_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Top_5_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_5_Chart_TextBox.TextChanged
    '    If Top_5_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart5(Top_5_Chart_TextBox.Text)
    '        Top_5_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Top_6_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_6_Chart_TextBox.TextChanged
    '    If Top_6_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart6(Top_6_Chart_TextBox.Text)
    '        Top_6_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Top_7_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Top_7_Chart_TextBox.TextChanged
    '    If Top_7_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart7(Top_7_Chart_TextBox.Text)
    '        Top_7_Chart_Bowl_TextBox.Text = Top_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Mid_1_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_1_Chart_TextBox.TextChanged
    '    If Mid_1_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart1(Mid_1_Chart_TextBox.Text)
    '        Mid_1_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Mid_2_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_2_Chart_TextBox.TextChanged
    '    If Mid_2_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart2(Mid_2_Chart_TextBox.Text)
    '        Mid_2_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Mid_3_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_3_Chart_TextBox.TextChanged
    '    If Mid_3_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart3(Mid_3_Chart_TextBox.Text)
    '        Mid_3_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Mid_4_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_4_Chart_TextBox.TextChanged
    '    If Mid_4_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart4(Mid_4_Chart_TextBox.Text)
    '        Mid_4_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Mid_5_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_5_Chart_TextBox.TextChanged
    '    If Mid_5_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart5(Mid_5_Chart_TextBox.Text)
    '        Mid_5_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(Mid_5_Chart_TextBox.Text)
    '    End If
    'End Sub

    'Private Sub Mid_6_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_6_Chart_TextBox.TextChanged
    '    If Mid_6_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart6(Mid_6_Chart_TextBox.Text)
    '        Mid_6_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Mid_7_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Mid_7_Chart_TextBox.TextChanged
    '    If Mid_7_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart7(Mid_7_Chart_TextBox.Text)
    '        Mid_7_Chart_Bowl_TextBox.Text = Mid_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_1_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_1_Chart_TextBox.TextChanged
    '    If Bot_1_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart1(Bot_1_Chart_TextBox.Text)
    '        Bot_1_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_2_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_2_Chart_TextBox.TextChanged
    '    If Bot_2_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart2(Bot_2_Chart_TextBox.Text)
    '        Bot_2_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_3_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_3_Chart_TextBox.TextChanged
    '    If Bot_3_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart3(Bot_3_Chart_TextBox.Text)
    '        Bot_3_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_4_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_4_Chart_TextBox.TextChanged
    '    If Bot_4_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart4(Bot_4_Chart_TextBox.Text)
    '        Bot_4_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_5_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_5_Chart_TextBox.TextChanged
    '    If Bot_5_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart5(Bot_5_Chart_TextBox.Text)
    '        Bot_5_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_6_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_6_Chart_TextBox.TextChanged
    '    If Bot_6_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart6(Bot_6_Chart_TextBox.Text)
    '        Bot_6_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub

    'Private Sub Bot_7_Chart_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Bot_7_Chart_TextBox.TextChanged
    '    If Bot_7_Type_TextBox.Text.ToUpper = "KEYCODE" Then
    '        Dim temp = ChartsTableAdapter.GetPart7(Bot_7_Chart_TextBox.Text)
    '        Bot_7_Chart_Bowl_TextBox.Text = Bottom_TumblerTableAdapter.GetBowl(temp)
    '    End If
    'End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Tumbler_KitTableAdapter.Update(NCLRecipeDataSet.Tumbler_Kit)
            Me.Tumbler_KitTableAdapter.Fill(Me.NCLRecipeDataSet.Tumbler_Kit)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Tumbler_KitRow
        NewRow = Me.NCLRecipeDataSet.Tumbler_Kit.NewRow()

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring1_Type = Spring_2_Type_TextBox.Text
        NewRow.Spring1_Random1 = Spring_2_Random_1_TextBox.Text
        NewRow.Spring1_Random2 = Spring_2_Random_2_TextBox.Text
        NewRow.Spring1_Number = Spring_2_Number_TextBox.Text
        NewRow.Spring1_Chart = Spring_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring2_Type = Spring_2_Type_TextBox.Text
        NewRow.Spring2_Random1 = Spring_2_Random_1_TextBox.Text
        NewRow.Spring2_Random2 = Spring_2_Random_2_TextBox.Text
        NewRow.Spring2_Number = Spring_2_Number_TextBox.Text
        NewRow.Spring2_Chart = Spring_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring3_Type = Spring_3_Type_TextBox.Text
        NewRow.Spring3_Random1 = Spring_3_Random_1_TextBox.Text
        NewRow.Spring3_Random2 = Spring_3_Random_2_TextBox.Text
        NewRow.Spring3_Number = Spring_3_Number_TextBox.Text
        NewRow.Spring3_Chart = Spring_3_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring4_Type = Spring_4_Type_TextBox.Text
        NewRow.Spring4_Random1 = Spring_4_Random_1_TextBox.Text
        NewRow.Spring4_Random2 = Spring_4_Random_2_TextBox.Text
        NewRow.Spring4_Number = Spring_4_Number_TextBox.Text
        NewRow.Spring4_Chart = Spring_4_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring5_Type = Spring_5_Type_TextBox.Text
        NewRow.Spring5_Random1 = Spring_5_Random_1_TextBox.Text
        NewRow.Spring5_Random2 = Spring_5_Random_2_TextBox.Text
        NewRow.Spring5_Number = Spring_5_Number_TextBox.Text
        NewRow.Spring5_Chart = Spring_5_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring6_Type = Spring_6_Type_TextBox.Text
        NewRow.Spring6_Random1 = Spring_6_Random_1_TextBox.Text
        NewRow.Spring6_Random2 = Spring_6_Random_2_TextBox.Text
        NewRow.Spring6_Number = Spring_6_Number_TextBox.Text
        NewRow.Spring6_Chart = Spring_6_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Spring7_Type = Spring_7_Type_TextBox.Text
        NewRow.Spring7_Random1 = Spring_7_Random_1_TextBox.Text
        NewRow.Spring7_Random2 = Spring_7_Random_2_TextBox.Text
        NewRow.Spring7_Number = Spring_7_Number_TextBox.Text
        NewRow.Spring7_Chart = Spring_7_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top1_Type = Top_2_Type_TextBox.Text
        NewRow.Top1_Random1 = Top_2_Random_1_TextBox.Text
        NewRow.Top1_Random2 = Top_2_Random_2_TextBox.Text
        NewRow.Top1_Number = Top_2_Number_TextBox.Text
        NewRow.Top1_Chart = Top_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top2_Type = Top_2_Type_TextBox.Text
        NewRow.Top2_Random1 = Top_2_Random_1_TextBox.Text
        NewRow.Top2_Random2 = Top_2_Random_2_TextBox.Text
        NewRow.Top2_Number = Top_2_Number_TextBox.Text
        NewRow.Top2_Chart = Top_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top3_Type = Top_3_Type_TextBox.Text
        NewRow.Top3_Random1 = Top_3_Random_1_TextBox.Text
        NewRow.Top3_Random2 = Top_3_Random_2_TextBox.Text
        NewRow.Top3_Number = Top_3_Number_TextBox.Text
        NewRow.Top3_Chart = Top_3_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top4_Type = Top_4_Type_TextBox.Text
        NewRow.Top4_Random1 = Top_4_Random_1_TextBox.Text
        NewRow.Top4_Random2 = Top_4_Random_2_TextBox.Text
        NewRow.Top4_Number = Top_4_Number_TextBox.Text
        NewRow.Top4_Chart = Top_4_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top5_Type = Top_5_Type_TextBox.Text
        NewRow.Top5_Random1 = Top_5_Random_1_TextBox.Text
        NewRow.Top5_Random2 = Top_5_Random_2_TextBox.Text
        NewRow.Top5_Number = Top_5_Number_TextBox.Text
        NewRow.Top5_Chart = Top_5_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top6_Type = Top_6_Type_TextBox.Text
        NewRow.Top6_Random1 = Top_6_Random_1_TextBox.Text
        NewRow.Top6_Random2 = Top_6_Random_2_TextBox.Text
        NewRow.Top6_Number = Top_6_Number_TextBox.Text
        NewRow.Top6_Chart = Top_6_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Top7_Type = Top_7_Type_TextBox.Text
        NewRow.Top7_Random1 = Top_7_Random_1_TextBox.Text
        NewRow.Top7_Random2 = Top_7_Random_2_TextBox.Text
        NewRow.Top7_Number = Top_7_Number_TextBox.Text
        NewRow.Top7_Chart = Top_7_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid1_Type = Mid_2_Type_TextBox.Text
        NewRow.Mid1_Random1 = Mid_2_Random_1_TextBox.Text
        NewRow.Mid1_Random2 = Mid_2_Random_2_TextBox.Text
        NewRow.Mid1_Number = Mid_2_Number_TextBox.Text
        NewRow.Mid1_Chart = Mid_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid2_Type = Mid_2_Type_TextBox.Text
        NewRow.Mid2_Random1 = Mid_2_Random_1_TextBox.Text
        NewRow.Mid2_Random2 = Mid_2_Random_2_TextBox.Text
        NewRow.Mid2_Number = Mid_2_Number_TextBox.Text
        NewRow.Mid2_Chart = Mid_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid3_Type = Mid_3_Type_TextBox.Text
        NewRow.Mid3_Random1 = Mid_3_Random_1_TextBox.Text
        NewRow.Mid3_Random2 = Mid_3_Random_2_TextBox.Text
        NewRow.Mid3_Number = Mid_3_Number_TextBox.Text
        NewRow.Mid3_Chart = Mid_3_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid4_Type = Mid_4_Type_TextBox.Text
        NewRow.Mid4_Random1 = Mid_4_Random_1_TextBox.Text
        NewRow.Mid4_Random2 = Mid_4_Random_2_TextBox.Text
        NewRow.Mid4_Number = Mid_4_Number_TextBox.Text
        NewRow.Mid4_Chart = Mid_4_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid5_Type = Mid_5_Type_TextBox.Text
        NewRow.Mid5_Random1 = Mid_5_Random_1_TextBox.Text
        NewRow.Mid5_Random2 = Mid_5_Random_2_TextBox.Text
        NewRow.Mid5_Number = Mid_5_Number_TextBox.Text
        NewRow.Mid5_Chart = Mid_5_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid6_Type = Mid_6_Type_TextBox.Text
        NewRow.Mid6_Random1 = Mid_6_Random_1_TextBox.Text
        NewRow.Mid6_Random2 = Mid_6_Random_2_TextBox.Text
        NewRow.Mid6_Number = Mid_6_Number_TextBox.Text
        NewRow.Mid6_Chart = Mid_6_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Mid7_Type = Mid_7_Type_TextBox.Text
        NewRow.Mid7_Random1 = Mid_7_Random_1_TextBox.Text
        NewRow.Mid7_Random2 = Mid_7_Random_2_TextBox.Text
        NewRow.Mid7_Number = Mid_7_Number_TextBox.Text
        NewRow.Mid7_Chart = Mid_7_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot1_Type = Bot_2_Type_TextBox.Text
        NewRow.Bot1_Random1 = Bot_2_Random_1_TextBox.Text
        NewRow.Bot1_Random2 = Bot_2_Random_2_TextBox.Text
        NewRow.Bot1_Number = Bot_2_Number_TextBox.Text
        NewRow.Bot1_Chart = Bot_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot2_Type = Bot_2_Type_TextBox.Text
        NewRow.Bot2_Random1 = Bot_2_Random_1_TextBox.Text
        NewRow.Bot2_Random2 = Bot_2_Random_2_TextBox.Text
        NewRow.Bot2_Number = Bot_2_Number_TextBox.Text
        NewRow.Bot2_Chart = Bot_2_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot3_Type = Bot_3_Type_TextBox.Text
        NewRow.Bot3_Random1 = Bot_3_Random_1_TextBox.Text
        NewRow.Bot3_Random2 = Bot_3_Random_2_TextBox.Text
        NewRow.Bot3_Number = Bot_3_Number_TextBox.Text
        NewRow.Bot3_Chart = Bot_3_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot4_Type = Bot_4_Type_TextBox.Text
        NewRow.Bot4_Random1 = Bot_4_Random_1_TextBox.Text
        NewRow.Bot4_Random2 = Bot_4_Random_2_TextBox.Text
        NewRow.Bot4_Number = Bot_4_Number_TextBox.Text
        NewRow.Bot4_Chart = Bot_4_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot5_Type = Bot_5_Type_TextBox.Text
        NewRow.Bot5_Random1 = Bot_5_Random_1_TextBox.Text
        NewRow.Bot5_Random2 = Bot_5_Random_2_TextBox.Text
        NewRow.Bot5_Number = Bot_5_Number_TextBox.Text
        NewRow.Bot5_Chart = Bot_5_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot6_Type = Bot_6_Type_TextBox.Text
        NewRow.Bot6_Random1 = Bot_6_Random_1_TextBox.Text
        NewRow.Bot6_Random2 = Bot_6_Random_2_TextBox.Text
        NewRow.Bot6_Number = Bot_6_Number_TextBox.Text
        NewRow.Bot6_Chart = Bot_6_Chart_TextBox.Text

        NewRow.Tumbler_Kit = Tumbler_Kit_TextBox.Text
        NewRow.Bot7_Type = Bot_7_Type_TextBox.Text
        NewRow.Bot7_Random1 = Bot_7_Random_1_TextBox.Text
        NewRow.Bot7_Random2 = Bot_7_Random_2_TextBox.Text
        NewRow.Bot7_Number = Bot_7_Number_TextBox.Text
        NewRow.Bot7_Chart = Bot_7_Chart_TextBox.Text

        Try
            Tumbler_KitTableAdapter.Insert(Tumbler_Kit:=NewRow.Tumbler_Kit,
                                         Spring1_Type:=NewRow.Spring1_Type,
                                         Spring1_Random1:=NewRow.Spring1_Random1,
                                         Spring1_Random2:=NewRow.Spring1_Random2,
                                         Spring1_Number:=NewRow.Spring1_Number,
                                         Spring1_Chart:=NewRow.Spring1_Chart,
                                         Spring2_Type:=NewRow.Spring2_Type,
                                         Spring2_Random1:=NewRow.Spring2_Random1,
                                         Spring2_Random2:=NewRow.Spring2_Random2,
                                         Spring2_Number:=NewRow.Spring2_Number,
                                         Spring2_Chart:=NewRow.Spring2_Chart,
                                         Spring3_Type:=NewRow.Spring3_Type,
                                         Spring3_Random1:=NewRow.Spring3_Random1,
                                         Spring3_Random2:=NewRow.Spring3_Random2,
                                         Spring3_Number:=NewRow.Spring3_Number,
                                         Spring3_Chart:=NewRow.Spring3_Chart,
                                         Spring4_Type:=NewRow.Spring4_Type,
                                         Spring4_Random1:=NewRow.Spring4_Random1,
                                         Spring4_Random2:=NewRow.Spring4_Random2,
                                         Spring4_Number:=NewRow.Spring4_Number,
                                         Spring4_Chart:=NewRow.Spring4_Chart,
                                         Spring5_Type:=NewRow.Spring5_Type,
                                         Spring5_Random1:=NewRow.Spring5_Random1,
                                         Spring5_Random2:=NewRow.Spring5_Random2,
                                         Spring5_Number:=NewRow.Spring5_Number,
                                         Spring5_Chart:=NewRow.Spring5_Chart,
                                         Spring6_Type:=NewRow.Spring6_Type,
                                         Spring6_Random1:=NewRow.Spring6_Random1,
                                         Spring6_Random2:=NewRow.Spring6_Random2,
                                         Spring6_Number:=NewRow.Spring6_Number,
                                         Spring6_Chart:=NewRow.Spring6_Chart,
                                         Spring7_Type:=NewRow.Spring7_Type,
                                         Spring7_Random1:=NewRow.Spring7_Random1,
                                         Spring7_Random2:=NewRow.Spring7_Random2,
                                         Spring7_Number:=NewRow.Spring7_Number,
                                         Spring7_Chart:=NewRow.Spring7_Chart,
                                         Top1_Type:=NewRow.Top1_Type,
                                         Top1_Random1:=NewRow.Top1_Random1,
                                         Top1_Random2:=NewRow.Top1_Random2,
                                         Top1_Number:=NewRow.Top1_Number,
                                         Top1_Chart:=NewRow.Top1_Chart,
                                         Top2_Type:=NewRow.Top2_Type,
                                         Top2_Random1:=NewRow.Top2_Random1,
                                         Top2_Random2:=NewRow.Top2_Random2,
                                         Top2_Number:=NewRow.Top2_Number,
                                         Top2_Chart:=NewRow.Top2_Chart,
                                         Top3_Type:=NewRow.Top3_Type,
                                         Top3_Random1:=NewRow.Top3_Random1,
                                         Top3_Random2:=NewRow.Top3_Random2,
                                         Top3_Number:=NewRow.Top3_Number,
                                         Top3_Chart:=NewRow.Top3_Chart,
                                         Top4_Type:=NewRow.Top4_Type,
                                         Top4_Random1:=NewRow.Top4_Random1,
                                         Top4_Random2:=NewRow.Top4_Random2,
                                         Top4_Number:=NewRow.Top4_Number,
                                         Top4_Chart:=NewRow.Top4_Chart,
                                         Top5_Type:=NewRow.Top5_Type,
                                         Top5_Random1:=NewRow.Top5_Random1,
                                         Top5_Random2:=NewRow.Top5_Random2,
                                         Top5_Number:=NewRow.Top5_Number,
                                         Top5_Chart:=NewRow.Top5_Chart,
                                         Top6_Type:=NewRow.Top6_Type,
                                         Top6_Random1:=NewRow.Top6_Random1,
                                         Top6_Random2:=NewRow.Top6_Random2,
                                         Top6_Number:=NewRow.Top6_Number,
                                         Top6_Chart:=NewRow.Top6_Chart,
                                         Top7_Type:=NewRow.Top7_Type,
                                         Top7_Random1:=NewRow.Top7_Random1,
                                         Top7_Random2:=NewRow.Top7_Random2,
                                         Top7_Number:=NewRow.Top7_Number,
                                         Top7_Chart:=NewRow.Top7_Chart,
                                         Top8_Type:=NewRow.Top8_Type,
                                         Top8_Random1:=NewRow.Top8_Random1,
                                         Top8_Random2:=NewRow.Top8_Random2,
                                         Top8_Number:=NewRow.Top8_Number,
                                         Top8_Chart:=NewRow.Top8_Chart,
                                         Mid1_Type:=NewRow.Mid1_Type,
                                         Mid1_Random1:=NewRow.Mid1_Random1,
                                         Mid1_Random2:=NewRow.Mid1_Random2,
                                         Mid1_Number:=NewRow.Mid1_Number,
                                         Mid1_Chart:=NewRow.Mid1_Chart,
                                         Mid2_Type:=NewRow.Mid2_Type,
                                         Mid2_Random1:=NewRow.Mid2_Random1,
                                         Mid2_Random2:=NewRow.Mid2_Random2,
                                         Mid2_Number:=NewRow.Mid2_Number,
                                         Mid2_Chart:=NewRow.Mid2_Chart,
                                         Mid3_Type:=NewRow.Mid3_Type,
                                         Mid3_Random1:=NewRow.Mid3_Random1,
                                         Mid3_Random2:=NewRow.Mid3_Random2,
                                         Mid3_Number:=NewRow.Mid3_Number,
                                         Mid3_Chart:=NewRow.Mid3_Chart,
                                         Mid4_Type:=NewRow.Mid4_Type,
                                         Mid4_Random1:=NewRow.Mid4_Random1,
                                         Mid4_Random2:=NewRow.Mid4_Random2,
                                         Mid4_Number:=NewRow.Mid4_Number,
                                         Mid4_Chart:=NewRow.Mid4_Chart,
                                         Mid5_Type:=NewRow.Mid5_Type,
                                         Mid5_Random1:=NewRow.Mid5_Random1,
                                         Mid5_Random2:=NewRow.Mid5_Random2,
                                         Mid5_Number:=NewRow.Mid5_Number,
                                         Mid5_Chart:=NewRow.Mid5_Chart,
                                         Mid6_Type:=NewRow.Mid6_Type,
                                         Mid6_Random1:=NewRow.Mid6_Random1,
                                         Mid6_Random2:=NewRow.Mid6_Random2,
                                         Mid6_Number:=NewRow.Mid6_Number,
                                         Mid6_Chart:=NewRow.Mid6_Chart,
                                         Mid7_Type:=NewRow.Mid7_Type,
                                         Mid7_Random1:=NewRow.Mid7_Random1,
                                         Mid7_Random2:=NewRow.Mid7_Random2,
                                         Mid7_Number:=NewRow.Mid7_Number,
                                         Mid7_Chart:=NewRow.Mid7_Chart,
                                         Bot1_Type:=NewRow.Bot1_Type,
                                         Bot1_Random1:=NewRow.Bot1_Random1,
                                         Bot1_Random2:=NewRow.Bot1_Random2,
                                         Bot1_Number:=NewRow.Bot1_Number,
                                         Bot1_Chart:=NewRow.Bot1_Chart,
                                         Bot2_Type:=NewRow.Bot2_Type,
                                         Bot2_Random1:=NewRow.Bot2_Random1,
                                         Bot2_Random2:=NewRow.Bot2_Random2,
                                         Bot2_Number:=NewRow.Bot2_Number,
                                         Bot2_Chart:=NewRow.Bot2_Chart,
                                         Bot3_Type:=NewRow.Bot3_Type,
                                         Bot3_Random1:=NewRow.Bot3_Random1,
                                         Bot3_Random2:=NewRow.Bot3_Random2,
                                         Bot3_Number:=NewRow.Bot3_Number,
                                         Bot3_Chart:=NewRow.Bot3_Chart,
                                         Bot4_Type:=NewRow.Bot4_Type,
                                         Bot4_Random1:=NewRow.Bot4_Random1,
                                         Bot4_Random2:=NewRow.Bot4_Random2,
                                         Bot4_Number:=NewRow.Bot4_Number,
                                         Bot4_Chart:=NewRow.Bot4_Chart,
                                         Bot5_Type:=NewRow.Bot5_Type,
                                         Bot5_Random1:=NewRow.Bot5_Random1,
                                         Bot5_Random2:=NewRow.Bot5_Random2,
                                         Bot5_Number:=NewRow.Bot5_Number,
                                         Bot5_Chart:=NewRow.Bot5_Chart,
                                         Bot6_Type:=NewRow.Bot6_Type,
                                         Bot6_Random1:=NewRow.Bot6_Random1,
                                         Bot6_Random2:=NewRow.Bot6_Random2,
                                         Bot6_Number:=NewRow.Bot6_Number,
                                         Bot6_Chart:=NewRow.Bot6_Chart,
                                         Bot7_Type:=NewRow.Bot7_Type,
                                         Bot7_Random1:=NewRow.Bot7_Random1,
                                         Bot7_Random2:=NewRow.Bot7_Random2,
                                         Bot7_Number:=NewRow.Bot7_Number,
                                         Bot7_Chart:=NewRow.Bot7_Chart,
                                         Use_Mid_Tum:=NewRow.Use_Mid_Tum)

            Tumbler_KitTableAdapter.Update(NCLRecipeDataSet.Tumbler_Kit)
            Me.Tumbler_KitTableAdapter.Fill(Me.NCLRecipeDataSet.Tumbler_Kit)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Tumbler_KitTableAdapter.Delete(Original_Tumbler_Kit:=Tumbler_Kit_TextBox.Text,
                                            Original_Spring1_Type:=Spring_1_Type_TextBox.Text,
                                            Original_Spring1_Random1:=Spring_1_Random_1_TextBox.Text,
                                            Original_Spring1_Random2:=Spring_1_Random_2_TextBox.Text,
                                            Original_Spring1_Number:=Spring_1_Number_TextBox.Text,
                                            Original_Spring1_Chart:=Spring_1_Chart_TextBox.Text,
                                            Original_Spring2_Type:=Spring_2_Type_TextBox.Text,
                                            Original_Spring2_Random1:=Spring_2_Random_1_TextBox.Text,
                                            Original_Spring2_Random2:=Spring_2_Random_2_TextBox.Text,
                                            Original_Spring2_Number:=Spring_2_Number_TextBox.Text,
                                            Original_Spring2_Chart:=Spring_2_Chart_TextBox.Text,
                                            Original_Spring3_Type:=Spring_3_Type_TextBox.Text,
                                            Original_Spring3_Random1:=Spring_3_Random_1_TextBox.Text,
                                            Original_Spring3_Random2:=Spring_3_Random_2_TextBox.Text,
                                            Original_Spring3_Number:=Spring_3_Number_TextBox.Text,
                                            Original_Spring3_Chart:=Spring_3_Chart_TextBox.Text,
                                            Original_Spring4_Type:=Spring_4_Type_TextBox.Text,
                                            Original_Spring4_Random1:=Spring_4_Random_1_TextBox.Text,
                                            Original_Spring4_Random2:=Spring_4_Random_2_TextBox.Text,
                                            Original_Spring4_Number:=Spring_4_Number_TextBox.Text,
                                            Original_Spring4_Chart:=Spring_4_Chart_TextBox.Text,
                                            Original_Spring5_Type:=Spring_5_Type_TextBox.Text,
                                            Original_Spring5_Random1:=Spring_5_Random_1_TextBox.Text,
                                            Original_Spring5_Random2:=Spring_5_Random_2_TextBox.Text,
                                            Original_Spring5_Number:=Spring_5_Number_TextBox.Text,
                                            Original_Spring5_Chart:=Spring_5_Chart_TextBox.Text,
                                            Original_Spring6_Type:=Spring_6_Type_TextBox.Text,
                                            Original_Spring6_Random1:=Spring_6_Random_1_TextBox.Text,
                                            Original_Spring6_Random2:=Spring_6_Random_2_TextBox.Text,
                                            Original_Spring6_Number:=Spring_6_Number_TextBox.Text,
                                            Original_Spring6_Chart:=Spring_6_Chart_TextBox.Text,
                                            Original_Spring7_Type:=Spring_7_Type_TextBox.Text,
                                            Original_Spring7_Random1:=Spring_7_Random_1_TextBox.Text,
                                            Original_Spring7_Random2:=Spring_7_Random_2_TextBox.Text,
                                            Original_Spring7_Number:=Spring_7_Number_TextBox.Text,
                                            Original_Spring7_Chart:=Spring_7_Chart_TextBox.Text,
                                            Original_Top1_Type:=Top_1_Type_TextBox.Text,
                                            Original_Top1_Random1:=Top_1_Random_1_TextBox.Text,
                                            Original_Top1_Random2:=Top_1_Random_2_TextBox.Text,
                                            Original_Top1_Number:=Top_1_Number_TextBox.Text,
                                            Original_Top1_Chart:=Top_1_Chart_TextBox.Text,
                                            Original_Top2_Type:=Top_2_Type_TextBox.Text,
                                            Original_Top2_Random1:=Top_2_Random_1_TextBox.Text,
                                            Original_Top2_Random2:=Top_2_Random_2_TextBox.Text,
                                            Original_Top2_Number:=Top_2_Number_TextBox.Text,
                                            Original_Top2_Chart:=Top_2_Chart_TextBox.Text,
                                            Original_Top3_Type:=Top_3_Type_TextBox.Text,
                                            Original_Top3_Random1:=Top_3_Random_1_TextBox.Text,
                                            Original_Top3_Random2:=Top_3_Random_2_TextBox.Text,
                                            Original_Top3_Number:=Top_3_Number_TextBox.Text,
                                            Original_Top3_Chart:=Top_3_Chart_TextBox.Text,
                                            Original_Top4_Type:=Top_4_Type_TextBox.Text,
                                            Original_Top4_Random1:=Top_4_Random_1_TextBox.Text,
                                            Original_Top4_Random2:=Top_4_Random_2_TextBox.Text,
                                            Original_Top4_Number:=Top_4_Number_TextBox.Text,
                                            Original_Top4_Chart:=Top_4_Chart_TextBox.Text,
                                            Original_Top5_Type:=Top_5_Type_TextBox.Text,
                                            Original_Top5_Random1:=Top_5_Random_1_TextBox.Text,
                                            Original_Top5_Random2:=Top_5_Random_2_TextBox.Text,
                                            Original_Top5_Number:=Top_5_Number_TextBox.Text,
                                            Original_Top5_Chart:=Top_5_Chart_TextBox.Text,
                                            Original_Top6_Type:=Top_6_Type_TextBox.Text,
                                            Original_Top6_Random1:=Top_6_Random_1_TextBox.Text,
                                            Original_Top6_Random2:=Top_6_Random_2_TextBox.Text,
                                            Original_Top6_Number:=Top_6_Number_TextBox.Text,
                                            Original_Top6_Chart:=Top_6_Chart_TextBox.Text,
                                            Original_Top7_Type:=Top_7_Type_TextBox.Text,
                                            Original_Top7_Random1:=Top_7_Random_1_TextBox.Text,
                                            Original_Top7_Random2:=Top_7_Random_2_TextBox.Text,
                                            Original_Top7_Number:=Top_7_Number_TextBox.Text,
                                            Original_Top7_Chart:=Top_7_Chart_TextBox.Text,
                                            Original_Top8_Type:=Top_8_Type_TextBox.Text,
                                            Original_Top8_Random1:=Top_8_Random_1_TextBox.Text,
                                            Original_Top8_Random2:=Top_8_Random_2_TextBox.Text,
                                            Original_Top8_Number:=Top_8_Number_TextBox.Text,
                                            Original_Top8_Chart:=Top_8_Chart_TextBox.Text,
                                            Original_Mid1_Type:=Mid_1_Type_TextBox.Text,
                                            Original_Mid1_Random1:=Mid_1_Random_1_TextBox.Text,
                                            Original_Mid1_Random2:=Mid_1_Random_2_TextBox.Text,
                                            Original_Mid1_Number:=Mid_1_Number_TextBox.Text,
                                            Original_Mid1_Chart:=Mid_1_Chart_TextBox.Text,
                                            Original_Mid2_Type:=Mid_2_Type_TextBox.Text,
                                            Original_Mid2_Random1:=Mid_2_Random_1_TextBox.Text,
                                            Original_Mid2_Random2:=Mid_2_Random_2_TextBox.Text,
                                            Original_Mid2_Number:=Mid_2_Number_TextBox.Text,
                                            Original_Mid2_Chart:=Mid_2_Chart_TextBox.Text,
                                            Original_Mid3_Type:=Mid_3_Type_TextBox.Text,
                                            Original_Mid3_Random1:=Mid_3_Random_1_TextBox.Text,
                                            Original_Mid3_Random2:=Mid_3_Random_2_TextBox.Text,
                                            Original_Mid3_Number:=Mid_3_Number_TextBox.Text,
                                            Original_Mid3_Chart:=Mid_3_Chart_TextBox.Text,
                                            Original_Mid4_Type:=Mid_4_Type_TextBox.Text,
                                            Original_Mid4_Random1:=Mid_4_Random_1_TextBox.Text,
                                            Original_Mid4_Random2:=Mid_4_Random_2_TextBox.Text,
                                            Original_Mid4_Number:=Mid_4_Number_TextBox.Text,
                                            Original_Mid4_Chart:=Mid_4_Chart_TextBox.Text,
                                            Original_Mid5_Type:=Mid_5_Type_TextBox.Text,
                                            Original_Mid5_Random1:=Mid_5_Random_1_TextBox.Text,
                                            Original_Mid5_Random2:=Mid_5_Random_2_TextBox.Text,
                                            Original_Mid5_Number:=Mid_5_Number_TextBox.Text,
                                            Original_Mid5_Chart:=Mid_5_Chart_TextBox.Text,
                                            Original_Mid6_Type:=Mid_6_Type_TextBox.Text,
                                            Original_Mid6_Random1:=Mid_6_Random_1_TextBox.Text,
                                            Original_Mid6_Random2:=Mid_6_Random_2_TextBox.Text,
                                            Original_Mid6_Number:=Mid_6_Number_TextBox.Text,
                                            Original_Mid6_Chart:=Mid_6_Chart_TextBox.Text,
                                            Original_Mid7_Type:=Mid_7_Type_TextBox.Text,
                                            Original_Mid7_Random1:=Mid_7_Random_1_TextBox.Text,
                                            Original_Mid7_Random2:=Mid_7_Random_2_TextBox.Text,
                                            Original_Mid7_Number:=Mid_7_Number_TextBox.Text,
                                            Original_Mid7_Chart:=Mid_7_Chart_TextBox.Text,
                                            Original_Bot1_Type:=Bot_1_Type_TextBox.Text,
                                            Original_Bot1_Random1:=Bot_1_Random_1_TextBox.Text,
                                            Original_Bot1_Random2:=Bot_1_Random_2_TextBox.Text,
                                            Original_Bot1_Number:=Bot_1_Number_TextBox.Text,
                                            Original_Bot1_Chart:=Bot_1_Chart_TextBox.Text,
                                            Original_Bot2_Type:=Bot_2_Type_TextBox.Text,
                                            Original_Bot2_Random1:=Bot_2_Random_1_TextBox.Text,
                                            Original_Bot2_Random2:=Bot_2_Random_2_TextBox.Text,
                                            Original_Bot2_Number:=Bot_2_Number_TextBox.Text,
                                            Original_Bot2_Chart:=Bot_2_Chart_TextBox.Text,
                                            Original_Bot3_Type:=Bot_3_Type_TextBox.Text,
                                            Original_Bot3_Random1:=Bot_3_Random_1_TextBox.Text,
                                            Original_Bot3_Random2:=Bot_3_Random_2_TextBox.Text,
                                            Original_Bot3_Number:=Bot_3_Number_TextBox.Text,
                                            Original_Bot3_Chart:=Bot_3_Chart_TextBox.Text,
                                            Original_Bot4_Type:=Bot_4_Type_TextBox.Text,
                                            Original_Bot4_Random1:=Bot_4_Random_1_TextBox.Text,
                                            Original_Bot4_Random2:=Bot_4_Random_2_TextBox.Text,
                                            Original_Bot4_Number:=Bot_4_Number_TextBox.Text,
                                            Original_Bot4_Chart:=Bot_4_Chart_TextBox.Text,
                                            Original_Bot5_Type:=Bot_5_Type_TextBox.Text,
                                            Original_Bot5_Random1:=Bot_5_Random_1_TextBox.Text,
                                            Original_Bot5_Random2:=Bot_5_Random_2_TextBox.Text,
                                            Original_Bot5_Number:=Bot_5_Number_TextBox.Text,
                                            Original_Bot5_Chart:=Bot_5_Chart_TextBox.Text,
                                            Original_Bot6_Type:=Bot_6_Type_TextBox.Text,
                                            Original_Bot6_Random1:=Bot_6_Random_1_TextBox.Text,
                                            Original_Bot6_Random2:=Bot_6_Random_2_TextBox.Text,
                                            Original_Bot6_Number:=Bot_6_Number_TextBox.Text,
                                            Original_Bot6_Chart:=Bot_6_Chart_TextBox.Text,
                                            Original_Bot7_Type:=Bot_7_Type_TextBox.Text,
                                            Original_Bot7_Random1:=Bot_7_Random_1_TextBox.Text,
                                            Original_Bot7_Random2:=Bot_7_Random_2_TextBox.Text,
                                            Original_Bot7_Number:=Bot_7_Number_TextBox.Text,
                                            Original_Bot7_Chart:=Bot_7_Chart_TextBox.Text,
                                            Original_Use_Mid_Tum:=UseMidTumbler_CheckBox.Checked)


            Tumbler_KitTableAdapter.Update(NCLRecipeDataSet.Tumbler_Kit)
            Me.Tumbler_KitTableAdapter.Fill(Me.NCLRecipeDataSet.Tumbler_Kit)
        Catch ex As Exception
            MessageBox.Show("Cannot delete record")
        End Try
    End Sub

End Class