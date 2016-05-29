using SQLite.Net;

namespace SQLiteXamarin.Connection
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}