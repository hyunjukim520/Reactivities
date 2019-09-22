using System.Linq;
using AutoMapper;
using Domain;

namespace Application.Activities
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Activity, ActivityDto>();
      CreateMap<UserActivity, AttendeeDto>()
        .ForMember(destination => destination.Username, option => option.MapFrom(source => source.AppUser.UserName))
        .ForMember(destination => destination.DisplayName, option => option.MapFrom(source => source.AppUser.DisplayName))
        .ForMember(d => d.Image, o => o.MapFrom(s => s.AppUser.Photos.FirstOrDefault(x => x.IsMain).Url));
    }
  }
}