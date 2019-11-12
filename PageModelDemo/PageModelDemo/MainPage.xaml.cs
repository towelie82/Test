using PageModelDemo.ViewModels;
using PageModelDemo.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageModelDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_Page1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());

        }
        private async void btn_Page2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void btn_Page3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
