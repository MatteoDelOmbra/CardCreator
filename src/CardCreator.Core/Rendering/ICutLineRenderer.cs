using CardCreator.Core.Input;
using CardCreator.Core.Layout;
using PdfSharp.Drawing;

namespace CardCreator.Core.Rendering;

public interface ICutLineRenderer
{
    /// <summary>Draws full-length cut lines along the trim edges of all cards on the page.</summary>
    void Draw(XGraphics graphics, SheetLayout layout, CardSize cardSize);
}
