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
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        private async void btnGoToPage6_Clicked(object sender, EventArgs e)
        {
            App.countPagesToRemove++;
            await Navigation.PushAsync(new Page6());
        }
    }
}