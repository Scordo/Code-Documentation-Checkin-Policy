using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
    internal class FieldSymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            FieldConfig config = policyConfig.FieldConfig;
			
            if ((!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) || !symbol.CanBeReferencedByName))
                return;
            
            IDocumentationComment documentation = symbol.GetDocumentationComment();

            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryText))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
        }
    }
}