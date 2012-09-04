namespace CDCP.UI
{
    partial class VisibilityControl
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
            this.ProtectedInternalBox = new System.Windows.Forms.CheckBox();
            this.PrivateBox = new System.Windows.Forms.CheckBox();
            this.InternalBox = new System.Windows.Forms.CheckBox();
            this.ProtectedBox = new System.Windows.Forms.CheckBox();
            this.PublicBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProtectedInternalBox
            // 
            this.ProtectedInternalBox.AutoSize = true;
            this.ProtectedInternalBox.Location = new System.Drawing.Point(12, 55);
            this.ProtectedInternalBox.Name = "ProtectedInternalBox";
            this.ProtectedInternalBox.Size = new System.Drawing.Size(108, 17);
            this.ProtectedInternalBox.TabIndex = 14;
            this.ProtectedInternalBox.Text = "protected internal";
            this.ProtectedInternalBox.UseVisualStyleBackColor = true;
            // 
            // PrivateBox
            // 
            this.PrivateBox.AutoSize = true;
            this.PrivateBox.Location = new System.Drawing.Point(12, 95);
            this.PrivateBox.Name = "PrivateBox";
            this.PrivateBox.Size = new System.Drawing.Size(58, 17);
            this.PrivateBox.TabIndex = 13;
            this.PrivateBox.Text = "private";
            this.PrivateBox.UseVisualStyleBackColor = true;
            // 
            // InternalBox
            // 
            this.InternalBox.AutoSize = true;
            this.InternalBox.Location = new System.Drawing.Point(12, 75);
            this.InternalBox.Name = "InternalBox";
            this.InternalBox.Size = new System.Drawing.Size(60, 17);
            this.InternalBox.TabIndex = 12;
            this.InternalBox.Text = "internal";
            this.InternalBox.UseVisualStyleBackColor = true;
            // 
            // ProtectedBox
            // 
            this.ProtectedBox.AutoSize = true;
            this.ProtectedBox.Location = new System.Drawing.Point(12, 36);
            this.ProtectedBox.Name = "ProtectedBox";
            this.ProtectedBox.Size = new System.Drawing.Size(71, 17);
            this.ProtectedBox.TabIndex = 11;
            this.ProtectedBox.Text = "protected";
            this.ProtectedBox.UseVisualStyleBackColor = true;
            // 
            // PublicBox
            // 
            this.PublicBox.AutoSize = true;
            this.PublicBox.Location = new System.Drawing.Point(12, 18);
            this.PublicBox.Name = "PublicBox";
            this.PublicBox.Size = new System.Drawing.Size(54, 17);
            this.PublicBox.TabIndex = 10;
            this.PublicBox.Text = "public";
            this.PublicBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Visibilities to check:";
            // 
            // VisibilityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProtectedInternalBox);
            this.Controls.Add(this.PrivateBox);
            this.Controls.Add(this.InternalBox);
            this.Controls.Add(this.ProtectedBox);
            this.Controls.Add(this.PublicBox);
            this.Name = "VisibilityControl";
            this.Size = new System.Drawing.Size(150, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ProtectedInternalBox;
        private System.Windows.Forms.CheckBox PrivateBox;
        private System.Windows.Forms.CheckBox InternalBox;
        private System.Windows.Forms.CheckBox ProtectedBox;
        private System.Windows.Forms.CheckBox PublicBox;
        private System.Windows.Forms.Label label1;
    }
}
