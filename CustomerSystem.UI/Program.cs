using System;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using CustomerSystem.Backend;

namespace CustomerSystem.UI {
    internal static class Program {
        /// <summary>
        ///     应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Assembly assem = typeof(Program).Assembly;
         
            
             

            Console.WriteLine("Assembly Full Name:");
            Console.WriteLine(assem.GetName().Version.ToString());
            //
            // Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            //
            // foreach (var assembly in assemblies)
            // {
            //     Console.WriteLine("\nName: {0}", assembly.GetName());
            //
            // }

            var builder = new ContainerBuilder();
            builder.RegisterModule<BackendModule>();
            builder.RegisterType<LoginForm>();
            builder.RegisterType<MainForm>();
            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope()) {
                // var loginForm = scope.Resolve<LoginForm>();
                // var dialogResult = loginForm.ShowDialog();
                // if (!DialogResult.OK.Equals(dialogResult)) return;
                var mainForm = scope.Resolve<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}