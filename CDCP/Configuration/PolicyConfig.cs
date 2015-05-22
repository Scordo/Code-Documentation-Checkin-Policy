using System;

namespace CDCP.Configuration
{
  [Serializable]
  public class PolicyConfig
  {
    public ClassConfig ClassConfig { get; set; }
    public ClassConfig StructConfig { get; set; }
    public ClassConfig InterfaceConfig { get; set; }
    public DelegateConfig DelegateConfig { get; set; }
    public MethodConfig MethodConfig { get; set; }
    public EventConfig EventConfig { get; set; }
    public FieldConfig FieldConfig { get; set; }
    public PropertyConfig PropertyConfig { get; set; }
    public EnumConfig EnumConfig { get; set; }
    public bool SkipMerges { get; set; }
    public bool SkipBranches { get; set; }
    public bool SkipRollbacks { get; set; }
    public bool SkipUndeletes { get; set; }

    public PolicyConfig()
    {
      ClassConfig = new ClassConfig();
      StructConfig = new ClassConfig();
      InterfaceConfig = new ClassConfig();
      DelegateConfig = new DelegateConfig();
      MethodConfig = new MethodConfig();
      EventConfig = new EventConfig();
      FieldConfig = new FieldConfig();
      PropertyConfig = new PropertyConfig();
      EnumConfig = new EnumConfig();
    }

    public PolicyConfig LoadDefaults()
    {
      ClassConfig.LoadDefaults();
      StructConfig.LoadDefaults();
      InterfaceConfig.LoadDefaults();
      DelegateConfig.LoadDefaults();
      MethodConfig.LoadDefaults();
      EventConfig.LoadDefaults();
      FieldConfig.LoadDefaults();
      PropertyConfig.LoadDefaults();
      EnumConfig.LoadDefaults();
      
      SkipMerges = true;
      SkipBranches = true;
      SkipRollbacks = true;
      SkipUndeletes = true;

      return this;
    }

    public void ToggleRuleActivation(bool activate, bool recursive = true)
    {
      SkipMerges = activate;
      SkipBranches = activate;
      SkipRollbacks = activate;
      SkipUndeletes = activate;

      if (!recursive)
        return;

      ClassConfig.ToggleRuleActivation(activate);
      StructConfig.ToggleRuleActivation(activate);
      InterfaceConfig.ToggleRuleActivation(activate);
      DelegateConfig.ToggleRuleActivation(activate);
      MethodConfig.ToggleRuleActivation(activate);
      EventConfig.ToggleRuleActivation(activate);
      FieldConfig.ToggleRuleActivation(activate);
      PropertyConfig.ToggleRuleActivation(activate);
      EnumConfig.ToggleRuleActivation(activate);
    }
  }
}