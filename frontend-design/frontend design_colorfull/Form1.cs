using System;
using FontAwesome.Sharp;



namespace frontend_design_colorfull
{
    public partial class FormMain : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentSubForm;
        public FormMain()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 50);
            pnlMenu.Controls.Add(leftBorderBtn);
        }


        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child form
                iconActive.IconChar = currentBtn.IconChar;
                iconActive.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(94, 104, 109);
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.WhiteSmoke;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(252, 199, 55));
            OpenSubForm(new FormDashboard());
        }

        private void btnMngIncome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(252, 199, 55));
            OpenSubForm(new FormManageIncome());
        }

        private void btnMngExpense_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(252, 199, 55));
            OpenSubForm(new FormManageExpenses());
        }

        private void btnIncRep_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(252, 199, 55));
            OpenSubForm(new FormIncomeReports());
        }

        private void btnExpRep_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(252, 199, 55));
            OpenSubForm(new FormExpenseReports());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentSubForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconActive.IconChar = IconChar.Home;
            iconActive.ForeColor = Color.FromArgb(252, 199, 55);
            lblActive.Text = "Home";
        }

        private void OpenSubForm(Form subForm)
        {
            if (currentSubForm != null)
            {
                currentSubForm.Close();
            }
            currentSubForm = subForm;
            currentSubForm.TopLevel = false;
            currentSubForm.FormBorderStyle = FormBorderStyle.None; //remove edges of the form
            currentSubForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(subForm);
            pnlMain.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();
            lblActive.Text = subForm.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeApp_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
