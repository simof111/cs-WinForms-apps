using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FichierDataBinaire
{

    [Serializable]
    public class Stagiaire
    {
        
   
        public int matricule;
        public string cin;
        public string nom;
        public string prenom;
        public string section;


        public Stagiaire(int m,string n,string p,string c,string s)
        {
            matricule = m;
            nom = n;
            prenom = p;
            cin = c;
            section = s;
        }
        



    }
}
