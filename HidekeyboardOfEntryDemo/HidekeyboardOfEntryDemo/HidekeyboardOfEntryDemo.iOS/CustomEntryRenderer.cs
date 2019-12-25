using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using HidekeyboardOfEntryDemo;
using HidekeyboardOfEntryDemo.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace HidekeyboardOfEntryDemo.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        private UITextField textField;
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            textField = (UITextField)this.Control;
            textField.ReturnKeyType = UIReturnKeyType.Done;
        }
    }
}