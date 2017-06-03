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
            Point p1=new Point(1,3,'*');
             p1.draw();

            Point p2 = new Point(2,4,'#');
            p2.draw();

            VertPoints Vertpointss = new VertPoints(1, 18, 1, '+');
            VertPoints Vertpoints = new VertPoints(1, 18, 48, '+');
            horizPoints horizpointss = new horizPoints(2, 47, 1, '+');
            horizPoints horizpoints = new horizPoints(2, 47, 18, '+');

            Console.ReadLine();
        }

    }
}
