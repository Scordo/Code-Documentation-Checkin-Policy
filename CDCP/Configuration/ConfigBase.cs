using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public abstract class ConfigBase
  {
    public HashSet<Visibility> VisibilitiesToCheck { get; set; }
    public bool SummaryDocumentationRequired { get; set; }
  }
}
