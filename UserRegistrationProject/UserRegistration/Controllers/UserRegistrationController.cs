using Microsoft.AspNetCore.Mvc;
using BusinessLayer1.service;

namespace UserRegistration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {

        UserRegistrationBL _businessLayer;

        public UserRegistrationController(UserRegistrationBL businessLayer)
        {
            _businessLayer = businessLayer;
        }

        [HttpGet]
        public string Registration()
        {
            string username = "root";
            string password = "root1";
            string msg = _businessLayer.RegistrationBL(username, password);
            return msg;
            

        }

    }
}
