namespace System.Windows.Controls {}
namespace System.Windows.Documents {}
namespace System.Windows.Ink {}
namespace System.Windows.Input {}
namespace System.Windows.Media {}
namespace System.Windows.Media.Animation {}
namespace System.Windows.Shapes {}
namespace GalaSoft.MvvmLight { public class ViewModelBase : System.ComponentModel.INotifyPropertyChanged { public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged; protected void RaisePropertyChanged(string n) { if(PropertyChanged!=null)PropertyChanged(this,new System.ComponentModel.PropertyChangedEventArgs(n)); } } }
namespace AliensOldEnemies.ViewModel {public static class ViewModelLocator {public static Status StatusStatic=new Status();} public class Status {public int CrewCount,ItemCount;public int CountSelectedCrew(){return CrewCount;}public int CountSelectedPossibleItems(){return ItemCount;}}}
