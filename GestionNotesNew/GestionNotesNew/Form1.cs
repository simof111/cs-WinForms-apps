using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionNotesNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text != "" && comboBox5.Text != "")
            {


                textBox1.Text = ((Convert.ToDouble(comboBox5.Text) + Convert.ToDouble(comboBox4.Text) + Convert.ToDouble(comboBox6.Text)) / 4).ToString("#0.00");
            }
            else
            {
                errorProvider1.SetError(comboBox5, "Cc1 non Renseignee");

            }
            dataGridView1.Rows.Add(comboBox2.Text, textBox1.Text);
            comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
           else {
             dataGridView1.Enabled = false;
          }
        }
    }
}
