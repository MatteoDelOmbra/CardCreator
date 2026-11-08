using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CardCreator.Core.Input;

[JsonConverter(typeof(StringEnumConverter))]
public enum PageOrientation
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "portrait")]
    Portrait,

    [EnumMember(Value = "landscape")]
    Landscape
}
