using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace PennyWatch.AccountModule
{
    [Module(ModuleName = "AccountModule", OnDemand = false)]
    [ModuleDependency("DataModule")]
    [ModuleDependency("CommonModule")]
    public class AccountModule : IModule
    {
        private IUnityContainer _Container;
        private IRegionManager _RegionManager;
        private IEventAggregator _EventAggregator;

        public AccountModule(IUnityContainer container, IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _Container = container;
            _RegionManager = regionManager;
            _EventAggregator = eventAggregator;
        }   
        
        public void Initialize()
        {
            _RegionManager.RegisterViewWithRegion("RibbonRegion", typeof(Views.AccountModuleRibbonTabView));
            
            _RegionManager.Regions["WorkspaceRegion"].Add(new Views.AccountModuleWorkspaceView(), "AccountModuleWorkspaceView");
        }
    }
}
