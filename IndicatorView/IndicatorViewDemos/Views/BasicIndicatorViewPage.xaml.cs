using IndicatorViewDemos.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IndicatorViewDemos.Views
{
    public partial class BasicIndicatorViewPage : ContentPage
    {
        public IList<Items> items { get; set; }
        public BasicIndicatorViewPage()
        {
            InitializeComponent();
            items = new List<Items>()
            {
                new Items(){ Title="A", Subtitle="S", ImageSource="pink.jpg"},
                new Items(){ Title="B", Subtitle="S", ImageSource="pink.jpg"},
                new Items(){ Title="C", Subtitle="S", ImageSource="pink.jpg"},
            };
            this.BindingContext = this;
        }
    }
}
