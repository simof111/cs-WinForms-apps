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

namespace FichierDataBinaire
{
    public partial class Form1 : Form
    {
        Stagiaire s,s2;
        BinaryFormatter r = new BinaryFormatter();
        BinaryFormatter v = new BinaryFormatter();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("stag.dat", FileMode.Open);
                dataGridView1.Rows.Clear();
                if (g.Length == 0)
                {
                    dataGridView1.Visible = false;
                    label9.ForeColor = Color.Red;
                    label9.Visible = true;

                }
                comboBox1.Items.Clear();
                while (g.Position < g.Length)
                {
                    s = (Stagiaire)v.Deserialize(g);

                    comboBox1.Items.Add(s.matricule);
                }

                g.Close();

            }
            catch (Exception d)
            {
                errorProvider1.SetError(label5, d.Message);
            }

        }



        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
               
                    s = new Stagiaire(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text, comboBox2.Text, textBox3.Text);
                    Stream f = File.Open("stag.dat", FileMode.Append);
                    BinaryFormatter r = new BinaryFormatter();
                    r.Serialize(f, s);
                    f.Close();

                    comboBox1.Text = ""; comboBox2.Text = ""; textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4,ex.Message);
            }

        }



        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("stag.dat", FileMode.Open);
                dataGridView1.Rows.Clear();

                bool trouve = true;
                while (g.Position < g.Length && trouve == true)
                {
                    s = (Stagiaire)v.Deserialize(g);
                    if (s.matricule == int.Parse(comboBox1.Text))
                    {

                        dataGridView1.Rows.Add(s.matricule, s.cin, s.nom, s.prenom, s.section);
                        comboBox2.Text = s.cin.ToString();
                        textBox1.Text = s.nom.ToString();
                        textBox2.Text = s.prenom.ToString();
                        textBox3.Text = s.section.ToString();
                        trouve = false;
                    }

                }

                g.Close();
                if (trouve == true)
                {
                    textBox4.ForeColor = Color.Red;
                    textBox4.Text = " Stagiaire Inexistant";
                }
            }
            catch (Exception d)
            {
                errorProvider1.SetError(label4, d.Message);
            }

        }

        private void label10_Click(object sender, EventArgs e)//methode de suppression
        {
           
           
        }

        private void serializationAjoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool trouve= false;
                for (int i = 0; i < comboBox1.Items.Count;i++ )
                {
                    if (Convert.ToInt32(comboBox1.Text) == Convert.ToInt32(comboBox1.Items[i]))
                        trouve = true;
                }
                if (trouve == true)
                {
                    comboBox1.ForeColor = Color.Red;
                    comboBox1.Text = "deja exist!!";
                    comboBox2.Text = ""; textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; comboBox1.Focus();
                }
                else
                {
                    if (comboBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        s = new Stagiaire(int.Parse(comboBox1.Text), textBox1.Text, textBox2.Text, comboBox2.Text, textBox3.Text);
                        Stream f = File.Open("stag.dat", FileMode.Append);
                        BinaryFormatter r = new BinaryFormatter();
                        r.Serialize(f, s);
                        f.Close();
                        comboBox1.Items.Add(s.matricule);
                        comboBox1.Text = ""; comboBox2.Text = ""; textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; comboBox1.Focus();
                        label6.Visible = false;
                        label12.Visible = false;
                        label11.Visible = false;
                        label10.Visible = false;
                    }
                    else
                    {
                        label6.Visible = true;
                        label12.Visible = true;
                        label11.Visible = true;
                        label10.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4, ex.Message);
            }

        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("stag.dat", FileMode.Open);

                dataGridView1.Rows.Clear();
                if (g.Length == 0)
                {
                    dataGridView1.Visible = false;
                    label9.ForeColor = Color.Red;
                    label9.Visible = true;

                }

                while (g.Position < g.Length)
                {
                    s = (Stagiaire)v.Deserialize(g);
                    dataGridView1.Visible = true;
                    if ( s.cin != "" && s.nom != "" && s.prenom != "" && s.section != "")
                    {
                        dataGridView1.Rows.Add(s.matricule, s.cin, s.nom, s.prenom, s.section);
                    }
                    }
                g.Close();
                textBox5.Text = (dataGridView1.Rows.Count-1).ToString();
                MessageBox.Show("Data Exported");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4, ex.Message);
            }
        }

        private void finToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter v = new BinaryFormatter();
                FileStream g = File.Open("stag.dat", FileMode.Open);

                dataGridView1.Rows.Clear();
                if (g.Length == 0)
                {
                    dataGridView1.Visible = false;
                    label9.ForeColor = Color.Red;
                    label9.Visible = true;

                }
                bool trouve = true;
                while (g.Position < g.Length && trouve == true)
                {

                    s = (Stagiaire)v.Deserialize(g);
                    if (s.matricule == int.Parse(textBox4.Text))
                    {
                        dataGridView1.Rows.Add(s.matricule, s.cin, s.nom, s.prenom, s.section);
                        trouve = false;
                    }
                }
                g.Close();
                if (trouve == true)
                {

                    textBox4.ForeColor = Color.Red;
                    textBox4.Text = " Stagiaire Inexistant";

                }
                else
                    MessageBox.Show("Data Exported");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label4, ex.Message);
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Stream f = File.Open("stag.dat", FileMode.Create);
                dataGridView1.Rows.Clear();

                f.Close();

            }

            catch (Exception g)
            {
                errorProvider1.SetError(label4, g.Message);
            }
        }

    

   

      

     
    }
}
