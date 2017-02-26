using AppSqlLite.Models;
using Xamarin.Forms;

namespace AppSqlLite.View
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Student student)
        {
            InitializeComponent();
            lblName.Text = student.Name;
            lblSurname.Text = student.Surname;
        }
    }
}
