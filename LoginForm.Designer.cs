namespace Expense_Tracker
{
    partial class LoginForm
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
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.emailLoginBox = new System.Windows.Forms.TextBox();
            this.passwordLoginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameRegBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailRegBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passRegBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmPassRegBox = new System.Windows.Forms.TextBox();
            this.RegisterPanel.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RegisterPanel.Controls.Add(this.label7);
            this.RegisterPanel.Controls.Add(this.confirmPassRegBox);
            this.RegisterPanel.Controls.Add(this.label6);
            this.RegisterPanel.Controls.Add(this.passRegBox);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.emailRegBox);
            this.RegisterPanel.Controls.Add(this.LoginLink);
            this.RegisterPanel.Controls.Add(this.signUpBtn);
            this.RegisterPanel.Controls.Add(this.Register);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.nameRegBox);
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(1060, 671);
            this.RegisterPanel.TabIndex = 0;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginPanel.Controls.Add(this.linkLabel1);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.passwordLoginBox);
            this.LoginPanel.Controls.Add(this.emailLoginBox);
            this.LoginPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1060, 671);
            this.LoginPanel.TabIndex = 1;
            // 
            // emailLoginBox
            // 
            this.emailLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailLoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLoginBox.Location = new System.Drawing.Point(363, 261);
            this.emailLoginBox.Name = "emailLoginBox";
            this.emailLoginBox.Size = new System.Drawing.Size(367, 38);
            this.emailLoginBox.TabIndex = 1;
            // 
            // passwordLoginBox
            // 
            this.passwordLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordLoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginBox.Location = new System.Drawing.Point(363, 361);
            this.passwordLoginBox.Name = "passwordLoginBox";
            this.passwordLoginBox.PasswordChar = '*';
            this.passwordLoginBox.Size = new System.Drawing.Size(367, 38);
            this.passwordLoginBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(358, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(358, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(486, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginButton.Location = new System.Drawing.Point(493, 436);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(99, 35);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(508, 488);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLink.Location = new System.Drawing.Point(508, 584);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(50, 20);
            this.LoginLink.TabIndex = 12;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Login";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signUpBtn.Location = new System.Drawing.Point(479, 535);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(113, 34);
            this.signUpBtn.TabIndex = 11;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Register.Location = new System.Drawing.Point(472, 35);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(152, 39);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(358, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name:";
            // 
            // nameRegBox
            // 
            this.nameRegBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRegBox.Location = new System.Drawing.Point(363, 145);
            this.nameRegBox.Name = "nameRegBox";
            this.nameRegBox.Size = new System.Drawing.Size(367, 38);
            this.nameRegBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(358, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // emailRegBox
            // 
            this.emailRegBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailRegBox.Location = new System.Drawing.Point(363, 249);
            this.emailRegBox.Name = "emailRegBox";
            this.emailRegBox.Size = new System.Drawing.Size(367, 38);
            this.emailRegBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(358, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password:";
            // 
            // passRegBox
            // 
            this.passRegBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passRegBox.Location = new System.Drawing.Point(363, 346);
            this.passRegBox.Name = "passRegBox";
            this.passRegBox.Size = new System.Drawing.Size(367, 38);
            this.passRegBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(358, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Confirm Password:";
            // 
            // confirmPassRegBox
            // 
            this.confirmPassRegBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPassRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassRegBox.Location = new System.Drawing.Point(363, 443);
            this.confirmPassRegBox.Name = "confirmPassRegBox";
            this.confirmPassRegBox.Size = new System.Drawing.Size(367, 38);
            this.confirmPassRegBox.TabIndex = 17;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.RegisterPanel);
            this.Name = "LoginForm";
            this.Text = "Welcom to Expense Tracker app!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox passwordLoginBox;
        private System.Windows.Forms.TextBox emailLoginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confirmPassRegBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passRegBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailRegBox;
        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameRegBox;
    }
}

