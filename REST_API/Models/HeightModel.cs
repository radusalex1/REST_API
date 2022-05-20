namespace REST_API.Models
{
    public class HeightModel
    {
        public int Id { get; set; }

        public string Inches { get;set; }

        public string Centimeters { get; set; }
        public HeightModel()
        {

        }
        public HeightModel(string inches, string centimeters)
        {
            Inches = inches;
            Centimeters = centimeters;
        }
    }
}
