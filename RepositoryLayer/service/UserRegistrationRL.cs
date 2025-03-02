using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.service
{
    public class UserRegistrationRL
    {
        
        private string databasefirstName = "Jyoti";
        private string databaselastName = "Thakur";
        private string databaseEmail = "thakurjyoti1430@gmail.com";

        public (string, string) RegistrationRL(string username, string password)
        {
            return ("root", "root");
        }

        public LoginDTO GetFirstNameLastName(LoginDTO loginDTO)
        {
            try
            {
                loginDTO.firstName = databasefirstName;
                loginDTO.lastName = databaselastName;
                return loginDTO;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetFirstnameLastname: " + ex.Message);
                return null;
            }

        }

        public LoginDTO GetEmail(LoginDTO loginDTO)
        {
            try
            {
                loginDTO.email = databaseEmail;
                return loginDTO;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in GetEmail: " + ex.Message);
                return null;
            }

        }
    }


}
