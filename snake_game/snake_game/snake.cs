using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game 
{
    class snake : figura
    {
        direction Direction;
        public snake(Point tail, int width, direction _direction)
            {
            Direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < width; i++)
            {
                Point p = new Point(tail);
                p.move(i, Direction);
                plist.Add(p);
            }
            }

        internal void Move()
        {
            Point tail = plist.First(); //
            plist.Remove(tail); //
            Point head = GNP(); //
                plist.Add(head); //

            tail.Clear(); //
            head.draw(); //
        }

        public Point GNP()
        {
            Point head = plist.Last(); //присваивает этой точке значение последней точки 
            Point nextPoint = new Point(head); //
            nextPoint.move(1, Direction); //
            return nextPoint; //
        }
        public void handlekey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                Direction = direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                Direction = direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                Direction = direction.UP;
            else if (key == ConsoleKey.DownArrow)
                Direction = direction.DOWN;
        }


    }
}
