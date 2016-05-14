using System.Collections.Generic;
using XamarinTR_MVVM.Models;

namespace XamarinTR_MVVM.Services
{
    public class StudentService
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Name = "Yiğit", Department = "Software Engineering" },
                new Student { Name = "Serkan", Department = "Math" },
                new Student { Name = "İbrahim", Department = "Computer Engineering" }
            };
        }
    }
}