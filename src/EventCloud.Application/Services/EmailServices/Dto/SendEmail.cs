using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.EmailServices.Dto
{
    [AutoMapTo(typeof(SignupDto))]
    public class SendEmail
    {
        public string Email { get; set; }
    }
}
