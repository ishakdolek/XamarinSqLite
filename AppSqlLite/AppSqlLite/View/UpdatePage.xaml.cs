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
    public partial class UpdatePage : ContentPage
    {
        private readonly int Id;
        public UpdatePage(Student student)
        {
            InitializeComponent();
            txtName.Text = student.Name;
            txtSurname.Text = student.Surname;
            Id = student.Id;
        }

        private void Update_OnClicked(object sender, EventArgs e)
        {
            var _manager = new SqLiteManeger();
            var s = new Student();

            s.Id = Id;
            s.RegisteDate=DateTime.Now;
            s.Name = txtName.Text;
            s.Surname = txtSurname.Text;
            var isUpdate = _manager.Update(s);
            if (isUpdate != 0)
            {
                DisplayAlert("Başarılı", s.Name + " " + s.Surname + "Güncellendi", "OK");
                }
            else
            {
                DisplayAlert("Error", "Hata Oluştu", "OK");
            }

        }
    }
}
