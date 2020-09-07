using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RotatePage.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(RoateHandler))]
namespace RotatePage.Droid
{
    class RoateHandler : IRotate
    {
        public void ForcePortrait()
        {
            ((Activity)Forms.Context).RequestedOrientation = ScreenOrientation.Portrait;
        }
    }
}