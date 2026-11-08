namespace CardCreator.Core.Layout;

/// <summary>Output page format in portrait dimensions (millimetres).</summary>
public record PageFormat(string Name, double WidthMm, double HeightMm)
{
    public static readonly PageFormat A4 = new("A4", 210, 297);

    public static IReadOnlyList<PageFormat> Supported { get; } = [A4];

    public static bool TryGet(string name, out PageFormat? format)
    {
        throw new NotImplementedException();
    }
}
