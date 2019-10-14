using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btn_TextLayout = FindViewById<Button>(Resource.Id.btn_TextLayout);
            btn_TextLayout.Click += Btn_TextLayout_Click;

            var btn_GralleryLayout = FindViewById<Button>(Resource.Id.btn_GralleryLayout);
            btn_GralleryLayout.Click += Btn_GralleryLayout_Click;
        }

        private void Btn_GralleryLayout_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(GralleryActivity));
            StartActivity(intent);
        }

        private void Btn_TextLayout_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(TextActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}