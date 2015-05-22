using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public abstract class ConfigBase
  {
    public HashSet<Visibility> VisibilitiesToCheck { get; set; }
    public bool SummaryDocumentationRequired { get; set; }

    protected ConfigBase()
    {
      VisibilitiesToCheck = new HashSet<Visibility>();
    }

    public virtual void LoadDefaults()
    {
      VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal };
      SummaryDocumentationRequired = true;
    }

    public virtual void ToggleRuleActivation(bool activate)
    {
      SummaryDocumentationRequired = activate;
    }
  }
}
