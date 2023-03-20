using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    //Api Controller
    [ApiController]
    //Route Attribute
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        //Method 
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { id = 1, name = "Sam"}
        };
        //Controller with Route for GetAll records
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        //Controller with Routing with parameters  
        //Send id Via URL
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }

        //method for Adding new Record
        //Send via JSONObject
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newChracter)
        {
            //Add new
            characters.Add(newChracter);
            //Retrun List
            return Ok(characters);
        }
    }
}