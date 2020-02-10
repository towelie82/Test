using System;
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
using Xamarin.Forms;

namespace App1.Droid
{
    public class DependencyImplementation : Activity, IDpendencyService
    {
        public Task<bool> Launch(string stringUri)
        {

            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage(stringUri);
            if (intent != null)
            {
                intent.AddFlags(ActivityFlags.NewTask);
                Forms.Context.StartActivity(intent);
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(true);
            }



        }
    }
}