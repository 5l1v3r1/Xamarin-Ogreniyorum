using SQLiteXamarin.Connection;
using SQLiteXamarin.Models;
using System;
using Xamarin.Forms;

namespace SQLiteXamarin.Views
{
    public partial class Create : ContentPage
    {
        public Create()
        {
            InitializeComponent();
        }

        private void SaveStudent(object sender, EventArgs e)
        {
            Student _student = new Student();
            _student.Name = txtName.Text;
            _student.Surname = txtSurname.Text;
            _student.About = txtAbout.Text;
            _student.BirthDate = pickerBirthDate.Date;

            SQLiteClient _client = new SQLiteClient();
            var result = _client.Insert(_student);

            if (result > 0)
                DisplayAlert(_student.Name, "Eklendi", "Ok");
            else
                DisplayAlert("Hata Oluştu", "Öğrenci Eklenemedi!", "Ok");

            var startPage = (Start)this.Parent;
            startPage.Detail = new List();
            startPage.IsPresented = false;
        }
    }
}
