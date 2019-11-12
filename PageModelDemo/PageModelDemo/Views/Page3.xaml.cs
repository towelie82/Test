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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
         

            ViewModel viewModel = new ViewModel()
            {
                Name = "C",
                Address = "C-Address",
                Country = "C-Country"
            };

            this.BindingContext = viewModel;

        }
    }
}