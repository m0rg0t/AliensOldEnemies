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
            InvItems = new ObservableCollection<string>();

            AllCrew.Add(new PersonItem() { Name = "Силикон", Image = "/Images/Silikon.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Живодер", Image = "/Images/Zivoder.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Святоша", Image = "/Images/Sviatosha.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Голем", Image = "/Images/Golem.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Тамагочи", Image = "/Images/Tamagochi.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Док", Image = "/Images/Dok.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Безумный Макс", Image = "/Images/MadMax.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Васаби", Image = "/Images/Vasabi.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Заноза", Image = "/Images/Zanoza.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Лола", Image = "/Images/Lola.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Криоген", Image = "/Images/Kriogen.jpg" });
            AllCrew.Add(new PersonItem() { Name = "Малыш", Image = "/Images/Malish.jpg" });

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

        public bool FindInvItem(string InvItem)
        {
            bool isFind = false;
            foreach (string item in this.InvItems)
            {
                if (InvItem == item)
                {
                    isFind = true;
                };
            };
            return isFind;
        }

        public void DeleteInvItem(string InvItem)
        {
            try
            {
                this.InvItems.Remove(this.InvItems.FirstOrDefault(c => c == InvItem));
            }
            catch { };
        }

        private ObservableCollection<PersonItem> _crew;
        public ObservableCollection<PersonItem> Crew
        {
            get
            {
                return _crew;
            }
            set
            {
                _crew = value;
                RaisePropertyChanged("Crew");
            }
        }

        private ObservableCollection<string> _invItems;
        public ObservableCollection<string> InvItems
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