using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
         List<Point> pList;
        public VerticalLine (int x, int yHeight, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yHeight; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
           
        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
