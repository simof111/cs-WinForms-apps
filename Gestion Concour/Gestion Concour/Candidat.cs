using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Concour
{
   [Serializable]
    public class Candidat
    {

       public string code;
       public string cin;
       public string nom;
       public string adress;
       public string diplome;
       public double moyenne;
       public string mention;

       public Candidat(string c, string ci, string n, string ad, string dip, double moy, string men)
       {
           code = c;
           cin = ci;
           nom = n;
           adress = ad;
           diplome = dip;
           moyenne = moy;
           mention = men;
       }
    }
}
