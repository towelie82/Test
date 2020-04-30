using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.ViewModel;

namespace XF_Login.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomPage : ContentPage
	{
        WelcomePageVM welcomePageVM;
		public WelcomPage (string email)
		{
			InitializeComponent ();
            welcomePageVM = new WelcomePageVM(email);
            BindingContext = welcomePageVM;
		}
	}
}