using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Panel = AntdUI.Panel;

namespace CustomerSystem.UI.Views {
    [Designer(typeof(MyUserControlDesigner))] // 指定自定义设计器
    public partial class UserControl1 : UserControl {
        public UserControl1() {
            InitializeComponent();
        }

        public Panel HeaderPanel {
            get => panel1;
            set => panel1 = value;
        }
    }


    public class MyUserControlDesigner : ParentControlDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);

            var userControl = component as UserControl1;
            if (userControl != null)
                // 启用设计时的面板支持
                EnableDesignMode(userControl.HeaderPanel, "HeaderPanel");
        }

        // // 禁止调整控件大小
        // protected override void PreFilterProperties(System.Collections.IDictionary properties) {
        //     base.PreFilterProperties(properties);
        //
        //     // 移除面板的 Width 和 Height 属性，禁止调整大小
        //     if (properties.Contains("Height")) {
        //         properties.Remove("Height");
        //     }
        //
        //     if (properties.Contains("Width")) {
        //         properties.Remove("Width");
        //     }
        // }
        //
        // // 固定控件的大小
        // public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) {
        //     base.InitializeNewComponent(defaultValues);
        //
        //     var userControl = this.Control as MyUserControl;
        //     if (userControl != null) {
        //         // 强制设置面板的大小
        //         userControl.HeaderPanel.Size = new Size(userControl.Width - 20, 50);
        //         userControl.ContentPanel.Size = new Size(userControl.Width - 20, 150);
        //         userControl.FooterPanel.Size = new Size(userControl.Width - 20, 50);
        //     }
        // }
    }
}