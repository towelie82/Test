using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.V7.Widget;

namespace AndroidDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            StartActivity(typeof(casdView_Activity));
            //SetContentView(Resource.Layout.activity_main);


            //btnOrder = FindViewById<Button>(Resource.Id.btnOrder);

            //cardSugar = FindViewById<CardView>(Resource.Id.cardSugar);
            //cardSugar.Click += CardSugar_Click;

            //checkToppingSugar = FindViewById<CheckBox>(Resource.Id.checkToppingSugar);
            //checkFillingSugar = FindViewById<CheckBox>(Resource.Id.checkFillingSugar);
        }

        private void CardSugar_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}