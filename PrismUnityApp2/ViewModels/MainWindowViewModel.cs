using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismUnityApp2.ViewModels
{
    internal class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel( IRegionManager regionManager )
        {
            RemoveCommand = new DelegateCommand( () => regionManager.Regions["ContentRegion"].RemoveAll() );
        }

        public DelegateCommand RemoveCommand { get; }
    }
}