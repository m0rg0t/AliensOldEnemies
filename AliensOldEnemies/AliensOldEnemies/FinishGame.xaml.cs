using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Collections.ObjectModel;

namespace AliensOldEnemies
{
    /// <summary>
    /// Description for BattlePage.
    /// </summary>
    public partial class FinishGamePage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the BattlePage class.
        /// </summary>
        public FinishGamePage()
        {
            InitializeComponent();
        }

        private void LayoutRoot_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            foreach (var item in ViewModelLocator.StatusStatic.Crew) {
                if (item.Name == "Хартман")
                {
                    ViewModelLocator.MainStatic.Mission2 = true;
                }
                else
                {
                    if (item.Warior == false)
                    {
                        ViewModelLocator.MainStatic.Mission1 = true;
                    };
                };
            };

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