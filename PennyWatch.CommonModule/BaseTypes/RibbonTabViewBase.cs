using Microsoft.Practices.Prism.Regions;
using System.Windows.Controls.Ribbon;

namespace PennyWatch.CommonModule.BaseTypes
{
    public class RibbonTabViewBase : RibbonTab
    {
        protected string _ViewName = "";
        public string ViewName
        {
            get { return _ViewName; }
        }

        protected string _PairedWorkspaceViewName = "";
        public string PairedWorkspaceViewName
        {
            get { return _PairedWorkspaceViewName; }
        }
    }
}


