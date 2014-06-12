using Microsoft.Practices.Prism.Modularity;

namespace PennyWatch.CommonModule
{
    [Module(ModuleName="CommonModule", OnDemand=false)]
    public class CommonModule : IModule
    {
        public void Initialize()
        {
        }
    }
}
