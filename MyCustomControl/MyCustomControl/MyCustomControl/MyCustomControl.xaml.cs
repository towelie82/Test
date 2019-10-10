using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCustomControl.MyCustomControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomControl : ContentView
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged();
            }
        }
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
                 nameof(Text),
                 typeof(string),
                 typeof(MyCustomControl),
                 string.Empty,
                 propertyChanged: (bindable, oldValue, newValue) =>
                 {
                     var control = bindable as MyCustomControl;
                     //var changingFrom = oldValue as string;
                     //var changingTo = newValue as string;
                     control.Title.Text = newValue.ToString();
                 });
        #region
        //public string TitleText { get; set; }

        //private static BindableProperty titleTextProperty = BindableProperty.Create(
        //                                                 propertyName: "TitleText",
        //                                                 returnType: typeof(string),
        //                                                 declaringType: typeof(MyCustomControl),
        //                                                 defaultValue: "",
        //                                                 defaultBindingMode: BindingMode.TwoWay,
        //                                                 propertyChanged: titleTextPropertyChanged);


        //private static void titleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var control = (MyCustomControl)bindable;
        //    control.Title.Text = newValue.ToString();
        //}
        #endregion
        public MyCustomControl()
        {
            InitializeComponent();
        }
    }
}