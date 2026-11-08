namespace CardCreator.Core.Templates;

/// <summary>
/// Provides the supported games, themes, card types and card sizes embedded in the library.
/// </summary>
public interface ITemplateCatalog
{
    IReadOnlyList<string> GetGames();

    IReadOnlyList<string> GetThemes(string game);

    string GetDefaultTheme(string game);

    IReadOnlyList<string> GetCardTypes(string game);

    IReadOnlyList<string> GetThemes(string game, string cardType);

    IReadOnlyList<string> GetCardSizes(string game, string theme, string cardType);

    /// <param name="theme">
    /// Requested theme. Null, or a theme not supported by the card type, falls back to the game's default theme.
    /// </param>
    ResolvedTemplate Resolve(string game, string? theme, string cardType, string cardSize);
}
