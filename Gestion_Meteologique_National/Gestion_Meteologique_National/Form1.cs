using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Meteologique_National
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Casa","Janvier","12 degree","Cotiere");
            dataGridView1.Rows.Add("Fes", "Janvier", "14 degree", "Interieur");
            dataGridView1.Rows.Add("Casa", "December", "25 degree", "Cotiere");
            dataGridView1.Rows.Add("Tanger", "Janvier", "10 degree", "Cotiere");
            dataGridView1.Rows.Add("Rabat", "November", "20 degree", "Cotiere");
            dataGridView1.Rows.Add("Settat", "Mars", "15 degree", "Interieur");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1;i++ )
            {
               
                if (comboBox1.Text == dataGridView1[0, i].Value.ToString())
                    dataGridView2.Rows.Add(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), dataGridView1[3, i].Value.ToString());

            }

            textBox1.Text = (dataGridView2.Rows.Count - 1).ToString();
        }
    }
}
