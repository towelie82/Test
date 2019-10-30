using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo.CS
{
    class LoginPageCS : ContentPage
    {
        private Button _button;
        public LoginPageCS()
        {
            Title = "Login in";

            _button = new Button
            {
                Text = "Log in"
            };
            _button.Clicked += _button_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text="Login in Page goes here",
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },
                    _button
                }
            };

        }

        private void _button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPageCS();
        }
    }
}
