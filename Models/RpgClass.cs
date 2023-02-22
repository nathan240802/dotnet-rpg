using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //Digunakan untuk merubah nilai enumerasi menjadi string
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2 , 
        Cleric = 3
    }
}