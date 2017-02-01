namespace Droid_deployer
{
    partial class GitHubGUI
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
            panel1 = new System.Windows.Forms.Panel();
            _gitHubUserDetail = new Droid_deployer.GitHubUserDetail();
            _gitHubLogger = new Droid_deployer.GitHubLogger();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Location = new System.Drawing.Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(579, 252);
            panel1.TabIndex = 1;
            // 
            // _gitHubUserDetail
            // 
            _gitHubUserDetail.GitHubAdapter = null;
            _gitHubUserDetail.Location = new System.Drawing.Point(12, 12);
            _gitHubUserDetail.Name = "_gitHubUserDetail";
            _gitHubUserDetail.Size = new System.Drawing.Size(579, 64);
            _gitHubUserDetail.TabIndex = 0;
            _gitHubUserDetail.Visible = false;
            // 
            // _gitHubLogger
            // 
            _gitHubLogger.GitHubAdapter = null;
            _gitHubLogger.Location = new System.Drawing.Point(12, 12);
            _gitHubLogger.Name = "_gitHubLogger";
            _gitHubLogger.Size = new System.Drawing.Size(579, 64);
            _gitHubLogger.TabIndex = 0;
            // 
            // GitHubGUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(599, 346);
            Controls.Add(_gitHubUserDetail);
            Controls.Add(panel1);
            Controls.Add(_gitHubLogger);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "GitHubGUI";
            Text = "GitHub ";
            ResumeLayout(false);

        }

        #endregion

        private GitHubLogger _gitHubLogger;
        private System.Windows.Forms.Panel panel1;
        private GitHubUserDetail _gitHubUserDetail;
    }
}