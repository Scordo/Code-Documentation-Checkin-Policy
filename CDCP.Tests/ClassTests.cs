using System.Collections.Generic;
using System.Linq;
using CDCP.Configuration;
using CDCP.Processing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDCP.Tests
{
  [TestClass]
  public class ClassTests
  {
    [TestMethod]
    public void SingleClassWithFilledSummary()
    {
      string fileContent = Util.GetFileContent("Single class with filled summary.txt");
      PolicyConfig config = PolicyConfig.GetDefault();

      ViolationStore violationStore = new CodeCommentsFacade().CheckCodeDocumentation(fileContent, config);
      Assert.IsFalse(violationStore.HasViolations);
    }

    [TestMethod]
    public void SingleClassWithEmptySummary()
    {
      string fileContent = Util.GetFileContent("Single class with empty summary.txt");
      PolicyConfig config = PolicyConfig.GetDefault();

      ViolationStore violationStore = new CodeCommentsFacade().CheckCodeDocumentation(fileContent, config);
      List<Violation> violations = violationStore.Violations.ToList();

      Assert.AreEqual(1, violations.Count);

      Violation classViolation = violations.First();

      Assert.AreEqual(Constants.MissingSummaryMessage, classViolation.Message);
      Assert.AreEqual("CDCP.Tests.SampleCode.Test1", classViolation.FullSymbolName);
    }
  }
}
