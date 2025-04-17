using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.UI
{
        class PacManUI
        {
            public static void PrintPacman((int x, int y) Position)
            {
                Console.SetCursorPosition(Position.y, Position.x);
                Console.Write("P");
            }
            public static void ClearPacman((int x, int y) Position)
            {
                Console.SetCursorPosition(Position.y, Position.x);
                Console.Write(" ");
            }
            public static void MovePacman((int x, int y) Position, string direction)
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
            ClearPacman(Position);
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
                PrintPacman(Position);
            }
        }
}
