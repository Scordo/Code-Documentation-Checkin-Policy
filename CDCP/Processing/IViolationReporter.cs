namespace CDCP.Processing
{
  public interface IViolationReporter
  {
    void Report(Violation violation);
  }
}