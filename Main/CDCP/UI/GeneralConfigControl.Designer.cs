namespace CDCP.UI
{
    partial class GeneralConfigControl
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
            this.SkipMergesCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SkipBranchesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SkipMergesCheckBox
            // 
            this.SkipMergesCheckBox.AutoSize = true;
            this.SkipMergesCheckBox.Location = new System.Drawing.Point(3, 3);
            this.SkipMergesCheckBox.Name = "SkipMergesCheckBox";
            this.SkipMergesCheckBox.Size = new System.Drawing.Size(94, 17);
            this.SkipMergesCheckBox.TabIndex = 0;
            this.SkipMergesCheckBox.Text = "Ignore Merges";
            this.toolTip1.SetToolTip(this.SkipMergesCheckBox, "Check this checkbox to skip documentation checking when the pending change is a m" +
        "erge.");
            this.SkipMergesCheckBox.UseVisualStyleBackColor = true;
            // 
            // SkipBranchesCheckBox
            // 
            this.SkipBranchesCheckBox.AutoSize = true;
            this.SkipBranchesCheckBox.Location = new System.Drawing.Point(3, 26);
            this.SkipBranchesCheckBox.Name = "SkipBranchesCheckBox";
            this.SkipBranchesCheckBox.Size = new System.Drawing.Size(95, 17);
            this.SkipBranchesCheckBox.TabIndex = 1;
            this.SkipBranchesCheckBox.Text = "Skip Branches";
            this.toolTip1.SetToolTip(this.SkipBranchesCheckBox, "Check this checkbox to skip documentation checking when the pending change is a b" +
        "ranch.");
            this.SkipBranchesCheckBox.UseVisualStyleBackColor = true;
            // 
            // GeneralConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkipBranchesCheckBox);
            this.Controls.Add(this.SkipMergesCheckBox);
            this.Name = "GeneralConfigControl";
            this.Size = new System.Drawing.Size(350, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SkipMergesCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox SkipBranchesCheckBox;
    }
}
