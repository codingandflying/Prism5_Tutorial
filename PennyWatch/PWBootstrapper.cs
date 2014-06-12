using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;

namespace PennyWatch
{
    class PWBootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Creates and returns a directory module catalog.
        /// </summary>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog();
        }

        /// <summary>
        /// Sets the directory that will host the modules
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            ((DirectoryModuleCatalog)this.ModuleCatalog).ModulePath = @".\Modules";
        }

        /// <summary>
        /// Returns a MainWindow instance to be used as the shell
        /// </summary>
        /// <returns></returns>
        protected override System.Windows.DependencyObject CreateShell()
        {
            return new MainWindow();
        }

        /// <summary>
        /// Sets the application's main window to the shell window and displays it
        /// </summary>
        protected override void InitializeShell()
        {
            Application.Current.MainWindow = this.Shell as Window;
            Application.Current.MainWindow.Show();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
        }
    }
}
