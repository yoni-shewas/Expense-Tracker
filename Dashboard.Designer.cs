﻿namespace Expense_Tracker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addExpenseLink = new System.Windows.Forms.LinkLabel();
            this.summaryPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseDBDataSet = new Expense_Tracker.ExpenseDBDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.navPanel = new System.Windows.Forms.Panel();
            this.ExpenseNav = new System.Windows.Forms.Button();
            this.BudgetNav = new System.Windows.Forms.Button();
            this.HomeNav = new System.Windows.Forms.Button();
            this.ProfileNav = new System.Windows.Forms.Button();
            this.ProfilePanel = new System.Windows.Forms.Panel();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogoutLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.expenseTableAdapter = new Expense_Tracker.ExpenseDBDataSetTableAdapters.ExpenseTableAdapter();
            this.ExpensePanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.filterEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.filterMaxAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.filterCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.filterMinAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BudgetPanel = new System.Windows.Forms.Panel();
            this.HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDBDataSet)).BeginInit();
            this.navPanel.SuspendLayout();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterMaxAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterMinAmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.HomePanel.Controls.Add(this.linkLabel2);
            this.HomePanel.Controls.Add(this.linkLabel1);
            this.HomePanel.Controls.Add(this.addExpenseLink);
            this.HomePanel.Controls.Add(this.summaryPie);
            this.HomePanel.Controls.Add(this.dataGridView1);
            this.HomePanel.Controls.Add(this.label8);
            this.HomePanel.Controls.Add(this.label7);
            this.HomePanel.Controls.Add(this.label5);
            this.HomePanel.Controls.Add(this.label4);
            this.HomePanel.Controls.Add(this.label3);
            this.HomePanel.Controls.Add(this.textBox3);
            this.HomePanel.Controls.Add(this.label2);
            this.HomePanel.Controls.Add(this.textBox2);
            this.HomePanel.Controls.Add(this.label1);
            this.HomePanel.Controls.Add(this.textBox1);
            this.HomePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1060, 672);
            this.HomePanel.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(720, 540);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(103, 20);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "- Set Budget";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(720, 516);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(165, 20);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "- Manage Categories";
            // 
            // addExpenseLink
            // 
            this.addExpenseLink.AutoSize = true;
            this.addExpenseLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseLink.Location = new System.Drawing.Point(720, 492);
            this.addExpenseLink.Name = "addExpenseLink";
            this.addExpenseLink.Size = new System.Drawing.Size(151, 20);
            this.addExpenseLink.TabIndex = 9;
            this.addExpenseLink.TabStop = true;
            this.addExpenseLink.Text = "- Add new expense";
            // 
            // summaryPie
            // 
            this.summaryPie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.summaryPie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea3.Name = "ChartArea1";
            this.summaryPie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.summaryPie.Legends.Add(legend3);
            this.summaryPie.Location = new System.Drawing.Point(600, 132);
            this.summaryPie.Name = "summaryPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.summaryPie.Series.Add(series3);
            this.summaryPie.Size = new System.Drawing.Size(396, 252);
            this.summaryPie.TabIndex = 15;
            this.summaryPie.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.categoryName,
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expenseBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(24, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 264);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "user";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.Width = 125;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "category";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            this.categoryName.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataMember = "Expense";
            this.expenseBindingSource.DataSource = this.expenseDBDataSetBindingSource;
            // 
            // expenseDBDataSetBindingSource
            // 
            this.expenseDBDataSetBindingSource.DataSource = this.expenseDBDataSet;
            this.expenseDBDataSetBindingSource.Position = 0;
            // 
            // expenseDBDataSet
            // 
            this.expenseDBDataSet.DataSetName = "ExpenseDBDataSet";
            this.expenseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(696, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quick Links";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(156, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Recent Transactions";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(648, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expense Summary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(180, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Expense";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(120, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Expense:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(84, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reamining Budget: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(132, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Income: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 0;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navPanel.Controls.Add(this.ExpenseNav);
            this.navPanel.Controls.Add(this.BudgetNav);
            this.navPanel.Controls.Add(this.HomeNav);
            this.navPanel.Controls.Add(this.ProfileNav);
            this.navPanel.Location = new System.Drawing.Point(276, 12);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(444, 36);
            this.navPanel.TabIndex = 7;
            // 
            // ExpenseNav
            // 
            this.ExpenseNav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExpenseNav.Location = new System.Drawing.Point(348, 0);
            this.ExpenseNav.Name = "ExpenseNav";
            this.ExpenseNav.Size = new System.Drawing.Size(75, 35);
            this.ExpenseNav.TabIndex = 13;
            this.ExpenseNav.Text = "Expense";
            this.ExpenseNav.UseVisualStyleBackColor = false;
            this.ExpenseNav.Click += new System.EventHandler(this.ExpenseNav_Click);
            // 
            // BudgetNav
            // 
            this.BudgetNav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BudgetNav.Location = new System.Drawing.Point(240, 0);
            this.BudgetNav.Name = "BudgetNav";
            this.BudgetNav.Size = new System.Drawing.Size(75, 35);
            this.BudgetNav.TabIndex = 12;
            this.BudgetNav.Text = "Budget";
            this.BudgetNav.UseVisualStyleBackColor = false;
            this.BudgetNav.Click += new System.EventHandler(this.BudgetNav_Click);
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
            this.ProfileNav.Location = new System.Drawing.Point(132, 0);
            this.ProfileNav.Name = "ProfileNav";
            this.ProfileNav.Size = new System.Drawing.Size(75, 35);
            this.ProfileNav.TabIndex = 10;
            this.ProfileNav.Text = "Profile";
            this.ProfileNav.UseVisualStyleBackColor = false;
            this.ProfileNav.Click += new System.EventHandler(this.ProfileNav_Click);
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
            this.UserPanel.Location = new System.Drawing.Point(900, 0);
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
            // expenseTableAdapter
            // 
            this.expenseTableAdapter.ClearBeforeFill = true;
            // 
            // ExpensePanel
            // 
            this.ExpensePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExpensePanel.Controls.Add(this.label14);
            this.ExpensePanel.Controls.Add(this.filterEndDatePicker);
            this.ExpensePanel.Controls.Add(this.filterStartDatePicker);
            this.ExpensePanel.Controls.Add(this.filterMaxAmountNumericUpDown);
            this.ExpensePanel.Controls.Add(this.label15);
            this.ExpensePanel.Controls.Add(this.filterCategoryComboBox);
            this.ExpensePanel.Controls.Add(this.filterMinAmountNumericUpDown);
            this.ExpensePanel.Controls.Add(this.label13);
            this.ExpensePanel.Controls.Add(this.filterButton);
            this.ExpensePanel.Controls.Add(this.label12);
            this.ExpensePanel.Controls.Add(this.label11);
            this.ExpensePanel.Controls.Add(this.label9);
            this.ExpensePanel.Controls.Add(this.label6);
            this.ExpensePanel.Controls.Add(this.dataGridView2);
            this.ExpensePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExpensePanel.Location = new System.Drawing.Point(0, 0);
            this.ExpensePanel.Name = "ExpensePanel";
            this.ExpensePanel.Size = new System.Drawing.Size(1060, 671);
            this.ExpensePanel.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(24, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 22);
            this.label14.TabIndex = 32;
            this.label14.Text = "From: ";
            // 
            // filterEndDatePicker
            // 
            this.filterEndDatePicker.Location = new System.Drawing.Point(360, 192);
            this.filterEndDatePicker.Name = "filterEndDatePicker";
            this.filterEndDatePicker.Size = new System.Drawing.Size(228, 22);
            this.filterEndDatePicker.TabIndex = 31;
            // 
            // filterStartDatePicker
            // 
            this.filterStartDatePicker.Location = new System.Drawing.Point(84, 192);
            this.filterStartDatePicker.Name = "filterStartDatePicker";
            this.filterStartDatePicker.Size = new System.Drawing.Size(228, 22);
            this.filterStartDatePicker.TabIndex = 30;
            // 
            // filterMaxAmountNumericUpDown
            // 
            this.filterMaxAmountNumericUpDown.Location = new System.Drawing.Point(516, 144);
            this.filterMaxAmountNumericUpDown.Name = "filterMaxAmountNumericUpDown";
            this.filterMaxAmountNumericUpDown.Size = new System.Drawing.Size(72, 22);
            this.filterMaxAmountNumericUpDown.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(324, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 22);
            this.label15.TabIndex = 33;
            this.label15.Text = "To: ";
            // 
            // filterCategoryComboBox
            // 
            this.filterCategoryComboBox.FormattingEnabled = true;
            this.filterCategoryComboBox.Items.AddRange(new object[] {
            "category",
            "amount",
            "date"});
            this.filterCategoryComboBox.Location = new System.Drawing.Point(120, 144);
            this.filterCategoryComboBox.Name = "filterCategoryComboBox";
            this.filterCategoryComboBox.Size = new System.Drawing.Size(168, 24);
            this.filterCategoryComboBox.TabIndex = 20;
            // 
            // filterMinAmountNumericUpDown
            // 
            this.filterMinAmountNumericUpDown.Location = new System.Drawing.Point(360, 144);
            this.filterMinAmountNumericUpDown.Name = "filterMinAmountNumericUpDown";
            this.filterMinAmountNumericUpDown.Size = new System.Drawing.Size(72, 22);
            this.filterMinAmountNumericUpDown.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(456, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "Max: ";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Turquoise;
            this.filterButton.Location = new System.Drawing.Point(504, 240);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 24;
            this.filterButton.Text = "Go";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(312, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "Min: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(24, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "Category: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(48, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Filter by: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "All Transactions";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.expenseBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(36, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(552, 360);
            this.dataGridView2.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn1.HeaderText = "user";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "categoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "category";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "amount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // BudgetPanel
            // 
            this.BudgetPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BudgetPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BudgetPanel.Location = new System.Drawing.Point(0, 0);
            this.BudgetPanel.Name = "BudgetPanel";
            this.BudgetPanel.Size = new System.Drawing.Size(1060, 671);
            this.BudgetPanel.TabIndex = 11;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.ExpensePanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ProfilePanel);
            this.Controls.Add(this.BudgetPanel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.summaryPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDBDataSet)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ExpensePanel.ResumeLayout(false);
            this.ExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterMaxAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterMinAmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button ProfileNav;
        private System.Windows.Forms.Button HomeNav;
        private System.Windows.Forms.Panel ProfilePanel;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.LinkLabel LogoutLink;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource expenseDBDataSetBindingSource;
        private ExpenseDBDataSet expenseDBDataSet;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private ExpenseDBDataSetTableAdapters.ExpenseTableAdapter expenseTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart summaryPie;
        private System.Windows.Forms.LinkLabel addExpenseLink;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button ExpenseNav;
        private System.Windows.Forms.Button BudgetNav;
        private System.Windows.Forms.Panel ExpensePanel;
        private System.Windows.Forms.Panel BudgetPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox filterCategoryComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.NumericUpDown filterMaxAmountNumericUpDown;
        private System.Windows.Forms.NumericUpDown filterMinAmountNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker filterEndDatePicker;
        private System.Windows.Forms.DateTimePicker filterStartDatePicker;
    }
}