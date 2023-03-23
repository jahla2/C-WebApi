namespace Dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //3 Methods from, Controller
        Task<List<Character>> GetAllChraracters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}