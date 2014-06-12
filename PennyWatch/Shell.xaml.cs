using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using PennyWatch.CommonModule.BaseTypes;
using System.Windows.Controls.Ribbon;

namespace PennyWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ribbon_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var ribbon = sender as Ribbon;
            var tab = ribbon.SelectedItem as RibbonTabViewBase;

            //Get the default container and using the container get the singleton region manager
            var container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            var regionManager = container.Resolve<IRegionManager>();

            //Request to navigate to the selected workspace view
            regionManager.RequestNavigate(_DataContext.WorkspaceRegionName, tab.PairedWorkspaceViewName);
        }
    }
}
