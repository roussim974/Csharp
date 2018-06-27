using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Models
{
    public class User
    {
        public string pFirstName { get; set; }

        public string pLastName { get; set; }

        public string pEmail { get; set; }

       
        public User() {}

        public User(string aFirstName, string aLastName, string aEmail)
        {
            pFirstName = aFirstName;
            pLastName = aLastName;
            pEmail = aEmail;
        }
    }
}
