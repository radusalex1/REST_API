using Newtonsoft.Json;

namespace REST_API.Models
{
    public class WorkModelJSON
    {
        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

    }
}
