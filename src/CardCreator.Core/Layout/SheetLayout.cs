using CardCreator.Core.Input;

namespace CardCreator.Core.Layout;

/// <param name="Orientation">Resolved orientation, never <see cref="PageOrientation.Auto"/>.</param>
/// <param name="Slots">Card positions on the front page, in reading order.</param>
public record SheetLayout(
    PageFormat PageFormat,
    PageOrientation Orientation,
    double PageWidthMm,
    double PageHeightMm,
    int Columns,
    int Rows,
    IReadOnlyList<CardSlot> Slots)
{
    public int CardsPerPage => Columns * Rows;
}
