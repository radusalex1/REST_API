using Newtonsoft.Json;

namespace REST_API.Models
{
    public class HeroModelJSON
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("powerstats")]
        public PowerStatsModelJSON PowerStats { get; set; }

        [JsonProperty("appearance")]
        public AppearanceModelJSON Appearance { get; set; }

        [JsonProperty("biography")]
        public BiographyModelJSON Biography { get; set; }

        [JsonProperty("work")]
        public WorkModelJSON Work { get; set; }

        [JsonProperty("connection")]
        public ConnectionsModelJSON ConnectionsModel { get; set; }

        [JsonProperty("images")]
        public ImagesModelJSON Images { get; set; }

        public HeroModelJSON()
        {
            PowerStats = new PowerStatsModelJSON();
            Appearance = new AppearanceModelJSON();
            Biography = new BiographyModelJSON();
            Work = new WorkModelJSON();
            ConnectionsModel = new ConnectionsModelJSON();
            Images = new ImagesModelJSON();
        }
            
    }
}
