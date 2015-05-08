using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  internal class EventSymbolProcessor : SymbolProcessorBase
  {
    protected override void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
    {
      EventConfig config = policyConfig.EventConfig;

      if (symbol.IsOverride && !config.DocumentOverrides)
        return;

      if (symbol.ContainingType != null && symbol.ContainingType.TypeKind == TypeKind.Interface && !config.InterfaceDeclarationDocumentationRequired)
        return;

      if (!symbol.CanBeReferencedByName && !config.ExplicitInterfaceEventDocumentationRequired)
        return;

      if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) && symbol.CanBeReferencedByName)
        return;

      IDocumentationComment documentation = symbol.GetDocumentationComment();

      if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryText))
        violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
    }
  }
}