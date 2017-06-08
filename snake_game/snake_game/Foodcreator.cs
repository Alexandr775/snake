using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Foodcreator
    {
        int mapwidht;
        int mapheight;
        char sym;

        Random random = new Random();
        public Foodcreator(int mapwidht, int mapheight, char sym)
        {
            this.mapwidht = mapwidht;
            this.mapheight = mapheight;
            this.sym = sym;
        }

        public Point Createfood()
        {
            int x = random.Next(2, mapwidht - 2);
            int y = random.Next(2, mapheight - 2);
            return new Point(x, y, sym);
        }


    }
}
