﻿using System;
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

            Point p3 = new Point(7, 8, '$');
            p3.Draw();

            Point p4 = new Point(10, 7, '@');
            p4.Draw();

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
                {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            List<char> charList = new List<char>();

            charList.Add('*');
            charList.Add('#');
            charList.Add('@');
            charList.Add('&');
            charList.Add('$');
            charList.Add('%');

            List<Point> mypList = new List<Point>();
            mypList.Add(p1);
            mypList.Add(p2);
            mypList.Add(p3);
            mypList.Add(p4);


            Console.ReadLine();
        }
    }
}
