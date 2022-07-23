using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Concour
{
    [Serializable]
    public class Note
    {
        public string codee;
        public double Ntheo;
        public double Nprati;

        public Note(string co, double nt, double np)
        {
            codee = co;
            Ntheo = nt;
            Nprati = np;
        }

    }
}
