using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pile_Exercices
{
    public partial class Form1 : Form
    {
        int s = 0;
        int ech = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             int n = 1;
            for (int i = 2; i <= (int.Parse(textBox1.Text));i++ )
            {
               
                n = n * i;
            }
            textBox2.Text = n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((int.Parse(textBox4.Text)) >= 20 && (int.Parse(textBox4.Text)) <= 30)
            {
                s = s + (int.Parse(textBox4.Text));
                ech++;
                textBox4.Clear();
            }
            else
                MessageBox.Show("Entrer un nombre entre 20 et 30"); 


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = int.Parse(textBox4.Text);
            if (r >= 20 && r <= 30)
            {
                s = s - r;
                ech--;
                textBox4.Clear();
            }
            else
                MessageBox.Show("Entrer un nombre entre 20 et 30");

            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (s>=10 && s<=90)
                {
                checkBox2.Checked = false;
                textBox3.Text = s.ToString();
                label6.Text = "exact";
                }
                else if (s < 10)
                {
                    checkBox2.Checked = false;
                    label6.Text = "Plut Petit!";
                   
                }

                else if ((s) > 90)
                {
                    checkBox2.Checked = false;
                    label6.Text = "Plus Grand!";
                  
                }


                }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if ((s / ech) >= 10 && (s / ech) <= 90)
                {
                    checkBox1.Checked = false;
                    textBox3.Text = (s / ech).ToString();
                    label6.Text = "exact";
                }
                else if ((s / ech) < 10)
                {
                    checkBox1.Checked = false;
                    label6.Text = "Plut Petit!";

                }
                else if ((s / ech) > 90)
                {
                    checkBox1.Checked = false;
                    label6.Text = "Plus Grand!";
                }


                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            string res = textBox5.Text;

            if (res.Equals("6") || res.Equals("7"))
            {
                textBox6.Text = "Poussin";
                textBox5.Clear();
            }
            else if (res.Equals("8") || res.Equals("9"))
            {
                textBox6.Text = "Pupille";
                textBox5.Clear();
                
            }
            else if (res.Equals("10") || res.Equals("11"))
            {
                textBox6.Text = "Minime";
                textBox5.Clear();

            }
            else if (res.CompareTo("11")==1 && int.Parse(res)>0)
            {
                textBox6.Text = "Cadet";
                textBox5.Clear();

            }
            else
            {
                MessageBox.Show("inconu");
                textBox5.Clear();
            }

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
