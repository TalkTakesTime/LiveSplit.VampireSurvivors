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
            this.pnlVsDir = new System.Windows.Forms.Panel();
            this.lblVsDir = new System.Windows.Forms.Label();
            this.txtVsDir = new System.Windows.Forms.TextBox();
            this.topLevelLayoutPanel.SuspendLayout();
            this.pnlVsDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.ColumnCount = 1;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Controls.Add(this.pnlVsDir, 0, 0);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(0, 3);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 1;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // pnlVsDir
            // 
            this.pnlVsDir.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVsDir.AutoSize = true;
            this.pnlVsDir.Controls.Add(this.lblVsDir);
            this.pnlVsDir.Controls.Add(this.txtVsDir);
            this.pnlVsDir.Location = new System.Drawing.Point(3, 3);
            this.pnlVsDir.Name = "pnlVsDir";
            this.pnlVsDir.Size = new System.Drawing.Size(194, 94);
            this.pnlVsDir.TabIndex = 0;
            // 
            // lblVsDir
            // 
            this.lblVsDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVsDir.Location = new System.Drawing.Point(0, 0);
            this.lblVsDir.Name = "lblVsDir";
            this.lblVsDir.Size = new System.Drawing.Size(100, 94);
            this.lblVsDir.TabIndex = 1;
            this.lblVsDir.Text = "Vampire Survivors directory";
            // 
            // txtVsDir
            // 
            this.txtVsDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtVsDir.Location = new System.Drawing.Point(186, 0);
            this.txtVsDir.Name = "txtVsDir";
            this.txtVsDir.Size = new System.Drawing.Size(8, 20);
            this.txtVsDir.TabIndex = 0;
            // 
            // VampireSurvivorsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "VampireSurvivorsSettings";
            this.Size = new System.Drawing.Size(203, 150);
            this.Load += new System.EventHandler(this.VampireSurvivorsSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.pnlVsDir.ResumeLayout(false);
            this.pnlVsDir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblVsDir;

        private System.Windows.Forms.TextBox txtVsDir;

        private System.Windows.Forms.Panel pnlVsDir;

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;

        #endregion
    }
}