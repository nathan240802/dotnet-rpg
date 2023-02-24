
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
       
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
            
        }

    [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

    [HttpGet("{id}")]

        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            var response= await _characterService.GetCharacterById(id);
            if(response.Data == null)
                return NotFound(response);
            return Ok(response);
        }

    [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

    [HttpPut]

        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            var response= await _characterService.UpdateCharacter(updateCharacter);

            if(response.Data == null)
                return NotFound(response);

            return Ok(response);
        }
    }
}