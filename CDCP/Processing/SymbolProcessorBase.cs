using System.Collections.Generic;
using CDCP.Configuration;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CDCP.Processing
{
  internal abstract class SymbolProcessorBase : ISymbolProcessor
  {
    void ISymbolProcessor.Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
    {
      Process(symbol, policyConfig, violationReporter);
    }

    protected abstract void Process(ISymbol symbol, PolicyConfig policyConfig, IViolationReporter violationReporter);

    protected void ProcessChildren(INamespaceOrTypeSymbol namespaceOrTypeSymbol, PolicyConfig policyConfig, IViolationReporter violationReporter)
    {
      foreach (ISymbol childSymbol in namespaceOrTypeSymbol.GetMembers())
        new CodeCommentsFacade().GetSymbolProcessorFactory().CreateSymbolProcessor(childSymbol).Process(childSymbol, policyConfig, violationReporter);
    }

    protected bool AnyVisibilityMatches(Accessibility accessibility, IEnumerable<Visibility> visibility)
    {
      return visibility.Any(v => v == VisibilityMapper.ToVisibility(accessibility));
    }

    protected Violation ViolationFromSymbol(string message, ISymbol symbol)
    {
      Location symbolLocation = symbol.Locations.First();
      FileLinePositionSpan lineSpan = symbolLocation.SourceTree.GetLineSpan(symbolLocation.SourceSpan);

      return new Violation
      {
        Message = message,
        Line = lineSpan.StartLinePosition.Line + 1,
        Column = lineSpan.StartLinePosition.Character + 1,
        Filepath = lineSpan.Path,
        Namespace = GetNamespace(symbol.ContainingNamespace),
        ContainingTypeName = GetParentSymbolName(symbol),
        SymbolName = symbol.Name,
      };
    }

    private string GetParentSymbolName(ISymbol currentSymbol)
    {
      if (currentSymbol.ContainingType != null)
        return string.Format("{0}.{1}", GetParentSymbolName(currentSymbol.ContainingType), currentSymbol.ContainingType.Name).TrimStart('.');

      return null;
    }

    private string GetNamespace(INamespaceSymbol namespaceSymbol)
    {
      if (namespaceSymbol.ContainingNamespace != null)
        return string.Format("{0}.{1}", GetNamespace(namespaceSymbol.ContainingNamespace), namespaceSymbol.Name).TrimStart('.');

      return namespaceSymbol.Name;
    }
  }
}