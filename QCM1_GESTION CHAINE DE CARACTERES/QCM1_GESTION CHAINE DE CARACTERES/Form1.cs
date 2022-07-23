using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QCM1_GESTION_CHAINE_DE_CARACTERES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = richTextBox1.Text.Substring(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label3,ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try {
                textBox4.Text = richTextBox1.Text.Length.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4, ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = richTextBox1.Text.Remove(int.Parse(textBox7.Text),int.Parse(textBox6.Text)).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label5, ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try {
                if ((textBox9.Text.CompareTo(richTextBox1.Text)) == 0)
                    textBox8.Text = "les Deux Chaines est ==";
                else
                    textBox8.Text = "les Deux Chaines est !=";
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label6, ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                textBox11.Text = richTextBox1.Text.ToUpper();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label9, ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try {
                String[] s = new string[30];
                s = richTextBox1.Text.Split(' ');
                for (int i = 0; i < s.Length;i++ )
                {
                    listBox1.Items.Add(s[i]);
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label8, ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                string var = " ";
                textBox12.Text = richTextBox1.Text + var + textBox10.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label11, ex.Message);
            }

            }

     

        private void label13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox14.Text = textBox13.Text.Substring(3,2).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label13, ex.Message);
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                String[] v = new string[30];
                v = textBox15.Text.Split(' ');
                textBox16.Text = v[0].ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label15, ex.Message);
            }
        }
    }
}
