namespace CDCP.UI
{
    partial class DelegateConfigControl
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
            this.ParametersOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.SampleDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnsDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.GenericParametersOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SummaryDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Visibilities = new CDCP.UI.VisibilityControl();
            this.SuspendLayout();
            // 
            // ParametersOptionCheckBox
            // 
            this.ParametersOptionCheckBox.AutoSize = true;
            this.ParametersOptionCheckBox.Location = new System.Drawing.Point(164, 18);
            this.ParametersOptionCheckBox.Name = "ParametersOptionCheckBox";
            this.ParametersOptionCheckBox.Size = new System.Drawing.Size(79, 17);
            this.ParametersOptionCheckBox.TabIndex = 69;
            this.ParametersOptionCheckBox.Text = "Parameters";
            this.ParametersOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // SampleDocumentationTagCheckBox
            // 
            this.SampleDocumentationTagCheckBox.AutoSize = true;
            this.SampleDocumentationTagCheckBox.Location = new System.Drawing.Point(164, 141);
            this.SampleDocumentationTagCheckBox.Name = "SampleDocumentationTagCheckBox";
            this.SampleDocumentationTagCheckBox.Size = new System.Drawing.Size(61, 17);
            this.SampleDocumentationTagCheckBox.TabIndex = 68;
            this.SampleDocumentationTagCheckBox.Text = "Sample";
            this.SampleDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReturnsDocumentationTagCheckBox
            // 
            this.ReturnsDocumentationTagCheckBox.AutoSize = true;
            this.ReturnsDocumentationTagCheckBox.Location = new System.Drawing.Point(95, 141);
            this.ReturnsDocumentationTagCheckBox.Name = "ReturnsDocumentationTagCheckBox";
            this.ReturnsDocumentationTagCheckBox.Size = new System.Drawing.Size(63, 17);
            this.ReturnsDocumentationTagCheckBox.TabIndex = 67;
            this.ReturnsDocumentationTagCheckBox.Text = "Returns";
            this.ReturnsDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenericParametersOptionCheckBox
            // 
            this.GenericParametersOptionCheckBox.AutoSize = true;
            this.GenericParametersOptionCheckBox.Location = new System.Drawing.Point(164, 36);
            this.GenericParametersOptionCheckBox.Name = "GenericParametersOptionCheckBox";
            this.GenericParametersOptionCheckBox.Size = new System.Drawing.Size(118, 17);
            this.GenericParametersOptionCheckBox.TabIndex = 65;
            this.GenericParametersOptionCheckBox.Text = "Generic parameters";
            this.GenericParametersOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(161, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Options:";
            // 
            // SummaryDocumentationTagCheckBox
            // 
            this.SummaryDocumentationTagCheckBox.AutoSize = true;
            this.SummaryDocumentationTagCheckBox.Location = new System.Drawing.Point(19, 141);
            this.SummaryDocumentationTagCheckBox.Name = "SummaryDocumentationTagCheckBox";
            this.SummaryDocumentationTagCheckBox.Size = new System.Drawing.Size(69, 17);
            this.SummaryDocumentationTagCheckBox.TabIndex = 63;
            this.SummaryDocumentationTagCheckBox.Text = "Summary";
            this.SummaryDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Required documentation tags:";
            // 
            // Visibilities
            // 
            this.Visibilities.Location = new System.Drawing.Point(8, 2);
            this.Visibilities.Name = "Visibilities";
            this.Visibilities.Size = new System.Drawing.Size(150, 115);
            this.Visibilities.TabIndex = 61;
            // 
            // DelegateConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParametersOptionCheckBox);
            this.Controls.Add(this.SampleDocumentationTagCheckBox);
            this.Controls.Add(this.ReturnsDocumentationTagCheckBox);
            this.Controls.Add(this.GenericParametersOptionCheckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SummaryDocumentationTagCheckBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Visibilities);
            this.Name = "DelegateConfigControl";
            this.Size = new System.Drawing.Size(350, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ParametersOptionCheckBox;
        private System.Windows.Forms.CheckBox SampleDocumentationTagCheckBox;
        private System.Windows.Forms.CheckBox ReturnsDocumentationTagCheckBox;
        private System.Windows.Forms.CheckBox GenericParametersOptionCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox SummaryDocumentationTagCheckBox;
        private System.Windows.Forms.Label label17;
        private VisibilityControl Visibilities;
    }
}
