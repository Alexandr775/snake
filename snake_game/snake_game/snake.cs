using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game 
{
    class snake : figura
    {
        public snake(Point tail, int width, direction direction)
            {
            plist = new List<Point>();
            for (int i = 0; i < width; i++)
            {
                Point p = new Point(tail);
                p.move(i, direction);
                plist.Add(p);
            }
            }
    }
}
