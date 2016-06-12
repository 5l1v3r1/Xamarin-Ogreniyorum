using Xamarin.Forms;
using XamarinTRMenu.Models;
using XamarinTRMenu.ViewModel;

namespace XamarinTRMenu.Views
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            Title = "www.xamarintr.com";
            Icon = "menu.png";
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }

        private void onStudentSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (MenuModel)e.SelectedItem;
            if (selectedItem != null)
            {
                //Uyarı mesajı
                DisplayAlert("www.xamarintr.com", selectedItem.Name, "OK");

                //Eğer bir nesne seçildikten sonra menu'yu kapatmak istiyorsanız..
                var mdPage = (Startup)this.Parent;
                mdPage.IsPresented = false;

                //Eğer bir nesne seçildikten sonra, seçtiğiniz nesne üzerindeki "selected" özelliğini kaldırmak istiyorsanız..
                var lstMenu = (ListView)sender;
                lstMenu.SelectedItem = null;
            }
        }
    }
}