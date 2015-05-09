using System;

namespace CDCP.Configuration
{
  [Serializable]
  public class PropertyConfig : FieldConfig
  {
    public bool ResultDocumentationRequired { get; set; }
    public bool ExplicitInterfacePropertyDocumentationRequired { get; set; }
    public bool InterfaceDeclarationDocumentationRequired { get; set; }
    public bool DocumentOverrides { get; set; }

    public override void LoadDefaults()
    {
      base.LoadDefaults();
      ResultDocumentationRequired = true;
      ExplicitInterfacePropertyDocumentationRequired = false;
      InterfaceDeclarationDocumentationRequired = true;
      DocumentOverrides = false;
    }

    public override void ToggleRuleActivation(bool activate)
    {
      base.ToggleRuleActivation(activate);
      ResultDocumentationRequired = activate;
      ExplicitInterfacePropertyDocumentationRequired = activate;
      InterfaceDeclarationDocumentationRequired = activate;
      DocumentOverrides = activate;
    }
  }
}