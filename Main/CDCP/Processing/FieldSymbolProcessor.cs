using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class FieldSymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            FieldConfig config = policyConfig.FieldConfig;
			
            if ((!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) || !symbol.CanBeReferencedByName))
                return;
            
            DocumentationComment documentation = symbol.GetDocumentationComment();

            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
        }
    }
}