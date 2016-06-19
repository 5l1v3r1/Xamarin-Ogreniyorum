using System;
using System.Collections.Generic;
using XamarinConverters.Models;

namespace XamarinConverters.Data
{
    public class BindPerson
    {
        public static IList<Person> Persons { get; set; }

        static BindPerson()
        {
            Persons = new List<Person>
            {
                new Person { FirstName = "Mr", LastName = "Smith", Gender = Gender.Male,
                    BirthDate = new DateTime(1986, 11, 7)},
                new Person { FirstName = "Mrs", LastName = "Smith", Gender = Gender.Female,
                    BirthDate = new DateTime(1990, 06, 11) }
            };
        }
    }
}