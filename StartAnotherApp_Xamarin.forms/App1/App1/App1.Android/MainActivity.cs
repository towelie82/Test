using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Xamarin.Forms;
using App1;

[assembly: Dependency(typeof(IDpendencyService))]
namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class Activity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public Intent intent;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            DependencyService.Register<IDpendencyService, DependencyImplementation>();
            
            //SetContentView(Resource.Layout.layout1);

            //var textview1 = FindViewById<TextView>(Resource.Id.textView1);
            //textview1.Text = "App1";

            //var button1 = FindViewById<Button>(Resource.Id.button1);
            //button1.Click += delegate
            //{
            //    Intent intent = PackageManager.GetLaunchIntentForPackage("com.companyname.app2");
            //    StartActivity(intent);
            //};
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}