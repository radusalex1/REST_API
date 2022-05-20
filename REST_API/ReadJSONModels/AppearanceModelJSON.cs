using REST_API.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace REST_API.Models
{
    public class AppearanceModelJSON
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("height")]
        public List<string> Height { get; set; }

        [JsonProperty("weight")]
        public List<string> Weight { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("hairColor")]
        public string HairColor { get; set; }

    }
}
