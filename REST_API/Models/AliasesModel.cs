namespace REST_API.Models
{
    public class AliasesModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public AliasesModel()
        {

        }
        public AliasesModel(string name)
        {
            Name = name;
        }
    }
}
