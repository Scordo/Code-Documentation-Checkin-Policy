using System;

namespace CDCP.Configuration
{
  [Serializable]
  public class MethodConfig : DelegateConfig
  {
    public bool ExplicitInterfaceMethodDocumentationRequired { get; set; }
    public bool InterfaceDeclarationDocumentationRequired { get; set; }
    public bool DocumentOverrides { get; set; }

    public override void LoadDefaults()
    {
      base.LoadDefaults();
      SampleDocumentationRequired = false;
      ParameterDocumentationRequired = true;
      GenericParameterDocumentationRequired = true;
      ResultDocumentationRequired = true;
      InterfaceDeclarationDocumentationRequired = true;
      ExplicitInterfaceMethodDocumentationRequired = false;
      DocumentOverrides = false;
    }

    public override void ToggleRuleActivation(bool activate)
    {
      base.ToggleRuleActivation(activate);
      SampleDocumentationRequired = activate;
      ParameterDocumentationRequired = activate;
      GenericParameterDocumentationRequired = activate;
      ResultDocumentationRequired = activate;
      InterfaceDeclarationDocumentationRequired = activate;
      ExplicitInterfaceMethodDocumentationRequired = activate;
      DocumentOverrides = activate;
    }
  }
}