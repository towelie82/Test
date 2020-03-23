using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo.PassingData_Navigating.Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
        private async void BtnDone_Clicked(object sender, EventArgs e)
        {
            MainPage.timeStamp.EndTime = DateTime.Now.ToString();
            MainPage mainPage = new MainPage();
            mainPage.BindingContext = MainPage.timeStamp;
            await Navigation.PushAsync(mainPage);
        }
    }
}