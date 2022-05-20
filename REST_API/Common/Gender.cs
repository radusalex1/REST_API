using System.Runtime.Serialization;

namespace REST_API.Common
{
    public enum Gender
    {
        [EnumMember(Value ="male")]
        MALE,
       
        [EnumMember(Value = "female")]
        FEMALE,

        [EnumMember(Value = "-")]
        UNDEFINED
    }
}
