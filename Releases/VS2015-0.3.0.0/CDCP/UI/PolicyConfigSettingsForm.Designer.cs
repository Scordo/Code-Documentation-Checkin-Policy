namespace CDCP.UI
{
    partial class PolicyConfigSettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OkDialogButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.ResetToDefaultsButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ClassesTab = new System.Windows.Forms.TabPage();
            this.ClassesConfigControlInstance = new CDCP.UI.ClassesConfigControl();
            this.StructsTab = new System.Windows.Forms.TabPage();
            this.StructsConfigControlInstance = new CDCP.UI.StructsConfigControl();
            this.InteracesTab = new System.Windows.Forms.TabPage();
            this.InterfacesConfigControlInstance = new CDCP.UI.InterfacesConfigControl();
            this.EnumsTab = new System.Windows.Forms.TabPage();
            this.EnumsConfigControlInstance = new CDCP.UI.EnumsConfigControl();
            this.EventsTab = new System.Windows.Forms.TabPage();
            this.EventsConfigControlInstance = new CDCP.UI.EventsConfigControl();
            this.DelegatesTab = new System.Windows.Forms.TabPage();
            this.DelegatesConfigControlInstance = new CDCP.UI.DelegateConfigControl();
            this.FieldsTab = new System.Windows.Forms.TabPage();
            this.FieldsConfigControlInstance = new CDCP.UI.FieldsConfigControl();
            this.PropertiesTab = new System.Windows.Forms.TabPage();
            this.PropertiesConfigControlInstance = new CDCP.UI.PropertiesConfigControl();
            this.MethodsTab = new System.Windows.Forms.TabPage();
            this.MethodsConfigControlInstance = new CDCP.UI.MethodsConfigControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.GeneralConfigControlInstance = new CDCP.UI.GeneralConfigControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ClassesTab.SuspendLayout();
            this.StructsTab.SuspendLayout();
            this.InteracesTab.SuspendLayout();
            this.EnumsTab.SuspendLayout();
            this.EventsTab.SuspendLayout();
            this.DelegatesTab.SuspendLayout();
            this.FieldsTab.SuspendLayout();
            this.PropertiesTab.SuspendLayout();
            this.MethodsTab.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.OkDialogButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CancelDialogButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResetToDefaultsButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 193);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 47);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // OkDialogButton
            // 
            this.OkDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkDialogButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkDialogButton.Location = new System.Drawing.Point(101, 10);
            this.OkDialogButton.Margin = new System.Windows.Forms.Padding(10);
            this.OkDialogButton.Name = "OkDialogButton";
            this.OkDialogButton.Size = new System.Drawing.Size(71, 27);
            this.OkDialogButton.TabIndex = 0;
            this.OkDialogButton.Text = "Ok";
            this.OkDialogButton.UseVisualStyleBackColor = true;
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Location = new System.Drawing.Point(283, 10);
            this.CancelDialogButton.Margin = new System.Windows.Forms.Padding(10);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(71, 27);
            this.CancelDialogButton.TabIndex = 1;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            // 
            // ResetToDefaultsButton
            // 
            this.ResetToDefaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetToDefaultsButton.Location = new System.Drawing.Point(192, 10);
            this.ResetToDefaultsButton.Margin = new System.Windows.Forms.Padding(10);
            this.ResetToDefaultsButton.Name = "ResetToDefaultsButton";
            this.ResetToDefaultsButton.Size = new System.Drawing.Size(71, 27);
            this.ResetToDefaultsButton.TabIndex = 2;
            this.ResetToDefaultsButton.Text = "Defaults";
            this.ResetToDefaultsButton.UseVisualStyleBackColor = true;
            this.ResetToDefaultsButton.Click += new System.EventHandler(this.ResetToDefaultsButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.ClassesTab);
            this.tabControl1.Controls.Add(this.StructsTab);
            this.tabControl1.Controls.Add(this.InteracesTab);
            this.tabControl1.Controls.Add(this.EnumsTab);
            this.tabControl1.Controls.Add(this.EventsTab);
            this.tabControl1.Controls.Add(this.DelegatesTab);
            this.tabControl1.Controls.Add(this.FieldsTab);
            this.tabControl1.Controls.Add(this.PropertiesTab);
            this.tabControl1.Controls.Add(this.MethodsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 193);
            this.tabControl1.TabIndex = 2;
            // 
            // ClassesTab
            // 
            this.ClassesTab.Controls.Add(this.ClassesConfigControlInstance);
            this.ClassesTab.Location = new System.Drawing.Point(4, 22);
            this.ClassesTab.Name = "ClassesTab";
            this.ClassesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTab.Size = new System.Drawing.Size(451, 167);
            this.ClassesTab.TabIndex = 0;
            this.ClassesTab.Text = "Classes";
            this.ClassesTab.UseVisualStyleBackColor = true;
            // 
            // ClassesConfigControlInstance
            // 
            this.ClassesConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesConfigControlInstance.Location = new System.Drawing.Point(3, 3);
            this.ClassesConfigControlInstance.Name = "ClassesConfigControlInstance";
            this.ClassesConfigControlInstance.Size = new System.Drawing.Size(445, 161);
            this.ClassesConfigControlInstance.TabIndex = 0;
            // 
            // StructsTab
            // 
            this.StructsTab.Controls.Add(this.StructsConfigControlInstance);
            this.StructsTab.Location = new System.Drawing.Point(4, 22);
            this.StructsTab.Name = "StructsTab";
            this.StructsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StructsTab.Size = new System.Drawing.Size(451, 167);
            this.StructsTab.TabIndex = 1;
            this.StructsTab.Text = "Structs";
            this.StructsTab.UseVisualStyleBackColor = true;
            // 
            // StructsConfigControlInstance
            // 
            this.StructsConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StructsConfigControlInstance.Location = new System.Drawing.Point(3, 3);
            this.StructsConfigControlInstance.Name = "StructsConfigControlInstance";
            this.StructsConfigControlInstance.Size = new System.Drawing.Size(445, 161);
            this.StructsConfigControlInstance.TabIndex = 0;
            // 
            // InteracesTab
            // 
            this.InteracesTab.Controls.Add(this.InterfacesConfigControlInstance);
            this.InteracesTab.Location = new System.Drawing.Point(4, 22);
            this.InteracesTab.Name = "InteracesTab";
            this.InteracesTab.Padding = new System.Windows.Forms.Padding(3);
            this.InteracesTab.Size = new System.Drawing.Size(451, 167);
            this.InteracesTab.TabIndex = 2;
            this.InteracesTab.Text = "Interfaces";
            this.InteracesTab.UseVisualStyleBackColor = true;
            // 
            // InterfacesConfigControlInstance
            // 
            this.InterfacesConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InterfacesConfigControlInstance.Location = new System.Drawing.Point(3, 3);
            this.InterfacesConfigControlInstance.Name = "InterfacesConfigControlInstance";
            this.InterfacesConfigControlInstance.Size = new System.Drawing.Size(445, 161);
            this.InterfacesConfigControlInstance.TabIndex = 0;
            // 
            // EnumsTab
            // 
            this.EnumsTab.Controls.Add(this.EnumsConfigControlInstance);
            this.EnumsTab.Location = new System.Drawing.Point(4, 22);
            this.EnumsTab.Name = "EnumsTab";
            this.EnumsTab.Size = new System.Drawing.Size(451, 167);
            this.EnumsTab.TabIndex = 3;
            this.EnumsTab.Text = "Enums";
            this.EnumsTab.UseVisualStyleBackColor = true;
            // 
            // EnumsConfigControlInstance
            // 
            this.EnumsConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.EnumsConfigControlInstance.Name = "EnumsConfigControlInstance";
            this.EnumsConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.EnumsConfigControlInstance.TabIndex = 0;
            // 
            // EventsTab
            // 
            this.EventsTab.Controls.Add(this.EventsConfigControlInstance);
            this.EventsTab.Location = new System.Drawing.Point(4, 22);
            this.EventsTab.Name = "EventsTab";
            this.EventsTab.Size = new System.Drawing.Size(451, 167);
            this.EventsTab.TabIndex = 4;
            this.EventsTab.Text = "Events";
            this.EventsTab.UseVisualStyleBackColor = true;
            // 
            // EventsConfigControlInstance
            // 
            this.EventsConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.EventsConfigControlInstance.Name = "EventsConfigControlInstance";
            this.EventsConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.EventsConfigControlInstance.TabIndex = 0;
            // 
            // DelegatesTab
            // 
            this.DelegatesTab.Controls.Add(this.DelegatesConfigControlInstance);
            this.DelegatesTab.Location = new System.Drawing.Point(4, 22);
            this.DelegatesTab.Name = "DelegatesTab";
            this.DelegatesTab.Size = new System.Drawing.Size(451, 167);
            this.DelegatesTab.TabIndex = 5;
            this.DelegatesTab.Text = "Delegates";
            this.DelegatesTab.UseVisualStyleBackColor = true;
            this.DelegatesTab.UseWaitCursor = true;
            // 
            // DelegatesConfigControlInstance
            // 
            this.DelegatesConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelegatesConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.DelegatesConfigControlInstance.Name = "DelegatesConfigControlInstance";
            this.DelegatesConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.DelegatesConfigControlInstance.TabIndex = 0;
            this.DelegatesConfigControlInstance.UseWaitCursor = true;
            // 
            // FieldsTab
            // 
            this.FieldsTab.Controls.Add(this.FieldsConfigControlInstance);
            this.FieldsTab.Location = new System.Drawing.Point(4, 22);
            this.FieldsTab.Name = "FieldsTab";
            this.FieldsTab.Size = new System.Drawing.Size(451, 167);
            this.FieldsTab.TabIndex = 6;
            this.FieldsTab.Text = "Fields";
            this.FieldsTab.UseVisualStyleBackColor = true;
            // 
            // FieldsConfigControlInstance
            // 
            this.FieldsConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldsConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.FieldsConfigControlInstance.Name = "FieldsConfigControlInstance";
            this.FieldsConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.FieldsConfigControlInstance.TabIndex = 0;
            // 
            // PropertiesTab
            // 
            this.PropertiesTab.Controls.Add(this.PropertiesConfigControlInstance);
            this.PropertiesTab.Location = new System.Drawing.Point(4, 22);
            this.PropertiesTab.Name = "PropertiesTab";
            this.PropertiesTab.Size = new System.Drawing.Size(451, 167);
            this.PropertiesTab.TabIndex = 7;
            this.PropertiesTab.Text = "Properties";
            this.PropertiesTab.UseVisualStyleBackColor = true;
            // 
            // PropertiesConfigControlInstance
            // 
            this.PropertiesConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.PropertiesConfigControlInstance.Name = "PropertiesConfigControlInstance";
            this.PropertiesConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.PropertiesConfigControlInstance.TabIndex = 0;
            // 
            // MethodsTab
            // 
            this.MethodsTab.Controls.Add(this.MethodsConfigControlInstance);
            this.MethodsTab.Location = new System.Drawing.Point(4, 22);
            this.MethodsTab.Name = "MethodsTab";
            this.MethodsTab.Size = new System.Drawing.Size(451, 167);
            this.MethodsTab.TabIndex = 8;
            this.MethodsTab.Text = "Methods";
            this.MethodsTab.UseVisualStyleBackColor = true;
            // 
            // MethodsConfigControlInstance
            // 
            this.MethodsConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodsConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.MethodsConfigControlInstance.Name = "MethodsConfigControlInstance";
            this.MethodsConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.MethodsConfigControlInstance.TabIndex = 0;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.GeneralConfigControlInstance);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Size = new System.Drawing.Size(451, 167);
            this.GeneralTab.TabIndex = 9;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // GeneralConfigControlInstance
            // 
            this.GeneralConfigControlInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralConfigControlInstance.Location = new System.Drawing.Point(0, 0);
            this.GeneralConfigControlInstance.Name = "GeneralConfigControlInstance";
            this.GeneralConfigControlInstance.Size = new System.Drawing.Size(451, 167);
            this.GeneralConfigControlInstance.TabIndex = 0;
            // 
            // PolicyConfigSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 240);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PolicyConfigSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Code Documentation Checkin Policy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ClassesTab.ResumeLayout(false);
            this.StructsTab.ResumeLayout(false);
            this.InteracesTab.ResumeLayout(false);
            this.EnumsTab.ResumeLayout(false);
            this.EventsTab.ResumeLayout(false);
            this.DelegatesTab.ResumeLayout(false);
            this.FieldsTab.ResumeLayout(false);
            this.PropertiesTab.ResumeLayout(false);
            this.MethodsTab.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button OkDialogButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ClassesTab;
        private System.Windows.Forms.TabPage StructsTab;
        private System.Windows.Forms.TabPage InteracesTab;
        private System.Windows.Forms.TabPage EnumsTab;
        private System.Windows.Forms.TabPage EventsTab;
        private System.Windows.Forms.TabPage DelegatesTab;
        private System.Windows.Forms.TabPage FieldsTab;
        private System.Windows.Forms.TabPage PropertiesTab;
        private System.Windows.Forms.TabPage MethodsTab;
        private ClassesConfigControl ClassesConfigControlInstance;
        private EnumsConfigControl EnumsConfigControlInstance;
        private EventsConfigControl EventsConfigControlInstance;
        private DelegateConfigControl DelegatesConfigControlInstance;
        private FieldsConfigControl FieldsConfigControlInstance;
        private PropertiesConfigControl PropertiesConfigControlInstance;
        private MethodsConfigControl MethodsConfigControlInstance;
        private StructsConfigControl StructsConfigControlInstance;
        private InterfacesConfigControl InterfacesConfigControlInstance;
        private System.Windows.Forms.Button ResetToDefaultsButton;
        private System.Windows.Forms.TabPage GeneralTab;
        private GeneralConfigControl GeneralConfigControlInstance;

    }
}