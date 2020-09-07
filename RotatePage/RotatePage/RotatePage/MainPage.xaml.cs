using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RotatePage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DependencyService.Get<IRotate>().ForcePortrait();

            string json = @"{
  CPU: 'Intel',
  Drives: [
    'DVD read/writer',
    '500 gigabyte hard drive'
  ]
}";

            JObject o = JObject.Parse(json);

            string json1 = @"[
  'Small',
  'Medium',
  'Large'
]";

            JArray a = JArray.Parse(json1);
        }
    }
}
