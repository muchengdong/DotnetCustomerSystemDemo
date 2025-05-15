using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerSystem.Backend.Models;
using CustomerSystem.Backend.Services;

namespace CustomerSystem.UI
{
    public partial class LoginForm : Form
    {

        private readonly IAccountService _accountService;

        public LoginForm(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine($@"testaetast={_accountService.Login()}");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var ofd = new OpenFileDialog())
            {
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
    }
}
