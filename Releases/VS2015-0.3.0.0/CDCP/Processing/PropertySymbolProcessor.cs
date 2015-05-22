using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  internal class PropertySymbolProcessor : SymbolProcessorBase
  {
    protected override void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
    {
      PropertyConfig config = policyConfig.PropertyConfig;

      if (symbol.IsOverride && !config.DocumentOverrides)
        return;

      if (symbol.ContainingType != null && symbol.ContainingType.TypeKind == TypeKind.Interface && !config.InterfaceDeclarationDocumentationRequired)
        return;

      IPropertySymbol propertySymbol = (IPropertySymbol)symbol;

      if (!propertySymbol.CanBeReferencedByName && !config.ExplicitInterfacePropertyDocumentationRequired)
        return;

      if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) && propertySymbol.CanBeReferencedByName)
        return;

      IDocumentationComment documentation = symbol.GetDocumentationComment();

      if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryText))
        violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

      if (config.ResultDocumentationRequired && !propertySymbol.IsWriteOnly && string.IsNullOrWhiteSpace(documentation.ReturnsText))
        violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingReturnsDocumentation, symbol));
    }
  }
}