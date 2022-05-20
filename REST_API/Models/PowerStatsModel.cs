using Newtonsoft.Json;

namespace REST_API.Models
{
    public class PowerStatsModel
    {
        public int Id { get; set; }

        public int Intelligence { get; set; }

        public int Strength { get; set; }

        public int Speed { get; set; }

        public int Durability { get; set; }

        public int Power { get; set; }

        public int Combat { get; set; }

        public PowerStatsModel()
        {

        }

        public PowerStatsModel(int intelligence, int strength, int speed, int durability, int power, int combat)
        {
            this.Id= Id;
            Intelligence = intelligence;
            Strength = strength;
            Speed = speed;
            Durability = durability;
            Power = power;
            Combat = combat;
        }
    }
}
