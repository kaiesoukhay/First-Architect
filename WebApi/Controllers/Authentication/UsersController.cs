using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Authentication
{

    [Produces("application/json")]
    [Route("api/main")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


   
        //[HttpPost]
        //[Route("test")]
        //public string test([FromBody] Student student)
        //{
        //    var model = student;
        //    var x=  Json(new { success = true, result = "my name is" + model.Name });
        //    return x.Value.ToString();

        //}

        [HttpGet]
        [Route("Getlogin")]
        public IEnumerable<User> Get()
        {


            List<User> UserLogins = new List<User>()
            {
                new User(){Mail="malek", PassWord="malek"},
              new User(){Mail="aze", PassWord="aze"},
                  new User(){Mail="tttt", PassWord="ttt"}
            };
            //return new string[] { "value1", "value2" };
            return UserLogins;

        }
    }
}