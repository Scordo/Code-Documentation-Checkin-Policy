namespace CDCP.UI
{
    partial class ClassesConfigControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GenericParametersOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.SampleDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SummaryDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Visibilities = new CDCP.UI.VisibilityControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // GenericParametersOptionCheckBox
            // 
            this.GenericParametersOptionCheckBox.AutoSize = true;
            this.GenericParametersOptionCheckBox.Location = new System.Drawing.Point(165, 18);
            this.GenericParametersOptionCheckBox.Name = "GenericParametersOptionCheckBox";
            this.GenericParametersOptionCheckBox.Size = new System.Drawing.Size(118, 17);
            this.GenericParametersOptionCheckBox.TabIndex = 69;
            this.GenericParametersOptionCheckBox.Text = "Generic parameters";
            this.toolTip1.SetToolTip(this.GenericParametersOptionCheckBox, "When checked, non empty generic parameter descriptions are required.");
            this.GenericParametersOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // SampleDocumentationTagCheckBox
            // 
            this.SampleDocumentationTagCheckBox.AutoSize = true;
            this.SampleDocumentationTagCheckBox.Location = new System.Drawing.Point(96, 141);
            this.SampleDocumentationTagCheckBox.Name = "SampleDocumentationTagCheckBox";
            this.SampleDocumentationTagCheckBox.Size = new System.Drawing.Size(61, 17);
            this.SampleDocumentationTagCheckBox.TabIndex = 67;
            this.SampleDocumentationTagCheckBox.Text = "Sample";
            this.toolTip1.SetToolTip(this.SampleDocumentationTagCheckBox, "When checked, a non empty <example> tag is required");
            this.SampleDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(162, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Options:";
            // 
            // SummaryDocumentationTagCheckBox
            // 
            this.SummaryDocumentationTagCheckBox.AutoSize = true;
            this.SummaryDocumentationTagCheckBox.Location = new System.Drawing.Point(20, 141);
            this.SummaryDocumentationTagCheckBox.Name = "SummaryDocumentationTagCheckBox";
            this.SummaryDocumentationTagCheckBox.Size = new System.Drawing.Size(69, 17);
            this.SummaryDocumentationTagCheckBox.TabIndex = 63;
            this.SummaryDocumentationTagCheckBox.Text = "Summary";
            this.toolTip1.SetToolTip(this.SummaryDocumentationTagCheckBox, "When checked, a non empty <summar> tag is required");
            this.SummaryDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Required documentation tags:";
            // 
            // Visibilities
            // 
            this.Visibilities.Location = new System.Drawing.Point(9, 2);
            this.Visibilities.Name = "Visibilities";
            this.Visibilities.Size = new System.Drawing.Size(150, 115);
            this.Visibilities.TabIndex = 61;
            // 
            // ClassesConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenericParametersOptionCheckBox);
            this.Controls.Add(this.SampleDocumentationTagCheckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SummaryDocumentationTagCheckBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Visibilities);
            this.Name = "ClassesConfigControl";
            this.Size = new System.Drawing.Size(350, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox GenericParametersOptionCheckBox;
        private System.Windows.Forms.CheckBox SampleDocumentationTagCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox SummaryDocumentationTagCheckBox;
        private System.Windows.Forms.Label label17;
        private VisibilityControl Visibilities;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
