namespace Expense_Tracker
{
    partial class Dashboard
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.HomeNav = new System.Windows.Forms.Button();
            this.ProfileNav = new System.Windows.Forms.Button();
            this.ReportNav = new System.Windows.Forms.Button();
            this.ReportPanel = new System.Windows.Forms.Panel();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.navPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HomePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1060, 671);
            this.HomePanel.TabIndex = 2;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navPanel.Controls.Add(this.HomeNav);
            this.navPanel.Controls.Add(this.ProfileNav);
            this.navPanel.Controls.Add(this.ReportNav);
            this.navPanel.Location = new System.Drawing.Point(12, 12);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(456, 36);
            this.navPanel.TabIndex = 7;
            // 
            // HomeNav
            // 
            this.HomeNav.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HomeNav.Location = new System.Drawing.Point(12, 0);
            this.HomeNav.Name = "HomeNav";
            this.HomeNav.Size = new System.Drawing.Size(75, 35);
            this.HomeNav.TabIndex = 9;
            this.HomeNav.Text = "Home";
            this.HomeNav.UseVisualStyleBackColor = false;
            this.HomeNav.Click += new System.EventHandler(this.HomeNav_Click);
            // 
            // ProfileNav
            // 
            this.ProfileNav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ProfileNav.Location = new System.Drawing.Point(120, 0);
            this.ProfileNav.Name = "ProfileNav";
            this.ProfileNav.Size = new System.Drawing.Size(75, 35);
            this.ProfileNav.TabIndex = 10;
            this.ProfileNav.Text = "Profile";
            this.ProfileNav.UseVisualStyleBackColor = false;
            this.ProfileNav.Click += new System.EventHandler(this.ProfileNav_Click);
            // 
            // ReportNav
            // 
            this.ReportNav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ReportNav.Location = new System.Drawing.Point(228, 0);
            this.ReportNav.Name = "ReportNav";
            this.ReportNav.Size = new System.Drawing.Size(75, 35);
            this.ReportNav.TabIndex = 11;
            this.ReportNav.Text = "Report";
            this.ReportNav.UseVisualStyleBackColor = false;
            this.ReportNav.Click += new System.EventHandler(this.ReportNav_Click);
            // 
            // ReportPanel
            // 
            this.ReportPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReportPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReportPanel.Location = new System.Drawing.Point(0, 0);
            this.ReportPanel.Name = "ReportPanel";
            this.ReportPanel.Size = new System.Drawing.Size(1060, 671);
            this.ReportPanel.TabIndex = 9;
            // 
            // ProfilePanel
            // 
            this.ProfilePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ProfilePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.ProfilePanel.Name = "ProfilePanel";
            this.ProfilePanel.Size = new System.Drawing.Size(1060, 671);
            this.ProfilePanel.TabIndex = 10;
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UserPanel.Controls.Add(this.UserNameLabel);
            this.UserPanel.Controls.Add(this.LogoutLink);
            this.UserPanel.Controls.Add(this.pictureBox2);
            this.UserPanel.Location = new System.Drawing.Point(900, 12);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(156, 60);
            this.UserPanel.TabIndex = 12;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserNameLabel.Location = new System.Drawing.Point(48, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(90, 32);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "Login";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogoutLink
            // 
            this.LogoutLink.AutoSize = true;
            this.LogoutLink.Location = new System.Drawing.Point(60, 36);
            this.LogoutLink.Name = "LogoutLink";
            this.LogoutLink.Size = new System.Drawing.Size(48, 16);
            this.LogoutLink.TabIndex = 8;
            this.LogoutLink.TabStop = true;
            this.LogoutLink.Text = "Logout";
            this.LogoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Expense_Tracker.Properties.Resources.profile_svgrepo_com;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.ReportPanel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.navPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button ReportNav;
        private System.Windows.Forms.Button ProfileNav;
        private System.Windows.Forms.Button HomeNav;
        private System.Windows.Forms.Panel ReportPanel;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}