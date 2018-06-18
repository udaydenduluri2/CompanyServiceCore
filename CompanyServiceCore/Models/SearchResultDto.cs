using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyService.Models
{
    public class SearchResultDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string  ImageId { get; set; }
        public string Price { get; set; }
    }
}