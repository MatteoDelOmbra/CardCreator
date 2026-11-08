using CardCreator.Core.Templates;
using PdfSharp.Drawing;

namespace CardCreator.Core.Rendering;

public interface ICardBackRenderer
{
    /// <summary>Draws the theme back background with the card type name as a title.</summary>
    /// <param name="bleedBox">Card area including bleed, in points.</param>
    void Draw(XGraphics graphics, XRect bleedBox, ResolvedTemplate template);
}
