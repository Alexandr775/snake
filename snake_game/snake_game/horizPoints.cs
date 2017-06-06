using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class horizPoints
    {
        List<Point> plist;
        public horizPoints(int xleft, int xright,int y,char sym)
            {
            plist = new List<Point>();
            for (int x=xleft;x<=xright;x++)
             {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
            }
        public void draw()
        {
            foreach (Point p in plist)
            {
                p.draw();
            }
        }

    }
}
