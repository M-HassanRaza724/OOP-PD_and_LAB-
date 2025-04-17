using System.Dynamic;

namespace PacMan.BL
{
    class Ghost
    {
        protected int X;
        protected int Y;
        protected string Direction;
        protected char Previous;

        public Ghost(int x, int y)
        {
            X = x;
            Y = y;
            Previous = ' ';
        }
        public Ghost(int x, int y, string direction)
        {
            X = x;
            Y = y;
            Direction = direction;
            Previous = ' ';
        }
        public void SetGhostDirection(string direction)
        {
            Direction = direction;
        }
        public string GetDirection()
        {
            return Direction;
        }
        public void SetCoordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
        public (int x, int y) GetCoordinates()
        {
            return (X, Y);
        }
        public int GetX()
        {
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public char GetPrevious()
        {
            return Previous;
        }
        public void SetPrevious(char previous)
        {
            Previous = previous;
        }
        public bool MoveGhostInLine()
        {
            char[,] maze = Maze.GetMaze();
            if (maze[X, Y - 1] == 'P' || maze[X, Y + 1] == 'P' || maze[X + 1, Y] == 'P' || maze[X - 1, Y] == 'P')
            {
                return false;
            }
            if (Direction == "left" && (maze[X, Y - 1] == ' ' || maze[X, Y - 1] == '.'))
            {
                Maze.SetMaze(X, Y, Previous);

                Y = Y - 1;

                Previous = Maze.GetMaze()[X, Y];
                if (maze[X, Y - 1] == '|')
                {
                    Direction = "right";
                }
            }
            else if (Direction == "right" && (maze[X, Y + 1] == ' ' || maze[X, Y + 1] == '.'))
            {
                Maze.SetMaze(X, Y, Previous);

                Y = Y + 1;

                Previous = Maze.GetMaze()[X, Y];
                if (maze[X, Y + 1] == '|')
                {
                    Direction = "left";
                }
            }
            else if (Direction == "up" && (maze[X - 1, Y] == ' ' || maze[X - 1, Y] == '.'))
            {
                Maze.SetMaze(X, Y, Previous);

                X = X - 1;

                Previous = Maze.GetMaze()[X, Y];
                if (maze[X - 1, Y] == '%' || maze[X - 1, Y] == '#')
                {
                    Direction = "down";
                }
            }
            else if (Direction == "down" && (maze[X + 1, Y] == ' ' || maze[X + 1, Y] == '.'))
            {
                Maze.SetMaze(X, Y, Previous);

                X = X + 1;

                Previous = Maze.GetMaze()[X, Y];
                if (maze[X + 1, Y] == '%' || maze[X + 1, Y] == '#')
                {
                    Direction = "up";
                }
            }
            return true;
        }

    }
}
