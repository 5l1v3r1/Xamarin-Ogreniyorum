using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinTR_MVVM.Models;
using XamarinTR_MVVM.Services;

namespace XamarinTR_MVVM.ViewModels
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private List<Student> _students;
        public List<Student> Students
        {
            get
            {
                return _students;
            }

            set
            {
                _students = value;
                OnPropertyChanged();
            }
        }

        public StudentViewModel()
        {
            var studentService = new StudentService();

            Students = studentService.GetStudents();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}