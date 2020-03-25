using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Behavior.ViewModels;

namespace XamarinDemo.Behavior
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MaskedEntry : ContentPage
    {

        public MaskedEntry()
        {
            InitializeComponent();
            this.BindingContext = new MaskedEntryViewModel();
        }

     
    }

}