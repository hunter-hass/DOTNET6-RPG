using System.Text.Json.Serialization;

namespace DOTNET_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,

        Mage = 2,

        Druid = 3


    }
}