using Newtonsoft.Json;

namespace REST_API.Models
{
    public class ConnectionsModelJSON
    {

        [JsonProperty("groupAffiliation")]
        public string GroupAffiliation { get; set; }

        [JsonProperty("relatives")]
        public string Relatives { get; set; }


    }
}
