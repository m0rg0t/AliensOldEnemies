﻿using Microsoft.Phone.Controls;
using AliensOldEnemies.ViewModel;
using System.Collections.ObjectModel;
using System;

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
            /*try
            {
                if (NavigationService.CanGoBack)
                {
                    while (NavigationService.RemoveBackEntry() != null)
                    {
                        NavigationService.RemoveBackEntry();
                    };
                };
            }
            catch { };*/

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
                    //NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                    NavigationService.GoBack();
                }
                catch
                {
                };
            };


        }
    }
}