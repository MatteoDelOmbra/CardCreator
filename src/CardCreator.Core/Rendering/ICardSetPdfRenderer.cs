namespace CardCreator.Core.Rendering;

public interface ICardSetPdfRenderer
{
    /// <summary>
    /// Renders front pages (and, if requested, mirrored back pages interleaved: front 1, back 1, front 2, ...).
    /// </summary>
    void Render(RenderRequest request);
}
