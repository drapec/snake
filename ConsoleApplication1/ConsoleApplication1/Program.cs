using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            HorisontLine upLine = new HorisontLine(0,78,0,'+');
            HorisontLine downLine = new HorisontLine(0, 78, 24, '+');
            VerticalLine lLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            lLine.Drow();
            rLine.Drow();
            

            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move(); 
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


            Console.Read();
        
        }
    }
}
        
    

