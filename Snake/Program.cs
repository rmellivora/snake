using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        { 
            Point p1 = new Point(1, 2, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorisontalLine line = new HorisontalLine(5, 10, 8,'+');
            line.Drow();

            VerticalLine vLine = new VerticalLine(15, 9, 20, '+');
            vLine.DrowVLine();


            Console.ReadLine();
        }
    }
}
