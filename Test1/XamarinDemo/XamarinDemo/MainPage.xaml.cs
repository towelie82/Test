using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDemo.MenuItems;
using XamarinDemo.Views;

namespace XamarinDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menuList
        {
            get;
            set;
        }
        public MainPage()
        {
            InitializeComponent();
            menuList = new List<MasterPageItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MasterPageItem()
            {
                Title = "Home",
                Icon = "home.png",
                TargetType = typeof(HomePage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Setting",
                Icon = "setting.png",
                TargetType = typeof(SettingPage)
            });
            menuList.Add(new MasterPageItem()
            {
                Title = "Help",
                Icon = "help.png",
                TargetType = typeof(HelpPage)
            });

            menuList.Add(new MasterPageItem()
            {
                Title = "LogOut",
                Icon = "logout.png",
                TargetType = typeof(LogoutPage)
            });
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));

        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
