using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using XamarinConverters.Data;
using XamarinConverters.Models;

namespace XamarinConverters.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            //BindingContext = BindPerson.Persons;
            BindingContext = new ObservableCollection<Grouping<string, Person>>(
            BindPerson.Persons
            .OrderBy(c => c.FirstName)
            .GroupBy(c => c.FirstName[0].ToString(), c => c)
            .Select(g => new Grouping<string, Person>(g.Key, g)));
        }

        bool reverse;
        void OnRefreshing(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;

            List<Person> reversedData = ((reverse)
                ? BindPerson.Persons.OrderBy(p => p.FirstName)
                : BindPerson.Persons.OrderByDescending(p => p.FirstName)).ToList();
            reverse = !reverse;

            BindPerson.Persons.Clear();
            foreach (var item in reversedData)
                BindPerson.Persons.Add(item);


            lv.IsRefreshing = false;
        }
    }
}