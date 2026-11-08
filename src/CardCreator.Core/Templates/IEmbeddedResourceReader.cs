namespace CardCreator.Core.Templates;

public interface IEmbeddedResourceReader
{
    /// <summary>
    /// Lists resource paths (relative to the Templates folder, '/' separated) that start with the given prefix.
    /// </summary>
    IReadOnlyList<string> List(string prefix);

    Stream Open(string path);

    string ReadText(string path);

    byte[] ReadBytes(string path);
}
