using CDCP.Processing;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace CDCP
{
    public class CodeDocumentationPolicyFailure : PolicyFailure
    {
        public Violation Violation { get; private set; }
        public PendingChange PendingChange { get; private set; }

        public CodeDocumentationPolicyFailure(Violation violation, PendingChange pendingChange, IPolicyEvaluation policyEvaluation) : base(GetMessage(violation), policyEvaluation)
        {
            Violation = violation;
            PendingChange = pendingChange;
        }

        private static string GetMessage(Violation violation)
        {
            return string.Format("[{0}:{1}] [{2}] {3}", violation.Line, violation.Column, violation.FullSymbolName, violation.Message);
        }
    }
}