namespace CardCreator.Core.Rendering;

public class CardSetPdfRenderer : ICardSetPdfRenderer
{
    private readonly ICardFrontRenderer _frontRenderer;
    private readonly ICardBackRenderer _backRenderer;
    private readonly ICutLineRenderer _cutLineRenderer;

    public CardSetPdfRenderer(
        ICardFrontRenderer frontRenderer,
        ICardBackRenderer backRenderer,
        ICutLineRenderer cutLineRenderer)
    {
        _frontRenderer = frontRenderer;
        _backRenderer = backRenderer;
        _cutLineRenderer = cutLineRenderer;
    }

    public void Render(RenderRequest request)
    {
        throw new NotImplementedException();
    }
}
