using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Test
{
    [Serializable]
    class personne
    {

        public string nom;
       [NonSerialized] public int age;
        public string info;
        public static List<personne> listpers = new List<personne>();


        public personne(string n,int a,string i)
        {
            nom = n;
            age = a;
            info = i;
            listpers.Add(this);
        }

        public override string ToString()
        {
            if (age != 0)
                return "Age: " + age + " et Nom: " + nom + " et Info:" + info;
            else
                return "Age non defini et Nom: " + nom + " et Info:" + info;
        }

        public void sauveg()
        {
            Stream flux = File.Open("Personnes.txt",FileMode.Append);
            BinaryFormatter r = new BinaryFormatter();
            r.Serialize(flux,this);
            flux.Close();
           
        }

        public static personne reset()
        {
            FileStream flux = File.Open("Personnes.txt",FileMode.Open);
            BinaryFormatter r = new BinaryFormatter();
            personne p = (personne)r.Deserialize(flux);
            flux.Close();
            return p;
        }


        public static void sauvglistpers()
        {
            Stream flux = File.Open("Personnes.txt", FileMode.OpenOrCreate);
            BinaryFormatter r = new BinaryFormatter();
            r.Serialize(flux, listpers);
            flux.Close();
        }

        public static void restListPers()
        {
            FileStream flux = File.Open("Personnes.txt",FileMode.Open);
            BinaryFormatter r = new BinaryFormatter();
            listpers = (List<personne>)r.Deserialize(flux);
            flux.Close();
        }

        public static void lister()
        {
            IEnumerator<personne> IE = listpers.GetEnumerator();
            while (IE.MoveNext())
                Console.WriteLine(IE.Current);
           
        }



    }
}
