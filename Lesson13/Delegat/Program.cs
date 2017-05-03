using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    class Program
    {
        static void Main(string[] args)
        {
            // считываем строку по запросу 1_2_+
            Func<int, int, int> myDel=null;
            string baseString = Console.ReadLine();
            string[] SplitbaseString = baseString.Split(' ');

            int a = int.Parse(SplitbaseString[0]);
            int b = int.Parse(SplitbaseString[1]);
            
            switch (SplitbaseString[2])
            {
                case "+":
                     myDel = delegate (int x, int y)
                      {
                          return x + y;
                      };
                break;

                case "-":
                    myDel = delegate (int x, int y)
                    {
                        return x - y;
                    };
                break;

                case "*":
                    myDel = (x, y)=> a*b;
                break;

                case "/":
                    myDel = (x, y) => a / b;
                 break;
               
            }
            Console.WriteLine(myDel(a, b));
            Console.ReadKey();
        }
       // static int Add(int x, int y) => x + y;

       // static int Mult(int x, int y) => x - y;

        //static int Supl(int x, int y) => x * y;

       // static int Div(int x, int y) => x / y;
        

    
    }
}
