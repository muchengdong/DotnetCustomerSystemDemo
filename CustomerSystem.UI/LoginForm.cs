using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


            Console.WriteLine($"testaetast={_accountService.Login()}");

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
