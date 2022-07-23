using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC1_TEAMS_LPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = richTextBox1.Text.Length.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label9, ex.Message);
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {
            try
            {

                int compteur = 0;
                for (int i = 0; i < richTextBox1.Text.Length - 4; i++)
                {
                    if (richTextBox1.Text.Substring(i, 4).Equals("Mlle"))
                    {
                        compteur = compteur + 1;
                    }

                }
                textBox2.Text = compteur.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label8,ex.Message);
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                int compteur = 0;
                for (int i = 0; i < richTextBox1.Text.Length - 2; i++)
                {
                    if (richTextBox1.Text.Substring(i, 2).Equals("Jh"))
                    {
                        compteur = compteur + 1;
                    }

                }
                textBox3.Text = compteur.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label7, ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                int compteur = 0;
                for (int i = 0; i < richTextBox1.Text.Length - richTextBox2.Text.Length; i++)
                {
                    if (richTextBox1.Text.Substring(i, richTextBox2.Text.Length).Equals(richTextBox2.Text))
                    {
                        compteur = compteur + 1;
                    }

                }
                textBox4.Text = compteur.ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label6, ex.Message);
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                String[] v1 = new string[30];
                String[] v2 = new string[30];

                int x = 0;

                for (int i = 0; i < richTextBox2.Text.Length; i++)
                {
                    v1[x] = richTextBox2.Text.Substring(i, 1);

                    x = x + 1;
                }

                int y = 0;
                for (int i = richTextBox2.Text.Length - 1; i >= 0; i--)
                {
                    v2[y] = richTextBox2.Text.Substring(i, 1);

                    y = y + 1;
                }

                bool trouve = false;
                for (int idc = 0; idc < v1.Length; idc++)
                {
                    if (v1[idc] != v2[idc])
                        trouve = true;
                }

                if (trouve == false)
                    textBox5.Text = "palindrome";
                else
                    textBox5.Text = "ne pas palindrome";
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label5, ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                String[] s1 = new string[30];

                s1 = richTextBox1.Text.Split();
                for (int i = 2; i < s1.Length; i++)
                {
                    richTextBox3.Text = richTextBox3.Text + " " + s1[i];
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4,ex.Message);
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            try
            {
                String[] s2 = new string[30];

                s2 = richTextBox1.Text.Split();
                for (int i = 0; i < s2.Length-1; i++)
                {
                    richTextBox4.Text = richTextBox4.Text + " " + s2[i];
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label11, ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] T = new double[2, 2];

                T[0, 0] = 12;
                T[0, 1] = 14;
                T[1, 0] = 16;
                T[1, 1] = 18;

                for (int i = 0; i < 2;i++ )
                {
                    dataGridView1.Rows.Add(T[i,0],T[i,1]);
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label12, ex.Message);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            try
            {
                String[] s = new string[30];
                s = richTextBox1.Text.Split(' ');

                string[,] T1 = new string[4, 4];
                for (int i = 0; i < 4;i++ )
                {
                    T1[0,i] = s[i];
                }
                for (int y = 0; y < 4; y++)
                {
                    dataGridView2[y,0].Value=T1[0,y];
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label13, ex.Message);
            }
        }

      
    }
}
