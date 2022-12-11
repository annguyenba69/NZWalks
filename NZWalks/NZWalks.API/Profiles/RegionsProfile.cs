using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile() 
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                //Tell Convert DTO => Domain
                .ReverseMap();
            //If have different property can specify like that Id (DTO) => Id (Domain)
            /*                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.Id));*/
        }
    }
}
