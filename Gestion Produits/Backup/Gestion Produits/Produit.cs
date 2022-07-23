using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Produits
{
[Serializable]
    public class Produit
    {
    public string Reference;
    public string Designation;
    public int Stock;
    public int Prix;
    public string CFournisseur;


    public Produit(string r, string d, int s, int p, string c)
    {
        Reference = r;
        Designation = d;
        Stock = s;
        Prix = p;
        CFournisseur = c;
    }

    }
}
