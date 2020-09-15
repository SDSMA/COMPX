Option Explicit On

'===============================================================
' Global Variables
'===============================================================
'Imports System.ComponentModel

'Imports System          'To Access Console.WriteLine()
'Imports System.Runtime.InteropServices
'Imports System.Drawing
'Imports System.Drawing.Imaging

Module GlobalVariables
    Public Machine_Operating As Boolean = False
    Public FullAccess As Boolean = True
    Public User_Password As String = "12345"

    ' Key File data
    Public Key_Series As String
    Public Key_No As String
    Public Key_Code As String
    Public Key_MK_Code As String
    Public Key_Qty As String
    Public Key_Desc As String
    Public Key_Assigned_To As String
    Public Key_Date As Date

    Public WorkFile_RowCount As Integer = 0
    Public WorkFile_CurrentRow As Integer

    Public Current_Row_Complete As Boolean
    Public RunMode As Boolean

    Public Work_File_Path As String
    'Public Key_File_Path As String
    Public KeyFile As String

    Public Tumbler_1_Code As String
    Public Tumbler_2_Code As String
    Public Tumbler_3_Code As String
    Public Tumbler_4_Code As String
    Public Tumbler_5_Code As String
    Public Tumbler_6_Code As String
    Public Tumbler_7_Code As String
    Public Tumbler_8_Code As String

    Public WorkFile_Complete As Boolean = False
    Public KeyFile_OK As Boolean = False
    Public TumblerCode_OK As Boolean = False

    ' Recipe Table Holding Variables
    Public R_Recipe_Name As String
    Public R_Lock_Family As String
    Public R_Company_Name As String
    Public R_Date As String
    Public R_Tool_ID As String
    Public R_Sta_1_Load_Keys As String
    Public R_Sta_1_Keyed As String
    Public R_Sta_1_Unload As String
    Public R_Sta_2_Enable As String
    Public R_Sta_3_Enable As String
    Public R_Sta_3_Part_Number As String
    Public R_Sta_4_Enable As String
    Public R_Sta_5_Enable As String
    Public R_Sta_5_Part_Number As String
    Public R_Sta_5_Vert_Height As String
    Public R_Sta_6_Enable As String
    Public R_Sta_6_Part_Number As String
    Public R_Sta_7_Enable As String
    Public R_Sta_7_Part_Number As String
    Public R_Sta_8_Enable As String
    Public R_Sta_8_Part_Number As String
    Public R_Sta_9_Enable As String
    Public R_Sta_9_Tool As String
    Public R_Sta_10_Enable As String
    Public R_Sta_10_Part_Number As String
    Public R_Sta_11_Enable As String
    Public R_Sta_11_Part_Number As String
    Public R_Sta_12_Enable As String
    Public R_Sta_12_Part_Number As String

    ' Station 13
    Public R_Sta_13_Enable As String
    Public R_Sta_13_Part_Number As String
    Public R_Sta_13_Tool As String
    Public R_Sta_13_Gripper As String
    Public R_Sta_13_Orient As String
    Public R_Sta_13_Shotpin As String
    Public R_Sta_13_Place As String
    Public R_Sta_13_ReClockPos As String
    Public R_Sta_13_ReClockRot As String

    ' Springs
    Public R_Spring_Tumbler_Kit As String

    Public R_Spring1_Type As String
    Public R_Spring2_Type As String
    Public R_Spring3_Type As String
    Public R_Spring4_Type As String
    Public R_Spring5_Type As String
    Public R_Spring6_Type As String
    Public R_Spring7_Type As String
    Public R_Spring8_Type As String

    Public R_Spring1_Bowl As String
    Public R_Spring2_Bowl As String
    Public R_Spring3_Bowl As String
    Public R_Spring4_Bowl As String
    Public R_Spring5_Bowl As String
    Public R_Spring6_Bowl As String
    Public R_Spring7_Bowl As String
    Public R_Spring8_Bowl As String

    Public R_Spring1_Chart As String
    Public R_Spring2_Chart As String
    Public R_Spring3_Chart As String
    Public R_Spring4_Chart As String
    Public R_Spring5_Chart As String
    Public R_Spring6_Chart As String
    Public R_Spring7_Chart As String
    Public R_Spring8_Chart As String

    ' Top Tumblers
    Public R_Top_Tumbler_Kit As String

    Public R_Top1_Type As String
    Public R_Top2_Type As String
    Public R_Top3_Type As String
    Public R_Top4_Type As String
    Public R_Top5_Type As String
    Public R_Top6_Type As String
    Public R_Top7_Type As String
    Public R_Top8_Type As String

    Public R_Top1_Bowl As String
    Public R_Top2_Bowl As String
    Public R_Top3_Bowl As String
    Public R_Top4_Bowl As String
    Public R_Top5_Bowl As String
    Public R_Top6_Bowl As String
    Public R_Top7_Bowl As String
    Public R_Top8_Bowl As String

    Public R_Top1_Chart As String
    Public R_Top2_Chart As String
    Public R_Top3_Chart As String
    Public R_Top4_Chart As String
    Public R_Top5_Chart As String
    Public R_Top6_Chart As String
    Public R_Top7_Chart As String
    Public R_Top8_Chart As String

    ' Middle Tumblers
    Public R_Mid_Tumbler_Kit As String

    Public R_Mid1_Type As String
    Public R_Mid2_Type As String
    Public R_Mid3_Type As String
    Public R_Mid4_Type As String
    Public R_Mid5_Type As String
    Public R_Mid6_Type As String
    Public R_Mid7_Type As String
    Public R_Mid8_Type As String

    Public R_Mid1_Bowl As String
    Public R_Mid2_Bowl As String
    Public R_Mid3_Bowl As String
    Public R_Mid4_Bowl As String
    Public R_Mid5_Bowl As String
    Public R_Mid6_Bowl As String
    Public R_Mid7_Bowl As String
    Public R_Mid8_Bowl As String

    Public R_Mid1_Chart As String
    Public R_Mid2_Chart As String
    Public R_Mid3_Chart As String
    Public R_Mid4_Chart As String
    Public R_Mid5_Chart As String
    Public R_Mid6_Chart As String
    Public R_Mid7_Chart As String
    Public R_Mid8_Chart As String

    ' Bottom Tumblers
    Public R_Bottom_Tumbler_Kit As String

    Public R_Bot1_Type As String
    Public R_Bot2_Type As String
    Public R_Bot3_Type As String
    Public R_Bot4_Type As String
    Public R_Bot5_Type As String
    Public R_Bot6_Type As String
    Public R_Bot7_Type As String
    Public R_Bot8_Type As String

    Public R_Bot1_Bowl As String
    Public R_Bot2_Bowl As String
    Public R_Bot3_Bowl As String
    Public R_Bot4_Bowl As String
    Public R_Bot5_Bowl As String
    Public R_Bot6_Bowl As String
    Public R_Bot7_Bowl As String
    Public R_Bot8_Bowl As String

    Public R_Bot1_Chart As String
    Public R_Bot2_Chart As String
    Public R_Bot3_Chart As String
    Public R_Bot4_Chart As String
    Public R_Bot5_Chart As String
    Public R_Bot6_Chart As String
    Public R_Bot7_Chart As String
    Public R_Bot8_Chart As String

    Public R_Stepped_Tumbler_Kit As String

    Public R_Stepped1_Type As String
    Public R_Stepped2_Type As String
    Public R_Stepped3_Type As String
    Public R_Stepped4_Type As String
    Public R_Stepped5_Type As String
    Public R_Stepped6_Type As String
    Public R_Stepped7_Type As String
    Public R_Stepped8_Type As String

    Public R_Stepped1_Chart As String
    Public R_Stepped2_Chart As String
    Public R_Stepped3_Chart As String
    Public R_Stepped4_Chart As String
    Public R_Stepped5_Chart As String
    Public R_Stepped6_Chart As String
    Public R_Stepped7_Chart As String
    Public R_Stepped8_Chart As String

    Public R_Bot1_Stepped As String
    Public R_Bot2_Stepped As String
    Public R_Bot3_Stepped As String
    Public R_Bot4_Stepped As String
    Public R_Bot5_Stepped As String
    Public R_Bot6_Stepped As String
    Public R_Bot7_Stepped As String
    Public R_Bot8_Stepped As String

    Public R_Stepped1_Bowl As String
    Public R_Stepped2_Bowl As String
    Public R_Stepped3_Bowl As String
    Public R_Stepped4_Bowl As String
    Public R_Stepped5_Bowl As String
    Public R_Stepped6_Bowl As String
    Public R_Stepped7_Bowl As String
    Public R_Stepped8_Bowl As String

    Public R_Bushing As String
    Public R_Bushing_ToolingCode As String
    Public R_DrillPin As String
    Public R_TopSleeve As String
    Public R_KnurlPin As String
    Public R_KnurlPin_ToolingCode As String
    Public R_KnurlPin_Bowl As String
    Public R_Barrel As String
    Public R_Barrel_Bowl As String
    Public R_Barrel_Orient As String

    Public R_Sta_14_Enable As String
    Public R_Sta_14_Tool As String
    Public R_Sta_15_Enable As String
    Public R_Sta_15_Insert_Angle As String
    Public R_Sta_15_Test_Angle As String
    Public R_Sta_15_Finish_Angle As String
    Public R_Sta_15_Tool As String
    Public R_Sta_15_Leave_Key_In_After_Test As String

    Public R_Sta_16_Enable As String
    Public R_Sta_16_Part_Number As String
    Public R_Sta_16_Back_Support As String
    Public R_Sta_17_Enable As String

    Public Batch_Key_Queue_Enabled As String
    Public strDatabase As String = My.Settings.DatabaseFileName
    Public strDatabaseCon As String = My.Settings.NCLRecipeConnectionString

End Module