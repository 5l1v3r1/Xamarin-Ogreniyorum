using PCL_Ornek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PCL_Ornek.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            Title = "PCL Menu";
            var _pickerModel = PickerModel.CreateModel();
            lvMenu.ItemsSource = _pickerModel;
            lvMenu.ItemSelected += LvMenu_ItemSelected;
        }

        private void LvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PickerModel selectedModel = (PickerModel)e.SelectedItem;
            DisplayAlert("Picker Model", selectedModel.Name, "Ok");
        }
    }
}
