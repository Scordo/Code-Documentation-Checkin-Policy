using System;
using CDCP.Configuration;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal abstract class NamedTypeSymbolProcessorBase : SymbolProcessorBase
    {
        protected abstract TypeKind TypeKind {get;}

		protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            if (symbol.Kind != SymbolKind.NamedType)
                throw new ArgumentException(string.Format("symbol is not of kind: NamedType. It's of type: {0}", symbol.Kind));

            NamedTypeSymbol namedTypeSymbol = (NamedTypeSymbol)symbol;

            if (namedTypeSymbol.TypeKind != TypeKind)
                throw new ArgumentException(string.Format("symbol is not of typekind: {0}. It's of typekind: {1}", TypeKind, namedTypeSymbol.TypeKind));

            ProcessInternal(namedTypeSymbol, policyConfig, violationReporter);
        }

        protected abstract void ProcessInternal(NamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter);
    }
}