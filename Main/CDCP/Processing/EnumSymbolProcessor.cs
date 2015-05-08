using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  internal class EnumSymbolProcessor : NamedTypeSymbolProcessorBase
  {
    protected override TypeKind TypeKind
    {
      get { return TypeKind.Enum; }
    }

    protected override void ProcessInternal(INamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
    {
      EnumConfig enumConfig = policyConfig.EnumConfig;

      if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, enumConfig.VisibilitiesToCheck))
        return;

      IDocumentationComment classDocumentation = symbol.GetDocumentationComment();

      if (enumConfig.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.SummaryText))
        violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
    }
  }
}