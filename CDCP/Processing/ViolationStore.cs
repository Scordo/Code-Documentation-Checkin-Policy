using System.Collections.Generic;

namespace CDCP.Processing
{
    public class ViolationStore : IViolationReporter
    {
        private readonly List<Violation> _violations = new List<Violation>();

        public IEnumerable<Violation> Violations 
        { 
            get { return _violations; }
        }

        void IViolationReporter.Report(Violation violation)
        {
            if (violation != null)
                _violations.Add(violation);
        }

        public bool HasViolations { get { return _violations.Count > 0; }}
    }
}