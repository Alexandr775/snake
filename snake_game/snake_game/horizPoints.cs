using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class horizPoints
    {
        public horizPoints(int xleft, int xright,int y,char sym)
            {
             for (int x=xleft;x<=xright;x++)
             {
                Point p = new Point(x, y, sym);
                p.draw();
             }
            }
    }
}
