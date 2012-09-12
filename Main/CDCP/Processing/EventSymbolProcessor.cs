using System.Reflection;
using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using System.Linq;

namespace CDCP.Processing
{
    internal class EventSymbolProcessor : SymbolProcessorBase
    {
        protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
        {
            EventConfig config = policyConfig.EventConfig;

			if (symbol.IsOverride && !config.DocumentOverrides)
				return;

			if (symbol.ContainingType != null && symbol.ContainingType.TypeKind == TypeKind.Interface && !config.InterfaceDeclarationDocumentationRequired)
				return;

			//Bug: for an explicit event implementation symbol.CanBeReferencedByName should return false but it does return true!
			if (!symbol.CanBeReferencedByName && !config.ExplicitInterfaceEventDocumentationRequired)
				return;

			if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) && symbol.CanBeReferencedByName)
                return;

			DocumentationComment documentation = GetDocumentationComment(symbol);

            if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryTextOpt))
                violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));
        }

		private static DocumentationComment GetDocumentationComment(Symbol symbol)
		{
			// return symbol.GetDocumentationComment(); // this is buggy in roslyn


			// this is a dirty workaround for a bug in roslyn
			try
			{
				SyntaxNode currentNode = GetCurrentSyntaxNode(symbol);
				SyntaxNode realEventNode = GetEventSyntaxNode(currentNode);
				DocumentationCommentSyntax documentationSyntax = (DocumentationCommentSyntax)realEventNode.GetLeadingTrivia().First(t => t.Kind == SyntaxKind.DocumentationComment).GetStructure();

				return DocumentationComment.FromXmlFragment(documentationSyntax.GetInteriorXml());
			}
			catch
			{
				return symbol.GetDocumentationComment();
			}
		}

		private static SyntaxNode GetEventSyntaxNode(SyntaxNode currentNode)
		{
			while (currentNode != null)
			{
				if (currentNode.Kind == SyntaxKind.EventFieldDeclaration || currentNode.Kind == SyntaxKind.EventDeclaration)
					return currentNode;

				currentNode = currentNode.Parent;
			}

			return null;
		}

		private static SyntaxNode GetCurrentSyntaxNode(Symbol symbol)
		{
			try
			{
				return (SyntaxNode)symbol.GetType().GetProperty("SyntaxNode", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(symbol, null);
			}
			catch
			{
				return null;
			}
		}
    }
}