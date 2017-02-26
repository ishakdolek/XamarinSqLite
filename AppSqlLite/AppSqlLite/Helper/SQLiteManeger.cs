using System.Collections.Generic;
using AppSqlLite.Models;
using SQLite.Net;
using Xamarin.Forms;

namespace AppSqlLite.Helper
{
    public class SqLiteManeger
    {
        private readonly SQLiteConnection _sqLiteConnection;

        public SqLiteManeger()
        {
            _sqLiteConnection = DependencyService.Get<ISqlLiteConnection>().GetConnection();
            _sqLiteConnection.CreateTable<Student>();
        }

        #region CRUD

        public int Insert(Student s)
        {
            return _sqLiteConnection.Insert(s);
        }

        public int Update(Student s)
        {
            return _sqLiteConnection.Update(s);
        }

        public int Delete(int Id)
        {
            return _sqLiteConnection.Delete<Student>(Id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _sqLiteConnection.Table<Student>();
        }

        public Student Get(int Id)
        {
            //return _sqLiteConnection.Table<Student>().FirstOrDefault(x => x.Id == Id);
            return null;
        }

        public void Dispose()
        {
            _sqLiteConnection.Dispose();
        }
        #endregion
    }
}
