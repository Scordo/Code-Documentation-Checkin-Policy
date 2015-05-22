using System;

namespace CDCP.Configuration
{
  [Serializable]
  public class DelegateConfig : ConfigBase
  {
    public bool SampleDocumentationRequired { get; set; }
    public bool ParameterDocumentationRequired { get; set; }
    public bool GenericParameterDocumentationRequired { get; set; }
    public bool ResultDocumentationRequired { get; set; }

    public override void LoadDefaults()
    {
      base.LoadDefaults();
      SampleDocumentationRequired = false;
      ParameterDocumentationRequired = true;
      GenericParameterDocumentationRequired = true;
      ResultDocumentationRequired = true;
    }

    public override void ToggleRuleActivation(bool activate)
    {
      base.ToggleRuleActivation(activate);
      SampleDocumentationRequired = activate;
      ParameterDocumentationRequired = activate;
      GenericParameterDocumentationRequired = activate;
      ResultDocumentationRequired = activate;
    }
  }
}