using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            draw(1,3,'*');
            draw(1, 4, 's');
            draw(2, 3, '#');
            draw(2, 5, '@');
            draw(3, 4, '&');
            Console.ReadLine();
        }
        static void draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
