using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.Locations.Dto
{
    public class CountryDto
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string Language { get; set; }
        public virtual string Currency { get; set; }
        public DateTime CreationTime { get; set; }= DateTime.Now;
    }
}
