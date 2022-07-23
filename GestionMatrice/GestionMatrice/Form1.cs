using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionMatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void label2_Click_1(object sender, EventArgs e)
        {
            try
            {
                String[,] IS = new String[4, 3];
                Double[,] IN = new Double[4, 4];

                IS[0, 0] = "A1";
                IS[0, 1] = "el hattabi";
                IS[0, 2] = "Hamza";
                IS[1, 0] = "A2";
                IS[1, 1] = "fikry";
                IS[1, 2] = "mustapha";
                IS[2, 0] = "A3";
                IS[2, 1] = "ridhi";
                IS[2, 2] = "youness";
                IS[3, 0] = "A4";
                IS[3, 1] = "rifi";
                IS[3, 2] = "farid";

           
                IN[0, 0] = 17;
                IN[0, 1] = 16;
                IN[0, 2] = 39;
                IN[0, 3] = (IN[0,0]+IN[0,1]+IN[0,2])/4;
                IN[1, 0] = 12;
                IN[1, 1] = 17;
                IN[1, 2] = 33;
                IN[1, 3] = (IN[1, 0] + IN[1, 1] + IN[1, 2]) / 4;
                IN[2, 0] = 9;
                IN[2, 1] = 20;
                IN[2, 2] = 38;
                IN[2, 3] = (IN[2, 0] + IN[2, 1] + IN[2, 2]) / 4;
                IN[3, 0] = 18;
                IN[3, 1] = 7;
                IN[3, 2] = 29;
                IN[3, 3] = (IN[3, 0] + IN[3, 1] + IN[3, 2]) / 4;


                for (int i = 0; i < IS.Length / 3; i++)
                {
                    dataGridView1.Rows.Add(IS[i, 0], IS[i, 1], IS[i, 2]);
                }

                for (int i = 0; i < IN.Length / 4; i++)
                {
                    dataGridView2.Rows.Add(IN[i, 0], IN[i, 1], IN[i, 2],IN[i,3]);
                }



            }
            catch (Exception ex)
            {
                errorProvider1.SetError(label2, ex.Message);
            }
        }

       
    }
}
