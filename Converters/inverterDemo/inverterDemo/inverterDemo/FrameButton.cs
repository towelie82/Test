using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace inverterDemo
{
    public class FrameButton : Frame
    {
        public string IsBusy { get; set; }
        public FrameButton()
        {
            var MyTapGesture = new TapGestureRecognizer();
            MyTapGesture.Tapped += (sender, e) => { Clicked(); };
            GestureRecognizers.Add(MyTapGesture);
        }

        public async void Clicked()
        {
            await this.ScaleTo(1.1, 100);
            await this.ScaleTo(1, 100);
            Console.WriteLine(this.IsEnabled);
        }
    }
}
