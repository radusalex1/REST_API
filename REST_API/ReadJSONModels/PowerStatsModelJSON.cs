using Newtonsoft.Json;

namespace REST_API.Models
{
    public class PowerStatsModelJSON
    {
        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("speed")]
        public int Speed { get; set; }

        [JsonProperty("durability")]
        public int Durability { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("combat")]
        public int Combat { get; set; }

    }
}
