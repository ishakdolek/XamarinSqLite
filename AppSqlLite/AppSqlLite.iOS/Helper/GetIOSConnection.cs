using System;
using System.IO;
using AppSqlLite.Helper;
using AppSqlLite.iOS.Helper;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;

[assembly:Xamarin.Forms.Dependency(typeof(GetIosConnection))]
namespace AppSqlLite.iOS.Helper
{
    public class GetIosConnection : ISqlLiteConnection
    {
        public SQLiteConnection GetConnection()
        {

            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, App.DbName);
            var platform = new SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, path);
            return connection;
        }
    }
}
