using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 + num2;
                textBox3.Text = result.ToString();
                textBox1.Text = textBox3.Text;
                textBox2.Text = "";
            }
            else
                MessageBox.Show("Error");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 - num2;
                textBox3.Text = result.ToString();
                textBox1.Text = textBox3.Text;
                textBox2.Text = "";
            }
            else
                MessageBox.Show("Error");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                double result = num1 * num2;
                textBox3.Text = result.ToString();
                textBox1.Text = textBox3.Text;
                textBox2.Text = "";
            }
            else
                MessageBox.Show("Error");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                double result = (double)num1 / num2;
                textBox3.Text = result.ToString();
                textBox1.Text = textBox3.Text;
                textBox2.Text = "";
            }
            else
                MessageBox.Show("Error");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
         
        }
    }
}
