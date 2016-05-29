using SQLiteXamarin.Connection;
using SQLiteXamarin.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SQLiteXamarin.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private static SQLiteClient _client = null;
        private static SQLiteClient GetConnection()
        {
            if (_client == null)
                _client = new SQLiteClient();
            return _client;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<Student> _student;

        public IEnumerable<Student> Student
        {
            get
            {
                return _student;
            }

            set
            {
                _student = value;
                OnPropertyChanged();
            }
        }

        public StudentViewModel()
        {
            Student = GetConnection().GetAll();
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}