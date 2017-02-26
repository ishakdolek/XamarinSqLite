using System;
using AppSqlLite.Droid.ConnectionHelper;
using AppSqlLite.Helper;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;

[assembly:Xamarin.Forms.Dependency(typeof(GetDroidConnection))]
namespace AppSqlLite.Droid.ConnectionHelper
{
    public class GetDroidConnection :ISqlLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentPath,App.DbName);
            var platform= new SQLitePlatformAndroid();
            var connection = new SQLiteConnection(platform,path);
            return connection;
        }
    }
}