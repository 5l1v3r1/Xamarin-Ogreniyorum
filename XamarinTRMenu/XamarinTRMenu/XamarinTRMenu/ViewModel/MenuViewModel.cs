using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinTRMenu.Data;
using XamarinTRMenu.Models;

namespace XamarinTRMenu.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<MenuModel> _menu;

        public ObservableCollection<MenuModel> Menu
        {
            get
            {
                return _menu;
            }
            set
            {
                _menu = value;
                OnPropertyChanged();
            }
        }

        public MenuViewModel()
        {
            Menu = MenuDataBinding.BindMenu();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}