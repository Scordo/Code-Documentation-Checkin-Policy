using System.Reflection;
using CDCP.Configuration;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using System.Linq;

namespace CDCP.Processing
{
	internal class MethodSymbolProcessor : SymbolProcessorBase
	{
		private static readonly MethodKind[] AllowedMethodKinds = new[] { MethodKind.StaticConstructor, MethodKind.Constructor, MethodKind.Destructor, MethodKind.ExplicitInterfaceImplementation, MethodKind.Ordinary };

		protected override void Process(Symbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
		{
			MethodSymbol methodSymbol = (MethodSymbol) symbol;
			MethodConfig config = policyConfig.MethodConfig;

			if (methodSymbol.IsOverride && !config.DocumentOverrides)
				return;

			if (methodSymbol.MethodKind == MethodKind.ExplicitInterfaceImplementation && !config.ExplicitInterfaceMethodDocumentationRequired)
				return;

			if (!AnyVisibilityMatches(symbol.DeclaredAccessibility, config.VisibilitiesToCheck) && methodSymbol.MethodKind != MethodKind.ExplicitInterfaceImplementation)
				return;

			// skip compiler generated methods for which there is no source code
			if (symbol.IsImplicitlyDeclared)
				return;

			// skip special method kinds
			if (!AllowedMethodKinds.Contains(methodSymbol.MethodKind))
				return;

			//DocumentationComment documentation = symbol.GetDocumentationComment();
			MethodDocumentationComment documentation = GetDocumentationComment(symbol);

			if (config.SampleDocumentationRequired && string.IsNullOrWhiteSpace(documentation.ExampleTextOpt))
				violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSampleDocumentation, symbol));

			if (config.SummaryDocumentationRequired && string.IsNullOrWhiteSpace(documentation.SummaryTextOpt))
				violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingSummaryDocumentation, symbol));

			if (config.ResultDocumentationRequired && !methodSymbol.ReturnsVoid && string.IsNullOrWhiteSpace(documentation.ReturnsTextOpt))
				violationReporter.Report(ViolationFromSymbol(ViolationMessage.MissingReturnsDocumentation, symbol));

			if (config.ParameterDocumentationRequired && !methodSymbol.Parameters.IsNullOrEmpty)
			{
				foreach (ParameterSymbol parameterSymbol in methodSymbol.Parameters)
				{
					if (string.IsNullOrWhiteSpace(documentation.GetParameterText(parameterSymbol.Name)))
						violationReporter.Report(ViolationFromSymbol(string.Format(ViolationMessage.MissingParameter, parameterSymbol.Name), symbol));
				}
			}

			if (config.GenericParameterDocumentationRequired && !methodSymbol.TypeParameters.IsNullOrEmpty)
			{
				foreach (TypeParameterSymbol typeParameter in methodSymbol.TypeParameters)
				{
					if (string.IsNullOrWhiteSpace(documentation.GetTypeParameterText(typeParameter.Name)))
						violationReporter.Report(ViolationFromSymbol(string.Format("Missing documentation for type parameter with name '{0}'", typeParameter.Name), symbol));
				}
			}
		}

		private static MethodDocumentationComment GetDocumentationComment(Symbol symbol)
		{
			//DocumentationComment comment = symbol.GetDocumentationComment();


			// this is a dirty workaround for a bug in roslyn
			try
			{
				SyntaxNode realMethodNode = GetMethodSyntaxNode(GetCurrentSyntaxNode(symbol));
				SyntaxTrivia syntaxTrivia = realMethodNode.GetLeadingTrivia().First(t => t.Kind == SyntaxKind.DocumentationCommentTrivia);
				DocumentationCommentTriviaSyntax documentation = (DocumentationCommentTriviaSyntax)syntaxTrivia.GetStructure();

				return MethodDocumentationComment.FromXmlFragment(documentation.GetInteriorXml());
			}
			catch
			{
				MethodDocumentationComment documentationComment = new MethodDocumentationComment { HadXmlParseError = true };
				return documentationComment;
			}
		}

		private static SyntaxNode GetMethodSyntaxNode(SyntaxNode currentNode)
		{
			while (currentNode != null)
			{
				if (currentNode.Kind == SyntaxKind.MethodDeclaration || currentNode.Kind == SyntaxKind.ConstructorDeclaration)
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