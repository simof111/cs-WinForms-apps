using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sgcv11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Passage";
            textBox1.ForeColor = Color.Green;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Arret";
            textBox1.ForeColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ralletissement";
            textBox1.ForeColor = Color.Yellow;
        }
    }
}
