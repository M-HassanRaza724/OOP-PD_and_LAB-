using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.BL
{
    internal class Pacman
    {
        int X;
        int Y;
        int Score;


        public Pacman(int x, int y)
        {
            X = x;
            Y = y;
            Score = 0;
        }
        public Pacman() 
        {
            X = 9;
            Y = 31;
        }

        public (int x,int y) GetCoordinates()
        {
            return (X, Y);
        }
        public bool SetCoordinates(int x,int y)
        {
            X = x;
            Y = y;
            return true;
        }
        public int GetScore()
        {
            return Score;
        }
        public void movePacManUp()
        {
            char[,] maze = Maze.GetMaze();
            if (maze[X - 1, Y] == ' ' || maze[X - 1, Y] == '.')
            {
                Maze.SetMaze(X, Y, ' ');
                X = X - 1;
                if (maze[X, Y] == '.')
                {
                    CalculateScore();
                }
                Maze.SetMaze(X, Y, 'P');

            }
        }
        public void movePacManDown( )
        {
            char[,] maze = Maze.GetMaze();
            if (maze[X + 1, Y] == ' ' || maze[X + 1, Y] == '.')
            {
                Maze.SetMaze(X, Y, ' ');
                X = X + 1;
                if (maze[X, Y] == '.')
                {
                    CalculateScore();
                }
                Maze.SetMaze(X, Y, 'P');

            }
        }

        public void movePacManLeft( )
        {
            char[,] maze = Maze.GetMaze();
            if (maze[X, Y - 1] == ' ' || maze[X, Y - 1] == '.')
            {
                Maze.SetMaze(X, Y, ' ');
                Y = Y - 1;
                if (maze[X, Y] == '.')
                {
                    CalculateScore();
                }
                Maze.SetMaze(X, Y, 'P');

            }
        }

        public void movePacManRight(  )
        {
            char[,] maze = Maze.GetMaze();
            if (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.')
            {
                Maze.SetMaze(X, Y, ' ');
                Y = Y + 1;
                if (maze[X, Y] == '.')
                {
                    CalculateScore();
                }
                Maze.SetMaze(X, Y, 'P');

            }
        }

        public void CalculateScore()
        {
            Score = Score + 1;
        }
    }
}
