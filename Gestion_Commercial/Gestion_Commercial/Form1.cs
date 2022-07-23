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


namespace Gestion_Commercial
{
    public partial class Form1 : Form
    {
        produit P;
        facture F;
        BinaryFormatter r = new BinaryFormatter();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                P = new produit(Convert.ToInt32(dataGridView1[0,dataGridView1.CurrentRow.Index].Value), 
                    dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                    dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(),
                    Convert.ToDouble(dataGridView1[3, dataGridView1.CurrentRow.Index].Value), 
                    Convert.ToInt32(dataGridView1[4, dataGridView1.CurrentRow.Index].Value));
                Stream p = File.Open("produits.dat",FileMode.Append);   
                r.Serialize(p, P);
                p.Close();
               
                label7.Visible = true;

            }
            catch(Exception ex)
            {
                errorProvider1.SetError(dataGridView1,ex.Message);
            }
        }

        private void afficherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("produits.dat",FileMode.Open);
                dataGridView2.Rows.Clear();
                while(g.Position<g.Length)
                {

                    P = (produit)v.Deserialize(g);
                    dataGridView2.Rows.Add(P.reference, P.designation, P.prix);
                
                }
                MessageBox.Show("data exported");
                g.Close();

            }
            catch(Exception ex)
            {
                errorProvider1.SetError(dataGridView2,ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[4].Value = (Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value) * Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("produits.dat", FileMode.Open);
                dataGridView1.Rows.Clear();

                comboBox1.Items.Clear();
                while (g.Position < g.Length)
                {
                    P = (produit)v.Deserialize(g);
                        comboBox1.Items.Add(P.fr.ToString());
                    
                }

                g.Close();

            }
            catch (Exception d)
            {
                errorProvider1.SetError(comboBox1, d.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("produits.dat", FileMode.Open);
                dataGridView2.Rows.Clear();

             
                while (g.Position < g.Length )
                {
                    P = (produit)v.Deserialize(g);
                    if (P.fr==Convert.ToInt32(comboBox1.Text))
                    {
                        dataGridView2.Rows.Add(P.reference, P.designation, P.prix);                   
                    }
                }

                g.Close();
          
            }
            catch (Exception d)
            {
                errorProvider1.SetError(dataGridView2, d.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Clear();
                //partie1
                double count = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    count += Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value);
                }
                textBox1.Text = count.ToString();
                textBox2.Text = (double.Parse(textBox1.Text) * 0.2).ToString();
                textBox3.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();

                //partie 2
             
                F = new facture(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                Stream p = File.Open("Factures.dat", FileMode.Append);
                BinaryFormatter r = new BinaryFormatter();
                r.Serialize(p, F);
                p.Close();

                //partie 3
         
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("Factures.dat", FileMode.Open);
                dataGridView3.Rows.Clear();
                while (g.Position < g.Length)
                {                 
                    F = (facture)v.Deserialize(g);
                    if (g.Position == g.Length)
               
    
                            dataGridView3.Rows.Add(F.Num_facture, F.CodeClient, F.MontGlobal, F.TVA, F.MTTC);

                  
                }
                MessageBox.Show("Facture Exported");
                g.Close();

                

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(button1, ex.Message);
            }
        }

        private void produitsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Stream f = File.Open("produits.dat", FileMode.Create);
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                f.Close();

            }

            catch (Exception g)
            {
                errorProvider1.SetError(dataGridView1, g.Message);
            }
        }

        private void factureFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Stream f = File.Open("Factures.dat", FileMode.Create);
                
                dataGridView3.Rows.Clear();
                f.Close();

            }

            catch (Exception g)
            {
                errorProvider1.SetError(dataGridView3, g.Message);
            }
        }

        private void miseAJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Partie1
                Stream f = File.Open("Factures.dat", FileMode.Create);
           
                f.Close();

                //partie2

                Stream p = File.Open("Factures.dat", FileMode.Append);
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    F = new facture( Convert.ToDouble(dataGridView3[2, i].Value),
                        Convert.ToDouble(dataGridView3[3, i].Value),
                        Convert.ToDouble(dataGridView3[4, i].Value));
                   
                    //BinaryFormatter r = new BinaryFormatter();
                    r.Serialize(p, F);
                }
                
                p.Close();



            }

            catch (Exception g)
            {
                errorProvider1.SetError(dataGridView3, g.Message);
            }
        }

        private void afficherFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Factures.dat", FileMode.Open);
                dataGridView3.Rows.Clear();
                while (g.Position < g.Length)
                {

                    F = (facture)v.Deserialize(g);
                    dataGridView3.Rows.Add(F.Num_facture,F.CodeClient,F.MontGlobal,F.TVA,F.MTTC);

                }
                MessageBox.Show("data exported");
                g.Close();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView3, ex.Message);
            }
        }

    

       
    }
}
