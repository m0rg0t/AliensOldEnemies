using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace AliensOldEnemies.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
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
    public class MainViewModel : ViewModelBase
    {
        public string ApplicationTitle
        {
            get
            {
                return "Чужие – старые враги";
            }
        }

        private string _bgImage = "/images/The_Darkness_of_Space_by_qaz2008.jpg";
        public string BgImage {
            get
            {
                return _bgImage;
            }
            set
            {
                _bgImage = value;
                RaisePropertyChanged("BgImage");
            }
    }

        public string PageName
        {
            get
            {
                try
                {
                    return CurrentPage.Title;
                }
                catch { return ""; };
            }
        }

        public string Music
        {
            get
            {
                try
                {
                    return CurrentPage.Music;
                }
                catch { return ""; };
            }
        }

        public string Description
        {
            get
            {
                try
                {
                    return CurrentPage.Description + PathsSelect(CurrentPageId)+"<br><br>";
                }
                catch { return ""; };
            }
        }

        public PageItem CurrentPage
        {
            private set { }
            get
            {
                PageItem outPage = this.Pages.FirstOrDefault(c => c.Id==this.CurrentPageId);
                if (outPage==null)
                {
                    outPage = this.Pages.FirstOrDefault(c => c.Id == this._previousPage);
                };
                return outPage;
            }
        }

        private string _previousPage = "";
        private string _currentPage = "";
        public string CurrentPageId
        {
            get { 
                return _currentPage;  
            }
            set {
                _previousPage = _currentPage;
                _currentPage = value;
                RaisePropertyChanged("Title");
                RaisePropertyChanged("Description");
                RaisePropertyChanged("Music");
                RaisePropertyChanged("CurrentPage");
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
                this.CurrentPageId = "/intro";
                Pages = new ObservableCollection<PageItem>();
                Pages.Add(new PageItem { 
                    Title="Введение", 
                    Description = Texts.Introduction, 
                    Id = "/intro", 
                    Music="/Music/Bent_and_Broken.mp3" });
                Pages.Add(new PageItem
                {
                    Title = "Введение",
                    Description = Texts.Missions,
                    Id = "/intro2",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Начало",
                    Description = Texts.Start,
                    Id = "/start",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ангар",
                    Description = Texts.a1,
                    Id = "/1",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Температура",
                    Description = Texts.a2,
                    Id = "/2",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дверь",
                    Description = Texts.a3,
                    Id = "/3",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Убит",
                    Description = Texts.a4,
                    Id = "/4",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мак Коллинз",
                    Description = Texts.a5,
                    Id = "/5",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Погрузчик",
                    Description = "",
                    Id = "/6",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Вопросы",
                    Description = Texts.a7,
                    Id = "/7",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a8,
                    Id = "/8",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Воздуховоды",
                    Description = Texts.a9,
                    Id = "/9",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Температура",
                    Description = Texts.a10,
                    Id = "/10",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ситуация",
                    Description = Texts.a11,
                    Id = "/11",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Нападение",
                    Description = Texts.a12,
                    Id = "/12",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Технический отсек",
                    Description = Texts.a13,
                    Id = "/13",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Труп Чужого",
                    Description = Texts.a14,
                    Id = "/14",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Труп Чужого",
                    Description = Texts.a15,
                    Id = "/15",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Роберт Фул",
                    Description = Texts.a15,
                    Id = "/16",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пищеблок",
                    Description = Texts.a17,
                    Id = "/17",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Лазарет",
                    Description = Texts.a18,
                    Id = "/18",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a19,
                    Id = "/19",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Инженерный отсек",
                    Description = Texts.a20,
                    Id = "/20",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Осмотр отсека",
                    Description = "",
                    Id = "/20_check",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Кровавый след",
                    Description = Texts.a21,
                    Id = "/21",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Сюзанна Мур",
                    Description = Texts.a22,
                    Id = "/22",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a22,
                    Id = "/23",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Труп",
                    Description = Texts.a24,
                    Id = "/24",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "доктор Ливенгауп",
                    Description = Texts.a25,
                    Id = "/25",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пусто",
                    Description = Texts.a26,
                    Id = "/26",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Женщина",
                    Description = "",
                    Id = "/27",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Женщина",
                    Description = "",
                    Id = "/28",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Тауер",
                    Description = "",
                    Id = "/29",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Тауер",
                    Description = Texts.a30,
                    Id = "/30",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пусто",
                    Description = Texts.a31,
                    Id = "/31",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Лифт",
                    Description = Texts.a32,
                    Id = "/32",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Грузовой лифт",
                    Description = Texts.a33,
                    Id = "/33",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Не заражен",
                    Description = Texts.a34,
                    Id = "/34",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "События",
                    Description = Texts.a35,
                    Id = "/35",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a36,
                    Id = "/36",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Температура",
                    Description = Texts.a37,
                    Id = "/37",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Исток",
                    Description = Texts.a38,
                    Id = "/38",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Осмотр",
                    Description = Texts.a39,
                    Id = "/39",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Осмотр",
                    Description = "",
                    Id = "/40",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пищеблок",
                    Description = Texts.a41,
                    Id = "/41",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пищеблок",
                    Description = Texts.a42,
                    Id = "/42",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Авария",
                    Description = Texts.a43,
                    Id = "/43",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a44,
                    Id = "/44",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Сумасшедший",
                    Description = "",
                    Id = "/45",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Сумасшедший",
                    Description = "",
                    Id = "/46",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Зародыш",
                    Description = Texts.a47,
                    Id = "/47",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Вопросы",
                    Description = Texts.a48,
                    Id = "/48",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Атака",
                    Description = Texts.a49,
                    Id = "/49",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a50,
                    Id = "/50",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Исток",
                    Description = Texts.a51,
                    Id = "/51",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пациентка",
                    Description = Texts.a52,
                    Id = "/52",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a53,
                    Id = "/53",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Джоанна Вагнер",
                    Description = Texts.a54,
                    Id = "/54",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Биолог",
                    Description = Texts.a55,
                    Id = "/55",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Биолог",
                    Description = Texts.a56,
                    Id = "/56",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a57,
                    Id = "/57",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = "",
                    Id = "/58",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Краб",
                    Description = Texts.a59,
                    Id = "/59",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "КОРИДОР «С»",
                    Description = Texts.a60,
                    Id = "/60",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a61,
                    Id = "/61",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = "",
                    Id = "/62",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неизвестный",
                    Description = Texts.a63,
                    Id = "/63",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Инженерный отсек",
                    Description = Texts.a64,
                    Id = "/64",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Инженерный отсек",
                    Description = Texts.a65,
                    Id = "/65",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Инженерный отсек",
                    Description = Texts.a66,
                    Id = "/66",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = "",
                    Id = "/67",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a68,
                    Id = "/68",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Атака",
                    Description = "",
                    Id = "/69",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Хартман",
                    Description = Texts.a70,
                    Id = "/70",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a71,
                    Id = "/71",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a72,
                    Id = "/72",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пусто",
                    Description = Texts.a73,
                    Id = "/73",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Начало нападения",
                    Description = Texts.a74,
                    Id = "/74",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Зародыш",
                    Description = Texts.a75,
                    Id = "/75",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Пусто",
                    Description = Texts.a76,
                    Id = "/76",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a77,
                    Id = "/77",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Королева",
                    Description = Texts.a78,
                    Id = "/78",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Хартман",
                    Description = Texts.a79,
                    Id = "/79",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мастерские",
                    Description = Texts.a80,
                    Id = "/80",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Сейф",
                    Description = Texts.a81,
                    Id = "/81",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a82,
                    Id = "/82",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неудача",
                    Description = Texts.a83,
                    Id = "/83",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты – событие",
                    Description = Texts.a84,
                    Id = "/84",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a85,
                    Id = "/85",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты – событие",
                    Description = Texts.a86,
                    Id = "/86",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a87,
                    Id = "/87",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a88,
                    Id = "/88",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a89,
                    Id = "/89",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Грузовой лифт",
                    Description = Texts.a90,
                    Id = "/90",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Лаборатория",
                    Description = Texts.a91,
                    Id = "/91",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Сейф",
                    Description = Texts.a93,
                    Id = "/93",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a94,
                    Id = "/94",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Заражен",
                    Description = Texts.a95,
                    Id = "/95",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мародерство",
                    Description = "",
                    Id = "/96",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Обыск",
                    Description = Texts.a97,
                    Id = "/97",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Предатель",
                    Description = Texts.a98,
                    Id = "/98",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Сейф",
                    Description = Texts.a99,
                    Id = "/99",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Деньги",
                    Description = Texts.a101,
                    Id = "/101",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Деньги",
                    Description = Texts.a102,
                    Id = "/102",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Драка",
                    Description = Texts.a103,
                    Id = "/103",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Спор",
                    Description = Texts.a104,
                    Id = "/104",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Драка",
                    Description = Texts.a105,
                    Id = "/105",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Драка",
                    Description = "",
                    Id = "/106",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a107,
                    Id = "/107",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a108,
                    Id = "/108",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a109,
                    Id = "/109",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор Е",
                    Description = Texts.a110,
                    Id = "/110",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a111,
                    Id = "/111",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a112,
                    Id = "/112",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a113,
                    Id = "/113",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a114,
                    Id = "/114",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a115,
                    Id = "/115",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Дипломат",
                    Description = Texts.a116,
                    Id = "/116",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a117,
                    Id = "/117",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                //118 - null

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a119,
                    Id = "/119",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Оранжерея",
                    Description = Texts.a120,
                    Id = "/120",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Оранжерея",
                    Description = Texts.a121,
                    Id = "/121",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Оранжерея",
                    Description = Texts.a122,
                    Id = "/122",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Оранжерея",
                    Description = Texts.a123,
                    Id = "/123",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Оранжерея",
                    Description = Texts.a124,
                    Id = "/124",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Живодер",
                    Description = Texts.a125,
                    Id = "/125",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Святоша",
                    Description = Texts.a126,
                    Id = "/126",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Святоша",
                    Description = Texts.a127,
                    Id = "/127",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор D",
                    Description = Texts.a128,
                    Id = "/128",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Робот",
                    Description = Texts.a129,
                    Id = "/129",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор «D» - Событие",
                    Description = Texts.a134,
                    Id = "/134",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор «С»",
                    Description = Texts.a137,
                    Id = "/137",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор «С»",
                    Description = Texts.a138,
                    Id = "/138",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор «С»",
                    Description = Texts.a139,
                    Id = "/139",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Реактор",
                    Description = Texts.a140,
                    Id = "/140",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Монтгомери",
                    Description = Texts.a141,
                    Id = "/141",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Монтгомери",
                    Description = "",
                    Id = "/142",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a143,
                    Id = "/143",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a144,
                    Id = "/144",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a145,
                    Id = "/145",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a146,
                    Id = "/146",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a147,
                    Id = "/147",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Арсенал",
                    Description = Texts.a148,
                    Id = "/148",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Лифт",
                    Description = Texts.a149,
                    Id = "/149",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор «В»",
                    Description = Texts.a150,
                    Id = "/150",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Событие",
                    Description = Texts.a151,
                    Id = "/151",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Событие",
                    Description = "",
                    Id = "/152",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Событие",
                    Description = Texts.a153,
                    Id = "/153",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Событие",
                    Description = Texts.a154,
                    Id = "/154",
                    Music = "/Music/Bent_and_Broken.mp3"
                });
                
                Pages.Add(new PageItem
                {
                    Title = "Событие",
                    Description = Texts.a155,
                    Id = "/155",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Код",
                    Description = Texts.a156,
                    Id = "/156",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мертв",
                    Description = Texts.a157,
                    Id = "/157",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ранение",
                    Description = Texts.a158,
                    Id = "/158",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чанг-Фу",
                    Description = Texts.a159,
                    Id = "/159",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Выбор",
                    Description = Texts.a160,
                    Id = "/160",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Событие",
                    Description = Texts.a161,
                    Id = "/161",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мастерские",
                    Description = Texts.a162,
                    Id = "/162",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мастерские",
                    Description = Texts.a163,
                    Id = "/163",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Паника",
                    Description = Texts.a164,
                    Id = "/164",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Отключено",
                    Description = Texts.a165,
                    Id = "/165",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чанг-Фу",
                    Description = Texts.a166,
                    Id = "/166",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Утечка",
                    Description = Texts.a167,
                    Id = "/167",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Утечка",
                    Description = Texts.a168,
                    Id = "/168",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Коридор Е",
                    Description = Texts.a169,
                    Id = "/169",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "КОРИДОР «А»",
                    Description = "Из этого коридора одна дверь ведет в Рубку, другая в Инженерный отсек, третья в Коридор «В».",
                    Id = "/170",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a171,
                    Id = "/171",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a171,
                    Id = "/172",
                    Music = "/Music/Bent_and_Broken.mp3"
                });


                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a171,
                    Id = "/173",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Правильно",
                    Description = Texts.a174,
                    Id = "/174",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a171,
                    Id = "/175",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a176,
                    Id = "/176",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a171,
                    Id = "/177",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a171,
                    Id = "/178",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a179,
                    Id = "/179",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/180",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/181",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/182",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a183,
                    Id = "/183",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/184",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/185",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a186,
                    Id = "/186",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/187",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Ошибка!",
                    Description = Texts.a180,
                    Id = "/188",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Потери",
                    Description = Texts.a189,
                    Id = "/189",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Бассейн",
                    Description = Texts.a190,
                    Id = "/190",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Тоннель",
                    Description = Texts.a191,
                    Id = "/191",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Тоннель",
                    Description = Texts.a192,
                    Id = "/192",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Вопрос №3",
                    Description = Texts.a251,
                    Id = "/251",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Вопрос №4",
                    Description = Texts.a251,
                    Id = "/251",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Верно",
                    Description = Texts.a253,
                    Id = "/253",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Верно",
                    Description = Texts.a254,
                    Id = "/254",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a255,
                    Id = "/255",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Тревога",
                    Description = Texts.a256,
                    Id = "/256",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a257,
                    Id = "/257",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a260,
                    Id = "/258",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a260,
                    Id = "/259",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a260,
                    Id = "/260",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a260,
                    Id = "/261",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Верно",
                    Description = Texts.a262,
                    Id = "/262",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Верно",
                    Description = Texts.a263,
                    Id = "/263",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a264,
                    Id = "/264",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a265,
                    Id = "/265",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a266,
                    Id = "/266",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Верно",
                    Description = Texts.a267,
                    Id = "/267",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a268,
                    Id = "/268",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a268,
                    Id = "/269",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Вы не человек",
                    Description = Texts.a273,
                    Id = "/273",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Вы человек",
                    Description = Texts.a274,
                    Id = "/274",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Верно",
                    Description = Texts.a275,
                    Id = "/275",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неверно",
                    Description = Texts.a277,
                    Id = "/277",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Бассейн",
                    Description = Texts.a279,
                    Id = "/279",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Удача",
                    Description = Texts.a285,
                    Id = "/285",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Репелент",
                    Description = Texts.a287,
                    Id = "/287",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неудача",
                    Description = Texts.a288,
                    Id = "/288",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "К пробоине",
                    Description = Texts.a289,
                    Id = "/289",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Удача",
                    Description = Texts.a290,
                    Id = "/290",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неудача",
                    Description = Texts.a291,
                    Id = "/291",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Неудача",
                    Description = Texts.a292,
                    Id = "/292",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Удача",
                    Description = Texts.a293,
                    Id = "/293",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мародерство",
                    Description = Texts.a294,
                    Id = "/294",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Мародерство",
                    Description = Texts.a295,
                    Id = "/295",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a296,
                    Id = "/296",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "",
                    Description = "",
                    Id = "/297",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Порядок",
                    Description = Texts.a298,
                    Id = "/298",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a299,
                    Id = "/299",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a300,
                    Id = "/300",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "",
                    Description = "",
                    Id = "/301",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Чужой",
                    Description = Texts.a302,
                    Id = "/302",
                    Music = "/Music/Bent_and_Broken.mp3"
                });                
            }

        }

        public string PathsSelect(string page) {
            switch (page) {
                case "/1": return angar();
                case "/47": return a47();
                case "/41": return a41();
                case "/14": return a14();
                case "/a2": ViewModelLocator.StatusStatic.ChangeLifes(-1); return "";
                case "/a15": ViewModelLocator.StatusStatic.ChangeLifes(-1); return "";                
                case "/6": return a6();
                case "/13": return techroom();
                case "/17": return a17();
                case "/18": return a18();
                case "/19": return a19();
                case "/20": return a20();
                case "/20_check": return a20_check();
                case "/27": return a27();
                case "/28": return a28();
                case "/29": return a29();
                case "/32": return a32();
                case "/60": return a60();
                case "/139": return a139();
                case "/30": return a30();
                case "/33": return a33();
                case "/40": return a40();
                case "/45": return a45();
                case "/46": return a46();
                case "/53": return a53();
                case "/54": return a54();
                case "/55": return a55();
                case "/56": return a56();
                case "/58": return a58();
                case "/59": return a59();
                case "/61": return a61();
                case "/62": return a62();
                case "/63": return a63();
                case "/64": return a64();
                case "/65": return a65();
                case "/66": return a66();
                case "/67": return a67();
                case "/68": return a68();
                case "/69": return a69();
                case "/71": return a71();
                case "/79": return a79();
                case "/80": return a80();
                case "/81": return a81();
                case "/82": return a82();
                case "/85": return a85();
                case "/88": return a88();
                case "/89": return a89();
                case "/90": return a90();
                case "/91": return a91();
                case "/95": return a95();
                case "/96": return a96();
                case "/98": return a98();
                case "/99": return a99();
                case "/104": return a104();
                case "/105": return a105();
                case "/106": return a106();
                case "/107": return a107();
                case "/110": return a110();
                case "/114": return a114();
                case "/116": return a116();
                case "/119": return a119();
                case "/120": return a120();
                case "/122": return a122();
                case "/123": return a123();
                case "/124": return a124();
                case "/125": return a125();
                case "/126": return a126();
                case "/127": return a127();
                case "/128": return a128();
                case "/140": return a140();
                case "/141": return a141();
                case "/142": return a142();
                case "/145": return a145();
                case "/146": return a146();
                case "/147": return a147();
                case "/148": return a148();
                case "/149": return a149();
                case "/150": return a150();
                case "/152": return a152();
                case "/154": return a154();
                case "/155": return a155();
                case "/159": return a159();                
                case "/161": return a161();
                case "/164": return a164();
                case "/167": return a167();
                case "/168": return a168();
                case "/170": return a170();
                case "/189": return a189();
                case "/190": return a190();
                case "/192": return a192();
                case "/287": return a287();
                case "/290": return a290();
                case "/293": return a293();
                case "/296": return a296();
                case "/299": return a299();
                case "/300": return a300();
                default: return "";
            }
        }

        public bool Mission8 = false;
        public bool Mission7 = false;
        public bool Mission6 = false;
        public bool Mission5 = false;
        public bool Mission4 = false;
        public bool Mission3 = false;
        public bool Mission2 = false;
        public bool Mission1 = false;

        public bool mak_kolinz_saved = false;
        public bool livengaup_saved = false;
        public bool hartman_saved = false;
        public bool security_system_central_computer_disabled = false;
        public bool delete_record = false;
        public bool reactor_fixed = false;
        public bool generator_off = false; //147 генератор выключен
        public bool service_lift_off = false; //148 - испорчен грузовой лифт
        public bool repelent_get = false; //287 - получен репелент от чужих
        public bool a141_security_system = false; //141




        public string a192()
        {
            string outstr = "";
            ViewModelLocator.StatusStatic.ChangeLifes(-1);
            return outstr;
        }

        private bool a190_207 = false;
        private bool a190_208 = false;
        private string a190()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "";

            outevent += "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1:
                    outevent += "<a href='/205'>Событие многоразовое – 205</a>";
                    break;
                case 2:
                    outevent += "<a href='/206'>Событие многоразовое - 206</a>";
                    break;
                case 3:
                    if (a190_207 == false)
                    {
                        a190_207 = true;
                        outevent += "<a href='/207'>Событие только для первого посещения отсека - 207</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };                           
                    break;
                case 4:
                    if (a190_208 == false)
                    {
                        a190_208 = true;
                        outevent += "<a href='/208'>Событие только для первого посещения отсека - 208</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };                           
                    break;
                case 5:
                    outevent += "<a href='/209'>Событие многоразовое - 209</a>"; break;
                case 6:
                    outevent += "Нападение врага – Атака Чужого-офицера – атакует сзади – атакует первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
            };
            outevent += Texts.a190_select;

            return outevent + "<br>";
        }

        public string a189()
        {
            string outstr = "";
            Random random = new Random();
            int randomNumber = random.Next(0, ViewModelLocator.StatusStatic.Crew.Count()-1);
            ViewModelLocator.StatusStatic.Crew[randomNumber].Health=0;
            ViewModelLocator.StatusStatic.Crew[randomNumber].Dead = true;
            return outstr;
        }

        private string a170()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "";

            outevent += "<br><b>События:</b><br>";            
            switch (randomNumber)
            {
                case 1:
                    outevent += "<a href='/221'>Событие многоразовое – 221</a>";
                    break;
                case 2:
                    outevent += "<a href='/222'>Событие многоразовое – 222</a>";
                    break;
                case 3: outevent += "Вы нашли в отсеке –";
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {

                        case 1: outevent += "аптечку.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" }); break;                        
                        case 3: outevent += "чип-плату";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" }); break;
                        case 2: outevent += "таблетки \"Антишок\"";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" }); break;
                        case 4: outevent += "3 боеприпаса.";
                            ViewModelLocator.StatusStatic.Ammo += 3; break;
                        case 5: outevent += "чип-ключ от арсенала.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от арсенала" }); break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 4:
                    outevent += "Нападение врага – Атака Чужого-офицера – атакует спереди – вы атакуете первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 5:
                    outevent += "Нападение врага – Атака Чужого-офицера – атакует сверху – атакует первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6:                    
                    outevent += "Нападение врага – Атака Чужого-офицера – атакует сзади – атакует первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
            };
            outevent += "<br><b>Ваши дальнейшие действия?</b><br><ul>";
            outevent += "<li><a href=\"/170_time-1\">Задержаться здесь и бросить еще раз кубик на событие – (вам -1 Время).</a></li>";
            outevent += "<li><a href=\"/20\">Идти в Инженерный отсек – 20</a></li>";
            outevent += "<li><a href=\"/150\">Идти в Коридор «В» - 150</a></li>";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от рубки"))
            {
                outevent += "<li><a href=\"/220\">Идти в Рубку (если у вас есть чип-ключ от двери в отсек Рубки) – 220</a></li>";
            };
            outevent += "</ul>";

            return outevent + "<br>";
        }

        public string a168()
        {
            string outstr = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("руководство по ремонту реактора") ||
                ViewModelLocator.StatusStatic.FindAbility("техник"))
            {
                ViewModelLocator.StatusStatic.Time += 3;
            };
            return outstr;
        }

        public string a167()
        {
            string outstr = "";
            if (!ViewModelLocator.StatusStatic.FindInvItem("пено-керамо-спрей"))
            {
                ViewModelLocator.StatusStatic.Time -= 2;
            };
            return outstr;
        }

        public string a164()
        {
            string outstr = "";
            /*Если у вас в команде на данный момент есть спасенные члены экипажа, то они начинают
            все больше паниковать, и требовать чтобы ваша команда сейчас же направилась к шатлу и
            эвакуировала их с этого корабля. Они отказываются идти дальше и если вы не пойдете
            сейчас же к шатлу, то они сами будут пробираться в отсек Ангара.
            Ваше решение?
            · Если у вас есть таблетки «Анти-шок» - то вы можете потратить по одной штуке на
            каждого спасенного члена экипажа, чтобы они успокоились и можете продолжить
            свою миссию – 80
            · Если у вас нет таблеток «Анти-шок», то спасенные покидают вас – бросьте 6 раз
            кубик и за каждое выпадение (5 или 6) по пути к шатлу погибает один член
            экипажа. Остальные успешно добираются до шатла и считаются спасенными – 80*/
            return outstr;
        }

        public string a161()
        {
            string outstr = "";
            if (ViewModelLocator.StatusStatic.Crew.Count()<=ViewModelLocator.StatusStatic.CountInvItem("скафандр"))
            {
                outstr+="<a href=\"/80\">Если у вас есть скафандры для всех членов вашей команды, то вы быстро одеваете их и можете остаться в отсеке. – 80</a><br>";
            };
            outstr += Texts.a161_2;
            return outstr;
        }

        public string a159()
        {
            string outstr = "";
            ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
            {
                Name = "Чужой-офицер",
                attack1 = Hit,
                attack2 = Hit,
                attack3 = Kill,
                attack4 = Miss,
                attack5 = Miss,
                attack6 = Miss,
                Attack = 1,
                Health = 5,
                MaxHealth = 5,
                AttackFirst = false
            };
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            if (ViewModelLocator.StatusStatic.FindInvItem("аптечка")) {
                outstr += "<li><a href=\"/166\">Если вы решаете ему помочь (вам -1 аптечка) и переходите на – 166</a></li>";
            };
            if (ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Святоша")!=null)
            {
                outstr += "<li><a href=\"/150_time-1\">";
            }
            else
            {
                outstr += "<li><a href=\"/150\">";
            };
            outstr += "Если вы не можете оказать помощь несчастному. То он умирает прямо у вас на руках. Оставьте его тело здесь. Если у вас в команде есть боец «Святоша», то он призывает всех помолиться за погибшего. Вы не в силах противодействовать этой просьбе (вы теряете -1 Время) и вернитесь на – 150</a></li></ul>";
            return outstr;
        } 


        public string a155()
        {
            string outstr = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("шоккер") || ViewModelLocator.StatusStatic.FindInvItem("лазерный резак") || ViewModelLocator.StatusStatic.FindInvItem("сварочный аппарат"))
                {
                    outstr+="<li><a href=\"/150\">Если у вас есть шоккер или лазерный резак или сварочный аппарат, то попробуйте им атаковать Чужого – 159</a1></li>";
                };
            outstr+="</ul>";
            outstr+="<br><a href=\"/150\">После боя вернитесь на – 150</a>";
            return outstr;
        }        
        
        public string a154()
        {
            string outstr = "";
            if ((ViewModelLocator.StatusStatic.FindAbility("программист") || ViewModelLocator.StatusStatic.FindAbility("техник"))
                && (ViewModelLocator.StatusStatic.FindInvItem("лазерный резак") || ViewModelLocator.StatusStatic.FindInvItem("сварочный аппарат")))
                {
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="чип-плата"});
                };
            return outstr;
        }

        public string a152()
        {
            string outstr="";
            if (security_system_central_computer_disabled==true) {
                outstr+=Texts.a152_1;
            } else {
                outstr += Texts.a152_2;
                if (ViewModelLocator.StatusStatic.FindAbility("программист"))
                {
                    outstr += "<li><a href=\"/156\">Если у вас есть программист, попытаться отключить систему безопасности. Но для этого вам нужно решить задачу по подбору нужного кода. Если вы ошибетесь – вы все погибните. Попробуйте – 156</a></li>";
                };
                outstr += "</ul>";
            };
            return outstr;
        }

        private bool a150_151 = false;
        private bool a150_154 = false;
        private bool a150_155 = false;
        private string a150()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "";
            if ((a141_security_system == true) && (ViewModelLocator.StatusStatic.FindAbility("программист")))
            {
                outevent+="<a href=\"/153\">Если вы ранее разговаривали с техником Монтгомери и у вас есть компьютерщик – переходите на – 153</a><br>";
            };
                outevent += "<br><b>События:</b><br>";
                switch (randomNumber)
                {
                    case 1:
                        if (a150_151 == false)
                        {
                            a150_151 = true;
                            outevent += "<a href='/151'>Событие только для первого посещения отсека – 151</a>";
                        }
                        else
                        {
                            outevent += "Ничего";
                        };
                        break;
                    case 2:
                        outevent += "<a href='/152'>Событие многоразовое – 152</a>";                        
                        break;
                    case 3:
                        if (a150_154 == false)
                        {
                            a150_154 = true;
                            outevent += "<a href='/154'>Событие только для первого посещения отсека – 154</a>";
                        }
                        else
                        {
                            outevent += "Ничего";
                        };
                        break;
                    case 4:
                        if (a150_155 == false)
                        {
                            a150_155 = true;
                            outevent += "<a href='/155'>Событие только для первого посещения отсека – 155</a>";
                        }
                        else
                        {
                            outevent += "Ничего";
                        };
                        break;
                    case 5: outevent += "Вы обыскали отсек и нашли –";
                        int randomItem = random.Next(1, 7);
                        switch (randomItem)
                        {
                            case 1: outevent += "4 боеприпаса.";
                                ViewModelLocator.StatusStatic.Ammo+=4;
                                break;
                            case 2: outevent += "аптечку.";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" }); break;
                            case 3: outevent += "сварочный аппарат.";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "сварочный аппарат" }); break;
                            case 5: outevent += "чип-плату";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" }); break;
                            case 4: outevent += "таблетки \"Антишок\"";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" }); break;
                            default: outevent += "ничего."; break;
                        };
                        break;
                    case 6:
                        outevent += "Нападение врага – вас атакует Чужой-офицер. Атакует сверху.";
                        ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                        {
                            Name = "Чужой-офицер",
                            attack1 = Hit,
                            attack2 = Hit,
                            attack3 = Kill,
                            attack4 = Miss,
                            attack5 = Miss,
                            attack6 = Miss,
                            Attack = 1,
                            Health = 5,
                            MaxHealth = 5,
                            AttackFirst = false
                        };
                        (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                        break;
                };
            outevent += "<br><b>Ваши дальнейшие действия?</b><br><ul>";
            outevent += "<li><a href=\"/60\">После сыгранного события вы можете идти в Коридор «С» - 60</a></li>";
            outevent += "<li><a href=\"/170\">или в Коридор «А» - 170</a></li>";
            outevent += "<li><a href=\"/150_time-1\">Вы можете задержаться в этом отсеке и снова бросить кубик на событие (вам -1 Время).</a></li>";
            outevent += "</ul>";

            return outevent + "<br>";
        }

        public string a141()
        {
            a141_security_system = true;
            return "";
        }

        public string a287()
        {
            repelent_get = true;
            return "";
        }

        public string a290()
        {
            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="ремонтный робот"});
            return "";
        }

        public string a293()
        {
            try
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "аптечка"));
            }
            catch { };
            try
            {
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems.FirstOrDefault(c => c.Title == "таблетки \"Антишок\""));
            } catch {};
            return "";
        }

        public string a296()
        {
            ViewModelLocator.StatusStatic.Ammo -= 1;
            return "";
        }

        public string a299()
        {
            ViewModelLocator.StatusStatic.Ammo -= 5;
            return "";
        }

        public string a300()
        {
            string outstr = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от грузового лифта") && (service_lift_off==false))
            {
                 outstr += "<li><a href=\"/33\">Грузовой Лифт - 33</a></li>";
            };           
            outstr+="</ul>";
            return outstr;
        }

        public string a149()
        {
            service_lift_off = true;
            ViewModelLocator.StatusStatic.Ammo -= 2;
            return "";
        }

        public string a148()
        {
            foreach (var item in ViewModelLocator.StatusStatic.InvItems) {
                if (item.Title=="чип-плата") {
                    ViewModelLocator.StatusStatic.InvItems.Remove(item);
                };
            };
            
            return "";
        }

        public string a147()
        {
            generator_off = true;
            return "";
        }

        public string a145()
        {
            string outevent = "<br>";

            if (ViewModelLocator.StatusStatic.FindInvItem("био-контейнер"))
            {
                Mission6 = true;
                outevent += "Отметьте у себя на листике персонажа, что вы выполнили Миссию №6 – Захватить живым одного Чужого.<br><ul>";
            }
            else
            {
                outevent += "<ul><li><a href=\"/77\">Если у вас нет био-контейнера, вы можете расстрелять раненого Чужого – 77</a></li>";
            };
            if (ViewModelLocator.StatusStatic.FindAbility("ксено-психолог"))
            {
                outevent += "<li><a href=\"/78\">Если у вас есть ксено-психолог – 78</a></li>";
            };
            outevent += "<ul><li><a href=\"/71\">Вернитесь на – 71</a></li>";
            
            outevent += "</ul>";
            return outevent;
        }

        public string a142()
        {
            string outevent = "Внутри тела Монтгомери есть зародыш Чужого.<br>";

            if (ViewModelLocator.StatusStatic.FindAbility("биолог") && ViewModelLocator.StatusStatic.FindInvItem("био-контейнер") &&
                ViewModelLocator.StatusStatic.FindInvItem("лазерный резак"))
            {
                Mission6 = true;
                outevent += "<a href=\"/120\">вам удалось изъять из тела умирающего зародыш Чужого и поместить его в контейнер. Вы выполнили Миссию №6.</a>";
            };
            outevent += "<a href=\"/60\">Вернитесь на – 60</a>";
            return outevent;
        }

        private bool a140_224 = false;
        private string a140()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            if (reactor_fixed == false)
            {
                ViewModelLocator.StatusStatic.ChangeLifes(-1);
            };

            string outevent = "";
            if ((reactor_fixed==false) && ((ViewModelLocator.StatusStatic.CountInvItem("чип-плата") > 1)
                && (ViewModelLocator.StatusStatic.FindInvItem("пено-керамо-спрей")) &&
                ((ViewModelLocator.StatusStatic.FindInvItem("инструкция по ремонту реактора"))
                || (ViewModelLocator.StatusStatic.FindAbility("техника")))))
            {
                outevent = "<br>Вы починили реактор и получили +5 Время.";
                ViewModelLocator.StatusStatic.Time += 5;
            }
            else
            {

                outevent += "<br><b>События:</b><br>";
                switch (randomNumber)
                {
                    case 1:
                        outevent += "<a href='/223'>Событие многоразовое – 223</a>";
                        break;
                    case 2:
                        if (a140_224 == false)
                        {
                            a140_224 = true;
                            outevent += "<a href='/224'>Событие только для первого посещения отсека – 224</a>";
                        }
                        else
                        {
                            outevent += "Ничего";
                        };
                        break;
                    case 3:
                        outevent += "<a href='/225'>Событие многоразовое – 225</a>";
                        break;
                    case 4: outevent += "Вы обыскали отсек и нашли –";
                        int randomItem = random.Next(1, 7);
                        switch (randomItem)
                        {
                            case 1: outevent += "3 скафандра.";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                                break;
                            case 2: outevent += "один баллон с кислородом.";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "балон с кислородом" }); break;
                            case 3: outevent += "один баллон с кислородом.";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "балон с кислородом" }); break;
                            case 4: outevent += "чип-плату";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" }); break;
                            case 5: outevent += "лазерный резак";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "лазерный резак" }); break;
                            case 6: outevent += "инструкция по ремонту реактора";
                                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "инструкция по ремонту реактора" }); break;
                            default: outevent += "ничего."; break;
                        };
                        break;
                    case 5: outevent += "Нападение врага – атакует Чужой-офицер – атакует сверху – атакует первым.";
                        ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                        {
                            Name = "Чужой-офицер",
                            attack1 = Hit,
                            attack2 = Hit,
                            attack3 = Kill,
                            attack4 = Miss,
                            attack5 = Miss,
                            attack6 = Miss,
                            Attack = 1,
                            Health = 5,
                            MaxHealth = 5,
                            AttackFirst = true,
                        };
                        (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                        break;
                    case 6:
                        outevent += "Нападение врага – атакует Чужой-солдат – атакует сзади – атакует первым";
                        ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                        {
                            Name = "Чужой-солдат",
                            attack1 = Hit,
                            attack2 = Hit,
                            attack3 = Hit,
                            attack4 = Miss,
                            attack5 = Miss,
                            attack6 = RunAway,
                            Attack = 1,
                            Health = 3,
                            MaxHealth = 3,
                            AttackFirst = false
                        };
                        (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                        break;
                };
            };
            outevent += "<br><b>Ваши дальнейшие действия?</b><br><ul>";
            if (reactor_fixed == false)
            {
                outevent += "<li><a href=\"/140_life-1\">Задержаться здесь еще и снова бросить кубик на Событие (если вы еще не починили реактор, то все ваши бойцы снова теряют -1 Жизнь из-за радиации и жары).</a></li>";
            }
            else
            {
                outevent += "<li><a href=\"/140\">Задержаться здесь еще и снова бросить кубик на Событие</a></li>";
            };
            outevent += "<li><a href=\"/130\">Идите в Коридор «D» – 130</a></li>";
            outevent += "<li><a href=\"/19\">Если вы попали сюда из отсека Кают, то можете вернуться туда – 19</a></li>";
            outevent += "</ul>";

            return outevent + "<br>";
        }

        public string a128()
        {
            string outevent = "<br>";
            try
            {
                Random rnd = new Random();
                int r = rnd.Next(ViewModelLocator.StatusStatic.InvItems.Count);
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems[r]);
            }
            catch { };
            try
            {
                Random rnd = new Random();
                int r = rnd.Next(ViewModelLocator.StatusStatic.InvItems.Count);
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems[r]);
            }
            catch { };
            try
            {
                Random rnd = new Random();
                int r = rnd.Next(ViewModelLocator.StatusStatic.InvItems.Count);
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems[r]);
            }
            catch { };
            try
            {
                Random rnd = new Random();
                int r = rnd.Next(ViewModelLocator.StatusStatic.InvItems.Count);
                ViewModelLocator.StatusStatic.InvItems.Remove(ViewModelLocator.StatusStatic.InvItems[r]);
            }
            catch { };
            return outevent;
        }

        public string a127()
        {
            string outevent = "<br>";
            ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Abilities.FirstOrDefault(a=>a=="лидер")!=null).Health--;
            ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Святоша").Health--;
            return outevent;
        }

        public string a126()
        {
            string outevent = "<br>";
            ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Живодер").Health = 0;

            if (ViewModelLocator.StatusStatic.FindAbility("лидер"))
            {
                outevent += "<br><a href=\"/127\">Если у вас в команде есть боец с умением «Лидер», то перейдите на – 127</a>";
            }
            else
            {
                outevent += "<br><a href=\"/18\">Если нет бойца с умением Лидер – вернитесь на – 18</a>";
            };
            return outevent;
        }

        public string a125()
        {
            string outevent = "<br>";

            if (ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Святоша") == null)
            {
                outevent += "<br><a href=\"/28\">Если нет в команде бойца «Святоши» вернитесь на – 28</a>";
            }
            else
            {
                outevent += "<br><a href=\"/126\">Если у вас в команде есть боец «Святоша» перейдите на – 126</a>";
            };
            
            return outevent;
        }

        public string a123()
        {
            string outevent = "<br>";

            if (ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c=>c.Health==1)==null)
            {
                outevent += "<a href=\"/191\">Вы можете спуститься в этот люк и проследить, куда уходит вода – 191</a>";
            };
            outevent += "<br><a href=\"/120\">Решаете оставить это рискованное и трудное дело - 120</a>";
            return outevent;
        }

        public string a122()
        {
            string outevent = "<br>";

            if (ViewModelLocator.StatusStatic.FindAbility("биолог") && ViewModelLocator.StatusStatic.FindInvItem("био-контейнер"))
            {
                Mission6 = true;
                outevent += "<a href=\"/120\">Если у вас есть биолог и био-контейнер – вы успеваете быстро поместить в контейнер вылезшего из яйца Чужого-краба – выполнение Миссии №6.</a>";
            }
            else
            {
                ViewModelLocator.StatusStatic.Ammo--;
                outevent += "<a href=\"/120\">Если у вас нет биолога и био-контейнера – то вы просто решаете расстрелять эту тварь – вам (-1) боезапас.</a>";
            };
            return outevent;
        }

        private bool a120_124 = false;
        private string a120()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: 
                    outevent += "<a href='/121'>Событие многоразовое - 121</a>"; break;
                case 2:
                    outevent += "<a href='/122'>Событие многоразовое - 122</a>"; break;
                case 3:
                    outevent += "<a href='/123'>Событие многоразовое - 123</a>"; break;
                case 4:
                    if (a120_124 == false)
                    {
                        outevent += "<a href='/124'>Событие только при первом посещении - 124</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };
                    break;
                case 5: outevent += "Нападения врага – Атакует Чужой-офицер – атака сверху – атакует первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6: outevent += "Нападения врага - Атакует Чужой-офицер – атака сзади – атакует первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
            };
            outevent += Texts.a120_select;
            return outevent;
        }

        private string a119()
        {
            string outevent = "";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = RunAway,
                        attack5 = RunAway,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            outevent += "<br><a href=\"/190\">Если вы не хотите лезть в туннель или если у вас есть боец, у которого осталась всего 1 Жизнь, то вы не можете спуститься в тоннель. Это ему не по силам – 190</a>";
            if (ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c=>c.Health==1)!=null) {
            } else {
                outevent+="<br><a href=\"/197\">Если же у вас нет тяжелораненого бойца, то вы можете лезть в тоннель – 197</a>";
            };
            return outevent;
        }

        public string a116()
        {

            string outevent = "";
            Mission8 = true;
            Random random = new Random();
            int randomNumber = random.Next(1, 7);            
            switch (randomNumber)
            {
                case 1:
                    outevent += "Боеприпасы (+2)";
                    ViewModelLocator.StatusStatic.Ammo += 2;
                    break;
                case 2:
                    outevent += "Чип-ключ от Реактора";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="чип-ключ от реактора"});
                    break;
                case 3:
                    outevent += "Чип-ключ от Грузового Лифта";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="чип-ключ от грузового лифта"});
                    break;
                case 4:
                    outevent += "аптечка";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="аптечка"});
                    break;
                case 5:
                    outevent += "аптечка";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="аптечка"});
                    break;
                case 6:
                    outevent += Texts.a116_6;                    
                    break;
                default: outevent += ""; break;
            };
            outevent += "<br><a href=\"19\">Переходите на – 19</a>";
            return outevent;
        }

        public string a114()
        {
            string outevent = "";
            Mission8 = true;
            if (ViewModelLocator.StatusStatic.FindAbility("психолог"))
            {
                outevent += "<a href=\"/115\">Если у вас есть в команде психолог – 115</a>";
            }
            else
            {
                outevent += "<a href=\"/115\">Если нет психолога – 109</a>";
            };
            return outevent;
        }

        private bool a110_168 = false;
        private string a110()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "<a href='/167'>Событие многоразовое – 167</a>"; break;
                case 2:
                    if (a110_168 == false)
                    {
                        outevent += "<a href='/168'>Событие только при первом посещении – 168</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };
                    break;
                case 3:
                    outevent += "<a href='/169'>Событие многоразовое – 169</a>";
                    break;
                case 4:
                    outevent += "Вы осмотрели отсек в поисках полезных предметов – ";
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "таблетки \"Антишок\"";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                            break;
                        case 2: outevent += "боезапас (+2)";
                            ViewModelLocator.StatusStatic.Ammo += 2;
                            break;
                        case 3: outevent += "аптечка";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" });
                            break;
                        case 4: outevent += "пено-керамо-спрей";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "пено-керамо-спрей" });
                            break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 5: outevent += "Нападение врага – Атака Чужого-солдата – атакует спереди – вы атакуете первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-солдат",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Hit,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 3,
                        MaxHealth = 3,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6: outevent += "Нападение врага – Атака Чужого-краба – атакует сзади – вы атакуете первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
            };
            outevent += Texts.a110_select;

            return outevent + "<br>";
        }

        public string a107()
        {
            string outevent = "<ul>";
            Mission8 = true;
            if (ViewModelLocator.StatusStatic.FindAbility("психолог")) {
                outevent += "<li><a href=\"/108\">Если у вас в команде есть психолог – 108</a></li>";
            };
            outevent += "<li><a href=\"/109_time-2\">Расспрашивать дипломата дальше (вам -2 Время) – 109</a></li>";
            outevent += "<li><a href=\"/19_harrison_add\">Присоединить дипломата к своему отряду, но не обращать внимания на его угрозы и продолжать свою миссию – 19</a></li>";
            outevent += "<ul>";
            return outevent;
        }

        public string a106()
        {

            string outevent = "";
            Mission8 = true;
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            switch (randomNumber)
            {
                case 1:
                    outevent += "Каждый из драчунов теряет (-1) Жизнь";
                    foreach (var item in ViewModelLocator.StatusStatic.Crew)
                    {
                        if (item.Abilities.FirstOrDefault(a => a == "любит деньги") != null)
                        {
                            item.Health--;
                        };
                    };
                    break;
                case 2:
                    outevent += "Один из драчунов получил в драке смертельный удар и погиб";
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Abilities.FirstOrDefault(a => a == "любит деньги") != null).Health = 0;
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Abilities.FirstOrDefault(a => a == "любит деньги") != null).Dead = true;
                    break;
                case 3:
                    outevent += "Один из драчунов теряет (-2) Жизни";
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Abilities.FirstOrDefault(a => a == "любит деньги") != null).Health-=2;
                    break;
                case 4:
                    outevent += "Оба драчуна совсем озверели и потасовке и пристрелили друг друга";
                    foreach (var item in ViewModelLocator.StatusStatic.Crew)
                    {
                        if (item.Abilities.FirstOrDefault(a => a == "любит деньги") != null)
                        {
                            item.Health = 0;
                            item.Dead = true;
                        };
                    };
                    break;
                case 5:
                    outevent += "Понимая, что это все глупо – драчуны сами прекращают драку";
                    break;
                case 6:
                    outevent += "Если у вас в команде есть боец с умением «Лидер», то он тоже присоединяется к драке – все драчуны и Лидер теряют (-1) Жизнь.";
                    foreach (var item in ViewModelLocator.StatusStatic.Crew)
                    {
                        if ((item.Abilities.FirstOrDefault(a => a == "любит деньги") != null) || (item.Abilities.FirstOrDefault(a => a == "лидер") != null))
                        {
                            item.Health = item.Health-1;
                            item.Dead = true;
                        };
                    };
                    break;
                default: outevent += ""; break;
            };

            return outevent;
        }

        public string a105()
        {
            string outevent = "";
            Mission8 = true;
            foreach (var item in ViewModelLocator.StatusStatic.Crew)
            {
                if (item.Abilities.FirstOrDefault(a => a == "любит деньги")!=null)
                {
                    item.Health--;
                };
            };
            return outevent;
        }

        public string a104()
        {
            string outevent = "";
            int want_money = 0;
            want_money = ViewModelLocator.StatusStatic.Crew.Where(c => c.Abilities.FirstOrDefault(a => a == "любит деньги") != null).Count();
            want_money = want_money + ViewModelLocator.StatusStatic.Crew.Where(c => c.Warior==false).Count();
            if (want_money < (ViewModelLocator.StatusStatic.Crew.Where(c => c.Abilities.FirstOrDefault(a => a == "лидер") != null).Count() + 1))
            {
                outevent += "<br>Большинство голосов у вас, вы забираете все деньги себе. <a href=\"/71\"Отметьте в своем листике персонажа о выполнении Миссии №8 – переходите на – 71</a><br>";
                Mission8 = true;
            }
            else
            {
                outevent += "<br><a href=\"/103\">Большинство голосов у «любителей денег» или число голосов равное переходите на – 103</a><br>";
            };
            return outevent;
        }

        public string a99()
        {
            string outevent = "<br><ul>";
            if ((ViewModelLocator.StatusStatic.Crew.Where(c=>c.Abilities.FirstOrDefault(a=>a=="любит деньги")!=null).Count()==2) && (ViewModelLocator.StatusStatic.FindAbility("психолог")==false))
            {
                outevent += "<li><a href=\"/101\">Если среди ваших бойцов есть два бойца с характеристикой – «любит деньги» - переходите на – 101</a></li>";
            };
            if ((ViewModelLocator.StatusStatic.Crew.Where(c => c.Abilities.FirstOrDefault(a => a == "любит деньги") != null).Count() == 2) && (ViewModelLocator.StatusStatic.FindAbility("психолог")))
            {
                outevent += "<li><a href=\"/102\">Если среди ваших бойцов есть два бойца с характеристикой – «любит деньги» и есть боец с умением «психолог» - переходите на – 102</a></li>";
            };
            if (ViewModelLocator.StatusStatic.Crew.Where(c => c.Abilities.FirstOrDefault(a => a == "любит деньги") != null).Count() < 2)
            {
                outevent += "<li><a href=\"/71_mission8\">Если у вас в команде нет двух бойцов с характеристикой – «любит деньги» - то вы забираете себе все деньги. Отметьте в своем листике персонажа о выполнении Миссии №8 – переходите на – 71</a></li>";
            };
            outevent += "</ul>";
            return outevent;
        }

        public string a98()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "<br><b>Предателем был:</b>";
            PersonItem enemy = null;
            switch (randomNumber)
            {
                case 1:
                    outevent += "Голлем";
                    enemy = ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Голлем");
                    break;
                case 2:
                    outevent += "Васаби";
                    enemy = ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Васаби");
                    break;
                case 3:
                    outevent += "Силикон";
                    enemy = ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Силикон");
                    break;
                case 4:
                    outevent += "Криоген";
                    enemy = ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Криоген");
                    break;
                case 5:
                    outevent += "Док";
                    enemy = ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Док");
                    break;
                case 6:
                    outevent += "Заноза";
                    enemy = ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Заноза");
                    outevent += "";
                    break;
                default: outevent += ""; break;
            };
            if (enemy != null)
            {
                enemy.AttackFirst = true;
                ViewModelLocator.BattleStatic.CurrentEnemy = enemy;
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                outevent += "</b><br>Услышав, что генерал разоблачен, этот боец атакует всю вашу команду. Деритесь! Агент генерала атакует первым. Атака сзади.<br>";
            }
            else
            {
                outevent += "никто из группы</b>";
            };
            outevent += "<br><a href=\"/93\">вернитесь на – 93</a>";
            return outevent;
        }

        public string a96()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindAbility("лидер"))
            {
                outevent += "<a href=\"/19\">Ваши бойцы вынуждены прекратить мародерство</a>";
            }
            else
            {
                outevent += "<a href=\"/19_time-1\">На ваши требования прекратить мародерство никто не обращает внимания. Вы ждете, пока ваши люди обыщут каюту – вы теряете (-1) Время – Вернитесь на – 19</a>";
            };
            return outevent;
        }

        public string a95()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("лазерный резак") && ViewModelLocator.StatusStatic.FindInvItem("био-контейнер") && ViewModelLocator.StatusStatic.FindAbility("доктор"))
            {
                outevent += "<li><a href=\"/89_mission6\">Убить Райса и у вас есть биолог + лазерный резак + био-контейнер, - вы смогли изъять зародыш чужого из тела убитого и поместить его в контейнер. Можете отметить на своем листике персонажа выполнение Миссии №6.</a></li>";
            }
            else
            {
                outevent += "<li><a href=\"/89\">Убить Райса</a></li>";
            };
            outevent += "</ul>";
            return outevent;
        }

        public string a91()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "<br><b>Событие:</b><br><ul>";
            switch (randomNumber)
            {
                case 1:
                    outevent += "<a href=\"/193\">Событие многоразовое - 193</a>";
                    break;
                case 2:
                    outevent += "<a href=\"/194\">Событие многоразовое - 194</a>";
                    break;
                case 3:
                    if (ViewModelLocator.StatusStatic.FindAbility("программист")) {
                    outevent += "<a href=\"/195\">Событие многоразовое (требуется программист) - 195</a>";
                    } else {
                        outevent+="Ничего";
                    };
                    break;
                case 4:
                    outevent += "<a href=\"/196\">Событие многоразовое - 196</a>";
                    break;
                case 5:
                    outevent += "Найдено: ";
                    Random random2 = new Random();
                    int randomNumber2 = random2.Next(1, 7);
                    switch (randomNumber2)
                    {
                        case 1:
                            outevent += "аптечка";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" });
                            break;
                        case 2:
                            outevent += "таблетки \"Антишок\" - 3 штуки";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                            break;
                        case 3:
                            outevent += "пено-керамо-спрей";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "пено-керамо-спрей" });
                            break;
                        case 4:
                            outevent += "наркотики";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "наркотики" });
                            break;
                        case 5:
                            outevent += "чип-ключ от рубки и реактора";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от рубки" });
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от реактора" });
                            break;
                        case 6:
                            outevent += "чип-плата";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" });
                            break;
                    }                    
                    break;
                case 6:
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst = true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    outevent += "";
                    break;
                default: outevent += ""; break;
            };
            outevent += Texts.a91_select;
            return outevent;
        }

        public string a90()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от коридора D") && ViewModelLocator.StatusStatic.CountInvItem("скафандр") >= ViewModelLocator.StatusStatic.Crew.Count)
            {
                outevent += Texts.a90_1;
            };
            outevent += "</ul>";
            outevent += Texts.a90_2;
            return outevent;
        }

        public string a89()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem(""))
            {
                outevent += "<li><a href=\"/95\">Если у вас есть переносной рентген-аппарат – проверьте мужчин на наличие у них в теле зародышей Чужого – 95</a></li>";
            };
            outevent += "</ul>";
            return outevent;
        }

        public string a88()
        {
            string outevent = "";
            ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 3;
            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="аптечка"});
            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "шоккер" });
            return outevent;
        }

        public string a85()
        {
            string outevent = Texts.a85_select;
            if (ViewModelLocator.StatusStatic.CountInvItem("аптечка")>1) {
                outevent += "<li><a href=\"/19_use_healthpack2\">Оказать ему медицинскую помощь (вам -2 аптечки). – 19</a></li>";
            };
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent += "<li><a href=\"/111\">Проверить его на наличие в его теле зародыша Чужого (если у вас есть рентген-аппарат) – 111</a></li>";
            };
            outevent+="</ul>";
            return outevent;
        }

        public string a82()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);

                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = RunAway,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst = true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            outevent+="<br><a href=\"/71\">Вернитесь на – 71</a></li>";
            return outevent;
        }

        public string a81()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            if (ViewModelLocator.StatusStatic.FindAbility("программист"))
            {
                outevent += Texts.a81_variants;
            }
            else
            {
                outevent += "<li>У вас нет программиста в команде.</li>";
            };
            outevent += "<li><a href=\"/71\">Если вы не смогли подобрать шифр к этому кодовому замку – вернитесь на – 71</a></li></ul>";
            return outevent;
        }

        public string a80() {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "<br><b>Событие:</b><br><ul>";
            switch (randomNumber)
            {
                case 1: 
                    outevent += "<li><a href=\"/161\">Событие многоразовое – 161</a></li>";
                    break;
                case 2:
                    outevent += "<li><a href=\"/162\">Событие многоразовое – 162</a></li>";
                    break;
                case 3: 
                    outevent += "<li><a href=\"/163\">Событие многоразовое – 163</a></li>";
                    break;
                case 4:
                    outevent += "<li><a href=\"/164\">Событие многоразовое – 164</a></li>";
                    break;
                case 5: 
                    outevent += "Вы нашли – био-контейнер, чип-плату, лазерный резак, Инструкцию по ремонту реактора.";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "био-контейнер" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "лазерный резак" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "инструкция по ремонту реактора" });
                    break;
                case 6:
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst = true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    outevent += "";
                    break;
                default: outevent += ""; break;
            };
            outevent += Texts.a80_select;
            return outevent;
        }

        public string a79()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            switch (randomNumber)
            {
                case 1:
                    outevent += "чип-ключ от Арсенала и Рубки";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от арсенала" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от рубки" });
                    break;
                case 2:
                    outevent += "чип-ключ от Рубки и Реактора";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от рубки" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от реактора" });
                    break;
                case 3:
                    outevent += "чип-ключ от Реактора и Лаборатории";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от реактора" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от лаборатории" });
                    break;
                case 4:
                    outevent += "чип-ключ от Генератора и Рубки";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от генератора" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от рубки" });
                    break;
                case 5:
                    outevent += "чип-ключ от Коридора «D» и отсека Утилизации";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от коридора D" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от отсека утилизации" });
                    break;
                case 6:
                    outevent += "чип-ключ от Грузового Лифта";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от грузового лифта" });
                    break;
                default:
                    break;
            };
            outevent += "<br><a href=\"/20\">Вернитесь на – 20</a>";
            return outevent;
        }

        public string a77()
        {
            string outevent = "";
            ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
            {
                Name = "Чужой-краб",
                attack1 = Suck,
                attack2 = Suck,
                attack3 = Suck,
                attack4 = Miss,
                attack5 = RunAway,
                attack6 = RunAway,
                Attack = 1,
                Health = 1,
                MaxHealth = 1,
                AttackFirst = true
            };
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));

            /*Если Чужой присосался к одному из ваших бойцов, то он считается парализованным. Вы
            можете:
            · Если у вас есть биолог – попытаться пока не поздно оторвать Краба от лица
            жертвы – выберите один из вариантов попытки – 82 или 83
            · Или можете отослать одного своего члена команды сопровождать парализованного
            бойца, и самостоятельно добираться до Ангара. Бросьте кубик за каждый отсек на
            пути до Ангара. Если выпадет хотя бы одна (5 или 6) – они погибли по пути.
            · Если вы не выбрали ни один из предыдущих вариантов, то вам придется
            пристрелить тварь вместе с бойцом (уберите его карточку из игры).
            Идите на – 71*/
            outevent +="<br><a href=\"/71\">Идите на – 71</a>";
            return outevent;
        }

        private bool a71_145 = false;
        private bool a71_147 = false;
        private bool a71_first_items = false;
        public string a71()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            /*Вы нашли – 15 боеприпасов,
            шоккер, сканер движения (дает вам
            возможность всегда атаковать первым в
            бою), 5 комплектов скафандров (для
            выхода в открытый космос), 2 баллона с
            кислородом, лазерный резак, таблетки
            «Анти-шок» (3 шт.).*/
            if (a71_first_items == false)
            {
                ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 15;
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "шоккер" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "сканер движения" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "кислородный баллон" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "кислородный баллон" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "лазерный резак" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                outevent += "<p>Вы нашли – 15 боеприпасов, шоккер, сканер движения (дает вам возможность всегда атаковать первым в бою), 5 комплектов скафандров (для выхода в открытый космос), 2 баллона с кислородом, лазерный резак, таблетки «Анти-шок» (3 шт.).</p>";
            };
            outevent += "<br><b>Событие:</b><br>";
            switch (randomNumber)
            {
                case 1: 
                    outevent += "<a href=\"/143\">Событие многоразовое – 143</a><br>";
                    break;
                case 2:
                    outevent += "<a href=\"/144\">Событие многоразовое – 144</a><br>";
                    break;
                case 3:
                    if (a71_145==false) {
                    outevent += "<a href=\"/145\">Событие только для первого посещения – 145</a><br>";
                    } else {
                        outevent +="Ничего<br>";
                    };
                    break;
                case 4:
                    outevent += "<a href=\"/146\">Событие многоразовое – 146</a><br>";
                    break;
                case 5:
                    if (a71_147 == false)
                    {
                        outevent += "<a href=\"/147\">Событие только для первого посещения – 147</a><br>";
                    }
                    else
                    {
                        outevent += "Ничего<br>";
                    };
                    break;
                case 6:
                    outevent += "<a href=\"/148\">Событие многоразовое – 148</a><br>";
                    break;
                default: 
                    break;
            };
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent += "<li><a href=\"/76\">Если у вас есть переносной рентген-аппарат – проверьте, нет ли внутри тела Хартмана зародыша Чужого – 76</a></li>";
            };
            outevent += "</ul>";
            outevent += Texts.a71_select;
            return outevent;
        }

        public string a70()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent+="<li><a href=\"/76\">Если у вас есть переносной рентген-аппарат – проверьте, нет ли внутри тела Хартмана зародыша Чужого – 76</a></li>";
            };
            outevent+="</ul>";
            return outevent;
        }

        public string a69()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "<br><b>АТАКА НЕИЗВЕСТНОГО (1 Жизнь)</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "Попал - вам (-1) Жизнь.";
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault().Health -= 1;
                    break;
                case 2:
                    outevent += "Попал - вам (-2) Жизнь.";
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault().Health -= 2;
                    break;
                default: outevent += "он промахнулся."; break;
            };
            outevent += "<a href=\"/68\">Если вы решили его пристрелить – 68</a>";
            return outevent;
        }

        public string a68()
        {
            string outevent = "";
            ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 5;
            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от арсенала" });
            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от коридора D" });
            return outevent;
        }

        public string a67()
        {
            string outevent = "";
            if (security_system_central_computer_disabled == true)
            {
                outevent += "<a href=\"/71\">Если вы уже отключили Систему безопасности на центральном компьютере корабля – то переходите на – 71</a>";
            }
            else
            {
                outevent += "<a href=\"/72\">Если вы еще не отключили систему безопасности – то переходите на – 72</a>";
            };
            outevent += "</ul>";
            return outevent;
        }

        public string a40()
        {
            string outevent = "Негр заражен.<br>";
            if (ViewModelLocator.StatusStatic.FindInvItem("био-контейнер") && ViewModelLocator.StatusStatic.FindInvItem("лазерный резак") && ViewModelLocator.StatusStatic.FindAbility("доктор"))
            {
                outevent += "<a href=\"/29_mission6\">Вы вскрыли тело негра и заключить в био-контейнер зародыш Чужого. Отметьте на своей карточке персонажа, что вы выполнили Миссию №6.</a>";
            }
            else
            {
                outevent += "<a href=\"/29_ammo-1\">Расстреляйте этого зародыша Чужого (-1 боезапас).</a>";
            };
            outevent += "</ul>";
            return outevent;
        }

        public string a66()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от арсенала")) {
                outevent+="<li><a href=\"/67\">Срочно бежать из этого отсека – Идти – в отсек Арсенала (только если у вас есть чип-ключ от Арсенала) – 67</a></li>";
            };
            outevent+="</ul>";
            return outevent;
        }

        public string a65()
        {
            /*Проверьте ваших бойцов на самообладание. Бросьте кубик на каждого бойца по его
            карточке действий:
            · Если по действию бойца выпадет «Попал» - то это значит, что ваш боец в панике
            открыл огонь во все стороны (вам -2 боезапаса);
            · Если по действию бойца выпадет «Убил» - то это значит, что ваш боец в панике
            открыл огонь во все стороны (вам -2 боезапаса) и случайно рикошетом убил одного
            из своих товарищей (уберите карточку убитого);
            · Если по действию бойца выпадет «Паника», - то это значит, что этот боец в ужасе
            бросился бежать по коридорам и отсекам, не разбирая пути (вы потеряли этого
            бойца – отложите его карточку пока в сторону);*/
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "";
            switch (randomNumber)
            {
                case 1: outevent += "";
                    break;
                case 2:
                    outevent += "";
                    break;
                case 3: outevent += "";
                    break;
                case 4:
                    outevent += "";
                    break;
                case 5: outevent += "";
                    break;
                case 6:
                    outevent += "";
                    break;
                default: outevent += ""; break;
            };
            outevent += "<br>Внезапно все шорохи затихли. Враг затаился или ушел?<br><a href=\"/20\">Вернитесь на – 20</a>";
            return outevent;
        }

        public string a64()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "";
            switch (randomNumber)
            {
                case 1: outevent += Texts.a64_1;
                    break;
                case 2:
                    outevent += Texts.a64_2;
                    break;
                case 3: outevent += Texts.a64_3;
                    break;
                case 4:
                    outevent += Texts.a64_4;
                    break;
                case 5: outevent += Texts.a64_5;
                    break;
                case 6:
                    outevent += Texts.a64_6;
                    break;
                default: outevent += ""; break;
            };
            outevent += "<br><a href=\"/20\">Вернитесь на – 20</a>";

            return outevent;
        }

        public string a146()
        {
            ViewModelLocator.StatusStatic.ChangeLifes(-1);
            return "";
        }

        public string a124()
        {
            ViewModelLocator.StatusStatic.Ammo--;
            return "";
        }

        public string a63()
        {
            string outevent = "";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "<br><b>АТАКА НЕИЗВЕСТНОГО (1 Жизнь)</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "Попал - вам (-1) Жизнь.";
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault().Health -= 1;
                    break;
                case 2:
                    outevent += "Попал - вам (-2) Жизнь.";
                    ViewModelLocator.StatusStatic.Crew.FirstOrDefault().Health -= 2;
                    break;
                default: outevent += "он промахнулся."; break;
            };
            outevent += "<br><b>Ваше решение?</b><br><ul>";            
            if (ViewModelLocator.StatusStatic.FindAbility("психолог"))
            {
                outevent += "<li><a href=\"/70\"><li>Если у вас есть психолог – 70</a></li>";
            };
            outevent += "<li><a href=\"/69\">Крикнуть ему, что вы группа спасения – 69</a></li>";
            outevent += "<li><a href=\"/68\">Стрелять в него – 68</a></li>";
            outevent += "</ul>";
            return outevent;
        }

        public string a62()
        {
            string outevent = "<p>Биолог отбросил краба в сторону и тварь, быстро перебирая своими многочисленными лапами, снова бросилась на вас. Деритесь! Чужой-краб атакует спереди, вы стреляете первым.</p>";
            ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
            {
                Name = "Чужой-краб",
                attack1 = Suck,
                attack2 = Suck,
                attack3 = Suck,
                attack4 = Miss,
                attack5 = Miss,
                attack6 = RunAway,
                Attack = 1,
                Health = 1,
                MaxHealth = 1,
                AttackFirst = true
            };
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            outevent += "<br><a href=\"/17\">После боя идите на 17</a>";
            return outevent;
        }

        public string a61()
        {
            string outevent = "<ul>";
            ViewModelLocator.StatusStatic.Crew.LastOrDefault(c => c.Abilities.FirstOrDefault(a => a == "биолог") != null).Health--; 
            if (ViewModelLocator.StatusStatic.CountInvItem("био-контейнер") > 0)
            {
                outevent += "<li><a href=\"/17_mission6\"><li>У вас есть био-контейнер, вы можете посадить тварь в контейнер и отметить выполнение Миссии №6 – 17</a></li>";
            };
            outevent += "<li><a href=\"/62\"><li>Вы можете приказать биологу отбросить тварь подальше в сторону, чтобы вы могли ее расстрелять с безопасного расстояния – 62</a></li>";
            outevent += "</ul>";

            return outevent;
        }

        public string a59()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.Ammo > 0)
            {
                outevent += "<li><a href=\"/17_ammo-1_biolog_dead\"><li>Расстрелять тварь вместе с биологом – вам (-1) боезапас. Вернитесь на – 17</a></li>";
            };
            if (ViewModelLocator.StatusStatic.Crew.Where(c => c.Abilities.FirstOrDefault(a => a == "биолог") != null).Count()>1)
            {
                outevent += "<li><a href=\"/61\"><li>У вас в команде есть еще один специалист биолог – попытаться побыстрее снять краба с лица жертвы – 61</a></li>";
            };
            if (ViewModelLocator.StatusStatic.CountInvItem("шокер") > 0)
            {
                outevent += "<li><a href=\"/58\"><li>У вас есть шоккер – ударить тварь разрядом тока – 58</a></li>";
            };
            outevent += "<li><a href=\"/17\"><li>Оставить жертву и краба так как есть – 17</a></li>";
            outevent += "</ul>";

            return outevent;
        }

        public string a58()
        {
            string outevent = "<p>Тварь отпрыгнула в сторону и напала на вас. Деритесь! Чужой-краб – атакует спереди – он атакует первым.</p>";
            ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
            {
                Name = "Чужой-краб",
                attack1 = Suck,
                attack2 = Suck,
                attack3 = Suck,
                attack4 = Miss,
                attack5 = Miss,
                attack6 = RunAway,
                Attack = 1,
                Health = 1,
                MaxHealth = 1,
                AttackFirst = true
            };
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            outevent += "<br><a href=\"/17\">После боя идите на 17</a>";
            return outevent;
        }

        public string a55()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.CountInvItem("шокер") > 0)
            {
                outevent += "<li><a href=\"/58\"><li>У вас есть шоккер – ударить тварь разрядом тока – 58</a></li>";
            }; 
            outevent += "<li><a href=\"/19\"><li>Ничего не делать. Позволить твари присосаться к биологу – 59</a></li>";
            outevent += "</ul>";

            return outevent;
        }

        public string a56()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.CountInvItem("аптечка")>2)
            {
                outevent += "<li><a href=\"/59_use_healthpack3\"><li>Потребуется использовать (-3) аптечки для заживления сильных ожогов раненого – 59</a></li>";
            };
                outevent += "<li><a href=\"/17_biolog_dead\"><li>Оставить биолога умирать. Вернитесь на – 17</a></li>";
            outevent += "</ul>";

            return outevent;
        }

        public bool a54_vagner_saved = false;
        public bool a54_vagner_send = false;
        public string a54()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindAbility("биолог") && ViewModelLocator.StatusStatic.FindInvItem("шоккер") && ViewModelLocator.StatusStatic.FindInvItem("био-контейнер"))
            {
                Mission6 = true;
                MessageBox.Show("Вы сняли с жертвы тело Чужого и поместили его в контейнер – выполнение Миссии №6");
                outevent = "<ul>";
                outevent += "<li><a href=\"/17\"><li>Оставить ее в бессознательном состоянии в этом отсеке. – 17</a></li>";
                outevent += "<li><a href=\"/17_vagner_send\"><li>Отправить женщину вместе с одним из своих людей в отсек Ангара</a></li>";
                outevent += "</ul>";
            }
            else
            {
                outevent = "<ul>";
                outevent += "<a href=\"/17\"><li>Расстрелять Чужого-краба вместе с женщиной – 17</a></li>";
                outevent += "<a href=\"/17\"><li>Оставить женщину и Чужого здесь – 17</a></li>";
                if (ViewModelLocator.StatusStatic.FindAbility("биолог"))
                {
                    outevent += "<a href=\"/55\"><li>Попытаться снять Чужого-краба с лица женщины – 55</a></li>";
                };
                outevent += "<a href=\"/17_vagner_send\"><li>Отправить женщину вместе с одним из своих людей в отсек Ангара</a></li>";
                outevent += "</ul>";
            };
            
            return outevent;
        }


        public string a53()
        {
            string outevent = "";
            ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
            {
                Name = "Чужой-краб",
                attack1 = Suck,
                attack2 = Suck,
                attack3 = Suck,
                attack4 = Miss,
                attack5 = Miss,
                attack6 = RunAway,
                Attack = 1,
                Health = 1,
                MaxHealth = 1,
                AttackFirst = true
            };
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            outevent += "<br><a href=\"/17\">Идите на 17</a>";
            return outevent;
        }


        public bool a46_juzepe_saved = false;
        public bool a46_juzepe_send = false;
        public bool a46_juzepe_added = false;
        public string a46()
        {
            string outevent = Texts.a46;
            outevent += "<ul>";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent += "<li><a href=\"/47\">обследуйте мужчину на наличие в его теле Чужого – 47</a></li>";
            };
            if (ViewModelLocator.StatusStatic.FindInvItem("аптечка"))
            {
                outevent += "<li><a href=\"/48_use_healthpack\">Приведите его в чувство (-1 аптечка) – 48</a></li>";
            };
            outevent += "<li><a href=\"/17\">Оставить его здесь как есть – 17</a></li>";
            outevent += "<li><a href=\"/17_juzepe_send\">Отправить его в сопровождении с одним из своих людей в Ангар</a></li>";
            outevent += "<li><a href=\"/17_juzepe_add\">Присоединить его к своей команде – 17</a></li>";
            outevent += "</ul>";
            return outevent;
        }


        public string a45()
        {
            string outevent = "Сумасшедший с тесаком в руке подскакивает к вам и наносит удар. Деритесь! – атака спереди – он атакует первым.";
            ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
            {
                Name = "Сумасшедший",
                attack1 = Hit,
                attack2 = Hit,
                attack3 = Miss,
                attack4 = Miss,
                attack5 = Miss,
                attack6 = Miss,
                Attack = 1,
                Health = 1,
                MaxHealth = 1,
                AttackFirst = true
            };
            (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            outevent += "<br><b>При обыске вы нашли у него:</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "аптечку";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" });
                    break;
                case 2: 
                    outevent += "таблетки \"Антишок\"";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                    break;
                case 3: outevent += "аэрозоль от тараканов";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аэрозоль от тараканов" });
                    break;
                default: outevent += "ничего";  break;
            };
            outevent += "<br><a href=\"/17\">Идите на 17</a>";
            return outevent;
        }

        public string a33()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от грузового отсека"))
            {
                outevent += "<li><a href=\"/90\">Вы можете разблокировать дверь</a></li>";
            };
            outevent += "<li><a href=\"/18\">в Лазарет – 18</a></li>";
            outevent += "<li><a href=\"/100\">в отсек Генератора – 100</a></li>";
            outevent += "<li><a href=\"/130\">в Коридор «Д» - 130</a></li>";
            outevent += "<li><a href=\"/120\">в Оранжерею – 120</a></li>";
            outevent += "<li><a href=\"/110\">в коридор «Е» - 110</a></li>";
            outevent += "</ul>";
            return outevent;
        }

        public bool a30_tauer = false;
        public bool a30_tauer_saved = false;
        public bool a30_tauer_send = false;
        public bool a30_tauer_added = false;
        public string a30()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.FindInvItem("аптечка"))
            {
                outevent += "<li><a href=\"/30_a30_tauer\">Перевязать Тауэра (вам -1 аптечка) – негру (+1) Жизнь.</a></li>";
            };
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent += "<li><a href=\"/34\">Проверить негра рентген-аппаратом на наличие в его теле зародыша Чужого – 34</a></li>";
            };
            outevent += "<li><a href=\"/35\">Расспросить негра о событиях на корабле – 35</a></li>";
            outevent += "<li><a href=\"/36\">Спросить негра не видел ли он дипломата – 36</a></li>";
            outevent += "<li><a href=\"/37\">Спросить негра о причине повышения температуры на корабле – 37</a></li>";
            outevent += "<li><a href=\"/38\">Спросить негра знает ли он откуда могли появиться Чужие на корабле – 38</a></li>";
            if (a30_tauer)
            {
                if (a30_tauer_saved == false)
                {
                    outevent += "<li><a href=\"/18_tauer_add\">Присоединить негра к своей команде</a></li>";
                };
                if (a30_tauer_send == false)
                {
                    outevent += "<li><a href=\"/18_tauer_send\">Отправить негра самому добираться до ангара, где он сможет спрятаться в вашем шатле</a></li>";
                };
            };
            outevent += "<li><a href=\"/33\">Отправиться в отсек «Грузовой Лифт» - 33</a></li>";
            outevent += "<li><a href=\"/17\">Отправится в отсек «Пищеблок» - 17</a></li>";
            outevent += "</ul>";
            return outevent;
        }

        public string a139()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.FindInvItem("аптечка"))
            {
                outevent += "<li><a href=\"141\">Оказать ему медицинскую помощь чтобы поддержать его жизнь на пару минут (вам -1 аптечкa) – 141</a></li>";
            }; 
            outevent += "<li><a href=\"/60\">Оставить умирающего – 60</a></li>";
            outevent += "<li><a href=\"/60\">Оставить умирающего – 60</a></li>";
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent += "<li><a href=\"/142\">Если у вас есть рентген-аппарат, то вы можете проверить умирающего на наличие у него внутри зародыша Чужого. – 142</a></li>";
            }; 
            
            outevent += "</ul>";
            return outevent;
        }

        public string a32()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от отсека грузового лифта"))
            {
                outevent += "<a href=\"/33\">У вас есть чип-ключ от отсека Грузового лифта – переходите на – 33</a>";
            }
            else
            {
                outevent += "<a href=\"/23\">У вас нет чип-ключа – вернитесь на – 23</a>";
            };
            return outevent;
        }

        public string a29() {
            string outevent = "";
            outevent += "<p>Вы расстреливаете темную зловещую фигуру Чужого и тело пару раз дернувшись - замирает (вам (-1) боеприпас). Вы подходите ближе и видите, что это совсем не Чужой, а здоровый лысый негр. Вы приняли его за тварь, потому что его тело было черным и блестело от пота как хитиновый панцирь Чужого. Вы вытаскиваете из воздуховода тело негра. На его бэйдже написано – Тауэр (техник).</p><br>";
            ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo - 1;
            outevent += "<p>Обыскав тело убитого, вы находите:";
            Random random = new Random();
            int randomNumber = random.Next(1, 7);

            switch (randomNumber)
            {
                case 1: outevent += "чип-ключ от отсека Реактора."; ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от отсека реактора" }); break;
                case 2: outevent += "Инструкция по ремонту Реактора (позволяет любому без умения Техник исправить реактор);"; ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "инструкция по ремонту реактора" }); break;
                case 3: outevent += "чип-плата"; ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" }); break;
                case 4: outevent += "чип-ключ в отсек Грузового Лифта";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ в отсек грузового лифта" });
                    break;
                case 5: outevent += "ничего";
                    break;
                case 6: outevent += "<br>Информация на персональном коммуникаторе Билли Тауэра – <i>«… у меня есть неоспоримые доказательства того, что навигатор Сюзана Мур является давней любовницей нашего дипломата Артура Харрисона. Не случайно он в своих перелетах всегда использует наш корабль. Сюзанна беременна от него. … Я пригрозил Харрисону, что если он мне не заплатит 50 тыс. кредиток, я расскажу всем о его тайной связи, и на этом его карьера будет окончена. Харрисон обещал мне заплатить…но, я почему-то ему не верю».</i>";
                    break;
                default: break;
            };
            outevent += "</p>";

            return outevent;
        }

        public string a28()
        {
            string outevent = "";
            outevent += "<p>Вы обнаруживаете по рентген снимку, что женщина беременна (на 6-ом месяце). Человеческий зародыш живой. Значит и женщина жива. Но почему она в таком странном безжизненном состоянии – пока непонятно.</p><br>";
            if (ViewModelLocator.StatusStatic.Crew.FirstOrDefault(c => c.Name == "Живодер")!=null)
            {
                outevent += "<a href=\"/125\">Перейдите на 125</a>";
            }
            else
            {
                outevent += "<br><b>Ваши действия?</b><br>";
                outevent += "<ul><li><a href=\"/18\">Оставить женщину в лазарете как есть – вернитесь на – 18</a></li>";
                outevent += "<ul><li><a href=\"/18\">Отправить одного из своих бойцов вместе с женщиной назад к шатлу. Уберите карточку одного бойца и карточку женщины из своей команды. Бросьте кубик за каждый отсек на пути вашего бойца к Ангару с шатлом – если хотя бы на одном из кубиков выпадет (5 или 6) – боец и женщина погибли по пути.</a></li>";
                outevent += "</ul>";
            };
            return outevent;
        }

        public string a27()
        {
            string outevent = "";
            outevent += "<p>Женщина – Нет зародыша Чужого.</p><br>";
            if (ViewModelLocator.StatusStatic.FindAbility("доктор"))
            {
                outevent += "<a href=\"/28\">У вас в команде есть персонаж с Умением - доктор, перейдите на - 28</a>";
            }
            else
            {
                outevent += "<a href=\"/18\">Нет доктора, вернитесь на - 18</a>";

            };
            return outevent;
        }

        public string a20_check()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "";
            outevent += "<p>Вы осмотрели отсек</p>: ";
            switch (randomNumber)
            {
                case 1: outevent += "боекомплект(+2)."; ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 2; break;
                case 2: outevent += "аптечка."; ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" }); break;
                case 3: outevent += "чип-плата"; ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" }); break;
                case 5: outevent += "инструкция по отладке Реактора (заменяет Умение «техник» при ремонте Реактора);";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "инструкция по отладке реактора" });
                    break;
                case 4: outevent += "ремонтный комплект";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "ремонтный комплект" });
                    break;
                case 6: outevent += "чип-ключ от арсенала";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от арсенала" });
                    break;
                default: break;
            };
            outevent += "<br><a href='/20'>Вернитесь на - 20</a>";
            return outevent + "<br>";
        }

        private bool a20_63 = false;
        private string a20()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1:
                    if (a20_63 == false)
                    {
                        a20_63 = true;
                        outevent += "<a href='/63'>Событие только для первого посещения - 63</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };
                    break;
                case 2: outevent += "<a href='/64'>Событие многоразовое - 64</a>"; break;
                case 3: outevent += "<a href='/65'>Событие многоразовое - 65</a>"; break;
                case 4: outevent += "<a href='/66'>Событие многоразовое - 66</a>"; break;
                case 5: outevent += "Нападение врага – Чужой-офицер – атакует сзади – атакует первым"; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst=false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));

                    break;
                case 6: outevent += "Нападение врага - Чужой-солдат – атакует сверху – вы атакуете первым."; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-солдат",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Hit,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 3,
                        MaxHealth = 3,
                        AttackFirst=false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));

                    break;
            };
            outevent += "<br><b>Ваши дельнейшие действия?</b><br><ul>";
            outevent += "<li><a href='/20_time-1'>Остаться в отсеке – (-1 Время) – бросайте снова кубик на Событие;</a></li>";
            outevent += "<li><a href='/20_check'>Осмотреть отсек</a></li>";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от арсенала"))
            {
                outevent += "<li><a href='/67'>Идти - в отсек Арсенала – 67</a></li>";
            };
            outevent += "<li><a href='/80'>Спустится на нижний уровень палубы в отсек Мастерских – 80</a></li>";
            outevent += "<li><a href='/19_time-1'>Лезть в воздухопровод и ползти – до отсека Кают (-2 Времени) - 19</a></li>";
            outevent += "<li><a href='/18_time-5'>Лезть в воздухопровод и ползти до отсека Лазарета (-5 Времени) - 18</a></li>";
            outevent += "<li><a href='/13_time-7'>Лезть в воздухопровод и ползти до Технического отсека (-7 Времени) – 13</a></li></ul>";

            return outevent + "<br>";
        }

        private bool a19_84 = false;
        private bool a19_85 = false;
        private bool a19_86 = false;
        private string a19()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: 
                    if (a19_84==false) {
                        a19_84 = true;
                        outevent += "<a href='/84'>Событие только для первого посещения – 84</a>"; 
                    } else {
                        outevent +="Ничего";
                    };
                    break;
                case 2: 
                    if (a19_85==false) {
                        a19_85 = true;
                        outevent += "<a href='/85'>Событие только для первого посещения – 85</a>"; 
                    } else {
                        outevent +="Ничего";
                    };
                    break;
                case 3:
                    if (a19_86==false)
                    {
                        a19_86 = true;
                        outevent += "<a href='/86'>Событие только для первого посещения – 86</a>"; 
                    } else {
                        outevent +="Ничего";
                    };
            break;
                case 4: outevent += "<a href='/87'>Событие многоразовое – 87</a>"; break;
                case 5: outevent += "Нападение врага - Чужой-офицер – атакует сзади – атакует первым."; 
                     ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Kill,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst=false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6: outevent += "Нападение врага - Чужой-солдат – атакует сверху – атакует первым."; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-солдат",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Hit,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 3,
                        MaxHealth = 3,
                        AttackFirst=false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
            };
            outevent += Texts.a19_select;

            return outevent + "<br>";
        }

        public bool a139_event = false;
        private string a60()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "<a href='/135'>Событие многоразовое - 135</a>"; break;
                case 2: outevent += "<a href='/136'>Событие многоразовое - 136</a>"; break;
                case 3: outevent += "<a href='/137'>Событие многоразовое - 137</a>"; break;
                case 4: outevent += "<a href='/138'>Событие многоразовое – 138</a>"; break;
                case 5:
                    if (a139_event == false)
                    {
                        outevent += "<a href='/139_a139_event'>Событие только для первого посещения – 139</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };
                    break;
                case 6: outevent += "Нападение врага - Чужой-краб – атакует сверху – атакует первым.";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem()
                    {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst = false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
            };
            outevent += Texts.a19_select;

            return outevent + "<br>";
        }

        public string a14()
        {
            if (ViewModelLocator.StatusStatic.FindAbility("биолог")) {
                return "<a href=\"/39\">Если у вас в команде есть биолог, идите на - 39</a>";
            }
            else {
                return "<a href=\"/13\">Если нет биолога, вернитесь на – 13</a>";
            };
        }

        public string a47()
        {
            string outstr = "";
            if (ViewModelLocator.StatusStatic.FindAbility("биолог") && ViewModelLocator.StatusStatic.FindInvItem("лазерный резак") && ViewModelLocator.StatusStatic.FindInvItem("био-контейнер"))
            {
                outstr = outstr + "<p>У вас есть биолог + лазерный резак +  био-контейнер, вам удается поместить зародыш Чужого в контейнер. Выполнение Миссии №6.</p><br>";
            };
            return outstr + "<br><a href=\"/43\">Вернитесь на – 43</a>";
        }

        public string a41()
        {
            string outstr = "<ul><li><a href=\"/44\">Стрелять в него – 44</a></li><li><a href=\"/45\">Не стрелять в него – 45</a></li>";
            if (ViewModelLocator.StatusStatic.FindAbility("психолог"))
            {
                outstr+="<li><a href=\"/46\">Если у вас в команде есть Психолог– 46</a></li>";
            };
            outstr += "</ul>";
            return outstr;
        }

        public string a6()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "";
            outevent+="<p>Вы завели автопогрузчик и сняли несколько контейнеров с верхнего ряда.  Вы открыли эти контейнеры.</p><br><p>Бросьте кубик – Вы нашли там: ";
            switch (randomNumber)
            {
                case 1: outevent += "боезапас(+3)."; 
                    ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 3; break;
                case 2: outevent += "чип-плату."; 
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" }); break;
                case 3: outevent += "один баллон с кислородом."; 
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="балон с кислородом"}); break;
                case 4: outevent+="пять комплектов скафандров (для перемещения в космосе – требуется наличие хотя бы одного бойца с Умением - навигатор).";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "скафандр" });
                    break;
                case 5: outevent+="один баллон пено-керамо-спрея.";
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "пено-керамо-спрей" });
                    break;
                case 6: outevent+="ничего полезного."; break;
                default: break;
            };
            outevent+="<br><a href='/1'>Вернитесь на - 1</a>";
            return outevent+"<br>";
        }



        public bool a13_16 = false;
        //a13
        private string techroom()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "<a href='/14'>Событие - 14</a>"; break;
                case 2: outevent += "<a href='/15'>Событие - 15</a>"; break;
                case 3:
                    if (a13_16 == false)
                    {
                        a13_16 = true;
                        outevent += "<a href='/16'>Событие для первого посещенния - 16</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };
                    break;
                case 4:
                    outevent += "Вы осмотрели отсек в поисках полезных предметов – "; 
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "био-контейнер.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "био-контейнер" });
                            break;
                        case 2: outevent += "чип-плата.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" });
                            break;
                        case 3: outevent += "кислородный баллон.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "кислородный баллон" });
                            break;
                        case 4: outevent += "лазерный резак.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "лазерный резак" });
                            break;
                        case 5: outevent += "универсальный ремонтный комплект.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "универсальный ремонтный комплект" });
                            break;
                        case 6: outevent += "ничего."; break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 5: outevent += "Нападение врага (Чужой-краб – атакует сзади – атакует первым)."; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = RunAway,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst=true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6: outevent += "Ничего"; break;
            };

            outevent += "<br><b>Ваше решение?</b><br>";
            outevent += Texts.a13_select;

            return outevent + "<br>";
        }

        const string Kill = "Убил";
        const string Hit = "Попал";
        const string Miss = "Мимо";
        const string Panic = "Паника";
        const string Reload = "Перезарядить";
        const string RunAway = "Убежал";
        const string Suck = "Присосался";


        public bool a1_2 = false;
        public bool a1_3 = false;
        private string angar() {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: 
                    if (a1_2==false) {
                        a1_2 = true;
                        outevent += "<a href='/2'>Событие только для первого посещения – 2</a>"; 
                    } else {
                        outevent += "Ничего";
                    };
                    break;
                case 2:
                    if (a1_3 == false)
                    {
                        a1_3 = true;
                        outevent += "<a href='/3'>Событие только для первого посещения – 3</a>";
                    }
                    else
                    {
                        outevent += "Ничего";
                    };
                    break;
                case 3: outevent += "Вы мельком осмотрели отсек в поисках полезных предметов –";
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "сварочный аппарат.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "сварочный аппарат" });
                            break;
                        case 2: outevent += "чип-плата.";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-плата" });
                            break;
                        case 3: outevent += "боезапас(+1).";
                            ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 1;
                            break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 4: outevent += "Нападение врага (Чужой-краб – атака сверху – атакует первыми)";
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() { 
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = RunAway,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst = true,
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 5: 
                    outevent += "Нападение врага (Чужой-офицер – атакует спереди – вы атакуете первым)"; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-офицер",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Hit,
                        attack4 = Kill,
                        attack5 = Miss,
                        attack6 = Miss,
                        Attack = 1,
                        Health = 5,
                        MaxHealth = 5,
                        AttackFirst=false 
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6: outevent += "Ничего"; break;
            };

            outevent += "<br><b>Ваше решение?</b><br>";
            outevent += Texts.a1_select;
            if (ViewModelLocator.StatusStatic.FindAbility("техник")) {
                outevent += "<li><a href=\"/6_time-1\">Использовать автопогрузчик, чтобы снять верхние контейнеры вниз и осмотреть их (вам (-1) Время) – требуется умение-техник. - 6</a></li>";
            };
            outevent += "</ul>";            

            return outevent+"<br>";
        }

        private bool a17_41 = false;
        private bool a17_42 = false;
        private string a17()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1:
                    if (a17_41==false)
                    {
                        a17_41 = true;
                        outevent += "<a href='/41'>Событие только для первого посещения – 41</a>"; 
                    } else {
                        outevent += "Ничего";
                    };
                    break;
                case 2:
                    if (a17_42 == false)
                    {
                        a17_42 = true;
                        outevent += "<a href='/42'>Событие только для первого посещения – 42</a>";
                    } else {
                        outevent += "Ничего";
                    };
                    break;
                case 3: outevent += "<a href='/43'>Событие многоразовое – 43</a>"; break;
                case 4:
                    outevent += "Вы осмотрели отсек на наличие предметов: ";
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "пено-керамо-спрей";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "пено-керамо-спрей" });
                            break;
                        case 2: outevent += "шоккер";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "шоккер" });
                            break;
                        case 3: outevent += "чип-ключ от отсека Генератора";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "чип-ключ от отсека Генератора" });
                            break;
                        case 4: outevent += "аптечка";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" });
                            break;
                        case 5: outevent += "боезапас(+1)";
                            ViewModelLocator.StatusStatic.Ammo = ViewModelLocator.StatusStatic.Ammo + 1;
                            break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 5: outevent += "Нападение врага - Чужой-солдат – атакует спереди – вы атакуете первым.";
                     ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-солдат",
                        attack1 = Hit,
                        attack2 = Hit,
                        attack3 = Hit,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 3,
                        MaxHealth = 3,
                        AttackFirst=false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));
                    break;
                case 6: outevent += "Нападение врага - Чужой-краб – атакует сзади – вы стреляете первым."; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst=false
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));

                    break;
            };

            outevent += "<br><b>Ваше решение?</b><br>";
            outevent += Texts.a17_select;

            return outevent + "<br>";
        }


        private bool a18_21 = false;
        private bool a18_22 = false;
        private bool a18_23 = false;
        private string a18()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1:
                    if (a18_21==false)
                    {
                        a18_21 = true;
                        outevent += "<a href='/21'>Событие только для первого посещения – 21</a>"; 
                    } else {
                        outevent += "Ничего.";
                    };
                    break;
                case 2:
                    if (a18_22 == false)
                    {
                        a18_22 = true;
                        outevent += "<a href='/22'>Событие только для первого посещения – 22</a>";
                    } else {
                        outevent += "Ничего.";
                    };
                    break;
                case 3: 
                    if (a18_23 == false)
                    {
                        a18_23 = true;
                        outevent += "<a href='/23'>Событие только для первого посещения – 23</a>";
                    } else {
                        outevent += "Ничего.";
                    };
                    break;
                case 4:
                    outevent += "Вы мельком осмотрели отсек в поисках полезных предметов: ";
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "аптечка";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "аптечка" });
                            break;
                        case 2: outevent += "хирургический лазерный резак";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "лазерный резак" });
                            break;
                        case 3: outevent += "кислородный балон";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "кислородный балон" });
                            break;
                        case 4: outevent += "таблетки \"Антишок\"";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "таблетки \"Антишок\"" });
                            break;
                        case 5: outevent += "таблетки \"Антишок\"";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="таблетки \"Антишок\""});
                            break;
                        case 6: outevent += "переносной рентген-аппарат";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title="переносной рентген-аппарат"});
                            break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 5: outevent += "Нападение врага - Чужой-краб – атакует сзади – атакует первым."; 
                    ViewModelLocator.BattleStatic.CurrentEnemy = new PersonItem() {
                        Name = "Чужой-краб",
                        attack1 = Suck,
                        attack2 = Suck,
                        attack3 = Suck,
                        attack4 = Miss,
                        attack5 = Miss,
                        attack6 = RunAway,
                        Attack = 1,
                        Health = 1,
                        MaxHealth = 1,
                        AttackFirst=true
                    };
                    (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/BattlePage.xaml", UriKind.Relative));

                    break;
                case 6: outevent += "Ничего."; break;
            };

            outevent += "<br><b>Ваше решение?</b><br>";
            outevent += "<ul><li><a href=\"/18_time-1\">Остаться в отсеке(вам(-1) Время) – еще раз бросать кубик на событие.</a></li>";
            if (ViewModelLocator.StatusStatic.FindAbility("техник") && ViewModelLocator.StatusStatic.FindInvItem("чип-плата")) {
                ViewModelLocator.StatusStatic.DeleteInvItem("чип-плата");
                outevent += "<li><a href=\"/18_life+1\">У вас есть предмет - чип-плата и умение техник, то вы можете починить робота-доктора и восстановить здоровье своим раненым бойцам. Каждому бойцу можно восстановить максимум (+1) Жизнь.</a></li>";
            };
            outevent += Texts.a18_select;

            return outevent + "<br>";
        }



        public ObservableCollection<PageItem> Pages;

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}