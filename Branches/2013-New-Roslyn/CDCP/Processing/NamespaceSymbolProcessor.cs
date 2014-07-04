using System;
using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
    internal class NamespaceSymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            if (symbol.Kind != SymbolKind.Namespace)
                throw new ArgumentException(string.Format("symbol is not of kind: Namespace. It's of type: {0}", symbol.Kind));

			ProcessChildren((INamespaceSymbol)symbol, policyConfig, violationReporter);
        }
    }
}