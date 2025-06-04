using System.ComponentModel;
using System.Drawing;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Panel = AntdUI.Panel;

namespace CustomerSystem.UI.Views {
    [Designer(typeof(MyLayoutContainerControlDesigner))] // 这里关联自定义设计器
    public partial class BaseLayoutControl : UserControl {
        // Header 区域，UI 设计器可以自定义
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel HeaderPanel {
            get => this.pnlHeader; set { this.pnlHeader = value; }
        }

        // Content 区域，页面内容可以通过代码动态更新
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel => this.pnlContent;

        // Footer 区域，UI 设计器可以自定义
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel FooterPanel => this.pnlFooter;

        public BaseLayoutControl() {
            InitializeComponent();
            this.DoubleBuffered = true; // 防止闪烁
        }

        // 使设计时可用
        // protected override void OnLoad(EventArgs e) {
        //     base.OnLoad(e);
        //
        //     // 使设计器在初始化时可以看到各区域
        //     this.HeaderPanel.AllowDrop = true;
        //     this.ContentPanel.AllowDrop = true;
        //     this.FooterPanel.AllowDrop = true;
        // }
    }


    // // 自定义控件的设计器
    // public class BaseLayoutControlDesigner : ControlDesigner {
    //     public override void Initialize(IComponent component) {
    //         base.Initialize(component);
    //         var baseLayoutControl = component as BaseLayoutControl;
    //
    //         // 设置 ContentPanel 区域不可在设计器中显示
    //         if (baseLayoutControl != null) {
    //             baseLayoutControl.ContentPanel.Visible = false; // 让 ContentPanel 在设计器中不可见
    //         }
    //     }
    // }
    
    
    public class MyLayoutContainerControlDesigner : ParentControlDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);

            // 使得设计器可以识别控件内的子控件
            var myContainerControl = component as BaseLayoutControl;

            if (myContainerControl != null) {
                // 可视化设计时支持
                this.EnableDesignMode(myContainerControl.HeaderPanel, "HeaderPanel");
                this.EnableDesignMode(myContainerControl.ContentPanel, "ContentPanel");
                this.EnableDesignMode(myContainerControl.FooterPanel, "FooterPanel");
            }
        }

        // 禁止改变面板大小
        // public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) {
        //     base.InitializeNewComponent(defaultValues);
        //
        //     var parentControl = this.Control as BaseLayoutControl;
        //
        //     // if (parentControl != null) {
        //     //     // 禁止调整面板的大小
        //     //     parentControl.HeaderPanel.Size = new Size(parentControl.Width - 20, 50);
        //     //     parentControl.ContentPanel.Size = new Size(parentControl.Width - 20, 150);
        //     //     parentControl.FooterPanel.Size = new Size(parentControl.Width - 20, 50);
        //     // }
        // }

        // // 阻止拖动和改变控件大小
        // protected override void PostFilterProperties(System.Collections.IDictionary properties) {
        //     base.PostFilterProperties(properties);
        //
        //     // 隐藏控件的大小相关属性（如Width和Height）
        //     if (properties.Contains("Height"))
        //         properties.Remove("Height");
        //
        //     if (properties.Contains("Width"))
        //         properties.Remove("Width");
        // }

        // 强制设计时显示控件内部的所有面板
        // protected override void PreFilterProperties(System.Collections.IDictionary properties) {
        //     base.PreFilterProperties(properties);
        //
        //     // 这里可以控制哪些属性在设计时显示
        //     if (!properties.Contains("HeaderPanel"))
        //         properties.Add("HeaderPanel",
        //             TypeDescriptor.CreateProperty(typeof(BaseLayoutControl), "HeaderPanel", typeof(AntdUI.Panel)));
        //
        //     if (!properties.Contains("ContentPanel"))
        //         properties.Add("ContentPanel",
        //             TypeDescriptor.CreateProperty(typeof(BaseLayoutControl), "ContentPanel", typeof(AntdUI.Panel)));
        //
        //     if (!properties.Contains("FooterPanel"))
        //         properties.Add("FooterPanel",
        //             TypeDescriptor.CreateProperty(typeof(BaseLayoutControl), "FooterPanel", typeof(AntdUI.Panel)));
        // }
    }
}