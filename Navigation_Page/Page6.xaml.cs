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
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }

        private async void btnGoToPage2_Clicked(object sender, EventArgs e)
        {
            for (var i = 2; i < App.countPagesToRemove; i++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count-2]);
            }
            await Navigation.PopAsync();
        }
    }
}