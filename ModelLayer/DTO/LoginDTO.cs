using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public override string ToString()
        {
            try
            {
                return "Firstname " + firstName + " Lastname " + lastName + " Email " + email + " Password " + password;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in ToString: " + ex.Message);
                return "Error converting LoginDTO to string.";
            }



        }
    }
}
