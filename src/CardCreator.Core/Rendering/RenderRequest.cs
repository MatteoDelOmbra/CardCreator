using CardCreator.Core.Input;
using CardCreator.Core.Layout;
using CardCreator.Core.Templates;

namespace CardCreator.Core.Rendering;

public record RenderRequest(
    string OutputFilePath,
    ResolvedTemplate Template,
    SheetLayout SheetLayout,
    IReadOnlyList<CardEntry> Cards,
    bool WithBacks);
