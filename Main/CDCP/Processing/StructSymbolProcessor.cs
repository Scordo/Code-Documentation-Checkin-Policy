using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  internal class StructSymbolProcessor : NamedTypeSymbolProcessorBase
  {
    protected override TypeKind TypeKind
    {
      get { return TypeKind.Struct; }
    }

    protected override void ProcessInternal(INamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
    {
      ClassConfig config = policyConfig.StructConfig;

      if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck))
        return;

      IDocumentationComment classDocumentation = symbol.GetDocumentationComment();

      if (config.SampleDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.ExampleText))
        violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSampleDocumentation, symbol));

      if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.SummaryText))
        violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

      if (!symbol.TypeParameters.IsEmpty && config.GenericParameterDocumentationRequired)
      {
        foreach (ITypeParameterSymbol typeParameter in symbol.TypeParameters)
        {
          if (string.IsNullOrWhiteSpace(classDocumentation.GetTypeParameterText(typeParameter.Name)))
            violationReporter.Report(ViolationFromSymbol(string.Format(ViolationMessage.MissingTypeParameter, typeParameter.Name), symbol));
        }
      }

      ProcessChildren(symbol, policyConfig, violationReporter);
    }
  }
}