using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo.Navigation_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private async void btnGoToPage3_Clicked(object sender, EventArgs e)
        {
            App.countPagesToRemove++;
            await Navigation.PushAsync(new Page3());
        }
    }
}