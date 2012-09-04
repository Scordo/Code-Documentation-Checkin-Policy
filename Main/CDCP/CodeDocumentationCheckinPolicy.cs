using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using CDCP.Configuration;
using CDCP.UI;
using EnvDTE;
using EnvDTE80;
using Microsoft.TeamFoundation.VersionControl.Client;

namespace CDCP
{
    [Serializable]
    public class CodeDocumentationCheckinPolicy : PolicyBase
    {
        #region Properties

        private string _serializedSettings;

        [NonSerialized]
        private PolicyConfig _config;

        public override string Type
        {
            get { return "Code Documentation Checkin Policy"; }
        }

        public override string TypeDescription
        {
            get { return "Prevents user from checking in undocumented code."; }
        }

        public override string Description
        {
            get { return "This Checkin Policy does check code documentation using the configured rule set."; }
        }

        public override bool CanEdit
        {
            get { return true; }
        }

        #endregion

        #region Public Methods

        public override bool Edit(IPolicyEditArgs policyEditArgs)
        {
            if (_config == null)
                _config = GetDeserializedSettings();

            using (PolicyConfigSettingsForm dialog = new PolicyConfigSettingsForm())
            {
                IPolicyConfigControl policyConfigControl = dialog;
                policyConfigControl.ReadFromConfig(_config);

                bool finishedWithOk = dialog.ShowDialog() == DialogResult.OK;

                if (finishedWithOk)
                    policyConfigControl.WriteToConfig(_config);

                _serializedSettings = GetSerializedSettings();
                return finishedWithOk;
            }
        }

        public override PolicyFailure[] Evaluate()
        {
            if (_config == null)
                _config = GetDeserializedSettings();

            List<PolicyFailure> failures = new List<PolicyFailure>();
            CodeCommentsFacade facade = new CodeCommentsFacade();
            
            foreach (PendingChange pendingChange in PendingCheckin.PendingChanges.CheckedPendingChanges.Where(IsNonDeletedCSharpSourceFile))
            {
                failures.AddRange(facade.CheckFileDocumentation(pendingChange.LocalItem, _config ?? PolicyConfig.GetDefault()).Violations.Select(v => new CodeDocumentationPolicyFailure(v, pendingChange, this)));
            }

            return failures.ToArray();
        }

        public override void Activate(PolicyFailure failure)
        {
            if (failure is CodeDocumentationPolicyFailure)
                OnPolicyFailureActivation((CodeDocumentationPolicyFailure) failure);
            else
                base.Activate(failure);
        }

        #endregion

        #region Non Public Methods

        private void OnPolicyFailureActivation(CodeDocumentationPolicyFailure policyFailure)
        {
            DTE2 ide = (DTE2)Marshal.GetActiveObject("VisualStudio.DTE.11.0");

            if (ide == null)
                return;

            Document document = ide.Documents.Open(policyFailure.Violation.Filepath);

            if (document == null)
                return;

            TextSelection selection = (TextSelection)document.Selection;

            if (selection == null)
                return;

            selection.GotoLine(policyFailure.Violation.Line, true);
        }

        private bool IsNonDeletedCSharpSourceFile(PendingChange pendingChange)
        {
            return pendingChange.ChangeType != ChangeType.Delete && ".cs".Equals(Path.GetExtension(pendingChange.FileName), StringComparison.InvariantCultureIgnoreCase);
        }

        private PolicyConfig GetDeserializedSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PolicyConfig));
            
            try
            {
                return (PolicyConfig) serializer.Deserialize(new StringReader(_serializedSettings));
            }
            catch (Exception)
            {
                return PolicyConfig.GetDefault();
            }
        }

        private string GetSerializedSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PolicyConfig));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, _config ?? PolicyConfig.GetDefault());

            return writer.ToString();
        }


        #endregion
    }
}