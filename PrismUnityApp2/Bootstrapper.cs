using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismUnityApp2.Views;
using System.Windows;
using Prism.Regions;

namespace PrismUnityApp2
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            Container.RegisterTypeForNavigation<MyView>( nameof( MyView ) );
            base.ConfigureContainer();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
            Container.Resolve<IRegionManager>().RequestNavigate( "ContentRegion", nameof( MyView ) );
        }
    }
}