'====================================================
'Recipe Display Form
'====================================================
Option Explicit On

Imports System.Linq

Public Class RecipeDisplay_Form
    Dim caption As String = "Recipe"
    Dim msg As String = "message"

    '====================================================
    'Load Recipe Display Form
    '====================================================
    Private Sub RecipeDisplay_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '====================================================
        'Load dataset from database
        '====================================================
        Me.Knurl_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Knurl_Pin)
        Me.Drill_PinTableAdapter.Fill(Me.NCLRecipeDataSet.Drill_Pin)
        Me.ChartsTableAdapter.Fill(Me.NCLRecipeDataSet.Charts)
        Me.BushingTableAdapter.Fill(Me.NCLRecipeDataSet.Bushing)
        Me.BarrelTableAdapter.Fill(Me.NCLRecipeDataSet.Barrel)
        Me.Station_13_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_13_Tooling)
        Me.RecipeTableAdapter.Fill(Me.NCLRecipeDataSet.Recipe)

        '====================================================
        'Format datagridview
        '====================================================
        RecipeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        RecipeDataGridView.Sort(RecipeDataGridView.Columns(0), 0)

        '====================================================
        ' Recipe permissives = false
        '====================================================
        Recipe_Selected_Update(False)

        '====================================================
        ' Lookup current recipe
        '====================================================
        FindCurrentRecipe()

        '====================================================
        ' Update Recipe
        '====================================================
        UpdateRecipe()
        UpdateScreen()

        '====================================================
        ' Populate ComboBoxes with list of unique entries in database
        '====================================================
        Dim columnindex As Integer = -1
        Dim distinctitems As List(Of String)

        ' Populate Combo boxs lists with unique items from database
        For Each i In RecipeDataGridView.Columns()
            columnindex += 1

            distinctitems = (From row As DataGridViewRow In RecipeDataGridView.Rows
                             Where Not row.IsNewRow
                             Select CStr(row.Cells(columnindex).Value)).Distinct.ToList

            distinctitems.Sort()

            If columnindex = 1 Then
                LockFamily_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 2 Then
                CompanyName_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 3 Then
                ToolID_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 4 Then
                ToolID_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 9 Then
                Sta3_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 11 Then
                Sta5_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 12 Then
                Sta5_VertHt_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 13 Then
                Sta6_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 14 Then
                Sta7_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 15 Then
                Sta8_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 17 Then
                Sta9_Tool_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 18 Then
                Sta10_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 19 Then
                Sta11_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 20 Then
                Sta12_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 21 Then
                Sta13_Part_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 22 Then
                Sta13_Tool_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 24 Then
                Sta14_Tool_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 26 Then
                Sta15_InsertAngle_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 27 Then
                Sta15_TestAngle_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 28 Then
                Sta15_FinishAngle_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 29 Then
                Sta15_Tool_ComboBox.DataSource = distinctitems
            End If

            If columnindex = 30 Then
                Sta16_Part_ComboBox.DataSource = distinctitems
            End If
        Next

    End Sub

    '====================================================
    ' Event: Recipe Display Form Visibility Changed
    '====================================================
    Private Sub RecipeDisplay_Form_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible = True Then

        End If
    End Sub

    '====================================================
    ' Event: Recipe Display Form Shown
    '====================================================
    Private Sub RecipeDisplay_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'System.Windows.Forms.Application.DoEvents()
        'Threading.Thread.Sleep(5)
    End Sub

    '====================================================
    'Lookup current Recipe Name
    '====================================================
    Private Sub FindCurrentRecipe()
        Dim rowindex As Integer
        For Each row As DataGridViewRow In RecipeDataGridView.Rows
            If row.Cells(0).Value = My.Settings.Recipe_Name Then
                rowindex = row.Index
                'RecipeDataGridView.Rows(rowindex).Selected = True
                RecipeBindingSource.Position = rowindex
            End If
        Next

        ' Update database
        RecipeTableAdapter.Update(NCLRecipeDataSet.Recipe)

        ' tells the control that data is changed
        RecipeBindingSource.ResetBindings(False)

        ' Update if valid database row is found
        If rowindex >= 0 Then
            RecipeName_ComboBox.Text = My.Settings.Recipe_Name
        Else
            RecipeName_ComboBox.Text = My.Settings.Recipe_Name & "- None Selected"
        End If
    End Sub

    '====================================================
    ' Update on selection of new Recipe Name 
    '====================================================
    Private Sub Select_Recipe_Button_Click(sender As Object, e As EventArgs) Handles Select_Recipe_Button.Click
        ' Loading New recipe: clear data sent flags
        Recipe_Selected_Update(False)

        ' update recipe
        UpdateRecipe()

        UpdateScreen()
    End Sub

    '====================================================
    'Update Recipe with values from Recipe Name
    '====================================================
    Public Sub UpdateRecipe()
        caption = "Update Recipe"
        msg = ""

        Wait_Message_Form.Text = "Recipe Update"
        Wait_Message_Form.Message_TextBox.Text = "Updating Recipe." & vbCrLf & "Please wait ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Update global variables
        ' Get Recipe Name
        GlobalVariables.R_Recipe_Name = RecipeName_ComboBox.Text

        ' Lookup Recipe Values
        Try
            GlobalVariables.R_Lock_Family = RecipeTableAdapter.GetLockFamily(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Company_Name = RecipeTableAdapter.GetCompanyName(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Date = RecipeTableAdapter.GetDate(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Tool_ID = RecipeTableAdapter.GetToolID(GlobalVariables.R_Recipe_Name)

            ' Update Station 1 ============================================================
            GlobalVariables.R_Sta_1_Load_Keys = RecipeTableAdapter.GetLoadKeys(GlobalVariables.R_Recipe_Name)

            GlobalVariables.R_Sta_1_Keyed = RecipeTableAdapter.GetSta1Keyed(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_1_Unload = RecipeTableAdapter.GetSta1Unload(GlobalVariables.R_Recipe_Name)
            ' Update Station 2 ============================================================
            GlobalVariables.R_Sta_2_Enable = RecipeTableAdapter.GetSta2Enable(GlobalVariables.R_Recipe_Name)

            ' Update Station 3 ============================================================
            GlobalVariables.R_Sta_3_Part_Number = RecipeTableAdapter.GetSta3Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_3_Part_Number.ToUpper = "NONE" Then
                GlobalVariables.R_Sta_3_Enable = "0"
            Else
                GlobalVariables.R_Sta_3_Enable = "1"
            End If

            ' Update Bushing Values
            If R_Sta_3_Part_Number.ToUpper = "NONE" Then
                GlobalVariables.R_Bushing_ToolingCode = "NONE"
                GlobalVariables.R_Sta_3_Enable = "0"
            Else
                GlobalVariables.R_Bushing_ToolingCode = BushingTableAdapter.GetToolingCode(R_Sta_3_Part_Number)
                GlobalVariables.R_Sta_3_Enable = "1"
            End If

            ' Update Station 4 ============================================================
            GlobalVariables.R_Sta_4_Enable = RecipeTableAdapter.GetSta4Enable(GlobalVariables.R_Recipe_Name)


            ' Update Station 5 ============================================================
            GlobalVariables.R_Sta_5_Part_Number = RecipeTableAdapter.GetSta5Part(GlobalVariables.R_Recipe_Name)
            If R_Sta_5_Part_Number.ToUpper = "NONE" Then
                R_Sta_5_Enable = "0"
                GlobalVariables.R_Sta_5_Enable = "0"
            Else
                R_Sta_5_Enable = "1"
                GlobalVariables.R_Sta_5_Enable = "1"
            End If

            GlobalVariables.R_Sta_5_Vert_Height = RecipeTableAdapter.GetSta5VertHt(GlobalVariables.R_Recipe_Name)

            ' Update Station 6 ============================================================
            GlobalVariables.R_Sta_6_Part_Number = RecipeTableAdapter.GetSta6Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_6_Part_Number.ToUpper = "NONE" Then
                R_Sta_6_Enable = "0"
            Else
                R_Sta_6_Enable = "1"
            End If

            ' Update Station 7 ============================================================
            GlobalVariables.R_Sta_7_Part_Number = RecipeTableAdapter.GetSta7Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_7_Part_Number.ToUpper = "NONE" Then
                R_Sta_7_Enable = "0"
            Else
                R_Sta_7_Enable = "1"
            End If

            ' Update Station 8 ============================================================
            GlobalVariables.R_Sta_8_Part_Number = RecipeTableAdapter.GetSta8Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_8_Part_Number.ToUpper = "NONE" Then
                R_Sta_8_Enable = "0"
            Else
                R_Sta_8_Enable = "1"
            End If

            ' Update Station 9 ============================================================
            GlobalVariables.R_Sta_9_Enable = RecipeTableAdapter.GetSta9Enable(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_9_Tool = RecipeTableAdapter.GetSta9Tool(GlobalVariables.R_Recipe_Name)

            ' Update Station 10 ============================================================
            GlobalVariables.R_Sta_10_Part_Number = RecipeTableAdapter.GetSta10Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_10_Part_Number.ToUpper = "NONE" Then
                R_Sta_10_Enable = "0"
            Else
                R_Sta_10_Enable = "1"
            End If

            ' Update Station 11 ============================================================
            GlobalVariables.R_Sta_11_Part_Number = RecipeTableAdapter.GetSta11Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_11_Part_Number.ToUpper = "NONE" Then
                R_Sta_11_Enable = "0"
            Else
                R_Sta_11_Enable = "1"
            End If

            ' Update Station 12 ============================================================
            GlobalVariables.R_Sta_12_Part_Number = RecipeTableAdapter.GetSta12Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_12_Part_Number.ToUpper = "NONE" Then
                R_Sta_12_Enable = "0"
            Else
                R_Sta_12_Enable = "1"
            End If

            ' Update Station 13 ============================================================
            GlobalVariables.R_Sta_13_Part_Number = RecipeTableAdapter.GetSta13Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_13_Part_Number.ToUpper = "NONE" Then
                R_Sta_13_Enable = "0"
            Else
                R_Sta_13_Enable = "1"
            End If

            GlobalVariables.R_Sta_13_Tool = RecipeTableAdapter.GetSta13Tool(GlobalVariables.R_Recipe_Name)
            If R_Sta_13_Part_Number.ToUpper = "NONE" Then
                ' Update Barrel Parts
                GlobalVariables.R_Barrel_Bowl = "NONE"
                GlobalVariables.R_Barrel_Orient = "NONE"

                ' Update Station 13 Tooling values
                GlobalVariables.R_Sta_13_Gripper = "NONE"
                GlobalVariables.R_Sta_13_Orient = "NONE"
                GlobalVariables.R_Sta_13_Shotpin = "NONE"
                GlobalVariables.R_Sta_13_Place = "NONE"
                GlobalVariables.R_Sta_13_ReClockPos = "NONE"
                GlobalVariables.R_Sta_13_ReClockRot = "NONE"
            Else
                ' Update Barrel Parts
                GlobalVariables.R_Barrel_Bowl = BarrelTableAdapter.GetBowl(R_Sta_13_Part_Number)
                GlobalVariables.R_Barrel_Orient = BarrelTableAdapter.GetMarkOrient(R_Sta_13_Part_Number)

                ' Update Station 13 Tooling values
                GlobalVariables.R_Sta_13_Gripper = Station_13_ToolingTableAdapter.GetGripper(R_Sta_13_Tool)
                GlobalVariables.R_Sta_13_Orient = Station_13_ToolingTableAdapter.GetOrient(R_Sta_13_Tool)
                GlobalVariables.R_Sta_13_Shotpin = Station_13_ToolingTableAdapter.GetOrient(R_Sta_13_Tool)
                GlobalVariables.R_Sta_13_Place = Station_13_ToolingTableAdapter.GetPlace(R_Sta_13_Tool)
                GlobalVariables.R_Sta_13_ReClockPos = Station_13_ToolingTableAdapter.GetReClockPos(R_Sta_13_Tool)
                GlobalVariables.R_Sta_13_ReClockRot = Station_13_ToolingTableAdapter.GetReClockRot(R_Sta_13_Tool)
            End If

            ' Update Station 14 ============================================================
            GlobalVariables.R_Sta_14_Enable = RecipeTableAdapter.GetSta14Enable(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_14_Tool = RecipeTableAdapter.GetSta10Part(GlobalVariables.R_Recipe_Name)

            ' Update Station 15 ============================================================
            GlobalVariables.R_Sta_15_Enable = RecipeTableAdapter.GetSta15Enable(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_15_Insert_Angle = RecipeTableAdapter.GetSta15InsertAngle(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_15_Test_Angle = RecipeTableAdapter.GetSta15TestAngle(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_15_Finish_Angle = RecipeTableAdapter.GetSta15FinishAngle(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_15_Tool = RecipeTableAdapter.GetSta15Tool(GlobalVariables.R_Recipe_Name)
            GlobalVariables.R_Sta_15_Tool = RecipeTableAdapter.GetSta15Tool(GlobalVariables.R_Recipe_Name)

            'If Insert and Finish angle are different  = Leave Key In
            If (GlobalVariables.R_Sta_15_Insert_Angle = GlobalVariables.R_Sta_15_Finish_Angle) Then
                R_Sta_15_Leave_Key_In_After_Test = "1"
            Else
                R_Sta_15_Leave_Key_In_After_Test = "1"
            End If

            ' Update Station 16 ============================================================
            GlobalVariables.R_Sta_16_Part_Number = RecipeTableAdapter.GetSta16Part(GlobalVariables.R_Recipe_Name)

            If R_Sta_16_Part_Number.ToUpper = "NONE" Then
                GlobalVariables.R_Sta_16_Enable = "0"
            Else
                GlobalVariables.R_Sta_16_Enable = "1"
            End If

            GlobalVariables.R_Sta_16_Back_Support = RecipeTableAdapter.GetSta16BackSupport(GlobalVariables.R_Recipe_Name)

            ' Update Knurl Pin Values
            If R_Sta_16_Part_Number.ToUpper = "NONE" Then
                GlobalVariables.R_KnurlPin_ToolingCode = "NONE"
                GlobalVariables.R_KnurlPin_Bowl = "NONE"
            Else
                GlobalVariables.R_KnurlPin_ToolingCode = Knurl_PinTableAdapter.GetToolingCode(R_Sta_16_Part_Number)
                GlobalVariables.R_KnurlPin_Bowl = Knurl_PinTableAdapter.GetBowl(R_Sta_16_Part_Number)

            End If

            ' Update Station 17 ============================================================
            GlobalVariables.R_Sta_17_Enable = RecipeTableAdapter.GetSta17Enable(GlobalVariables.R_Recipe_Name)

            Recipe_Selected_Update(True)
        Catch ex As Exception
            caption = "Recipe Update"
            msg = "Error reading from Database" & vbCrLf & ex.Message
            MessageBox.Show(msg,
                            caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk)
            Recipe_Selected_Update(False)
        End Try

        Wait_Message_Form.Close()
    End Sub

    '====================================================
    'Update Recipe Screen after update
    '====================================================
    Public Sub UpdateScreen()
        Wait_Message_Form.Message_TextBox.Text = "Updating ..."
        Wait_Message_Form.Show()
        Wait_Message_Form.Refresh()

        ' Update screen
        LockFamily_ComboBox.Text = R_Lock_Family
        CompanyName_ComboBox.Text = R_Company_Name
        ToolID_ComboBox.Text = R_Tool_ID
        CreationDate.Value = R_Date

        LoadKeys_Yes_RadioButton.Checked = (R_Sta_1_Load_Keys = "1")
        LoadKeys_No_RadioButton.Checked = (R_Sta_1_Load_Keys = "0")
        LoadKeys_Single_RadioButton.Checked = (R_Sta_1_Load_Keys = "2")

        KeyAlike_Yes_RadioButton.Checked = (R_Sta_1_Keyed = "1")
        KeyAlike_No_RadioButton.Checked = Not KeyAlike_Yes_RadioButton.Checked

        AutoLoad_RadioButton.Checked = (R_Sta_1_Unload = "1")
        ManualLoad_RadioButton.Checked = Not (R_Sta_1_Unload = "1")

        Sta2_Enable_RadioButton.Checked = (R_Sta_2_Enable = "1")
        Sta2_Disable_RadioButton.Checked = Not (R_Sta_2_Enable = "1")

        Sta3_Enable_RadioButton.Checked = (R_Sta_3_Enable = "1")
        Sta3_Part_ComboBox.Text = R_Sta_3_Part_Number

        Sta4_Enable_RadioButton.Checked = (R_Sta_4_Enable = "1")
        Sta4_Disable_RadioButton.Checked = Not (R_Sta_4_Enable = "1")

        Sta5_Enable_RadioButton.Checked = (R_Sta_5_Enable = "1")
        Sta5_Disable_RadioButton.Checked = Not (R_Sta_5_Enable = "1")

        Sta5_Part_ComboBox.Text = R_Sta_5_Part_Number
        Sta5_VertHt_ComboBox.Text = R_Sta_5_Vert_Height

        Sta6_Part_ComboBox.Text = R_Sta_6_Part_Number
        Sta6_Enable_RadioButton.Checked = (R_Sta_6_Enable = "1")
        Sta6_Disable_RadioButton.Checked = Not (R_Sta_6_Enable = "1")

        Sta7_Part_ComboBox.Text = R_Sta_7_Part_Number
        Sta7_Enable_RadioButton.Checked = (R_Sta_7_Enable = "1")
        Sta7_Disable_RadioButton.Checked = Not (R_Sta_7_Enable = "1")

        Sta8_Part_ComboBox.Text = R_Sta_8_Part_Number
        Sta8_Enable_RadioButton.Checked = (R_Sta_8_Enable = "1")
        Sta8_Disable_RadioButton.Checked = Not (R_Sta_8_Enable = "1")

        Sta9_Tool_ComboBox.Text = R_Sta_9_Tool
        Sta9_Enable_RadioButton.Checked = (R_Sta_9_Enable = "1")
        Sta9_Disable_RadioButton.Checked = Not (R_Sta_9_Enable = "1")

        Sta10_Part_ComboBox.Text = R_Sta_10_Part_Number
        Sta10_Enable_RadioButton.Checked = (R_Sta_10_Enable = "1")
        Sta10_Disable_RadioButton.Checked = Not (R_Sta_10_Enable = "1")

        Sta11_Part_ComboBox.Text = R_Sta_11_Part_Number
        Sta11_Enable_RadioButton.Checked = (R_Sta_11_Enable = "1")
        Sta11_Disable_RadioButton.Checked = Not (R_Sta_11_Enable = "1")

        Sta12_Part_ComboBox.Text = R_Sta_12_Part_Number
        Sta12_Enable_RadioButton.Checked = (R_Sta_12_Enable = "1")
        Sta12_Disable_RadioButton.Checked = Not (R_Sta_12_Enable = "1")

        Sta13_Part_ComboBox.Text = R_Sta_13_Part_Number
        Sta13_Enable_RadioButton.Checked = (R_Sta_13_Enable = "1")
        Sta13_Disable_RadioButton.Checked = Not (R_Sta_13_Enable = "1")

        Sta13_Tool_ComboBox.Text = R_Sta_14_Tool
        Sta14_Enable_RadioButton.Checked = (R_Sta_14_Enable = "1")
        Sta14_Disable_RadioButton.Checked = Not (R_Sta_14_Enable = "1")

        Sta14_Enable_RadioButton.Checked = (R_Sta_14_Enable = "1")
        Sta14_Tool_ComboBox.Text = R_Sta_14_Tool

        Sta15_Enable_RadioButton.Checked = (R_Sta_15_Enable = "1")
        Sta15_InsertAngle_ComboBox.Text = R_Sta_15_Insert_Angle
        Sta15_TestAngle_ComboBox.Text = R_Sta_15_Test_Angle
        Sta15_FinishAngle_ComboBox.Text = R_Sta_15_Finish_Angle
        Sta15_Tool_ComboBox.Text = R_Sta_15_Tool

        Sta16_Enable_RadioButton.Checked = (R_Sta_16_Enable = "1")
        Sta16_Disable_RadioButton.Checked = Not (R_Sta_16_Enable = "1")
        Sta16_Part_ComboBox.Text = R_Sta_16_Part_Number

        Sta16_BackSupport_CheckBox.Checked = (R_Sta_16_Back_Support = "1")

        Sta17_Enable_RadioButton.Checked = (R_Sta_17_Enable = "1")
        Sta17_Disable_RadioButton.Checked = Not (R_Sta_17_Enable = "1")

        ' Station 13 data
        Sta13_Gripper_TextBox.Text = R_Sta_13_Gripper
        Sta13_Orient_TextBox.Text = R_Sta_13_Orient
        Sta13_Shotpin_TextBox.Text = R_Sta_13_Shotpin
        Sta13_Place_TextBox.Text = R_Sta_13_Place
        Sta13_ReclockPos_TextBox.Text = R_Sta_13_ReClockPos
        Sta13_ReClockRot_TextBox.Text = R_Sta_13_ReClockRot

        Barrel_Bowl_TextBox.Text = R_Barrel_Bowl
        Barrel_Orient_TextBox.Text = R_Barrel_Orient

        Sta3_ToolingCode_TextBox.Text = R_Bushing_ToolingCode

        KnurlPin_Bowl_TextBox.Text = R_KnurlPin_Bowl
        KnurlPin_ToolingCode_TextBox.Text = R_KnurlPin_ToolingCode

        '' Spring & Tumbler Bowls =================================================
        'Spring1_Bowl_TextBox.Text = R_Spring1_Bowl
        'Spring2_Bowl_TextBox.Text = R_Spring2_Bowl
        'Spring3_Bowl_TextBox.Text = R_Spring3_Bowl
        'Spring4_Bowl_TextBox.Text = R_Spring4_Bowl
        'Spring5_Bowl_TextBox.Text = R_Spring5_Bowl
        'Spring6_Bowl_TextBox.Text = R_Spring6_Bowl
        'Spring7_Bowl_TextBox.Text = R_Spring7_Bowl
        'Spring8_Bowl_TextBox.Text = R_Spring8_Bowl

        'Top1_Bowl_TextBox.Text = R_Top1_Bowl
        'Top2_Bowl_TextBox.Text = R_Top2_Bowl
        'Top3_Bowl_TextBox.Text = R_Top3_Bowl
        'Top4_Bowl_TextBox.Text = R_Top4_Bowl
        'Top5_Bowl_TextBox.Text = R_Top5_Bowl
        'Top6_Bowl_TextBox.Text = R_Top6_Bowl
        'Top7_Bowl_TextBox.Text = R_Top7_Bowl
        'Top8_Bowl_TextBox.Text = R_Top8_Bowl

        'Mid1_Bowl_TextBox.Text = R_Mid1_Bowl
        'Mid2_Bowl_TextBox.Text = R_Mid2_Bowl
        'Mid3_Bowl_TextBox.Text = R_Mid3_Bowl
        'Mid4_Bowl_TextBox.Text = R_Mid4_Bowl
        'Mid5_Bowl_TextBox.Text = R_Mid5_Bowl
        'Mid6_Bowl_TextBox.Text = R_Mid6_Bowl
        'Mid7_Bowl_TextBox.Text = R_Mid7_Bowl
        'Mid8_Bowl_TextBox.Text = R_Mid8_Bowl

        'Bot1_Bowl_TextBox.Text = R_Bot1_Bowl
        'Bot2_Bowl_TextBox.Text = R_Bot2_Bowl
        'Bot3_Bowl_TextBox.Text = R_Bot3_Bowl
        'Bot4_Bowl_TextBox.Text = R_Bot4_Bowl
        'Bot5_Bowl_TextBox.Text = R_Bot5_Bowl
        'Bot6_Bowl_TextBox.Text = R_Bot6_Bowl
        'Bot7_Bowl_TextBox.Text = R_Bot7_Bowl
        'Bot8_Bowl_TextBox.Text = R_Bot8_Bowl

        'Bot1_Stepped_TextBox.Text = R_Bot1_Stepped
        'Bot2_Stepped_TextBox.Text = R_Bot2_Stepped
        'Bot3_Stepped_TextBox.Text = R_Bot3_Stepped
        'Bot4_Stepped_TextBox.Text = R_Bot4_Stepped
        'Bot5_Stepped_TextBox.Text = R_Bot5_Stepped
        'Bot6_Stepped_TextBox.Text = R_Bot6_Stepped
        'Bot7_Stepped_TextBox.Text = R_Bot7_Stepped
        'Bot8_Stepped_TextBox.Text = R_Bot8_Stepped

        SaveSettings()
        Wait_Message_Form.Close()
    End Sub

    Private Sub Update_Database_Button_Click(sender As Object, e As EventArgs) Handles Update_Database_Button.Click
        Try
            ' Update database
            RecipeTableAdapter.Update(NCLRecipeDataSet.Recipe)
            ' Reload database
            Me.RecipeTableAdapter.Fill(Me.NCLRecipeDataSet.Recipe)

        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try

        Me.Update()

        FindCurrentRecipe()
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.RecipeRow
        NewRow = Me.NCLRecipeDataSet.Recipe.NewRow()

        NewRow.Recipe_Name = RecipeName_ComboBox.Text
        NewRow.Lock_Family = LockFamily_ComboBox.Text
        NewRow.Company_Name = CompanyName_ComboBox.Text
        NewRow._Date = CreationDate.Value
        NewRow.Tool_Id = ToolID_ComboBox.Text

        'NewRow.Sta1_Keyed = Sta1_Keyed_ComboBox.Text
        If (KeyAlike_Yes_RadioButton.Checked = "True") Then
            NewRow.Sta1_Keyed = 1
        Else
            NewRow.Sta1_Keyed = 0
        End If

        'NewRow.Sta1_Load_Keys = Sta1_LoadKeys_ComboBox.Text
        If (LoadKeys_Yes_RadioButton.Checked = "True") Then
            NewRow.Sta1_Unload = 1
        Else
            NewRow.Sta1_Unload = 0
        End If

        'NewRow.Sta1_Unload = Sta1_Unload_ComboBox.Text
        If (AutoLoad_RadioButton.Checked = "True") Then
            NewRow.Sta1_Load_Keys = 1
        Else
            NewRow.Sta1_Load_Keys = 0
        End If

        'NewRow.Sta2_Enable = Sta2_Enable_ComboBox.Text
        If (Sta2_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta2_Enable = 1
        Else
            NewRow.Sta2_Enable = 0
        End If

        NewRow._Sta3_Part_ = Sta3_Part_ComboBox.Text

        'NewRow.Sta4_Enable = Sta4_Enable_ComboBox.Text
        If (Sta4_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta4_Enable = 1
        Else
            NewRow.Sta4_Enable = 0
        End If

        NewRow._Sta5_Part_ = Sta5_Part_ComboBox.Text
        NewRow.Sta5_Vert_Height = Sta5_VertHt_ComboBox.Text

        NewRow._Sta6_Part_ = Sta6_Part_ComboBox.Text
        NewRow._Sta7_Part_ = Sta7_Part_ComboBox.Text
        NewRow._Sta8_Part_ = Sta8_Part_ComboBox.Text

        'NewRow.Sta9_Enable = Sta9_Enable_ComboBox.Text
        If (Sta9_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta9_Enable = 1
        Else
            NewRow.Sta9_Enable = 0
        End If

        NewRow.Sta9_Tool = Sta9_Tool_ComboBox.Text
        NewRow._Sta10_Part_ = Sta10_Part_ComboBox.Text
        NewRow._Sta11_Part_ = Sta11_Part_ComboBox.Text
        NewRow._Sta12_Part_ = Sta12_Part_ComboBox.Text
        NewRow._Sta13_Part_ = Sta13_Part_ComboBox.Text
        NewRow.Sta13_Tool = Sta13_Tool_ComboBox.Text

        'NewRow.Sta14_Enable = Sta14_Enable_ComboBox.Text
        If (Sta14_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta14_Enable = 1
        Else
            NewRow.Sta14_Enable = 0
        End If

        NewRow.Sta14_Tool = Sta14_Tool_ComboBox.Text

        'NewRow.Sta15_Enable = Sta15_Enable_ComboBox.Text
        If (Sta15_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta15_Enable = 1
        Else
            NewRow.Sta15_Enable = 0
        End If

        NewRow.Sta15_Insert_Angle = Sta15_InsertAngle_ComboBox.Text
        NewRow.Sta15_Test_Angle = Sta15_TestAngle_ComboBox.Text
        NewRow.Sta15_Finish_Angle = Sta15_FinishAngle_ComboBox.Text
        NewRow.Sta15_Tool = Sta15_Tool_ComboBox.Text
        NewRow._Sta16_Part_ = Sta16_Part_ComboBox.Text

        If Sta16_BackSupport_CheckBox.Checked = True Then
            NewRow.Sta16_BackSupport = "1"
        Else
            NewRow.Sta16_BackSupport = "0"
        End If

        If (Sta17_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta17_Enable = 1
        Else
            NewRow.Sta17_Enable = 0
        End If

        Try
            RecipeTableAdapter.Insert(Recipe_Name:=NewRow.Recipe_Name,
                                        Lock_Family:=NewRow.Lock_Family,
                                        Company_Name:=NewRow.Company_Name,
                                        _Date:=NewRow._Date,
                                        Tool_Id:=NewRow.Tool_Id,
                                        Sta1_Load_Keys:=NewRow.Sta1_Load_Keys,
                                        Sta1_Unload:=NewRow.Sta1_Unload,
                                        Sta1_Keyed:=NewRow.Sta1_Keyed,
                                        Sta2_Enable:=NewRow.Sta2_Enable,
                                        _Sta3_Part_:=NewRow._Sta3_Part_,
                                        Sta4_Enable:=NewRow.Sta4_Enable,
                                        _Sta5_Part_:=NewRow._Sta5_Part_,
                                        Sta5_Vert_Height:=NewRow.Sta5_Vert_Height,
                                        _Sta6_Part_:=NewRow._Sta6_Part_,
                                        _Sta7_Part_:=NewRow._Sta7_Part_,
                                        _Sta8_Part_:=NewRow._Sta8_Part_,
                                        Sta9_Enable:=NewRow.Sta9_Enable,
                                        Sta9_Tool:=NewRow.Sta9_Tool,
                                        _Sta10_Part_:=NewRow._Sta10_Part_,
                                        _Sta11_Part_:=NewRow._Sta11_Part_,
                                        _Sta12_Part_:=NewRow._Sta12_Part_,
                                        _Sta13_Part_:=NewRow._Sta13_Part_,
                                        Sta13_Tool:=NewRow.Sta13_Tool,
                                        Sta14_Enable:=NewRow.Sta14_Enable,
                                        Sta14_Tool:=NewRow.Sta14_Tool,
                                        Sta15_Enable:=NewRow.Sta15_Enable,
                                        Sta15_Insert_Angle:=NewRow.Sta15_Insert_Angle,
                                        Sta15_Test_Angle:=NewRow.Sta15_Test_Angle,
                                        Sta15_Finish_Angle:=NewRow.Sta15_Finish_Angle,
                                        Sta15_Tool:=NewRow.Sta15_Tool,
                                        _Sta16_Part_:=NewRow._Sta16_Part_,
                                        Sta16_BackSupport:=NewRow.Sta16_BackSupport,
                                        Sta17_Enable:=NewRow.Sta17_Enable)
            ' Update database
            RecipeTableAdapter.Update(NCLRecipeDataSet.Recipe)
            ' Reload database
            Me.RecipeTableAdapter.Fill(Me.NCLRecipeDataSet.Recipe)

        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub
    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Dim NewRow As NCLRecipeDataSet.RecipeRow
        NewRow = Me.NCLRecipeDataSet.Recipe.NewRow()

        NewRow.Recipe_Name = RecipeName_ComboBox.Text
        NewRow.Lock_Family = LockFamily_ComboBox.Text
        NewRow.Company_Name = CompanyName_ComboBox.Text
        NewRow._Date = CreationDate.Value
        NewRow.Tool_Id = ToolID_ComboBox.Text

        'NewRow.Sta1_Keyed = Sta1_Keyed_ComboBox.Text
        If (KeyAlike_Yes_RadioButton.Checked = "True") Then
            NewRow.Sta1_Keyed = 1
        Else
            NewRow.Sta1_Keyed = 0
        End If

        'NewRow.Sta1_Load_Keys = Sta1_LoadKeys_ComboBox.Text
        If (LoadKeys_Yes_RadioButton.Checked = "True") Then
            NewRow.Sta1_Unload = 1
        Else
            NewRow.Sta1_Unload = 0
        End If

        'NewRow.Sta1_Unload = Sta1_Unload_ComboBox.Text
        If (AutoLoad_RadioButton.Checked = "True") Then
            NewRow.Sta1_Load_Keys = 1
        Else
            NewRow.Sta1_Load_Keys = 0
        End If

        'NewRow.Sta2_Enable = Sta2_Enable_ComboBox.Text
        If (Sta2_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta2_Enable = 1
        Else
            NewRow.Sta2_Enable = 0
        End If

        NewRow._Sta3_Part_ = Sta3_Part_ComboBox.Text

        'NewRow.Sta4_Enable = Sta4_Enable_ComboBox.Text
        If (Sta4_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta4_Enable = 1
        Else
            NewRow.Sta4_Enable = 0
        End If

        NewRow._Sta5_Part_ = Sta5_Part_ComboBox.Text

        NewRow.Sta5_Vert_Height = Sta5_Part_ComboBox.Text
        NewRow._Sta6_Part_ = Sta6_Part_ComboBox.Text
        NewRow._Sta7_Part_ = Sta7_Part_ComboBox.Text
        NewRow._Sta8_Part_ = Sta8_Part_ComboBox.Text

        'NewRow.Sta9_Enable = Sta9_Enable_ComboBox.Text
        If (Sta9_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta9_Enable = 1
        Else
            NewRow.Sta9_Enable = 0
        End If

        NewRow.Sta9_Tool = Sta9_Tool_ComboBox.Text
        NewRow._Sta10_Part_ = Sta10_Part_ComboBox.Text
        NewRow._Sta11_Part_ = Sta11_Part_ComboBox.Text
        NewRow._Sta12_Part_ = Sta12_Part_ComboBox.Text
        NewRow._Sta13_Part_ = Sta13_Part_ComboBox.Text
        NewRow.Sta13_Tool = Sta13_Tool_ComboBox.Text

        'NewRow.Sta14_Enable = Sta14_Enable_ComboBox.Text
        If (Sta14_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta14_Enable = 1
        Else
            NewRow.Sta14_Enable = 0
        End If

        NewRow.Sta14_Tool = Sta14_Tool_ComboBox.Text

        'NewRow.Sta15_Enable = Sta15_Enable_ComboBox.Text
        If (Sta15_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta15_Enable = 1
        Else
            NewRow.Sta15_Enable = 0
        End If

        NewRow.Sta15_Insert_Angle = Sta15_InsertAngle_ComboBox.Text
        NewRow.Sta15_Test_Angle = Sta15_TestAngle_ComboBox.Text
        NewRow.Sta15_Finish_Angle = Sta15_FinishAngle_ComboBox.Text
        NewRow.Sta15_Tool = Sta15_Tool_ComboBox.Text
        NewRow._Sta16_Part_ = Sta16_Part_ComboBox.Text

        If Sta16_BackSupport_CheckBox.Checked = True Then
            NewRow.Sta16_BackSupport = "1"
        Else
            NewRow.Sta16_BackSupport = "0"
        End If

        'NewRow.Sta17_Enable = Sta17_Enable_ComboBox.Text
        If (Sta17_Enable_RadioButton.Checked = "True") Then
            NewRow.Sta17_Enable = 1
        Else
            NewRow.Sta17_Enable = 0
        End If
        Try
            RecipeTableAdapter.Delete(Original_Recipe_Name:=NewRow.Recipe_Name,
                                        Original_Lock_Family:=NewRow.Lock_Family,
                                        Original_Company_Name:=NewRow.Company_Name,
                                        Original_Date:=NewRow._Date,
                                        Original_Tool_Id:=NewRow.Tool_Id,
                                        Original_Sta1_Load_Keys:=NewRow.Sta1_Load_Keys,
                                        Original_Sta1_Unload:=NewRow.Sta1_Unload,
                                        Original_Sta1_Keyed:=NewRow.Sta1_Keyed,
                                        Original_Sta2_Enable:=NewRow.Sta2_Enable,
                                        _Original_Sta3_Part_:=NewRow._Sta3_Part_,
                                        Original_Sta4_Enable:=NewRow.Sta4_Enable,
                                        _Original_Sta5_Part_:=NewRow._Sta5_Part_,
                                        Original_Sta5_Vert_Height:=NewRow.Sta5_Vert_Height,
                                        _Original_Sta6_Part_:=NewRow._Sta6_Part_,
                                        _Original_Sta7_Part_:=NewRow._Sta7_Part_,
                                        _Original_Sta8_Part_:=NewRow._Sta8_Part_,
                                        Original_Sta9_Enable:=NewRow.Sta9_Enable,
                                        Original_Sta9_Tool:=NewRow.Sta9_Tool,
                                        _Original_Sta10_Part_:=NewRow._Sta10_Part_,
                                        _Original_Sta11_Part_:=NewRow._Sta11_Part_,
                                        _Original_Sta12_Part_:=NewRow._Sta12_Part_,
                                        _Original_Sta13_Part_:=NewRow._Sta13_Part_,
                                        Original_Sta13_Tool:=NewRow.Sta13_Tool,
                                        Original_Sta14_Enable:=NewRow.Sta14_Enable,
                                        Original_Sta14_Tool:=NewRow.Sta14_Tool,
                                        Original_Sta15_Enable:=NewRow.Sta15_Enable,
                                        Original_Sta15_Insert_Angle:=NewRow.Sta15_Insert_Angle,
                                        Original_Sta15_Test_Angle:=NewRow.Sta15_Test_Angle,
                                        Original_Sta15_Finish_Angle:=NewRow.Sta15_Finish_Angle,
                                        Original_Sta15_Tool:=NewRow.Sta15_Tool,
                                        _Original_Sta16_Part_:=NewRow._Sta16_Part_,
                                        Original_Sta16_BackSupport:=NewRow.Sta16_BackSupport,
                                        Original_Sta17_Enable:=NewRow.Sta17_Enable)
            ' Update database
            RecipeTableAdapter.Update(NCLRecipeDataSet.Recipe)
            ' Reload database
            Me.RecipeTableAdapter.Fill(Me.NCLRecipeDataSet.Recipe)

        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Close_Form_Button_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' ============================================================
    ' Save Recipe Settings
    ' ============================================================
    Public Sub SaveSettings()
        ' Update settings
        My.Settings.Recipe_Name = GlobalVariables.R_Recipe_Name
        My.Settings.Lock_Family = GlobalVariables.R_Lock_Family
        My.Settings.Company_Name = GlobalVariables.R_Company_Name
        My.Settings.R_Date = GlobalVariables.R_Date
        My.Settings.Tool_ID = GlobalVariables.R_Tool_ID

        'Load Keys On Pallet With Lock (0=Do Not Load Keys, 1=Load Keys For Each Pallet, 2=Load A Single Master Key)
        If GlobalVariables.R_Sta_1_Load_Keys = "1" Then
            My.Settings.Sta_1_Load_Keys = "1"
        Else
            My.Settings.Sta_1_Load_Keys = "0"
        End If

        If GlobalVariables.R_Sta_1_Load_Keys = "2" Then
            My.Settings.Master_Key_Scenario = "1"
        Else
            My.Settings.Master_Key_Scenario = "0"
        End If

        My.Settings.Sta_1_Keyed = GlobalVariables.R_Sta_1_Keyed
        My.Settings.Sta_1_Unload = GlobalVariables.R_Sta_1_Unload
        My.Settings.Sta_2_Enable = GlobalVariables.R_Sta_2_Enable
        My.Settings.Sta_3_Enable = GlobalVariables.R_Sta_3_Enable
        My.Settings.Sta_3_Part_Number = GlobalVariables.R_Sta_3_Part_Number
        My.Settings.Sta_4_Enable = GlobalVariables.R_Sta_4_Enable
        My.Settings.Sta_5_Enable = GlobalVariables.R_Sta_5_Enable
        My.Settings.Sta_5_Part_Number = GlobalVariables.R_Sta_5_Part_Number
        My.Settings.Sta_5_Vert_Height = GlobalVariables.R_Sta_5_Vert_Height
        My.Settings.Sta_6_Enable = GlobalVariables.R_Sta_6_Enable
        My.Settings.Sta_6_Part_Number = GlobalVariables.R_Sta_6_Part_Number
        My.Settings.Sta_7_Enable = GlobalVariables.R_Sta_7_Enable
        My.Settings.Sta_7_Part_Number = GlobalVariables.R_Sta_7_Part_Number
        My.Settings.Sta_8_Enable = GlobalVariables.R_Sta_8_Enable
        My.Settings.Sta_8_Part_Number = GlobalVariables.R_Sta_8_Part_Number
        My.Settings.Sta_9_Enable = GlobalVariables.R_Sta_9_Enable
        My.Settings.Sta_9_Tool = GlobalVariables.R_Sta_9_Tool
        My.Settings.Sta_10_Enable = GlobalVariables.R_Sta_10_Enable
        My.Settings.Sta_10_Part_Number = GlobalVariables.R_Sta_10_Part_Number
        My.Settings.Sta_11_Enable = GlobalVariables.R_Sta_11_Enable
        My.Settings.Sta_11_Part_Number = GlobalVariables.R_Sta_11_Part_Number
        My.Settings.Sta_12_Enable = GlobalVariables.R_Sta_12_Enable
        My.Settings.Sta_12_Part_Number = GlobalVariables.R_Sta_12_Part_Number
        My.Settings.Sta_13_Enable = GlobalVariables.R_Sta_13_Enable
        My.Settings.Sta_13_Part_Number = GlobalVariables.R_Sta_13_Part_Number
        My.Settings.Sta_13_Tool = GlobalVariables.R_Sta_13_Tool
        My.Settings.Sta_14_Enable = GlobalVariables.R_Sta_14_Enable
        My.Settings.Sta_14_Tool = GlobalVariables.R_Sta_14_Tool
        My.Settings.Sta_14_Tool = GlobalVariables.R_Sta_14_Tool
        My.Settings.Sta_15_Enable = GlobalVariables.R_Sta_15_Enable
        My.Settings.Sta_15_Insert_Angle = GlobalVariables.R_Sta_15_Insert_Angle
        My.Settings.Sta_15_Test_Angle = GlobalVariables.R_Sta_15_Test_Angle
        My.Settings.Sta_15_Finish_Angle = GlobalVariables.R_Sta_15_Finish_Angle
        My.Settings.Sta_15_Tool = GlobalVariables.R_Sta_15_Tool
        My.Settings.Sta_15_Leave_Key = GlobalVariables.R_Sta_15_Leave_Key_In_After_Test
        My.Settings.Sta_16_Enable = GlobalVariables.R_Sta_16_Enable
        My.Settings.Sta_16_Part_Number = GlobalVariables.R_Sta_16_Part_Number
        My.Settings.Sta_16_Back_Support = GlobalVariables.R_Sta_16_Back_Support
        My.Settings.Sta_17_Enable = GlobalVariables.R_Sta_17_Enable

        ' Update Bushing Values
        My.Settings.Bushing_Tooling_Code = GlobalVariables.R_Bushing_ToolingCode

        ' Update Barrel Values
        My.Settings.Barrel_Bowl = GlobalVariables.R_Barrel_Bowl
        My.Settings.Barrel_Orient = GlobalVariables.R_Barrel_Orient

        ' Update Station 13 Values
        My.Settings.Sta_13_Gripper = GlobalVariables.R_Sta_13_Gripper
        My.Settings.Sta_13_Orient = GlobalVariables.R_Sta_13_Orient
        My.Settings.Sta_13_ShotPin = GlobalVariables.R_Sta_13_Shotpin
        My.Settings.Sta_13_Place = GlobalVariables.R_Sta_13_Place
        My.Settings.Sta_13_ReClockPos = GlobalVariables.R_Sta_13_ReClockPos
        My.Settings.Sta_13_ReClockRot = GlobalVariables.R_Sta_13_ReClockRot

        ' Update Knurl Pin Values
        My.Settings.Knurl_Pin_Tooling_Code = GlobalVariables.R_KnurlPin_ToolingCode
        My.Settings.Knurl_Pin_Bowl = GlobalVariables.R_KnurlPin_Bowl

        '' Update Spring Bowl
        'My.Settings.Spring1_Bowl = GlobalVariables.R_Spring1_Bowl
        'My.Settings.Spring2_Bowl = GlobalVariables.R_Spring2_Bowl
        'My.Settings.Spring3_Bowl = GlobalVariables.R_Spring3_Bowl
        'My.Settings.Spring4_Bowl = GlobalVariables.R_Spring4_Bowl
        'My.Settings.Spring5_Bowl = GlobalVariables.R_Spring5_Bowl
        'My.Settings.Spring6_Bowl = GlobalVariables.R_Spring6_Bowl
        'My.Settings.Spring7_Bowl = GlobalVariables.R_Spring7_Bowl
        'My.Settings.Spring8_Bowl = GlobalVariables.R_Spring8_Bowl

        '' Update Top Tumbler Bowl
        'My.Settings.Top1_Bowl = GlobalVariables.R_Top1_Bowl
        'My.Settings.Top2_Bowl = GlobalVariables.R_Top2_Bowl
        'My.Settings.Top3_Bowl = GlobalVariables.R_Top3_Bowl
        'My.Settings.Top4_Bowl = GlobalVariables.R_Top4_Bowl
        'My.Settings.Top5_Bowl = GlobalVariables.R_Top5_Bowl
        'My.Settings.Top6_Bowl = GlobalVariables.R_Top6_Bowl
        'My.Settings.Top7_Bowl = GlobalVariables.R_Top7_Bowl
        'My.Settings.Top8_Bowl = GlobalVariables.R_Top8_Bowl

        '' Update Mid Tumbler Bowl
        'My.Settings.Mid1_Bowl = GlobalVariables.R_Mid1_Bowl
        'My.Settings.Mid2_Bowl = GlobalVariables.R_Mid2_Bowl
        'My.Settings.Mid3_Bowl = GlobalVariables.R_Mid3_Bowl
        'My.Settings.Mid4_Bowl = GlobalVariables.R_Mid4_Bowl
        'My.Settings.Mid5_Bowl = GlobalVariables.R_Mid5_Bowl
        'My.Settings.Mid6_Bowl = GlobalVariables.R_Mid6_Bowl
        'My.Settings.Mid7_Bowl = GlobalVariables.R_Mid7_Bowl
        'My.Settings.Mid8_Bowl = GlobalVariables.R_Mid8_Bowl

        ''===================================================
        ''Stepped = Boolean
        ''   On = Stepped
        ''   OFF = Bottom
        ''Bowl = Bowl number for Stepped or Bottom
        ''   Set other Bowl number = 0
        ''===================================================

        '' Update Bottom Tumbler Bowl
        'My.Settings.Bot1_Bowl = GlobalVariables.R_Bot1_Bowl
        'My.Settings.Bot2_Bowl = GlobalVariables.R_Bot2_Bowl
        'My.Settings.Bot3_Bowl = GlobalVariables.R_Bot3_Bowl
        'My.Settings.Bot4_Bowl = GlobalVariables.R_Bot4_Bowl
        'My.Settings.Bot5_Bowl = GlobalVariables.R_Bot5_Bowl
        'My.Settings.Bot6_Bowl = GlobalVariables.R_Bot6_Bowl
        'My.Settings.Bot7_Bowl = GlobalVariables.R_Bot7_Bowl
        'My.Settings.Bot8_Bowl = GlobalVariables.R_Bot8_Bowl

        '' Update Bottom Tumbler Stepped Enabled
        'My.Settings.Stepped_1 = GlobalVariables.R_Bot1_Stepped
        'My.Settings.Stepped_2 = GlobalVariables.R_Bot2_Stepped
        'My.Settings.Stepped_3 = GlobalVariables.R_Bot3_Stepped
        'My.Settings.Stepped_4 = GlobalVariables.R_Bot4_Stepped
        'My.Settings.Stepped_5 = GlobalVariables.R_Bot5_Stepped
        'My.Settings.Stepped_6 = GlobalVariables.R_Bot6_Stepped
        'My.Settings.Stepped_7 = GlobalVariables.R_Bot7_Stepped
        'My.Settings.Stepped_8 = GlobalVariables.R_Bot8_Stepped

        '' Update Bottom Tumbler Stepped Bowl
        'My.Settings.Stepped1_Bowl = GlobalVariables.R_Stepped1_Bowl
        'My.Settings.Stepped2_Bowl = GlobalVariables.R_Stepped2_Bowl
        'My.Settings.Stepped3_Bowl = GlobalVariables.R_Stepped3_Bowl
        'My.Settings.Stepped4_Bowl = GlobalVariables.R_Stepped4_Bowl
        'My.Settings.Stepped5_Bowl = GlobalVariables.R_Stepped5_Bowl
        'My.Settings.Stepped6_Bowl = GlobalVariables.R_Stepped6_Bowl
        'My.Settings.Stepped7_Bowl = GlobalVariables.R_Stepped7_Bowl

        ' save settings
        My.Settings.Save()
    End Sub

    Private Sub AutoLoad_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AutoLoad_RadioButton.CheckedChanged
        If AutoLoad_RadioButton.Checked Then
            GlobalVariables.R_Sta_1_Unload = "1"
        Else
            GlobalVariables.R_Sta_1_Unload = "0"
        End If
    End Sub

    Private Sub LoadKeys_Yes_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LoadKeys_Yes_RadioButton.CheckedChanged
        If AutoLoad_RadioButton.Checked Then
            GlobalVariables.R_Sta_1_Unload = "1"
        Else
            GlobalVariables.R_Sta_1_Unload = "0"
        End If

    End Sub

    Private Sub KeyAlike_Yes_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles KeyAlike_Yes_RadioButton.CheckedChanged
        If KeyAlike_Yes_RadioButton.Checked Then
            GlobalVariables.R_Sta_1_Keyed = "1"
        Else
            GlobalVariables.R_Sta_1_Keyed = "0"
        End If

    End Sub

    Private Sub Sta2_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta2_Enable_RadioButton.CheckedChanged
        If Sta2_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_2_Enable = "1"
        Else
            GlobalVariables.R_Sta_2_Enable = "0"
        End If
    End Sub

    Private Sub Sta3_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta3_Enable_RadioButton.CheckedChanged
        If Sta3_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_3_Enable = "1"
        Else
            GlobalVariables.R_Sta_3_Enable = "0"
        End If
    End Sub

    Private Sub Sta4_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta4_Enable_RadioButton.CheckedChanged
        If Sta4_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_4_Enable = "1"
        Else
            GlobalVariables.R_Sta_4_Enable = "0"
        End If
    End Sub

    Private Sub Sta5_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta5_Enable_RadioButton.CheckedChanged
        If Sta5_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_5_Enable = "1"
        Else
            GlobalVariables.R_Sta_5_Enable = "0"
        End If
    End Sub

    Private Sub Sta6_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta6_Enable_RadioButton.CheckedChanged
        If Sta6_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_6_Enable = "1"
        Else
            GlobalVariables.R_Sta_6_Enable = "0"
        End If
    End Sub

    Private Sub Sta7_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta7_Enable_RadioButton.CheckedChanged
        If Sta7_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_7_Enable = "1"
        Else
            GlobalVariables.R_Sta_7_Enable = "0"
        End If
    End Sub

    Private Sub Sta8_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta8_Enable_RadioButton.CheckedChanged
        If Sta8_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_8_Enable = "1"
        Else
            GlobalVariables.R_Sta_8_Enable = "0"
        End If
    End Sub

    Private Sub Sta9_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta9_Enable_RadioButton.CheckedChanged
        If Sta9_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_9_Enable = "1"
        Else
            GlobalVariables.R_Sta_9_Enable = "0"
        End If
    End Sub

    Private Sub Sta10_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta10_Enable_RadioButton.CheckedChanged
        If Sta10_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_10_Enable = "1"
        Else
            GlobalVariables.R_Sta_10_Enable = "0"
        End If
    End Sub

    Private Sub Sta11_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta11_Enable_RadioButton.CheckedChanged
        If Sta11_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_11_Enable = "1"
        Else
            GlobalVariables.R_Sta_11_Enable = "0"
        End If
    End Sub

    Private Sub Sta12_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta12_Enable_RadioButton.CheckedChanged
        If Sta12_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_12_Enable = "1"
        Else
            GlobalVariables.R_Sta_12_Enable = "0"
        End If
    End Sub

    Private Sub Sta13_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta13_Enable_RadioButton.CheckedChanged
        If Sta13_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_13_Enable = "1"
        Else
            GlobalVariables.R_Sta_13_Enable = "0"
        End If
    End Sub

    Private Sub Sta14_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta14_Enable_RadioButton.CheckedChanged
        If Sta14_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_14_Enable = "1"
        Else
            GlobalVariables.R_Sta_14_Enable = "0"
        End If
    End Sub

    Private Sub Sta15_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta15_Enable_RadioButton.CheckedChanged
        If Sta15_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_15_Enable = "1"
        Else
            GlobalVariables.R_Sta_15_Enable = "0"
        End If
    End Sub

    Private Sub Sta16_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta16_Enable_RadioButton.CheckedChanged
        If Sta16_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_16_Enable = "1"
        Else
            GlobalVariables.R_Sta_16_Enable = "0"
        End If
    End Sub

    Private Sub Sta17_Enable_RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Sta17_Enable_RadioButton.CheckedChanged
        If Sta17_Enable_RadioButton.Checked Then
            GlobalVariables.R_Sta_17_Enable = "1"
        Else
            GlobalVariables.R_Sta_17_Enable = "0"
        End If
    End Sub

    '=====================================================================
    ' Recipe Selected
    '=====================================================================
    Public Sub Recipe_Selected_Update(status)
        If VarType(status) <> vbBoolean Then
            Send_Recipe_Button.Enabled = False
            Return
        End If

        If status Then
            Send_Recipe_Button.Enabled = True
        Else
            Send_Recipe_Button.Enabled = False
        End If
    End Sub

    ' ========================================================
    ' If recipe changes, reset Recipe_OK and indicators
    ' ========================================================
    Private Sub RecipeName_ComboBox_TextChanged(sender As Object, e As EventArgs) Handles RecipeName_ComboBox.TextChanged
        Recipe_Selected_Update(False)
    End Sub

    ' ========================================================
    ' Go to Recipe Verify screen
    ' ========================================================
    Private Sub Send_Recipe_Button_Click(sender As Object, e As EventArgs) Handles Send_Recipe_Button.Click
        RecipeVerify_Form.StartPosition = FormStartPosition.Manual
        RecipeVerify_Form.Location = New Point(200, 0)
        RecipeVerify_Form.Show()
        RecipeVerify_Form.BringToFront()
    End Sub

    '====================================================
    ' If click while Full Access then renew permission for another time period
    '====================================================
    Private Sub RecipeDisplay_Form_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If FullAccess Then
            MainMenu.Renew_Permissions()
        End If
    End Sub

    ' ========================================================
    ' DGV Set ReadOnly according to Enabled
    ' ========================================================
    Private Sub ReadOnly_CheckBox_EnabledChanged(sender As Object, e As EventArgs)
        RecipeDataGridView.ReadOnly = RecipeDataGridView.Enabled
        RecipeDataGridView.Enabled = True
        'RecipeDataGridView.ReadOnly = DGV_ReadOnly_CheckBox.Checked
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs)
        If RecipeDataGridView.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow
            row = RecipeDataGridView.SelectedRows(0)
            Clipboard.SetDataObject(Me.RecipeDataGridView.GetClipboardContent())
        End If
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs)
        If Clipboard.ContainsText Then
            Dim CopyText As String
            CopyText = Clipboard.GetText
            Dim Items() As String
            Items = CopyText.Split(ChrW(Keys.Tab))
            RecipeDataGridView.Rows.Add(Items)
        End If
    End Sub
End Class
