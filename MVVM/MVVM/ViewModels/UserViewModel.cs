using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;

namespace MVVM.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public ObservableCollection<User> pUsers { get; set; }


        public UserViewModel()
        {
            pUsers = new ObservableCollection<User>();
        }


        public void createUser(string aFisrtName, string aLastName, string aEmail)
        {
            User wUser = new User(aFisrtName, aLastName, aEmail);

            pUsers.Add(wUser);
        }

    }
}
