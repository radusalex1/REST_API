using Newtonsoft.Json;

namespace REST_API.Models
{
    public class WorkModel
    {
        public int Id { get; set; }

        public string Occupation { get; set; }

        public string Base { get; set; }
        public WorkModel()
        {

        }
        public WorkModel(string occupation, string @base)
        {
            
            Occupation = occupation;
            Base = @base;
        }
    }
}
