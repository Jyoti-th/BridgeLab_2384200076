using Microsoft.AspNetCore.Mvc;
using BusinessLayer.service;
using ModelLayer.DTO;
using Microsoft.VisualBasic;
using NLog;

namespace UserRegistration.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
{
    private Logger logger = LogManager.GetCurrentClassLogger();
    UserRegistrationBL _obj;

    public UserRegistrationController(UserRegistrationBL obj)
    {
        _obj = obj;
    }

    [HttpGet]
    public string Registration()
    {
        string username = "root";
        string password = "root";
        string msg = _obj.RegistrationBL(username, password);
        return msg;
    }


    [HttpPost]
    //public string Login(string username, string password)
    //{
    //    return username + " " + password;
    //}


    //public string Login(LoginDTO logindto)
    //{
    //    return logindto.ToString();
    //}

    public IActionResult LoginUser(LoginDTO loginDTO)
    {
        var response = new ResponseDTO<string>();
        try
        {
            bool res = _obj.loginuser(loginDTO);
            
            if (res)
            {
            
             response.success = true;
             response.message = "Login SuccessFully";
             response.data = loginDTO.ToString();
             logger.Info("User Logged In Successfully");
             return Ok(response);
            }

            response.success = false;
            response.message = "Login Unsuccessful";
            response.data = "";
            logger.Warn("Login failed for email");
            return NotFound(); ;
        }
        
        catch (Exception ex)
        {
            response.success = false;
            response.message = "Login failed";
            response.data = ex.Message;
            logger.Error("Exception Occured");
            return BadRequest();
        }
    }

    

    }


