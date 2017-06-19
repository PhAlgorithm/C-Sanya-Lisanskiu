using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Program
    {
        static void Main(string[] args)
        {
            HoispitalRepository repo = new HoispitalRepository();

            var doctors = repo.GetDoctor();
        }
    }
}
