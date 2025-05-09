using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using CustomerSystem.Backend;
using CustomerSystem.Backend.Services;

namespace CustomerSystem.UI
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterModule<BackendModule>();
            builder.RegisterType<LoginForm>();
            builder.RegisterType<MainForm>();
            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var loginForm = scope.Resolve<LoginForm>();
                var dialogResult = loginForm.ShowDialog();
                if (!DialogResult.OK.Equals(dialogResult)) return;
                var mainForm = scope.Resolve<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}