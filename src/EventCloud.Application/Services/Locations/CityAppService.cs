using Abp.Domain.Repositories;
using Abp.UI;
using EventCloud.Models.Locations;
using EventCloud.Services.Locations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCloud.Services.Locations
{
    public class CityAppService : ICityAppService
    {
        private readonly IRepository<City> _repository;

        public CityAppService(IRepository<City> repository)
        {
            _repository=repository;
        }
        public void CreateCity(CreateCityInput createCity)
        {
            var city = _repository.FirstOrDefault(c => c.Name == createCity.Name);
            if (city != null)
            {
                throw new UserFriendlyException("There is already a country with given name");
            }
            city = new City
            {
                Id=createCity.Id,
                Name = createCity.Name,
                CountryId = createCity.CountryId,
                CreationTime = createCity.CreationTime
            };
            _repository.Insert(city);
        }

        public void UpdateCity(UpdateCityInput update, int id)
        {
            var country = _repository.FirstOrDefault(c => c.Id ==id);
            if (country == null)
            {
                throw new UserFriendlyException("There is already a country with given name");
            }
            country = new City
            {
                Name = update.Name,
                CountryId = update.CountryId
            };
            _repository.Update(country);
        }
    }
}
