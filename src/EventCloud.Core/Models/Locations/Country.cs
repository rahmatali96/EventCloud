using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EventCloud.Models.Locations
{
    public class Country:Entity, IHasCreationTime
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string Language { get; set; }
        public virtual string Currency { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
