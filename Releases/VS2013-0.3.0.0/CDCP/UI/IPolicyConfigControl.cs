using CDCP.Configuration;

namespace CDCP.UI
{
    interface IPolicyConfigControl
    {
        void ReadFromConfig(PolicyConfig config);
        void WriteToConfig(PolicyConfig config);
    }
}
