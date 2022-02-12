using System.ComponentModel;

namespace LiveSplit.VampireSurvivors.UI.Controls {
    partial class AchievementControl {
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
            this.imgAchievement = new System.Windows.Forms.PictureBox();
            this.imgCheckbox = new System.Windows.Forms.PictureBox();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize) (this.imgAchievement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.imgCheckbox)).BeginInit();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgAchievement
            // 
            this.imgAchievement.Location = new System.Drawing.Point(33, 3);
            this.imgAchievement.Name = "imgAchievement";
            this.imgAchievement.Size = new System.Drawing.Size(24, 24);
            this.imgAchievement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAchievement.TabIndex = 1;
            this.imgAchievement.TabStop = false;
            // 
            // imgCheckbox
            // 
            this.imgCheckbox.InitialImage = null;
            this.imgCheckbox.Location = new System.Drawing.Point(3, 3);
            this.imgCheckbox.Name = "imgCheckbox";
            this.imgCheckbox.Size = new System.Drawing.Size(24, 24);
            this.imgCheckbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCheckbox.TabIndex = 0;
            this.imgCheckbox.TabStop = false;
            // 
            // layout
            // 
            this.layout.AutoSize = true;
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Controls.Add(this.imgCheckbox, 0, 0);
            this.layout.Controls.Add(this.imgAchievement, 1, 0);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(60, 30);
            this.layout.TabIndex = 0;
            // 
            // AchievementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.layout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AchievementControl";
            this.Size = new System.Drawing.Size(60, 30);
            this.Load += new System.EventHandler(this.AchievementControl_Load);
            ((System.ComponentModel.ISupportInitialize) (this.imgAchievement)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.imgCheckbox)).EndInit();
            this.layout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox imgAchievement;
        private System.Windows.Forms.PictureBox imgCheckbox;
        private System.Windows.Forms.TableLayoutPanel layout;

        #endregion
    }
}