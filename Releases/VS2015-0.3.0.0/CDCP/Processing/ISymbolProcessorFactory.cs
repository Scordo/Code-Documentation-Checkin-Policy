using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  public interface ISymbolProcessorFactory
  {
    ISymbolProcessor CreateSymbolProcessor(ISymbol symbol);
  }
}