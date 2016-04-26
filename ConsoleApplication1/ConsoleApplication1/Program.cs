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
            upLine.Draw();
            downLine.Draw();
            lLine.Draw();
            rLine.Draw();
            

            // отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80,25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
 
            if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }                
                Thread.Sleep(100);
                snake.Move();
            }

        }
    }
}
        
    

