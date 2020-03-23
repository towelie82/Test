using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo.PassingData_Navigating.Test
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public string mainpagevalue;
        int offlinecount = 0;
        int onlinecount = 0;
        public static TimeStamp timeStamp = new TimeStamp();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnOnline_Clicked(object sender, EventArgs e)
        {
            onlinecount++;

            if (onlinecount == 1)
            {
                string currentDT = DateTime.Now.ToString();
                lblOnlineStartDT.Text = currentDT;
                timeStamp.StartTime = currentDT;
            }

            await Navigation.PushAsync(new OnlinePage());
        }

        private void btnOffline_Clicked(object sender, EventArgs e)
        {
            offlinecount++;
            //Navigation.PushAsync(new SecondPage(this, lblEndDT));
            Navigation.PushAsync(new OfflinePage(this, lblEndDT, btnOnline));
            if (offlinecount == 1)
            {
                string currentDT = DateTime.Now.ToString();
                lblStartDT.Text = currentDT;
            }
        }
    }
}