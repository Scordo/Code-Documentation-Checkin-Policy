using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    public interface ISymbolProcessorFactory
    {
        ISymbolProcessor CreateSymbolProcessor(Symbol symbol);
    }
}
