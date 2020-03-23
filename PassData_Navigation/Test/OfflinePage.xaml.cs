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
    public partial class OfflinePage : ContentPage
    {
        Label offlineEndDT;
        MainPage mainpage;
        ImageButton btnonline;
        public OfflinePage()
        {
            InitializeComponent();
        }
        public OfflinePage(MainPage mpage, Label endDT, ImageButton onlineimage)
        {
            InitializeComponent();
            mainpage = mpage;
            offlineEndDT = endDT;
            btnonline = onlineimage;

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.offlineDonecount++;

            if (App.offlineDonecount == 1)
            {
                string edt = DateTime.Now.ToString();
                offlineEndDT.Text = edt;
                mainpage.mainpagevalue = offlineEndDT.Text;
            }

            btnonline.Source = "onlinetool";
            btnonline.IsEnabled = true;

            Navigation.PopAsync();


        }
    }
}