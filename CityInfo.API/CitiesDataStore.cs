using CityInfo.API.Models;

namespace CityInfo.API;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }

    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "Rio de Janeiro",
                Description = "Wonderful city"
            },
            new CityDto()
            {
                Id = 2,
                Name = "São Paulo",
                Description = "City of Stone"
            },
            new CityDto()
            {
                Id = 3,
                Name = "Brasília",
                Description = "Capital of Brazil"
            },
        };
    }
}