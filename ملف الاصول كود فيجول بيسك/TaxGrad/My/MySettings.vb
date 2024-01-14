Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace TaxGrad.My
    <EditorBrowsable(EditorBrowsableState.Advanced), CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")> _
    Friend NotInheritable Class MySettings
        Inherits ApplicationSettingsBase
        ' Methods
        <EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode> _
        Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
            If MyProject.Application.get_SaveMySettingsOnExit Then
                MySettingsProperty.Settings.Save
            End If
        End Sub


        ' Properties
        Public Shared ReadOnly Property [Default] As MySettings
            Get
                If Not MySettings.addedHandler Then
                    Dim addedHandlerLockObject As Object = MySettings.addedHandlerLockObject
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject)
                    SyncLock addedHandlerLockObject
                        If Not MySettings.addedHandler Then
                            MyProject.Application.add_Shutdown(New ShutdownEventHandler(Nothing, MySettings.AutoSaveSettings))
                            MySettings.addedHandler = True
                        End If
                    End SyncLock
                End If
                Return MySettings.defaultInstance
            End Get
        End Property

        <DefaultSettingValue("Data Source=.;Initial Catalog=Gard;Integrated Security=True"), DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.ConnectionString)> _
        Public ReadOnly Property GardConnectionString As String
            Get
                Return Conversions.ToString(Me.Item("GardConnectionString"))
            End Get
        End Property


        ' Fields
        Private Shared defaultInstance As MySettings = DirectCast(SettingsBase.Synchronized(New MySettings), MySettings)
        Private Shared addedHandler As Boolean
        Private Shared addedHandlerLockObject As Object = New Object
    End Class
End Namespace

