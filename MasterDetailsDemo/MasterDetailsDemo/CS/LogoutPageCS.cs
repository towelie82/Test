using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class LogoutPageCS : ContentPage
    {
        private Button _button;
        public LogoutPageCS()
        {
            Title = "Logout";

            _button = new Button
            {
                Text = "Go to LogoutPage1",

            };
            _button.Clicked += delegate
           {
               Navigation.PushAsync(new LogoutPage1CS());
           };
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
                    _button,

                }
            };
        }
    }
}
