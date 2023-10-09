using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseLevel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(wTxtBox.Text) && !string.IsNullOrEmpty(hTxtBox.Text))
            {
                float fw = Single.Parse(wTxtBox.Text);
                float fh = Single.Parse(hTxtBox.Text);

                float bmi = fw / (fh * fh);

                rTxtBox.Text = bmi.ToString("0.00");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
