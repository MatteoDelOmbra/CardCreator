using CardCreator.Core.Input;

namespace CardCreator.Core.Layout;

public interface ISheetLayoutCalculator
{
    /// <summary>
    /// Calculates how cards (with bleed, touching each other) are placed on a page.
    /// For <see cref="PageOrientation.Auto"/> picks the orientation that fits more cards.
    /// </summary>
    SheetLayout Calculate(PageFormat pageFormat, PageOrientation orientation, CardSize cardSize);
}
