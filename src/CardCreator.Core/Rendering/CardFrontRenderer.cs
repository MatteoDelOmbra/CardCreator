using CardCreator.Core.Input;
using CardCreator.Core.Rendering.Text;
using CardCreator.Core.Templates;
using PdfSharp.Drawing;

namespace CardCreator.Core.Rendering;

public class CardFrontRenderer : ICardFrontRenderer
{
    private readonly IMarkdownParser _markdownParser;
    private readonly ITextFitter _textFitter;

    public CardFrontRenderer(IMarkdownParser markdownParser, ITextFitter textFitter)
    {
        _markdownParser = markdownParser;
        _textFitter = textFitter;
    }

    public void Draw(XGraphics graphics, XRect bleedBox, CardEntry card, ResolvedTemplate template)
    {
        throw new NotImplementedException();
    }
}
