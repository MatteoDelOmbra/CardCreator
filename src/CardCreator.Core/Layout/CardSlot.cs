namespace CardCreator.Core.Layout;

/// <summary>
/// Position of a card on the page in millimetres. X/Y point to the top-left corner of the trimmed card (bleed excluded).
/// </summary>
public record CardSlot(int Column, int Row, double XMm, double YMm);
