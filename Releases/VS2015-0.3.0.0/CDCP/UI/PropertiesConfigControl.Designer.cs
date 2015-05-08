namespace CDCP.UI
{
    partial class PropertiesConfigControl
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
            this.OverridesOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.ReturnsDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.InterfaceOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.ExplicitOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SummaryDocumentationTagCheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Visibilities = new CDCP.UI.VisibilityControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // OverridesOptionCheckBox
            // 
            this.OverridesOptionCheckBox.AutoSize = true;
            this.OverridesOptionCheckBox.Location = new System.Drawing.Point(164, 18);
            this.OverridesOptionCheckBox.Name = "OverridesOptionCheckBox";
            this.OverridesOptionCheckBox.Size = new System.Drawing.Size(71, 17);
            this.OverridesOptionCheckBox.TabIndex = 47;
            this.OverridesOptionCheckBox.Text = "Overrides";
            this.toolTip1.SetToolTip(this.OverridesOptionCheckBox, "When checked, then overriden ones are required.");
            this.OverridesOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReturnsDocumentationTagCheckBox
            // 
            this.ReturnsDocumentationTagCheckBox.AutoSize = true;
            this.ReturnsDocumentationTagCheckBox.Location = new System.Drawing.Point(95, 141);
            this.ReturnsDocumentationTagCheckBox.Name = "ReturnsDocumentationTagCheckBox";
            this.ReturnsDocumentationTagCheckBox.Size = new System.Drawing.Size(63, 17);
            this.ReturnsDocumentationTagCheckBox.TabIndex = 45;
            this.ReturnsDocumentationTagCheckBox.Text = "Returns";
            this.toolTip1.SetToolTip(this.ReturnsDocumentationTagCheckBox, "When checked, a non empty <returns> tag is required");
            this.ReturnsDocumentationTagCheckBox.UseVisualStyleBackColor = true;
            // 
            // InterfaceOptionCheckBox
            // 
            this.InterfaceOptionCheckBox.AutoSize = true;
            this.InterfaceOptionCheckBox.Location = new System.Drawing.Point(164, 55);
            this.InterfaceOptionCheckBox.Name = "InterfaceOptionCheckBox";
            this.InterfaceOptionCheckBox.Size = new System.Drawing.Size(113, 17);
            this.InterfaceOptionCheckBox.TabIndex = 44;
            this.InterfaceOptionCheckBox.Text = "Interface definition";
            this.toolTip1.SetToolTip(this.InterfaceOptionCheckBox, "When checked, then properties defined on an interface are required.");
            this.InterfaceOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExplicitOptionCheckBox
            // 
            this.ExplicitOptionCheckBox.AutoSize = true;
            this.ExplicitOptionCheckBox.Location = new System.Drawing.Point(164, 36);
            this.ExplicitOptionCheckBox.Name = "ExplicitOptionCheckBox";
            this.ExplicitOptionCheckBox.Size = new System.Drawing.Size(176, 17);
            this.ExplicitOptionCheckBox.TabIndex = 43;
            this.ExplicitOptionCheckBox.Text = "Explicit interface implementation";
            this.toolTip1.SetToolTip(this.ExplicitOptionCheckBox, "When checked, then explicit interface implementations are required.");
            this.ExplicitOptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(161, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Options:";
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
            // PropertiesConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OverridesOptionCheckBox);
            this.Controls.Add(this.ReturnsDocumentationTagCheckBox);
            this.Controls.Add(this.InterfaceOptionCheckBox);
            this.Controls.Add(this.ExplicitOptionCheckBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SummaryDocumentationTagCheckBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Visibilities);
            this.Name = "PropertiesConfigControl";
            this.Size = new System.Drawing.Size(350, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OverridesOptionCheckBox;
        private System.Windows.Forms.CheckBox ReturnsDocumentationTagCheckBox;
        private System.Windows.Forms.CheckBox InterfaceOptionCheckBox;
        private System.Windows.Forms.CheckBox ExplicitOptionCheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox SummaryDocumentationTagCheckBox;
        private System.Windows.Forms.Label label17;
        private VisibilityControl Visibilities;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
