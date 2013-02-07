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
                };
            }
            get
            {
                return _health;
            }
        }
        public int MaxHealth = 5;

        public int Attack = 1;

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
    }
}
