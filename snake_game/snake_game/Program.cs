﻿using System;
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
            VertPoints Vertpointss = new VertPoints(0, 24, 0, '#');
            VertPoints Vertpoints = new VertPoints(0, 24, 78, '#');
            horizPoints horizpointss = new horizPoints(0, 78, 0, '#');
            horizPoints horizpoints = new horizPoints(0, 78, 24, '#');
            Vertpointss.draw();
            Vertpoints.draw();
            horizpointss.draw();
            horizpoints.draw();

            Console.SetBufferSize(80, 25);
            Point p = new Point(2,5,'*');
            snake Snake = new snake(p, 4, direction.RIGHT);
            Snake.draw();

            Foodcreator foodcreator = new Foodcreator(80, 25, '$');
            Point food = foodcreator.Createfood();
            food.draw();

            while (true)
            {
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
