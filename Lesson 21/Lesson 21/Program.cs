using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_21
{



    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 51; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.WriteLine(i+j);
                }
            }

            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.Write("I am from Trase");

            Debug.Write("ghgh ggh ");

#if DEBUG
            Console.WriteLine("it is debug");
#endif
        }



    }
}
