using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            User Iam = new User();
            Iam.AddBook("Bond", "007");

            Console.ReadKey();
        }
    }
}
