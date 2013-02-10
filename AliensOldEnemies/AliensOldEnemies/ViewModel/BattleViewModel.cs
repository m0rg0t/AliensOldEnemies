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

        private bool _battle = false;
        public bool Battle
        {
            get
            {
                return _battle;
            }
            set
            {
                _battle = value;
                RaisePropertyChanged("Battle");
            }
        }

        const string Kill = "Убил";
        const string Hit = "Попал";
        const string Miss = "Мимо";
        const string Panic = "Паника";
        const string Reload = "Перезарядить";
        const string RunAway = "Убежал";
        const string Suck = "Присосался";

        private int currentCrew = 0;

        public void BattleStart(bool enemyFirstAttack=false)
        {
                Random random = new Random();
                int randomNumber = random.Next(1, 7);

                if (currentCrew > (ViewModelLocator.StatusStatic.AliveCrew.Count() - 1))
                {
                    currentCrew = 0;
                };
                PersonItem crew = ViewModelLocator.StatusStatic.AliveCrew[currentCrew];

                string attackAction1 = "";
                string attackAction2 = "";
                switch (randomNumber)
                {
                    case 1: attackAction1 = crew.attack1; break;
                    case 2: attackAction1 = crew.attack2; break;
                    case 3: attackAction1 = crew.attack3; break;
                    case 4: attackAction1 = crew.attack4; break;
                    case 5: attackAction1 = crew.attack5; break;
                    case 6: attackAction1 = crew.attack6; break;
                };

                switch (randomNumber)
                {
                    case 1: attackAction2 = CurrentEnemy.attack1; break;
                    case 2: attackAction2 = CurrentEnemy.attack2; break;
                    case 3: attackAction2 = CurrentEnemy.attack3; break;
                    case 4: attackAction2 = CurrentEnemy.attack4; break;
                    case 5: attackAction2 = CurrentEnemy.attack5; break;
                    case 6: attackAction2 = CurrentEnemy.attack6; break;
                };

                if (enemyFirstAttack == true)
                {
                    EnemyAttack(crew, attackAction2);
                    crewAttack(crew, attackAction1);
                }
                else
                {
                    crewAttack(crew, attackAction1);
                    EnemyAttack(crew, attackAction2);                    
                };

                currentCrew++;
                RaisePropertyChanged("BattleStatus");
        }

        private void crewAttack(PersonItem crew, string attackAction1)
        {
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
        }

        private void EnemyAttack(PersonItem crew, string attackAction1)
        {
            switch (attackAction1)
            {
                case Hit:
                    crew.Health = crew.Health - CurrentEnemy.Attack;
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " попал в " + crew.Name + " с атакой в " + CurrentEnemy.Attack.ToString());
                    break;
                case Kill:
                    crew.Health = 0;
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " убил " + crew.Name);
                    break;
                case Suck:
                    crew.Health = crew.Health - CurrentEnemy.Attack;
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " присосался к " + crew.Name);
                    break;
                case RunAway:
                    crew.Health = crew.Health - CurrentEnemy.Attack;
                    ViewModelLocator.BattleStatic.Battle = false;
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " убежал.");
                    break;
                case Miss:
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " промазал мимо " + crew.Name);
                    break;
                case Panic:
                    CurrentEnemy.Panic = true;
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " в панике!");
                    break;
                case Reload:
                    ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 1;
                    ViewModelLocator.BattleStatic.BattleStatus.Add(CurrentEnemy.Name + " перезаряжается.");
                    break;
                default: break;
            };
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean own resources if needed

        ////    base.Cleanup();
        ////}
    }
}