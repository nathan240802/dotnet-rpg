
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
<<<<<<< HEAD
    [Route("api/controller")]
    public class CharacterController :ControllerBase
    {

        private readonly ICharacterService _characterService;

=======
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
       
        private readonly ICharacterService _characterService;
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
            
        }

<<<<<<< HEAD
    [HttpGet("GetAll")]//Memberikan tambahan route karena httpget ada dua.Route tambahan disini adalah ("GetAll")
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
    {
        return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
    {
        var response=await _characterService.GetCharacterById(id);
        if(response.Data==null)
            return NotFound(response);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
    {
       
        return Ok(await _characterService.AddCharacter(newCharacter));
    }

    [HttpPut]

    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
    {
        var response= await _characterService.UpdateCharacter(updatedCharacter);
        if (response.Data == null)
            return NotFound(response);

        return Ok(response);
        
    }

    [HttpDelete ("{id}")]

    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> DeleteCharacter(int id)
    {
        var response=await _characterService.DeleteCharacter(id);
        if(response.Data == null)
            return NotFound(response);
        return Ok(response);
    }

=======
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
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
    }
}