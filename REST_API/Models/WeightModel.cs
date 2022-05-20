namespace REST_API.Models
{
    public class WeightModel
    {
        public int Id { get; set; }

        public string Pounds { get; set; }

        public string Kilograms { get; set; }
        public WeightModel()
        {

        }
        public WeightModel(string pounds, string kilograms)
        {
            Pounds = pounds;
            Kilograms = kilograms;
        }
    }
}
