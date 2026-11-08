using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

/// <summary>Deserialized game.json.</summary>
public class GameTemplate
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Theme used when no theme is selected or the selected theme is not supported by the card type.
    /// Every card type of the game must support it.
    /// </summary>
    [JsonProperty("default_theme")]
    public string DefaultTheme { get; set; } = string.Empty;
}
