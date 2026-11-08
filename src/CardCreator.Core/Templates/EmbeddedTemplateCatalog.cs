namespace CardCreator.Core.Templates;

public class EmbeddedTemplateCatalog : ITemplateCatalog
{
    private readonly IEmbeddedResourceReader _resourceReader;

    public EmbeddedTemplateCatalog(IEmbeddedResourceReader resourceReader)
    {
        _resourceReader = resourceReader;
    }

    public IReadOnlyList<string> GetGames()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> GetThemes(string game)
    {
        throw new NotImplementedException();
    }

    public string GetDefaultTheme(string game)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> GetCardTypes(string game)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> GetThemes(string game, string cardType)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> GetCardSizes(string game, string theme, string cardType)
    {
        throw new NotImplementedException();
    }

    public ResolvedTemplate Resolve(string game, string? theme, string cardType, string cardSize)
    {
        throw new NotImplementedException();
    }
}
