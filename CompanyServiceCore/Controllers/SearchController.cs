using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CompanyService.Models;

namespace CompanyServiceCore.Controllers
{
    [Produces("application/json")]
    public class SearchController : Controller
    {
        [HttpGet]
        [Route("api/Search")]
        public IEnumerable<SearchResultDto> Index(string searchTerm)
        {
            var results = new List<SearchResultDto>
            {
                new SearchResultDto{ Name = "Name1", Description = "Description 1", ImageId="Image1", Price= "£12.78" },
                new SearchResultDto{ Name = "Name2", Description = "Description 2", ImageId="Image2", Price= "£32.98" },
                new SearchResultDto{ Name = "Name3", Description = "Description 3", ImageId="Image3", Price= "£96.70" },
                new SearchResultDto{ Name = "Test1", Description = "Test Desc 1", ImageId="TestImage1", Price= "£102.78" },
                new SearchResultDto{ Name = "Test2", Description = "Test Desc 2", ImageId="TestImage2", Price= "£392.98" },
                new SearchResultDto{ Name = "Test3", Description = "Test Desc 3", ImageId="TestImage3", Price= "£196.70" }
            };

            return results.Where(r => r.Name.Contains(searchTerm));
        }

        [HttpGet]
        [Route("api/Search/RelatedSearch")]
        public IEnumerable<SearchResultDto> RelatedSearch(string selectedItem)
        {
            var results = new List<SearchResultDto>
            {
                new SearchResultDto{ Name = "Name1", Description = "Description 1", ImageId="Image1", Price= "£12.78" },
                new SearchResultDto{ Name = "Name2", Description = "Description 2", ImageId="Image2", Price= "£32.98" },
                new SearchResultDto{ Name = "Name3", Description = "Description 3", ImageId="Image3", Price= "£96.70" },
                new SearchResultDto{ Name = "Test1", Description = "Test Desc 1", ImageId="TestImage1", Price= "£102.78" },
                new SearchResultDto{ Name = "Test2", Description = "Test Desc 2", ImageId="TestImage2", Price= "£392.98" },
                new SearchResultDto{ Name = "Test3", Description = "Test Desc 3", ImageId="TestImage3", Price= "£196.70" }
            };

            return results;
        }
    }
}