﻿namespace itHappens.UIs.valentina
{
    partial class ListPage
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
            this.ListsTitleLabel = new System.Windows.Forms.Label();
            ListsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            //
            // ListsTitleLabel
            //
            this.ListsTitleLabel.AutoSize = true;
            this.ListsTitleLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ListsTitleLabel.Location = new System.Drawing.Point(3, 12);
            this.ListsTitleLabel.Name = "ListsTitleLabel";
            this.ListsTitleLabel.Size = new System.Drawing.Size(67, 36);
            this.ListsTitleLabel.TabIndex = 72;
            this.ListsTitleLabel.Text = "Lists";
            //
            // ListsFlowLayoutPanel
            //
            ListsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            ListsFlowLayoutPanel.AutoSize = true;
            ListsFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ListsFlowLayoutPanel.Location = new System.Drawing.Point(-1, 61);
            ListsFlowLayoutPanel.Name = "ListsFlowLayoutPanel";
            ListsFlowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            ListsFlowLayoutPanel.TabIndex = 73;
            //
            // ListPage
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

            this.Controls.Add(ListsFlowLayoutPanel);

            this.Controls.Add(this.ListsTitleLabel);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "ListPage";
            this.Size = new System.Drawing.Size(73, 64);
            this.Load += new System.EventHandler(this.ListPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ListsTitleLabel;
        public static System.Windows.Forms.FlowLayoutPanel ListsFlowLayoutPanel;
    }
}
