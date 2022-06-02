
using Abp.Domain.Repositories;
using Abp.UI;
using EventCloud.Models.Locations;
using EventCloud.Services.Locations.Dto;
using System;

namespace EventCloud.Services.Locations
{
    public class CountryAppService : ICountryAppService
    {
        private readonly IRepository<Country> _repository;

        public CountryAppService(IRepository<Country> repository)
        {
            _repository=repository;
        }
        public void CreateCountry(CreateCountryInput create)
        {
            var country = _repository.FirstOrDefault(c => c.Name == create.Name);
            if (country != null)
            {
                throw new UserFriendlyException("There is already a country with given name");
            }
            country = new Country
            {
                Name = create.Name,
                CountryCode = create.CountryCode,
                Currency= create.Currency,
                Language= create.Language,
                CreationTime = create.CreationTime
            };
            _repository.Insert(country);
        }

        public void GetAllCountry()
        {
            if (_repository.Count()<0)
            {
                throw new UserFriendlyException("There is no data exist");
            }
            _repository.GetAll();
        }

        public void UpdateCountry(int id)
        {
            var country = _repository.FirstOrDefault(c => c.Id == id);
            if (country == null)
            {
                throw new UserFriendlyException("There is already a country with given name");
            }
            _repository.Update(country);
        }
    }
}
