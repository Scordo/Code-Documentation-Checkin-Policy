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

        public static PolicyConfig GetDefault()
        {
            return new PolicyConfig
            {
                ClassConfig = ClassConfig.GetDefault(),
                StructConfig = ClassConfig.GetDefault(),
                InterfaceConfig = ClassConfig.GetDefault(),
                DelegateConfig = DelegateConfig.GetDefault(),
                MethodConfig = MethodConfig.GetDefault(),
                EventConfig = EventConfig.GetDefault(),
                FieldConfig = FieldConfig.GetDefault(),
                PropertyConfig = PropertyConfig.GetDefault(),
                EnumConfig = EnumConfig.GetDefault()
            };
        }
    }
}