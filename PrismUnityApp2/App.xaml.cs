using System.Windows;

namespace PrismUnityApp2
{
    internal partial class App
    {
        protected override void OnStartup( StartupEventArgs e )
        {
            base.OnStartup( e );

            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}