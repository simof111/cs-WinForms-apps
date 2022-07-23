using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Test
{
  

    class Program
    {
        

        static void Main(string[] args)
        {

            //Random randomGenerator = new Random();
            //int randomnumber = randomGenerator.Next(1,10);
            // do{
            //Console.WriteLine("Please Guess the number: ");
            //int a = int.Parse(Console.ReadLine());

           

            //if(randomnumber==a)
            //{
            //    Console.WriteLine("the number is correct!");
            //}
            //else if(randomnumber<a)
            //{
            //    Console.WriteLine("the number is high");
            //}
            //else if (randomnumber > a)
            //{
            //    Console.WriteLine("the number is low");
            //}
            //}while(randomnumber!=12);
            //int[] numstd ={ 1,2,3};
            //string[] namstd = new string[3];
            //int[] averstd = new int[3];
            //int score=0;
            //for (int i = 0; i < numstd.Length;i++ )
            //{
            //    Console.WriteLine("enter the name of the student number {0}",numstd[i]);
            //    namstd[i] = Console.ReadLine();

            //    Console.WriteLine("enter the score of the student number {0}", numstd[i]);
            //    averstd[i] = int.Parse(Console.ReadLine());
            //    score += averstd[i];


            //}
            //int max = averstd.Max();
            //int min = averstd.Min();

            //for (int i = 0; i < numstd.Length; i++)
            //{
            //    Console.WriteLine(" {0} N:{1} Score:{2} max:{3} min:{4} average:{5}",namstd[i],numstd[i],averstd[i],max,min,score/3 );
       

            //}
            //ArrayList x = new ArrayList();
            //x.Add(122);
            //x.Add(454);
            //x.Add(5467);
            //x.Add(322);

            //x.Insert(2,777);
            //x.RemoveAt(1);

            //foreach(var b in x)
            //{
            //Console.WriteLine(b);
            //}

            //Hashtable v = new Hashtable();

            //v.Add("Name","Hamza el hattabi");
            //v.Add("Phone",5464567);

           
            //foreach(object key in v.Keys)
            //    Console.WriteLine(key+": "+v[key]);


            //List<int> xx = new List<int>();

            //xx.Add(4);
            //xx.Add(45);
            //xx.Add(32);

            //for (int i = 0; i < xx.Count;i++ )
            //{
            //    Console.WriteLine(xx[i]);
            //}


            //Dictionary<int, string> dictio = new Dictionary<int, string>()
            //                    {
            //                        {1,"One"},
            //                        {2, "Two"},
            //                        {3,"Three"}
            //                    };


            //personne p1 = new personne("youssef", 20, "developer");
            //p1.sauveg();
            //personne pe = personne.reset();
            //Console.WriteLine("la personne rest: " + pe);
            //personne p2 = new personne("hamza", 30, "seller");
            //personne p3 = new personne("fati", 13, "student");
            //personne.sauvglistpers();

            personne.restListPers();
            personne.lister();

            Console.ReadKey();


        }
    }
}
