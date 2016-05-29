using SQLiteXamarin.Connection;
using SQLiteXamarin.Models;
using SQLiteXamarin.ViewModels;
using Xamarin.Forms;

namespace SQLiteXamarin.Views
{
    public partial class List : ContentPage
    {
        public List()
        {
            InitializeComponent();
            BindingContext = new StudentViewModel();
        }

        private async void lstItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = (Student)e.SelectedItem;
            var accepted = await DisplayAlert(selected.Name, "Silinsin mi?", "Evet", "Vazgeç");
            if (accepted)
            {
                SQLiteClient _client = new SQLiteClient();
                _client.Delete(selected.Id);
            }
            BindingContext = new StudentViewModel();
        }
    }
}
