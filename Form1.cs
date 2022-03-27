using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
        }

        private void o10_Click(object sender, EventArgs e)
        {
            this.Opacity = .1;
        }

        private void o20_Click(object sender, EventArgs e)
        {
            this.Opacity = .2;
        }

        private void o30_Click(object sender, EventArgs e)
        {
            this.Opacity = .3;
        }

        private void o40_Click(object sender, EventArgs e)
        {
            this.Opacity = .4;
        }

        private void o50_Click(object sender, EventArgs e)
        {
            this.Opacity = .5;
        }

        private void o75_Click(object sender, EventArgs e)
        {
            this.Opacity = .75;
        }

        private void o100_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void o5_Click(object sender, EventArgs e)
        {
            this.Opacity = .05;
        }

        private void o0_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonOpenbuttonOpen_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }
    }
}
