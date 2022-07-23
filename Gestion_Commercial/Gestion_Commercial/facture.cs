using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Commercial
{
    [Serializable]
    public class facture
    {
        public int Num_facture=252351;
        public int CodeClient=0;
        public double MontGlobal;
        public double TVA;
        public double MTTC;
        public static int contfac = 252351;
        public static int contclie = 0;


        public facture(double mg,double tv,double mt)
        {
            contfac++;
            Num_facture=contfac;     
            contclie++;
            CodeClient=contclie;
            MontGlobal = mg;
            TVA = tv;
            MTTC = mt;
        }


    }
}
