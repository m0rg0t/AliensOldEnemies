using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Collections.ObjectModel;

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
            ViewModelLocator.BattleStatic.BattleStatus = new ObservableCollection<string>();
            this.BattleReport.ItemsSource = ViewModelLocator.BattleStatic.BattleStatus;
            ViewModelLocator.BattleStatic.Battle = true;
            ViewModelLocator.BattleStatic.BattleStart();
        }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {
            if ((ViewModelLocator.BattleStatic.Battle == true) && (ViewModelLocator.BattleStatic.CurrentEnemy.Dead == false) && (ViewModelLocator.StatusStatic.CrewAlive() == true))
            {
                ViewModelLocator.BattleStatic.BattleStart();
            }
            else
            {
                try
                {
                    NavigationService.GoBack();
                }
                catch
                {
                };
            };


        }
    }
}