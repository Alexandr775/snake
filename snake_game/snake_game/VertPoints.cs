using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class VertPoints:figura 
    {
        public VertPoints(int yback, int ytop, int x, char sym)
        {
            plist = new List<Point>();
            for (int y=yback; y <= ytop; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }


    }
}
