using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class PropertySymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            PropertyConfig config = policyConfig.PropertyConfig;

			if (symbol.IsOverride && !config.DocumentOverrides)
				return;

			if (symbol.ContainingType != null && symbol.ContainingType.TypeKind == TypeKind.Interface && !config.InterfaceDeclarationDocumentationRequired)
				return;
            
            PropertySymbol propertySymbol = (PropertySymbol)symbol;

            if (!propertySymbol.CanBeReferencedByName && !config.ExplicitInterfacePropertyDocumentationRequired)
                return;

            if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) && propertySymbol.CanBeReferencedByName)
                return;
            
            DocumentationComment documentation = symbol.GetDocumentationComment();
            
            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

            if (config.ResultDocumentationRequired && !propertySymbol.IsWriteOnly && string.IsNullOrWhiteSpace(documentation.ReturnsTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingReturnsDocumentation, symbol));
        }
    }
}