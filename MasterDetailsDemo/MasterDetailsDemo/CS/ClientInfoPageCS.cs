using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class ClientInfoPageCS : ContentPage
    {
        public ClientInfoPageCS()
        {
            Title = "Client Information";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="Client Information goes here",
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
