using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;
using System;

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
                    return CurrentPage.Description + PathsSelect(CurrentPageId);
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
            }
        }

        public int Time = 40;

        public string PathsSelect(string page) {
            switch (page) {
                case "/1": return angar();
                case "/6": return a6();
                case "/13": return techroom();
                default: return "";
            }
        }

        public string a6()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "";
            outevent+="<p>Вы завели автопогрузчик и сняли несколько контейнеров с верхнего ряда.  Вы открыли эти контейнеры.</p><br><p>Бросьте кубик – Вы нашли там: ";
            switch (randomNumber)
            {
                case 1: outevent+="боезапас(+3)."; break;
                case 2: outevent+="чип-плату."; break;
                case 3: outevent+="один баллон с кислородом."; break;
                case 4: outevent+="пять комплектов скафандров(для перемещения в космосе – требуется наличие хотя бы одного бойца с Умением-навигатор)."; break;
                case 5: outevent+="один баллон пено-керамо-спрея."; break;
                case 6: outevent+="ничего полезного."; break;
                default: break;
            };
            outevent+="<br><a href='/1'>Вернитесь на - 1</a>";
            return outevent+"<br>";
        }

        private string techroom()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "<a href='/14'>Событие - 14</a>"; break;
                case 2: outevent += "<a href='/15'>Событие - 15</a>"; break;
                case 3: outevent += "<a href='/16'>Событие для первого посещенния - 16</a>"; break;
                case 4:
                    outevent += "Вы осмотрели отсек в поисках полезных предметов – "; 
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "био-контейнер."; break;
                        case 2: outevent += "чип-плата."; break;
                        case 3: outevent += "кислородный баллон."; break;
                        case 4: outevent += "лазерный резак."; break;
                        case 5: outevent += "универсальный ремонтный комплект."; break;
                        case 6: outevent += "ничего."; break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 5: outevent += "Нападение врага (Чужой-краб – атакует сзади– атакует первым)."; break;
                case 6: outevent += "Ничего"; break;
            };

            outevent += "<br><b>Ваше решение?</b><br>";
            outevent += Texts.a13_select;

            return outevent + "<br>";
        }

        private string angar() {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            string outevent = "<br><b>События:</b><br>";
            switch (randomNumber)
            {
                case 1: outevent += "<a href='/2'>Событие только для первого посещения – 2</a>"; break;
                case 2: outevent += "<a href='/3'>Событие только для первого посещения – 3</a>"; break;
                case 3: outevent += "Вы мельком осмотрели отсек в поисках полезных предметов –";
                    int randomItem = random.Next(1, 7);
                    switch (randomItem)
                    {
                        case 1: outevent += "сварочный аппарат."; break;
                        case 2: outevent += "чип-плата."; break;
                        case 3: outevent += "боезапас(+1)."; break;
                        default: outevent += "ничего."; break;
                    };
                    break;
                case 4: outevent += "Нападение врага(Чужой-краб – атака сверху – атакует первыми)"; break;
                case 5: outevent += "Нападение врага(Чужой-солдат– атакует спереди– вы атакуете первым)"; break;
                case 6: outevent += "Ничего"; break;
            };

            outevent += "<br><b>Ваше решение?</b><br>";
            outevent += Texts.a1_select;

            return outevent+"<br>";
        }

        public ObservableCollection<PageItem> Pages;

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}