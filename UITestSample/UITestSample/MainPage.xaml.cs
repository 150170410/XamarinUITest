using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UITestSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnHello.Clicked += BtnHello_Clicked;
        }

        private void BtnHello_Clicked(object sender, EventArgs e)
        {
            lblHello.Text = "HelloMoto";
        }
    }
}
