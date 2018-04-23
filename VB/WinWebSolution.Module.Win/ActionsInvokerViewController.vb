Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.SystemModule

Namespace WinWebSolution.Module.Win
	Partial Public Class PopupWindowInvokerViewController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub
		Private Sub saPopupWindowShowActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saPopupWindowShowActionInvoker.Execute
			CType(New PopupWindowShowActionHelper(Frame.GetController(Of LinkUnlinkController)().LinkAction), PopupWindowShowActionHelper).ShowPopupWindow()
		End Sub
		Private Sub saSingleChoiceActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saSingleChoiceActionInvoker.Execute
			Frame.GetController(Of NewObjectViewController)().NewObjectAction.DoExecute(Frame.GetController(Of NewObjectViewController)().NewObjectAction.Items(0))
		End Sub
		Private Sub saSimpleActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saSimpleActionInvoker.Execute
			Frame.GetController(Of RefreshController)().RefreshAction.DoExecute()
		End Sub
		Private Sub saParametrizedActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saParametrizedActionInvoker.Execute
			Frame.GetController(Of FilterController)().FullTextFilterAction.DoExecute("test value")
		End Sub
	End Class
End Namespace
