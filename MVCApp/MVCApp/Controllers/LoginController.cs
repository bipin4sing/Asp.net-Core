using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class LoginController : Controller
    {

      
        public LoginController()
        {

        }
        public IActionResult Index()
        { 

            return View();
        }
        [HttpPost]
        public IActionResult Index(Login model)
        {

            return View();
        }
    }
}