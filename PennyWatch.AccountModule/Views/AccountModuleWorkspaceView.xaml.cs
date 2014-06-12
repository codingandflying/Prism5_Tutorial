using PennyWatch.CommonModule.BaseTypes;

namespace PennyWatch.AccountModule.Views
{
    /// <summary>
    /// Interaction logic for AccountModuleWorkspaceView.xaml
    /// </summary>
    public partial class AccountModuleWorkspaceView : WorkspaceViewBase
    {
        public AccountModuleWorkspaceView()
        {
            _ViewName = Settings.Default.WorkspaceViewName;
            InitializeComponent();
        }
    }
}
