using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblLcd.Text = "";
            lblLcd.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            lblLcd.Text += "2";
        }
    }
}
