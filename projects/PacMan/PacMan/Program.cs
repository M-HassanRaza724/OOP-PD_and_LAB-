using System;
using System.Threading;
using EZInput;
using System.IO;
using PacMan.BL;
using PacMan.DL;
using PacMan.UI;

namespace PacMan
{
    class Program
    {
        //static int score = 0;
        static void Main(string[] args)
        {
            Pacman pacman = new Pacman();
            PacmanCRUD.pacmans.Add(pacman);
            // PacMan Coordinates

            // Ghost 1 (Horizontal) Information
            Ghost g1 = new Ghost(15,39,"left");
            GhostCRUD.ghosts.Add(g1);
            //char previous1 = ' ';
            //int ghost1X = 15;
            //int ghost1Y = 39;
            //string ghost1direction = "left";
            int count1 = 0;

            // Ghost 2 (Vertical) Information
            Ghost g2 = new Ghost(20, 57, "up");
            GhostCRUD.ghosts.Add(g2);

            //char previous2 = ' ';
            //int ghost2X = 20;
            //int ghost2Y = 57;
            //string ghost2direction = "up";
            int count2 = 0;

            // Ghost 3 (Random) Information
            RandomGhost g3 = new RandomGhost(19, 25);
            RandomGhostCRUD.randomGhosts.Add(g3);
            //char previous3 = ' ';
            //int ghost3X = 19;
            //int ghost3Y = 25;

            // Ghost 4 (Smart) Information
            SmartGhost g4 = new SmartGhost(21, 30);
            SmartGhostCRUD.smartGhosts.Add(g4);
            //char previous4 = ' ';
            //int ghost4X = 21;
            //int ghost4Y = 30;

            //char[,] maze = new char[24, 71];

            MazeCRUD.readData();
            MazeUI.PrintMaze(Maze.GetMaze());

            
            PacManUI.PrintPacman(pacman.GetCoordinates());

            bool gameRunning = true;
            while (true)
            {
                Thread.Sleep(90);
                printScore();
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    pacman.movePacManUp();
                    PacManUI.MovePacman(pacman.GetCoordinates(), "up");
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    pacman.movePacManDown();
                    PacManUI.MovePacman(pacman.GetCoordinates(), "down");
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    pacman.movePacManLeft();
                    PacManUI.MovePacman(pacman.GetCoordinates(), "left");
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    pacman.movePacManRight();
                    PacManUI.MovePacman(pacman.GetCoordinates(), "right");
                }
                count1++;
                count2++;
             
                if (count1 == 5) // Slowest Movement
                {
                    GhostUI.ClearGhost(g1.GetCoordinates(),g1.GetPrevious());
                    gameRunning = g1.MoveGhostInLine();
                    GhostUI.PrintGhost(g1.GetCoordinates());
                    //if (gameRunning)
                    //{
                    //    GhostUI.MoveGhost(g1.GetCoordinates(), g1.GetPrevious(), g1.GetDirection());
                    //}
                    if (gameRunning == false)
                    { break;
                    }
                    count1 = 0;
                }
                if (count2 == 2) // Slow Movement
                {
                    GhostUI.ClearGhost(g2.GetCoordinates(), g2.GetPrevious());
                    gameRunning = g2.MoveGhostInLine();
                    GhostUI.PrintGhost(g2.GetCoordinates());
                    //if (gameRunning)
                    //{
                    //    GhostUI.MoveGhost(g2.GetCoordinates(), g2.GetPrevious(), g2.GetDirection());
                    //}
                    if (gameRunning == false)
                    {
                        break;
                    }
                    count2 = 0;
                }
                GhostUI.ClearGhost(g3.GetCoordinates(), g3.GetPrevious());
                int direction = g3.MoveGhostRandom();
                GhostUI.PrintGhost(g3.GetCoordinates());
                if (direction == -1)
                {
                    gameRunning = false;
                }
                //if (gameRunning)
                //{
                //    GhostUI.MoveGhost(g3.GetCoordinates(), g3.GetPrevious(), g3.GetDirection());
                //}
                if (gameRunning == false)
                {
                    break;
                }
                GhostUI.ClearGhost(g4.GetCoordinates(), g4.GetPrevious());
                gameRunning = g4.MoveGhostSmart();
                GhostUI.PrintGhost(g4.GetCoordinates());
                //if (gameRunning)
                //{
                //    GhostUI.MoveGhost(g4.GetCoordinates(), g4.GetPrevious(), g4.GetDirection());
                //}
                if (gameRunning == false)
                {
                    break;
                }
            }
        }

