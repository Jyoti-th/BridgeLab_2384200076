using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer1.service;

namespace BusinessLayer1.service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _repoLayer;
        public UserRegistrationBL(UserRegistrationRL repoLayer)
        {
            _repoLayer = repoLayer;
        }

        public string RegistrationBL(string username, string password)
        {
            var (user, pass) = _repoLayer.RegistrationRL(username, password);

            if(username == user && password == pass)
            {
                return "Login Sucessfuylly";
            }
            else
            {
                return "Invalid";
            }

        }
    }
}
