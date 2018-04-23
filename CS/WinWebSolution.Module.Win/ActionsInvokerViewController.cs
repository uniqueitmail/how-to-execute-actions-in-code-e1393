using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.SystemModule;

namespace WinWebSolution.Module.Win {
    public partial class PopupWindowInvokerViewController : ViewController {
        public PopupWindowInvokerViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void saPopupWindowShowActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            new PopupWindowShowActionHelper(Frame.GetController<LinkUnlinkController>().LinkAction).ShowPopupWindow();
        }
        private void saSingleChoiceActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            Frame.GetController<NewObjectViewController>().NewObjectAction.DoExecute(Frame.GetController<NewObjectViewController>().NewObjectAction.Items[0]);
        }
        private void saSimpleActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            Frame.GetController<RefreshController>().RefreshAction.DoExecute();
        }
        private void saParametrizedActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            Frame.GetController<FilterController>().FullTextFilterAction.DoExecute("test value");
        }
    }
}
