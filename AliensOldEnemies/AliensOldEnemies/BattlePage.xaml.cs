using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;

namespace AliensOldEnemies
{
    /// <summary>
    /// Description for BattlePage.
    /// </summary>
    public partial class BattlePage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the BattlePage class.
        /// </summary>
        public BattlePage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ViewModelLocator.BattleStatic.BattleStart();
            this.BattleReport.ItemsSource = ViewModelLocator.BattleStatic.BattleStatus;
        }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                NavigationService.GoBack();
            }
            catch
            {
            };
        }
    }
}