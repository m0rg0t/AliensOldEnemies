using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Windows;
using System;
using System.Linq;

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
            if (item.Contains("_life_-2"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(-2);
                item = item.Replace("_life_-2", "");
            };
            if (item.Contains("_life_+1"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(+1);
                item = item.Replace("_life_+1", "");
            };

            if (item.Contains("_a30_tauer"))
            {
                ViewModelLocator.MainStatic.a30_tauer = true;
                item = item.Replace("_a30_tauer", "");
            };

            if (item.Contains("_tauer_add"))
            {
                //30 - тауер добавлен к команде
                ViewModelLocator.MainStatic.a30_tauer_added = true;
                MessageBox.Show("Техник Тауэр добавлен к вашей команде.");
                item = item.Replace("_tauer_add", "");
            };

            if (item.Contains("_tauer_send"))
            {
                //30 - тауер отправлен в шатл
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                switch (randomNumber)
                {
                    case 5:
                        ViewModelLocator.MainStatic.a30_tauer_saved = false;
                        MessageBox.Show("Техник Тауэр погиб по пути к вашему шаттлу.");
                        break;
                    case 6:
                        MessageBox.Show("Техник Тауэр был убит по пути к вашему шаттлу.");
                        ViewModelLocator.MainStatic.a30_tauer_saved = false;
                        break;
                    default:
                        MessageBox.Show("Техник Тауэр добрался до шаттла.");
                        ViewModelLocator.MainStatic.a30_tauer_saved = true;
                        break;
                };
                item = item.Replace("_tauer_send", "");
            };

            if (item.Contains("_save_mak_kolinz"))
            {
                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                item = item.Replace("_save_mak_kolinz", "");
            };

            if (item.Contains("_add_mak_kolinz"))
            {
                ViewModelLocator.StatusStatic.AllCrew.Add(new PersonItem() { Name = "Мак Коллинз", 
                    Image = "", Warior = false, MaxHealth = 1, Health = 1, Selected = true });
                ViewModelLocator.StatusStatic.AllCrew.FirstOrDefault(c => c.Name == "Мак Коллинз").Abilities.Add("техник");

                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                item = item.Replace("_add_mak_kolinz", "");
            };

            if (item.Contains("_save_livengaup"))
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                switch (randomNumber)
                {
                    case 5:
                        ViewModelLocator.MainStatic.livengaup_saved = false;
                        MessageBox.Show("Ливенгауп погиб по пути к вашему шаттлу.");
                        break;
                    case 6:
                        MessageBox.Show("Ливенгауп был убит по пути к вашему шаттлу.");
                        ViewModelLocator.MainStatic.livengaup_saved = false;
                        break;
                    default:
                        MessageBox.Show("Доктор Ливенгауп добрался до шаттла.");
                        ViewModelLocator.MainStatic.livengaup_saved = true;
                        break;
                };
                item = item.Replace("_save_livengaup", "");
            };

            if (item.Contains("_livengaup_add"))
            {
                ViewModelLocator.StatusStatic.AllCrew.Add(new PersonItem() 
                    { Name = "Ливенгауп", Image = "", Warior=false, MaxHealth=1, Health=1, Selected=true});
                ViewModelLocator.StatusStatic.AllCrew.FirstOrDefault(c => c.Name == "Ливенгауп").Abilities.Add("доктор");

                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                item = item.Replace("_livengaup_add", "");
            };

            if (item.Contains("_hartman_add"))
            {
                ViewModelLocator.StatusStatic.AllCrew.Add(new PersonItem() { Name = "Хартман", Image = "", Warior = false, MaxHealth = 1, Health = 1, Selected = true });
                ViewModelLocator.StatusStatic.AllCrew.FirstOrDefault(c => c.Name == "Хартман").Abilities.Add("офицер безопасности");

                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                item = item.Replace("_hartman_add", "");
            };
            if (item.Contains("_hartman_send"))
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                switch (randomNumber)
                {
                    case 5:
                        ViewModelLocator.MainStatic.hartman_saved = false;
                        MessageBox.Show("Хартман погиб по пути к вашему шаттлу.");
                        break;
                    case 6:
                        MessageBox.Show("Хартман был убит по пути к вашему шаттлу.");
                        ViewModelLocator.MainStatic.hartman_saved = false;
                        break;
                    default:
                        MessageBox.Show("Хартман добрался до шаттла.");
                        ViewModelLocator.MainStatic.hartman_saved = true;
                        break;
                };
                item = item.Replace("_hartman_send", "");
            };
            

            if (item.Contains("_mission6"))
            {
                MessageBox.Show("Вы поместили Чужого в контейнер – выполнение Миссии №6");
                ViewModelLocator.MainStatic.Mission6 = true;                
                item = item.Replace("_mission6", "");
            };

            if (item.Contains("_vagner_send"))
            {
                //54 - dfuyth d ifnk
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                ViewModelLocator.MainStatic.a54_vagner_send = true;
                switch (randomNumber)
                {
                    case 5:
                        ViewModelLocator.MainStatic.a54_vagner_saved = false;
                        MessageBox.Show("Джоанна Вагнер погибла по пути к вашему шаттлу.");
                        break;
                    case 6:
                        MessageBox.Show("Джоанна Вагнер была убита по пути к вашему шаттлу.");
                        ViewModelLocator.MainStatic.a54_vagner_saved = false;
                        break;
                    default:
                        MessageBox.Show("Джоанна Вагнер добралась до шаттла.");
                        ViewModelLocator.MainStatic.a54_vagner_saved = true;
                        break;
                };
                item = item.Replace("_vagner_send", "");
            };

            if (item.Contains("_juzepe_add"))
            {
                //30 - тауер добавлен к команде
                ViewModelLocator.MainStatic.a46_juzepe_added = true;
                MessageBox.Show("Джузеппе (повар) добавлен к вашей команде.");
                item = item.Replace("_juzepe_add", "");
            };

            if (item.Contains("_juzepe_send"))
            {
                //46 - джузепе отправлен в шатл
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                switch (randomNumber)
                {
                    case 5:
                        ViewModelLocator.MainStatic.a46_juzepe_saved = false;
                        MessageBox.Show("Джузеппе (повар) погиб по пути к вашему шаттлу.");
                        break;
                    case 6:
                        MessageBox.Show("Джузеппе (повар) был убит по пути к вашему шаттлу.");
                        ViewModelLocator.MainStatic.a46_juzepe_saved = false;
                        break;
                    default:
                        MessageBox.Show("Джузеппе (повар) добрался до шаттла.");
                        ViewModelLocator.MainStatic.a46_juzepe_saved = true;
                        break;
                };
                item = item.Replace("_juzepe_send", "");
            };  


            if (item.Contains("_chipplata"))
            {
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" });
                item = item.Replace("_chipplata", "");
            };

            if (item.Contains("_ammo-1"))
            {
                ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 1;
                item = item.Replace("_ammo-1", "");
            };
            if (item.Contains("_ammo-2"))
            {
                ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 2;
                item = item.Replace("_ammo-2", "");
            };
            if (item.Contains("_ammo-3"))
            {
                ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo -3;
                item = item.Replace("_ammo-3", "");
            };
            if (item.Contains("_ammo-4"))
            {
                ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 4;
                item = item.Replace("_ammo-4", "");
            };

            if (item.Contains("_biolog_dead"))
            {
                ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Abilities.FirstOrDefault(a => a == "биолог") != null).Dead = true;
                item = item.Replace("_biolog_dead", "");
            };

            if (item.Contains("_a139_event"))
            {
                ViewModelLocator.MainStatic.a139_event = true;
                item = item.Replace("_a139_event", "");
            };
            

            if (item.Contains("_use_healthpack"))
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c=>c.Title=="аптечка"));
                item = item.Replace("_use_healthpack", "");
            };

            if (item.Contains("_use_healthpack3"))
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c=>c.Title=="аптечка"));
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
                item = item.Replace("_use_healthpack3", "");
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
