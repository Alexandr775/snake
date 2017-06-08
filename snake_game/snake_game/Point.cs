﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point(int _x,int _y,char _sym)
            {
            x=_x;
            y =_y;
            sym =_sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void move (int offset, direction Direction)
            {
            if (Direction == direction.RIGHT)
            {
                x = x + offset;
            }
            else if (Direction == direction.LEFT)
            {
                x = x - offset;
            }
            else if (Direction == direction.UP)
            {
                y = y + offset;
            }
            else if (Direction == direction.DOWN)
            {
                y = y - offset;
            }
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }

}
