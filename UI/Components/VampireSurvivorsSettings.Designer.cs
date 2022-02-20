using System.ComponentModel;

namespace LiveSplit.UI.Components {
    partial class VampireSurvivorsSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.topLevelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowPnlVsDir = new System.Windows.Forms.FlowLayoutPanel();
            this.lblVsDir = new System.Windows.Forms.Label();
            this.txtVsDir = new System.Windows.Forms.TextBox();
            this.btnSelectVsDir = new System.Windows.Forms.Button();
            this.fbrowsVsDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnResetData = new System.Windows.Forms.Button();
            this.topLevelLayoutPanel.SuspendLayout();
            this.flowPnlVsDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.ColumnCount = 1;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Controls.Add(this.flowPnlVsDir, 0, 0);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(0, 3);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 1;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(350, 68);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // flowPnlVsDir
            // 
            this.flowPnlVsDir.AutoSize = true;
            this.flowPnlVsDir.Controls.Add(this.lblVsDir);
            this.flowPnlVsDir.Controls.Add(this.txtVsDir);
            this.flowPnlVsDir.Controls.Add(this.btnSelectVsDir);
            this.flowPnlVsDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnlVsDir.Location = new System.Drawing.Point(3, 3);
            this.flowPnlVsDir.Name = "flowPnlVsDir";
            this.flowPnlVsDir.Size = new System.Drawing.Size(344, 62);
            this.flowPnlVsDir.TabIndex = 0;
            // 
            // lblVsDir
            // 
            this.lblVsDir.AutoSize = true;
            this.lblVsDir.Location = new System.Drawing.Point(3, 0);
            this.lblVsDir.Name = "lblVsDir";
            this.lblVsDir.Size = new System.Drawing.Size(138, 13);
            this.lblVsDir.TabIndex = 0;
            this.lblVsDir.Text = "Vampire Survivors directory:";
            // 
            // txtVsDir
            // 
            this.txtVsDir.Location = new System.Drawing.Point(3, 16);
            this.txtVsDir.MinimumSize = new System.Drawing.Size(200, 4);
            this.txtVsDir.Name = "txtVsDir";
            this.txtVsDir.Size = new System.Drawing.Size(300, 20);
            this.txtVsDir.TabIndex = 1;
            this.txtVsDir.TextChanged += new System.EventHandler(this.txtVsDir_TextChanged);
            // 
            // btnSelectVsDir
            // 
            this.btnSelectVsDir.AutoSize = true;
            this.btnSelectVsDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectVsDir.Location = new System.Drawing.Point(306, 13);
            this.btnSelectVsDir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectVsDir.Name = "btnSelectVsDir";
            this.btnSelectVsDir.Size = new System.Drawing.Size(26, 23);
            this.btnSelectVsDir.TabIndex = 2;
            this.btnSelectVsDir.Text = "...";
            this.btnSelectVsDir.UseVisualStyleBackColor = true;
            this.btnSelectVsDir.Click += new System.EventHandler(this.btnSelectVsDir_Click);
            // 
            // fbrowsVsDir
            // 
            this.fbrowsVsDir.Description = "Select the directory in which Vampire Survivors is installed.";
            this.fbrowsVsDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbrowsVsDir.ShowNewFolderButton = false;
            // 
            // btnResetData
            // 
            this.btnResetData.AutoSize = true;
            this.btnResetData.Location = new System.Drawing.Point(0, 74);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(95, 23);
            this.btnResetData.TabIndex = 1;
            this.btnResetData.Text = "Reset save data";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // VampireSurvivorsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnResetData);
            this.Controls.Add(this.topLevelLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(250, 0);
            this.Name = "VampireSurvivorsSettings";
            this.Size = new System.Drawing.Size(353, 309);
            this.Load += new System.EventHandler(this.VampireSurvivorsSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.flowPnlVsDir.ResumeLayout(false);
            this.flowPnlVsDir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnResetData;

        private System.Windows.Forms.Button btnSelectVsDir;

        private System.Windows.Forms.FolderBrowserDialog fbrowsVsDir;

        private System.Windows.Forms.Label lblVsDir;
        private System.Windows.Forms.TextBox txtVsDir;

        private System.Windows.Forms.FlowLayoutPanel flowPnlVsDir;

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;

        #endregion
    }
}
