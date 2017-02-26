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
            var manager = new SqLiteManeger();
            var listStudents = new List<Student>();
            listStudents = manager.GetAllStudents().ToList();
            lstSutdents.BindingContext = listStudents;
        }
        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void Listele_OnClick(object sender, EventArgs e)
        {
         Refresh();
        }

        private void Refresh()
        {
            var manager = new SqLiteManeger();
            var listStudents = new List<Student>();
            listStudents = manager.GetAllStudents().ToList();
            lstSutdents.BindingContext = listStudents;

        }

        private void Delete_OnClicked(object sender, EventArgs e)
        {
            var menuItemSelected = (MenuItem)sender;
            SqLiteManeger _maneger = new SqLiteManeger();
            var isDeleted = _maneger.Delete(Convert.ToInt32(menuItemSelected.CommandParameter.ToString()));
            if (isDeleted > 0)
            {
                DisplayAlert("Başarılı", "Silindi", "Tamam");
                Refresh();
            }
            else
            {
                DisplayAlert("Error", "Silinemedi", "Tamam");
            }
        }

        private void Detail_OnClicked(object sender, EventArgs e)
        {
            var _manager = new SqLiteManeger();
            var menuItemSelected = (MenuItem)sender;
            var selectedStudent = _manager.Get(Convert.ToInt32(menuItemSelected.CommandParameter.ToString()));
            Navigation.PushAsync(new DetailPage(selectedStudent));

        }

        private void Update_OnClicked(object sender, EventArgs e)
        {
            var _manager = new SqLiteManeger();
            var menuItemSelected = (MenuItem)sender;
            var selectedStudent = _manager.Get(Convert.ToInt32(menuItemSelected.CommandParameter.ToString()));
            Navigation.PushAsync(new UpdatePage(selectedStudent));
        }
    }
}
