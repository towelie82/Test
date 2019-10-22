﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Webkit;
using Android.Net.Http;

namespace WebViewDemo2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);
            RelativeLayout layout_main = new RelativeLayout(this);
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MatchParent, RelativeLayout.LayoutParams.MatchParent);
            layout_main.LayoutParameters = layoutParams;

            WebView webView = new WebView(this);
            webView.LayoutParameters = layoutParams;

            layout_main.AddView(webView);
            SetContentView(layout_main);
            LaunchBrowserView("https://www.google.com", webView);
        }

        public void LaunchBrowserView(string authorizationServerUrl, WebView webView)
        {
            try
            {
                webView.Settings.JavaScriptEnabled = true;
                webView.Settings.DomStorageEnabled = true;
                //web_view.Settings.= true;
                //web_view.Settings.AllowContentAccess = true;
                webView.SetWebViewClient(new MyBrowser());
                webView.Settings.LoadsImagesAutomatically = true;
                webView.LoadUrl(authorizationServerUrl);
            }
            catch (System.Exception ex)
            {
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
    class MyBrowser : WebViewClient
    {
        override public bool ShouldOverrideUrlLoading(Android.Webkit.WebView view, string url)
        {
            view.LoadUrl(url);
            return false;
        }

        public override void OnReceivedSslError(Android.Webkit.WebView view, SslErrorHandler handler, SslError error)
        {
            base.OnReceivedSslError(view, handler, error);
        }

    }
}