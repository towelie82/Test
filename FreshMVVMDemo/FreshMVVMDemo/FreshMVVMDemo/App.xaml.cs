using FreshMvvm;
using FreshMVVMDemo.PageModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMVVMDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // To set MainPage for the Application  
            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
