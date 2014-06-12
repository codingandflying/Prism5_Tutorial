using Microsoft.Practices.Prism.Regions;
using PennyWatch.CommonModule.BaseTypes;
using System.Windows.Controls.Ribbon;

namespace PennyWatch.HomeModule.Views
{
    /// <summary>
    /// Interaction logic for HomeModuleRibbonTabView.xaml
    /// </summary>
    [ViewSortHint("0")]
    public partial class HomeModuleRibbonTabView : RibbonTabViewBase
    {
        public HomeModuleRibbonTabView()
        {
            _ViewName = Settings.Default.RibbonTabViewName;
            _PairedWorkspaceViewName = Settings.Default.WorkspaceViewName;

            InitializeComponent();
        }
    }
}
