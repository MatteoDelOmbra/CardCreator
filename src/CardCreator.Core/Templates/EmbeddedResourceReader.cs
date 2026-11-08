using System.Reflection;

namespace CardCreator.Core.Templates;

public class EmbeddedResourceReader : IEmbeddedResourceReader
{
    private readonly Assembly _assembly;

    public EmbeddedResourceReader() : this(typeof(EmbeddedResourceReader).Assembly) { }

    public EmbeddedResourceReader(Assembly assembly)
    {
        _assembly = assembly;
    }

    public IReadOnlyList<string> List(string prefix)
    {
        throw new NotImplementedException();
    }

    public Stream Open(string path)
    {
        throw new NotImplementedException();
    }

    public string ReadText(string path)
    {
        throw new NotImplementedException();
    }

    public byte[] ReadBytes(string path)
    {
        throw new NotImplementedException();
    }
}
