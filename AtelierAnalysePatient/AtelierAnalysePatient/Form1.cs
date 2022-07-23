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

namespace AtelierAnalysePatient
{
    public partial class Form1 : Form
    {
        Patient P;
        Analyse A;
        Facture F;
        BinaryFormatter r = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                P= new Patient(comboBox1.Text,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text);
                Stream p = File.Open("Patients.dat", FileMode.Append);
                r.Serialize(p, P);
                p.Close();
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = "";
                MessageBox.Show("Complet!");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(groupBox1, ex.Message);
            }
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Patients.dat", FileMode.Open);
                dataGridView1.Rows.Clear();
                while (g.Position < g.Length)
                {

                    P = (Patient)v.Deserialize(g);
                    dataGridView1.Rows.Add(P.Nom,P.cin,P.adress,P.datenaissance,P.patologie);

                }
                MessageBox.Show("data exported");
                g.Close();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView1, ex.Message);
            }
        }

        private void serializationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {

                A = new Analyse(comboBox1.Text, Convert.ToDouble(textBox10.Text), Convert.ToDouble(textBox9.Text));
                Stream p = File.Open("Analyses.dat", FileMode.Append);
                r.Serialize(p, A);
                p.Close();

                textBox9.Text = ""; textBox10.Text = "" ; comboBox1.Text = "";
                MessageBox.Show("Complet!");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(groupBox2, ex.Message);
            }
        }

        private void consultationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Analyses.dat", FileMode.Open);
                dataGridView2.Rows.Clear();
                while (g.Position < g.Length)
                {
                    A = (Analyse)v.Deserialize(g);
                    dataGridView2.Rows.Add(A.analyse1,A.analyse2);
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
            try
            {
                dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value = (Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value) + Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[1].Value)).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView2,ex.Message);
            }
        }

        private void serializationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Stream g = File.Open("Patients.dat", FileMode.Open);
                Stream j = File.Open("Analyses.dat", FileMode.Open);

                while (g.Position < g.Length && j.Position < j.Length)
                {
                    A = (Analyse)r.Deserialize(j);
                    P = (Patient)r.Deserialize(g);
                    if (A.Codee.Equals(P.code))
                    {
                        F = new Facture(P.code, Convert.ToDouble(dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[2].Value));
                        Stream p = File.Open("Factures.dat", FileMode.Append);
                        r.Serialize(p, F);
                        p.Close();
                        MessageBox.Show("Done");

                    }
                }
                g.Close();
                j.Close();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView3, ex.Message);
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[2].Value = (Convert.ToDouble(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[1].Value) * 1.2).ToString();
                dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[3].Value =(Convert.ToDouble(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[2].Value )+Convert.ToDouble(dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[1].Value)).ToString();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dataGridView3, ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("Patients.dat", FileMode.Open);
                dataGridView1.Rows.Clear();

                comboBox1.Items.Clear();
                while (g.Position < g.Length)
                {
                    P = (Patient)v.Deserialize(g);
                    comboBox1.Items.Add(P.code.ToString());

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
                FileStream g = File.Open("Patients.dat", FileMode.Open);
                dataGridView1.Rows.Clear();


                while (g.Position < g.Length)
                {
                    P = (Patient)v.Deserialize(g);
                    if (P.code.Equals(comboBox1.Text))
                    {
                        dataGridView1.Rows.Add(P.Nom, P.cin, P.adress, P.datenaissance, P.patologie);
                    }
                }

                g.Close();

            }
            catch (Exception d)
            {
                errorProvider1.SetError(dataGridView1, d.Message);
            }
        }

        private void consultationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                Stream g = File.Open("Factures.dat", FileMode.Open);
                dataGridView3.Rows.Clear();
                while (g.Position < g.Length)
                {
                    F = (Facture)v.Deserialize(g);
             
                        dataGridView3.Rows.Add(F.code,F.MontantG);
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
