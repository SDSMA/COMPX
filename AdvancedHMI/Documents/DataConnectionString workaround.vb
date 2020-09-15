'In Project Properties, Settings
'	Make a user scoped string entry for each Application scoped connection string with the same base name plus a suffix.
'	For example, "UserOverride".
'For application scoped connection settings "ConnectionString1" and "ConnectionString2", 
'	create two user scoped strings (not (connection strings)) called "ConnectionString1UserOverride" and "ConnectionString2UserOverride".

'To update the connection string, call SetUserOverride(). 
'	For example, to call My.Settings.ConnectionString1 = "My new string", which is not allowed, 
'		call My.Settings.SetUserOverride("ConnectionString1", "My new string").

'In My Project, Application Settings
'	make sure that Save My.Settings on Shutdown is enabled.

'https://www.codeproject.com/Articles/19578/How-to-persist-changes-to-My-Settings-ConnectionSt

Namespace My
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase

		'Include names of Application scoped connection strings to be replaced by user overrides
        Private Shared userOverrides() As String = { _
            "ConnectionString1", _
            "ConnectionString2" _
        }

		'	Set the userOverrideSuffix
        Private userOverrideSuffix As String = "UserOverride"

        Public Sub SetUserOverride(ByVal [property] As String, ByVal value As String)
            Me([property]) = value
        End Sub

		' change targeted settings when settings are loaded
        Private Sub userOverride_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) _
            Handles Me.SettingsLoaded
            Dim userProperty As String

            For Each appProperty As String In userOverrides
                userProperty = appProperty & userOverrideSuffix
                If CType(Me(userProperty), String).Length > 0 Then
                    Me(appProperty) = Me(userProperty)
                End If
            Next
        End Sub

		' restre targeted settings when settings are saved.
        Private Sub userOverride_SettingsSaving(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
            Handles Me.SettingsSaving
            Dim userProperty As String
			
            For Each appProperty As String In userOverrides
                userProperty = appProperty & userOverrideSuffix
                Me(userProperty) = Me(appProperty)
            Next
        End Sub
    End Class
End Namespace