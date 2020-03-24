using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo.Navigation_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }
        private async void btnGoToPage2_Clicked(object sender, EventArgs e)
        {
            App.countPagesToRemove++;
            await Navigation.PushAsync(new Page2());
        }
    }
}