namespace Dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //3 Methods from, Controller
        Task<ServiceResponse<List<Character>>> GetAllChraracters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}