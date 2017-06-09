using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(2,5,'*');
            snake Snake = new snake(p, 4, direction.RIGHT);
            Snake.draw();

            Foodcreator foodcreator = new Foodcreator(80, 25, '$');
            Point food = foodcreator.Createfood();
            food.draw();

            while (true)
            {
                if (walls.IsHit(Snake) || Snake.IsHitTail())
                {
                    break;
                }
                if (Snake.Eat(food))
                {
                    food = foodcreator.Createfood();
                    food.draw();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Snake.handlekey(key.Key);
                }
                Thread.Sleep(100);
                Snake.Move();
            }

        }

    }
}
