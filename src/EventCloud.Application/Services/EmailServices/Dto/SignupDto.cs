using Abp.AutoMapper;
using Abp.Domain.Entities;
using EventCloud.Models.Emails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.EmailServices.Dto
{
    [AutoMapTo(typeof(Signup))]
    public class SignupDto
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
