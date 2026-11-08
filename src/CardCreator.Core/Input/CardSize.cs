namespace CardCreator.Core.Input;

/// <summary>
/// Final (trimmed) card size in millimetres, written as WIDTHxHEIGHTmm, e.g. "63x88mm".
/// Width greater than height means a landscape card.
/// </summary>
public readonly record struct CardSize(double WidthMm, double HeightMm)
{
    public bool IsLandscape => WidthMm > HeightMm;

    public static CardSize Parse(string value)
    {
        throw new NotImplementedException();
    }

    public static bool TryParse(string? value, out CardSize size)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        throw new NotImplementedException();
    }
}
