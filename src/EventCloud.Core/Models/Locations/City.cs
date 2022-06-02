using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace EventCloud.Models.Locations
{
    public class City:Entity, IHasCreationTime
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int CountryId { get; set; }
        public DateTime CreationTime { get; set; }= DateTime.Now;

        public City()
        {
            var country=new Country();
            country.Id = CountryId;
        }
    }
}
