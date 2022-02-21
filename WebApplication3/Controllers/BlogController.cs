using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            //TODO

            List<User> users = new List<User>()
            {
                new User
                {
                    Name = "kenan",
                    Surname = "agamuradli",
                    Email = "babek.agamuradli@gmail.com",
                    Password = "12345"
                },
                new User
                {
                    Name = "elshad",
                    Surname = "babeyev",
                    Email = "elshad.babayev@gmail.com",
                    Password = "12345"
                }
            };

            return View(users);
        }

    }


}
