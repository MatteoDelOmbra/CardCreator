using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CardCreator.Core.Templates.Models;

[JsonConverter(typeof(StringEnumConverter))]
public enum TextAlignment
{
    [EnumMember(Value = "left")]
    Left,

    [EnumMember(Value = "center")]
    Center,

    [EnumMember(Value = "right")]
    Right,

    [EnumMember(Value = "justify")]
    Justify
}
