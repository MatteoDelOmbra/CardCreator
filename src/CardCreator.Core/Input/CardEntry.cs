using Newtonsoft.Json.Linq;

namespace CardCreator.Core.Input;

/// <summary>
/// A single card from the input file together with its position in the "cards" array.
/// </summary>
public record CardEntry(int Index, string? Name, JObject Data);
