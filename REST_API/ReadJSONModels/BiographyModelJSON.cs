using REST_API.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace REST_API.Models
{
    public class BiographyModelJSON
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("alterEgos")]
        public string AlterEgo { get; set; }

        [JsonProperty("aliases")]
        public List<string> Aliases { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("firstAppearance")]
        public string FirstAppearance { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Alignment Alignment { get; set; }

    }
}
