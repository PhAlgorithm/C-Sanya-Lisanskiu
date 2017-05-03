using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new[]
            {

                new Pen { Color = Color.Blue, Brand = "Brain Academy"},
                new Pen {  Color =Color.Red, Brand = "ICDS"},
                 new Pen { Color = Color.Red, Brand = "Big"},
                new Pen {  Color =Color.Wihte, Brand = "Big"},
                 new Pen { Color = Color.Blue, Brand = "Brain Academy"},
                new Pen {  Color =Color.Blue, Brand = "ICDS"},
            };
            var pen = array.Where(x => x.Brand == "Big").ToList();
          //  var pen = array.Count(x => x.Color == Color.Red&&x.Brand=="Big");
          var pens = array.FirstOrDefault()
            Console.WriteLine(pen);
        }
    }
}
