using Newtonsoft.Json.Linq;

namespace CardCreator.Core.Services;

public interface ICardSetLoader
{
    /// <summary>Reads the input JSON file without interpreting it.</summary>
    JObject Load(string jsonFilePath);
}
