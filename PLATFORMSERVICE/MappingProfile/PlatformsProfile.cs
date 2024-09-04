
using AutoMapper;
using PLATFORMSERVICE.DTOs;
using PLATFORMSERVICE.Model;

namespace PLATFORMSERVICE.MappingProfile
{
    public class PlatformsProfile : Profile 
    {
        public PlatformsProfile()
        {
            CreateMap<PlatForm, PlatformReadDto>();
            CreateMap<PlatformCreateDto, PlatForm>();
        }
    }
}
