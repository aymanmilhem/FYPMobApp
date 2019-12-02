using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenWorld.Persistence;
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

            var connection = DependencyService.Get<ISQLiteDB>().GetConnection();
            connection.CreateTableAsync<User>();

            connection.Table<User>().ToListAsync();

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