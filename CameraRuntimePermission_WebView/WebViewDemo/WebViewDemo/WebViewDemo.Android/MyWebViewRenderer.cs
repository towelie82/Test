﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Annotation;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Plugin.Permissions.Abstractions;
using WebViewDemo;
using WebViewDemo.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Renderscripts.Sampler;

[assembly: ExportRenderer(typeof(MyWebView), typeof(MyWebViewRenderer))]
namespace WebViewDemo.Droid
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        Activity mContext;
        public MyWebViewRenderer(Context context) : base(context)
        {
            this.mContext = context as Activity;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);
            Control.Settings.JavaScriptEnabled = true;
            Control.ClearCache(true);
            Control.SetWebChromeClient(new MyWebClient(mContext));
        }
        public class MyWebClient : WebChromeClient
        {
            Activity mContext;
            public MyWebClient(Activity context)
            {
                this.mContext = context;
            }
            [TargetApi(Value = 21)]
            public override void OnPermissionRequest(PermissionRequest request)
            {
                mContext.RunOnUiThread(() =>
                {
                    request.Grant(request.GetResources());

                });
               
            }
        }

    }
}