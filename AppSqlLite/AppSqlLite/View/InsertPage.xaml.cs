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
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private void Insert_OnClicked(object sender, EventArgs e)
        {
             var _maneger= new SqLiteManeger();
             var _student= new Student();
            _student.Name = txtName.Text;
            _student.Surname = txtSurname.Text;
            var isInserted= _maneger.Insert(_student);
            if (isInserted>0)
            {
                DisplayAlert("Ekle", "Başarı İle Eklendi", "TAMAM");
            }
            else
            {
                DisplayAlert("Error", "Başarı İle Eklendi", "TAMAM");
            }

        }
    }
}
