using Prism.Regions;

namespace PrismUnityApp2.ViewModels
{
    internal class MyViewModel : IRegionMemberLifetime
    {
        public bool KeepAlive => false;
    }
}