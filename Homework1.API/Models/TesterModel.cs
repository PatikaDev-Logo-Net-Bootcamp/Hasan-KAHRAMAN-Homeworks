using Microsoft.AspNetCore.Http;
using System;

namespace Homework1.API.Models
{
    public class TesterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IFormFile Image { get; set; }
    }
}
