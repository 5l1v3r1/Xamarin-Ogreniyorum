using System.Collections.ObjectModel;
using XamarinTRMenu.Models;

namespace XamarinTRMenu.Data
{
    public class MenuDataBinding
    {
        public static ObservableCollection<MenuModel> BindMenu()
        {
            return new ObservableCollection<MenuModel>
            {
                new MenuModel { Id = 1, Name = "Main" },
                new MenuModel { Id = 1, Name = "Shop" },
                new MenuModel { Id = 1, Name = "Categories" },
                new MenuModel { Id = 1, Name = "Data" },
                new MenuModel { Id = 1, Name = "Maps" },
                new MenuModel { Id = 1, Name = "Xamarin" },
            };
        }
    }
}