using System.Collections.ObjectModel;

namespace Record_Book_MVVM.Models
{
    public class UserManager
    {
        // Hardcoded database
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() {
            new User { Email = "lilliasteo24@hotmail.com", Name = "Lillias Teodor"},
            new User { Email = "frihanna7@yahoo.com", Name = "Fritjof Hanna"},
            new User { Email = "Blnkhon5u@google.com", Name = "Bláthnaid Khonsu"},
            new User { Email = "gallegra0103@hotmail.com", Name = "Garen Allegra"},
            new User { Email = "lynne.antal.can@protonmail.com", Name = "Lynne Antal"}
        };

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }
    }
}
