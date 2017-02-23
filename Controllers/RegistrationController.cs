using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using valform.Models;

namespace valform.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        
        public IActionResult AddUser(User user)
        {
           if(ModelState.IsValid)
           {
            //    save new user here

           }
           // Handle failure
        }
        private static User GetNewUser()
        {
            return new User
            {
                First_Name = "first_name",
                Last_Name = "last_name",
                Age = 0,
                Email = "email@email.com",
                Password = "password"
            };
        }
    }
}
