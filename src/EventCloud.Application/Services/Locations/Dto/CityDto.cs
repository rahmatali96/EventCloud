using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using EventCloud.Models.Locations;
using System;
using System.ComponentModel.DataAnnotations;
namespace EventCloud.Services.Locations.Dto
{
    [AutoMapTo(typeof(City))]
    public class CityDto : EntityDto
    {
        public virtual int Id { get; set; }

        [Required(ErrorMessage ="City name is required")]
        [StringLength(255,MinimumLength =5)]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "City code is required")]
        [StringLength(5, MinimumLength = 2)]
        public virtual int CountryId { get; set; }

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        public CityDto()
        {
            var country = new Country();
            country.Id = CountryId;
        }
    }
}
