using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();

            
        }

        private async void SignUpButton_OnClicked(object sender, EventArgs e)
        {

            Button button = sender as Button;
            StackLayout stackLayout = button.Parent as StackLayout;
            Entry emailEntry = stackLayout.Children[1] as Entry;
            Entry passwordEntry = stackLayout.Children[2] as Entry;
            Entry passwordVerificationEntry = stackLayout.Children[3] as Entry;


            if (!((passwordEntry.Text) == passwordVerificationEntry.Text))
            {
                await DisplayAlert("Attention!", "Password not matching!!, please verify", "Ok");
            }

            
            else
            {
                await DisplayAlert(null, "Added", "Ok");
            }

        }
    }
}