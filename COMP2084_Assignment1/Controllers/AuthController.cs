﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace COMP2084_Assignment1.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [Route("signin")]
        public IActionResult SignIn()
        {

            return Challenge(new AuthenticationProperties { RedirectUri = "/" });
        }
    }
}