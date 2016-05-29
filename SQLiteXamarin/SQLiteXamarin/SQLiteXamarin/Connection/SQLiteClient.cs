using SQLite.Net;
using SQLiteXamarin.Models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SQLiteXamarin.Connection
{
    public class SQLiteClient
    {
        static object locker = new object();

        SQLiteConnection _sqlconnection;

        public SQLiteClient()
        {
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<Student>();
        }

        public int Insert(Student DB)
        {
            lock (locker)
            {
                return _sqlconnection.Insert(DB);
            }
        }

        public int Update(Student DB)
        {
            lock (locker)
            {
                return _sqlconnection.Update(DB);
            }
        }

        public int Delete(int id)
        {
            lock (locker)
            {
                return _sqlconnection.Delete<Student>(id);
            }
        }

        public IEnumerable<Student> GetAll()
        {
            lock (locker)
            {
                return (from i in _sqlconnection.Table<Student>() select i).ToList();
            }
        }

        public Student Get(int id)
        {
            lock (locker)
            {
                return _sqlconnection.Table<Student>().FirstOrDefault(t => t.Id == id);
            }
        }

        public void Dispose()
        {
            _sqlconnection.Dispose();
        }
    }
}