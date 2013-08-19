using CDCP.Configuration;

namespace CDCP.Processing
{
    internal class UnsupportedSymbolProcessory : SymbolProcessorBase
    {
        protected override void Process(Roslyn.Compilers.CSharp.Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            // intentionally do nothing
        }
    }
}