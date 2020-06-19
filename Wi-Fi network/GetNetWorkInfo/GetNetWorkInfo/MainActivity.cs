using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using System.Collections;
using Android.Support.Design.Widget;
using Android.Util;
using Android.Content.PM;
using Android.Net.Wifi;
using Android.Support.V4.App;
using System;
using Android;

namespace GetNetWorkInfo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public string TAG
        {
            get
            {
                return "123456";
            }
        }
        // static readonly int REQUEST_PHONE_STATE = 1;


        static readonly int REQUEST_LOCATION = 2;

        /**
     	* Root of the layout of this Activity.
     	*/
        View layout;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            layout = FindViewById(Resource.Id.sample_main_layout);

            checkPermission();
        }
        public void checkPermission()
        {
            Log.Info(TAG, "Checking permission.");

            // Check if the  permission is already available.
            if (ActivityCompat.CheckSelfPermission(this, Manifest.Permission.AccessCoarseLocation) != (int)Permission.Granted)
            {

                //  permission has not been granted
                RequestPermission();
            }
            else
            {
                //  permissions is already available
                Log.Info(TAG, " permission has already been granted.");

                getWifiList();
            }
        }

        private void RequestPermission()
        {
            Log.Info(TAG, " permission has NOT been granted. Requesting permission.");

            if (ActivityCompat.ShouldShowRequestPermissionRationale(this, Manifest.Permission.AccessCoarseLocation))
            {

                Snackbar.Make(layout, Resource.String.permission_accesscoarselocation_rationale,
                    Snackbar.LengthIndefinite).SetAction(Resource.String.ok, new Action<View>(delegate (View obj) {
                        ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.AccessCoarseLocation }, REQUEST_LOCATION);
                    })).Show();
            }
            else
            {
                // AccessCoarseLocation permission has not been granted yet. Request it directly.
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.AccessCoarseLocation }, REQUEST_LOCATION);
            }
        }


        void getWifiList()
        {

            IList myListrow = new ArrayList();

            var wifiMgr = (WifiManager)GetSystemService(WifiService);
            var wifiList = wifiMgr.ScanResults;

            foreach (var item in wifiList)
            {
                var wifiLevel = WifiManager.CalculateSignalLevel(item.Level, 100);
                myListrow.Add(($"Wifi Name: {item.Ssid} - Single: {wifiLevel}"));

            }

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            if (requestCode == REQUEST_LOCATION)
            {
                // Received permission result for AccessCoarseLocation permission.
                Log.Info(TAG, "Received response for phone state permission request.");

                // Check if the only required permission has been granted
                if (grantResults.Length == 1 && grantResults[0] == Permission.Granted)
                {
                    // AccessCoarseLocation permission has been granted, preview can be displayed
                    Log.Info(TAG, "phonestate permission has now been granted. Showing preview.");
                    Snackbar.Make(layout, Resource.String.permission_available_accesscoarselocation, Snackbar.LengthShort).Show();

                    getWifiList();

                }
                else
                {
                    Log.Info(TAG, "AccessCoarseLocation permission was NOT granted.");
                    Snackbar.Make(layout, Resource.String.permissions_not_granted, Snackbar.LengthShort).Show();
                }
            }
            else
            {
                base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            }
        }
    }
}