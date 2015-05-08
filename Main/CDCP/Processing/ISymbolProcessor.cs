using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  public interface ISymbolProcessor
  {
    void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter);
  }
}