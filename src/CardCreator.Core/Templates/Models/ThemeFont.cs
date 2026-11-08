using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

/// <summary>
/// Font family and font files. Paths are relative to the templates root (e.g. "Fonts/ChakraPetch/ChakraPetch-Regular.ttf")
/// so fonts can be shared between themes and games.
/// </summary>
public class ThemeFont
{
    [JsonProperty("family")]
    public string Family { get; set; } = string.Empty;

    [JsonProperty("regular")]
    public string? Regular { get; set; }

    [JsonProperty("bold")]
    public string? Bold { get; set; }

    [JsonProperty("italic")]
    public string? Italic { get; set; }

    [JsonProperty("bold_italic")]
    public string? BoldItalic { get; set; }
}
