using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerSystem.Backend.Services;

namespace CustomerSystem.UI {
    public partial class LoginForm : Form {
        private readonly IAccountService _accountService;
        private Timer animationTimer;
        private Panel collapsiblePanel;
        private bool isExpanded;
        private readonly int panelCollapsedHeight = 0;

        private readonly int panelExpandedHeight = 200;
        private Button toggleButton;


        public LoginForm(IAccountService accountService) {
            _accountService = accountService;
            InitializeComponent();
            InitializeCollapsiblePanel();
        }

        private void button1_Click(object sender, EventArgs e) {
            Task.Run(() => {
                Invoke(new Action(() => {
                    Console.WriteLine($@"testaetast={_accountService.Login()}");
                    DialogResult = DialogResult.OK;
                    Close();
                }));
            });
        }

        private void button2_Click(object sender, EventArgs e) {
            using (var ofd = new OpenFileDialog()) {
                // 设置对话框的标题
                // ofd.Title = "选择一个文件";
                // 设置默认的文件类型过滤器，例如只显示文本文件 (*.txt)
                ofd.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
                // 设置是否可以多选文件，默认为 false（单选）
                ofd.Multiselect = false;
                // 设置初始目录（可选）
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // 显示 OpenFileDialog 并确定用户是否点击了“打开”按钮
                if (ofd.ShowDialog() != DialogResult.OK) return;
                // 获取用户选择的文件路径
                var filePath = ofd.FileName;
                // 在这里处理文件，例如打开文件等操作
                MessageBox.Show($"选择的文件是: {filePath}", "文件选择成功");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
        }

        private void InitializeCollapsiblePanel() {
            // 初始化面板
            collapsiblePanel = new Panel {
                BackColor = Color.LightBlue,
                Height = panelCollapsedHeight,
                Width = 300,
                Top = 50,
                Left = 20,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(collapsiblePanel);

            // 初始化按钮
            toggleButton = new Button {
                Text = "展开",
                Width = 100,
                Height = 30,
                Top = 10,
                Left = 20
            };
            toggleButton.Click += ToggleButton_Click;
            Controls.Add(toggleButton);

            // 初始化动画计时器
            animationTimer = new Timer();
            animationTimer.Interval = 1;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void ToggleButton_Click(object sender, EventArgs e) {
            isExpanded = !isExpanded;
            toggleButton.Text = isExpanded ? "收起" : "展开";
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e) {
            if (isExpanded) {
                if (collapsiblePanel.Height < panelExpandedHeight) {
                    collapsiblePanel.Height += 10;
                }
                else {
                    collapsiblePanel.Height = panelExpandedHeight;
                    animationTimer.Stop();
                }
            }
            else {
                if (collapsiblePanel.Height > panelCollapsedHeight) {
                    collapsiblePanel.Height -= 10;
                }
                else {
                    collapsiblePanel.Height = panelCollapsedHeight;
                    animationTimer.Stop();
                }
            }
        }
    }
}