using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

/// <summary>
/// Deserialized layout JSON. Positions are in millimetres relative to the top-left corner of the trimmed card.
/// </summary>
public class CardLayoutTemplate
{
    [JsonProperty("card_size")]
    public string CardSize { get; set; } = string.Empty;

    [JsonProperty("front")]
    public List<LayoutElement> Front { get; set; } = [];

    [JsonProperty("back_title")]
    public LayoutElement? BackTitle { get; set; }
}
