using Microsoft.Practices.Prism.Modularity;

namespace PennyWatch.DataModule
{
    [Module(ModuleName = "DataModule", OnDemand = false)]
    [ModuleDependency("CommonModule")]
    public class DataModule : IModule
    {
        public void Initialize()
        {
            
        }
    }
}
