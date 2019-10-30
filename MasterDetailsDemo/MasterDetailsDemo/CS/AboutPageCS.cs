using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class AboutPageCS:ContentPage
    {
        public AboutPageCS()
        {
            Title = "About";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="About Page goes here",
                        HorizontalOptions=LayoutOptions.Center,
                       VerticalOptions=LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
