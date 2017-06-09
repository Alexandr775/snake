using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Walls
    {
        List<figura> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<figura>();

            // Отрисовка рамочки
            horizPoints upLine = new horizPoints(0, mapWidth - 2, 0, '+');
            horizPoints downLine = new horizPoints(0, mapWidth - 2, mapHeight - 1, '+');
            VertPoints leftLine = new VertPoints(0, mapHeight - 1, 0, '+');
            VertPoints rightLine = new VertPoints(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(figura figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.draw();
            }
        }
    }
}
