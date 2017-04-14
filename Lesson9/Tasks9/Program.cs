using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks9
{
    

    class Program
    {
        static void Main(string[] args)
       {
            //            Text: file.txt(6B); Some string content
            //            Image: img.bmp(19MB); 1920х1080
            //            Text:data.txt(12B); Another string
            //            Text:data1.txt(7B); Yet another string
            //            Movie:logan.2017.mkv(19GB); 1920х1080; 2h12m
            List<Text> TextForConsole = new List<Text>();

            string stroka = @"Text:file.txt(6B);Some string content
                            Image:img.bmp(19MB);1920х1080
                            Text:data.txt(12B);Another string
                            Text:data1.txt(7B);Yet another string
                            Movie:logan.2017.mkv(19GB);1920х1080;2h12m";

           

            if (stroka.StartsWith("Text") == true)
            {

                TextForConsole.Add(new Text() { Name = "pars", Extension = "gf", Size = "dgdg", Content = "sfsf" });

            }
            
        }
    }
}
