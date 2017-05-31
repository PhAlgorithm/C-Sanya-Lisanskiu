using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_26
{
    class Program
    {
        static void Main(string[] args)
        {

            FileWatcher fw = new FileWatcher("test.txt");

            fw.CheckFile();

            fw.ModFile += fw.CheckFile;

            Console.ReadKey();
        }
    }
}
