using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lesson_26
{
    public class FileWatcher
    {
        private DateTime TimeChek { get; set; }

        private string NameFile { get; set; }

        public FileWatcher(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            TimeChek = File.GetLastWriteTime(path);
            NameFile = path;
        }

        public event ActionCheck ModFile;

        public delegate void ActionCheck();

        public void CheckFile()
        {
            DateTime TimeForCheck = File.GetLastWriteTime(NameFile);

            if (TimeChek != TimeForCheck)
            {
                Console.WriteLine("The file was modified");
            }
        }
    }
}
