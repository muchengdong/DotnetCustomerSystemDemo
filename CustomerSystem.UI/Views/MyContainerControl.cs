using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomerSystem.UI.Views {
    [Designer(typeof(MyContainerControlDesigner))] // 为容器控件指定自定义设计器
    public class MyContainerControl : Control {
        // 构造函数
        public MyContainerControl() {
            DoubleBuffered = true; // 防止闪烁
            BackColor = Color.LightGray; // 设置默认背景颜色
            Padding = new Padding(10); // 内边距
            Size = new Size(300, 300); // 默认大小

            // 初始化面板
            InitializePanels();
        }

        // 可通过这个方法访问面板
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel HeaderPanel { get; private set; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentPanel { get; private set; }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel FooterPanel { get; private set; }

        // 初始化面板
        private void InitializePanels() {
            // 创建头部面板
            HeaderPanel = new Panel {
                BackColor = Color.LightBlue, // 设置背景色
                Size = new Size(Width - 20, 50), // 设置大小
                Location = new Point(10, 10) // 设置位置
            };

            // 创建内容面板
            ContentPanel = new Panel {
                BackColor = Color.LightGreen,
                Size = new Size(Width - 20, 150),
                Location = new Point(10, 70)
            };

            // 创建底部面板
            FooterPanel = new Panel {
                BackColor = Color.LightCoral,
                Size = new Size(Width - 20, 50),
                Location = new Point(10, Height - 60)
            };

            // 将面板添加到容器中
            Controls.Add(HeaderPanel);
            Controls.Add(ContentPanel);
            Controls.Add(FooterPanel);
        }

        // 重写 OnPaint 方法，来绘制容器的内容（可选）
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            // 绘制容器的背景
            e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

            // 绘制边框
            using (var borderPen = new Pen(Color.Black)) {
                borderPen.Width = 2;
                e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
            }
        }
    }


    public class MyContainerControlDesigner : ControlDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);

            // 使得设计器可以识别控件内的子控件
            var myContainerControl = component as MyContainerControl;

            if (myContainerControl != null) {
                // 可视化设计时支持
                EnableDesignMode(myContainerControl.HeaderPanel, "HeaderPanel");
                EnableDesignMode(myContainerControl.ContentPanel, "ContentPanel");
                EnableDesignMode(myContainerControl.FooterPanel, "FooterPanel");
            }
        }

        // 禁止改变面板大小
        public override void InitializeNewComponent(IDictionary defaultValues) {
            base.InitializeNewComponent(defaultValues);

            var parentControl = Control as MyContainerControl;

            if (parentControl != null) {
                // 禁止调整面板的大小
                parentControl.HeaderPanel.Size = new Size(parentControl.Width - 20, 50);
                parentControl.ContentPanel.Size = new Size(parentControl.Width - 20, 150);
                parentControl.FooterPanel.Size = new Size(parentControl.Width - 20, 50);
            }
        }

        // 阻止拖动和改变控件大小
        protected override void PostFilterProperties(IDictionary properties) {
            base.PostFilterProperties(properties);

            // 隐藏控件的大小相关属性（如Width和Height）
            if (properties.Contains("Height"))
                properties.Remove("Height");

            if (properties.Contains("Width"))
                properties.Remove("Width");
        }

        // 强制设计时显示控件内部的所有面板
        protected override void PreFilterProperties(IDictionary properties) {
            base.PreFilterProperties(properties);

            // 这里可以控制哪些属性在设计时显示
            if (!properties.Contains("HeaderPanel"))
                properties.Add("HeaderPanel",
                    TypeDescriptor.CreateProperty(typeof(MyContainerControl), "HeaderPanel", typeof(Panel)));

            if (!properties.Contains("ContentPanel"))
                properties.Add("ContentPanel",
                    TypeDescriptor.CreateProperty(typeof(MyContainerControl), "ContentPanel", typeof(Panel)));

            if (!properties.Contains("FooterPanel"))
                properties.Add("FooterPanel",
                    TypeDescriptor.CreateProperty(typeof(MyContainerControl), "FooterPanel", typeof(Panel)));
        }
    }
}