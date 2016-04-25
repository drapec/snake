using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'#');
            p1.Draw();
            
            Point p2 = new Point(4,5,'*');
            p2.Draw();

            HorisontLine line = new HorisontLine(5,10,8,'-');
            line.Drow();

            VerticalLine vLine = new VerticalLine(4, 8, 15, '|');
            vLine.Drow();


                                    
            Console.ReadLine();
        }
    }
}
        
    

