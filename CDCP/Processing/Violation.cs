using System.Diagnostics;

namespace CDCP.Processing
{
  [DebuggerDisplay("[{Line}:{Column}] [{FullSymbolName}] {Message}")]
  public class Violation
  {
    public string Message { get; set; }
    public int Line { get; set; }
    public int Column { get; set; }
    public string Namespace { get; set; }
    public string SymbolName { get; set; }
    public string ContainingTypeName { get; set; }
    public string Filepath { get; set; }

    public string FullSymbolName
    {
      get
      {
        return string.Format("{0}{1}.{2}", Namespace, ContainingTypeName == null ? string.Empty : "." + ContainingTypeName, SymbolName);
      }
    }
  }
}