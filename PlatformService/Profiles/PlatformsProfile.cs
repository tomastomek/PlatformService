using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            // because properties are named the same we don't have to do anything else
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<PlatformReadDto, PlatformPublishedDto>();
            CreateMap<Platform, GrpcPlatformModel>()
                .ForMember(destination => destination.PlatformId, source => source.MapFrom(source => source.Id))
                .ForMember(destination => destination.Name, source => source.MapFrom(source => source.Name))
                .ForMember(destination => destination.Publisher, source => source.MapFrom(source => source.Publisher));
        }
    }
}
