using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Directdraw
{
    class Program
    {
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        static void draw(Rectangle r , Brush b,IntPtr hwnd)
        {
            using(Graphics g = Graphics.FromHdc(hwnd))
            {
                g.FillRectangle(b, r);
            }
        }
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

                Console.Write("Command: ");
            string cmd = Console.ReadLine();

            if (cmd.ToLower().Substring(0, 4) == "draw")
            {
                    string[] rec = cmd.Substring(5).Split(':');

                    int x = Convert.ToInt32(rec[0]);
                    int y = Convert.ToInt32(rec[1]);
                    int width = Convert.ToInt32(rec[2]);
                    int height = Convert.ToInt32(rec[3]);
                while (true)
                {
                    //the draw method we use for later 
                    draw(new Rectangle(x, y, width, height), Brushes.PaleGoldenrod, GetDC(IntPtr.Zero));
                }
            }
            if(cmd.ToLower().Substring(0,5) == "crossline")
            {   
                
            }




        }
    }
}
