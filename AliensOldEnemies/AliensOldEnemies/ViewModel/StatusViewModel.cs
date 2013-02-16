using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

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
    public class StatusViewModel : ViewModelBase
    {
        const string Kill = "Убил";
        const string Hit = "Попал";
        const string Miss = "Мимо";
        const string Panic = "Паника";
        const string Reload = "Перезарядить";

        /// <summary>
        /// Initializes a new instance of the StatusViewModel class.
        /// </summary>
        public StatusViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real": Connect to service, etc...
            ////}
            _time = 40;
            _ammo = 40;

            AllCrew = new ObservableCollection<PersonItem>();
            InvItems = new ObservableCollection<InvItem>();

            AllCrew.Add(new PersonItem() { Name = "Силикон", Image = "/Images/Silikon.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Miss,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Живодер", Image = "/Images/Zivoder.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Hit,
                                           attack5 = Miss,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Святоша", Image = "/Images/Sviatosha.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Miss,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Голем", Image = "/Images/Golem.jpg",
                                           attack1 = Kill,
                                           attack2 = Kill,
                                           attack3 = Kill,
                                           attack4 = Miss,
                                           attack5 = Panic,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Тамагочи", Image = "/Images/Tamagochi.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Panic,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Док", Image = "/Images/Dok.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Panic,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Безумный Макс", Image = "/Images/MadMax.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Miss,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Васаби", Image = "/Images/Vasabi.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Miss,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Заноза", Image = "/Images/Zanoza.jpg",
                                           attack1 = Kill,
                                           attack2 = Kill,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Panic,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Лола", Image = "/Images/Lola.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Panic,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Криоген", Image = "/Images/Kriogen.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Miss,
                                           attack6 = Reload
            });
            AllCrew.Add(new PersonItem() { Name = "Малыш", Image = "/Images/Malish.jpg",
                                           attack1 = Hit,
                                           attack2 = Hit,
                                           attack3 = Hit,
                                           attack4 = Miss,
                                           attack5 = Panic,
                                           attack6 = Reload
            });

            AllCrew.FirstOrDefault(c => c.Name=="Силикон").Abilities.Add("программист");
            AllCrew.FirstOrDefault(c => c.Name == "Силикон").Abilities.Add("техник");
            AllCrew.FirstOrDefault(c => c.Name == "Живодер").Abilities.Add("любит деньги");
            AllCrew.FirstOrDefault(c => c.Name == "Святоша").Abilities.Add("биолог");
            AllCrew.FirstOrDefault(c => c.Name == "Тамагочи").Abilities.Add("ксено-психолог");
            AllCrew.FirstOrDefault(c => c.Name == "Тамагочи").Abilities.Add("любит деньги");
            AllCrew.FirstOrDefault(c => c.Name == "Док").Abilities.Add("доктор");
            AllCrew.FirstOrDefault(c => c.Name == "Безумный Макс").Abilities.Add("любит деньги");
            AllCrew.FirstOrDefault(c => c.Name == "Безумный Макс").Abilities.Add("программист");
            AllCrew.FirstOrDefault(c => c.Name == "Васаби").Abilities.Add("любит деньги");
            AllCrew.FirstOrDefault(c => c.Name == "Васаби").Abilities.Add("рейнджер");
            AllCrew.FirstOrDefault(c => c.Name == "Заноза").Abilities.Add("лидер");
            AllCrew.FirstOrDefault(c => c.Name == "Лола").Abilities.Add("биолог");
            AllCrew.FirstOrDefault(c => c.Name == "Криоген").Abilities.Add("лидер");
            AllCrew.FirstOrDefault(c => c.Name == "Малыш").Abilities.Add("навигатор");

            RaisePropertyChanged("AllCrew");
            RaisePropertyChanged("Crew");

            PossibleItems = new ObservableCollection<InvItem>();
            PossibleItems.Add(new InvItem() { Title = "лазерный резак", Description = "(режет биомассу и пластик)" });
            PossibleItems.Add(new InvItem() { Title = "портативный рентген-аппарат", Description = "(доктору виднее!)" });
            PossibleItems.Add(new InvItem() { Title = "чип-плата", Description = "(для ремонта всяких систем)" });
            PossibleItems.Add(new InvItem() { Title = "пенно-керамо-спрей", Description = "(для заделывания небольших пробоин в обшивке корабля; на случай диареи тоже сгодится)" });
            PossibleItems.Add(new InvItem() { Title = "аптечка", Description = "(повышает Жизнь на (+1) – жаль потенцию не повышает)" });
            PossibleItems.Add(new InvItem() { Title = "комплект из пяти скафандров", Description = "(для выхода в космос – а вы думали для чего?)" });
            PossibleItems.Add(new InvItem() { Title = "портативный сварочный аппарат", Description = "(вдруг пригодится?)" });
            PossibleItems.Add(new InvItem() { Title = "кислородный баллон", Description = "(это запас для скафандра – если кто захочет погулять подольше в открытом космосе)" });
            PossibleItems.Add(new InvItem() { Title = "таблетки \"Антишок\"", Description = "для борьбы с паникой (своей или соседа)" });
            PossibleItems.Add(new InvItem() { Title = "био-контейнер", Description = "для погружения в него образца Чужого (так сказать, «апартаменты с климат-контролем»)" });
            PossibleItems.Add(new InvItem() { Title = "шоккер", Description = "(на всякий случай)" });
            RaisePropertyChanged("PossibleItems");
        }

        public void ChangeLifes(int life) {
            foreach (var item in Crew)
            {
                item.Health = item.Health + life;
            };
        }

        public bool FindAbility(string abilityIn)
        {
            bool isFind = false;
            foreach (var item in Crew)
            {
                foreach (var abl in item.Abilities)
                {
                    if (abl == abilityIn)
                    {
                        isFind = true;
                    };
                };
            };            
            return isFind;
        }

        public bool CrewAlive()
        {
            bool isAlive = false;
            foreach (var item in Crew)
            {
                if (item.Dead==false) {
                    isAlive = true;
                };
            };
            return isAlive;
        }

        public int CountSelectedCrew() {
            int count = 0;
            foreach (var item in AllCrew)
            {
                if (item.Selected == true)
                {
                    count++;
                };
            }
            RaisePropertyChanged("Crew");
            return count;
        }

        public int CountSelectedPossibleItems()
        {
            int count = 0;
            foreach (var item in PossibleItems)
            {
                if (item.Selected == true)
                {
                    count++;
                };
            }
            RaisePropertyChanged("PossibleItems");
            return count;
        }

        public bool FindInvItem(string InvItem)
        {
            bool isFind = false;
            foreach (var item in this.InvItems)
            {
                if (InvItem == item.Title)
                {
                    isFind = true;
                };
            };
            return isFind;
        }

        public int CountInvItem(string InvItem)
        {
            int count = 0;
            foreach (var item in this.InvItems)
            {
                if (InvItem == item.Title)
                {
                    count = count + 1;
                };
            };
            return count;
        }

        public void DeleteInvItem(string InvItem)
        {
            try
            {
                this.InvItems.Remove(this.InvItems.FirstOrDefault(c => c.Title == InvItem));
            }
            catch { };
        }

        private ObservableCollection<PersonItem> _crew;
        public ObservableCollection<PersonItem> Crew
        {
            get
            {
                ObservableCollection<PersonItem> selectedCrew = new ObservableCollection<PersonItem>();
                foreach (var item in AllCrew) {
                    if (item.Selected == true)
                    {
                        selectedCrew.Add(item);
                    };
                };
                return selectedCrew;
            }
            private set
            {
                _crew = value;
                RaisePropertyChanged("Crew");
            }
        }

        public ObservableCollection<PersonItem> AliveCrew
        {
            get
            {
                ObservableCollection<PersonItem> selectedCrew = new ObservableCollection<PersonItem>();
                foreach (var item in AllCrew)
                {
                    if ((item.Selected == true) && (item.Dead==false))
                    {
                        selectedCrew.Add(item);
                    };
                };
                return selectedCrew;
            }
            private set
            {
            }
        }

        private ObservableCollection<InvItem> _invItems;
        public ObservableCollection<InvItem> InvItems
        {
            get
            {
                return _invItems;
            }
            set
            {
                _invItems = value;
                RaisePropertyChanged("InvItems");
            }
        }

        private ObservableCollection<InvItem> _possibleItems;
        public ObservableCollection<InvItem> PossibleItems
        {
            get
            {
                return _possibleItems;
            }
            set
            {
                _possibleItems = value;
                RaisePropertyChanged("PossibleItems");
            }
        }

        private ObservableCollection<PersonItem> _allCrew;
        public ObservableCollection<PersonItem> AllCrew
        {
            get
            {
                return _allCrew;
            }
            set
            {
                _allCrew = value;
                RaisePropertyChanged("AllCrew");
            }
        }

        public void CrewChanged() {
            RaisePropertyChanged("Crew");
            RaisePropertyChanged("AllCrew");
        }

        private int _time;
        public int Time
        {
            set
            {
                _time = value;
                RaisePropertyChanged("Time");
            }
            get
            {
                return _time;
            }
        }

        private int _ammo;
        public int Ammo
        {
            set
            {
                _ammo = value;
                RaisePropertyChanged("Ammo");
            }
            get
            {
                return _ammo;
            }
        }


        ////public override void Cleanup()
        ////{
        ////    // Clean own resources if needed

        ////    base.Cleanup();
        ////}
    }
}