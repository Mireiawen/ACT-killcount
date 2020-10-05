using System.ComponentModel;

namespace Killcount
{
    partial class ConfigPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.Kills = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.filter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kill Counter";
            // 
            // Kills
            // 
            this.Kills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kills.Location = new System.Drawing.Point(0, 23);
            this.Kills.Multiline = true;
            this.Kills.Name = "Kills";
            this.Kills.ReadOnly = true;
            this.Kills.Size = new System.Drawing.Size(425, 343);
            this.Kills.TabIndex = 1;
            this.Kills.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Reset.Location = new System.Drawing.Point(0, 343);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(425, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset Counts";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // filter
            // 
            this.filter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filter.Location = new System.Drawing.Point(0, 323);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(425, 20);
            this.filter.TabIndex = 2;
            this.filter.TextChanged += new System.EventHandler(this.filter_TextChanged);
            // 
            // ConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.filter);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Kills);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ConfigPanel";
            this.Size = new System.Drawing.Size(425, 366);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox filter;

        private System.Windows.Forms.Button Reset;

        private System.Windows.Forms.TextBox Kills;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}