using AutoMapper;

namespace CityInfo.API.Profiles;

public class CityProfiles : Profile
{
    public CityProfiles()
    {
        CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
        CreateMap<Entities.City, Models.CityDto>();
    }
    
}