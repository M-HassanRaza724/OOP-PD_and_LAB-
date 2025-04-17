using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.DL;

namespace PacMan.BL
{
    class SmartGhost : Ghost
    {
        public SmartGhost(int x, int y) : base(x, y) { }

        public bool MoveGhostSmart()
        {
            char[,] maze = Maze.GetMaze();
            double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
            if (maze[X, Y - 1] != '|' && maze[X, Y - 1] != '%')
            {
                distance[0] = (CalculateDistance(X, Y - 1,PacmanCRUD.pacmans[0].GetCoordinates()));
            }
            if (maze[X, Y + 1] != '|' && maze[X, Y + 1] != '%')
            {
                distance[1] = (CalculateDistance(X, Y + 1,PacmanCRUD.pacmans[0].GetCoordinates()));
            }
            if (maze[X + 1, Y] != '|' && maze[X + 1, Y] != '%' && maze[X + 1, Y] != '#')
            {
                distance[2] = (CalculateDistance(X + 1, Y,PacmanCRUD.pacmans[0].GetCoordinates()));
            }
            if (maze[X - 1, Y] != '|' && maze[X - 1, Y] != '%' && maze[X - 1, Y] != '#')
            {
                distance[3] = (CalculateDistance(X - 1, Y,PacmanCRUD.pacmans[0].GetCoordinates()));
            }
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                Direction = "left";
                return MoveGhostInLine();
            }
            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                Direction = "right";
                return MoveGhostInLine();
            }
            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                Direction = "down";
                return MoveGhostInLine();
            }
            else
            {
                Direction = "up";
                return MoveGhostInLine();
            }
        }

        public static double CalculateDistance (int x,int y,(int pX, int pY) Position)
        {
            return Math.Sqrt(Math.Pow((Position.pX - x), 2) + Math.Pow((Position.pY - y), 2));
        }
    }
}
