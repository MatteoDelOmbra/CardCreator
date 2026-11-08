using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

/// <summary>Deserialized theme.json.</summary>
public class ThemeTemplate
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("font")]
    public ThemeFont Font { get; set; } = new();

    [JsonProperty("text_color")]
    public string TextColor { get; set; } = "#000000";

    /// <summary>Backgrounds keyed by card size, e.g. "63x88mm".</summary>
    [JsonProperty("backgrounds")]
    public Dictionary<string, ThemeBackground> Backgrounds { get; set; } = [];
}
