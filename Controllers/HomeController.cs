using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string messages = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sequi, harum. Nam veritatis repellendus aspernatur iusto, doloribus fuga soluta itaque recusandae facilis dolore impedit possimus non nostrum? Asperiores minus at placeat!";
            return View("Index", messages);
        }

        [HttpGet("numbers")]
        public IActionResult Number()
        {
            int[] numbers = new int[]
            {
                1,
                2,
                3,
                10,
                43,
                5
            };
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> users = new List<User>();

            users.Add(new User {FirstName="Moose", LastName="Philips"});
            users.Add(new User() {FirstName = "Sarah", LastName = ""});
            users.Add(new User() {FirstName = "Jerry", LastName = ""});
            users.Add(new User() {FirstName = "Rene", LastName = "Ricky"});
            users.Add(new User() {FirstName = "Barbarah", LastName = ""});

            return View("Users", users);
        }

        [HttpGet("user")]
        public IActionResult UserDetail()
        {
            User person = new User()
            {
                FirstName = "Moose",
                LastName = "Philips"
            };
            return View("UserDetail", person);
        }
    }
}