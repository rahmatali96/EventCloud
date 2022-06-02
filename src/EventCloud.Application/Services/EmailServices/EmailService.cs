using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using EventCloud.Models.Emails;
using EventCloud.Services.EmailServices.Dto;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.EmailServices
{
    public interface IEmailService : IApplicationService
    {
        void SendEmail(SignupDto signup);
    }
    public class EmailService:IEmailService
    {
        private readonly IRepository<Signup> _repository;

        public EmailService(IRepository<Signup> repository)
        {
            _repository=repository;
        }
        public void SendEmail(SignupDto signup)
        {
            var exist = _repository.FirstOrDefault(x => x.Email == signup.Email);
            if (signup == null)
            {
                throw new UserFriendlyException("Bad request");
            }
            if (exist != null)
            {
                throw new UserFriendlyException("User already exist");
            }
            exist = new Signup
            {
                Title = signup.Title,
                FirstName = signup.FirstName,
                LastName = signup.LastName,
                Email = signup.Email,
                Password = signup.Password,
                CreationTime = signup.CreationTime = DateTime.Now
            };
            _repository.Insert(exist);
            SendEmailTo(signup.Email);
            
        }
        void SendEmailTo(string Email)
        {
            if (Email == null)
            {
                throw new UserFriendlyException("bad request");
            }
            var body = "Hi,  you are welcome in testing";
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("testerpromactinfo@gmail.com"));
            email.To.Add(MailboxAddress.Parse(Email));
            email.Subject = "Test email subject";
            email.Body = new TextPart(TextFormat.Html) { Text = body };
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("testerpromactinfo@gmail.com", "Tester@123");
            smtp.Send(email);
            smtp.Disconnect(true);

        }
    }
}
