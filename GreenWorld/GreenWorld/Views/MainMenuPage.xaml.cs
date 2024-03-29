﻿using System;
using GreenWorld.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
             

        }

        private async void MainPageLoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void MainPageProfileButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePageNew());
        }

        private async void MainPageRecordTasksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecordTasksPage());
        }

        private async void MainPageBrowseAsGuestButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void MainPageSignUpButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        private async void MainPageUserListButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientList());
        }
    }
}