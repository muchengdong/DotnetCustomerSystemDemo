using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using AntdUI;
using Panel = AntdUI.Panel;

namespace CustomerSystem.UI.Views {
    [Designer(typeof(MyTestControlDesigner))] // 为容器控件指定自定义设计器
    public class TestControl : UserControl {
        private GridPanel gridPanel1;

        public TestControl() {
            InitializeComponent();
        }

        // 可通过这个方法访问面板
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel HeaderPanel { get; private set; }


        private void InitializeComponent() {
            gridPanel1 = new GridPanel();
            HeaderPanel = new Panel();
            gridPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridPanel1
            // 
            gridPanel1.Controls.Add(HeaderPanel);
            gridPanel1.Location = new Point(53, 106);
            gridPanel1.Name = "gridPanel1";
            gridPanel1.Size = new Size(305, 158);
            gridPanel1.TabIndex = 0;
            gridPanel1.Text = "gridPanel1";
            // 
            // panel1
            // 
            HeaderPanel.Location = new Point(3, 3);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(146, 73);
            HeaderPanel.TabIndex = 0;
            HeaderPanel.Text = "panel1";
            // 
            // TestControl
            // 
            Controls.Add(gridPanel1);
            Name = "TestControl";
            Size = new Size(444, 427);
            gridPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }


    public class MyTestControlDesigner : ControlDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);

            // 使得设计器可以识别控件内的子控件
            var myContainerControl = component as TestControl;

            if (myContainerControl != null)
                // 可视化设计时支持
                EnableDesignMode(myContainerControl.HeaderPanel, "HeaderPanel");
        }

        //// 禁止改变面板大小
        //public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) {
        //    base.InitializeNewComponent(defaultValues);

        //    var parentControl = this.Control as TestControl;

        //    if (parentControl != null) {
        //        // 禁止调整面板的大小
        //        parentControl.HeaderPanel.Size = new Size(parentControl.Width - 20, 50);
        //        parentControl.ContentPanel.Size = new Size(parentControl.Width - 20, 150);
        //        parentControl.FooterPanel.Size = new Size(parentControl.Width - 20, 50);
        //    }
        //}

        //// 阻止拖动和改变控件大小
        //protected override void PostFilterProperties(System.Collections.IDictionary properties) {
        //    base.PostFilterProperties(properties);

        //    // 隐藏控件的大小相关属性（如Width和Height）
        //    if (properties.Contains("Height"))
        //        properties.Remove("Height");

        //    if (properties.Contains("Width"))
        //        properties.Remove("Width");
        //}

        // 强制设计时显示控件内部的所有面板
        protected override void PreFilterProperties(IDictionary properties) {
            base.PreFilterProperties(properties);

            // 这里可以控制哪些属性在设计时显示
            if (!properties.Contains("HeaderPanel"))
                properties.Add("HeaderPanel",
                    TypeDescriptor.CreateProperty(typeof(TestControl), "HeaderPanel",
                        typeof(System.Windows.Forms.Panel)));

            //if (!properties.Contains("ContentPanel"))
            //    properties.Add("ContentPanel",
            //        TypeDescriptor.CreateProperty(typeof(MyContainerControl), "ContentPanel", typeof(Panel)));

            //if (!properties.Contains("FooterPanel"))
            //    properties.Add("FooterPanel",
            //        TypeDescriptor.CreateProperty(typeof(MyContainerControl), "FooterPanel", typeof(Panel)));
        }
    }
}