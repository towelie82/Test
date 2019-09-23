using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContentPresenterDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivatableContent : ContentPage
    {
        public ActivatableContent()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty IsReadonlyProperty = BindableProperty.Create(
        "IsReadonly",
        typeof(bool),
        typeof(ActivatableContent),
        true,
        BindingMode.TwoWay,
        propertyChanged: OnIsReadonlyChanged);

        public static readonly BindableProperty ReadonlyContentProperty = BindableProperty.Create(nameof(ReadonlyContent), typeof(View), typeof(ActivatableContent), propertyChanged: OnReadonlyContentChanged);

        public static readonly BindableProperty WritableContentProperty = BindableProperty.Create(nameof(WritableContent), typeof(View), typeof(ActivatableContent), propertyChanged: OnWritableContentChanged);

        public bool IsReadonly
        {
            get { return (bool)GetValue(IsReadonlyProperty); }
            set
            {
                SetValue(IsReadonlyProperty, value);
            }
        }

        public View ReadonlyContent
        {
            get { return (View)GetValue(ReadonlyContentProperty); }
            set { SetValue(ReadonlyContentProperty, value); }
        }

        public View WritableContent
        {
            get { return (View)GetValue(WritableContentProperty); }
            set { SetValue(WritableContentProperty, value); }
        }

        private static void OnIsReadonlyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            ((ActivatableContent)bindable).IsReadonly = (bool)newvalue;
        }

        private static void OnReadonlyContentChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var readonlyContent = (View)newvalue;
            ((ActivatableContent)bindable).ReadonlyContent = readonlyContent;
            SetInheritedBindingContext(readonlyContent, bindable.BindingContext);
        }

        private static void OnWritableContentChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var writableContent = (View)newvalue;
            ((ActivatableContent)bindable).WritableContent = writableContent;
            SetInheritedBindingContext(writableContent, bindable.BindingContext);
        }

        private void OnToggleIsReadonly(object sender, EventArgs e)
        {
            IsReadonly = !IsReadonly;
        }

        /// <summary>Method that is called when the binding context changes.</summary>
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var controlTemplate = ControlTemplate;
            if (ReadonlyContent != null && controlTemplate != null)
            {
                SetInheritedBindingContext(ReadonlyContent, BindingContext);
            }

            if (WritableContent != null && controlTemplate != null)
            {
                SetInheritedBindingContext(WritableContent, BindingContext);
            }
        }
    }

}