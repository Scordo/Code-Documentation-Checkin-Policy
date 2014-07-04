using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class ClassSymbolProcessor : NamedTypeSymbolProcessorBase
    {
        protected override TypeKind TypeKind
        {
            get { return TypeKind.Class; }
        }

        protected override void ProcessInternal(NamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            ClassConfig classConfig = policyConfig.ClassConfig;

            if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, classConfig.VisibilitiesToCheck))
                return;

            DocumentationComment classDocumentation = symbol.GetDocumentationComment();

            if (classConfig.SampleDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.ExampleTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSampleDocumentation, symbol));

            if (classConfig.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

            if (!symbol.TypeParameters.IsNullOrEmpty && classConfig.GenericParameterDocumentationRequired)
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