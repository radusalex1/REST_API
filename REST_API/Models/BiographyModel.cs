using REST_API.Common;
using System.Collections.Generic;

namespace REST_API.Models
{
    public class BiographyModel
    {
        public int Id { get; set; } 

        public string FullName { get; set; }

        public string AlterEgo { get; set; }

        public List<AliasesModel> Aliases { get; set; }

        public string PlaceOfBirth { get; set; }

        public string FirstAppearance { get; set; }

        public string Publisher { get; set; }

        public Alignment Alignment { get; set; }
        public BiographyModel()
        {

        }
        public BiographyModel(string fullName, string alterEgo, List<AliasesModel> aliases, string placeOfBirth, string firstAppearance, string publisher, Alignment alignment)
        {
           
            FullName = fullName;
            AlterEgo = alterEgo;
            Aliases = aliases;
            PlaceOfBirth = placeOfBirth;
            FirstAppearance = firstAppearance;
            Publisher = publisher;
            Alignment = alignment;
        }
    }
}
