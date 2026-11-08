using CardCreator.Core.Input;
using CardCreator.Core.Templates;
using Newtonsoft.Json.Linq;

namespace CardCreator.Core.Validation;

public interface ICardSetValidator
{
    /// <summary>
    /// Validates root properties against the card set schema and the template catalog.
    /// Errors returned here are fatal.
    /// </summary>
    IReadOnlyList<string> ValidateDefinition(JObject rawDefinition);

    /// <summary>
    /// Validates each card against the card type schema. Invalid cards can be skipped by the user.
    /// </summary>
    CardsValidationResult ValidateCards(IReadOnlyList<JObject> cards, ResolvedTemplate template);
}
