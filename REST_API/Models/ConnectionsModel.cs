using Newtonsoft.Json;

namespace REST_API.Models
{
    public class ConnectionsModel
    {
        public int Id { get; set; }

        public string GroupAffiliation { get; set; }

        public string Relatives { get; set; }
        public ConnectionsModel()
        {

        }
        public ConnectionsModel(string groupAffiliation, string relatives)
        {
            
            GroupAffiliation = groupAffiliation;
            Relatives = relatives;
        }
    }
}
