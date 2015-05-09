using System.Collections.Generic;
using System.Linq;
using CDCP.Configuration;
using CDCP.Processing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDCP.Tests
{
  [TestClass]
  public class PropertyTests
  {
    [TestMethod]
    public void SinglePropertyWithNoSummary()
    {
      string fileContent = Util.GetFileContent("Properties.P1_No_Summary.cs");
      PolicyConfig config = GetDeactivatedConfig();

      config.PropertyConfig.SummaryDocumentationRequired = true;
      config.PropertyConfig.VisibilitiesToCheck = new HashSet<Visibility> {Visibility.Public};
      ViolationStore violationStore = new CodeCommentsFacade().CheckCodeDocumentation(fileContent, config);
      Assert.IsTrue(violationStore.HasViolations);
      Assert.AreEqual(1, violationStore.Violations.Count());
      Violation violation = violationStore.Violations.First();

      Assert.AreEqual(8, violation.Line);
      Assert.AreEqual(19, violation.Column);
      Assert.AreEqual("Name", violation.SymbolName);
    }
    
    private PolicyConfig GetDeactivatedConfig()
    {
      PolicyConfig config = new PolicyConfig();
      config.ToggleRuleActivation(false);
      config.ClassConfig.VisibilitiesToCheck = new HashSet<Visibility> { Visibility.Public };

      return config;
    }
  }
}
