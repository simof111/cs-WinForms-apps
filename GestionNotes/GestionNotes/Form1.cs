using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox4.Text != "" && comboBox5.Text != "")
            {
                

                textBox1.Text = ((Convert.ToDouble(comboBox4.Text) + Convert.ToDouble(comboBox5.Text) + Convert.ToDouble(comboBox6.Text)) / 4).ToString("#0.##");
            }
            else
            {
                errorProvider1.SetError(comboBox4,"Cc1 non Renseignee");
            
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
errorProvider1.Dispose();
        }
    }
}
