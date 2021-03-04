using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Traffic_light
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void red_Clicked(object sender, EventArgs e)
        {
            Main.BackgroundColor = Color.Red;
        }

        private void yellow_Clicked(object sender, EventArgs e)
        {
            Main.BackgroundColor = Color.Yellow;
        }

        private void green_Clicked(object sender, EventArgs e)
        {
            Main.BackgroundColor = Color.Green;
        }
    }
}
