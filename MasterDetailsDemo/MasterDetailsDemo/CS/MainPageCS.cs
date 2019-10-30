using MasterDetailsDemo.CS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterDetailsDemo
{
    public class MainPageCS : MasterDetailPage
    {
        MasterPageCS masterPage;

        public MainPageCS()
        {
            masterPage = new MasterPageCS();
            Master = masterPage;
            Detail = new NavigationPage(new ClientInfoPageCS());

            masterPage.ListView.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
