using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenWorld.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        private string _dBPath =
            Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
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

            var db = new SQLiteConnection(_dBPath);
            db.CreateTable<User>();
            //var maxPk = db.Table<User>().OrderBy(c => c.Id).FirstOrDefault();

            //User user = new User();

            //if ((emailEntry.Text == " ") || (passwordEntry.Text == " ") || (passwordVerificationEntry.Text == " "))
            //{


            //   await DisplayAlert("Wrong Entry", "Entries Missing", "Ok");
            //}

            //else
            //{
            //    user.Id = (maxPk == null ? 1 : maxPk.Id + 1);
            //    user.EmailAddress = emailEntry.Text;
            //    user.Password = passwordEntry.Text;
            //}


            //db.Insert(user);
            //await DisplayAlert(null, "User: " + user.EmailAddress + "added.", "Ok");

        }
    }
}