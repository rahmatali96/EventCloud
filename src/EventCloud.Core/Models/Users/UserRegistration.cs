
using Abp.Domain.Entities.Auditing;
using EventCloud.Models.Locations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventCloud.Models.Users
{
    public class UserRegistration:FullAuditedEntity
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        
        [NotMapped]
        [Compare("Password")]
        public virtual string ConfirmPassword { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual long PhoneNumer { get; set; }
        public virtual string Street { get; set; }
        public virtual string CountryName { get; set; }
        public virtual string CityName { get; set; }
        public virtual int ZipCode { get; set; }
        public virtual string CountryCurrency { get; set; }
        public virtual string CountryLanguage { get; set; }
        public virtual bool AcceptTerm { get; set; } = true;

        public UserRegistration() 
        {
            var country = new Country();
            country.CountryCode = CountryCode;
            country.Currency = CountryCurrency;
            country.Language = CountryLanguage;

            var city = new City();
            city.Name = CityName;
        }

    }
}
