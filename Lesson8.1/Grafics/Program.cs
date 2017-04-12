using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;
using System.Threading;

namespace Grafics
{
    public class Rentang
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public Keys KeyUp;
        public Keys KeyDounw;
        public Keys KeyLeft;
        public Keys KeyRight;

        public bool Color;


        public Rentang(int x, int y, int w, int h, Keys keyUp, Keys keyDounw, Keys keyLeft, Keys keyRight, bool color)
        {
            X = x;
            Y = y;
            W = w;
            H = h;

            KeyUp = keyUp;
            KeyDounw = keyDounw;
            KeyLeft = keyLeft;
            KeyRight = keyRight;
            Color = color;
        }

        static void Drow(int x, int y, int w, int h, Keys keyUp, Keys keyDounw, Keys keyLeft, Keys keyRight, bool color)
        {
            while (true)
            {
                if (Input.IsKeyDown(Keys.LEFT))
                     x  -= 10;
                else if (Input.IsKeyDown(Keys.RIGHT))
                    x += 10;
                else if (Input.IsKeyDown(Keys.DOWN))
                    y += 10;
                else if (Input.IsKeyDown(Keys.UP))
                    y -= 10;
                //////////////////////////////////////////////////////////////
                if (x == grapfic.ClientWidth - 100)
                    x -= 10;
                else if (x == 0)
                    x += 10;
                else if (y == grapfic.ClientHeight - 100)
                    y -= 10;
                else if (y == 0)
                    y += 10;

                ///////////////////////////////////////////////////////////////
                if (((Input.MouseX - x) <= w) && ((Input.MouseY - y) <= h))
                {
                    grapfic.FillRectangle(0xFF00FF00, x, y, w, h);

                } else
                {
                    grapfic.FillRectangle(0xFF000000, 0, 0, grapfic.ClientWidth, grapfic.ClientHeight);
                    grapfic.FillRectangle(0xFFFF0000, x, y, w, h);

                }
                Thread.Sleep(10);
            }

        }

    }

    class Program
    {        

        static void Main(string[] args)
        {
            Rentang ren = new Rentang();
           

            ConsoleGraphics grapfic = new ConsoleGraphics();
            ConsoleGraphics grapfic2 = new ConsoleGraphics();

            int x = 100, y = 100, w = 100, h = 100;

            while(true)
            {
                if (Input.IsKeyDown(Keys.LEFT))
                     -= 10;
                else if (Input.IsKeyDown(Keys.RIGHT))
                    x += 10;
                else if (Input.IsKeyDown(Keys.DOWN))
                    y += 10;
                else if (Input.IsKeyDown(Keys.UP))
                    y -= 10;
                //////////////////////////////////////////////////////////////
                if (x == grapfic.ClientWidth-100)
                    x -= 10;
                else if (x == 0)
                    x += 10;
                else if (y == grapfic.ClientHeight-100)
                    y -= 10;
                else if (y == 0)
                    y += 10;

                ///////////////////////////////////////////////////////////////
                if (((Input.MouseX -x )<= w) && ((Input.MouseY -y )<=h))
                {
                    grapfic.FillRectangle(0xFF00FF00, x, y, w, h);

                } 
                else
                {
                    grapfic.FillRectangle(0xFF000000, 0, 0, grapfic.ClientWidth, grapfic.ClientHeight);
                    grapfic.FillRectangle(0xFFFF0000, x, y, w, h);
                                       
                }
                Thread.Sleep(10);
            }

           


        }
    }
}
