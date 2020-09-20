using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Unity;
using WPFApplication.Views;
using Microsoft.Practices.Unity;
using WPFApplicationCommon;

namespace WPFApplication.Module
{
    public class Bootstrapper: UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            Type phoneModuleType = typeof(PhoneModule);
            ModuleCatalog.AddModule(new Prism.Modularity.ModuleInfo { ModuleName=phoneModuleType.Name, ModuleType = phoneModuleType.AssemblyQualifiedName});
        }
    }
}
