using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public class PropertyConfig : FieldConfig
  {
    public bool ResultDocumentationRequired { get; set; }
    public bool ExplicitInterfacePropertyDocumentationRequired { get; set; }
    public bool InterfaceDeclarationDocumentationRequired { get; set; }
    public bool DocumentOverrides { get; set; }

    public static new PropertyConfig GetDefault()
    {
      return new PropertyConfig
      {
        VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
        SummaryDocumentationRequired = true,
        ResultDocumentationRequired = true,
        ExplicitInterfacePropertyDocumentationRequired = false,
        InterfaceDeclarationDocumentationRequired = true,
        DocumentOverrides = false
      };
    }
  }
}