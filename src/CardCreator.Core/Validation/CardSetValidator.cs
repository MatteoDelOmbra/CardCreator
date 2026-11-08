using CardCreator.Core.Templates;
using Newtonsoft.Json.Linq;

namespace CardCreator.Core.Validation;

public class CardSetValidator : ICardSetValidator
{
    private readonly ITemplateCatalog _templateCatalog;
    private readonly IEmbeddedResourceReader _resourceReader;

    public CardSetValidator(ITemplateCatalog templateCatalog, IEmbeddedResourceReader resourceReader)
    {
        _templateCatalog = templateCatalog;
        _resourceReader = resourceReader;
    }

    public IReadOnlyList<string> ValidateDefinition(JObject rawDefinition)
    {
        throw new NotImplementedException();
    }

    public CardsValidationResult ValidateCards(IReadOnlyList<JObject> cards, ResolvedTemplate template)
    {
        throw new NotImplementedException();
    }
}
