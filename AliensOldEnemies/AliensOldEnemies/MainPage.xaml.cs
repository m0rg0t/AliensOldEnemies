using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Windows;

namespace AliensOldEnemies
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void HTMLViewer_HyperlinkClick(object sender, MSPToolkit.Controls.HyperlinkClickEventArgs e)
        {
            string item = e.NavigationUri.OriginalString.ToString();

            if (item.Contains("_time_-1")) {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-1","");
            };
            if (item.Contains("_time_-2"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 2;
                item = item.Replace("_time_-2", "");
            };
            if (item.Contains("_time_-3"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-3", "");
            };
            if (item.Contains("_time_-4"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-4", "");
            };
            if (item.Contains("_time_-5"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-5", "");
            };
            if (item.Contains("_time_-6"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-6", "");
            };
            if (item.Contains("_time_-7"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-7", "");
            };
            if (item.Contains("_time_-8"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time_-8", "");
            };

            if (item.Contains("_life_-1"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(-1);
                item = item.Replace("_life_-1", "");
            };
            if (item.Contains("_life_+1"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(+1);
                item = item.Replace("_life_+1", "");
            };

            if (item.Contains("_chipplata"))
            {
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" });
                item = item.Replace("_chipplata", "");
            };

            

            ViewModelLocator.MainStatic.CurrentPageId = item;
        }

        private void Inv_ItemTap(object sender, Telerik.Windows.Controls.ListBoxItemTapEventArgs e)
        {
            InvItem selected = (InvItem)this.Inv.SelectedItem;
            switch (selected.Title)
            {
                case "аптечка":
                    MessageBox.Show("Вы использовали аптечку.");
                    break;
                default: break;
            }
        }
    }
}
