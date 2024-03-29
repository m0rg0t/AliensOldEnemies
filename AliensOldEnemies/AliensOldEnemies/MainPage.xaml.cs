﻿using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Windows;
using System;
using System.Linq;
using System.Collections.Generic;

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

            if (item.Contains("_time-1")) {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-1","");
            };
            if (item.Contains("_time-2"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 2;
                item = item.Replace("_time-2", "");
            };
            if (item.Contains("_time-3"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-3", "");
            };
            if (item.Contains("_time-4"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-4", "");
            };
            if (item.Contains("_time-5"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-5", "");
            };
            if (item.Contains("_time-6"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-6", "");
            };
            if (item.Contains("_time-7"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-7", "");
            };
            if (item.Contains("_time-8"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time - 1;
                item = item.Replace("_time-8", "");
            };

            if (item.Contains("_time+5"))
            {
                ViewModelLocator.StatusStatic.Time = ViewModelLocator.StatusStatic.Time + 5;
                item = item.Replace("_time+5", "");
            };

            if (item.Contains("_life-1"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(-1);
                item = item.Replace("_life-1", "");
            };           

            if (item.Contains("_delete_record"))
            {
                ViewModelLocator.MainStatic.delete_record = true;
                item = item.Replace("_delete_record", "");
            };

            if (item.Contains("_life+1"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(+1);
                item = item.Replace("_life+1", "");
            };

            if (item.Contains("_life-2"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(-2);
                item = item.Replace("_life-2", "");
            };
            if (item.Contains("_life+2"))
            {
                ViewModelLocator.StatusStatic.ChangeLifes(+1);
                item = item.Replace("_life+2", "");
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
                        ViewModelLocator.MainStatic.Mission1 = true;
                        break;
                };
                item = item.Replace("_tauer_send", "");
            };

            if (item.Contains("_save_mak_kolinz"))
            {
                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                ViewModelLocator.MainStatic.Mission1 = true;
                item = item.Replace("_save_mak_kolinz", "");
            };

            if (item.Contains("_unblock_angar"))
            {
                ViewModelLocator.MainStatic.unblock_angar = true;
                item = item.Replace("_unblock_angar", "");
            };
            if (item.Contains("_generator_on"))
            {
                ViewModelLocator.MainStatic.generator_on = true;
                item = item.Replace("_generator_on", "");
            };
            if (item.Contains("_unblock_doors"))
            {
                ViewModelLocator.MainStatic.unblock_doors = true;
                item = item.Replace("_unblock_doors", "");
            };
            if (item.Contains("_reactor_fixed"))
            {
                ViewModelLocator.MainStatic.Mission3 = true;
                ViewModelLocator.MainStatic.reactor_fixed = true;
                item = item.Replace("_reactor_fixed", "");
            };
            if (item.Contains("_uncorrect"))
            {
                MessageBox.Show("Неверный код. Вы потеряли -5 времени.");
                ViewModelLocator.StatusStatic.Time -= 5;
                item = item.Replace("_uncorrect", "");
            };
            if (item.Contains("_ucorrectdead"))
            {
                MessageBox.Show("Неверный код. Вас выбросило в космос... И вы умерли.");
                ViewModelLocator.StatusStatic.GameOver = false;
                item = item.Replace("_ucorrectdead", "");
            };

            if (item.Contains("_add_mak_kolinz"))
            {
                ViewModelLocator.StatusStatic.AllCrew.Add(new PersonItem() { Name = "Мак Коллинз", 
                    Image = "", Warior = false, MaxHealth = 1, Health = 1, Selected = true });
                ViewModelLocator.StatusStatic.AllCrew.FirstOrDefault(c => c.Name == "Мак Коллинз").Abilities.Add("техник");

                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                ViewModelLocator.MainStatic.Mission1 = true;
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
                        ViewModelLocator.MainStatic.Mission1 = true;
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
                ViewModelLocator.MainStatic.Mission1 = true;
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
                        ViewModelLocator.MainStatic.Mission2 = true;
                        ViewModelLocator.MainStatic.hartman_saved = true;
                        break;
                };
                item = item.Replace("_hartman_send", "");
            };

            if (item.Contains("_harrison_add"))
            {
                ViewModelLocator.StatusStatic.AllCrew.Add(new PersonItem() { Name = "Артур Харрисон", Image = "", Warior = false, MaxHealth = 1, Health = 1, Selected = true });
                ViewModelLocator.StatusStatic.AllCrew.FirstOrDefault(c => c.Name == "Артур Харрисон").Abilities.Add("дипломат");

                ViewModelLocator.MainStatic.mak_kolinz_saved = true;
                item = item.Replace("_harrison_add", "");
            };

            if (item.Contains("_mission6"))
            {
                MessageBox.Show("Вы поместили Чужого в контейнер – выполнение Миссии №6");
                ViewModelLocator.MainStatic.Mission6 = true;                
                item = item.Replace("_mission6", "");
            };

            if (item.Contains("_mission8"))
            {
                MessageBox.Show("Выполнение Миссии №8");
                ViewModelLocator.MainStatic.Mission8 = true;
                item = item.Replace("_mission8", "");
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
                        ViewModelLocator.MainStatic.Mission1 = true;
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
                        ViewModelLocator.MainStatic.Mission1 = true;
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
                ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 3;
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

            if (item.Contains("_use_oxigen"))
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "балон с кислородом"));
                item = item.Replace("_use_oxigen", "");
            };

            if (item.Contains("_throw_item_to_save_in_space"))
            {
                try
                {
                    List<string> items_throw = new List<string>() { "подойдет сварочный аппарат", "лазерный резак", "рентген-аппарат", "ремонтный комплект", "баллон с кислородом" };
                    bool throwItem = false;
                    foreach (var elem_throw in items_throw)
                    {
                        if (throwItem == false)
                        {
                            if (ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == elem_throw) != null)
                            {
                                throwItem = true;
                                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == elem_throw));
                            };
                        };
                    };
                }
                catch { };
                //ViewModelLocator.StatusStatic.InvItems.Remove
                item = item.Replace("_throw_item_to_save_in_space", "");
            };           

            if (item.Contains("_use_healthpack2"))
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
               
                item = item.Replace("_use_healthpack2", "");
            };

            if (item.Contains("_use_healthpack3"))
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c=>c.Title=="аптечка"));
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
                item = item.Replace("_use_healthpack3", "");
            };


            ViewModelLocator.StatusStatic.CrewUpdated();
            ViewModelLocator.MainStatic.CurrentPageId = item;
        }

        private void Inv_ItemTap(object sender, Telerik.Windows.Controls.ListBoxItemTapEventArgs e)
        {
            InvItem selected = (InvItem)this.Inv.SelectedItem;
            switch (selected.Title)
            {
                case "аптечка":
                    MessageBox.Show("Вы использовали аптечку.");
                    ViewModelLocator.StatusStatic.ChangeLifes(1);
                    break;
                default: break;
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
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

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/FinishGame.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            ViewModelLocator.StatusStatic.Volume = 0.5;
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            ViewModelLocator.StatusStatic.Volume = 0;
        }

        private void about_Click(object sender, EventArgs e)
        {
            try
            {
                NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
            }
            catch { };
        }


    }
}
