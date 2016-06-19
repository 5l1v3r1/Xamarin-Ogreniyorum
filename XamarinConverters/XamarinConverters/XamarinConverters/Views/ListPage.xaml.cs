using Xamarin.Forms;
using XamarinConverters.Data;

namespace XamarinConverters.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            BindingContext = BindPerson.Persons;
        }
    }
}