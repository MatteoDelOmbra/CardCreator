using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

public class LayoutElement
{
    /// <summary>Card property rendered in this element. Not used for the back title.</summary>
    [JsonProperty("field")]
    public string? Field { get; set; }

    [JsonProperty("x")]
    public double X { get; set; }

    [JsonProperty("y")]
    public double Y { get; set; }

    [JsonProperty("width")]
    public double Width { get; set; }

    [JsonProperty("height")]
    public double Height { get; set; }

    /// <summary>Starting font size in points. Shrunk to fit, down to the minimum font size.</summary>
    [JsonProperty("font_size")]
    public double FontSize { get; set; }

    [JsonProperty("bold")]
    public bool Bold { get; set; }

    [JsonProperty("italic")]
    public bool Italic { get; set; }

    [JsonProperty("alignment")]
    public TextAlignment Alignment { get; set; } = TextAlignment.Left;

    [JsonProperty("markdown")]
    public bool Markdown { get; set; }
}
