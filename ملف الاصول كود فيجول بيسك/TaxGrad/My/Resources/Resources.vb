Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace TaxGrad.My.Resources
    <HideModuleName, StandardModule, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), DebuggerNonUserCode, CompilerGenerated> _
    Friend NotInheritable Class Resources
        ' Properties
        <EditorBrowsable(EditorBrowsableState.Advanced)> _
        Friend Shared ReadOnly Property ResourceManager As ResourceManager
            Get
                If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
                    Resources.resourceMan = New ResourceManager("TaxGrad.Resources", GetType(Resources).Assembly)
                End If
                Return Resources.resourceMan
            End Get
        End Property

        <EditorBrowsable(EditorBrowsableState.Advanced)> _
        Friend Shared Property Culture As CultureInfo
            Get
                Return Resources.resourceCulture
            End Get
            Set(ByVal Value As CultureInfo)
                Resources.resourceCulture = Value
            End Set
        End Property

        Friend Shared ReadOnly Property company1 As Bitmap
            Get
                Return DirectCast(Resources.ResourceManager.GetObject("company1", Resources.resourceCulture), Bitmap)
            End Get
        End Property


        ' Fields
        Private Shared resourceMan As ResourceManager
        Private Shared resourceCulture As CultureInfo
    End Class
End Namespace

