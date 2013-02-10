﻿using Microsoft.Phone.Controls;
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

            if (item.Contains("_use_healthpack"))
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c=>c.Title=="аптечка"));
                item = item.Replace("_use_healthpack", "");
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
