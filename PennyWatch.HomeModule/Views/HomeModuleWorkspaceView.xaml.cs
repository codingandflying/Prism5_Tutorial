using PennyWatch.CommonModule.BaseTypes;

namespace PennyWatch.HomeModule.Views
{
    /// <summary>
    /// Interaction logic for HomeModuleWorkspaceView.xaml
    /// </summary>
    public partial class HomeModuleWorkspaceView : WorkspaceViewBase
    {
        public HomeModuleWorkspaceView()
        {
            _ViewName = Settings.Default.WorkspaceViewName;
            InitializeComponent();
        }
    }
}
