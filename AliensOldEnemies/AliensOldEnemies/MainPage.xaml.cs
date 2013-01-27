using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;

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
            ViewModelLocator.MainStatic.CurrentPageId = item;
        }
    }
}
