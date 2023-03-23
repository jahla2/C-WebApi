namespace Dotnet_rpg.Services.CharacterService
{
    public class ChracterService : ICharacterService
    {
        //Method 
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { id = 1, name = "Sam"}
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            //Add new
            characters.Add(newCharacter);
            //Retrun List
            return characters;
        }

        public async Task<List<Character>> GetAllChraracters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.id == id);
            if (character is not null)
                return character;
            throw new Exception("Character Not Found");
        }
    }
}