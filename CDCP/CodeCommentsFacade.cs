using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CDCP.Configuration;
using CDCP.Processing;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;

namespace CDCP
{
    public class CodeCommentsFacade
    {
        public ViolationStore CheckFileDocumentation(string filePath, PolicyConfig policyConfig)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(string.Format("Could not find file '{0}'", filePath));

            if (policyConfig == null)
                throw new ArgumentNullException("policyConfig");

            SyntaxTree tree = SyntaxTree.ParseCompilationUnit(File.ReadAllText(filePath), filePath);
            AssemblyFileReference mscorlib = new AssemblyFileReference(typeof(object).Assembly.Location);
            Compilation compilation = Compilation.Create(Guid.NewGuid().ToString("N")).AddReferences(mscorlib).AddSyntaxTrees(tree);
            IEnumerable<Symbol> allSymbols = compilation.GlobalNamespace.GetMembers().AsEnumerable().Where(m => m.Locations.Any(l => l.IsInSource));
            ISymbolProcessorFactory symbolFactory = GetSymbolProcessorFactory();
            
            ViolationStore result = new ViolationStore();
            
            foreach (Symbol symbol in allSymbols)
                symbolFactory.CreateSymbolProcessor(symbol).Process(symbol, policyConfig, result);

            return result;
        }

        public ISymbolProcessorFactory GetSymbolProcessorFactory()
        {
            return new SymbolProcessorFactory();
        }
    }
}
