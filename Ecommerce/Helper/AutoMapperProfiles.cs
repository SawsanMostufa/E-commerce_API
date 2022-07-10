using AutoMapper;
using Ecommerce.DTO.Auth;
using Ecommerce.Models;

namespace Ecommerce.Helper
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ApplicationUser, UserForListDto>()

                   //.ForMember(dest => dest.PhotoUrl, opt =>
                   //{
                   //    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                   //})
                   .ForMember(dest => dest.Age, opt =>
                   {
                       opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
                   });

            CreateMap<ApplicationUser, UserForDetailedDto>()
            
            .ForMember(dest => dest.Age, opt =>
            {
                opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            });




        }
    }
}
