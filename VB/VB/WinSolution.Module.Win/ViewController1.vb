Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Win.Templates

Namespace WinSolution.Module.Win
	Partial Public Class ViewController1
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub popupWindowShowAction1_CustomizeTemplate(ByVal sender As Object, ByVal e As CustomizeTemplateEventArgs) Handles popupWindowShowAction1.CustomizeTemplate
			CType(e.Template, PopupForm).Size = New System.Drawing.Size(200, 200)
		End Sub
		Private Sub popupWindowShowAction1_CustomizePopupWindowParams(ByVal sender As Object, ByVal e As CustomizePopupWindowParamsEventArgs) Handles popupWindowShowAction1.CustomizePopupWindowParams
			Dim os As ObjectSpace = Application.CreateObjectSpace()
			e.View = Application.CreateDetailView(os, os.CreateObject(Of DomainObject1)())
		End Sub
	End Class
End Namespace
