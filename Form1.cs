using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorcreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd(object sender, EventArgs e)
        {
            int a, b,c;
            a =Convert.ToInt32( txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a + b;
            txtOutput.Text = c.ToString("n");
        }

        private void BtnSub(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a - b;
            txtOutput.Text = c.ToString("n");
        }

        private void BtnMulti(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a * b;
            txtOutput.Text = c.ToString("n");
        }

        private void BtnDiv(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirst.Text);
            b = Convert.ToInt32(txtSecond.Text);
            c = a / b;
            txtOutput.Text = c.ToString("n");
        }

        private void BtnClick(object sender, EventArgs e)
        {
            txtFirst.Text = " ";
            txtSecond.Text = "";
            txtOutput.Text = "";
        }
    }
}
