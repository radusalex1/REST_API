
namespace REST_API.Models
{
    public class HeroModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public PowerStatsModel PowerStats { get; set; }

        public AppearanceModel Appearance { get; set; }

        public BiographyModel Biography { get; set; }

        public WorkModel Work { get; set; }

        public ConnectionsModel ConnectionsModel { get; set; }

        public ImagesModel Images { get; set; }

        public HeroModel()
        {

        } 
    }
}
