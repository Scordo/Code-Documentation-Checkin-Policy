using System.IO;

namespace CDCP.Tests
{
  public static class Util
  {
    public static string GetFileContent(string name)
    {
      using (StreamReader reader = new StreamReader(typeof(Util).Assembly.GetManifestResourceStream("CDCP.Tests.SampleCode." + name)))
      {
        return reader.ReadToEnd();
      }
    }
  }
}