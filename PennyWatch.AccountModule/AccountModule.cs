using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System.Configuration;

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
            string ribbonRegionName = ConfigurationManager.AppSettings["RibbonRegionName"];
            string workspaceRegionName = ConfigurationManager.AppSettings["WorkspaceRegionName"];

            _RegionManager.RegisterViewWithRegion(ribbonRegionName, typeof(Views.AccountModuleRibbonTabView));

            _RegionManager.Regions[workspaceRegionName].Add(new Views.AccountModuleWorkspaceView(), Settings.Default.WorkspaceViewName);
        }
    }
}
