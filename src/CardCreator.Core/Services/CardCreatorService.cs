using CardCreator.Core.Layout;
using CardCreator.Core.Rendering;
using CardCreator.Core.Templates;
using CardCreator.Core.Validation;

namespace CardCreator.Core.Services;

public class CardCreatorService : ICardCreatorService
{
    private readonly ICardSetLoader _loader;
    private readonly ICardSetValidator _validator;
    private readonly ITemplateCatalog _templateCatalog;
    private readonly ISheetLayoutCalculator _sheetLayoutCalculator;
    private readonly ICardSetPdfRenderer _renderer;

    public CardCreatorService(
        ICardSetLoader loader,
        ICardSetValidator validator,
        ITemplateCatalog templateCatalog,
        ISheetLayoutCalculator sheetLayoutCalculator,
        ICardSetPdfRenderer renderer)
    {
        _loader = loader;
        _validator = validator;
        _templateCatalog = templateCatalog;
        _sheetLayoutCalculator = sheetLayoutCalculator;
        _renderer = renderer;
    }

    public PreparedCardSet Prepare(string jsonFilePath)
    {
        throw new NotImplementedException();
    }

    public void Generate(PreparedCardSet cardSet)
    {
        throw new NotImplementedException();
    }
}
