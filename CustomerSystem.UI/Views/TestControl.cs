using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomerSystem.UI.Views {

    [Designer(typeof(MyTestControlDesigner))] // 为容器控件指定自定义设计器
    public class TestControl : UserControl {
        private AntdUI.GridPanel gridPanel1;
        private AntdUI.Panel panel1;

        // 可通过这个方法访问面板
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AntdUI.Panel HeaderPanel => panel1;

        public TestControl() { 
            InitializeComponent();
        }


        private void InitializeComponent() {
            this.gridPanel1 = new AntdUI.GridPanel();
            this.panel1 = new AntdUI.Panel();
            this.gridPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPanel1
            // 
            this.gridPanel1.Controls.Add(this.panel1);
            this.gridPanel1.Location = new System.Drawing.Point(53, 106);
            this.gridPanel1.Name = "gridPanel1";
            this.gridPanel1.Size = new System.Drawing.Size(305, 158);
            this.gridPanel1.TabIndex = 0;
            this.gridPanel1.Text = "gridPanel1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 73);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // TestControl
            // 
            this.Controls.Add(this.gridPanel1);
            this.Name = "TestControl";
            this.Size = new System.Drawing.Size(444, 427);
            this.gridPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }




    public class MyTestControlDesigner : ControlDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);

            // 使得设计器可以识别控件内的子控件
            var myContainerControl = component as TestControl;

            if (myContainerControl != null) {
                // 可视化设计时支持
                this.EnableDesignMode(myContainerControl.HeaderPanel, "HeaderPanel");
            }
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
        protected override void PreFilterProperties(System.Collections.IDictionary properties) {
            base.PreFilterProperties(properties);

            // 这里可以控制哪些属性在设计时显示
            if (!properties.Contains("HeaderPanel"))
                properties.Add("HeaderPanel",
                    TypeDescriptor.CreateProperty(typeof(TestControl), "HeaderPanel", typeof(Panel)));

            //if (!properties.Contains("ContentPanel"))
            //    properties.Add("ContentPanel",
            //        TypeDescriptor.CreateProperty(typeof(MyContainerControl), "ContentPanel", typeof(Panel)));

            //if (!properties.Contains("FooterPanel"))
            //    properties.Add("FooterPanel",
            //        TypeDescriptor.CreateProperty(typeof(MyContainerControl), "FooterPanel", typeof(Panel)));
        }
    }
}
