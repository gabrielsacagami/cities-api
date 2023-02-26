using AutoMapper;
using CityInfo.API.Entities;

namespace CityInfo.API.Profiles;

public class PointOfInterestProfile : Profile
{
    public PointOfInterestProfile()
    {
    CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
    }
}