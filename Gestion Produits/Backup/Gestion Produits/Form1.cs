using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_Produits
{
    public partial class Form1 : Form
    {
        Produit s;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {

                s = new Produit(comboBox1.Text,comboBox2.Text,int.Parse(textBox1.Text),int.Parse(textBox2.Text),textBox3.Text);
                Stream f = File.Open("Produit.dat", FileMode.Append);
                BinaryFormatter r = new BinaryFormatter();
                r.Serialize(f, s);
                f.Close();

                comboBox1.Text = ""; comboBox2.Text = ""; textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label6, ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("Produit.dat", FileMode.Open);

                dataGridView1.Rows.Clear();
                while (g.Position < g.Length)
                {
                    s = (Produit)v.Deserialize(g);
                    dataGridView1.Rows.Add(s.Reference,s.Designation,s.Stock,s.Prix,s.CFournisseur);
                }
                g.Close();

                MessageBox.Show("Data Exported");
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
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("Produit.dat", FileMode.Open);

                dataGridView1.Rows.Clear();
          
                while (g.Position < g.Length)
                {

                    s = (Produit)v.Deserialize(g);
                    if (s.Reference.Equals(textBox4.Text))
                        dataGridView1.Rows.Add(s.Reference, s.Designation, s.Stock, s.Prix, s.CFournisseur);
                  
                }
                g.Close();
        
                    MessageBox.Show("Data Exported");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4, ex.Message);
            }
        }
    }
}
