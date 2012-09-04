using System;
using CDCP.Configuration;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class NamespaceSymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            if (symbol.Kind != SymbolKind.Namespace)
                throw new ArgumentException(string.Format("symbol is not of kind: Namespace. It's of type: {0}", symbol.Kind));

			ProcessChildren((NamespaceSymbol)symbol, policyConfig, violationReporter);
        }
    }
}