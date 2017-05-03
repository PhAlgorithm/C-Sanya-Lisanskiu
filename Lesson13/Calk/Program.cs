using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk
{
    class Program
    {
        public delegate int MyDeleg(int x, int y);

        static void Main(string[] args)
        {
            // считываем строку по запросу 1_2_+

            string baseString = Console.ReadLine();
            string[] SplitbaseString = baseString.Split(' ');

            int a = int.Parse(SplitbaseString[0]);
            int b = int.Parse(SplitbaseString[1]);
            MyDeleg myDel = null;
            switch (SplitbaseString[2])
            {
                case "+":
                    myDel = Add;
                     break;

                case "-":
                    myDel = Mult;
                    break;
                     
                case "*":
                    myDel = Supl;
                    break;

                case "/":
                    myDel = Div;
                    break;
            }
            Console.WriteLine(myDel(a,b));
            Console.ReadKey();
         }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Mult(int x, int y)
        {
            return x - y;
        }
        static int Supl(int x, int y)
        {
            return x * y;
        }
        static int Div(int x, int y)
        {
            return x / y;
        }
        
    }
}
