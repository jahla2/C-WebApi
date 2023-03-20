using System.Text.Json.Serialization;

namespace Dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //Conver enum value to Strings
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}