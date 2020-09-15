﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SplashScreen.Droid
{
    [Activity(Label = "Splash_Activity", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class Splash_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }
        async void SimulateStartup()
        {
           
            await Task.Delay(3000); // Simulate a bit of startup work.
          
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}