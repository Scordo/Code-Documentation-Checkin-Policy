using CDCP.Configuration;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    public interface ISymbolProcessor
    {
        void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter);
    }
}