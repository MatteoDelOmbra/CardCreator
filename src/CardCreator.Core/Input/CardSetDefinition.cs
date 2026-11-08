using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CardCreator.Core.Input;

/// <summary>
/// Root object of the input JSON file. One file describes one set of cards
/// sharing the same game, theme, card type and card size.
/// </summary>
public class CardSetDefinition
{
    [JsonProperty("output_file_path")]
    public string OutputFilePath { get; set; } = string.Empty;

    [JsonProperty("output_format")]
    public string OutputFormat { get; set; } = string.Empty;

    [JsonProperty("page_orientation")]
    public PageOrientation PageOrientation { get; set; } = PageOrientation.Auto;

    [JsonProperty("game")]
    public string Game { get; set; } = string.Empty;

    /// <summary>
    /// Optional. When missing or not supported by the card type, the game's default theme is used.
    /// </summary>
    [JsonProperty("theme")]
    public string? Theme { get; set; }

    [JsonProperty("card_type")]
    public string CardType { get; set; } = string.Empty;

    [JsonProperty("card_size")]
    public string CardSize { get; set; } = string.Empty;

    [JsonProperty("with_backs")]
    public bool WithBacks { get; set; }

    /// <summary>
    /// Raw card details. Shape depends on game + card type and is validated against the card type JSON Schema.
    /// </summary>
    [JsonProperty("cards")]
    public List<JObject> Cards { get; set; } = [];
}
