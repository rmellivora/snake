using System;
using System.Collections.Generic;

namespace Snake
{
    public class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yHigh, int yLow, char sym)
        {
            pList = new List<Point>();
            for (int y = yHigh; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void DrowVLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }
    }
}
