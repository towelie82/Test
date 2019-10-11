using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using WImageSource = Windows.UI.Xaml.Media.ImageSource;

using Xamarin.Forms;
using Windows.UI.Xaml.Media.Imaging;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App43.UWP
{
    public class MySlider : Windows.UI.Xaml.Controls.Slider
    {
        public MySlider()
        {
            this.DefaultStyleKey = typeof(MySlider);
        }
        internal Thumb Thumb { get; set; }
        internal Thumb ImageThumb { get; set; }

        public static readonly DependencyProperty ThumbImageSourceProperty =
            DependencyProperty.Register(nameof(ThumbImageSource), typeof(WImageSource),
            typeof(MySlider), new PropertyMetadata(null, PropertyChangedCallback));

        [Obsolete("ThumbImageProperty is obsolete as of 4.0.0. Please use ThumbImageSourceProperty instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly DependencyProperty ThumbImageProperty = ThumbImageSourceProperty;

        static void PropertyChangedCallback(DependencyObject dependencyObject,
            DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var slider = (MySlider)dependencyObject;
          //  SwapThumbs(slider);
        }

        static void SwapThumbs(MySlider slider)
        {
            if (slider.Thumb == null || slider.ImageThumb == null)
            {
                return;
            }

            if (slider.ThumbImageSource != null)
            {
                slider.Thumb.Visibility = Visibility.Collapsed;
                slider.ImageThumb.Visibility = Visibility.Visible;
            }
            else
            {
                slider.Thumb.Visibility = Visibility.Visible;
                slider.ImageThumb.Visibility = Visibility.Collapsed;
            }
        }

        public WImageSource ThumbImageSource
        {
            get { return (WImageSource)GetValue(ThumbImageSourceProperty); }
            set { SetValue(ThumbImageSourceProperty, value); }
        }

        [Obsolete("ThumbImage is obsolete as of 4.0.0. Please use ThumbImageSource instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public BitmapImage ThumbImage
        {
            get { return GetValue(ThumbImageSourceProperty) as BitmapImage; }
            set { SetValue(ThumbImageSourceProperty, value); }
        }

        internal event EventHandler Ready;

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Thumb = GetTemplateChild("HorizontalThumb") as Thumb;
           
            ImageThumb = GetTemplateChild("HorizontalImageThumb") as Thumb;

          //  SwapThumbs(this);

            OnReady();
        }

        protected virtual void OnReady()
        {
            Ready?.Invoke(this, EventArgs.Empty);
        }
    }
}
