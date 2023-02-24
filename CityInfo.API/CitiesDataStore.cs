using CityInfo.API.Models;

namespace CityInfo.API;

public class CitiesDataStore
{
    public List<CityDto> Cities { get; set; }
    //public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public CitiesDataStore()
    {
        Cities = new List<CityDto>()
        {
            new CityDto()
            {
                Id = 1,
                Name = "Rio de Janeiro",
                Description = "Wonderful city",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 1,
                        Name = "Sugarloaf",
                        Description = "Rock peak of Sugarloaf, towering 394 meters above the harbor. It sits on a point of land that projects out into the bay and wraps around its harbor, and is connected to the city by a low strip of land."
                    },
                    new PointOfInterestDto()
                    {
                        Id = 2,
                        Name = "Christ the Redeemer",
                        Description = "The giant statue of Christ overlooking the city from the 709-meter summit of Corcovado is almost as widely recognized a symbol of Rio as the distinctive shape of Sugarloaf."
                    }
                }
            },
            new CityDto()
            {
                Id = 2,
                Name = "São Paulo",
                Description = "City of Stone",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 3,
                        Name = "Liberdade",
                        Description = "Neighborhood with many oriental influences. Home of Japanese immigrants"
                    },
                    new PointOfInterestDto()
                    {
                        Id = 4,
                        Name = "MASP",
                        Description = "The São Paulo Museum of Art, known locally as MASP, only opened in 1968 but has the most representative and comprehensive collection of western art in Latin America."
                    }
                
                }
                
            },
            new CityDto()
            {
                Id = 3,
                Name = "Brasília",
                Description = "Capital of Brazil",
                PointsOfInterest = new List<PointOfInterestDto>()
                {
                    new PointOfInterestDto()
                    {
                        Id = 5,
                        Name = "Praça dos Três Poderes",
                        Description = "Brasilia's governmental center combines some of its most striking landmark buildings and monuments into a stunning showcase of modern architecture."
                    },
                    new PointOfInterestDto()
                    {
                        Id = 6,
                        Name = "Palácio Itamaraty",
                        Description = "he Palácio dos Arcos, also known as the Palácio Itamaraty, houses the Foreign Ministry and is one of Oscar Niemeyer's greatest achievements."
                    }
                }
            },
            new CityDto()
            {
                Id = 4,
                Name = "Salvador",
            }
        };
    }
}