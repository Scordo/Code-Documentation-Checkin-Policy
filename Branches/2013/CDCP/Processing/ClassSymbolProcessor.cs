using CDCP.Configuration;
using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
    internal class ClassSymbolProcessor : NamedTypeSymbolProcessorBase
    {
        protected override TypeKind TypeKind
        {
            get { return TypeKind.Class; }
        }

        protected override void ProcessInternal(INamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            ClassConfig classConfig = policyConfig.ClassConfig;

            if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, classConfig.VisibilitiesToCheck))
                return;

            IDocumentationComment classDocumentation = symbol.GetDocumentationComment();

            if (classConfig.SampleDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.ExampleText))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSampleDocumentation, symbol));

            if (classConfig.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.SummaryText))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

            if (!symbol.TypeParameters.IsEmpty && classConfig.GenericParameterDocumentationRequired)
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