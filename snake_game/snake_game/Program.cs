using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Point p = new Point(2,5,'*');
            snake Snake = new snake(p, 5, direction.RIGHT);
            Snake.draw();

            VertPoints Vertpointss = new VertPoints(0, 24, 0, '#');
            VertPoints Vertpoints = new VertPoints(0, 24, 78, '#');
            horizPoints horizpointss = new horizPoints(0, 78, 0, '#');
            horizPoints horizpoints = new horizPoints(0, 78, 24, '#');
            Vertpointss.draw();
            Vertpoints.draw();
            horizpointss.draw();
            horizpoints.draw();
            Console.ReadLine();
        }

    }
}
