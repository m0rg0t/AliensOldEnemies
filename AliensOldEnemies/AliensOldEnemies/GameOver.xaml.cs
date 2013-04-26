using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Collections.ObjectModel;

namespace AliensOldEnemies
{
    /// <summary>
    /// Description for BattlePage.
    /// </summary>
    public partial class GameOverPage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the BattlePage class.
        /// </summary>
        public GameOverPage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (NavigationService.CanGoBack)
                {
                    while (NavigationService.RemoveBackEntry() != null)
                    {
                        NavigationService.RemoveBackEntry();
                    };
                };
            }
            catch { };
        }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {
        }
    }
}