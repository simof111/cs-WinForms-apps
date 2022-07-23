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

namespace Gestion_Concour
{
    public partial class Form1 : Form
    {
        Candidat C;
        Note N;
        Resultat R;
        BinaryFormatter r = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void finToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serializationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                C = new Candidat(comboBox1.Text, txtcin.Text, txtnom.Text, txtadrs.Text, txtdplm.Text, Convert.ToDouble(txtmoy.Text), txtmtion.Text);
                Stream p = File.Open("Candidats.dat",FileMode.Append);
                r.Serialize(p, C);
                p.Close();
                txtmtion.Text = ""; txtmoy.Text = ""; txtnom.Text = ""; txtcin.Text = ""; txtadrs.Text = ""; txtdplm.Text = "";

                MessageBox.Show("Complet!");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(groupBox1,ex.Message);
            }
        }

        private void consultationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Candidats.dat", FileMode.Open);
                dataGridView1.Rows.Clear();
                while (g.Position < g.Length)
                {

                    C = (Candidat)v.Deserialize(g);
                    dataGridView1.Rows.Add(C.code,C.cin,C.nom,C.adress,C.diplome,C.moyenne,C.mention);

                }
                MessageBox.Show("data exported");
                g.Close();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView1,ex.Message);
            }
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try 
            {

                N = new Note(comboBox1.Text, Convert.ToDouble(txttheo.Text), Convert.ToDouble(txtpratic.Text));
                Stream p = File.Open("Notes.dat", FileMode.Append);
                r.Serialize(p, N);
                p.Close();

                txtpratic.Text = ""; txttheo.Text = ""; comboBox1.Text = "";
                MessageBox.Show("Complet!");

            }
            catch(Exception ex)
            {
                errorProvider1.SetError(dataGridView2,ex.Message);
            }
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Notes.dat", FileMode.Open);
                dataGridView2.Rows.Clear();
                while (g.Position < g.Length)
                {
                    N = (Note)v.Deserialize(g);
                    dataGridView2.Rows.Add(N.Ntheo,N.Nprati);
                }
                MessageBox.Show("data exported");
                g.Close();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView2, ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value = ((Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value) + Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value))/3).ToString();
            if (Convert.ToDouble( dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value)< 5)
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value = "Faile";
            else if (Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value) <= 10)
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value = "Moyenne";
            else if (Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value) >10)
                    dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value = "Bien";
        
        }

        private void serializationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Stream g = File.Open("Candidats.dat",FileMode.Open);
                Stream j = File.Open("Notes.dat",FileMode.Open);

                while(g.Position<g.Length && j.Position<j.Length)
                {
                    N = (Note)r.Deserialize(j);
                    C = (Candidat)r.Deserialize(g);
                    if (N.codee.Equals(C.code))
                    {
                        R = new Resultat(C.cin, C.nom, C.moyenne, N.Ntheo, N.Nprati, Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value), dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[3].Value.ToString());
                        Stream p = File.Open("Resultats.dat", FileMode.Append);
                        r.Serialize(p, R);
                        p.Close();
                    }
                }
        
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView3, ex.Message);
            }
        }

        private void consultationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Resultats.dat", FileMode.Open);
                dataGridView3.Rows.Clear();
                while (g.Position < g.Length)
                {
                    R = (Resultat)v.Deserialize(g);
                    if(R.moyenneG>12)
                    dataGridView3.Rows.Add(R.ciin, R.noom, R.moyenned, R.Ntheoo, R.Npratii, R.moyenneG, R.mentioon);
                }
                MessageBox.Show("data exported");
                g.Close();


            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView3,ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("Candidats.dat", FileMode.Open);
                dataGridView1.Rows.Clear();

                comboBox1.Items.Clear();
                while (g.Position < g.Length)
                {
                    C = (Candidat)v.Deserialize(g);
                    comboBox1.Items.Add(C.code.ToString());

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
                FileStream g = File.Open("Candidats.dat", FileMode.Open);
                dataGridView1.Rows.Clear();


                while (g.Position < g.Length)
                {
                    C = (Candidat)v.Deserialize(g);
                    if (C.code.Equals(comboBox1.Text))
                    {
                        dataGridView1.Rows.Add(C.code, C.cin, C.nom, C.adress, C.diplome, C.moyenne, C.mention);
                    }
                }

                g.Close();

            }
            catch (Exception d)
            {
                errorProvider1.SetError(dataGridView1, d.Message);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            try
            {
                double moy = 0;
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    moy += Convert.ToDouble(dataGridView3.Rows[dataGridView2.CurrentRow.Index].Cells[5].Value);
                }
                textBox2.Text = (moy / dataGridView3.Rows.Count - 1).ToString();
                textBox1.Text = (dataGridView3.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label10,ex.Message);
            }
        }

    
    }
}
