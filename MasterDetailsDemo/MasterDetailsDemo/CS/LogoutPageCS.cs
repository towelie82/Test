using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class LogoutPageCS : ContentPage
    {
        public LogoutPageCS()
        {
            Title = "Logout";


            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="Logout goes here",
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },


                }
            };
        }
    }
}
