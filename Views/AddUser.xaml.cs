using Record_Book_MVVM.ViewModel;
using System.Windows;

namespace Record_Book_MVVM.Views
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private static AddUser instance;

        public AddUser()
        {
            InitializeComponent();
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            this.DataContext = addUserViewModel;
        }

        // Get the singleton instance
        public static AddUser GetInstance()
        {
            if(instance == null)
            {
                instance = new AddUser();
                instance.Closed += (s, e) => instance = null; // Reset instance when window is closed
            }
            return instance;
        }
    }
}
