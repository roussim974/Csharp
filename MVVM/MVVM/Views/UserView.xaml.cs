using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour UserView.xaml
    /// </summary>
    public partial class UserView : Page
    {

        public UserViewModel _userViewModel { get; set; }
        public UserView()
        {
            InitializeComponent();

            _userViewModel = new UserViewModel();

            this.DataContext = _userViewModel;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _userViewModel.createUser(txBoxFirstName.Text , txBoxLastName.Text , txBoxEmail.Text);
        }
    }
}
