using Xamarin.Forms;
using static ListViewGrouping.Data.BJKFactory;

namespace ListViewGrouping.Views
{
    public partial class Detail : ContentPage
    {
        public Detail(Player player)
        {
            Title = player.FullName;
            BindingContext = player;
            InitializeComponent();
            Icon = "icon.png";
        }
    }
}