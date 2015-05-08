using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CDCP.Configuration;
using CDCP.Processing;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CDCP
{
  public class CodeCommentsFacade
  {
    public ViolationStore CheckFileDocumentation(string filePath, PolicyConfig policyConfig)
    {
      if (!File.Exists(filePath))
        throw new FileNotFoundException($"Could not find file '{filePath}'");

      SyntaxTree tree = CSharpSyntaxTree.ParseText(File.ReadAllText(filePath));

      return CheckFileDocumentation(tree, policyConfig);
    }

    public ViolationStore CheckCodeDocumentation(string csharpCode, PolicyConfig policyConfig)
    {
      if (csharpCode == null)
        throw new ArgumentNullException(nameof(csharpCode));

      SyntaxTree tree = CSharpSyntaxTree.ParseText(csharpCode);

      return CheckFileDocumentation(tree, policyConfig);
    }

    private ViolationStore CheckFileDocumentation(SyntaxTree tree, PolicyConfig policyConfig)
    {
      if (policyConfig == null)
        throw new ArgumentNullException(nameof(policyConfig));

      MetadataReference mscorlib = MetadataReference.CreateFromAssembly(typeof(object).Assembly);
      CSharpCompilation compilation = CSharpCompilation.Create(Guid.NewGuid().ToString("N")).AddReferences(mscorlib).AddSyntaxTrees(tree);
      IEnumerable<INamespaceOrTypeSymbol> allSymbols = compilation.GlobalNamespace.GetMembers().AsEnumerable().Where(m => m.Locations.Any(l => l.IsInSource));
      ISymbolProcessorFactory symbolFactory = GetSymbolProcessorFactory();

      ViolationStore result = new ViolationStore();

      foreach (INamespaceOrTypeSymbol symbol in allSymbols)
        symbolFactory.CreateSymbolProcessor(symbol).Process(symbol, policyConfig, result);

      return result;
    }

    public ISymbolProcessorFactory GetSymbolProcessorFactory()
    {
      return new SymbolProcessorFactory();
    }
  }
}