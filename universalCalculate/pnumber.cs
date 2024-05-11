using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace universalCalculate
{
    public partial class pnumber : Form
    {
        public pnumber()
        {
            InitializeComponent();
        }

        private void BtnNumberClicked(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            // this.label1.Text = button.Text;
            if (label1.Text == "0")
                label1.Text = button.Text;
            else
                label1.Text += button.Text;
        }




        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button1.Text;
            else
                label1.Text += button1.Text;
        }

        private void pnumber_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button2.Text;
            else
                label1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button3.Text;
            else
                label1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button4.Text;
            else
                label1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button5.Text;
            else
                label1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button6.Text;
            else
                label1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button7.Text;
            else
                label1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button8.Text;
            else
                label1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button9.Text;
            else
                label1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
                label1.Text = button10.Text;
            else
                label1.Text += button10.Text;
        }
    }
}
