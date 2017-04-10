using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        struct Sity
        {
            public string Name { get; set; }
            public int Popular { get; set; }

        }

        static void Main(string[] args)
        {
           // Kharkov=1430000,Kiev=2800000,Las Vegas=630000
            string str = @"Kharkov=1430000,Kiev=2800000,LasVegas=630000"; // Console.ReadLine();

            string[] para = str.Split(',');

            Sity[] Gorod = new Sity[para.Length];

            for (int i = 0; i < para.Length; i++)
            {
              //  s = para[i].Split('=');
               
                //   Gorod[i].Name ;
                //Gorod[i].Popular = para[i].Last();

            }
            
        }
    }
}
