using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommerceElectro
{
    public partial class Form1 : Form   //declaration global
        
    {public static Double mbg=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A1");
            comboBox1.Items.Add("A2");
            comboBox1.Items.Add("A3");
            comboBox1.Items.Add("A4");
            comboBox1.Items.Add("A5");
            comboBox1.Items.Add("A6");
            dataGridView1.Rows.Add(100, "Phone", 100, 200);
            dataGridView1.Rows.Add(101, "TV", 100, 100);
            dataGridView1.Rows.Add(102, "Headphone", 100, 220);
            dataGridView1.Rows.Add(103, "Mouse", 100, 230);
            comboBox2.Items.Add("aziz");
            comboBox2.Items.Add("ahmed");
            comboBox2.Items.Add("hamza");
            comboBox2.Items.Add("youness");
            comboBox2.Items.Add("farid");
            comboBox2.Items.Add("zakaria");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2[4, dataGridView2.CurrentRow.Index].Value = (Convert.ToDouble(dataGridView2[2, dataGridView2.CurrentRow.Index].Value) * Convert.ToDouble(dataGridView2[3, dataGridView2.CurrentRow.Index].Value)).ToString("#0.00");
            dataGridView1[2, dataGridView1.CurrentRow.Index].Value = (Convert.ToDouble(dataGridView1[2, dataGridView1.CurrentRow.Index].Value) - Convert.ToDouble(dataGridView2[3, dataGridView2.CurrentRow.Index].Value)).ToString();
            mbg = mbg + Convert.ToDouble(dataGridView2[4, dataGridView2.CurrentRow.Index].Value);
            textBox1.Text = mbg.ToString("#0.00")+" DHS";



            
            textBox2.Text = mbg.ToString("#0.00");
            textBox3.Text = (mbg * 0.2).ToString("#0.00");
            textBox4.Text = (mbg * 1.2).ToString("#0.00");
            textBox5.Text = comboBox2.Text;
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1[0, dataGridView1.CurrentRow.Index].Value, dataGridView1[1, dataGridView1.CurrentRow.Index].Value, dataGridView1[3, dataGridView1.CurrentRow.Index].Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       

      
        
       
    }
}
