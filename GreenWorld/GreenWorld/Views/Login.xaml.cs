using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StackLayout parentItem = button.Parent as StackLayout;
            Entry userNameEntry = parentItem.Children[1] as Entry;
            string userNameEntryValue = userNameEntry.Text;
            Entry userPasswordEntry = parentItem.Children[2] as Entry;
            string userPasswordEntryValue = userPasswordEntry.Text;

            if (userNameEntryValue == "McLovin")
            {
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Sorry!!", $"User {userNameEntryValue} Could Not Logged In at this time!!", "OK", "Whatever!!");
            }

           
        }
    }
}