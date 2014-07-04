namespace CDCP.UI
{
    partial class FieldsConfigControl
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
            this.SummaryDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Visibilities = new CDCP.UI.VisibilityControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SummaryDocumentationTagCheckBox
            // 
            this.SummaryDocumentationTagCheckBox.AutoSize = true;
            this.SummaryDocumentationTagCheckBox.Location = new System.Drawing.Point(19, 141);
            this.SummaryDocumentationTagCheckBox.Name = "SummaryDocumentationTagCheckBox";
            this.SummaryDocumentationTagCheckBox.Size = new System.Drawing.Size(69, 17);
            this.SummaryDocumentationTagCheckBox.TabIndex = 41;
            this.SummaryDocumentationTagCheckBox.Text = "Summary";
            this.toolTip1.SetToolTip(this.SummaryDocumentationTagCheckBox, "When checked, a non empty <summar> tag is required");
            this.SummaryDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Required documentation tags:";
            // 
            // Visibilities
            // 
            this.Visibilities.Location = new System.Drawing.Point(8, 2);
            this.Visibilities.Name = "Visibilities";
            this.Visibilities.Size = new System.Drawing.Size(150, 115);
            this.Visibilities.TabIndex = 39;
            // 
            // FieldsConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SummaryDocumentationTagCheckBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Visibilities);
            this.Name = "FieldsConfigControl";
            this.Size = new System.Drawing.Size(350, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SummaryDocumentationTagCheckBox;
        private System.Windows.Forms.Label label17;
        private VisibilityControl Visibilities;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
