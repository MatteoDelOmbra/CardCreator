using CardCreator.Core.Input;
using CardCreator.Core.Templates;
using PdfSharp.Drawing;

namespace CardCreator.Core.Rendering;

public interface ICardFrontRenderer
{
    /// <param name="bleedBox">Card area including bleed, in points.</param>
    void Draw(XGraphics graphics, XRect bleedBox, CardEntry card, ResolvedTemplate template);
}
