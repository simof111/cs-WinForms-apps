using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtelierAnalysePatient
{
    [Serializable]
    public class Patient
    {
        public string code;
        public string Nom;
        public string cin;
        public string adress;
        public string datenaissance;
        public string patologie;

        public Patient(string c, string n, string ci, string ad, string dat, string pat)
        {
            code = c;
            Nom = n;
            cin = ci;
            adress = ad;
            datenaissance = dat;
            patologie = pat;
        }
    }
}
