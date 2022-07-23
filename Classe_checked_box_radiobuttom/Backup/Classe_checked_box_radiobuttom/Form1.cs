using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classe_checked_box_radiobuttom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (listDesig.Items[comboBox1.SelectedIndex]).ToString();
            textBox2.Text = (listPrix.Items[comboBox1.SelectedIndex]).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(comboBox2.Text)).ToString("#0.00");
            textBox4.Text = (Convert.ToDouble(textBox3.Text) * 0.2).ToString("#0.00");
            textBox5.Text = (Convert.ToDouble(textBox3.Text) * 1.2).ToString("#0.00");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                groupBox3.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                groupBox3.Enabled = true;
            }
            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                textBox3.Text = (Convert.ToDouble(textBox3.Text) * 0.95).ToString("#0.00");
                textBox4.Text = (Convert.ToDouble(textBox3.Text) * 0.2).ToString("#0.00");
                textBox5.Text = (Convert.ToDouble(textBox3.Text) * 1.2).ToString("#0.00");

               

                dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text, textBox3.Text, Convert.ToDouble(textBox3.Text) * .05,textBox4.Text,textBox5.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                textBox3.Text = (Convert.ToDouble(textBox3.Text) * 0.93).ToString("#0.00");
                textBox4.Text = (Convert.ToDouble(textBox3.Text) * 0.2).ToString("#0.00");
                textBox5.Text = (Convert.ToDouble(textBox3.Text) * 1.2).ToString("#0.00");
                dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text, textBox3.Text, Convert.ToDouble(textBox3.Text) * .07, textBox4.Text, textBox5.Text);
            }
        }
    }
}
