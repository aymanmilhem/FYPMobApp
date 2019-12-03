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
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<User> _userList;
        //public IList<User> Users { get; private set; }
        public ClientList()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDB>().GetConnection();

            //Users = new List<User>();
            //Users.Add(new User
            //{
            //    EmailAddress = "ayman@ccp.ac.nz",
            //    FirstName = "Ayman",
            //    LastName = "Milhem"
            //});

            //Users.Add(new User
            //{
            //    EmailAddress = "amr@cpp.ac.nz",
            //    FirstName = "Amr",
            //    LastName = "Adel"
            //});

            _connection.CreateTableAsync<User>();

            var users = _connection.Table<User>().ToListAsync();
            _userList = new ObservableCollection<User>(users);

            clientListView.ItemsSource = _userList;

            var user = new User
            {
                FirstName = "Ahmad",
                LastName = "Saadat",
                EmailAddress = "sillyIdiot"
            };

            _userList.Add(user);

            BindingContext = this;

        }

        //protected override async void OnAppearing()
        //{
        //    await _connection.CreateTableAsync<User>();

        //    var users = await _connection.Table<User>().ToListAsync();
        //    _userList = new ObservableCollection<User>(users);

        //    clientListView.ItemsSource = _userList;

        //    base.OnAppearing();
        //}

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