using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win.Templates;

namespace WinSolution.Module.Win {
    public partial class ViewController1 : ViewController {
        public ViewController1() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void popupWindowShowAction1_CustomizeTemplate(object sender, CustomizeTemplateEventArgs e) {
            ((PopupForm)e.Template).Size = new System.Drawing.Size(200, 200);
        }
        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
            ObjectSpace os = Application.CreateObjectSpace();
            e.View = Application.CreateDetailView(os, os.CreateObject<DomainObject1>());
        }
    }
}
