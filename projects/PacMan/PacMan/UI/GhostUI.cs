using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.UI
{
    class GhostUI
    {

        public static void PrintGhost((int x, int y) Position)
        {
            Console.SetCursorPosition(Position.y, Position.x);
            Console.Write("G");
        }
        public static void ClearGhost((int x, int y) Position,char previous)
        {
            Console.SetCursorPosition(Position.y, Position.x);
            Console.Write(previous);
        }
        public static void MoveGhost((int x,int y) Position,char previous, string direction)
        {
            switch (direction)
            {
                case "up":
                    Position.x++;
                    break;
                case "down":
                    Position.x--;
                    break;
                case "left":
                    Position.y++;
                    break;
                case "right":
                    Position.y--;
                    break;
            }
            ClearGhost(Position,previous);
            switch (direction)
            {
                case "up":
                    Position.x--;
                    break;
                case "down":
                    Position.x++;
                    break;
                case "left":
                    Position.y--;
                    break;
                case "right":
                    Position.y++;
                    break;
            }
            PrintGhost(Position);
        }
        public static void MoveGhost((int x, int y) Position, char previous, int direction)
        {
            switch (direction)
            {
                case 0:
                    Position.x++;
                    break;
                case 1:
                    Position.x--;
                    break;
                case 2:
                    Position.y++;
                    break;
                case 3:
                    Position.y--;
                    break;
            }
            ClearGhost(Position,previous);
            switch (direction)
            {
                case 0:
                    Position.x--;
                    break;
                case 1:
                    Position.x++;
                    break;
                case 2:
                    Position.y--;
                    break;
                case 3:
                    Position.y++;
                    break;
            }
            PrintGhost(Position);
        }
    }
}

