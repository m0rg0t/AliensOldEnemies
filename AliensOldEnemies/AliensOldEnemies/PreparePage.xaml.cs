using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System;
using System.Windows;

namespace AliensOldEnemies
{
    /// <summary>
    /// Description for PreparePage.
    /// </summary>
    public partial class PreparePage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the PreparePage class.
        /// </summary>
        public PreparePage()
        {
            InitializeComponent();

            //this.AllCrew.ItemsSource = ViewModelLocator.StatusStatic.AllCrew;
        }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {            
            try
            {
                if (ViewModelLocator.StatusStatic.CountSelectedCrew() < 4)
                {
                    MessageBox.Show("Выберите четырех бойцов для вашего отряда. Сейчас выбрано - " + ViewModelLocator.StatusStatic.CountSelectedCrew().ToString());
                }
                else
                {
                    NavigationService.Navigate(new Uri("/InvPage.xaml", UriKind.Relative));
                };
            }
            catch { };
        }

        private void AllCrew_ItemTap(object sender, Telerik.Windows.Controls.ListBoxItemTapEventArgs e)
        {
            if ((AllCrew.SelectedItem as PersonItem).Selected == true)
            {
                (AllCrew.SelectedItem as PersonItem).Selected = false;
            }
            else
            {
                (AllCrew.SelectedItem as PersonItem).Selected = true;
            };  
        }
    }
}