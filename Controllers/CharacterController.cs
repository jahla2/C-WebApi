using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    //Api Controller
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
        public ActionResult<List<Character>> Get()
        {
            return Ok(_characterService.GetAllChraracters());
        }

        //Controller with Routing with parameters  
        //Send id Via URL
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        //method for Adding new Record
        //Send via JSONObject
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            //Retrun List
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}