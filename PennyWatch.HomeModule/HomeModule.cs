using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System.Configuration;

namespace PennyWatch.HomeModule
{
    [Module(ModuleName = "HomeModule", OnDemand = false)]
    [ModuleDependency("DataModule")]
    [ModuleDependency("CommonModule")]
    public class HomeModule : IModule
    {
        private IUnityContainer _Container;
        private IRegionManager _RegionManager;
        private IEventAggregator _EventAggregator;

        public HomeModule(IUnityContainer container, IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _Container = container;
            _RegionManager = regionManager;
            _EventAggregator = eventAggregator;
        }

        public void Initialize()
        {
            string ribbonRegionName = ConfigurationManager.AppSettings["RibbonRegionName"];
            string workspaceRegionName = ConfigurationManager.AppSettings["WorkspaceRegionName"];

            _RegionManager.RegisterViewWithRegion(ribbonRegionName, typeof(Views.HomeModuleRibbonTabView));

            _RegionManager.Regions[workspaceRegionName].Add(new Views.HomeModuleWorkspaceView(), Settings.Default.WorkspaceViewName);

            _RegionManager.RequestNavigate(workspaceRegionName, Settings.Default.WorkspaceViewName);

        }
    }
}
