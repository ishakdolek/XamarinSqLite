using System;
using SQLite.Net.Attributes;

namespace AppSqlLite.Models
{
    public class Student
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegisteDate { get; set; }
    }
}
