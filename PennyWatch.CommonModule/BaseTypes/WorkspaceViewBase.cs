using Microsoft.Practices.Prism.Regions;
using System.Windows.Controls;

namespace PennyWatch.CommonModule.BaseTypes
{
    public class WorkspaceViewBase : UserControl, IRegionMemberLifetime
    {
        protected bool _KeepAlive = true;
        public bool KeepAlive
        {
            get { return _KeepAlive; }
        }

        protected string _ViewName = "";
        public string ViewName
        {
            get { return _ViewName; }
        }
    }
}