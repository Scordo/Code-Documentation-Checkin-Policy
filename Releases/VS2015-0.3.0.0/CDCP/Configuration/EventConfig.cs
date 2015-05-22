using System;

namespace CDCP.Configuration
{
  [Serializable]
  public class EventConfig : ConfigBase
  {
    public bool InterfaceDeclarationDocumentationRequired { get; set; }
    public bool ExplicitInterfaceEventDocumentationRequired { get; set; }
    public bool DocumentOverrides { get; set; }

    public override void LoadDefaults()
    {
      base.LoadDefaults();
      InterfaceDeclarationDocumentationRequired = true;
      ExplicitInterfaceEventDocumentationRequired = false;
      DocumentOverrides = false;
    }

    public override void ToggleRuleActivation(bool activate)
    {
      base.ToggleRuleActivation(activate);
      InterfaceDeclarationDocumentationRequired = activate;
      ExplicitInterfaceEventDocumentationRequired = activate;
      DocumentOverrides = activate;
    }
  }
}