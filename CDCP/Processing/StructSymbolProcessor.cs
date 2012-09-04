using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class StructSymbolProcessor : NamedTypeSymbolProcessorBase
    {
        protected override TypeKind TypeKind
        {
            get { return TypeKind.Struct; }
        }

        protected override void ProcessInternal(NamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            ClassConfig config = policyConfig.StructConfig;

            if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck))
                return;

            DocumentationComment classDocumentation = symbol.GetDocumentationComment();

            if (config.SampleDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.ExampleTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSampleDocumentation, symbol));

            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

            if (!symbol.TypeParameters.IsNullOrEmpty && config.GenericParameterDocumentationRequired)
            {
                foreach (TypeParameterSymbol typeParameter in symbol.TypeParameters)
                {
                    if (string.IsNullOrWhiteSpace(classDocumentation.GetTypeParameterText(typeParameter.Name)))
                        violationReporter.Report(ViolationFromSymbol(string.Format(ViolationMessage.MissingTypeParameter, typeParameter.Name), symbol));
                }
            }

			ProcessChildren(symbol, policyConfig, violationReporter);
        }
    }
}