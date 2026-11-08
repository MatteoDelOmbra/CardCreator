using PdfSharp.Drawing;

namespace CardCreator.Core.Rendering.Text;

public interface ITextFitter
{
    /// <summary>
    /// Returns the largest font size (from <paramref name="startFontSize"/> down to the minimum, in fixed steps)
    /// at which the text fits into the given area.
    /// </summary>
    TextFitResult Fit(XGraphics graphics, FormattedText text, string fontFamily, double startFontSize, XRect area);
}
