using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class LogoutPage1CS : ContentPage
    {
        private Button _button;
        public LogoutPage1CS()
        {
            Title = "Logout Page 1";
            _button = new Button
            {
                Text = "Go to LogoutPage2",

            };
            _button.Clicked += delegate
            {
                Navigation.PushAsync(new LogoutPage2CS());
            };
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="Logout page1 goes here",
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },
                    _button,

                }
            };
        }
    }
}
