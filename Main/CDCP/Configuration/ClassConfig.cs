using System;

namespace CDCP.Configuration
{
  [Serializable]
  public class ClassConfig : ConfigBase
  {
    public bool SampleDocumentationRequired { get; set; }
    public bool GenericParameterDocumentationRequired { get; set; }


    public override void LoadDefaults()
    {
      base.LoadDefaults();
      SampleDocumentationRequired = false;
      GenericParameterDocumentationRequired = true;
    }

    public override void ToggleRuleActivation(bool activate)
    {
      base.ToggleRuleActivation(activate);
      SampleDocumentationRequired = activate;
      SummaryDocumentationRequired = activate;
      GenericParameterDocumentationRequired = activate;
    }
  }
}