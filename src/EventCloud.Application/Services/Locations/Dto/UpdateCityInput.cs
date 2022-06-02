using Abp.AutoMapper;
using EventCloud.Models.Locations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.Locations.Dto
{
    [AutoMapTo(typeof(CityDto))]
    public class UpdateCityInput
    {
        [Required(ErrorMessage = "City name is required")]
        [StringLength(255, MinimumLength = 5)]
        public virtual string Name { get; set; }

        [Required(ErrorMessage = "City code is required")]
        [StringLength(5, MinimumLength = 2)]
        public virtual int CountryId { get; set; } 

        [Required]
        public DateTime CreationTime { get; set; } = DateTime.Now;

    }
}
