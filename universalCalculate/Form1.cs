using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace universalCalculate
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelChoosing.Visible = false;
            panelSubInfo.Visible = false;
            //..
        }
        private void hideMenu()
        {
            if (panelChoosing.Visible == true)
                panelChoosing.Visible = false;
            if (panelSubInfo.Visible == true)
                panelSubInfo.Visible = false;
        }
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnChoosing_Click(object sender, EventArgs e)
        {
            showMenu(panelChoosing);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new pnumber());
            //my code
            hideMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new complex());
            //my code
            hideMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new drobi());
            //my code
            hideMenu();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showMenu(panelSubInfo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //my code
            hideMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //my code
            hideMenu();
        }
    }
}