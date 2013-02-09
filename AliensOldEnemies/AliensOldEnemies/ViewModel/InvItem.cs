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
using GalaSoft.MvvmLight;

namespace AliensOldEnemies.ViewModel
{
    public class InvItem : ViewModelBase
    {
        public InvItem()
        {

        }

        private string _title;
        public string Title
        {
            set
            {
                _title = value;
                RaisePropertyChanged("Title");
            }
            get
            {
                return _title;
            }
        }

        private string _description;
        public string Description
        {
            set
            {
                _description = value;
                RaisePropertyChanged("Description");
            }
            get
            {
                return _description;
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
                if ((ViewModelLocator.StatusStatic.CountSelectedPossibleItems() < 5) && (value == true))
                {
                    _selected = true;
                }
                else
                {
                    _selected = false;
                };
                RaisePropertyChanged("Selected");
            }
        }
    }
}
