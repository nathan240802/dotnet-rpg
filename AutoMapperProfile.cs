<<<<<<< HEAD
using AutoMapper;

namespace dotnet_rpg
{
    public class AutoMapperProfile:Profile
=======
namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
            CreateMap<UpdateCharacterDto,Character>();
<<<<<<< HEAD
            
=======
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
        }
    }
}