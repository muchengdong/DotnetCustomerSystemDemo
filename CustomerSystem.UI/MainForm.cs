using AntdUI;
using CustomerSystem.Backend.Services;

namespace CustomerSystem.UI {
    public partial class MainForm : Window {
        private readonly IAccountService _accountService;

        public MainForm(IAccountService accountService) {
            _accountService = accountService;
            InitializeComponent();
        }
    }
}