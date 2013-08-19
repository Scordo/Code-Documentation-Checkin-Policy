using CDCP.Configuration;

namespace CDCP.UI
{
    public class InterfacesConfigControl : ClassesConfigControl
    {
        protected override ClassConfig GetConfig(PolicyConfig config)
        {
            return config.InterfaceConfig;
        }
    }
}