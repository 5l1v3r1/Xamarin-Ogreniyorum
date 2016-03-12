using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SharedProject.Views
{
	public partial class Detail : ContentPage
	{
        int sayac = 0;
		public Detail ()
		{
			InitializeComponent ();
            lblXamarintr.Text = "Xamarintr.com " + sayac;
		}

        public void btnClicked(object sender, EventArgs e)
        {
            sayac++;
            lblXamarintr.Text = "Xamarintr.com " + sayac;
        }
	}
}
