using Record_Book_MVVM.Commands;
using Record_Book_MVVM.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Record_Book_MVVM.ViewModel
{
    public class AddUserViewModel : INotifyPropertyChanged
    {
        public ICommand AddUserCommand { get; set; }
        public string? addName;
        public string? addEmail;

        public string AddName
        {
            get => addName;
            set
            {
                addName = value;
                OnPropertyChanged(nameof(AddName));
            }
        }

        public string AddEmail
        {
            get => addEmail;
            set
            {
                addEmail = value;
                OnPropertyChanged(nameof(AddEmail));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            CommandManager.InvalidateRequerySuggested();
        }

        public AddUserViewModel()
        {
            AddUserCommand = new RelayCommand(AddUser, CanAddUser);
        }

        private bool CanAddUser(object obj)
        {
            return true;

        }

        private void AddUser(object obj)
        {
            if(!string.IsNullOrWhiteSpace(AddName) && !AddName.Any(char.IsDigit) &&
                   !string.IsNullOrWhiteSpace(AddEmail) && AddEmail.Contains("@") && AddEmail.EndsWith(".com"))
            {
                UserManager.AddUser(new User() { Name = AddName, Email = AddEmail });
                MessageBox.Show("User added.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("TextBox contains invalid elements.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }


    }
}