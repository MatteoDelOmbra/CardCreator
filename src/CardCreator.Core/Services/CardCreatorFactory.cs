namespace CardCreator.Core.Services;

/// <summary>Wires up the default implementations without a DI container.</summary>
public static class CardCreatorFactory
{
    public static ICardCreatorService CreateService()
    {
        throw new NotImplementedException();
    }

    public static Templates.ITemplateCatalog CreateTemplateCatalog()
    {
        throw new NotImplementedException();
    }
}