        static void printScore()
        {
            Console.SetCursorPosition(79, 12);
            Console.WriteLine("Score: " + PacmanCRUD.pacmans[0].GetScore());
        }
        //static int ghostDirection()
        //{
        //    Random r = new Random();
        //    int value = r.Next(4);
        //    return value;
        //}
        //static bool moveGhostRandom(char [,] maze, ref int X, ref int Y, ref char previous)
        //{
        //    if (maze[X, Y - 1] == 'P' || maze[X, Y + 1] == 'P' || maze[X + 1, Y] == 'P' || maze[X - 1, Y] == 'P')
        //    {
        //        return false;
        //    }
        //    int value = ghostDirection();
        //    if (value == 0)
        //    {
        //        if (maze[X, Y - 1] == ' ' || maze[X, Y - 1] == '.' || maze[X, Y - 1] == 'P')
        //        {
        //            maze[X, Y] = previous;
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write(previous);

        //            Y = Y - 1;
        //            previous = maze[X, Y];
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write('G');
        //        }
        //    }
        //    else if (value == 1)
        //    {
        //        if (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.' || maze[X, Y + 1] == 'P')
        //        {
        //            maze[X,Y] = previous;
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write(previous);
        //            Y = Y + 1;
        //            previous = maze[X,Y];
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write('G');
        //        }
        //    }
        //    else if (value == 2)
        //    {
        //        if (maze[X - 1,Y] == ' ' || maze[X - 1,Y] == '.' || maze[X - 1,Y] == 'P')
        //        {
        //            maze[X,Y] = previous;
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write(previous);
        //            X = X - 1;
        //            previous = maze[X,Y];
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write('G');
        //        }
        //    }
        //    else if (value == 3)
        //    {
        //        if (maze[X + 1,Y] == ' ' || maze[X + 1,Y] == '.' || maze[X + 1,Y] == '.')
        //        {
        //            maze[X,Y] = previous;
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write(previous);
        //            X = X + 1;
        //            previous = maze[X,Y];
        //            Console.SetCursorPosition(Y, X);
        //            Console.Write('G');
        //        }
        //    }
        //    return true;
        //}

        //static bool moveGhostSmart(char[,] maze, ref int X, ref int Y, ref char previous, int pX, int pY)
        //{
        //    double[] distance = new double[4] {1000000,1000000,1000000,1000000};
        //    if (maze[X, Y - 1] != '|' && maze[X, Y - 1] != '%' )
        //    {
        //        distance[0] = (calculateDistance(X, Y-1, pX, pY));
        //    }
        //    if (maze[X, Y + 1] != '|' && maze[X, Y + 1] != '%')
        //    {
        //        distance[1] = (calculateDistance(X, Y + 1, pX, pY));
        //    }
        //    if (maze[X + 1, Y] != '|' && maze[X + 1, Y] != '%' && maze[X + 1, Y] != '#')
        //    {
        //        distance[2] = (calculateDistance(X + 1, Y, pX, pY));
        //    }
        //    if (maze[X - 1, Y] != '|' && maze[X - 1, Y] != '%' && maze[X - 1, Y] != '#')
        //    {
        //        distance[3] = (calculateDistance(X - 1, Y, pX, pY));
        //    }
        //    if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
        //    {
        //        string direction = "left";
        //        return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
        //    }
        //    if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
        //    {
        //        string direction = "right";
        //        return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
        //    }
        //    if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
        //    {
        //        string direction = "down";
        //        return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
        //    }
        //    else
        //    {
        //        string direction = "up";
        //        return moveGhostInLine(ref direction, maze, ref X, ref Y, ref previous);
        //    }
        //}

        //static double calculateDistance(int X, int Y, int pX, int pY)
        //{
        //    return Math.Sqrt(Math.Pow((pX - X), 2) + Math.Pow((pY - Y), 2));
        //}

        //static bool moveGhostInLine(ref string direction, char[,] maze, ref int X, ref int Y, ref char previous)
        //{
        //    if (maze[X, Y - 1] == 'P' || maze[X, Y + 1] == 'P' || maze[X + 1, Y] == 'P' || maze[X - 1, Y] == 'P')
        //    {
        //        return false;
        //    }
        //    if (direction == "left" && (maze[X, Y-1] == ' ' || maze[X, Y-1] == '.'))
        //    {
        //        maze[X, Y] = previous;
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write(previous);
                
