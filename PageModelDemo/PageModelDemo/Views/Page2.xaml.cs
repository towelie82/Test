using PageModelDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageModelDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
      
        public Page2()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel()
            {
                Name = "B",
                Address = "B-Address",
                Country = "B-Country"
            };

            this.BindingContext = viewModel;
        }
    }
}