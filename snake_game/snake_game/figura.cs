using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class figura
    {
        protected List<Point> plist;
        public void draw()
        {
            foreach (Point p in plist)
            {
                p.draw();
            }
        }
    }
}
