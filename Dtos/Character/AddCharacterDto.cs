namespace dotnet_rpg.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";
<<<<<<< HEAD
        public int Hitpoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; }= 10;
        public int Intelligence { get; set; }=10;
        public RpgClass Class {get; set;}= RpgClass.Knight; 
=======

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;
        
        public RpgClass Class { get; set; } = RpgClass.Knight;
>>>>>>> 5fff9b6060cb87b20f85c8b979f56a2544f9efbc
    }
}