using System;
using System.Collections.Generic;

namespace CDCP.Configuration
{
  [Serializable]
  public class FieldConfig : ConfigBase
  {
    public override void LoadDefaults()
    {
      base.LoadDefaults();
      VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public, Visibility.Protected, Visibility.ProtectedInternal, Visibility.Internal };
    }
  }
}