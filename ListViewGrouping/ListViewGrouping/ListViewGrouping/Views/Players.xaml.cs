using ListViewGrouping.Data;
using System;
using Xamarin.Forms;
using static ListViewGrouping.Data.BJKFactory;

namespace ListViewGrouping.Views
{
    public partial class Players : ContentPage
    {
        public Players()
        {
            InitializeComponent();
            Icon = "icon.png";
            refreshCount++;
            BindingContext = BJKFactory.GetPlayersWithGrouping();
        }

        void OnAlert(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            Player player = (Player)item.BindingContext;
            DisplayAlert("BJK Players", player.FullName, "Cancel", "Ok");
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Player selectedPlayer = (Player)e.SelectedItem;
            ListView lv = (ListView)sender;
            lv.SelectedItem = null;
            if (selectedPlayer != null)
                await this.Navigation.PushAsync(new Detail(selectedPlayer));
        }

        void OnRefreshing(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            refreshCount++;
            BindingContext = BJKFactory.GetPlayersWithGrouping();
            lv.IsRefreshing = false;
        }

        void onSearch(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.NewTextValue) && e.NewTextValue.Length > 2)
                BindingContext = BJKFactory.GetPlayersWithGrouping(e.NewTextValue);
            else if(String.IsNullOrEmpty(e.NewTextValue))
                BindingContext = BJKFactory.GetPlayersWithGrouping();
        }
    }
}
