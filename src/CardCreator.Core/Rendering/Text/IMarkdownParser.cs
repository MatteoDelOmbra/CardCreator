namespace CardCreator.Core.Rendering.Text;

public interface IMarkdownParser
{
    /// <summary>Parses a limited Markdown subset (bold, italic, line breaks) into text runs.</summary>
    FormattedText Parse(string markdown);
}
