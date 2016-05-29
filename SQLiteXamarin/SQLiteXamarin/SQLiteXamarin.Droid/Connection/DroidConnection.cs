using System;
using SQLite.Net;
using SQLiteXamarin.Connection;
using System.IO;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;
using SQLiteXamarin.Droid.Connection;

[assembly: Dependency(typeof(DroidConnection))]
namespace SQLiteXamarin.Droid.Connection
{
    public class DroidConnection : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "Student.db";
            var documentspath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);
            var platform = new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}