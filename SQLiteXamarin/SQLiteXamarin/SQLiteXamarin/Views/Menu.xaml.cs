using System;
using Xamarin.Forms;

namespace SQLiteXamarin.Views
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            Title = "Xamarin SQLite";
            InitializeComponent();
        }
        
        private void btnInsert(object sender, EventArgs e)
        {
            var startPage = (Start)this.Parent;
            startPage.Detail = new Create();
            startPage.IsPresented = false;
        }

        private void btnList(object sender, EventArgs e)
        {
            var startPage = (Start)this.Parent;
            startPage.Detail = new List();
            startPage.IsPresented = false;
        }
    }
}
