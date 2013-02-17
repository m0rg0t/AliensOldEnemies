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
                return this.Pages.FirstOrDefault(c => c.Id==this.CurrentPageId);
            }
        }

        private string _currentPage;
        public string CurrentPageId
        {
            get { 
                return _currentPage;  
            }
            set { 
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
                    Title = "Каюты – событие",
                    Description = Texts.a86,
                    Id = "/86",
                    Music = "/Music/Bent_and_Broken.mp3"
                });

                Pages.Add(new PageItem
                {
                    Title = "Каюты",
                    Description = Texts.a117,
                    Id = "/117",
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
                    Description = Texts.a124,
                    Id = "/124",
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
                    Title = "Монтгомери",
                    Description = Texts.a141,
                    Id = "/141",
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
                    Description = Texts.a146,
                    Id = "/146",
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
                    Title = "Выбор",
                    Description = Texts.a160,
                    Id = "/160",
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
                    Title = "Коридор Е",
                    Description = Texts.a169,
                    Id = "/169",
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
                    Title = "Неверно",
                    Description = Texts.a260,
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
                    Title = "Удача",
                    Description = Texts.a285,
                    Id = "/285",
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
                
            }

        }

        public string PathsSelect(string page) {
            switch (page) {
                case "/1": return angar();
                case "47": return a47();
                case "41": return a41();
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
                case "/124": return a124();
                case "/146": return a146();
                default: return "";
            }
        }
        public bool Mission6 = false;
        public bool Mission5 = false;
        public bool Mission4 = false;
        public bool Mission3 = false;
        public bool Mission2 = false;
        public bool Mission1 = false;

        public bool mak_kolinz_saved = false;
        public bool livengaup_saved = false;
        public bool hartman_saved = false;
        public bool security_system_central_computer_dispabled = false;


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
            outevent += "<br><a href=\"20\">Вернитесь на – 20</a>";
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
            if (security_system_central_computer_dispabled == true)
            {
                outevent += "<a href=\"/71\">Если вы уже отключили Систему безопасности на центральном компьютере корабля – то переходите на – 71</a>";
            }
            else
            {
                outevent += "<a href=\"72\">Если вы еще не отключили систему безопасности – то переходите на – 72</a>";
            };
            outevent += "</ul>";
            return outevent;
        }

        public string a40()
        {
            string outevent = "Негр заражен.<br>";
            if (ViewModelLocator.StatusStatic.FindInvItem("био-контейнер") && ViewModelLocator.StatusStatic.FindInvItem("лазерный резак") && ViewModelLocator.StatusStatic.FindAbility("доктор"))
            {
                outevent += "<a href=\"29_mission6\">Вы вскрыли тело негра и заключить в био-контейнер зародыш Чужого. Отметьте на своей карточке персонажа, что вы выполнили Миссию №6.</a>";
            }
            else
            {
                outevent += "<a href=\"29_ammo-1\">Расстреляйте этого зародыша Чужого (-1 боезапас).</a>";
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
                outevent += "<li><a href=\"70\"><li>Если у вас есть психолог – 70</a></li>";
            };
            outevent += "<li><a href=\"69\">Крикнуть ему, что вы группа спасения – 69</a></li>";
            outevent += "<li><a href=\"68\">Стрелять в него – 68</a></li>";
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
                outevent += "<li><a href=\"17_mission6\"><li>У вас есть био-контейнер, вы можете посадить тварь в контейнер и отметить выполнение Миссии №6 – 17</a></li>";
            };
            outevent += "<li><a href=\"62\"><li>Вы можете приказать биологу отбросить тварь подальше в сторону, чтобы вы могли ее расстрелять с безопасного расстояния – 62</a></li>";
            outevent += "</ul>";

            return outevent;
        }

        public string a59()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.Ammo > 0)
            {
                outevent += "<li><a href=\"17_ammo-1_biolog_dead\"><li>Расстрелять тварь вместе с биологом – вам (-1) боезапас. Вернитесь на – 17</a></li>";
            };
            if (ViewModelLocator.StatusStatic.Crew.Where(c => c.Abilities.FirstOrDefault(a => a == "биолог") != null).Count()>1)
            {
                outevent += "<li><a href=\"61\"><li>У вас в команде есть еще один специалист биолог – попытаться побыстрее снять краба с лица жертвы – 61</a></li>";
            };
            if (ViewModelLocator.StatusStatic.CountInvItem("шокер") > 0)
            {
                outevent += "<li><a href=\"58\"><li>У вас есть шоккер – ударить тварь разрядом тока – 58</a></li>";
            };
            outevent += "<li><a href=\"17\"><li>Оставить жертву и краба так как есть – 17</a></li>";
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
                outevent += "<li><a href=\"58\"><li>У вас есть шоккер – ударить тварь разрядом тока – 58</a></li>";
            }; 
            outevent += "<li><a href=\"19\"><li>Ничего не делать. Позволить твари присосаться к биологу – 59</a></li>";
            outevent += "</ul>";

            return outevent;
        }

        public string a56()
        {
            string outevent = "<ul>";
            if (ViewModelLocator.StatusStatic.CountInvItem("аптечка")>2)
            {
                outevent += "<li><a href=\"59_use_healthpack3\"><li>Потребуется использовать (-3) аптечки для заживления сильных ожогов раненого – 59</a></li>";
            };
                outevent += "<li><a href=\"17_biolog_dead\"><li>Оставить биолога умирать. Вернитесь на – 17</a></li>";
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
                outevent += "<li><a href=\"17\"><li>Оставить ее в бессознательном состоянии в этом отсеке. – 17</a></li>";
                outevent += "<li><a href=\"17_vagner_send\"><li>Отправить женщину вместе с одним из своих людей в отсек Ангара</a></li>";
                outevent += "</ul>";
            }
            else
            {
                outevent = "<ul>";
                outevent += "<a href=\"17\"><li>Расстрелять Чужого-краба вместе с женщиной – 17</a></li>";
                outevent += "<a href=\"17\"><li>Оставить женщину и Чужого здесь – 17</a></li>";
                if (ViewModelLocator.StatusStatic.FindAbility("биолог"))
                {
                    outevent += "<a href=\"55\"><li>Попытаться снять Чужого-краба с лица женщины – 55</a></li>";
                };
                outevent += "<a href=\"17_vagner_send\"><li>Отправить женщину вместе с одним из своих людей в отсек Ангара</a></li>";
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
                outevent += "<li><a href=\"47\">обследуйте мужчину на наличие в его теле Чужого – 47</a></li>";
            };
            if (ViewModelLocator.StatusStatic.FindInvItem("аптечка"))
            {
                outevent += "<li><a href=\"48_use_healthpack\">Приведите его в чувство (-1 аптечка) – 48</a></li>";
            };
            outevent += "<li><a href=\"17\">Оставить его здесь как есть – 17</a></li>";
            outevent += "<li><a href=\"17_juzepe_send\">Отправить его в сопровождении с одним из своих людей в Ангар</a></li>";
            outevent += "<li><a href=\"17_juzepe_add\">Присоединить его к своей команде – 17</a></li>";
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
                outevent += "<li><a href=\"90\">Вы можете разблокировать дверь</a></li>";
            };
            outevent += "<li><a href=\"18\">в Лазарет – 18</a></li>";
            outevent += "<li><a href=\"100\">в отсек Генератора – 100</a></li>";
            outevent += "<li><a href=\"130\">в Коридор «Д» - 130</a></li>";
            outevent += "<li><a href=\"120\">в Оранжерею – 120</a></li>";
            outevent += "<li><a href=\"110\">в коридор «Е» - 110</a></li>";
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
                outevent += "<li><a href=\"30_a30_tauer\">Перевязать Тауэра (вам -1 аптечка) – негру (+1) Жизнь.</a></li>";
            };
            if (ViewModelLocator.StatusStatic.FindInvItem("портативный рентген-аппарат"))
            {
                outevent += "<li><a href=\"34\">Проверить негра рентген-аппаратом на наличие в его теле зародыша Чужого – 34</a></li>";
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
                outevent += "<li><a href=\"142\">Если у вас есть рентген-аппарат, то вы можете проверить умирающего на наличие у него внутри зародыша Чужого. – 142</a></li>";
            }; 
            
            outevent += "</ul>";
            return outevent;
        }

        public string a32()
        {
            string outevent = "";
            if (ViewModelLocator.StatusStatic.FindInvItem("чип-ключ от отсека грузового лифта"))
            {
                outevent += "<a href=\"33\">У вас есть чип-ключ от отсека Грузового лифта – переходите на – 33</a>";
            }
            else
            {
                outevent += "<a href=\"23\">У вас нет чип-ключа – вернитесь на – 23</a>";
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
                outevent += "<a href=\"125\">Перейдите на 125</a>";
            }
            else
            {
                outevent += "<br><b>Ваши действия?</b><br>";
                outevent += "<ul><li><a href=\"18\">Оставить женщину в лазарете как есть – вернитесь на – 18</a></li>";
                outevent += "<ul><li><a href=\"18\">Отправить одного из своих бойцов вместе с женщиной назад к шатлу. Уберите карточку одного бойца и карточку женщины из своей команды. Бросьте кубик за каждый отсек на пути вашего бойца к Ангару с шатлом – если хотя бы на одном из кубиков выпадет (5 или 6) – боец и женщина погибли по пути.</a></li>";
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
                outevent += "<a href=\"28\">У вас в команде есть персонаж с Умением - доктор, перейдите на - 28</a>";
            }
            else
            {
                outevent += "<a href=\"18\">Нет доктора, вернитесь на - 18</a>";

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
                return "<li><a href=\"/46\">Если у вас в команде есть Психолог– 46</a></li>";
            };
            return outstr+"</ul>";
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
                    ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "баллон пено-керамо-спрея" });
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
                        case 1: outevent += "пенно-керамо-спрей";
                            ViewModelLocator.StatusStatic.InvItems.Add(new InvItem() { Title = "пенно-керамо-спрей" });
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