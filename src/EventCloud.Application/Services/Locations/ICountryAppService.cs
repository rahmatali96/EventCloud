using Abp.Application.Services;
using EventCloud.Services.Locations.Dto;


namespace EventCloud.Services.Locations
{
    public interface ICountryAppService : IApplicationService
    {
        void GetAllCountry();
        void CreateCountry(CreateCountryInput create);
        void UpdateCountry(int id);
    }
}
