using System.Runtime.Serialization;

namespace REST_API.Common
{
    public enum Alignment
    {
        [EnumMember(Value = "good")]
        GOOD,

        [EnumMember(Value = "bad")]
        BAD,

        [EnumMember(Value = "neutral")]
        NEUTRAL,

        [EnumMember(Value = "-")]
        UNDEFINED
    }

}
