using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    class RandomGhost : Ghost
    {
        public RandomGhost(int x, int y) : base(x, y) { }
        static int GhostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
        public int MoveGhostRandom()
        {
            char[,] maze = Maze.GetMaze();
            if (maze[X, Y - 1] == 'P' || maze[X, Y + 1] == 'P' || maze[X + 1, Y] == 'P' || maze[X - 1, Y] == 'P')
            {
                return -1;
            }
            int value = GhostDirection();
            if (value == 0)
            {
                if (maze[X, Y - 1] == ' ' || maze[X, Y - 1] == '.' || maze[X, Y - 1] == 'P')
                {
                    Maze.SetMaze(X,Y,Previous);
                    Y = Y - 1;
                    Previous = Maze.GetMaze()[X, Y];
                }
            }
            else if (value == 1)
            {
                if (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.' || maze[X, Y + 1] == 'P')
                {
                    Maze.SetMaze(X,Y,Previous);
                    Y = Y + 1;
                    Previous = Maze.GetMaze()[X, Y];
   
                }
            }
            else if (value == 2)
            {
                if (maze[X - 1, Y] == ' ' || maze[X - 1, Y] == '.' || maze[X - 1, Y] == 'P')
                {
                    Maze.SetMaze(X,Y,Previous);
                    X = X - 1;
                    Previous = Maze.GetMaze()[X, Y];
                
                }
            }
            else if (value == 3)
            {
                if (maze[X + 1, Y] == ' ' || maze[X + 1, Y] == '.' || maze[X + 1, Y] == '.')
                {
                    Maze.SetMaze(X,Y,Previous);
                   
                    X = X + 1;
                    Previous = Maze.GetMaze()[X, Y];
                   
                }
            }
            return value;
        }

    }
}
