using CardCreator.Core.Input;
using CardCreator.Core.Templates;
using CardCreator.Core.Validation;

namespace CardCreator.Core.Services;

public record PreparedCardSet(
    CardSetDefinition Definition,
    ResolvedTemplate Template,
    CardsValidationResult Cards);
