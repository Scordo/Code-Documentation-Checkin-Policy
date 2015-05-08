using System;
using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
    internal abstract class NamedTypeSymbolProcessorBase : SymbolProcessorBase
    {
        protected abstract TypeKind TypeKind {get;}

		protected override void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            if (symbol.Kind != SymbolKind.NamedType)
                throw new ArgumentException(string.Format("symbol is not of kind: NamedType. It's of type: {0}", symbol.Kind));

            INamedTypeSymbol namedTypeSymbol = (INamedTypeSymbol)symbol;

            if (namedTypeSymbol.TypeKind != TypeKind)
                throw new ArgumentException(string.Format("symbol is not of typekind: {0}. It's of typekind: {1}", TypeKind, namedTypeSymbol.TypeKind));

            ProcessInternal(namedTypeSymbol, policyConfig, violationReporter);
        }

        protected abstract void ProcessInternal(INamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter);
    }
}