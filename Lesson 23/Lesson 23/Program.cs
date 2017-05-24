using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_23
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader ReadFile = File.OpenText(@"text.txt");

            string Input = null;
                       
            while ((Input = ReadFile.ReadLine()) != null)
            {
                var dic = Input.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
                Console.Write(String.Join(" ", dic));
            }
            Console.ReadKey();
        
        }
    }
}
