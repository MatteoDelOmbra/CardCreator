using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

/// <summary>Background image files (paths relative to the theme folder). Images include bleed.</summary>
public class ThemeBackground
{
    [JsonProperty("front")]
    public string Front { get; set; } = string.Empty;

    [JsonProperty("back")]
    public string Back { get; set; } = string.Empty;
}
