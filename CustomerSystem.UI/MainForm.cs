using System;
using System.Windows.Forms;
using CustomerSystem.Backend.Services;

namespace CustomerSystem.UI {
    public partial class MainForm : Form {
        private readonly IAccountService _accountService;

        public MainForm(IAccountService accountService) {
            _accountService = accountService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var result = _accountService.Login();
            button1.Text = result;
        }
    }
}