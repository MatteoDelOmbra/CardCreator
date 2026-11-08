using CardCreator.Core.Input;
using CardCreator.Core.Templates.Models;
using Newtonsoft.Json.Schema;

namespace CardCreator.Core.Templates;

/// <summary>
/// Everything needed to validate and render cards for one game + theme + card type + card size combination.
/// </summary>
/// <param name="ThemeFallback">Set when the requested theme was missing or unsupported and the default theme was used.</param>
public record ResolvedTemplate(
    GameTemplate Game,
    ThemeTemplate Theme,
    CardTypeTemplate CardType,
    CardSize CardSize,
    CardLayoutTemplate Layout,
    JSchema CardSchema,
    byte[] FrontBackground,
    byte[] BackBackground,
    ThemeFallback? ThemeFallback);
