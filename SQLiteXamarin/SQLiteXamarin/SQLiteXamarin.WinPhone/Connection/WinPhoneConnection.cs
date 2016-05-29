using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using SQLiteXamarin.Connection;
using SQLiteXamarin.WinPhone.Connection;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(WinPhoneConnection))]
namespace SQLiteXamarin.WinPhone.Connection
{
    public class WinPhoneConnection : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "Student.db";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
            var platform = new SQLitePlatformWinRT();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}