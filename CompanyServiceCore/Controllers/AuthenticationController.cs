using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CompanyService.Controllers
{
    [Route("api/Authentication")]
    [EnableCors("*")]
    public class AuthenticationController : Controller
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
      
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

        [HttpGet]
        public IEnumerable<Models.SearchResultDto> Search(string searchTerm)
        {
            var results = new List<Models.SearchResultDto>
            {
                new Models.SearchResultDto{ Name = "Name1", Description = "Description 1", ImageId="Image1", Price= "£12.78" },
                new Models.SearchResultDto{ Name = "Name2", Description = "Description 2", ImageId="Image2", Price= "£32.98" },
                new Models.SearchResultDto{ Name = "Name3", Description = "Description 3", ImageId="Image3", Price= "£96.70" },
                new Models.SearchResultDto{ Name = "Test1", Description = "Test Desc 1", ImageId="TestImage1", Price= "£102.78" },
                new Models.SearchResultDto{ Name = "Test2", Description = "Test Desc 2", ImageId="TestImage2", Price= "£392.98" },
                new Models.SearchResultDto{ Name = "Test3", Description = "Test Desc 3", ImageId="TestImage3", Price= "£196.70" }
            };

            return results.Where(r => r.Name.Contains(searchTerm));
        }
    }
}
