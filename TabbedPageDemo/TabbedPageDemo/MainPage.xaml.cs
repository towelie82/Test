using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabbedPageDemo.Views;
using Xamarin.Forms;

namespace TabbedPageDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_imgAdd_Clicked(object sender, EventArgs e)
        {
            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new Page1());
            tabbedPage.Children.Add(new Page2());

            App.Current.MainPage = tabbedPage;
        }
    }
}
