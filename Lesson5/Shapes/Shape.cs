using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        private int _a;
        protected int _b;
        private Color _color;


        public int A       // обычные свойства
        {
            get { return _a; }
            set { _a = value; }
        }

        public int B { get; set; }   //автосвойста









        public Shape() : this(4,4)
        {
            Console.WriteLine(nameof(Shape));
        }

        public Shape(int a, int b)
        {
             _a=a;
             _b=b;
           
        }
        public Shape(int a, int b, Color color)
        {
          _a=a;
          _b=b;
           _color=color;
        }

        public void Drow()
        {
            Console.WriteLine($"A: {_a}, B: {_b}");
        }

        public static void PrintPerfect()
        {
            Console.WriteLine("123");
        }
        protected virtual void DrowA()
        {
        Console.WriteLine($"A: {_a}, B: {_b}");
        }
        private void DrowB()
        {
            Console.WriteLine($"A: {_a}, B: {_b}");
        }


    }
}
