namespace CardCreator.Core.Rendering.Text;

public record FormattedText(IReadOnlyList<Paragraph> Paragraphs);

public record Paragraph(IReadOnlyList<TextRun> Runs);

public record TextRun(string Text, bool Bold, bool Italic);
