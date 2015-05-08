using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public class EventConfig : ConfigBase
  {
    public bool InterfaceDeclarationDocumentationRequired { get; set; }
    public bool ExplicitInterfaceEventDocumentationRequired { get; set; }
    public bool DocumentOverrides { get; set; }

    public static EventConfig GetDefault()
    {
      return new EventConfig
      {
        VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
        SummaryDocumentationRequired = true,
        InterfaceDeclarationDocumentationRequired = true,
        ExplicitInterfaceEventDocumentationRequired = false,
        DocumentOverrides = false
      };
    }
  }
}