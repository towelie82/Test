using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
    [Activity(Label = "GralleryActivity")]
    public class GralleryActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.GralleryLayout);

            var ImageView = FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView.SetImageResource(Resource.Drawable.pig);
        }
    }
}