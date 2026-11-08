using Newtonsoft.Json;

namespace CardCreator.Core.Templates.Models;

/// <summary>Deserialized card-type.json.</summary>
public class CardTypeTemplate
{
    /// <summary>Exact card type name used in input JSON and printed on card backs, e.g. "Talent".</summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>JSON Schema file for a single card's details (relative to the card type folder).</summary>
    [JsonProperty("schema")]
    public string Schema { get; set; } = string.Empty;

    /// <summary>Names of themes this card type can use.</summary>
    [JsonProperty("themes")]
    public List<string> Themes { get; set; } = [];

    /// <summary>Layout files keyed by supported card size, e.g. "63x88mm".</summary>
    [JsonProperty("layouts")]
    public Dictionary<string, string> Layouts { get; set; } = [];
}
