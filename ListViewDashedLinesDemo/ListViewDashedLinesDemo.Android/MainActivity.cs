using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListViewDashedLinesDemo.Droid
{
    [Activity(Label = "ListViewDashedLinesDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

       


        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);



            //SetContentView(Resource.Layout.layout1);
            //ListView listView = FindViewById<ListView>(Resource.Id.listview);
            //string[] s = new string[] { "1", "2", "3" };
            //ArrayAdapter<string> arrayAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, s);
            //listView.Adapter = arrayAdapter;



            //TextView text = FindViewById<TextView>(Resource.Id.text);
            //text.Text = "Dotted line for text view";
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}