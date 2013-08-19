using Roslyn.Compilers.CSharp;

namespace CDCP.Processing
{
    public class SymbolProcessorFactory : ISymbolProcessorFactory
    {
        ISymbolProcessor ISymbolProcessorFactory.CreateSymbolProcessor(Symbol symbol)
        {
            switch (symbol.Kind)
            {
                case SymbolKind.Namespace: 
                    return new NamespaceSymbolProcessor();
                case SymbolKind.NamedType:
                    return GetSymbolProcessorForNamedType((NamedTypeSymbol) symbol);
                case SymbolKind.Method:
                    return new MethodSymbolProcessor();
                case SymbolKind.Property:
                    return new PropertySymbolProcessor();
                case SymbolKind.Event:
                    return new EventSymbolProcessor();
                case SymbolKind.Field:
                    return new FieldSymbolProcessor();
                default:
                    return new UnsupportedSymbolProcessory();
            }
        }

        private static ISymbolProcessor GetSymbolProcessorForNamedType(NamedTypeSymbol namedTypeSymbol)
        {
            switch (namedTypeSymbol.TypeKind)
            {
                case TypeKind.Class:
                    return new ClassSymbolProcessor();
                case TypeKind.Struct:
                    return new StructSymbolProcessor();
                case TypeKind.Enum:
                    return new EnumSymbolProcessor();
                case TypeKind.Delegate:
                    return new DelegateSymbolProcessor();
                case TypeKind.Interface:
                    return new InterfaceSymbolProcessor();
                default:
                    return new UnsupportedSymbolProcessory();
            }
        }
    }
}