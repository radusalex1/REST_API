using REST_API.Common;

namespace REST_API.Models
{
    public class AppearanceModel
    {
        public int Id { get;set; }

        public Gender Gender { get; set; }

        public string Race { get; set; }

        public HeightModel Height { get; set; }

        public WeightModel Weight { get; set; }

        public string EyeColor { get; set; }

        public string HairColor { get; set; }
        public AppearanceModel()
        {

        }
        public AppearanceModel(Gender gender, string race, HeightModel height, WeightModel weight, string eyeColor, string hairColor)
        {
            
            Gender = gender;
            Race = race;
            Height = height;
            Weight = weight;
            EyeColor = eyeColor;
            HairColor = hairColor;
        }
    }
}
