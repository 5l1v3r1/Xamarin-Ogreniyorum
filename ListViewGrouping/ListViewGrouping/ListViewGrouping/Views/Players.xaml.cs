using ListViewGrouping.Data;
using ListViewGrouping.Utility;
using System;
using System.Collections.ObjectModel;
using System.Linq;
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

            BindingContext = new ObservableCollection<Grouping<string, Player>>(
                BJKFactory.Players
                .OrderBy(c => c.FullName)
                .GroupBy(c => c.FullName[0].ToString(), c => c)
                .Select(g => new Grouping<string, Player>(g.Key, g)));
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

        int refreshCount = 0;
        void OnRefreshing(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            BindingContext = new ObservableCollection<Grouping<string, Player>>(
                BJKFactory.Players
                .OrderBy(c => refreshCount % 2 == 0 ? c.Country : c.FullName)
                .GroupBy(c => refreshCount % 2 == 0 ? c.Country[0].ToString() : c.FullName[0].ToString(), c => c)
                .Select(g => new Grouping<string, Player>(g.Key, g)));

            refreshCount++;
            lv.IsRefreshing = false;
        }
    }
}
