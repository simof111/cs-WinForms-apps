using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Concour
{
    [Serializable]
    public class Resultat
    {

        public string ciin;
        public string noom;
        public double moyenned;
        public double Ntheoo;
        public double Npratii;
        public double moyenneG;
        public string mentioon;

        public Resultat(string cii, string noo, double moy, double nth, double ntp, double moyG, string ment)
        {
            ciin = cii;
            noom = noo;
            moyenned = moy;
            Ntheoo = nth;
            Npratii = ntp;
            moyenneG = moyG;
            mentioon = ment;
        }
    
    
    }
}
