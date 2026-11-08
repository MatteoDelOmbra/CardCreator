using CardCreator.Core.Rendering.Text;
using CardCreator.Core.Templates;
using PdfSharp.Drawing;

namespace CardCreator.Core.Rendering;

public class CardBackRenderer : ICardBackRenderer
{
    private readonly ITextFitter _textFitter;

    public CardBackRenderer(ITextFitter textFitter)
    {
        _textFitter = textFitter;
    }

    public void Draw(XGraphics graphics, XRect bleedBox, ResolvedTemplate template)
    {
        throw new NotImplementedException();
    }
}
