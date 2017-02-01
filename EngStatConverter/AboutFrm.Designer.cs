namespace EngStatConverter
{
    partial class AboutFrm
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
            this.CloseBtn = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MailLinkSchlueter = new System.Windows.Forms.LinkLabel();
            this.MailLinkRohrbach = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(222, 127);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(50, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(22, 122);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(42, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resources can be found at ";
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Location = new System.Drawing.Point(22, 98);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(220, 13);
            this.GitHubLink.TabIndex = 3;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Text = "https://github.com/schluo/EngStatConverter";
            this.GitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubLink_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Authors ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oliver Schlueter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MailLinkSchlueter
            // 
            this.MailLinkSchlueter.AutoSize = true;
            this.MailLinkSchlueter.Location = new System.Drawing.Point(80, 22);
            this.MailLinkSchlueter.Name = "MailLinkSchlueter";
            this.MailLinkSchlueter.Size = new System.Drawing.Size(158, 13);
            this.MailLinkSchlueter.TabIndex = 6;
            this.MailLinkSchlueter.TabStop = true;
            this.MailLinkSchlueter.Text = "mailto:oliver.schlueter@dell.com";
            this.MailLinkSchlueter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MailLink_LinkClicked);
            // 
            // MailLinkRohrbach
            // 
            this.MailLinkRohrbach.AutoSize = true;
            this.MailLinkRohrbach.Location = new System.Drawing.Point(80, 52);
            this.MailLinkRohrbach.Name = "MailLinkRohrbach";
            this.MailLinkRohrbach.Size = new System.Drawing.Size(166, 13);
            this.MailLinkRohrbach.TabIndex = 8;
            this.MailLinkRohrbach.TabStop = true;
            this.MailLinkRohrbach.Text = "mailto:Martin.Rohrbach@dell.com";
            this.MailLinkRohrbach.Click += new System.EventHandler(this.MailLinkRohrbach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Martin Rohrbach";
            // 
            // AboutFrm
            // 
            this.AcceptButton = this.CloseBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(280, 158);
            this.ControlBox = false;
            this.Controls.Add(this.MailLinkRohrbach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MailLinkSchlueter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About Eng Stat Converter";
            this.Load += new System.EventHandler(this.AboutFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel GitHubLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel MailLinkSchlueter;
        private System.Windows.Forms.LinkLabel MailLinkRohrbach;
        private System.Windows.Forms.Label label4;
    }
}