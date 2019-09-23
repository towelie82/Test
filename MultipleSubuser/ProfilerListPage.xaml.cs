using CaseDemo.MultipleSubuser.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CaseDemo.MultipleSubuser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilerListPage : ContentPage
    {
        List<ProfilerViewModel> profilerViewModels; 
        public ProfilerListPage()
        {
            InitializeComponent();
            profilerViewModels = new List<ProfilerViewModel>();
            Profiler profiler = new Profiler();
            profilerViewModels = profiler.profilerViewModels;
            lstView.ItemsSource = profilerViewModels;
        }

        private void LstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ProfilerViewModel;
            var index = e.SelectedItemIndex;
            Navigation.PushAsync(new ProfilePage(index));
        }
    }
}