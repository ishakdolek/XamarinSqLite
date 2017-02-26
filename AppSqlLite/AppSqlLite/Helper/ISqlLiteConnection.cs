using SQLite.Net;

namespace AppSqlLite.Helper
{
  public  interface ISqlLiteConnection
  {
      SQLiteConnection GetConnection();
  }
}
