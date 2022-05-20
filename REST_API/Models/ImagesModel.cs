using Newtonsoft.Json;

namespace REST_API.Models
{
    public class ImagesModel
    {
        public int Id { get; set; }

        public string ExtraSmall { get; set; }

        public string Small { get; set; }

        public string Medium { get; set; }

        public string Large { get; set; }

        public ImagesModel()
        {

        }

        public ImagesModel(string extraSmall, string small, string medium, string large)
        {
            
            ExtraSmall = extraSmall;
            Small = small;
            Medium = medium;
            Large = large;
        }
    }
}