using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
    internal class UnsupportedSymbolProcessory : SymbolProcessorBase
    {
        protected override void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            // intentionally do nothing
        }
    }
}