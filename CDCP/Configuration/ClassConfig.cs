using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public class ClassConfig : ConfigBase
  {
    public bool SampleDocumentationRequired { get; set; }
    public bool GenericParameterDocumentationRequired { get; set; }

    public static ClassConfig GetDefault()
    {
      return new ClassConfig
      {
        VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
        SampleDocumentationRequired = false,
        SummaryDocumentationRequired = true,
        GenericParameterDocumentationRequired = true
      };
    }
  }
}
