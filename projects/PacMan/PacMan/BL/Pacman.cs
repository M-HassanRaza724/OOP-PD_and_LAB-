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


        public Pacman(int x, int y)
        {
            X = x;
            Y = y;
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
        public void movePacManUp(char[,] maze)
        {
            if (maze[X - 1, Y] == ' ' || maze[X - 1, Y] == '.')
            {
                maze[X, Y] = ' ';
                Console.SetCursorPosition(Y, X);
                Console.Write(" ");
                X = X - 1;
                if (maze[X, Y] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(Y, X);
                maze[X, Y] = 'P';
                Console.Write("P");

            }
        }
        public void movePacManDown(char[,] maze, ref int X, ref int Y)
        {
            if (maze[X + 1, Y] == ' ' || maze[X + 1, Y] == '.')
            {
                maze[X, Y] = ' ';
                Console.SetCursorPosition(Y, X);
                Console.Write(" ");
                X = X + 1;
                Console.SetCursorPosition(Y, X);
                if (maze[X, Y] == '.')
                {
                    calculateScore();
                }
                maze[X, Y] = 'P';
                Console.Write("P");

            }
        }

        public void movePacManLeft(char[,] maze, ref int X, ref int Y)
        {
            if (maze[X, Y - 1] == ' ' || maze[X, Y - 1] == '.')
            {
                maze[X, Y] = ' ';
                Console.SetCursorPosition(Y, X);
                Console.Write(" ");
                Y = Y - 1;
                if (maze[X, Y] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(Y, X);
                maze[X, Y] = 'P';
                Console.Write("P");

            }
        }

        public void movePacManRight(char[,] maze, ref int X, ref int Y)
        {
            if (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.')
            {
                maze[X, Y] = ' ';
                Console.SetCursorPosition(Y, X);
                Console.Write(" ");
                Y = Y + 1;
                if (maze[X, Y] == '.')
                {
                    calculateScore();
                }
                Console.SetCursorPosition(Y, X);
                maze[X, Y] = 'P';
                Console.Write("P");

            }
        }
    }
}