        //        Y = Y - 1;
               
        //        previous = maze[X, Y];
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write("G");
        //        if(maze[X,Y-1] == '|')
        //        {
        //            direction = "right";
        //        }
        //    }
        //    else if (direction == "right" && (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.'))
        //    {
        //        maze[X, Y] = previous;
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write(previous);
                
        //        Y = Y + 1;
                
        //        previous = maze[X, Y];
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write("G");
        //        if (maze[X, Y+1] == '|')
        //        {
        //            direction = "left";
        //        }
        //    }
        //    else if (direction == "up" && (maze[X-1, Y] == ' ' || maze[X-1, Y] == '.'))
        //    {
        //        maze[X, Y] = previous;
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write(previous);

        //        X = X - 1;

        //        previous = maze[X, Y];
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write("G");
        //        if (maze[X - 1, Y] == '%' || maze[X - 1, Y] == '#')
        //        {
        //            direction = "down";
        //        }
        //    }
        //    else if (direction == "down" && (maze[X + 1, Y] == ' ' || maze[X + 1, Y] == '.'))
        //    {
        //        maze[X, Y] = previous;
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write(previous);

        //        X = X + 1;

        //        previous = maze[X, Y];
        //        Console.SetCursorPosition(Y, X);
        //        Console.Write("G");
        //        if (maze[X + 1, Y] == '%' || maze[X + 1, Y] == '#')
        //        {
        //            direction = "up";
        //        }
        //    }
        //    return true;
        //}



        //static void calculateScore()
        //{
        //    score = score + 1;
        //}

        //static void movePacManUp(char[,] maze, ref int pacman.X, ref int pacman.Y)
        //{
        //    if (maze[pacman.X - 1, pacman.Y] == ' ' || maze[pacman.X - 1, pacman.Y] == '.')
        //    {
        //        maze[pacman.X, pacman.Y] = ' ';
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        Console.Write(" ");
        //        pacman.X = pacman.X - 1;
        //        if (maze[pacman.X, pacman.Y] == '.')
        //        {
        //            calculateScore();
        //        }
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        maze[pacman.X, pacman.Y] = 'P';
        //        Console.Write("P");

        //    }
        //}
        //static void movePacManDown(char[,] maze, ref int pacman.X, ref int pacman.Y)
        //{
        //    if (maze[pacman.X + 1,pacman.Y] == ' ' || maze[pacman.X + 1,pacman.Y] == '.')
        //    {
        //        maze[pacman.X,pacman.Y] = ' ';
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        Console.Write(" ");
        //        pacman.X = pacman.X + 1;
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        if (maze[pacman.X, pacman.Y] == '.')
        //        {
        //            calculateScore();
        //        }
        //        maze[pacman.X, pacman.Y] = 'P';
        //        Console.Write("P");
                
        //    }
        //}

        //static void movePacManLeft(char[,] maze, ref int pacman.X, ref int pacman.Y)
        //{
        //    if (maze[pacman.X,pacman.Y - 1] == ' ' || maze[pacman.X,pacman.Y - 1] == '.')
        //    {
        //        maze[pacman.X,pacman.Y] = ' ';
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        Console.Write(" ");
        //        pacman.Y = pacman.Y - 1;
        //        if (maze[pacman.X, pacman.Y] == '.')
        //        {
        //            calculateScore();
        //        }
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        maze[pacman.X, pacman.Y] = 'P';
        //        Console.Write("P");
                
        //    }
        //}

        //static void movePacManRight(char[,] maze, ref int pacman.X, ref int pacman.Y)
        //{
        //    if (maze[pacman.X,pacman.Y + 1] == ' ' || maze[pacman.X,pacman.Y + 1] == '.')
        //    {
        //        maze[pacman.X,pacman.Y] = ' ';
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        Console.Write(" ");
        //        pacman.Y = pacman.Y + 1;
        //        if (maze[pacman.X, pacman.Y] == '.')
        //        {
        //            calculateScore();
        //        }
        //        Console.SetCursorPosition(pacman.Y, pacman.X);
        //        maze[pacman.X, pacman.Y] = 'P';
        //        Console.Write("P");
                
        //    }
        //}

    
    }
}

