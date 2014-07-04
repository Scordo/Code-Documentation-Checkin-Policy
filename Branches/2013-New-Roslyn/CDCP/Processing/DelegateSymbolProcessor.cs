using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class DelegateSymbolProcessor : NamedTypeSymbolProcessorBase
    {
        protected override TypeKind TypeKind
        {
            get { return TypeKind.Delegate; }
        }

        protected override void ProcessInternal(NamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            DelegateConfig config = policyConfig.DelegateConfig;

            if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck))
                return;

            if (symbol.DelegateInvokeMethod == null)
                return;

            DocumentationComment documentation = symbol.GetDocumentationComment();

            if (config.SampleDocumentationRequired && string.IsNullOrWhiteSpace(documentation.ExampleTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSampleDocumentation, symbol));

            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

            if (config.ResultDocumentationRequired && !symbol.DelegateInvokeMethod.ReturnsVoid && string.IsNullOrWhiteSpace(documentation.ReturnsTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingReturnsDocumentation, symbol));

            if (config.ParameterDocumentationRequired && !symbol.DelegateInvokeMethod.Parameters.IsNullOrEmpty)
            {
                foreach (ParameterSymbol parameterSymbol in symbol.DelegateInvokeMethod.Parameters)
                {
                    if (string.IsNullOrWhiteSpace(documentation.GetParameterText(parameterSymbol.Name)))
                        violationReporter.Report(ViolationFromSymbol(string.Format(ViolationMessage.MissingParameter, parameterSymbol.Name), symbol));
                }
            }

            if (config.GenericParameterDocumentationRequired && !symbol.TypeParameters.IsNullOrEmpty)
            {
                foreach (TypeParameterSymbol typeParameter in symbol.TypeParameters)
                {
                    if (string.IsNullOrWhiteSpace(documentation.GetTypeParameterText(typeParameter.Name)))
                        violationReporter.Report(ViolationFromSymbol(string.Format(ViolationMessage.MissingTypeParameter, typeParameter.Name), symbol));
                }
            }
        }
    }
}