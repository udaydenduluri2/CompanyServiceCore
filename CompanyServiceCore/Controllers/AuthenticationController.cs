﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CompanyService.Controllers
{
    [Route("api/Authentication")]
    [EnableCors("MyPolicy")]
    public class AuthenticationController : Controller
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("ValidateUser")]
        public IActionResult ValidateUser([FromBody]Models.UserDto userDto)
        {
            if(userDto.UserName.Equals("uday.denduluri") && userDto.Password.Equals("password1"))
            {
                return Ok(new { ValidUser = true, Reason = "Validated" });
            }
            return Ok(new { ValidUser = false, Reason = "Invalid User" });
        }

        [HttpPost]
        public IActionResult Logout(string userName)
        {
            return Ok();
        }
    }
}
