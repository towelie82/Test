using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using System;
using Java.Lang;
using Android.Graphics;

namespace SplashScreenDemo
{
    [Activity(Label = "SplashScreenDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : Activity
    {
        ImageView imageView;
        Animation view_animation;
        TextView textview;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            RequestWindowFeature(Android.Views.WindowFeatures.NoTitle);
            SetContentView (Resource.Layout.SplashScreen);
            imageView = (ImageView)FindViewById(Resource.Id.imageView);
            
            view_animation = AnimationUtils.LoadAnimation(this,Resource.Animation.hyperspace_jump);
             
            imageView.StartAnimation(view_animation);
            view_animation.AnimationEnd += Rotate_AnimationEnd;
            
        }

        private void Rotate_AnimationEnd(object sender, Animation.AnimationEndEventArgs e)
        {
            Finish();
            StartActivity(typeof(MainActivity));
        }
    }

}

