using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionAssurance
{
    public partial class Form1 : Form
    {
        public static string sexe,ag,tex8,tex9,tex7,tex6;
        public static double total,vol,bris,bose,incedure;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {

                checkBox5.Checked = false;
                checkBox4.Checked = false;
                ag = ">=18 & <50";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked==true)
            {
                checkBox5.Checked = false;
                checkBox3.Checked = false;
                ag = ">=50 & <81";
            }
            }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                ag = ">=81";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                sexe = "Homme";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                sexe = "Femme";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                foreach (CheckBox c in this.groupBox3.Controls)
                {
                    c.Checked = true;
                }
            }
            else
            {
                foreach (CheckBox c in this.groupBox3.Controls)
                {
                    c.Checked = false;
                }
            }

            if (checkBox9.Checked == false || checkBox8.Checked == false || checkBox6.Checked == false || checkBox7.Checked == false)
                checkBox10.Checked = false;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
                total = vol + bris + bose + incedure;
            else
            {
                if (checkBox9.Checked == true)
                    total = vol;
                if (checkBox8.Checked == true)
                    total = total + bris;
                if (checkBox6.Checked == true)
                    total += bose;
                if (checkBox7.Checked == true)
                    total += incedure;
            }
            textBox6.Text = total.ToString("#0.00");
            textBox5.Text = (total * .2).ToString("#0.00");
            textBox4.Text = (Convert.ToDouble(textBox5.Text) + total).ToString("#0.00");




            dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, sexe, ag, tex9, tex8, tex6, tex7, textBox6.Text, textBox5.Text, textBox4.Text);













        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox9.Checked == true)
            {
                vol = 50;
                tex9 = "Oui";
            }
           if (checkBox9.Checked==false)
                tex9 = "Non";
            }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox8.Checked == true)
            {
                bris = 45;
                tex8 = "Oui";
            }
           else
                tex8 = "Non";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox6.Checked == true)
            {
                tex6 = "Oui";
                bose = 56;
            }
            else
                tex6 = "Non";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox7.Checked == true)
            {
                tex7 = "Oui";
                incedure = 33;
            }
            else
                tex7 = "Non";
               
        }
        
       
    }
}
