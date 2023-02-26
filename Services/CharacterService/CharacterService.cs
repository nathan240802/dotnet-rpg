using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CharacterService(IMapper mapper , DataContext context)
        {
            _context = context;
            _mapper = mapper;
            
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
           var serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
           var dbCharacter= await _context.Characters.ToListAsync();
           var character=_mapper.Map<Character>(newCharacter);
           character.Id= dbCharacter.Max(c=>c.Id)+1;
           dbCharacter.Add(character);
           serviceResponse.Data=dbCharacter.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList();
           return serviceResponse;
        }


        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
           var serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
           var dbCharacter= await _context.Characters.ToListAsync();
           try
           {
             var character= dbCharacter.FirstOrDefault(c=>c.Id == id);
             if (character == null)
                throw new Exception($"Character with Id {id} not found");

            dbCharacter.Remove(character);
            serviceResponse.Data=dbCharacter.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToList();

           }
           catch (Exception ex)
           {
            
            serviceResponse.Success=false;
            serviceResponse.Message=ex.Message;
           }

           return serviceResponse;
        }


        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            var serviceResponse=new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data= await _context.Characters.Select(c=>_mapper.Map<GetCharacterDto>(c)).ToListAsync();
            return serviceResponse;
        }


        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var serviceResponse=new ServiceResponse<GetCharacterDto>();
            try
            {
            var dbCharacter = await _context.Characters.FirstOrDefaultAsync(c=>c.Id == id);
            if(dbCharacter == null)
                throw new Exception($"Character with id {id} not found");
            serviceResponse.Data=_mapper.Map<GetCharacterDto>(dbCharacter);
            }
            catch (Exception ex)
            {
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }
            
            return serviceResponse;
            
        }
        

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
           var serviceResponse = new ServiceResponse<GetCharacterDto>();

            try
            {
           var dbCharacter=await _context.Characters.FirstOrDefaultAsync(c=>c.Id == updatedCharacter.Id);

                if(dbCharacter == null)
                throw new Exception($"Character with Id '{updatedCharacter.Id}' not found");

            _mapper.Map(updatedCharacter,dbCharacter);

           serviceResponse.Data=_mapper.Map<GetCharacterDto>(dbCharacter);
            }
            catch (Exception ex)
            {
                
               serviceResponse.Success=false;
               serviceResponse.Message=ex.Message;
            }
        

           return serviceResponse;
        }
    }
}