using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class EventSymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            EventConfig config = policyConfig.EventConfig;

			if (symbol.IsOverride && !config.DocumentOverrides)
				return;

			if (symbol.ContainingType != null && symbol.ContainingType.TypeKind == TypeKind.Interface && !config.InterfaceDeclarationDocumentationRequired)
				return;

			//Bug: for an explicit event implementation symbol.CanBeReferencedByName should return false but it does return true!
			if (!symbol.CanBeReferencedByName && !config.ExplicitInterfaceEventDocumentationRequired)
				return;

			if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) && symbol.CanBeReferencedByName)
                return;

            DocumentationComment documentation = symbol.GetDocumentationComment();

            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
        }
    }
}