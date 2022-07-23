using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Commercial
{
    [Serializable]
    public class produit
    {
        public int fr;
        public string reference;
        public string designation;
        public double prix;
        public int stock;
       

        public produit(int frr, string re, string de, double pr, int st)
        {
            fr = frr;
            reference = re;
            designation = de;
            prix = pr;
            stock = st;
           
        }



    }
}
