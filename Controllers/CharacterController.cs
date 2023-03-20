using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    //Api Controller
    [ApiController]
    //Route Attribute
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { id = 1, name = "Sam"}
        };
        //Route for GetAll records
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        //Routing with parameters
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.id == id));
        }
    }
}