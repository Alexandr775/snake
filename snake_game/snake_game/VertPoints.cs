using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class VertPoints
    {
        public VertPoints(int yback, int ytop, int x, char sym)
        {
            for (int y=yback; y <= ytop; y++)
            {
                Point p = new Point(x, y, sym);
                p.draw();
            }
        }

    }
}
