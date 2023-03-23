using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    //Api Controller initialize HTTP Response of WEBAPI
    [ApiController]
    //Route Attribute
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        //
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        //Controller with Route for GetAll records
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAllChraracters());
        }

        //Controller with Routing with parameters  
        //Send id Via URL
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        //method for Adding new Record
        //Send via JSONObject
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            //Retrun List
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}