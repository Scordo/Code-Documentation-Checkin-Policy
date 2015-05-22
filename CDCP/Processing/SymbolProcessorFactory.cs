using Microsoft.CodeAnalysis;

namespace CDCP.Processing
{
  public class SymbolProcessorFactory : ISymbolProcessorFactory
  {
    ISymbolProcessor ISymbolProcessorFactory.CreateSymbolProcessor(ISymbol symbol)
    {
      switch (symbol.Kind)
      {
        case SymbolKind.Namespace:
          return new NamespaceSymbolProcessor();
        case SymbolKind.NamedType:
          return GetSymbolProcessorForNamedType((INamedTypeSymbol)symbol);
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

    private static ISymbolProcessor GetSymbolProcessorForNamedType(INamedTypeSymbol namedTypeSymbol)
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