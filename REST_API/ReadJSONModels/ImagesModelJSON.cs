using Newtonsoft.Json;

namespace REST_API.Models
{
    public class ImagesModelJSON
    {

        [JsonProperty("xs")]
        public string ExtraSmall { get; set; }

        [JsonProperty("sm")]
        public string Small { get; set; }

        [JsonProperty("md")]
        public string Medium { get; set; }

        [JsonProperty("lg")]
        public string Large { get; set; }
    }
}