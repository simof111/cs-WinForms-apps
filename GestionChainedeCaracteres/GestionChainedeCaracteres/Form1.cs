using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionChainedeCaracteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text.Length.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text.Remove((int.Parse(textBox7.Text)),(int.Parse(textBox6.Text))).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text.Substring((int.Parse(textBox5.Text)),(int.Parse(textBox4.Text))).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            char x = textBox2.Text[0];

            string[] word = textBox1.Text.Split(x);
            listBox1.Items.Clear();
            foreach (string item in word)
            {
                listBox1.Items.Add(item);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text.ToUpper();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox1.Text.ToLower();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.CompareTo(textBox3.Text)) == 0)
                textBox8.Text = "les deux Chaines est =";
            else
                textBox8.Text = "les deux Chaines est !=";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            String[] A = new string[11];
            A = textBox3.Text.Split();
            textBox8.Text = A.Length.ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            int compteur = 1;
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox3.Text.Substring(i, 1).Equals(","))
                {
                    compteur = compteur + 1;
                }
            }
            textBox8.Text = compteur.ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox3.Text.Substring(i, 1).Equals("."))
                {
                    compteur = compteur + 1;
                }
            }
            textBox8.Text = compteur.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            for(int i=0 ; i< textBox1.Text.Length-textBox3.Text.Length; i++)
            {
            if(textBox1.Text.Substring(i,textBox3.Text.Length).Equals(textBox3.Text))
            {
            compteur=compteur+1;
            }
            
            }
            textBox8.Text=compteur.ToString();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            String[] v1 = new string[30];
            String[] v2 = new string[30];

            int x = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                v1[x] = textBox3.Text.Substring(i,1);
                listBox1.Items.Add(v1[x]);
                x = x + 1;
            }

            int y = 0;
            for (int i = textBox3.Text.Length - 1; i >= 0; i--)
            {
                v2[y] = textBox3.Text.Substring(i,1);
                listBox2.Items.Add(v2[y]);
                y = y + 1;
            }
           
            bool trouve = false;
            for (int idc = 0; idc < v1.Length;idc++ )
            {
                if (v1[idc] != v2[idc])
                    trouve = true;
            }

            if (trouve == false)
                textBox8.Text = "palindrome";
            else
                textBox8.Text = "ne pas palindrome";






        }

        private void label17_Click(object sender, EventArgs e)
        {
          
            //textBox8.Text = textBox1.Text.Substring(0,textBox1.Text.Length-5).ToString();

            string str = textBox1.Text.Trim();
            string result=str;
            for (int i = 0; i < 5; i++)
            {
                 result = result.Remove(result.LastIndexOf(" ", result.Length)).ToString();
            }
            textBox8.Text = result;

           
        }
    }
}
