﻿using System.ComponentModel;

namespace LiveSplit.UI.Components {
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
            this.pnlCounters = new System.Windows.Forms.TableLayoutPanel();
            this.lblKillHeader = new System.Windows.Forms.Label();
            this.lblSkelesHeader = new System.Windows.Forms.Label();
            this.lblHealingHeader = new System.Windows.Forms.Label();
            this.lblCumuHeader = new System.Windows.Forms.Label();
            this.lblRemHeader = new System.Windows.Forms.Label();
            this.lblKillsCumu = new System.Windows.Forms.Label();
            this.lblSkelesCumu = new System.Windows.Forms.Label();
            this.lblHealingCumu = new System.Windows.Forms.Label();
            this.lblKillsRem = new System.Windows.Forms.Label();
            this.lblSkelesRem = new System.Windows.Forms.Label();
            this.lblHealingRem = new System.Windows.Forms.Label();
            this.pnlCounters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCounters
            // 
            this.pnlCounters.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCounters.AutoSize = true;
            this.pnlCounters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCounters.ColumnCount = 4;
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlCounters.Controls.Add(this.lblKillHeader, 1, 0);
            this.pnlCounters.Controls.Add(this.lblSkelesHeader, 2, 0);
            this.pnlCounters.Controls.Add(this.lblHealingHeader, 3, 0);
            this.pnlCounters.Controls.Add(this.lblCumuHeader, 0, 1);
            this.pnlCounters.Controls.Add(this.lblRemHeader, 0, 2);
            this.pnlCounters.Controls.Add(this.lblKillsCumu, 1, 1);
            this.pnlCounters.Controls.Add(this.lblSkelesCumu, 2, 1);
            this.pnlCounters.Controls.Add(this.lblHealingCumu, 3, 1);
            this.pnlCounters.Controls.Add(this.lblKillsRem, 1, 2);
            this.pnlCounters.Controls.Add(this.lblSkelesRem, 2, 2);
            this.pnlCounters.Controls.Add(this.lblHealingRem, 3, 2);
            this.pnlCounters.Location = new System.Drawing.Point(6, 7);
            this.pnlCounters.MinimumSize = new System.Drawing.Size(300, 100);
            this.pnlCounters.Name = "pnlCounters";
            this.pnlCounters.RowCount = 3;
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlCounters.Size = new System.Drawing.Size(388, 108);
            this.pnlCounters.TabIndex = 0;
            // 
            // lblKillHeader
            // 
            this.lblKillHeader.AutoSize = true;
            this.lblKillHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKillHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblKillHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKillHeader.Location = new System.Drawing.Point(100, 0);
            this.lblKillHeader.Name = "lblKillHeader";
            this.lblKillHeader.Size = new System.Drawing.Size(91, 36);
            this.lblKillHeader.TabIndex = 0;
            this.lblKillHeader.Text = "Total Kills";
            this.lblKillHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSkelesHeader
            // 
            this.lblSkelesHeader.AutoSize = true;
            this.lblSkelesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkelesHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSkelesHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSkelesHeader.Location = new System.Drawing.Point(197, 0);
            this.lblSkelesHeader.Name = "lblSkelesHeader";
            this.lblSkelesHeader.Size = new System.Drawing.Size(91, 36);
            this.lblSkelesHeader.TabIndex = 1;
            this.lblSkelesHeader.Text = "Skeleton Kills";
            this.lblSkelesHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHealingHeader
            // 
            this.lblHealingHeader.AutoSize = true;
            this.lblHealingHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHealingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHealingHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealingHeader.Location = new System.Drawing.Point(294, 0);
            this.lblHealingHeader.Name = "lblHealingHeader";
            this.lblHealingHeader.Size = new System.Drawing.Size(91, 36);
            this.lblHealingHeader.TabIndex = 2;
            this.lblHealingHeader.Text = "Healing";
            this.lblHealingHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCumuHeader
            // 
            this.lblCumuHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCumuHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCumuHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCumuHeader.Location = new System.Drawing.Point(3, 36);
            this.lblCumuHeader.Name = "lblCumuHeader";
            this.lblCumuHeader.Size = new System.Drawing.Size(91, 36);
            this.lblCumuHeader.TabIndex = 3;
            this.lblCumuHeader.Text = "Total";
            this.lblCumuHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemHeader
            // 
            this.lblRemHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRemHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemHeader.Location = new System.Drawing.Point(3, 72);
            this.lblRemHeader.Name = "lblRemHeader";
            this.lblRemHeader.Size = new System.Drawing.Size(91, 36);
            this.lblRemHeader.TabIndex = 4;
            this.lblRemHeader.Text = "Remaining";
            this.lblRemHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKillsCumu
            // 
            this.lblKillsCumu.AutoSize = true;
            this.lblKillsCumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKillsCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKillsCumu.Location = new System.Drawing.Point(100, 36);
            this.lblKillsCumu.Name = "lblKillsCumu";
            this.lblKillsCumu.Size = new System.Drawing.Size(91, 36);
            this.lblKillsCumu.TabIndex = 5;
            this.lblKillsCumu.Text = "0";
            this.lblKillsCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSkelesCumu
            // 
            this.lblSkelesCumu.AutoSize = true;
            this.lblSkelesCumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkelesCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSkelesCumu.Location = new System.Drawing.Point(197, 36);
            this.lblSkelesCumu.Name = "lblSkelesCumu";
            this.lblSkelesCumu.Size = new System.Drawing.Size(91, 36);
            this.lblSkelesCumu.TabIndex = 6;
            this.lblSkelesCumu.Text = "0";
            this.lblSkelesCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHealingCumu
            // 
            this.lblHealingCumu.AutoSize = true;
            this.lblHealingCumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHealingCumu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealingCumu.Location = new System.Drawing.Point(294, 36);
            this.lblHealingCumu.Name = "lblHealingCumu";
            this.lblHealingCumu.Size = new System.Drawing.Size(91, 36);
            this.lblHealingCumu.TabIndex = 7;
            this.lblHealingCumu.Text = "0";
            this.lblHealingCumu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKillsRem
            // 
            this.lblKillsRem.AutoSize = true;
            this.lblKillsRem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKillsRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKillsRem.Location = new System.Drawing.Point(100, 72);
            this.lblKillsRem.Name = "lblKillsRem";
            this.lblKillsRem.Size = new System.Drawing.Size(91, 36);
            this.lblKillsRem.TabIndex = 8;
            this.lblKillsRem.Text = "0";
            this.lblKillsRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSkelesRem
            // 
            this.lblSkelesRem.AutoSize = true;
            this.lblSkelesRem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkelesRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSkelesRem.Location = new System.Drawing.Point(197, 72);
            this.lblSkelesRem.Name = "lblSkelesRem";
            this.lblSkelesRem.Size = new System.Drawing.Size(91, 36);
            this.lblSkelesRem.TabIndex = 9;
            this.lblSkelesRem.Text = "0";
            this.lblSkelesRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHealingRem
            // 
            this.lblHealingRem.AutoSize = true;
            this.lblHealingRem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHealingRem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealingRem.Location = new System.Drawing.Point(294, 72);
            this.lblHealingRem.Name = "lblHealingRem";
            this.lblHealingRem.Size = new System.Drawing.Size(91, 36);
            this.lblHealingRem.TabIndex = 10;
            this.lblHealingRem.Text = "0";
            this.lblHealingRem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VampireSurvivorsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlCounters);
            this.MinimumSize = new System.Drawing.Size(400, 100);
            this.Name = "VampireSurvivorsControl";
            this.Size = new System.Drawing.Size(400, 118);
            this.Load += new System.EventHandler(this.VampireSurvivorsControl_Load);
            this.pnlCounters.ResumeLayout(false);
            this.pnlCounters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSkelesCumu;
        private System.Windows.Forms.Label lblHealingCumu;
        private System.Windows.Forms.Label lblKillsRem;
        private System.Windows.Forms.Label lblSkelesRem;
        private System.Windows.Forms.Label lblHealingRem;

        private System.Windows.Forms.Label lblCumuHeader;
        private System.Windows.Forms.Label lblRemHeader;
        private System.Windows.Forms.Label lblKillsCumu;

        private System.Windows.Forms.Label lblHealingHeader;

        private System.Windows.Forms.Label lblSkelesHeader;

        private System.Windows.Forms.Label lblKillHeader;

        private System.Windows.Forms.TableLayoutPanel pnlCounters;

        #endregion
    }
}