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
    public partial class ProfilePage : ContentPage
    {
        ProfilerViewModel viewModel ;
        int index;
        Profiler profiler = new Profiler();
        List<ProfilerViewModel> profilerViewModels = new List<ProfilerViewModel>();
        public ProfilePage(int index)
        {
            InitializeComponent();
            this.index = index;
            profilerViewModels = profiler.profilerViewModels;
            this.viewModel = profilerViewModels[index];
            BindingContext = viewModel;           
        }

        private void BtnBack_Clicked(object sender, EventArgs e)
        {
            if (index > 0 && index <= 3)
            {
                var data = profilerViewModels[index - 1];
                viewModel.Name = data.Name;
                viewModel.Detail1 = data.Detail1;
                viewModel.Detail2 = data.Detail2;
                viewModel.Detail3 = data.Detail3;
                viewModel.Detail4 = data.Detail4;
                index--;
            }
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            if (index >= 0 && index < 3)
            {
                var data = profilerViewModels[index + 1];
                viewModel.Name = data.Name;
                viewModel.Detail1 = data.Detail1;
                viewModel.Detail2 = data.Detail2;
                viewModel.Detail3 = data.Detail3;
                viewModel.Detail4 = data.Detail4;
                index++;
            }
        }




    }
}