using Abp.Application.Services;
using EventCloud.Services.Locations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.Locations
{
    public interface ICityAppService : IApplicationService
    {
        void CreateCity(CreateCityInput createCity);
        void UpdateCity(UpdateCityInput update, int id);
    }
}
