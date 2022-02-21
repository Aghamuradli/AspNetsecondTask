using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //TODO
            List<User> users = new List<User>()
            {
                new User
                {
                    Name = "Babek",
                    Surname = "Agamuradli",
                    Email = "Babek123@gmail.com",
                    Password = "12345"
                },
                new User
                {
                    Name = "Elshad",
                    Surname = "Babayev",
                    Email = "Elshad123@gmail.com",
                    Password = "12345"
                }
            };

            return View(users);
        }


       
    }
}
