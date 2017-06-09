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
        internal bool IsHit(figura figure)
        {
            foreach (var p in plist)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in plist)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
