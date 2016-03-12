using SharedProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SharedProject.Views
{
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
            Title = "Xamarintr.com";

            List<MenuModel> model = new List<MenuModel>()
            {
                new MenuModel
                {
                    Id = 1,
                    Title = "Xamarin"
                },
                new MenuModel
                {
                    Id = 2,
                    Title = "C#"
                },
                new MenuModel
                {
                    Id = 3,
                    Title = "ASP.NET"
                }
            };

            lstMenu.ItemsSource = model;
		}
    }
}
