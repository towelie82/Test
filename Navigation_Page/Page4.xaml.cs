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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private async void btnGoToPage5_Clicked(object sender, EventArgs e)
        {
            App.countPagesToRemove++;
            await Navigation.PushAsync(new Page5());
        }
    }
}