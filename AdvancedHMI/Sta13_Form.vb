Public Class Sta13_Form
    Private Sub Sta13_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NCLRecipeDataSet.Station_13_Tooling' table. You can move, or remove it, as needed.
        Me.Station_13_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_13_Tooling)

        Dim GripperList As New List(Of String)
        GripperList.Add("0")
        GripperList.Add("1")
        GripperList.Add("2")
        GripperList.Add("3")
        Gripper_ComboBox.DataSource = GripperList

        Dim OrientList As New List(Of String)
        OrientList.Add("#1 - Standard (.420)")
        OrientList.Add("#2 - High (.310)")
        OrientList.Add("#3 - Low (.600)")
        Orient_ComboBox.DataSource = OrientList

        Dim ShotPinList As New List(Of String)
        ShotPinList.Add("#1 - Standard (.420)")
        ShotPinList.Add("#2 - High (.310)")
        ShotPin_ComboBox.DataSource = ShotPinList

        Dim PlaceList As New List(Of String)
        PlaceList.Add("#1 - Standard (Low Switch)")
        PlaceList.Add("#2 - Top Sleeve (High Switch)")
        Place_ComboBox.DataSource = PlaceList

        Dim ReClockPosList As New List(Of String)
        ReClockPosList.Add("#1 - Standard (Low Switch)")
        ReClockPosList.Add("#2 - Top Sleeve (High Switch)")
        ReClockPos_ComboBox.DataSource = ReClockPosList

        Dim ReClockRotList As New List(Of String)
        ReClockRotList.Add("#1 - 22.5deg. CCW (STD.)")
        ReClockRotList.Add("#2 - 45deg. CCW")
        ReClockRotList.Add("#3 - 0deg.")
        ReClockRot_ComboBox.DataSource = ReClockRotList
    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Try
            Station_13_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_13_Tooling)
            Me.Station_13_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_13_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot update record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Insert_Button_Click(sender As Object, e As EventArgs) Handles Insert_Button.Click
        Dim NewRow As NCLRecipeDataSet.Station_13_ToolingRow
        NewRow = Me.NCLRecipeDataSet.Station_13_Tooling.NewRow()

        NewRow.Tooling_Name = Tool_ComboBox.Text
        NewRow.Gripper = Gripper_ComboBox.Text
        NewRow.Orient = Orient_ComboBox.Text
        NewRow.Shotpin = ShotPin_ComboBox.Text
        NewRow.Place = Place_ComboBox.Text
        NewRow.ReClock_Pos = ReClockPos_ComboBox.Text
        NewRow.ReClock_Rot = ReClockRot_ComboBox.Text

        Try
            Station_13_ToolingTableAdapter.Insert(Tooling_Name:=NewRow.Tooling_Name,
                                                  Gripper:=NewRow.Gripper,
                                                  Orient:=NewRow.Orient,
                                                  Shotpin:=NewRow.Shotpin,
                                                  Place:=NewRow.Place,
                                                  ReClock_Pos:=NewRow.ReClock_Pos,
                                                  ReClock_Rot:=NewRow.ReClock_Rot)
            Station_13_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_13_Tooling)
            Me.Station_13_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_13_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot insert record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        ' Add click to confirm before delete
        Try
            Station_13_ToolingTableAdapter.Delete(Original_Tooling_Name:=Tool_ComboBox.Text,
                                                  Original_Gripper:=Gripper_ComboBox.Text,
                                                  Original_Orient:=Orient_ComboBox.Text,
                                                  Original_Shotpin:=ShotPin_ComboBox.Text,
                                                  Original_Place:=Place_ComboBox.Text,
                                                  Original_ReClock_Pos:=ReClockPos_ComboBox.Text,
                                                  Original_ReClock_Rot:=ReClockRot_ComboBox.Text)
            Station_13_ToolingTableAdapter.Update(NCLRecipeDataSet.Station_13_Tooling)
            Me.Station_13_ToolingTableAdapter.Fill(Me.NCLRecipeDataSet.Station_13_Tooling)
        Catch ex As Exception
            MessageBox.Show(String.Format("Cannot delete record: {0}" & vbCrLf, ex.Message))
        End Try
    End Sub

    'Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    '    DataGridView1.ReadOnly = CheckBox1.Checked
    'End Sub

    Private Sub Tool_ComboBox_TextChanged(sender As Object, e As EventArgs) Handles Tool_ComboBox.TextChanged

        ' Update Global variables
        GlobalVariables.R_Sta_13_Gripper = Station_13_ToolingTableAdapter.GetGripper(Tool_ComboBox.Text)
        GlobalVariables.R_Sta_13_Orient = Station_13_ToolingTableAdapter.GetOrient(Tool_ComboBox.Text)
        GlobalVariables.R_Sta_13_Shotpin = Station_13_ToolingTableAdapter.GetOrient(Tool_ComboBox.Text)
        GlobalVariables.R_Sta_13_Place = Station_13_ToolingTableAdapter.GetPlace(Tool_ComboBox.Text)
        GlobalVariables.R_Sta_13_ReClockPos = Station_13_ToolingTableAdapter.GetReClockPos(Tool_ComboBox.Text)
        GlobalVariables.R_Sta_13_ReClockRot = Station_13_ToolingTableAdapter.GetReClockRot(Tool_ComboBox.Text)

        ' update screen combo box text
        Gripper_ComboBox.Text = R_Sta_13_Gripper
        Orient_ComboBox.Text = R_Sta_13_Orient
        ShotPin_ComboBox.Text = R_Sta_13_Shotpin
        Place_ComboBox.Text = R_Sta_13_Place
        ReClockPos_ComboBox.Text = R_Sta_13_ReClockPos
        ReClockRot_ComboBox.Text = R_Sta_13_ReClockRot

        ' update settings
        My.Settings.Sta_13_Gripper = GlobalVariables.R_Sta_13_Gripper
        My.Settings.Sta_13_Orient = GlobalVariables.R_Sta_13_Orient
        My.Settings.Sta_13_ShotPin = GlobalVariables.R_Sta_13_Shotpin
        My.Settings.Sta_13_Place = GlobalVariables.R_Sta_13_Place
        My.Settings.Sta_13_ReClockPos = GlobalVariables.R_Sta_13_ReClockPos
        My.Settings.Sta_13_ReClockRot = GlobalVariables.R_Sta_13_ReClockRot

        'save settings
        My.Settings.Save()
    End Sub

End Class