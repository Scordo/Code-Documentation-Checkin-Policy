using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    internal class EnumSymbolProcessor : NamedTypeSymbolProcessorBase
    {
        protected override TypeKind TypeKind
        {
            get { return TypeKind.Enum; }
        }

        protected override void ProcessInternal(NamedTypeSymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            EnumConfig enumConfig = policyConfig.EnumConfig;

            if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, enumConfig.VisibilitiesToCheck))
                return;

            DocumentationComment classDocumentation = symbol.GetDocumentationComment();

            if (enumConfig.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(classDocumentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
        }
    }
}