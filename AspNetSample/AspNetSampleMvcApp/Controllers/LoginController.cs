﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetSampleMvcApp.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Register() => Ok("Registred");


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return Ok("Logged in");
        }
    }
}