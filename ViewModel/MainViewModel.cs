﻿using Record_Book_MVVM.Commands;
using Record_Book_MVVM.Models;
using Record_Book_MVVM.Views;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Record_Book_MVVM.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Users = UserManager.GetUsers();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            var mainWindow = obj as Window;

            AddUser addUserWindow = AddUser.GetInstance();
            addUserWindow.Owner = mainWindow;
            addUserWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            if(!addUserWindow.IsVisible)
            {
                addUserWindow.Show();
            }
            else
            {
                addUserWindow.Activate();
            }
        }
    }
}
