using PennyWatch.CommonModule;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;

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
            _RegionManager.RegisterViewWithRegion("RibbonRegion", typeof(Views.HomeModuleRibbonTabView));

            _RegionManager.Regions["WorkspaceRegion"].Add(new Views.HomeModuleWorkspaceView(), "HomeModuleWorkspaceView");

            _RegionManager.RequestNavigate("WorkspaceRegion", "HomeModuleWorkspaceView");

        }
    }
}
