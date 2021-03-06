using System.ComponentModel;

namespace LiveSplit.VampireSurvivors.UI.Controls {
    partial class VampireSurvivorsControl {
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
            this.tblBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.pnlCounters = new System.Windows.Forms.TableLayoutPanel();
            this.lblKillsCumu = new System.Windows.Forms.Label();
            this.lblSkelesRem = new System.Windows.Forms.Label();
            this.lblRemHeader = new System.Windows.Forms.Label();
            this.lblCumuHeader = new System.Windows.Forms.Label();
            this.lblKillHeader = new System.Windows.Forms.Label();
            this.lblSkelesHeader = new System.Windows.Forms.Label();
            this.lblSkelesCumu = new System.Windows.Forms.Label();
            this.lblKillsRem = new System.Windows.Forms.Label();
            this.lblHealingHeader = new System.Windows.Forms.Label();
            this.lblHealingCumu = new System.Windows.Forms.Label();
            this.lblHealingRem = new System.Windows.Forms.Label();
            this.lblBuerHeader = new System.Windows.Forms.Label();
            this.lblBuerCumu = new System.Windows.Forms.Label();
            this.lblBuerRem = new System.Windows.Forms.Label();
            this.flpAchievements = new System.Windows.Forms.FlowLayoutPanel();
            this.tblBase.SuspendLayout();
            this.pnlCounters.SuspendLayout();
            this.SuspendLayout();
            //
            // tblBase
            //
            this.tblBase.AutoSize = true;
            this.tblBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblBase.ColumnCount = 1;
            this.tblBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBase.Controls.Add(this.lblAchievements, 0, 1);
            this.tblBase.Controls.Add(this.pnlCounters, 0, 0);
            this.tblBase.Controls.Add(this.flpAchievements, 0, 2);
            this.tblBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBase.Location = new System.Drawing.Point(0, 0);
            this.tblBase.MinimumSize = new System.Drawing.Size(300, 60);
            this.tblBase.Name = "tblBase";
            this.tblBase.RowCount = 3;
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBase.Size = new System.Drawing.Size(454, 232);
            this.tblBase.TabIndex = 0;
            //
            // lblAchievements
            //
            this.lblAchievements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAchievements.AutoSize = true;
            this.lblAchievements.BackColor = System.Drawing.Color.Transparent;
            this.lblAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAchievements.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAchievements.Location = new System.Drawing.Point(227, 116);
            this.lblAchievements.Margin = new System.Windows.Forms.Padding(3, 10, 3, 4);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(0, 17);
            this.lblAchievements.TabIndex = 4;
            this.lblAchievements.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // pnlCounters
            //
            this.pnlCounters.AutoSize = true;
            this.pnlCounters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCounters.ColumnCount = 3;
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCounters.Controls.Add(this.lblKillsCumu, 1, 1);
            this.pnlCounters.Controls.Add(this.lblSkelesRem, 2, 2);
            this.pnlCounters.Controls.Add(this.lblRemHeader, 2, 0);
            this.pnlCounters.Controls.Add(this.lblCumuHeader, 1, 0);
            this.pnlCounters.Controls.Add(this.lblKillHeader, 0, 1);
            this.pnlCounters.Controls.Add(this.lblSkelesHeader, 0, 2);
            this.pnlCounters.Controls.Add(this.lblSkelesCumu, 1, 2);
            this.pnlCounters.Controls.Add(this.lblKillsRem, 2, 1);
            this.pnlCounters.Controls.Add(this.lblHealingHeader, 0, 4);
            this.pnlCounters.Controls.Add(this.lblHealingCumu, 1, 4);
            this.pnlCounters.Controls.Add(this.lblHealingRem, 2, 4);
            this.pnlCounters.Controls.Add(this.lblBuerHeader, 0, 3);
            this.pnlCounters.Controls.Add(this.lblBuerCumu, 1, 3);
            this.pnlCounters.Controls.Add(this.lblBuerRem, 2, 3);
            this.pnlCounters.Location = new System.Drawing.Point(3, 3);
            this.pnlCounters.Name = "pnlCounters";
            this.pnlCounters.RowCount = 5;
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlCounters.Size = new System.Drawing.Size(270, 100);
            this.pnlCounters.TabIndex = 1;
            //
            // lblKillsCumu
            //
            this.lblKillsCumu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKillsCumu.AutoSize = true;
            this.lblKillsCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKillsCumu.Location = new System.Drawing.Point(164, 26);
            this.lblKillsCumu.Name = "lblKillsCumu";
            this.lblKillsCumu.Size = new System.Drawing.Size(13, 13);
            this.lblKillsCumu.TabIndex = 5;
            this.lblKillsCumu.Text = "0";
            this.lblKillsCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblSkelesRem
            //
            this.lblSkelesRem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSkelesRem.AutoSize = true;
            this.lblSkelesRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSkelesRem.Location = new System.Drawing.Point(254, 46);
            this.lblSkelesRem.Name = "lblSkelesRem";
            this.lblSkelesRem.Size = new System.Drawing.Size(13, 13);
            this.lblSkelesRem.TabIndex = 9;
            this.lblSkelesRem.Text = "0";
            this.lblSkelesRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblRemHeader
            //
            this.lblRemHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRemHeader.AutoSize = true;
            this.lblRemHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRemHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemHeader.Location = new System.Drawing.Point(183, 3);
            this.lblRemHeader.Margin = new System.Windows.Forms.Padding(3);
            this.lblRemHeader.Name = "lblRemHeader";
            this.lblRemHeader.Size = new System.Drawing.Size(84, 17);
            this.lblRemHeader.TabIndex = 4;
            this.lblRemHeader.Text = "Remaining";
            this.lblRemHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblCumuHeader
            //
            this.lblCumuHeader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCumuHeader.AutoSize = true;
            this.lblCumuHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCumuHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCumuHeader.Location = new System.Drawing.Point(132, 3);
            this.lblCumuHeader.Margin = new System.Windows.Forms.Padding(3);
            this.lblCumuHeader.Name = "lblCumuHeader";
            this.lblCumuHeader.Size = new System.Drawing.Size(45, 17);
            this.lblCumuHeader.TabIndex = 3;
            this.lblCumuHeader.Text = "Total";
            this.lblCumuHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblKillHeader
            //
            this.lblKillHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKillHeader.AutoSize = true;
            this.lblKillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblKillHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKillHeader.Location = new System.Drawing.Point(3, 23);
            this.lblKillHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblKillHeader.Name = "lblKillHeader";
            this.lblKillHeader.Size = new System.Drawing.Size(69, 17);
            this.lblKillHeader.TabIndex = 0;
            this.lblKillHeader.Text = "Total Kills";
            this.lblKillHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblSkelesHeader
            //
            this.lblSkelesHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSkelesHeader.AutoSize = true;
            this.lblSkelesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSkelesHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSkelesHeader.Location = new System.Drawing.Point(3, 43);
            this.lblSkelesHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblSkelesHeader.Name = "lblSkelesHeader";
            this.lblSkelesHeader.Size = new System.Drawing.Size(70, 17);
            this.lblSkelesHeader.TabIndex = 12;
            this.lblSkelesHeader.Text = "Skeletons";
            this.lblSkelesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblSkelesCumu
            //
            this.lblSkelesCumu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSkelesCumu.AutoSize = true;
            this.lblSkelesCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSkelesCumu.Location = new System.Drawing.Point(164, 46);
            this.lblSkelesCumu.Name = "lblSkelesCumu";
            this.lblSkelesCumu.Size = new System.Drawing.Size(13, 13);
            this.lblSkelesCumu.TabIndex = 6;
            this.lblSkelesCumu.Text = "0";
            this.lblSkelesCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblKillsRem
            //
            this.lblKillsRem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKillsRem.AutoSize = true;
            this.lblKillsRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKillsRem.Location = new System.Drawing.Point(254, 26);
            this.lblKillsRem.Name = "lblKillsRem";
            this.lblKillsRem.Size = new System.Drawing.Size(13, 13);
            this.lblKillsRem.TabIndex = 8;
            this.lblKillsRem.Text = "0";
            this.lblKillsRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblHealingHeader
            //
            this.lblHealingHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHealingHeader.AutoSize = true;
            this.lblHealingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHealingHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealingHeader.Location = new System.Drawing.Point(3, 80);
            this.lblHealingHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblHealingHeader.Name = "lblHealingHeader";
            this.lblHealingHeader.Size = new System.Drawing.Size(56, 17);
            this.lblHealingHeader.TabIndex = 11;
            this.lblHealingHeader.Text = "Healing";
            this.lblHealingHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblHealingCumu
            //
            this.lblHealingCumu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHealingCumu.AutoSize = true;
            this.lblHealingCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealingCumu.Location = new System.Drawing.Point(164, 83);
            this.lblHealingCumu.Name = "lblHealingCumu";
            this.lblHealingCumu.Size = new System.Drawing.Size(13, 13);
            this.lblHealingCumu.TabIndex = 7;
            this.lblHealingCumu.Text = "0";
            this.lblHealingCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblHealingRem
            //
            this.lblHealingRem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHealingRem.AutoSize = true;
            this.lblHealingRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealingRem.Location = new System.Drawing.Point(254, 83);
            this.lblHealingRem.Name = "lblHealingRem";
            this.lblHealingRem.Size = new System.Drawing.Size(13, 13);
            this.lblHealingRem.TabIndex = 10;
            this.lblHealingRem.Text = "0";
            this.lblHealingRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblBuerHeader
            //
            this.lblBuerHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuerHeader.AutoSize = true;
            this.lblBuerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBuerHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuerHeader.Location = new System.Drawing.Point(3, 63);
            this.lblBuerHeader.Name = "lblBuerHeader";
            this.lblBuerHeader.Size = new System.Drawing.Size(80, 17);
            this.lblBuerHeader.TabIndex = 13;
            this.lblBuerHeader.Text = "Lion Heads";
            this.lblBuerHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblBuerCumu
            //
            this.lblBuerCumu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBuerCumu.AutoSize = true;
            this.lblBuerCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuerCumu.Location = new System.Drawing.Point(164, 65);
            this.lblBuerCumu.Name = "lblBuerCumu";
            this.lblBuerCumu.Size = new System.Drawing.Size(13, 13);
            this.lblBuerCumu.TabIndex = 14;
            this.lblBuerCumu.Text = "0";
            this.lblBuerCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblBuerRem
            //
            this.lblBuerRem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBuerRem.AutoSize = true;
            this.lblBuerRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuerRem.Location = new System.Drawing.Point(254, 65);
            this.lblBuerRem.Name = "lblBuerRem";
            this.lblBuerRem.Size = new System.Drawing.Size(13, 13);
            this.lblBuerRem.TabIndex = 15;
            this.lblBuerRem.Text = "0";
            this.lblBuerRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // flpAchievements
            //
            this.flpAchievements.AutoSize = true;
            this.flpAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAchievements.Location = new System.Drawing.Point(3, 140);
            this.flpAchievements.Name = "flpAchievements";
            this.flpAchievements.Size = new System.Drawing.Size(448, 89);
            this.flpAchievements.TabIndex = 5;
            //
            // VampireSurvivorsControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tblBase);
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "VampireSurvivorsControl";
            this.Size = new System.Drawing.Size(454, 232);
            this.Load += new System.EventHandler(this.VampireSurvivorsControl_Load);
            this.tblBase.ResumeLayout(false);
            this.tblBase.PerformLayout();
            this.pnlCounters.ResumeLayout(false);
            this.pnlCounters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBuerHeader;
        private System.Windows.Forms.Label lblHealingHeader;
        private System.Windows.Forms.Label lblSkelesHeader;
        private System.Windows.Forms.Label lblKillHeader;

        private System.Windows.Forms.Label lblBuerRem;

        private System.Windows.Forms.Label lblBuerCumu;

        private System.Windows.Forms.FlowLayoutPanel flpAchievements;

        private System.Windows.Forms.Label lblAchievements;

        private System.Windows.Forms.TableLayoutPanel pnlCounters;
        private System.Windows.Forms.Label lblCumuHeader;
        private System.Windows.Forms.Label lblRemHeader;
        private System.Windows.Forms.Label lblKillsCumu;
        private System.Windows.Forms.Label lblSkelesCumu;
        private System.Windows.Forms.Label lblHealingCumu;
        private System.Windows.Forms.Label lblKillsRem;
        private System.Windows.Forms.Label lblSkelesRem;
        private System.Windows.Forms.Label lblHealingRem;

        private System.Windows.Forms.TableLayoutPanel tblBase;

        #endregion
    }
}
