namespace Dotnet_rpg.Services.CharacterService
{
    public class ChracterService : ICharacterService
    {
        //Method 
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { id = 1, name = "Sam"}
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            //Add new
            characters.Add(newCharacter);
            //Set data property to characters list
            serviceResponse.Data = characters;
            //Retrun List
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllChraracters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.id == id);
            serviceResponse.Data = character;
            return serviceResponse;
        }
    }
}