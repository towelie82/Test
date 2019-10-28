using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace AndroidDemo
{
    [Activity(Label = "casdView_Activity")]
    public class casdView_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cardView_layout);


            // Create your application here            
            #region
            var imageView = FindViewById<ImageView>(Resource.Id.imageView);
            imageView.SetImageResource(Resource.Drawable.pig);

            var textView = FindViewById<TextView>(Resource.Id.textView);

            var checkToppingSugar = FindViewById<CheckBox>(Resource.Id.checkToppingSugar);
            checkToppingSugar.Click += (o, e) =>
            {
                if (checkToppingSugar.Checked)
                {
                    Toast.MakeText(this, "Selected", ToastLength.Short).Show();
                    textView.Text = "textView Topping Selected";
                }
                else
                {
                    Toast.MakeText(this, "Not selected", ToastLength.Short).Show();
                    textView.Text = "textView Topping Not selected";
                }

            };

            var checkFillingSugar = FindViewById<CheckBox>(Resource.Id.checkFillingSugar);
            checkFillingSugar.Click += (o, e) =>
            {
                if (checkFillingSugar.Checked)
                {
                    Toast.MakeText(this, "Selected", ToastLength.Short).Show();
                    textView.Text = "textView Filling Selected";
                }
                else
                {
                    Toast.MakeText(this, "Not selected", ToastLength.Short).Show();
                    textView.Text = "textView Filling Not selected";
                }

            };
            #endregion


            #region
            var imageView2 = FindViewById<ImageView>(Resource.Id.imageView2);
            imageView2.SetImageResource(Resource.Drawable.pig);

            var textView2 = FindViewById<TextView>(Resource.Id.textView2);

            var checkToppingLemonJuice = FindViewById<CheckBox>(Resource.Id.checkToppingLemonJuice);
            checkToppingLemonJuice.Click += (o, e) =>
            {
                if (checkToppingLemonJuice.Checked)
                {
                    Toast.MakeText(this, "Selected", ToastLength.Short).Show();
                    textView2.Text = "textView Topping Selected";
                }

                else
                {
                    Toast.MakeText(this, "Not selected", ToastLength.Short).Show();
                    textView2.Text = "textView Topping Not selected";
                }
            };

            var checkFillingLemonJuice = FindViewById<CheckBox>(Resource.Id.checkFillingLemonJuice);
            checkFillingLemonJuice.Click += (o, e) =>
            {
                if (checkFillingLemonJuice.Checked)
                {
                    Toast.MakeText(this, "Selected", ToastLength.Short).Show();
                    textView2.Text = "textView Filling Selected";
                }
                else
                {
                    Toast.MakeText(this, "Not selected", ToastLength.Short).Show();
                    textView2.Text = "textView Filling Not selected";
                }
            };
            #endregion


          

            var btnOrder = FindViewById<Button>(Resource.Id.btnOrder);
            btnOrder.Click += delegate
            {

                ////get text of all cardview
                var linearLayout = FindViewById<LinearLayout>(Resource.Id.linearlayout_view);
                for (int i = 0; i < linearLayout.ChildCount; i++)
                {
                    View child = linearLayout.GetChildAt(i);
                    if (child.GetType() == typeof(CardView))
                    {
                        var viewGroup = ((ViewGroup)child).GetChildAt(0);

                        for (int j = 0; j < ((ViewGroup)viewGroup).ChildCount; j++)
                        {
                            var viewGroup2 = ((ViewGroup)viewGroup).GetChildAt(j);
                            if (viewGroup2.GetType() == typeof(TextView))
                            {
                                System.Diagnostics.Debug.WriteLine(viewGroup2.GetType().ToString() + ": " + ((TextView)viewGroup2).Text);
                            }
                        }
                    }

                }
                //var str = textView.Text;               

                for (int i = 0; i < linearLayout.ChildCount; i++)
                {
                    View child = linearLayout.GetChildAt(i);
                    if (child.GetType() == typeof(CardView))
                    {
                        var viewGroup = ((ViewGroup)child).GetChildAt(0);

                        for (int j = 0; j < ((ViewGroup)viewGroup).ChildCount; j++)
                        {
                            var viewGroup2 = ((ViewGroup)viewGroup).GetChildAt(j);
                            if (viewGroup2.GetType() == typeof(CheckBox))
                            {
                                if (((CheckBox)viewGroup2).Checked)
                                {
                                    System.Diagnostics.Debug.WriteLine(((CardView)child));
                                }                               
                            }
                        }
                    }

                }
            };


        }
    }
}