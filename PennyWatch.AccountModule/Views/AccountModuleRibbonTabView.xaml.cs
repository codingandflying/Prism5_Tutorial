using Microsoft.Practices.Prism.Regions;
using PennyWatch.CommonModule.BaseTypes;
using System.Windows.Controls.Ribbon;

namespace PennyWatch.AccountModule.Views
{
    /// <summary>
    /// Interaction logic for AccountModuleRibbonTabView.xaml
    /// </summary>
    [ViewSortHint("1")]
    public partial class AccountModuleRibbonTabView : RibbonTabViewBase
    {
        public AccountModuleRibbonTabView()
        {
            _ViewName = Settings.Default.RibbonTabViewName;
            _PairedWorkspaceViewName = Settings.Default.WorkspaceViewName;
            InitializeComponent();
        }
    }
}
