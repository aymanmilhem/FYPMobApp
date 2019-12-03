using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenWorld.Persistence;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientList : ContentPage
    {
        public IList<User> Users { get; private set; }
        public ClientList()
        {
            InitializeComponent();

            Users = new List<User>();

            Users.Add(new User
            {
                FirstName = "Ayman",
                LastName = "Milhem",
                EmailAddress = "ayman@milhem.com"
            });

            Users.Add(new User
            {
                FirstName = "Amr",
                LastName = "Adel",
                EmailAddress = "amr@whitecliffe.com"
            });

            Users.Add(new User
            {
                FirstName = "Monique",
                LastName = "Warrington",
                EmailAddress = "monique@whitecliffe.com"
            });
            BindingContext = this;
        }

        

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            User selectedItem = e.SelectedItem as User;
        }

        private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            User tappedItem = e.Item as User;
        }

        private void OnProfileButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfilePageNew());
        }

        private void OnBottomBarListButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void OnBottomBarRecordTaskButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecordTasksPage());
        }
    }
}