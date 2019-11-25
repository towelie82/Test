using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirebase.Helper;

namespace XamarinFirebase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage2 : ContentPage
    {
        FirebaseHelper2 firebaseHelper2 = new FirebaseHelper2();
        public MainPage2()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper2.GetAllCharacters();
            lstPersons.ItemsSource = allPersons;
        }

        private async void BtnAdd_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper2.AddCharacter(txtName.Text, txtEmail.Text, txtLastName.Text);
            txtEmail.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtName.Text = string.Empty;
            await DisplayAlert("Success", "Person Added Successfully", "OK");
            var allPersons = await firebaseHelper2.GetAllCharacters();
            lstPersons.ItemsSource = allPersons;
        }

        private async void BtnRetrive_Clicked(object sender, EventArgs e)
        {
            var character = await firebaseHelper2.GetEmail(txtEmail.Text);
            if (character != null)
            {
                txtEmail.Text = character.Email;
                txtName.Text = character.Name;
                txtLastName.Text = character.LastName;
                await DisplayAlert("Success", "character Retrive Successfully", "OK");

            }
            else
            {
                await DisplayAlert("Success", "No character Available", "OK");
            }

        }

        private async void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper2.UpdatePerson(txtEmail.Text, txtName.Text, txtLastName.Text);
            txtEmail.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtName.Text = string.Empty;
            await DisplayAlert("Success", "Person Updated Successfully", "OK");
            var allPersons = await firebaseHelper2.GetAllCharacters();
            lstPersons.ItemsSource = allPersons;
        }

        private async void BtnDelete_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper2.DeletePerson(txtEmail.Text);
            await DisplayAlert("Success", "Person Deleted Successfully", "OK");
            var allPersons = await firebaseHelper2.GetAllCharacters();
            lstPersons.ItemsSource = allPersons;
        }

        private async void btnQuery_Clicked(object sender, EventArgs e)
        {
            var character = await firebaseHelper2.GetEmail2(txtEmail.Text);
            if (character != null)
            {
                txtEmail.Text = character.Email;
                txtName.Text = character.Name;
                txtLastName.Text = character.LastName;

            }
        }
    }
}