using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSqlLite.Helper;
using AppSqlLite.Models;
using Xamarin.Forms;

namespace AppSqlLite.View
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            var manager= new SqLiteManeger();
            var listStudents= new List<Student>();
            listStudents = manager.GetAllStudents().ToList();
            lstSutdents.BindingContext = listStudents;
        }
        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void Listele_OnClick(object sender, EventArgs e)
        {
            var manager = new SqLiteManeger();
            var listStudents = new List<Student>();
            listStudents = manager.GetAllStudents().ToList();
            lstSutdents.BindingContext = listStudents;
        }
    }
}
