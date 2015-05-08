using System;
using Microsoft.CodeAnalysis;

namespace CDCP.Configuration
{
  public static class VisibilityMapper
  {
    public static Visibility ToVisibility(Accessibility accessibility)
    {
      switch (accessibility)
      {
        case Accessibility.Public:
          return Visibility.Public;
        case Accessibility.Protected:
          return Visibility.Protected;
        case Accessibility.ProtectedAndInternal:
          return Visibility.ProtectedInternal;
        case Accessibility.Internal:
          return Visibility.Internal;
        case Accessibility.Private:
          return Visibility.Private;
        default:
          throw new NotSupportedException(string.Format("Accessibility {0} is not supported", accessibility));
      }
    }
  }
}
