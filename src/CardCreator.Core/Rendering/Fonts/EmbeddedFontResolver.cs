using CardCreator.Core.Templates;
using PdfSharp.Fonts;

namespace CardCreator.Core.Rendering.Fonts;

/// <summary>Resolves theme fonts from embedded template resources.</summary>
public class EmbeddedFontResolver : IFontResolver
{
    private readonly IEmbeddedResourceReader _resourceReader;

    public EmbeddedFontResolver(IEmbeddedResourceReader resourceReader)
    {
        _resourceReader = resourceReader;
    }

    public FontResolverInfo? ResolveTypeface(string familyName, bool bold, bool italic)
    {
        throw new NotImplementedException();
    }

    public byte[]? GetFont(string faceName)
    {
        throw new NotImplementedException();
    }
}
