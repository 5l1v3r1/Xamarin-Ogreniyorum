using SQLite.Net.Attributes;
using System;

namespace SQLiteXamarin.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string FirstCharacter
        {
            get
            {
                if (!String.IsNullOrEmpty(Name))
                {
                    return Name.Substring(0, 1).ToUpper();
                }
                else
                {
                    return "";
                }
            }
        }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string About { get; set; }
    }
}