
<<<<<<< HEAD

=======
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
<<<<<<< HEAD

       Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

       Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

       Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
=======
        
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacterds);

>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
    }
}