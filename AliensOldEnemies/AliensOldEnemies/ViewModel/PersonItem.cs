using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace AliensOldEnemies.ViewModel
{
    public class PersonItem : ViewModelBase
    {
        public PersonItem()
        {
            Type = new List<string>();
        }

        private string _name;
        public string Name
        {
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
            get
            {
                return _name;
            }
        }

        public string Description;
        private int _health = 5;
        public int Health
        {
            set
            {
                if (value <= MaxHealth)
                {
                    _health = value;
                    if (_health < 1)
                    {
                        this.Dead = true;
                    };
                };
                RaisePropertyChanged("Health");
                RaisePropertyChanged("Dead");
            }
            get
            {
                return _health;
            }
        }

        private bool _dead = false;
        public bool Dead
        {
            get
            {
                return _dead;
            }
            set
            {
                _dead = value;
                RaisePropertyChanged("Dead");
            }
        }

        private bool _away = false;
        public bool Away
        {
            get
            {
                return _away;
            }
            set
            {
                _away = value;
                RaisePropertyChanged("Away");
            }
        }

        private bool _panic = false;
        public bool Panic
        {
            get
            {
                return _panic;
            }
            set
            {
                _panic = value;
                RaisePropertyChanged("Panic");
            }
        }

        public int MaxHealth = 5;
        public int Attack = 1;

        public string attack1 = "";
        public string attack2 = "";
        public string attack3 = "";
        public string attack4 = "";
        public string attack5 = "";
        public string attack6 = "";

        private ObservableCollection<string>  _abilities = new ObservableCollection<string>();
        public ObservableCollection<string> Abilities
        {
            get
            {
                return _abilities;
            }
            set
            {
                _abilities = value;
            }
        }

        private bool _selected = false;
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                if ((ViewModelLocator.StatusStatic.CountSelectedCrew() < 4) && (value==true))
                {
                    _selected = true;
                } else {
                    _selected = false;
                };
                RaisePropertyChanged("Selected");
            }
        }



        public string AllAbilities
        {
            private set
            {
            }
            get
            {
                string out_abl = "";
                foreach (var item in Abilities)
                {
                    out_abl = item + ", ";
                };
                return out_abl.TrimEnd().TrimEnd(',');
            }
        }

        private string _image;
        public string Image
        {
            set
            {
                _image = value;
                RaisePropertyChanged("Image");
            }
            get
            {
                return _image;
            }
        }

        public List<string> Type;

        public bool IsTypeExist(string intype)
        {
            if (this.Type.FirstOrDefault(c => c == intype) == null)
            {
                return false;
            }
            else
            {
                return true;
            };
        }

        public bool AttackFirst { get; set; }
    }
}
