using FreshMvvm;
using FreshMvvmDemo.PageModels;
using FreshMvvmDemo.ViewModels;
using System;
using Xamarin.Forms;

namespace FreshMvvmDemo
{
    public partial class App : Application
    {

        public class MyPageModelMapper : IFreshPageModelMapper
        {
            public string GetPageTypeName(Type pageModelType)
            {
                var mainpagemodel = typeof(MainPageModel);
                var s = Type.GetType(mainpagemodel.AssemblyQualifiedName);

                var mainviewmodel = typeof(MainViewModel);
                var s2 = Type.GetType(mainviewmodel.AssemblyQualifiedName);

                return pageModelType.AssemblyQualifiedName
                    .Replace("PageModel", "Page")
                 .Replace("ViewModel", "Page");
            }
        }

        public App()
        {
            InitializeComponent();

            // To set MainPage for the Application  
            FreshPageModelResolver.PageModelMapper = new MyPageModelMapper();
            var page = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
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
