using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierAnalysePatient
{
    [Serializable]
    public class Facture
    {
        public string code;
        public double MontantG;
     

        public Facture(string c, double mg)
        {
            code = c;
            MontantG = mg;
          

        }

    }
}
