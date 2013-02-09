using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.Windows;

namespace AliensOldEnemies.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class BattleViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the BattleViewModel class.
        /// </summary>
        public BattleViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real": Connect to service, etc...
            ////}
        }

        public PersonItem CurrentEnemy = new PersonItem();

        private ObservableCollection<string> _battleStatus = new ObservableCollection<string>();
        public ObservableCollection<string> BattleStatus
        {
            get
            {
                return _battleStatus;
            }
            set
            {
                _battleStatus = value;
                RaisePropertyChanged("BattleStatus");
            }
        }

        const string Kill = "Убил";
        const string Hit = "Попал";
        const string Miss = "Мимо";
        const string Panic = "Паника";
        const string Reload = "Перезарядить";
        const string RunAway = "Убежал";
        const string Suck = "Присосался";

        public void BattleStart()
        {
            ViewModelLocator.BattleStatic.BattleStatus = new ObservableCollection<string>();
            while ((CurrentEnemy.Dead == false) && (ViewModelLocator.StatusStatic.CrewAlive()==true))
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);
                PersonItem crew = ViewModelLocator.StatusStatic.Crew.First();
                string attackAction1 = "";
                switch (randomNumber)
                {
                case 1:
                 attackAction1 = crew.attack1;
                    break;
                case 2: attackAction1 = crew.attack2; break;
                case 3: attackAction1 = crew.attack3; break;
                case 4: attackAction1 = crew.attack4; break;
                case 5: attackAction1 = crew.attack5; break;
                case 6: attackAction1 = crew.attack6; break;
                };

                switch (attackAction1)
                {
                    case Hit:
                        CurrentEnemy.Health = CurrentEnemy.Health - crew.Attack;
                        ViewModelLocator.BattleStatic.BattleStatus.Add(crew.Name + " попал в " + CurrentEnemy.Name + " с атакой в " + crew.Attack.ToString());
                        break;
                    case Kill:
                        CurrentEnemy.Health = 0;
                        ViewModelLocator.BattleStatic.BattleStatus.Add(crew.Name + " убил " + CurrentEnemy.Name);
                        break;
                    case Miss:
                        ViewModelLocator.BattleStatic.BattleStatus.Add(crew.Name + " промазал мимо " + CurrentEnemy.Name);
                        break;
                    case Panic:
                        crew.Panic = true;
                        ViewModelLocator.BattleStatic.BattleStatus.Add(crew.Name + " в панике!");
                        break;
                    case Reload:
                        ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 1;
                        ViewModelLocator.BattleStatic.BattleStatus.Add(crew.Name + " перезаряжается.");
                        break;
                    default: break;
                };
                RaisePropertyChanged("BattleStatus");
            }
            RaisePropertyChanged("BattleStatus");
            MessageBox.Show("Бой закончен!");
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean own resources if needed

        ////    base.Cleanup();
        ////}
    }
}