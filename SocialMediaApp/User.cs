using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApp
{
    public class User
    {
        private string _username;
        private string _password;
        public string Email { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Username
        {
            get => _username;
            set
            {
                _username = value;

            }
        }
        public string Password { get; set; }
    }
}
