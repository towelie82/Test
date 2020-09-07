using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using RotatePage.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(RoateImplementation))]
namespace RotatePage.iOS
{
    class RoateImplementation : IRotate
    {
        public void ForcePortrait()
        {
            UIDevice.CurrentDevice.SetValueForKey(new NSNumber((int)UIInterfaceOrientation.Portrait), new NSString("orientation"));
        }
    }
}