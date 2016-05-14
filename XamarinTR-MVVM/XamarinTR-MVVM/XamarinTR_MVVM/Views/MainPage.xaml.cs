using Xamarin.Forms;
using XamarinTR_MVVM.Models;
using XamarinTR_MVVM.ViewModels;

namespace XamarinTR_MVVM.Views
{
    public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            Padding = new Thickness(5, 10, 5, 0);
            BindingContext = new StudentViewModel();
        }

        public void onStudentSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Student)
            {
                var selectedStudent = (Student)e.SelectedItem;
                DisplayAlert(selectedStudent.Name, selectedStudent.Department, "OK");
            }
            var listView = (ListView)sender;
            listView.SelectedItem = null;
        }
    }
}