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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel()
            {
                Name = "A",
                Address = "A-Address",
                Country = "A-Country"
            };

            this.BindingContext = viewModel;
        }
    }
}