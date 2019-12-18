using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewDashedLinesDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public Page1()
        {
            InitializeComponent();


        //    Items = new ObservableCollection<string>
        //{
        //    "Item 1",
        //    "Item 2",
        //    "Item 3",
        //    "Item 4",
        //    "Item 5"
        //};

        //    BindingContext = this;
        }
    }
}