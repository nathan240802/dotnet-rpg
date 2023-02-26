using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
<<<<<<< HEAD
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage= 2,
        Cleric=3
=======
    [JsonConverter(typeof(JsonStringEnumConverter))] //Digunakan untuk merubah nilai enumerasi menjadi string
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2 , 
        Cleric = 3
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
    }
}