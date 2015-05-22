using CDCP.Configuration;

namespace CDCP.UI
{
  public class StructsConfigControl : ClassesConfigControl
  {
    protected override ClassConfig GetConfig(PolicyConfig config)
    {
      return config.StructConfig;
    }
  }
}