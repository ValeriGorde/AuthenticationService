using AutoMapper;

namespace AuthenticationService
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<User, UserViewModel>().ConstructUsing(u => new UserViewModel(u)); //маппинг модели домена в модель представления
            //CreateMap<UserViewModel, User>();
        }
    }
}
