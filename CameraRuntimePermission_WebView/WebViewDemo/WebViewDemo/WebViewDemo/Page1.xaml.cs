using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void _button_Clicked(object sender, EventArgs e)
        {
            webView.Source = "https://test.webrtc.org/";//"https://xamarin.swappsdev.net/";
        }
    }
}