using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierAnalysePatient
{
    [Serializable]
    public class Analyse
    {
        public string Codee;
        public double analyse1;
        public double analyse2;

        public Analyse(string cc, double a1, double a2)
        {
            Codee = cc;
            analyse1 = a1;
            analyse2 = a2;
        }

    }
}
