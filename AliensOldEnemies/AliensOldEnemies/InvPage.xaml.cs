using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System;
using System.Collections.ObjectModel;

namespace AliensOldEnemies
{
    /// <summary>
    /// Description for InvPage.
    /// </summary>
    public partial class InvPage : PhoneApplicationPage
    {
        private ObservableCollection<InvItem> selected_items;
        /// <summary>
        /// Initializes a new instance of the InvPage class.
        /// </summary>
        public InvPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                    selected_items = new ObservableCollection<InvItem>();
                    foreach (var item in ViewModelLocator.StatusStatic.PossibleItems)
                    {
                        if (item.Selected == true)
                        {
                            if (item.Title == "комплект из пяти скафандров")
                            {
                                selected_items.Add(new InvItem() { Title="скафандр"});
                            }
                            else
                            {
                                selected_items.Add(item);
                            };
                        };                        
                    }
                    ViewModelLocator.StatusStatic.InvItems = selected_items;
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            catch { };
        }

        private void PossibleItems_ItemTap(object sender, Telerik.Windows.Controls.ListBoxItemTapEventArgs e)
        {
            if ((PossibleItems.SelectedItem as InvItem).Selected == true)
            {
                (PossibleItems.SelectedItem as InvItem).Selected = false;
            }
            else
            {
                (PossibleItems.SelectedItem as InvItem).Selected = true;
            };            
        }
    }
}