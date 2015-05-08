using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public class DelegateConfig : ConfigBase
  {
    public bool SampleDocumentationRequired { get; set; }
    public bool ParameterDocumentationRequired { get; set; }
    public bool GenericParameterDocumentationRequired { get; set; }
    public bool ResultDocumentationRequired { get; set; }

    public static DelegateConfig GetDefault()
    {
      return new DelegateConfig
      {
        VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal },
        SampleDocumentationRequired = false,
        SummaryDocumentationRequired = true,
        ParameterDocumentationRequired = true,
        GenericParameterDocumentationRequired = true,
        ResultDocumentationRequired = true
      };
    }
  }
}
