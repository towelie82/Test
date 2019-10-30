using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class LogoutPage2CS : ContentPage
    {

        private Button _button;
        public LogoutPage2CS()
        {
            Title = "Logout Page 1";
            _button = new Button
            {
                Text = "Go back to root page",

            };
            _button.Clicked += delegate
            {
               
            };
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="Logout page2 goes here",
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },
                    _button,

                }
            };
        }
    }
}
