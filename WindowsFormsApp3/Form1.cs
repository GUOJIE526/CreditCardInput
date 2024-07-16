using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MaxLetterCount(TextBox textBox1, TextBox textBox2)
        {
            if (textBox1.Text.Length >= 4)
            {
                textBox2.Focus();
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MaxLetterCount(textBox2, textBox3);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MaxLetterCount(textBox3, textBox4);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             if (textBox4.Text.Length > 4)
            {
                textBox4.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MaxLetterCount(textBox1, textBox2);
        }
    }
}
