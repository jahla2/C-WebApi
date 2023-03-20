namespace Dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        //3 Methods fro, Controller
        List<Character> GetAllChraracters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}