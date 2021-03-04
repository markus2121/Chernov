using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Student
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            count++;
            res.Text = "Студентов: " + count.ToString();
        }

        private void Del_Clicked(object sender, EventArgs e)
        {
            count--;
            res.Text = "Студентов: " + count.ToString();
        }
    }
}
