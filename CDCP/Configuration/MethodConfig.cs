using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public class MethodConfig : DelegateConfig
  {
    public bool ExplicitInterfaceMethodDocumentationRequired { get; set; }
    public bool InterfaceDeclarationDocumentationRequired { get; set; }
    public bool DocumentOverrides { get; set; }

    public static new MethodConfig GetDefault()
    {
      return new MethodConfig
      {
        VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
        SampleDocumentationRequired = false,
        SummaryDocumentationRequired = true,
        ParameterDocumentationRequired = true,
        GenericParameterDocumentationRequired = true,
        ResultDocumentationRequired = true,
        InterfaceDeclarationDocumentationRequired = true,
        ExplicitInterfaceMethodDocumentationRequired = false,
        DocumentOverrides = false
      };
    }
  }
}