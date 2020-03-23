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
    public partial class OnlinePage : ContentPage
    {
       
        public OnlinePage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {            
           
            Navigation.PushAsync(new ThirdPage());
        }
    }
}