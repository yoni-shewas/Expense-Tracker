namespace frontend_design_colorfull
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnExpRep = new FontAwesome.Sharp.IconButton();
            btnIncRep = new FontAwesome.Sharp.IconButton();
            btnMngExpense = new FontAwesome.Sharp.IconButton();
            btnMngIncome = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            btnHome = new PictureBox();
            pnlNavBar = new Panel();
            MaximizeApp = new FontAwesome.Sharp.IconPictureBox();
            MinimizeApp = new FontAwesome.Sharp.IconPictureBox();
            CloseApp = new FontAwesome.Sharp.IconPictureBox();
            lblActive = new Label();
            iconActive = new FontAwesome.Sharp.IconPictureBox();
            pnlMain = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaximizeApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconActive).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(94, 104, 109);
            pnlMenu.Controls.Add(btnExpRep);
            pnlMenu.Controls.Add(btnIncRep);
            pnlMenu.Controls.Add(btnMngExpense);
            pnlMenu.Controls.Add(btnMngIncome);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 441);
            pnlMenu.TabIndex = 0;
            pnlMenu.Paint += panel1_Paint;
            // 
            // btnExpRep
            // 
            btnExpRep.Dock = DockStyle.Top;
            btnExpRep.FlatAppearance.BorderSize = 0;
            btnExpRep.FlatStyle = FlatStyle.Flat;
            btnExpRep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpRep.ForeColor = Color.WhiteSmoke;
            btnExpRep.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            btnExpRep.IconColor = Color.WhiteSmoke;
            btnExpRep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExpRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpRep.Location = new Point(0, 270);
            btnExpRep.Name = "btnExpRep";
            btnExpRep.Padding = new Padding(15, 0, 20, 0);
            btnExpRep.Size = new Size(230, 50);
            btnExpRep.TabIndex = 5;
            btnExpRep.Text = "Expense Reports\t";
            btnExpRep.TextAlign = ContentAlignment.MiddleLeft;
            btnExpRep.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExpRep.UseVisualStyleBackColor = true;
            btnExpRep.Click += btnExpRep_Click;
            // 
            // btnIncRep
            // 
            btnIncRep.Dock = DockStyle.Top;
            btnIncRep.FlatAppearance.BorderSize = 0;
            btnIncRep.FlatStyle = FlatStyle.Flat;
            btnIncRep.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncRep.ForeColor = Color.WhiteSmoke;
            btnIncRep.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnIncRep.IconColor = Color.WhiteSmoke;
            btnIncRep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIncRep.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncRep.Location = new Point(0, 220);
            btnIncRep.Name = "btnIncRep";
            btnIncRep.Padding = new Padding(15, 0, 20, 0);
            btnIncRep.Size = new Size(230, 50);
            btnIncRep.TabIndex = 4;
            btnIncRep.Text = "Income Reports\t";
            btnIncRep.TextAlign = ContentAlignment.MiddleLeft;
            btnIncRep.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIncRep.UseVisualStyleBackColor = true;
            btnIncRep.Click += btnIncRep_Click;
            // 
            // btnMngExpense
            // 
            btnMngExpense.Dock = DockStyle.Top;
            btnMngExpense.FlatAppearance.BorderSize = 0;
            btnMngExpense.FlatStyle = FlatStyle.Flat;
            btnMngExpense.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMngExpense.ForeColor = Color.WhiteSmoke;
            btnMngExpense.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            btnMngExpense.IconColor = Color.WhiteSmoke;
            btnMngExpense.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMngExpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngExpense.Location = new Point(0, 170);
            btnMngExpense.Name = "btnMngExpense";
            btnMngExpense.Padding = new Padding(15, 0, 20, 0);
            btnMngExpense.Size = new Size(230, 50);
            btnMngExpense.TabIndex = 3;
            btnMngExpense.Text = "Manage Expenses\t";
            btnMngExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnMngExpense.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngExpense.UseVisualStyleBackColor = true;
            btnMngExpense.Click += btnMngExpense_Click;
            // 
            // btnMngIncome
            // 
            btnMngIncome.Dock = DockStyle.Top;
            btnMngIncome.FlatAppearance.BorderSize = 0;
            btnMngIncome.FlatStyle = FlatStyle.Flat;
            btnMngIncome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMngIncome.ForeColor = Color.WhiteSmoke;
            btnMngIncome.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btnMngIncome.IconColor = Color.WhiteSmoke;
            btnMngIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMngIncome.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngIncome.Location = new Point(0, 120);
            btnMngIncome.Name = "btnMngIncome";
            btnMngIncome.Padding = new Padding(15, 0, 20, 0);
            btnMngIncome.Size = new Size(230, 50);
            btnMngIncome.TabIndex = 2;
            btnMngIncome.Text = "Manage Income\t";
            btnMngIncome.TextAlign = ContentAlignment.MiddleLeft;
            btnMngIncome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngIncome.UseVisualStyleBackColor = true;
            btnMngIncome.Click += btnMngIncome_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.WhiteSmoke;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnDashboard.IconColor = Color.WhiteSmoke;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 70);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 20, 0);
            btnDashboard.Size = new Size(230, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(btnHome);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 70);
            pnlLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = Properties.Resources.logo;
            btnHome.Location = new Point(48, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(110, 55);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += pictureBox1_Click;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(94, 104, 109);
            pnlNavBar.Controls.Add(MaximizeApp);
            pnlNavBar.Controls.Add(MinimizeApp);
            pnlNavBar.Controls.Add(CloseApp);
            pnlNavBar.Controls.Add(lblActive);
            pnlNavBar.Controls.Add(iconActive);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(230, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(555, 50);
            pnlNavBar.TabIndex = 1;
            pnlNavBar.Paint += pnlNavBar_Paint;
            // 
            // MaximizeApp
            // 
            MaximizeApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeApp.BackColor = Color.FromArgb(94, 104, 109);
            MaximizeApp.ForeColor = SystemColors.ControlText;
            MaximizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            MaximizeApp.IconColor = SystemColors.ControlText;
            MaximizeApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MaximizeApp.IconSize = 21;
            MaximizeApp.Location = new Point(485, 3);
            MaximizeApp.Name = "MaximizeApp";
            MaximizeApp.Size = new Size(32, 32);
            MaximizeApp.TabIndex = 4;
            MaximizeApp.TabStop = false;
            MaximizeApp.Click += MaximizeApp_Click;
            // 
            // MinimizeApp
            // 
            MinimizeApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeApp.BackColor = Color.FromArgb(94, 104, 109);
            MinimizeApp.ForeColor = SystemColors.ControlText;
            MinimizeApp.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            MinimizeApp.IconColor = SystemColors.ControlText;
            MinimizeApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MinimizeApp.IconSize = 21;
            MinimizeApp.Location = new Point(447, 3);
            MinimizeApp.Name = "MinimizeApp";
            MinimizeApp.Size = new Size(32, 32);
            MinimizeApp.TabIndex = 3;
            MinimizeApp.TabStop = false;
            MinimizeApp.Click += MinimizeApp_Click;
            // 
            // CloseApp
            // 
            CloseApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseApp.BackColor = Color.FromArgb(94, 104, 109);
            CloseApp.ForeColor = SystemColors.ControlText;
            CloseApp.IconChar = FontAwesome.Sharp.IconChar.Close;
            CloseApp.IconColor = SystemColors.ControlText;
            CloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CloseApp.IconSize = 21;
            CloseApp.Location = new Point(523, 3);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new Size(32, 32);
            CloseApp.TabIndex = 2;
            CloseApp.TabStop = false;
            CloseApp.Click += CloseApp_Click;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActive.ForeColor = Color.WhiteSmoke;
            lblActive.Location = new Point(44, 26);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(50, 18);
            lblActive.TabIndex = 1;
            lblActive.Text = "Home";
            lblActive.Click += label1_Click;
            // 
            // iconActive
            // 
            iconActive.BackColor = Color.FromArgb(94, 104, 109);
            iconActive.ForeColor = Color.FromArgb(252, 199, 55);
            iconActive.IconChar = FontAwesome.Sharp.IconChar.House;
            iconActive.IconColor = Color.FromArgb(252, 199, 55);
            iconActive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconActive.Location = new Point(6, 12);
            iconActive.Name = "iconActive";
            iconActive.Size = new Size(32, 32);
            iconActive.TabIndex = 0;
            iconActive.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(94, 104, 109);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(230, 50);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(555, 391);
            pnlMain.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 441);
            Controls.Add(pnlMain);
            Controls.Add(pnlNavBar);
            Controls.Add(pnlMenu);
            Name = "FormMain";
            Text = "FormMain";
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaximizeApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconActive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnExpRep;
        private FontAwesome.Sharp.IconButton btnIncRep;
        private FontAwesome.Sharp.IconButton btnMngExpense;
        private FontAwesome.Sharp.IconButton btnMngIncome;
        private PictureBox btnHome;
        private Panel pnlNavBar;
        private FontAwesome.Sharp.IconPictureBox iconActive;
        private Label lblActive;
        private Panel pnlMain;
        private FontAwesome.Sharp.IconPictureBox MaximizeApp;
        private FontAwesome.Sharp.IconPictureBox MinimizeApp;
        private FontAwesome.Sharp.IconPictureBox CloseApp;
    }
}
